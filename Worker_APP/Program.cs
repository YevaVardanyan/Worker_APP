using System;
using System.Collections.Generic;

namespace Worker_APP
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkerService workerService = new WorkerService();
            List<DriverWorker> driverWorkers = workerService.CreateDriverWorker(4);
            workerService.Print(driverWorkers);
            driverWorkers[0].BreakTime();

            string res= workerService.Sarch(driverWorkers,"0Name");
            List<Worker> workers = new List<Worker>();
            workers.Add(new DriverWorker(45,"aaa","aaaaaa",78,400));
            workers.Add(new DriverWorker(75,"bbb","bbbbbb",78,400));
            workers.Add(new OfficeWorker(25,"ccc","cccccc",78,400));
            workers.Add(new OfficeWorker(47,"ddd","dddddd",78,400));
            workerService.Print(workers);
            string res1= workerService.Sarch(workers,"ccc");
            Console.WriteLine(res);
            var res2 = workerService.Addbonus(workers,"ddd");
            Console.WriteLine(workers[3]._salary);
            workers[0].BreakTime();
            workers[0].GoVacation();
            workers[3].BreakTime();
            workers[3].GoVacation();
        }
    }
}
