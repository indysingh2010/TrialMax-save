using FTI.Shared.Trialmax;
using FTI.Trialmax.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FTI.Trialmax.TmaxManager
{
    class Program
    {
        /// <summary>The main entry point for the application</summary>
        [STAThread]
        static void Main(string[] args)
        {
            FTI.Trialmax.Forms.CFSplashScreen splashScreen = null;
            var lst = new List<string>(args);
            lst.Remove("/max");
            lst.Remove("/multi");
            string[] newArgs = lst.ToArray();

            bool multiInstance = args.Any("/multi".Contains);

                try
                {
                //	Activate previous instance if there is one
                if (!multiInstance && CTmaxInstanceManager.GetPrevInstance(TmaxApplications.TmaxManager) == true)
                {
                    lst.Remove("/showreg");
                    newArgs = lst.ToArray();
                    CTmaxInstanceManager.ActivatePrevInstance(newArgs, TmaxApplications.TmaxManager);
                }
                else
                {
                    splashScreen = new CFSplashScreen();
                    splashScreen.Start();
                    splashScreen.SetMessage("Starting TmaxManager");
                    var f = new TmaxManagerForm(newArgs, splashScreen);
                    // Screen 0 = middle, 1 = left, 2 = right
                    if (args.Any("/max".Contains))
                    {
                        f.WindowState = FormWindowState.Maximized;
                        // NOTE default property of CenterScreen will center to display where mouse is !!
                    }
                    try
                    {
                        Application.Run(f);
                    }
                    catch (System.ObjectDisposedException)
                    {
                    }
                }

            }
            catch (System.DllNotFoundException e)
            {
                MessageBox.Show(e.Message, "Dll Not Found Exception");
            }
            catch (System.IO.FileNotFoundException e)
            {
                if ((e.FileName != null) && (e.FileName.Length > 0))
                    MessageBox.Show(e.Message + ": " + e.FileName, "File Not Found Exception");
                else
                    MessageBox.Show(e.ToString(), "File Not Found Exception");
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString(), "System Exception");
            }
            finally
            {
                if (splashScreen != null)
                    splashScreen.Stop();
            }
        }// static void Main() 

    } // class
} // namespace

