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
            lst.Remove("/nomax");
            string[] newArgs = lst.ToArray();

            try
            {
                //	Activate previous instance if there is one
                if (CTmaxInstanceManager.GetPrevInstance(TmaxApplications.TmaxManager) == true)
                {
                    CTmaxInstanceManager.ActivatePrevInstance(args, TmaxApplications.TmaxManager);
                }
                else
                {
                    splashScreen = new CFSplashScreen();
                    splashScreen.Start();
                    splashScreen.SetMessage("Starting TmaxManager");
                    var f = new TmaxManagerForm(newArgs, splashScreen);
                    if (args.Any("/nomax".Contains))
                    {
                        f.WindowState = FormWindowState.Normal;

                        //f.StartPosition = FormStartPosition.CenterScreen;
                        //Screen 1 = left, 0 = middle, 2 = right
                        f.StartPosition = FormStartPosition.Manual;   // need this for location to work
                        f.Location = Screen.AllScreens[2].WorkingArea.Location;
                        f.Top += 80;
                        f.Left += 110;
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

