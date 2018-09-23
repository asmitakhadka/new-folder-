using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_milestone2_team16
{
    class Program
    {
        public static void Main(string[] args) //recalling methods//
        {
            asklevel();
            askid();
            asksubjectcode();
            askpaper();
            askmarks();
            int result = (60 + 70 + 85 / 3);//average of three supposed marks//
            Console.WriteLine($"This is an average marks of your papers {60 + 70 + 85 / 3} and you have passed this course:");
            showgrade();
            Console.ReadLine();
        }
        public static void asklevel()
        {//method for asking a level of user//
            int level;
            Console.WriteLine("Please enter your level:");
            level = int.Parse(Console.ReadLine());

            if (level == 5)
            {
                Console.WriteLine("Perhaps you need 4 papers");
            }
            else
            {
                Console.WriteLine("Perhaps you need 3 papers");
            }

            Console.WriteLine($"You are in level {level}:");
        }
        public static void askid()
        {//method for asking an id of user//
            int id;
            Console.WriteLine("Please enter your idnumber:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your id is {id}:");

        }
        public static void asksubjectcode()
        {//method for asking paper code of user//
            int code;
            Console.WriteLine("Please enter your subject code:");
            code = int.Parse(Console.ReadLine());
            
            if (code >= 500 )
            {
                Console.WriteLine("Congratulation! You have got A+ grade");
            }
            else if (code <= 600)
                    {
                Console.WriteLine("Congratulation! You have got A- grade");
            }
            else if (code >= 300)
            {
                Console.WriteLine("Congratulation! You are in rank of B+ grade");
            }
            else if (code <= 200)
            {
                Console.WriteLine("Congratulation! You have got B- grade");
            }
            else if (code < 700)
            {
                Console.WriteLine("Congratulation! You are in rank of C grade");
            }
            Console.WriteLine("Please press enter for further information:");
            Console.ReadLine();
        }
        public static void askpaper ()
        {//method for showing all papers of level 5 and level 6//
            Console.Clear();
            Console.WriteLine("The following are the papers for only level 5 and level 6:");

            var papers = new List<string>();
            papers.Add("Infrastructure");
            papers.Add("Professional skills");
            papers.Add("Networking");
            papers.Add("Software packages");
            papers.Add("Statistics");
            papers.Add("Multimedia");
            papers.Add("Programming");
            papers.Add("Advanced Programming");
            papers.Add("Website designing");
            papers.Add("Business management");
            papers.Add("Database management");

            foreach (var paper in papers)
            {
                Console.WriteLine(paper);
            }
        
        }
        public static void askmarks()
        {//method for printing marks of paper that user want incase// 
            string paper;
            Console.WriteLine("Please enter your paper name:");
            Console.ReadLine();

            int papers;
            Console.WriteLine("Please enter your expected marks:");
            papers = int.Parse(Console.ReadLine());

            if (papers <= 60)
            {
                Console.WriteLine("You have got C grade that means above 50%:");
            }
            else if (papers <= 70)
            {
                Console.WriteLine("You have got B grade that means above 70%:");
            }
            else if (papers <= 100)
            {
                Console.WriteLine("You have got A grade that means above 80%:");
            }
            Console.WriteLine("Please press enter for other paper's grade and marks:");
            Console.ReadLine();

            string paperTypes;//printing other paper's grade and marks//
            Console.WriteLine("Please enter your paper name:");
            Console.ReadLine();

            int papersTypes;
            Console.WriteLine("Please enter your expected marks:");
            papers = int.Parse(Console.ReadLine());

            if (papers <= 60)
            {
                Console.WriteLine("You have got C grade that means above 50%:");
            }
            else if (papers <= 70)
            {
                Console.WriteLine("You have got B grade that means above 70%:");
            }
            else if (papers <= 100)
            {
                Console.WriteLine("You have got A grade that means above 80%:");
            }
            Console.WriteLine("Please press enter for other paper's mark and grade:");
            Console.ReadLine();

            string paperAgain;//printing other paper's grade and marks//
            Console.WriteLine("Please enter your paper name:");
            Console.ReadLine();

            int papersAgain;
            Console.WriteLine("Please enter your expected marks:");
            papers = int.Parse(Console.ReadLine());
            if (papers <= 60)
            {
                Console.WriteLine("You have got C grade that means above 50%:");
            }
            else if (papers <= 70)
            {
                Console.WriteLine("You have got B grade that means above approx.70%:");
            }
            else if (papers >= 85)
            {
                Console.WriteLine("You have got A grade that means above 85%:");
            }
            Console.WriteLine("Please press enter for other information:");
            Console.ReadLine();
        }
        public static int averagemarks(int papers, int papersType, int papersAgain)
        {//return an integers and giving average marks of user's marks//
            return papers + papersType + papersAgain / 3;
        }
        public static void showgrade()
        {// method for showing paper that has A+ grade//
            string grade;
            Console.WriteLine("Please choose one paper that you want to know about grade:");
            Console.ReadLine();

            int grades;
            Console.WriteLine("Please enter number that should be above 85, thanks:");
            grades = int.Parse(Console.ReadLine());

            if (grades>= 85)
            {
                Console.WriteLine($"This paper have A+ grade having {grades} marks , Thank you!");
            }
            else
            {
                Console.WriteLine("This is not a paper having A+ grade, Thank you!");
            }
                } 
    }
}
     
  




