using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_APP
{
   public abstract class Worker:IGoVacation,IBreakTime
    {
        public Worker(int id, string name, string surname, int age, double salary)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _age = age;
            _salary = salary;
        }
        public  int _id { get; }
        public abstract string _name { get; set; }
        public abstract string _surname { get; set; }
        public abstract int _age { get; set; }
        public abstract double _salary { get; set; }

        public abstract void BreakTime();
       

        public abstract void GoVacation();
       
    }
}
