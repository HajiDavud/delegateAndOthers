using System;
using System.Collections.Generic;

namespace homeWord2
{
    public delegate int Delegate(int eded1,int eded2);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> lst = new List<int>();
            lst.Add(3);
            lst.Add(2);
            lst.Add(5);
            Console.WriteLine("Eded * 3 Taski\n");
            List<int> newLst = fun1(lst);

            foreach(var i in newLst)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n\nEded Kuba Yukseltme Taski\n");

            newLst = fun2(lst);

            foreach (var i in newLst)
            {
                Console.WriteLine(i);
            }


            List<string> lst2 = new List<string>();
            lst2.Add("A");
            lst2.Add("B");
            lst2.Add("C");
            lst2.Add("D");
            List<string> newLst2 = new List<string>();
            Console.WriteLine("\n\n\n #X# Taski\n");

            newLst2 = fun3(lst2);

            foreach (var i in newLst2)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n\n\nCar Class indan alinan List");
            List<Car> Cars = new List<Car>();
            Car car1 = new Car("BMW", "E36", 4);
            Car car2 = new Car("AUDI", "RS7", 2);
            Car car3 = new Car("BMW", "E39",2);

            Cars.Add(car1);
            Cars.Add(car2);
            Cars.Add(car3);

            foreach(var i in Cars)
            {
                i.FullInfo();
            }


            Console.WriteLine("\n\n\n Task 6: Ages Byte Array");
            List<byte> ageLit = new List<byte>();
            ageLit.Add(11);
            ageLit.Add(12);
            List<byte> Ages = new List<byte>();
            Ages.Add(20);
            Ages.Add(18);
            Ages.Add(25);
            
            Ages.AddRange(ageLit);
            Ages.Insert(1,15);
            Ages.RemoveAt(0);
            Ages.Remove(18);
           
            foreach (var i in Ages)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n\n\n\nDelegate Task\n");
            List<Delegate> DelegateLst = new List<Delegate>();
            DelegateLst.Add(Sum);
            DelegateLst.Add(Subtraction);
            DelegateLst.Add(Multiplication);
            DelegateLst.Add(Division);
            foreach(var i in DelegateLst)
            {
                Console.WriteLine(i.Invoke(12,6));
            }

            //Burdakilari Ele Bele Yazmisam biu curde eleave edib
            Delegate myDelegate;
            myDelegate = new Delegate(Sum);
            Delegate myDelegate2 = Subtraction;
            myDelegate = new Delegate(Division);
            myDelegate = new Delegate(Multiplication);
        }


        public static List<int> fun1(List<int> lst)
        {
            List<int> newLst = new List<int>();
            foreach(var i in lst)
            {
                newLst.Add(i*3);
            }

            return newLst;
        }

        public static List<int> fun2(List<int> lst)
        {
            List<int> newLst = new List<int>();
            foreach (var i in lst)
            {
                newLst.Add(i * i * i);
            }

            return newLst;
        }

        public static List<string> fun3(List<string> lst)
        {
            List<string> newLst = new List<string>();
            foreach (var i in lst)
            {
                newLst.Add("#"+i+"#");
            }

            return newLst;
        }

        public static int Sum(int eded1,int eded2)
        {
            return eded1 + eded2;
        }
        public static int Subtraction(int eded1,int eded2)
        {
            return eded1 - eded2;
        }

        public static int Division(int eded1,int eded2)
        {
            return eded1 / eded2;

        }

        public static int Multiplication(int eded1,int eded2)
        {
            return eded1 * eded2;
        }


    }
    class Car
    {
        public string Brand { set; get; }
        public string Model { get; set; }
        public int DoorCount { get; set; }

        public Car(string brand,string model,int doorcount)
        {
            this.Brand = brand;
            this.Model = model;
            this.DoorCount = doorcount;

        }

        public void FullInfo()
        {
            Console.WriteLine("Brand: " + Brand + "\nModel: " + Model + "\nDoorCount: " + DoorCount+"\n\n");
        }

    }
}
