using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee
    {
        public int eID;
        public String name;

        public Employee(int eID, String name) {
            this.eID = eID;
            this.name = name;
        }

    }

    static class EmployeeList
    {
        static List<Employee> list = new List<Employee>();

        public static void add(Employee e) {
            list.Add(e);
        }

        public static void view() {
            foreach (var employee in list) {
                Console.WriteLine(employee.eID+" "+employee.name);
            }  
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeList.add(new Employee(319403,"saurabh"));
            EmployeeList.add(new Employee(319406, "urabh"));
            EmployeeList.view();
        }
    }
}
