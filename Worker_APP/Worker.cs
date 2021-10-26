using System;

namespace Worker_APP
{
   public abstract class Worker:IVacation,IBreakTime
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

        public abstract void Vacation();
    }
}
