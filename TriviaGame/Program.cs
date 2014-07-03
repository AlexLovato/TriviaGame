using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trivia game function goes here
            GetTriviaList();
            StartGame();
            Console.ReadKey();
        }


        //This functions gets the full list of trivia questions from the Trivia.txt document
        static List<Trivia> GetTriviaList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();

            //Each item in list "contents" is now one line of the Trivia.txt document.
            
            //make a new list to return all trivia questions
            List<Trivia> returnList = new List<Trivia>();
            // TODO: go through each line in contents of the trivia file and make a trivia object.
            //       add it to our return list.
            
            foreach (string a in contents)
            {
                Trivia triviaTest = new Trivia(a);
                //Console.WriteLine("question: " + triviaTest.question);
                //Console.WriteLine("answer: " + triviaTest.answer);
                returnList.Add(triviaTest);
            }
            //Return the full list of trivia questions
            return returnList;
        }
        static void StartGame()
        {
           
            int counter = 10;
            Console.WriteLine("_-_-_-_TRIVIA_-_-_-_");
            Console.WriteLine("_-_-_-_   GET_-_-_-_");
            Console.WriteLine("_-_-_-_ READY_-_-_-_");
            Console.WriteLine("_-_-_-_   FOR_-_-_-_");
            Console.WriteLine("_-_-_-_   FUN_-_-_-_");
            Console.WriteLine("\n");
            Console.WriteLine("I'm going to ask a question and you will type in 'the' answer");
            Console.WriteLine("You can only answer incorrectly 10 times");
            while (counter > 0)
            {
                Random rng = new Random();
                int randomNumber = rng.Next(0, GetTriviaList().Count());//instantiates a random number with parametersas
                var trivia = GetTriviaList()[randomNumber];
                var questionToAsk = trivia.question;
                Console.WriteLine(questionToAsk);
                string input = Console.ReadLine();
                if (trivia.answer.Contains(input))
                {
                    Console.WriteLine("Yes, the answer is : " + trivia.answer);
                }
                else
                {
                    Console.WriteLine("NO YOU SUCK THE ANSWER IS :" + trivia.answer);
                    counter--;
                }
            }
            Console.WriteLine("Thanks for playing");
            
        }

    }
}
