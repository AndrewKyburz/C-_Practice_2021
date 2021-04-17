using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPractice
{
    class Adventurer
    {


        private static void RunTrainingNormalThreading()
        {
            //First I'm working just with threads per my books suggestion, to get a feel for how they work
            //Then I will move on to tasks, to get the thread to work with multiple method calls, 
            //I can just use an anonymous method to encapsulate both of them (or an actual method to keep both (probably better if going by good
            //object oriented design philosophy

            Thread birdThread = new Thread(() =>
            {
                PrepareBirdhouseRun();
                CollectBirdHouseRun();
            });
            Console.WriteLine("************ STARTING WORKER THREAD 1 ************");
            birdThread.Start();

            Thread herbThread = new Thread(() => {
                PrepareHerbRun();
                CollectHerbRun();
            });
            Console.WriteLine("************ STARTING WORKER THREAD 2 ************");
            herbThread.Start();

            Thread treeThread = new Thread(() => {
                PrepareFruitTreeRun();
                CollectFruitTreeRun();
            });
            Console.WriteLine("************ STARTING WORKER THREAD 3 ************");
            treeThread.Start();

            Thread hardwoodTreeThread = new Thread(() => {
                PrepareHardwoodTreeRun();
                CollectHardwoodTreeRun();
            });
            Console.WriteLine("************ STARTING WORKER THREAD 4 ************");
            hardwoodTreeThread.Start();


        }

        private static async Task TaskRunTrainingTasks()
        {
            
        }

        #region NonTaskBasedMethods
        private static void CollectHardwoodTreeRun()
        {
            Console.WriteLine("Waiting for hardwood trees to grow.");
            Thread.Sleep(37500);
            Console.WriteLine("Stage 1 hardwood tree growth completed");
            Thread.Sleep(37500);
            Console.WriteLine("Hard wood trees collected");
        }
        private static void PrepareHardwoodTreeRun()
        {
            Console.WriteLine("Preparing Hardwood trees");
            Thread.Sleep(3000);
            Console.WriteLine("Hardwood trees prepared.");
        }

        private static void CollectFruitTreeRun()
        {
            Console.WriteLine("Waiting for Fruit trees to grow.");
            Thread.Sleep(50000);
            Console.WriteLine("Fruit trees have been collected");
        }
        private static void PrepareFruitTreeRun()
        {
            Console.WriteLine("Preparing fruit trees.");
            Thread.Sleep(2000);
            Console.WriteLine("Fruit trees have been prepared.");
        }

        private static void CollectHerbRun()
        {
            Console.WriteLine("Waiting for herbs to grow.");
            Thread.Sleep(15000);
            Console.WriteLine("Herbs have been collected.");
        }
        private static void PrepareHerbRun()
        {
            Console.WriteLine("Preparing herb run.");
            Thread.Sleep(1300);
            Console.WriteLine("Herb run prepared.");
        }

        private static void CollectBirdHouseRun()
        {
            Console.WriteLine("Waiting for bird houses");
            Thread.Sleep(10000);
            Console.WriteLine("Bird houses collected.");
        }
        private static void PrepareBirdhouseRun()
        {
            Console.WriteLine("Preparing bird houses");
            Thread.Sleep(1000);
            Console.WriteLine("Bird houses prepared.");

        }
        #endregion NonTaskBasedMethods


        #region TaskBasedMethods
        private static async void HardwoodTask()
        {
            var taskReturn = new Task(() => { });
            await taskReturn;
        }

        private static async void FruitTask()
        {
            var taskReturn = new Task(() => { });
            await taskReturn;
        }

        public static async void BirdTask()
        {
            var taskReturn = new Task(() => { });
        }

        public static async void HerbTask()
        {
            var taskReturn = new Task(() => {/* METHOD STUFF*/ });
        }

        public static async void GenericTask(Action action)
        {
            var taskReturn = new Task(() => {  });
        }

        #endregion TaskBasedMethods


    }
}
