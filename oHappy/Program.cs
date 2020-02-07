using System;
using System.Collections.Generic;

namespace oHappy
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] questions = { "The capital of the Great Britain","What is the square root of 256",
                "Н2О. This is the formula of what","How many planets in the solar system", "2018 World Cup Champion" };
            string[] variance = { "a", "b", "c", "d" };
            string[] rightAnswers = { "London", "16", "water", "8", "France"};
            string[,] answers = new string[5, 4] { { "London","Paris","Washington","Edinburgh"},
                {"16","25","9","2" },{ "water", "salt", "gas", "spirt" },{ "9", "8", "16", "2000" },
                { "France", "Spain", "Croatia", "Argentina" } };
           
            Dictionary<string,string> quan = new Dictionary<string,string>();
           

            for (int i = 0; i < questions.Length; i++)
            { 
                //Console.WriteLine(questions[i]);
                quan.Add(questions[i],rightAnswers[i]);
            }

            string userAnswer;
            for(int i = 0; i < questions.Length; i++)
            {
                bool isValid = false;
                while (!isValid)
                {
                    
                    Console.WriteLine($"{i + 1}) " + questions[i] + "?");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(variance[j].ToUpper()+") "+answers[i,j]+" ");
                    }
                    Console.WriteLine();
                    userAnswer = Console.ReadLine();
                    foreach(string el in variance)
                    {
                        if (userAnswer == el)
                        {
                            isValid = true;
                            break;
                        }
                        else if (userAnswer == "q") return;
                    }
                    
                }
                

            }




            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
