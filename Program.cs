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
                new Node<Point>(new Point(0, 0)),
                new Node<Point>(new Point(-2, 2)),
                new Node<Point>(new Point(-1, 2)),
                new Node<Point>(new Point(1, 2)),
                new Node<Point>(new Point(0, 1)),

            };

            Node<Point> root = new Node<Point>(new Point(0, 0));

            nodesList.ForEach(node => {root.AddChild(node);});





/*            Console.WriteLine(Position.CalculateGlobalPosition(child1));
            Console.WriteLine(Position.CalculateGlobalPosition(child2));
            Console.WriteLine(Position.CalculateGlobalPosition(child3));


            Console.WriteLine(child1.GetGlobalPosition());
            Console.WriteLine(child2.GetGlobalPosition());
            Console.WriteLine(child3.GetGlobalPosition());*/



            /* Point aa = child1.GetGlobalPosition();
             Point bb = child2_1.GetGlobalPosition();

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
