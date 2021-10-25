using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_APP
{
    class OfficeWorker : Worker
    {
        public OfficeWorker(int id, string name, string surname, int age, double salary) : base(id, name, surname, age, salary)
        {

        }
        public override string _name { get; set ; }
        public override string _surname { get ; set ; }
        public override int _age { get ; set; }
        public override double _salary { get ; set; }

        public override void BreakTime()
        {
            Console.WriteLine("two to three o'clock");
        }

        public override void Vacation()
        {
            Console.WriteLine("for a two month");
        }
    }
}
