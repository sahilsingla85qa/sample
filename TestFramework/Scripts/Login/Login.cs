using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MMMHC_Automation.Common;
using RelevantCodes.ExtentReports;
using Excel.Log;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace UnitTestProject1
{
    [CodedUITest]
    public class Login : TestBase
    {
       

      [TestMethod]
        public void checklogin()
        {
            try
            {

                string path = @"C:\WINDOWS\System32\calc.exe";
                ApplicationUnderTest application = ApplicationUnderTest.Launch(path);
                WinWindow mainWindow = new WinWindow();
                mainWindow.SearchProperties.Add(WinWindow.PropertyNames.Name, "Calculator");
                mainWindow.WindowTitles.Add("Calculator");




                WinButton btnSeven = new WinButton(mainWindow);
                btnSeven.SearchProperties.Add(WinButton.PropertyNames.Name, "7");
                WinButton btneight = new WinButton(mainWindow);
                btneight.SearchProperties.Add(WinButton.PropertyNames.Name, "8");
                WinButton btnmulti = new WinButton(mainWindow);
                btnmulti.SearchProperties.Add(WinButton.PropertyNames.Name, "Multiply");
                btnmulti.WindowTitles.Add("Calculator");
                WinButton btnequals = new WinButton(mainWindow);
                btnequals.SearchProperties.Add(WinButton.PropertyNames.Name, "Equals");
                btnSeven.WindowTitles.Add("Calculator");

                Assert.IsTrue(false);

                Mouse.Click(btnSeven);
                Mouse.Click(btnmulti);
                Mouse.Click(btneight);
                Mouse.Click(btnequals);

                StartReport();
                test = extent.StartTest("DemoReportPass");               
                //driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 500));
                //WaitForElementPresentAndEnabled(By.XPath(ElementsRepository.username_input),500);
                //ElementActions.EnterText(ElementActions.ObjectProperty.XPath, ElementsRepository.username_input, "dff");
                //WaitForElementPresentAndEnabled(By.XPath(ElementsRepository.password_input), 500);
                //ElementActions.EnterText(ElementActions.ObjectProperty.XPath, ElementsRepository.password_input, "sdfdsf");
                //WaitForElementPresentAndEnabled(By.XPath(ElementsRepository.login_btn), 500);
                //ElementActions.ClickElement(ElementActions.ObjectProperty.XPath, ElementsRepository.login_btn);
                //WaitForElementPresentAndEnabled(By.XPath(ElementsRepository.ok_btn), 500);              
                // Assert.IsTrue(driver.FindElement(By.XPath("//h2[contains(.,'Login failed')]")).Displayed);
                test.Log(LogStatus.Pass, "MSg is displayed");

                application.Close();

            }

            catch(Exception ex)
            {
               
                test.Log(LogStatus.Fail, "Snapshot below: " + test.AddScreenCapture(Capture("ScreenShotName"+ "checklogin ")));
                log.Info("Test Failed");
                Assert.Fail();

            }

            finally
            {

                
               // Cleanup();
                EndReport();
                              
            }
        }

        [TestMethod]
        public void checklogin1()
        {
            Console.WriteLine("TEST1");

        }


    }
}
