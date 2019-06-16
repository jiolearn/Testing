using Employee.Services;
using Xunit;
using ExcelDataReader;
using System.IO;
using System.Data;
//using Excel=Microsoft.Office.Tools.Excel;
using System;
using System.Collections.Generic;

namespace Test
{

    

    public class TestClass
    {
              
        
        public static IEnumerable<object[]> GridValues()
        {

            return Service.ReadValues();

           
        }



        [Theory]
        [MemberData(nameof(GridValues))]
        public void TestService(int basic, int super, int expected)
        {
            

            Service sc = new Service();

            sc.ReadExcel();
            
            int total = sc.AddSalary(basic, super);

            Assert.Equal(total, expected);
        }
        
    }
}
