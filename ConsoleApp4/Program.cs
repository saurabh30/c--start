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

        public  String Delete(int id) {
            foreach (var employee in list)
            {
                if (employee.EId == id) {
                    list.Remove(employee);
                    return ($"{employee.Name} deleted");
                  
                }
                
            }

            return "Invalid ID";
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

            Console.WriteLine("Employee Not found");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeList obj = new EmployeeList() ;
            while (true) {
                Console.WriteLine("Enter 1 to view employee list.");
                Console.WriteLine("Enter 2 to add employee list.");
                Console.WriteLine("Enter 3 to edit employee list.");
                Console.WriteLine("Enter 4 to delete employee list.");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        obj.View();
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Enter the employee ID");
                        String s = Console.ReadLine();
                        int eID;
                        try
                        {
                            eID = Convert.ToInt32(s);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid ID");
                            Console.WriteLine("Press enter to exit");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.WriteLine("Enter the employee name");
                        String name = Console.ReadLine();
                        Console.WriteLine("Enter the employee date of joining in dd/mm/yyyy");
                        String date = Console.ReadLine();
                        obj.Add(new Employee()
                        {
                            EId = eID,
                            Name = name,
                            DOJ = date
                        });
                        Console.WriteLine("Employee added");
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Enter the employee ID");
                        s = Console.ReadLine();
                        try
                        {
                            eID = Convert.ToInt32(s);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid ID");
                            Console.WriteLine("Press enter to exit");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.WriteLine("Enter new name");
                        name = Console.ReadLine();
                        obj.Edit(eID,name);
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Enter the employee ID");
                         s = Console.ReadLine();
                        try
                        {
                            eID = Convert.ToInt32(s);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid ID");
                            Console.WriteLine("Press enter to exit");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        String msg = obj.Delete(eID);
                        Console.WriteLine(msg);
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice.Press enter to exit.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
