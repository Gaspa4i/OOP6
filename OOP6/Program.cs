using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Zadacha
    {
        public int num;
        public int num2;
        public Zadacha()
        {

        }
        public Zadacha(int chislo)
        {
            num = chislo;
        }
        public Zadacha(int chislo, int chislo2)
        {
            num = chislo;
            num2 = chislo2;
        }
        public void Print()
        {
            Console.WriteLine(num + "  -  " + num2);
        }
    }
    class Zadacha2
    {
        private string line = "Пусто";
        public void Write()
        {

        }
        public void Write(string line2)
        {
            if (line2.Length > 10) line = "Слишком длинная строка";
            else line = line2;
        }
        public void Print()
        {
            Console.WriteLine(line);
        }
    }
    class Zadacha3
    {
        public double a;
        public double b;
        public double c;
        public Zadacha3(int line, int line2, int line3)
        {
            a = line; b = line2; c = line3;
            if ((a + b > c) && (b + c > a) && (c + a > b)) Console.WriteLine("Треугольник возможен");
            else Console.WriteLine("Треуголник не возможен");
            double alpha = (Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))) * (180 / Math.PI);
            double beta = (Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * (180 / Math.PI);
            double gamma = (Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a))) * (180 / Math.PI);
            Console.WriteLine("Угол alpha = " + (alpha));
            Console.WriteLine("Угол beta = " + (beta));
            Console.WriteLine("Угол gamma = " + (gamma));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1 ");
            Console.WriteLine("");
            Zadacha Zadacha1 = new Zadacha();
            Zadacha Zadacha2 = new Zadacha(530);
            Zadacha Zadacha3 = new Zadacha(832, 42);

            Zadacha1.Print();
            Zadacha2.Print();
            Zadacha3.Print();
            Console.WriteLine("");

            Console.WriteLine("Задача №2 ");
            Console.WriteLine();
            Zadacha2 text1 = new Zadacha2();
            Zadacha2 text2 = new Zadacha2();
            Zadacha2 text3 = new Zadacha2();
            text1.Write();
            text2.Write("Gabe VALVE");
            text3.Write("Gabe Logan Newell - VALVE");

            text1.Print();
            text2.Print();
            text3.Print();
            Console.WriteLine("");

            Console.WriteLine("Задача №3 ");
            Console.WriteLine("");
            Zadacha3 triangle = new Zadacha3(10, 2, 6);
            Console.WriteLine("");
            Zadacha3 triangle2 = new Zadacha3(5, 3, 6);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}

