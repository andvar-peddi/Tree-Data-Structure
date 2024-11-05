using Microsoft.VisualBasic;
using System.ComponentModel.Design.Serialization;
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
            Node<Point> root = new Node<Point>(new Point(10, 10), "Root");
            root.AddChild(new Node<Point>(new Point(6, 6), "firstChild"));
            root.AddChild(new Node<Point>(new Point(9, 9), "secondChild"));
            root.AddChild(new Node<Point>(new Point(8, 8), "thirdChild"));
            root.AddChild(new Node<Point>(new Point(4, 4), "fourthChild"));

            root.Children[0].AddChild(new Node<Point>(new Point(20, 20), "Johnny"));
            root.Children[0].AddChild(new Node<Point>(new Point(30, 30), "Jimmy"));

            var aa = Position.FindNode(root, new Point(8, 8));
            int depth = root.Children[0].Children[0].GetDepth();

            root.Children[0].Children[0].TraverseUpwards(data =>
            {
                var currentNode = Position.FindNode(root, data);
                Console.WriteLine(Position.GetGlobalPosition(currentNode));
            });
        }
    }
}
