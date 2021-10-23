using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_APP
{
   public class WorkerService :  IWorkerServise,IAddBonus,IPrint,ISearch
    {
        public bool Addbonus(List<Worker> workers, string name)
        {
            bool worker =false;
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i]._name == name)
                {
                  workers[i]._salary=  workers[i]._salary + 20000;
                  worker = true;
                }
            }
            return worker;
        }

        public void BreakTime()
        {
            Console.WriteLine("one to two o'clock");
        }

        

        public List<DriverWorker> CreateDriverWorker(int count)
        {
            List<DriverWorker> workers = new List<DriverWorker>(count);
            for (int i = 0; i < count; i++)
            {
                workers.Add(new DriverWorker(i, $"{i}Name", $"{i}Surname", i + 17, 200 + i));
            }
            return workers;
        }

       

        public void Print(List<DriverWorker> driverworkers)
        {
            foreach (var item in driverworkers)
            {
                Console.WriteLine($"id - {item._id}\n name - {item._name}\n surname - {item._surname}\n age - {item._age}\n salary - {item._salary} ");
            }
        }

        public void Print(List<Worker> driverworkers)
        {
            foreach (var item in driverworkers)
            {
                Console.WriteLine($"id - {item._id}\n name - {item._name}\n surname - {item._surname}\n age - {item._age}\n salary - {item._salary} ");
            }
        }

        public string Sarch(List<Worker> workers,string name)
        {
            string worker = "ther is no such employee";
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i]._name==name)
                {
                    worker = $"id - {workers[i]._id}\n name - {workers[i]._name}\n surname - {workers[i]._surname}\n age - {workers[i]._age}\n salary - {workers[i]._salary}";
                    break;
                }
            }
            return worker;
        }

        public string Sarch(List<DriverWorker> workers, string name)
        {
            string worker = "ther is no such employee";
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i]._name == name)
                {
                    worker = $"id - {workers[i]._id}\n name - {workers[i]._name}\n surname - {workers[i]._surname}\n age - {workers[i]._age}\n salary - {workers[i]._salary}";
                    break;
                }
            }
            return worker;
        }
    }
}
