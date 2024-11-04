using Microsoft.VisualBasic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Tree.Classes;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nodesList = new List<Node<Point>>()
            {
                new Node<Point>(new Point(5, 5)),
                new Node<Point>(new Point(-2, 2)),
                new Node<Point>(new Point(-1, 2)),
                new Node<Point>(new Point(1, 2)),
                new Node<Point>(new Point(0, 1)),

            };

            Node<Point> root = new Node<Point>(new Point(10, 10));
            root.AddChild(new Node<Point>(new Point(6, 6)));
            root.AddChild(new Node<Point>(new Point(9, 9)));
            root.AddChild(new Node<Point>(new Point(8, 8)));
            root.AddChild(new Node<Point>(new Point(4, 4)));

            foreach (var node in root.Children)
            {
                Console.WriteLine(Position.CalculateGlobalPosition(node));
            }


            /* root.Traverse(data => Console.WriteLine(Position.CalculateGlobalPosition(data)));

             /*
                         List<string> names = new List<string>();
                         names.Add("Bruce");
                         names.Add("Alfred");
                         names.Add("Tim");
                         names.Add("Richard");

                         names.ForEach(s => Console.WriteLine($"my name is {s}"));*/
        }

        static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
