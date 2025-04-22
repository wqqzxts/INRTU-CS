using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Даны вещественные положительные числа a, b, c. Если существует треугольник со сторонами a, b, c, то определить, является ли он прямоугольным.
*/

namespace @if {
    public class UserInterface {
        public static void Main(string[] args) {
            Console.WriteLine("Enter triangle sides:");

            double a = 0;
            do {
                try {
                    Console.Write("a: ");
                    a = double.Parse(Console.ReadLine());
                    if (a <= 0) { Console.WriteLine("Input error. Enter only positive numbers"); }
                } 
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
            } while (a <= 0);
            
            double b = 0;
            do {
                try {
                    Console.Write("b: ");
                    b = double.Parse(Console.ReadLine());
                    if (b <= 0) { Console.WriteLine("Input error. Enter only positive numbers"); }
                } 
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
            } while (b <= 0);
            
            double c = 0;
            do {
                try {
                    Console.Write("c: ");
                    c = double.Parse(Console.ReadLine());
                    if (c <= 0) { Console.WriteLine("Input error. Enter only positive numbers"); }
                } 
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
            } while (c <= 0);
            string Output = Logic.checkTriangle(a, b, c);
            Console.WriteLine(Output);
            Console.Read();
        }
    }

    public class Logic { 
        public static string checkTriangle(double a, double b, double c) {
            double Accuracy = 0.01;
            bool isTriangle = false;
            bool isRight = false;
            if (a + b > c && a + c > b && b + c > a) {
                isTriangle = true;
                if (Math.Abs(a * a + b * b - c * c) < Accuracy || Math.Abs(a * a + c * c - b * b) < Accuracy || Math.Abs(b * b + c * c - a * a) < Accuracy) {
                    isRight = true;
                }
            }
            if (isTriangle) {
                if (isRight) {
                    return "Triangle is exist & right";
                }
                return "Triangle is exist";
            } 
            else {
                return "Triangle is not exist";
            }   
        }
    }
}

