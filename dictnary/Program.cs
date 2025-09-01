using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictnary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.task();

        }
        public void keyWords()
        {
            // collections 

            // array , list ,dictionary , stack , queue , hashset   

            // which stores data in key value pair

            // works on basis of keys rather than index 

            // var --- data typs --- data as object 

            //instalisation of dictionary

            Dictionary<int, string> students = new Dictionary<int, string>()

            {
                { 101,"sunaib"},
                { 102,"ahmed"},
                { 103,"ali"},
                { 104,"hussain"}
            };

            // acess dictionary data

            // print 1 element of dictionary
            Console.WriteLine(students[101]);

            //print all elements of dictionary
            // key value pair   
            foreach (var name in students)
            {
                Console.WriteLine(name.Key + " " + name.Value);
            }

            // add new element to dictionary    

            students.Add(105, "umer");

            // remove element from dictionary   

            students.Remove(102); // by key value 102
            // students.Remove("ahmed"); // not possible

            //update element of dictionary

            students[103] = "ali"; // by key value 103

            // exists or not

            if (students.ContainsKey(104))
            {
                Console.WriteLine("yes exists");
            }
            else
            {
                Console.WriteLine("not exists");
            }
        }
        public void task()

        {


            // HERE IS THE PROGRAM OF CONTACT MANAGEMENT SYSTEM USING DICTIONARY IN C#


            Dictionary<int, string> students = new Dictionary<int, string>()

            {
                { 101,"sunaib"},
                { 102,"murtaza"},
                { 103,"ali"},
                { 104,"faisal"},
                { 105,"zamin"},
                { 106,"kamran"}
            };
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine("PRESS 1 TO SHOW ALL CONTACTS ||" +
                              "PRESS 2 TO ADD A CONTACT || " +
                              "PRESS  3 TO DELETE A CONTACT ||" +
                              "PRESS 4 TO UPDATE A CONTACT ||");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                foreach (var name in students)
                {
                    Console.WriteLine(name.Key + " " + name.Value);
                }
                task();
            }
            else if (choice == 2)
            {
                Console.WriteLine("ENTER CONTACT ID");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("ENTER CONTACT NAME");
                string name = Console.ReadLine();

                students.Add(id, name);
                Console.WriteLine( name + " ADDED TO THE CONTACTS SUCCESSFULLY");

                foreach (var name1 in students)
                {
                    Console.WriteLine(name1.Key + " " + name1.Value);
                }
                task();
            }
            else if (choice == 3)
            {
                Console.WriteLine("ENTER CONTACT ID TO DELETE");
                int id = int.Parse(Console.ReadLine());
                students.Remove(id);
                Console.WriteLine(id + "  CONTACT DELETED SUCCESSFULLY");

                foreach (var name in students)
                {
                    Console.WriteLine(name.Key + " " + name.Value);
                }
                task();
            }
            else if (choice == 4)
            {
                Console.WriteLine("ENTER CONTACT ID TO UPDATE");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER NEW CONTACT NAME");
                string name = Console.ReadLine();
                students[id] = name;
                Console.WriteLine(name + " CONTACT IS UPDATED SUCCESSFULLY");

                foreach (var name1 in students)
                {
                    Console.WriteLine(name1.Key + " " + name1.Value);
                }
                task();
            }
            else
            {
                Console.WriteLine("INVALID CHOICE");
                Console.WriteLine("PLEASE TRY AGAIN");
            }

            // T H A N K Y O U   F O R   U S I N G   O U R   S E R V I C E S
        }
    }
}
