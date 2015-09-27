using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch__UI.DisplayWF();
            stopwatch.Execute();
        }

    }
}
