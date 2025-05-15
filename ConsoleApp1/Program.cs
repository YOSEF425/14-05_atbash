using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string decrypter(string oldMessage)
        {
            string newMessage = "";
            foreach (char let in oldMessage)
            {
                newMessage += (char.IsLetter(let) ? (char)(219 - (int)let - (char.IsUpper(let) ? 64 : 0)) : let);
            }
            return newMessage;
        }
        static void Main(string[] args)
        {
            

            

        }
       
    }
}
