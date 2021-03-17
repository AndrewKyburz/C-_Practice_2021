using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPractice
{
    class Program
    {

        //I'll give this some flavor for OldSchool Runescape to make it my own example
        static void Main(string[] args)
        {

            Console.WriteLine("ASYNC EXAMPLE STARTED");


            /*Don't actually "need" to capture the 
             * task object, but doing so allows you to suspend
             * flow of the program in order to wait for the worker 
             * thread to finish. If this is not done, because worker
             * threads are "background" threads they die if the main thread ends
             * They don't keep the program "Alive" 
             */
            var task = Chef.BreakfastExample();
            task.Wait();

            Console.ReadLine();




        }






    }
}
