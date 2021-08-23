﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;

using FTI.Shared;
using FTI.Shared.Win32;
using FTI.Shared.Trialmax;
using FTI.Trialmax.Forms;

using Tmdata;
using Ghostscript.NET;
using Ghostscript.NET.Rasterizer;
using Ghostscript.NET.Processor;

using iTextSharp.text.pdf;
using System.IO;
using System.Runtime.InteropServices;


namespace FTI.Trialmax.Database
{
    /// <summary>This class manages the import operations using GhostScript.NET wrapper for Ghostscript</summary>
    public class CTmaxGsPdfManager
    {
        #region Constants

        #endregion Constants

        #region Private Members

        /// <summary>Local path where to output files</summary>
        private string m_outputPath = string.Empty;

        /// <summary>Local path where the document is present</summary>
        private string m_documentNameWithPath = string.Empty;

        /// <summary>Number of threads to be used. If set to 0, auto manage</summary>
        private short m_totalThreads;

        /// <summary>Flag that tells whether to convert files or not</summary>
        private TmaxPDFOutputType m_OutputType = TmaxPDFOutputType.ForceColor;

        private int m_PageCount = 0;

        /// <summary>Reference to the Ghostscript.dll to use</summary>
        private GhostscriptVersionInfo m_gvi = null;

        /// <summary>List of switches to be passed for GS Processing</summary>
        private List<string> m_switches = null;

        /// <summary>Resolution for Output images</summary>
        private short m_resolution;

        /// <summary>Flag that tells whether to convert files or not</summary>
        private volatile bool DoConvert = true;

        /// <summary>Local variable for GhostScriptProcessor that processes files so we can stop it any time</summary>
        private GhostscriptProcessor processor = null;

        /// <summary>Local variable to log detail errors with stacktrace</summary>
        private static readonly log4net.ILog logDetailed = log4net.LogManager.GetLogger("DetailedLog");

        /// <summary>Local variable to log user level details</summary>
        private static readonly log4net.ILog logUser = log4net.LogManager.GetLogger("UserLog");

        private bool m_DisableCustomDither = true;

        private bool m_IsExtracted = false;

        #endregion Private Members

        #region Public Members

        /// <summary> Notify Parent to update Progress bar on a single task completion </summary>
        public event EventHandler notifyPDFManager;


        /// <summary>Notify the RegOptionsForm to update the statusbar</summary>
        public event EventHandler notifyRegOptionsForm;

        #endregion Public Members

        #region Public Methods

        ///<summary>Constructor</summary>
        public CTmaxGsPdfManager(string docPath, string outPath, TmaxPDFOutputType OutputType, short outResolution = 0, bool disableCustomDither = false, short totThreads = 0)
        {
            m_documentNameWithPath = docPath;
            m_outputPath = outPath;
            m_totalThreads = totThreads;
            m_resolution = outResolution;
            m_OutputType = OutputType;
            m_DisableCustomDither = disableCustomDither;
            m_switches = new List<string>();
            InitializeGhostScript();
            AddRequiredSwitches();
        }// public CTmaxGsPdfManager(string docPath, string outPath, short outResolution = 0, short totThreads = 0)

        ///<summary>Start the conversion process using Ghostscript</summary>
        public bool Process()
        {
            try
            {
                processor = new GhostscriptProcessor(m_gvi, true);
                processor.Processing += new GhostscriptProcessorProcessingEventHandler(processor_Processing);
                processor.StartProcessing(m_switches.ToArray(), null);

            }
            catch (Exception ex)
            {
                logDetailed.Error(ex.ToString());
                StopProcess();
                return false;
            }
            return true;
        }// public bool Process()

        ///<summary>Process the document page by page</summary>
        public bool ProcessPage(int pageNum, short m_CustomDPI)
        {
            try
            {
                //ProcessPNG(pageNum, m_CustomDPI);
            }
            catch (Exception Ex)
            {
                logDetailed.Error(Ex.ToString());
                StopProcess();
                return false;
            }
            return true;
        }

        public void ExtractPNG()
        {
            using (processor = new GhostscriptProcessor(m_gvi, true))
            {
                SetColorSwitch(true);
                // Set 200 dpi as default -BW is converted in the next condition.
                SetResolutionSwitch(true);
                processor.Processing += new GhostscriptProcessorProcessingEventHandler(processor_Processing);
                processor.StartProcessing(m_switches.ToArray(), null);
                // Extraction successfully completed
                m_IsExtracted = true;
            }
        }

        ///<summary>TmaxPdfManager signalled to stop the conversion process</summary>
        public void StopProcess()
        {
            try
            {
                DoConvert = false;
                if (processor != null)
                {
                    processor.StopProcessing();
                    while (processor.IsRunning) // Wait until processor stops and then proceed
                    {
                        Thread.Sleep(1000);
                    }
                    processor.Dispose();
                }
            }
            catch (Exception Ex)
            {
                logDetailed.Error(Ex.ToString());
            }
        }// public void StopProcess()

        ///<summary>Release all resources used by this class</summary>
        public void Dispose()
        {
            try
            {
                if (processor != null)
                {
                    processor.StopProcessing();
                    while (processor.IsRunning) // Wait until processor stops and then proceed
                    {
                        Thread.Sleep(1000);
                    }
                    processor.Dispose();
                }
            }
            catch (Exception Ex)
            {
                logDetailed.Error(Ex.ToString());
            }
        }// public void Dispose()

        public int GetTotalPages()
        {
            return m_PageCount;
        }

        #endregion Public Methods

        #region Private Methods

        ///<summary>Initializes the Ghostscript dll that will be used</summary>
        private bool InitializeGhostScript()
        {
            //m_gvi = GhostscriptVersionInfo.GetLastInstalledVersion();
            try
            {
                m_gvi = new GhostscriptVersionInfo(@"PDFManager\gsdll32.dll");

                PdfReader pdfFile = new PdfReader(m_documentNameWithPath);
                m_PageCount = pdfFile.NumberOfPages;
                pdfFile.Close();
            }
            catch (Exception Ex)
            {
                logDetailed.Error(Ex.ToString());
            }
            return !(m_gvi == null);
        }// private bool InitializeGhostScript()

        ///<summary>Add all required switch for output</summary>
        private void AddRequiredSwitches()
        {
            try
            {
                AddDefaultSwitches();
                AddColorSwitch();
                AddResolutionSwitch();
                AddOutputSwitch();
                if (m_DisableCustomDither == false && m_OutputType == TmaxPDFOutputType.ForceBW)
                    AddCustomDitherSwitch();
                AddPdfOpenSwitch();
                //AddErrorLogSwitch();
            }
            catch (Exception Ex)
            {
                logDetailed.Error(Ex.ToString());
            }
        }// private void AddRequiredSwitches()

        ///<summary>Add default switch for output</summary>
        private void AddDefaultSwitches()
        {
            m_switches.Add("-dSAFER");
            m_switches.Add("-dNumRenderingThreads=2");
            m_switches.Add("-dBATCH");
            m_switches.Add("-dUseCropBox");
            m_switches.Add("-dNOPAUSE");
            m_switches.Add("-sPDFPassword=\"\"");
        }// private void AddDefaultSwitches()

        ///<summary>Add color switch for output</summary>
        private void AddColorSwitch()
        {
            if (m_OutputType == TmaxPDFOutputType.ForceColor)
                m_switches.Add("-sDEVICE=png16m");
            else
                m_switches.Add("-sDEVICE=tiffg4");
        }// private void AddColorSwitch()

        private void SetColorSwitch(bool isColor)
        {
            if (isColor)
            {
                m_switches[6] = "-sDEVICE=png16m";
            }
            else
            {
                m_switches[6] = "-sDEVICE=tiffg4";
            }
        }// public bool ProcessPage(int pageNum)

        ///<summary>Add resolution switch for output</summary>
        private void AddResolutionSwitch()
        {
            if (m_resolution == 0)
            {
                if (m_OutputType == TmaxPDFOutputType.ForceBW)
                    m_switches.Add("-r300");
                else
                    m_switches.Add("-r200");
                return;
            }
            m_switches.Add("-r" + m_resolution);
        }// private void AddResolutionSwitch()

        ///<summary>Add output target switch</summary>
        private void AddOutputSwitch()
        {
            if (m_OutputType == TmaxPDFOutputType.ForceBW)
            {
                m_switches.Add(@"-sOutputFile=" + m_outputPath + "\\%04d.tif");
                if (m_DisableCustomDither == false)
                {   // Add Custom Dither Switches
                    AddCustomDitherSwitch();
                }
            }
            else
                m_switches.Add(@"-sOutputFile=" + m_outputPath + "\\%04d.png");
        }// private void AddOutputSwitch()

        ///<summary>Add Tiff Custom Dither Switch</summary>
        private void AddCustomDitherSwitch()
        {
            m_switches.Add(@"-c");
            m_switches.Add("{ 0.2 sub 0.6 div }");
            m_switches.Add("settransfer");
            m_switches.Add("-f");
        }// private void AddOutputSwitch()

        ///<summary>Add PDF open switch</summary>
        private void AddPdfOpenSwitch()
        {
            m_switches.Add(m_documentNameWithPath);
        }// private void AddPdfOpenSwitch()

        ///<summary>Add error logging switch</summary>
        private void AddErrorLogSwitch()
        {
            m_switches.Add(">> \"" + m_outputPath + "\\conv.tmp");
            m_switches.Add("2>> \"" + m_outputPath + "\\conv.err");
        }// private void AddErrorLogSwitch()

        ///<summary>Progress of the current task if performing any</summary>
        private void processor_Processing(object sender, GhostscriptProcessorProcessingEventArgs e)
        {
            if (notifyPDFManager != null)
                notifyPDFManager(sender, e);
            //Console.WriteLine(e.CurrentPage.ToString() + " / " + e.TotalPages.ToString());
        }// private void processor_Processing(object sender, GhostscriptProcessorProcessingEventArgs e)

        ///<summary>Add PDF open switch</summary>
        private void AddPageSwitch(int pageNum, bool isColor)
        {
            m_switches.Insert(8,"-dFirstPage=" + pageNum);
            m_switches.Insert(9,"-dLastPage=" + pageNum);
            if (isColor)
            {
                m_switches[10] = @"-sOutputFile=" + m_outputPath + "\\" + pageNum.ToString("D4") + ".png";
            }
            else
            {
                m_switches[10] = @"-sOutputFile=" + m_outputPath + "\\" + pageNum.ToString("D4") + ".tif";
                if (m_DisableCustomDither == false)
                {   // Add Custom Dither Switches
                    m_switches.Insert(m_switches.Count - 1, @"-c");
                    m_switches.Insert(m_switches.Count - 1, "{ 0.2 sub 0.6 div }");
                    m_switches.Insert(m_switches.Count - 1, "settransfer");
                    m_switches.Insert(m_switches.Count - 1, "-f");
                }
            }
        }// private void AddPageSwitch(int pageNum)

        ///<summary>Remove Page Switch</summary>
        private void RemovePageSwitch(bool isColor)
        {
            if (m_switches[8].Contains("-dFirstPage="))
            {
                m_switches.RemoveAt(8);
                m_switches.RemoveAt(8);
            }
            if (!isColor && !m_DisableCustomDither)
            {   // Remove Custom Dither Switches
                m_switches.RemoveAt(m_switches.Count - 2);
                m_switches.RemoveAt(m_switches.Count - 2);
                m_switches.RemoveAt(m_switches.Count - 2);
                m_switches.RemoveAt(m_switches.Count - 2);
            }
        }// private void RemovePageSwitch()

        ///<summary>Set Resolution Switch</summary>
        private void SetResolutionSwitch(bool isColor)
        {
            if (m_resolution == 0)
            {
                var index = m_switches.FindIndex(x => x.StartsWith("-r"));
                if (isColor)
                {  
                    m_switches[index] = "-r200";
                    return;
                }
                m_switches[index] = "-r300";
                return;
            }
        }// private void SetResolutionSwitch()

        private void UpdateRegStatusBar(object sender, EventArgs e)
        {
            if (notifyRegOptionsForm != null)
                notifyRegOptionsForm(sender, e);
        }// protected void UpdateRegStatusBar(object sender, EventArgs e)

        #endregion Private Methods

        #region Properties

        #endregion Properties


        
    }// public class CTmaxGsPdfManager
}// namespace FTI.Trialmax.Database
