using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void printer(Tuple<string,int> data)
        {
            Console.WriteLine("\x1b[91m ");
            int num = data.Item2;
            if  (num > 0 && num < 6)
                Console.WriteLine("WARNING");
            
            if  (num > 5 && num < 11)
                Console.WriteLine("DANGER");
            
            if  (num > 10 && num < 16)
                Console.WriteLine("ULTRA ALERT");
            Console.WriteLine("\u001b[39m");
            Console.WriteLine(data.Item1);
        }
        static void Main(string[] args)
        {

        }
    }
}
