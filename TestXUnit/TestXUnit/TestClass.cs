using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitDemo;

namespace Test
{
    public class TestClass
    {
        [Theory]
        [InlineData(10000, 20000, 30000)]
        [InlineData(10000, 20000, 50000)]
        public void TestService(int basic, int super, int expected)
        {
            Service sc = new Service();
            
            int total = sc.AddSalary(basic, super);

            Assert.Equal(total, expected);
        }
        
    }
}
