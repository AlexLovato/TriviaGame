using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Trivia
    {
        //TODO: Fill out the Trivia Object
        public string answer {get; set;}
        public string question { get; set; }
        public string category { get; set; }

        public Trivia(string LineIn)
        {
            question = LineIn.Split('*')[0];
            answer = LineIn.Split('*')[1];


        }
    }
}
