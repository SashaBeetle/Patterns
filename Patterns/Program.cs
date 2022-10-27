using System;
using System.Collections.Generic;

namespace Patterns
{
    
    class Program // Main class
    {
        static void Main() // Main Function
        {
            float res;
            Developer dev1 = new Developer();
            Developer dev2 = new Developer();
            Task task1 = new Task();
            Task task2 = new Task();
            Project Sigma = new Project();
            Employee em1 = new Employee();
            dev1.first_name = "Andry";
            dev1.second_name = "Jonson";
            dev2.first_name = "Pavlo";
            dev2.second_name = "Tuchka";
            dev1.salary = 3456.34f;
            dev1.rank = "PM";
            dev2.rank = "Junior";
            dev2.salary = 983.65f;
            res = dev1.calculate_salary();
            Console.WriteLine("Salary {0} {1}: {2}$",dev1.first_name,dev1.second_name ,res);
            res = dev2.calculate_salary();
            Console.WriteLine("Salary {0} {1}: {2}$", dev2.first_name, dev2.second_name, res);
            Console.WriteLine();
            Console.WriteLine("Sick leave {1} = {0}", dev1.ask_sick_leave(),dev1.first_name);
            Console.WriteLine("Sick leave {1} = {0}", dev2.ask_sick_leave(), dev2.first_name);
            Console.WriteLine();
            Sigma.title = "Sigma";
            task1.title = "Server crash test";
            task1.id = 11;
            task2.title = "Creating site";
            task2.id = 03;
            Sigma.task_list.Add(task1.id);
            Sigma.task_list.Add(task2.id);
            task1.implement_item("Personal Computer");
            task1.implement_item("Pen");
            task2.implement_item("Laptop");
            Console.WriteLine("Items for {0}",task1.title);
            foreach (string el in task1.items)
            {
                Console.WriteLine(" '{0}' ",el);
            }
            Console.WriteLine("Items for {0}", task2.title);
            foreach (string el in task2.items)
            {
                Console.WriteLine(" '{0}' ", el);
            }



        }
        private static void YesOrNot(string name, List<string> listic) // Function for reduction code
        {
            int a = listic.Count;
            if(Developer.assign_possibility(listic)== true)
            {
                Console.WriteLine("<{0} Може взяти проект, у нього {1} Проект(а)>", name, a);
            }
            else
            {
                Console.WriteLine("<{0} Не може взяти бiльше проектiв, у нього {1} Проект(а)>", name, a);
            }
        }

    }
    
   public class Developer : Employee // class Developer
    {
       
       public List<string> Projects = new List<string>();

        
        public static void assigned_projects(List<string> Project) // Show developer projects
        {
            foreach (string el in Project)
            {
                Console.WriteLine("-{0} ",el);
            }
        }

        public static bool assign_possibility(List<string> Project) // checks the developer's workload

        {
            bool res;
            int els = Project.Count;
           if(els >= 3)
            {
                res = false;
            }
            else 
            {
                res = true;
            }
            return res;
        }
    }

   public class PersonalInfo // class PersonalInfo
    {
        public int id, position; // About PersonalInfo
        public string first_name, second_name, address, phone_number, email, rank;
        public float salary;
    }

    public class Employee : PersonalInfo // abstract class Employee + Progeny class
    {
        public float calculate_salary() 
        {
            
            return this.salary * 12;

        }

        public bool ask_sick_leave()
        {
            if (this.rank == "PM")
            {
                return true;
            }
            else if (this.rank == "QA")
            {
                return true;
            }
            else return false;
        }
    }
    public class AssigmentManagement : Project
    {

    }

    public class Project : Employee // class Project
    {
        public string title; // About Project
        DateTime start_date = new DateTime();
        public List<int> task_list = new List<int>();
        public List<string> Developers = new List<string>();
        public int limit;


        public void assign(string dev_name) // Add developer to project
        {
            this.Developers.Add(dev_name);

        }
        public void unassign(string dev_name) // Remove developer from project
        {
            this.Developers.Remove(dev_name);
        }
        public  void get_specific_employees(string dev_name)
        {
            this.Developers.Add(dev_name);
        }
    }

    public class Assignment : Task // class Assignment
    {
        public Dictionary<string, string> received_tasks = new Dictionary<string, string>(); // About Assigment
        public bool is_done;
        public string description,status;

       
        public static void get_tasks_to_date(string task) // Gets tasks to date
        {
           
        }
    }


    public class Task
    {
        public int id;
        public string title, status, related_project, comment;
        DateTime deadline = new DateTime();
        public List<string> items = new List<string>();


        public void implement_item(string item)
        {
            this.items.Add(item);
        }

        public void add_comment(string comment)
        {
            this.comment = comment;
        }
    }

    public class QA : Employee
    {
     
        
        public static void add_ticket(string test)
        {

        }
        
    }

   public class ProjectManager : Employee
    {

        public void employee_requests()
        {
            ask_sick_leave();
        }

        public static void discuss_progress()
        {

        }
    }

}