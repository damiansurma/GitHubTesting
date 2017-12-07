using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTesting
{
    interface DesignPatter
    {
        void checkValue();
    }


    class Program : DesignPatter
    {
        public void checkValue() {  }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
