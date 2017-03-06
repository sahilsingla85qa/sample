//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.TeamFoundation.Client;
//using Microsoft.TeamFoundation.TestManagement.Client;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.TeamFoundation.WorkItemTracking.Client;

//namespace MMMHC_Automation.Common
//{
//    class MTMIntegration: TestBase
//    {
//        public static Boolean UpdateResultsByID()
//        {
//            try
//            {
//                int testPlanId = 7115;
//                int testCaseID = Convert.ToInt16(strTestCase.Split('_')[2].Substring(2));
//                String TFSCollectionURI = "http://almdev.dev.pr.mmmhc.com:8080/tfs/Connectivity/";
//                String ProjectName = "ITConnectivity";
//                TfsTeamProjectCollection tfs = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(TFSCollectionURI));
//                ITestManagementService service = tfs.GetService<ITestManagementService>();
//                ITestManagementTeamProject project = service.GetTeamProject(ProjectName);
//                ITestPlan CurrentPlan = project.TestPlans.Find(testPlanId);
//                ITestRun CurrentRun = CurrentPlan.CreateTestRun(true);
//                string getAllTestPoints = "SELECT * FROM TestPoint WHERE TestCaseID = '" + testCaseID + "'";
//                ITestPointCollection points = CurrentPlan.QueryTestPoints(getAllTestPoints);
//                CurrentRun.AddTestPoints(points, CurrentPlan.Owner);
//                CurrentRun.Save();
//                ITestCaseResult result = CurrentRun.QueryResults()[0];
//                result.Outcome = returnTestOutCome(Outcome);
//                result.RunBy = CurrentRun.Owner;

//                if (!(result.Outcome == TestOutcome.Error))
//                {
//                    result.State = TestResultState.Completed;
//                }

//                result.Save(true);
//                CurrentRun.Save();
//                CurrentRun.Refresh();
//                WriteExecLog("Updated the test result in MTM for TC: " + testCaseID);

//                return true;

//            }
//            catch (Exception e)
//            {
//                WriteErrorLog("Error updating the test result" + e.Message);
//                return false;
//            }
//        }

//        private static TestOutcome returnTestOutCome(string outcome)
//        {
//            try
//            {
//                switch (outcome)
//                {
//                    case "Pass":
//                        return TestOutcome.Passed;
//                    case "Fail":
//                        return TestOutcome.Failed;
//                    default:
//                        return TestOutcome.Error;

//                }
//            }
//            catch
//            {
//                return TestOutcome.None;
//            }
//        }
    
//    }
//}
