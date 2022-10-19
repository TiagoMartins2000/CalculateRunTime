using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateRunTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //requer a library "System.Diagnostics"
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // código aqui . . . .

            for (int i = 0; i <= 100; ++i)
            {
                Console.WriteLine(i);
            }

            stopWatch.Stop();

            // obter o tempo decorrido armazenado pelo stopWatch para o TimeSpan
            TimeSpan ts = stopWatch.Elapsed;

            // formatar e mostrar o valor do TimeSpan 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
