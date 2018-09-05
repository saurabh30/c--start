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

    static class EmployeeData
    {
        static List<Employee> list1 = new List<Employee>();
        public static List<Employee> Get() {
            list1.Add(new Employee(1, "saurabh1"));
            list1.Add(new Employee(2, "saurabh2"));
            list1.Add(new Employee(3, "saurabh3"));
            list1.Add(new Employee(4, "saurabh4"));
            list1.Add(new Employee(5, "saurab5"));
            list1.Add(new Employee(6, "saurabh6"));
            list1.Add(new Employee(7, "saurabh7"));
            list1.Add(new Employee(8, "saurabh8"));
            list1.Add(new Employee(9, "saurabh9"));
            list1.Add(new Employee(10, "saurabh0"));
            return list1;
        }
        
     }

     class EmployeeList
    {
        List<Employee> list;
        public EmployeeList() {
            list = EmployeeData.Get();
        }
        public void add(Employee e) {
            list.Add(e);
        }

        public void view() {
            foreach (var employee in list) {
                Console.WriteLine(employee.eID+" "+employee.name+" ");
            }  
        }

        public  void delete(int id) {
            foreach (var employee in list)
            {
                if (employee.eID == id) {
                    list.Remove(employee);
                    Console.WriteLine(employee.name + " deleted" );
                    break;
                }
                
            }
        }

        public  void edit(int id,String name)
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
            EmployeeList obj = new EmployeeList() ;
            obj.view();
            obj.delete(1);
            obj.view();
            obj.edit(6,"saurabh");
            obj.view();
        }
    }
}
