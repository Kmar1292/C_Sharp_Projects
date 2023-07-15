using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var EmployeeList = new List<Employees>()
            {
                new Employees{FirstName = "Todd", LastName = "Gardner", Id = 0},
                new Employees{FirstName = "Joe", LastName = "Frazier", Id = 1},
                new Employees{FirstName = "Kevin", LastName = "Mar", Id = 2},
                new Employees{FirstName = "Andrew", LastName = "King", Id = 3 },
                new Employees{FirstName = "Joe", LastName = "Williams", Id = 4},
                new Employees{FirstName = "Melissa", LastName = "Reyes", Id = 5},
                new Employees{FirstName = "Lena", LastName = "Yee", Id = 6},
                new Employees{FirstName = "Joe", LastName = "Johnson", Id = 7},
                new Employees{FirstName = "Justin", LastName = "Blake", Id = 8},
                new Employees{FirstName = "James", LastName = "Hafner", Id = 9}
            };

            List<Employees> JoeList = new List<Employees>();
            foreach (Employees employee in EmployeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }

            List<Employees> JoeListLambda = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            List<Employees> IdListLambda = EmployeeList.Where(x => x.Id > 5).ToList();

            Console.Read();
        }
    }
}
