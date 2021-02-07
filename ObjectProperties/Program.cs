using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// how to use Object Properity 
namespace ObjectProperties
{
    class Program
    {
        //static void newKind(object newk, EventArgs e)
        //{
        //    Events ev = (Events)newk;
        //Console.WriteLine("firut change  to {0}", ev.Kind);
        //}
        //public struct Coords
        //{
        //    public double x, y;
        //}
        

        enum month
        {
            jan,
            feb,
            mar

        }
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.AppendText("D:/kal Academy/C#/IO test/filename.txt");  // Create a file and write the contents of writeText to it
            //File.WriteAllText("D:\kal Academy\C#\IO test.")
            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
            switchTest st = new switchTest();
            st.sw();

        //Animal a = new Animal();
        //month m = month.jan;
        //    int val = (int)m;
        //    Console.WriteLine($"the output{m}");
        //    Console.WriteLine($"the out put = {val}");
        //    Animal b = new cat();
        //    Animal c = new Dog();
        //   //// a.animalSound();
           // b.animalSound();
           // c.animalSound();
            
            //car c = new car();
            //c.Model = "opel";
            //c.Year = 2020;
            //Console.WriteLine($"the  values{c.Model}, {c.Year} ");
            //Person p = new Person();
            //p.Name = "mike";
            //p.Age = 88;
            //Console.WriteLine($"the name value: { p.Name}and age {p.Age}");
            //Person p2 = new Person();
            //p2.Age = 20;
            //p2.Name = "mike5";
            //Console.WriteLine($"the name value: { p2.Name} and age equal to {p2.Age}");
            //string pathSource = @"D:\kal Academy\C#\IO test\source.txt";
            //string pathNew = @"D:\kal Academy\C#\IO test\dest.txt";
            //IOFileStreams fs = new IOFileStreams(pathSource, pathNew);
            //fs.readFile();

            //int ? optionalInt;
            //optionalInt = 5;
            //string? optionalText = default;
            //optionalText = "Hello World.";
            //delegate decimal somemath(int x, int y);
            //int x = 1;
            //Console.WriteLine(x--);
            //Console.WriteLine(x);
            //Func<int, int, decimal> simplemath = AddTwoNumbers;


            //DrivedClass DC = new DrivedClass("apple", 0.5);
            //      double cost;
            //      cost = DC.GetCost();
            //Console.WriteLine($"kind :{DC.Kind} and cost :${cost}");
            ////Firute2 f = new Firute2();
            //Console.WriteLine($"the static value is {Firute2.FType} , the values directly accessed {f.GetCost()}");

            //    Coords co = new Coords();
            //    co.x = 100;
            //    co.y = 200;
            //    Coords co2 = co;
            //    Console.WriteLine($"the values of co2x{ co2.x}");
            //    Console.WriteLine($"the values of co2x{ co.x}");
            //    co.x = 500;
            //    Console.WriteLine($"the values of co2x{ co2.x}");
            //    Console.WriteLine($"the values of co2x{ co.x}");

            //Events ev = new Events();
            //ev.NewEvent += new EventHandler(newKind);
            //ev.Kind = "apple";
            //ev.Kind = "banana";
            //ev.Kind = "orange";
            // Firute3 f = new Firute3("apple", 0.5);
            //string s = f.GetKind();
            //double d = f.GetCost();
            //Firute2 f = new Firute2();
            //f.Kind = "macintosh";
            //f.Cost = 0.5;
            //String newf = f.GetFiruit();
            //double newc = f.GetCost();
            // Console.WriteLine($"the cost of {s} equal to {d}");
            //Firute firute = new Firute("apple", 0.5,12);
            //string item = firute.Getkind();
            //double tcost = firute.getTotalCost();
            Console.WriteLine("this is my main page");

            //Console.WriteLine($"The Cost of the :{item} is equalto ${tcost}");
            System.Console.ReadLine();


        }

        //delegate decimal MathDelegate(int firist, int seconde);
        //private static MathDelegate matdel = null;

        //static void DelegateBasics()
        //{
        //    matdel += new MathDelegate(AddAndGoForward);
        //    //matdel += SubtractAndBePositive
        //         int a = 10;
        //         int b = 20;
        //    decimal resurnval = matdel.Invoke(a, b);
        //    Console.WriteLine(resurnval);
        //}
        

        //public void newKind(object newk , EventArgs e)
        //{
        //    Events ev = (Events)newk;
        //    Console.WriteLine(" the kind of item {0}", ev.kind);
        //}
        // class Firute
        //{
        //    private string kind;
        //    private double cost;
        //    private double amount;

        //    public Firute(string k, double c, double a)
        //        {
        //        kind = k;
        //        cost = c;
        //        amount = a;

        //        }

        //    public string  Getkind()
        //    {
        //        return kind;
        //    }

        //    public double getTotalCost()
        //    {
        //        return cost * amount;

        //    }

        //}
    }
}
