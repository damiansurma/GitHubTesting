using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// strategy design pattern test

namespace GitHubTesting
{
    interface DefaultSolution
    {
        bool checkValue();
    }


    class Solution1 : DefaultSolution
    {
        public bool checkValue() { Console.WriteLine("true"); return true;  }
    }
    class Solution2 : DefaultSolution
    {
        public bool checkValue() { Console.WriteLine("false"); return false; }
    }

    class ValueCheckerPerson
    {
        DefaultSolution checker;

        public void setChecker(DefaultSolution _checker)  {
            checker = _checker;
        }

        public void doStuff()
        {
            checker.checkValue();
        }

    }

    class Program
    {
        public bool checkValue() { return false; }



        static void Main(string[] args)
        {
            // just some changes
            Console.WriteLine("Hello World");

            DefaultSolution sol1 = new Solution1();
            DefaultSolution sol2 = new Solution2();

            ValueCheckerPerson test = new ValueCheckerPerson();

            test.setChecker(sol2);
            test.doStuff();

            test.setChecker(sol1);
            test.doStuff();
        }
    }
}
