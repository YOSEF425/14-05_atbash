using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static Tuple <string,int> rate_danger(string sentance)
        {
            int counter = 0;
            List <string> words = sentance.Split(',').ToList();
            List <string> dangerous_words = new List<string> {"bomb","nukhba","fighter","rocket","secret" +
            "bombs","fighters","rockets","secrets"};
            foreach (string word in words)
            {
                if (dangerous_words.Contains(word))
                {
                    counter++;
                }
            }
            Tuple<string, int> result = new Tuple<string, int> { sentance, counter };
            return result;

        }





        static void Main(string[] args)
        {
            Console.WriteLine(rate_danger("we will bombm them all"));

        }


       







    }
}
