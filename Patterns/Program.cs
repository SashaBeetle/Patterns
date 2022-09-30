using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main()
        {
            Developer dev1 = new Developer();
            Developer dev2 = new Developer();
            Developer dev3 = new Developer();
            Project Apple = new Project();
            Apple.title = "Apple";
            Project.add_developer(dev1.name, Apple.Developers);
            Project.add_developer(dev2.name, Apple.Developers);
            Project.add_developer(dev3.name, Apple.Developers);
            Project Xiomi = new Project();
            Xiomi.title = "Xiomi";
            Project.add_developer(dev1.name, Xiomi.Developers);
            Project.add_developer(dev3.name, Xiomi.Developers);
            Project Terom = new Project();
            Terom.title = "Terom";
            Project.add_developer(dev3.name, Terom.Developers);
            dev1.id = 013;
            dev1.name = "Andry";
            dev1.number = "098-90-50-80";
            dev1.position = 1;
            dev1.rank = "Junior";
            dev1.salary = 734.23f;
            Developer.assign(dev1.Projects, Apple.title);
            Developer.assign(dev1.Projects, Xiomi.title);
            dev2.id = 035;
            dev2.name = "Pavlo";
            dev2.number = "098-50-40-83";
            dev2.position = 2;
            dev2.rank = "Middle";
            dev2.salary = 1472.67f;
            Developer.assign(dev2.Projects, Apple.title);
            dev3.id = 075;
            dev3.name = "Oleg";
            dev3.number = "068-47-45-38";
            dev3.position = 3;
            dev3.rank = "Senior";
            dev3.salary = 3503.37f;
            Developer.assign(dev3.Projects, Apple.title);
            Developer.assign(dev3.Projects, Xiomi.title);
            Developer.assign(dev3.Projects, Terom.title);
            Console.WriteLine("Проекти {0}:", dev1.name);
            Developer.assigned_projects(dev1.Projects);
            YesOrNot(dev1.name, dev1.Projects);
            Console.WriteLine("\nПроекти {0}:", dev2.name);
            Developer.assigned_projects(dev2.Projects);
            YesOrNot(dev2.name, dev2.Projects);
            Console.WriteLine("\nПроекти {0}:", dev3.name);
            Developer.assigned_projects(dev3.Projects);
            YesOrNot(dev3.name, dev3.Projects);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("     ------After Upgrade------");
            Console.WriteLine("----------------------------------------");
            Developer.unassign(dev1.Projects, Apple.title);
            Developer.assign(dev1.Projects, Terom.title);
            Developer.assign(dev2.Projects, Xiomi.title);
            Developer.assign(dev2.Projects, Terom.title);
            Developer.unassign(dev3.Projects, Xiomi.title);
            Console.WriteLine("Проекти {0}:", dev1.name);
            Developer.assigned_projects(dev1.Projects);
            YesOrNot(dev1.name, dev1.Projects);
            Console.WriteLine("\nПроекти {0}:", dev2.name);
            Developer.assigned_projects(dev2.Projects);
            YesOrNot(dev2.name, dev2.Projects);
            Console.WriteLine("\nПроекти {0}:", dev3.name);
            Developer.assigned_projects(dev3.Projects);
            YesOrNot(dev3.name, dev3.Projects);
        }
        private static void YesOrNot(string name, List<string> listic)
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
    
   public class Developer
    {
       public int id, position;
       public float salary;
       public string name, address, number, email, rank;
       public List<string> Projects = new List<string>();


        public static void assign(List<string> Project, string a)
        {
            Project.Add(a);
        }

        public static void unassign(List<string> Project, string a)
        {
            Project.Remove(a);
        }

        public static void assigned_projects(List<string> Project)
        {
            foreach (string el in Project)
            {
                Console.WriteLine("-{0} ",el);
            }
        }

        public static bool assign_possibility(List<string> Project)
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
   public class Assignment
    {
        public Dictionary<string, string> received_tasks = new Dictionary<string, string>();
        public bool is_done;
        public string description,status;


        public static void get_tasks_to_date(string task)
        {
           
        }
    }

   public class Project
    {
        public string title;
        DateTime start_date = new DateTime();
        public List<string> Tasks = new List<string>();
        public List<string> Developers = new List<string>();
        public int limit;


        public static void add_developer(string dev_name, List<string> Developers)
        {
            Developers.Add(dev_name);

        }
        public static void remove_developer(string dev_name, List<string> Developers)
        {
            Developers.Remove(dev_name);
        }
    }

    public class QAEngineer
    {
        public int id;
        public string name, adress, phone_number, email, rank, position;
        public float salary;
     
        
        public static void test_feature(string test)
        {

        }
    }

   public class ProjectManager
    {
        public int id;
        public string name, adress, phone_number, email;
        public float salary;

        public static void discuss_progress(string developer)
        {

        }
    }

}