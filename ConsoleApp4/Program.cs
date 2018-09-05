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

        public static void delete(int id) {
            foreach (var employee in list)
            {
                if (employee.eID == id) {
                    list.Remove(employee);
                    Console.WriteLine(employee.name + " deleted" );
                    break;
                }
                
            }
        }

        public static void edit(int id,String name)
        {
            foreach (var employee in list)
            {
                if (employee.eID == id)
                {
                    employee.name = name; 
                    Console.WriteLine(employee.name + " updated");
                    break;
                }

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
            EmployeeList.delete(319403);
            EmployeeList.view();
            EmployeeList.edit(319406,"saurabh");
            EmployeeList.view();
        }
    }
}
