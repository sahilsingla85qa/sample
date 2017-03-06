using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Linq;
using MMMHC_Automation.Common;

namespace MMMHC_Automation.Common
{
    public class CommonFunctions: TestBase
    {
        //Below function is used to fetch string value from App config file
        public static string FetchStringValueFromAppConfigFile(string NameOFTheKeyInAppConfigFile)
        {
            try
            {
                //Declare a object for App.config file
                AppSettingsReader appcon = new AppSettingsReader();

                //Fetch the value from App.config file
                string key = appcon.GetValue(NameOFTheKeyInAppConfigFile, typeof(string)).ToString();

                //Dispose the object
                appcon = null;

                //Return the value
                return key;
            }
            catch
            {
                return null;
            }
        }

        //Below function is used to fetch int value from App config file
        public static int FetchIntValueFromAppConfigFile(string NameOFTheKeyInAppConfigFile)
        {
            try
            {
                //Declare a object for App.config file
                AppSettingsReader appcon = new AppSettingsReader();

                //Fetch the value from App.config file
                int key = Convert.ToInt32(appcon.GetValue(NameOFTheKeyInAppConfigFile, typeof(string)).ToString());

                //Dispose the object
                appcon = null;

                //Return the value
                return key;
            }
            catch
            {
                return 0;
            }
        }

        //Function used to generate Random string
        public static string method_GenerateRandomData()
        {
            try
            {
                var chars = "0123456789";
                var random = new Random();
                var result = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
                return result;
            }
            catch
            {
                return null;
            }
        }

        
    }
}
