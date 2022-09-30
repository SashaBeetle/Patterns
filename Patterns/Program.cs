using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program : Developer
    {
        static void Main()
        {
            List<string> Projectss = new List<string>();
            
            Projectss.Add("Yui");
            Projectss.Add("Ruis");
            assign(Projectss, "Apple");
            unassign(Projectss, "Yui");
            foreach (string el in Projectss)
            {
                Console.WriteLine(el);
            }
            bool elnt;
            elnt = assign_possibility(Projectss);
            Console.WriteLine("___________");
            assigned_projects(Projectss);
            Console.WriteLine("___________");
            Console.Write("Space for new projects = {0}\n", elnt);
            
        }
        
    }
    
    class Developer
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
                Console.WriteLine(el);
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
    class Assignment
    {
        public Dictionary<string, string> received_tasks = new Dictionary<string, string>();
        public bool is_done;
        public string description,status;


        public static void get_tasks_to_date(string task)
        {
           
        }
    }

    class Project
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

    class QAEngineer
    {
        public int id;
        public string name, adress, phone_number, email, rank, position;
        public float salary;
     
        
        public static void test_feature(string test)
        {

        }
    }

    class ProjectManager
    {
        public int id;
        public string name, adress, phone_number, email;
        public float salary;

        public static void discuss_progress(string developer)
        {

        }
    }

}