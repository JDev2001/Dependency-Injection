using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Etc
{
    class Starter
    {
        static void Main(string[] args)
        {
            new DIContainer.MainProg();
            Console.ReadKey();
        }
    }
}
