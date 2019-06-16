using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Employee.Services
{
    public class Service
    {
        

        public int AddSalary(int basic, int super)
        {
            int total = basic + super;
            return total;
        }

        public StreamReader ReadExcel()
        {
            var reader = new StreamReader(@"E:\Learn\TestXUnit\SalTest.csv");
            

                return reader;
            
        }

        public static IEnumerable<object[]> ReadValues()
        { 

            List<object[]> ExcelDataValues=new List<object[]>();

            var reader = new StreamReader(@"E:\Learn\TestXUnit\SalTest.csv");


            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                //var values = line.Split(',');
                //ExcelDataValues.Add(new object[] { line });

               string[]  lineVal = line.Split(',');

                yield return new object[] { lineVal[0], lineVal[1], lineVal[2] };
            }

            //return ExcelDataValues;
        }

        

    }
}
