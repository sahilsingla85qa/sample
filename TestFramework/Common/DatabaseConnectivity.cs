using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMHC_Automation.Common
{
    class DatabaseConnectivity: TestBase
    {

        // Method to read data from SQL and return the data to be used in the calling functions in a List Array
        public static List<string> method_ReadOneColumnDataSQLTable(string str_Query)
        {
            List<string> arr_ReturnSQLData = new List<string>();

            try
            {
                string DatabaseServer = CommonFunctions.FetchStringValueFromAppConfigFile("DatabaseServer");
                string DatabaseName = CommonFunctions.FetchStringValueFromAppConfigFile("DatabaseName");

                string connection_string = "Data Source = " + DatabaseServer + "; Initial Catalog = " + DatabaseName + ";Integrated Security = SSPI";

                string query = str_Query;

                SqlConnection cn = new SqlConnection(connection_string);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    arr_ReturnSQLData.Add(Convert.ToString(dr[0]));
                }

                Console.WriteLine("\nData stored in List array is as below:");
                foreach (string str_Value in arr_ReturnSQLData)
                    Console.WriteLine(str_Value);

                cn.Close();
                dr.Close();
                Console.WriteLine("Function method_ReadOneColumnDataSQLTable executed successfully on the database table.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Function method_ReadOneColumnDataSQLTable failed");
            }
            return (arr_ReturnSQLData);
        }

        // Method to update Table in SQL using sql query
        public static void method_ExecuteSqlQueryToUpdateTable(string strQuery)
        {
            try
            {
                string DatabaseServer = CommonFunctions.FetchStringValueFromAppConfigFile("DatabaseServer");
                string DatabaseName = CommonFunctions.FetchStringValueFromAppConfigFile("DatabaseName");

                string connection_string = "Data Source = " + DatabaseServer + "; Initial Catalog = " + DatabaseName + ";Integrated Security = SSPI";

                SqlConnection cn = new SqlConnection(connection_string);
                cn.Open();
                SqlCommand cmd = new SqlCommand(strQuery, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                //WriteExecLog("Function method_ExecuteSqlQueryToUpdateTable executed successfully on the database table.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.ToString());
               // WriteErrorLog("Function method_ExecuteSqlQueryToUpdateTable failed");
            }
        }

        // Method to execute stored procedure
        public static void method_ExecuteStoredProcedure()
        {
            try
            {
                string DatabaseServer = CommonFunctions.FetchStringValueFromAppConfigFile("DatabaseServer");
                string DatabaseName = CommonFunctions.FetchStringValueFromAppConfigFile("DatabaseName");

                string connection_string = "Data Source = " + DatabaseServer + "; Initial Catalog = " + DatabaseName + ";Integrated Security = SSPI";
                SqlCommand cmd;

                using (SqlConnection con = new SqlConnection(connection_string))
                {
                    using (cmd = new SqlCommand("WriteResultsToDB", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@USERNAME", UserName);
                        cmd.Parameters.AddWithValue("@SUITE_NAME", strTestSuite);
                        cmd.Parameters.AddWithValue("@TEST_ID", strTestCase);
                        cmd.Parameters.AddWithValue("@TEST_DESC", testDescription);
                        cmd.Parameters.AddWithValue("@TEST_ENVIRONMENT_INFO", "Win7, Chrome");
                        cmd.Parameters.AddWithValue("@COMPLEXITY", complexity);
                        cmd.Parameters.AddWithValue("@RUN_ID", runID);
                        cmd.Parameters.AddWithValue("@RUN_DATE_TIME", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TEST_STATUS", Outcome);
                        cmd.Parameters.AddWithValue("@REMARKS", ReasonForFailure);
                        cmd.Parameters.AddWithValue("@EXPECTED_TIME", estimatedTime);
                        cmd.Parameters.AddWithValue("@ACTUAL_TIME", elapsedTime);
                        cmd.Parameters.AddWithValue("@SCREENSHOT_REF", ErrorScreenshotPath); 
                        cmd.Parameters.AddWithValue("@PROJECT_ID", "MMMHC");

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                //WriteExecLog("Function method_ExecuteStoredProcedure executed successfully on the database table.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.ToString());
                //WriteErrorLog("Function method_ExecuteStoredProcedure failed");
            }
        }
    }
}
