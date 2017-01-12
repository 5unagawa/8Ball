using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightBall
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = false;
            string fileLoc = ("f:\\8ball.txt");
            string[] responses = GetResponses(fileLoc);
            Console.WriteLine("5unagawa's all-knowing 8-Ball.\nAsk it any question you seek an answer to...");
            while (state == false)
            {
                Console.ReadLine();
                Answer(responses);
            }
        }

        static string[] GetResponses(string fileLoc)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(fileLoc);
            string[] responses = System.IO.File.ReadAllLines(fileLoc);
            return responses;
        }

        static void Answer(string[] responses)
        {
            var rand = new Random();
            int pos = rand.Next(0, responses.Length);
            Console.WriteLine(responses[pos]);
        }
    }
}
