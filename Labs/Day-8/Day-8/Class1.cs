using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;


namespace Day_8
{
    class student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
    }

    class Data
    {
        public student[] students { get; set; }
    }
    class Class1
    {
        public static void Main2()
        {
            student[] students = new student[2];
            for (int i = 0; i < students.Length; i++)
            {
                student s = new student();
                Console.WriteLine("Please enter student Roll No");
                s.RollNo=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter student Name");
                s.Name=Console.ReadLine();
                students[i] = s;
            }
            Data data = new Data();
            data.students = students;
            var jsonString =JsonConvert.SerializeObject(data);

            //Console.WriteLine(jsonString);
            string filePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Files\data.txt";
            File.WriteAllText(filePath, jsonString);
            string readText = File.ReadAllText(filePath);
          //  Console.WriteLine(readText);
            var obj = JsonConvert.DeserializeObject<Data>(readText);
            foreach (var item in obj.students)
            {
                Console.WriteLine("Student ID"+item.RollNo);
            }
        }
    }
}
