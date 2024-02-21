using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Logan Boughner
            int score;
            string q1, q2, q3, q4;
            score = 0;
            Console.WriteLine("Part 3 (quiz)");
            Console.WriteLine("You will take the following quiz about me");
            Console.WriteLine("Question 1: What is my dog's name?");
            Console.WriteLine("a) Wally." + "\t b) Winston." + "\t c) Willow." + "\t d) Wayne.");
            q1 = Console.ReadLine();
            if (q1 == "a")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else if (q1 == "b")
            {
                Console.WriteLine();
                Console.WriteLine("Correct");
                score = score + 25;
            }
            else if (q1 == "c")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else if (q1 == "d")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else
            {
                Console.WriteLine(); 
                Console.WriteLine("Invalid option");
            }
            Console.WriteLine(); 
            Console.WriteLine("Question 2: What breed is Winston?");
            Console.WriteLine("a) Bull dog" + "\t b) Pitbull" + "\t c) Micro bully");
            
            q2 = Console.ReadLine();
            if (q2 == "a")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else if (q2 == "b")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else if (q2 == "c")
            {
                Console.WriteLine();
                Console.WriteLine("Correct. FOr those who dont know Micro bully is a mix of both Pitbull and Bull dog");
                score = score + 25;
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Not a valid option");
            }
            Console.WriteLine();
            Console.WriteLine("Question 3: What am I persuing after highschool?");
            Console.WriteLine("a) Accounting" + "\t b) Game tester" + "\t c) Game developer" + "\t d) Streamer");
            q3 = Console.ReadLine();
            if (q3 == "a") 
            {
                Console.WriteLine();
                Console.WriteLine("Correct");
                score = score + 25;
            }
            else if (q3 == "b") 
            {
                Console.WriteLine();
                Console.WriteLine("Wrong. This is my second choice for a job");
            }
            else if (q3 == "c")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else if (q3 == "d")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong. I'm already doing this for fun");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not a valid option");
            }
            Console.WriteLine("Question 4: What is my favourite class?");
            Console.WriteLine("a) Gym" + "\t b) Computer Studies" + "\t c) Accounting" + "\t d) Math");
            q4 = Console.ReadLine();
            if (q4 == "a")
            {
                Console.WriteLine();
                Console.WriteLine("Correct");
                score = score + 25;
            }
            else if (q4 == "b")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong., Whill yes i'm enjoying this class it's not my all time favourite");
            }
            else if (q4 == "c")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else if (q4 == "d")
            {
                Console.WriteLine();
                Console.WriteLine("Wrong");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not a valid option");
            }
            Console.WriteLine(score + "%");
            Console.ReadLine();
        }

    }
}
