using System;
using System.IO;
using System.Diagnostics;
//using Microsoft.Office.Interop.Excel;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;
using System.Drawing.Imaging;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace MMMHC_Automation.Common
{
    // Description of TestBase.
    public class TestBase
    {
        public static Stopwatch watch;
        public static double elapsedTime;
        public static string Outcome;
        public static string ReasonForFailure;
        public static string ErrorScreenshotPath;
        public static string strTestSuite;
        public static string strTestCase;
        public static string testDescription;
        public static string complexity;
        public static string estimatedTime;
        public static int runID;
        public static string currentClass;
        public static string URL = CommonFunctions.FetchStringValueFromAppConfigFile("URL");
        public static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public static string excelPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\TestData\Excel\";
        public static string MachineName = Environment.MachineName;
        public static string UserName = Environment.UserName;
        public static string UserDomain = Environment.UserDomainName;        
        public static ExtentReports extent;
        public static ExtentTest test;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string errorScreenshotPath
        {
            get
            {
                return ErrorScreenshotPath;
            }
            set
            {
                ErrorScreenshotPath = value;
            }
        }


        private static System.Data.DataRow testDataRow;
        public static System.Data.DataRow TestDataRow
        {
            get
            {
                return testDataRow;
            }
            set
            {
                testDataRow = value;
            }
        }

        private static System.Data.DataTable testDataTable;
        public static System.Data.DataTable TestDataTable
        {
            get
            {
                return testDataTable;
            }
            set
            {
                testDataTable = value;
            }
        }

        public void StartReport()
        {
            

            string reportPath = projectPath + @"\ExtentReport\MyReport.html";         
            string ConfigReportPath = projectPath + @"\ExtentReportConfiguration\";          

            extent = new ExtentReports(reportPath, true);
            extent
            .AddSystemInfo("Host Name", "Sahil")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Sahil Singla");
            extent.LoadConfig(ConfigReportPath + "extent-config.xml");
        }

      
        public void EndReport()
        {
            extent.EndTest(test);
            extent.Flush();
            extent.Close();
            
        }

     
       

        //Get the screenshot
        //public static string Capture(IWebDriver driver, string screenShotName)
        //{
        //    ITakesScreenshot ts = (ITakesScreenshot)driver;
        //    Screenshot screenshot = ts.GetScreenshot();
        //    //string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        //    //string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "ErrorScreenshots\\" + screenShotName + ".png";
        //    //string localpath = new Uri(finalpth).LocalPath;
        //    string ErrorScreenShotPath = projectPath + @"\ErrorScreenshots\"+screenShotName +".png";
        //    screenshot.SaveAsFile(ErrorScreenShotPath, ImageFormat.Png);
        //    return ErrorScreenShotPath;
        //}


    


        
       
        // Function to kill execl insatnce
        public static void KillExcel()
        {
            try
            {
                foreach (Process process in Process.GetProcesses())
                    if (process.ProcessName.Equals("EXCEL"))
                        process.Kill();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        //return imagepath as string
        public static string Capture(string screenShotName)
        {
            Image SubmissionPic = UITestControl.Desktop.CaptureImage();

            var stream = new System.IO.MemoryStream();
            SubmissionPic.Save(stream, ImageFormat.Png);         

            string ErrorScreenShotPath = projectPath + @"\ErrorScreenshots\" + screenShotName + ".png";
           
            return ErrorScreenShotPath;
        }

        // Function to cleanup
        public static void Cleanup()
        {
            //try
            //{
            //    if (Outcome == "Pass")
            //    {
            //        WriteExecLog("Test Case Passed!");
            //        errorScreenshotPath = String.Empty;
            //        ReasonForFailure = String.Empty;
            //    }
            //    else if (Outcome == "Fail")
            //    {
            //        WriteExecLog("Test Case Failed!");
            //        WriteErrorLog("Test Case Failed!");
            //    }

            //    if (driver != null)
            //        driver.Quit();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

       

       
       

        
    }
}
