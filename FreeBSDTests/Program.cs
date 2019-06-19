using System;
using System.Threading.Tasks;

namespace FreeBSDTests
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello FreeBSD!");
            Task task = new Task(new Action(async () => await Dowork()));
            task.RunSynchronously();
            Console.WriteLine("main function done");
        }

        public static async Task Dowork()
        {
            Console.WriteLine("DoWork");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("done");
        }
    }
}
