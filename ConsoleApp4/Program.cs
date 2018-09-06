using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee
    {
        DateTime date;
        public int EId
        { get; set; }
        public String Name
        { get; set; }

        public String DOJ
        {
            get => date.ToString("dd/MM/yyyy");
            set
            {
                try
                {
                    date = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        } 

    }

    static class EmployeeData
    {
        static internal List<Employee> list1 = new List<Employee>()
        {
                new Employee(){  EId=1, Name = "saurabh1", DOJ = "25/07/2018" },
                new Employee(){  EId=2, Name = "saurabh2", DOJ = "25/07/2018" },
                new Employee(){  EId=3, Name = "saurabh3", DOJ = "25/07/2018" },
                new Employee(){  EId=4, Name = "saurabh4", DOJ = "25/07/2018" },
                new Employee(){  EId=5, Name = "saurabh5", DOJ = "25/07/2018" },
                new Employee(){  EId=6, Name = "saurabh6", DOJ = "25/07/2018" },
                new Employee(){  EId=7, Name = "saurabh7", DOJ = "25/07/2018" },
                new Employee(){  EId=8, Name = "saurabh8", DOJ = "25/07/2018" },
                new Employee(){  EId=9, Name = "saurabh9", DOJ = "25/07/2018" },
                new Employee(){  EId=10, Name = "saurabh10", DOJ = "25/07/2018" },
        };
     }

     class EmployeeList
    {
        List<Employee> list;
        public EmployeeList() {
            list = EmployeeData.list1;
        }
        public void Add(Employee e) {
            list.Add(e);
        }

        public void View() {
            foreach (var employee in list) {
                Console.WriteLine($"{employee.EId} {employee.Name} {employee.DOJ}");
            }  
        }

        public  void Delete(int id) {
            foreach (var employee in list)
            {
                if (employee.EId == id) {
                    list.Remove(employee);
                    Console.WriteLine($"{employee.Name} deleted");
                    break;
                }
                
            }
        }

        public  void Edit(int id,String name)
        {
            foreach (var employee in list)
            {
                if (employee.EId == id)
                {
                    
                    Console.WriteLine($"{employee.Name} updated");
                    employee.Name = name;
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
            obj.View();
            obj.Delete(1);
            obj.View();
            obj.Edit(6,"saurabh");
            obj.View();
        }
    }
}
