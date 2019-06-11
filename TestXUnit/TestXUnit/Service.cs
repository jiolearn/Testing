using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitDemo
{
    public class Service
    {
        public int AddSalary(int basic,int super)
        {
            int total = basic + super;
            return total;
        }
    }
}
