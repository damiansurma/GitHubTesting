using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTesting
{
    interface DesignPatter
    {
        int checkValue();
    }


    class Program : DesignPatter
    {
        public int checkValue() { return 0; }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
