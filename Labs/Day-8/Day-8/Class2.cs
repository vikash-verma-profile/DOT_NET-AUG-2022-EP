using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_8
{

    class EmployeeList
    {
        public List<EmployeeData> Employees { get; set; }
    }


    class EmployeeData
    {
        int _id=5;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get; set; }

        public void getData()
        {
            Console.WriteLine("Please enter employee Id");
            Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter employee Name");
            Name = Console.ReadLine();
        }
        public void writeInFile(EmployeeList list)
        {
            var jsonString = JsonConvert.SerializeObject(list);
            string filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Files\employeelist.txt";
            File.WriteAllText(filePath, jsonString);
        }
        public EmployeeList ReadFile()
        {
            string filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Files\employeelist.txt";
            string readText = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<EmployeeList>(readText);
        }
    }
    class Class2
    {
        public static void Main3()
        {
            bool Flag = true;
            int choice;
            EmployeeData employee1 = new EmployeeData();
            List<EmployeeData> emdata =
                employee1.ReadFile()==null?new List<EmployeeData>(): employee1.ReadFile().Employees;
            EmployeeList emplist = new EmployeeList();
            while (Flag)
            {
                Console.WriteLine("Please enter a choice from below list :-");
                Console.WriteLine(" 1.Add \n 2.Update \n 3.Delete \n 4.List \n 5.Exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmployeeData employee = new EmployeeData();
                        employee.getData();
                        emdata.Add(employee);

                        emplist.Employees = emdata;

                        employee.writeInFile(emplist);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        foreach (var item in emdata)
                        {
                            Console.WriteLine("ID :" + item.Id);
                            Console.WriteLine("Name :" + item.Name);
                        }
                        break;
                    case 5:
                        Flag = false;
                        break;
                }
                if (!Flag)
                {
                    break;
                }
            }
        }
    }
}
