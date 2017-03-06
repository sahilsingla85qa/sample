using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Excel;

namespace MMMHC_Automation.Common
{
    //Description of ExcelUtility.
    public class ExcelUtility : TestBase
    {
        public static DataTable ExcelToDataTable(string fileName, string sheet)
        {
            try
            {
                //open file and returns as Stream
                FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                //Createopenxmlreader via ExcelReaderFactory
                IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream); //.xls
                                                                                              //Set the First Row as Column Name
                excelReader.IsFirstRowAsColumnNames = true;
                //Return as DataSet
                DataSet result = excelReader.AsDataSet();
                //Get all the Tables
                DataTableCollection table = result.Tables;
                //Store it in DataTable
                DataTable resultTable = table[sheet];

                TestDataTable = resultTable;

                if (excelReader != null)
                    excelReader.Close();

                if (stream != null)
                    stream.Close();

                return resultTable;
            }
            catch
            {
                return null;
            }
        }

        public static List<Datacollection> dataCol = new List<Datacollection>();

        public static DataTable PopulateInCollection(string fileName, string sheet = "Sheet1")
        {
            try
            {
                dataCol = new List<Datacollection>();

                DataTable table = ExcelToDataTable(excelPath + fileName, sheet);

                //Iterate through the rows and columns of the Table
                for (int row = 1; row <= table.Rows.Count; row++)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        Datacollection dtTable = new Datacollection()
                        {
                            rowNumber = row,
                            colName = table.Columns[col].ColumnName,
                            colValue = table.Rows[row - 1][col].ToString()
                        };
                        //Add all the details for each row
                        dataCol.Add(dtTable);
                    }
                }

                return table;
            }
            catch
            {
                return null;
            }
        }

        public static string ReadData(string columnName, bool rowNo = false)
        {
            int rowNumber = 1;

            try
            {
                if (!rowNo)
                {
                    for (int i = 0; i < dataCol.Count; i++)
                    {
                        if (dataCol[i].colValue == currentClass)
                        {
                            rowNumber = dataCol[i].rowNumber;
                            break;
                        }
                    }
                }
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).FirstOrDefault();

                if (data == "Yes")
                    data = "true";
                else if (data == "No")
                    data = "false";

                return data.ToString();
            }
            catch
            {
                return null;
            }
        }
    }

    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }
}
