using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_APP
{
   public interface IVacation
    {
        public void Vacation();
    }

 
    public interface IPrint
    {
        public void Print(List<Worker> workers);
       
    }
    public interface ISearch
    {
        public string Search(List<Worker>workers, string name);
       
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
