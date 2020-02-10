using System;
using System.Collections.Generic;

namespace oHappy
{
    class Program
    {
        static void Main(string[] args)
        {
            //used variables
            string[] questions = { "The capital of the Great Britain","What is the square root of 256",
                "Н2О. This is the formula of what","How many planets in the solar system", "2018 World Cup Champion" };
            string[] variance = { "a", "b", "c", "d" };
            string[] rightAnswers = new string[5];
            string[][] answers = new string[5][];
            answers[0] = new string[] { "London", "Paris", "Washington", "Edinburgh" };
            answers[1] = new string[] { "16", "25", "9", "2" };
            answers[2] = new string[] { "water", "salt", "gas", "alcohol" };
            answers[3] = new string[] { "8", "9", "16", "2000" };
            answers[4] = new string[] { "France", "Spain", "Croatia", "Argentina" };
            string userAnswer;
            Dictionary<string, string> quan = new Dictionary<string, string>();


            
            for (int i = 0; i < questions.Length; i++)
            {
                quan.Add(questions[i], answers[i][0]);
                rightAnswers[i] = answers[i][0];
                Array.Sort(answers[i]);
            }

            //game start
            for (int i = 0; i < questions.Length; i++)
            {
                bool isValid = false;
                while (!isValid)
                {

                    Console.WriteLine($"{i + 1}) " + questions[i] + "?");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(variance[j].ToUpper() + ") " + answers[i][j] + " ");
                    }
                    Console.WriteLine();
                    userAnswer = Console.ReadLine();
                    foreach (string el in variance)
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

        public static void ShowBoard(string[] arr){
            foreach(string el in arr)
            {
                Console.Write(el+", ");
            }
        }

        public static void ShowTwoArr(string[][] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
