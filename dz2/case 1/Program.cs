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

        public static string carForeign;
        public static int YearOfIssueNotLower;

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
            enginePower = 0;
            maxSpeed = 0;
            //Print();
        }

        static Car()
        {
            carForeign = "carEurope";
            YearOfIssueNotLower = 1990;
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
        public Car(string _mark)
        {
            mark = _mark;
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
        public void Print(ref Car obj)
        {
            Console.WriteLine("milage = " + obj.milage);
            Console.WriteLine("mark = " + obj.mark);
            Console.WriteLine("Gasoline = " + obj.gasoline);
            Console.WriteLine("enginePower = " + obj.enginePower);
            Console.WriteLine("maxSpeed = " + obj.maxSpeed);
        }
        //public void Print(int i,ref Car[] obj)
        //{
        //        Console.WriteLine("milage = " + obj[i].milage);
        //        Console.WriteLine("mark = " + obj[i].mark);
        //        Console.WriteLine("Gasoline = " + obj[i].gasoline);
        //        Console.WriteLine("enginePower = " + obj[i].enginePower);
        //        Console.WriteLine("maxSpeed = " + obj[i].maxSpeed);
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car Car2 = new Car("reno");
            Car[] car3Cars = new Car[5];
            for (int i = 0; i < car3Cars.Length; i++)
            {
                car3Cars[i].Print();
            }
            Car2.Print();
            Console.WriteLine();
            Car1.MaxSpeed = 9;
            Console.WriteLine(Car1.MaxSpeed);
            Car1.Print(ref Car1);
            Car1.Print();
            Console.WriteLine(Car.carForeign);
        }
    }
}
