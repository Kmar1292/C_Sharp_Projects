using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employees
    {
        public int Id { get; set; }

        public static bool operator== (Employees employeeOne, Employees employeeTwo)
        {
            if (employeeOne.Id == employeeTwo.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employees employeeOne, Employees employeeTwo)
        {
            if (employeeOne.Id != employeeTwo.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
