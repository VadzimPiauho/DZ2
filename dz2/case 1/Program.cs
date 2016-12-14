using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_1
{
    class Car
    {
        private int milage;
        private string mark;
        private bool gasoline;
        private int enginePower;
        private int maxSpeed;

        public int Milage
        {
            get { return milage; }
            set { milage = value; }
        }
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public bool Gasoline
        {
            get { return gasoline; }
            set { gasoline = value; }
        }
        public int EnginePower
        {
            get { return enginePower; }
            set { enginePower = value; }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public Car()
        {
            milage = 0;
            mark = "default";
            gasoline = false;
            enginePower = 100;
            maxSpeed = 220;
            Print();
        }

        public Car(int _milage, string _mark, bool _Gasoline, int _enginePower, int _maxSpeed)
        {
            milage = _milage;
            mark = _mark;
            gasoline = _Gasoline;
            enginePower = _enginePower;
            maxSpeed = _maxSpeed;
            Print();
        }
        
        public void Print()
        {
            Console.WriteLine("milage = " + milage);
            Console.WriteLine("mark = " + mark);
            Console.WriteLine("Gasoline = " + gasoline);
            Console.WriteLine("enginePower = " + enginePower);
            Console.WriteLine("maxSpeed = " + maxSpeed);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Console.WriteLine();


        }
    }
}
