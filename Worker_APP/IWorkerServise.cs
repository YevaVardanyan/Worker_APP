using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_APP
{
   public interface IGoVacation
    {
        public void GoVacation();
    }

    public interface IWorkerServise
    {
        public List<DriverWorker> CreateDriverWorker(int count);
        
    }
    public interface IPrint
    {
        public void Print(List<Worker> driverworkers);
        public void Print(List<DriverWorker> driverworkers);
    }
    public interface ISearch
    {
        public string Sarch(List<Worker>workers, string name);
        public string Sarch(List<DriverWorker> workers, string name);
    }
    public interface IBreakTime
    {
        public void BreakTime();
    }
    public interface IAddBonus
    {
        public bool Addbonus(List<Worker> workers , string name );
    }
}
