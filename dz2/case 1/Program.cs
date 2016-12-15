using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_1
{
    partial class  Car
    {
        private int milage;
        private string mark;
        private bool gasoline;
        private int enginePower;
        private int maxSpeed;

        public static string carForeign;
        public static int YearOfIssueNotLower;              
        
        public Car()
        {
            milage = 0;
            mark = "default";
            gasoline = false;
            enginePower = 0;
            maxSpeed = 0;
            //Print();
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
                car3Cars[i] = new Car();
            }
            
            //Car2.Print();
            Console.WriteLine();
            Car1.MaxSpeed = 9;
            Console.WriteLine(Car1.MaxSpeed);
            Car1.Print(ref Car1);
            Console.WriteLine();
            Car1.Print();
            Console.WriteLine();
            Console.WriteLine(Car.carForeign);
        }
    }
}
