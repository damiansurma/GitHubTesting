using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTesting
{
    interface DesignPatter
    {
        bool checkValue();
    }


    class Program : DesignPatter
    {
        public bool checkValue() { return true; }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
