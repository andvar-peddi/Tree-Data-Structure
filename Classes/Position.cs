using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Classes
{
    internal class Position
    {
        public static Point GetGlobalPosition(Node<Point>? node)
        {
            if (node == null)
            {
                return Point.Empty;
            }

            Point parentGlobalPosition = node.Parent != null 
                ? GetGlobalPosition(node.Parent) 
                : Point.Empty;


            return new Point(parentGlobalPosition.X + node.Data.X, parentGlobalPosition.Y + node.Data.Y);
        }

        public static Node<Point>? FindNode(Node<Point>? root, Point data)
        {
            if (root is null || root.Data.Equals(data))
            {
                return root is null ? null : root;
            }
            else
            {
                foreach (var child in root.Children)
                {
                    Node<Point>? result = FindNode(child, data);
                    if (result != null)
                    {
                        return result;
                    }
                }

            }

            return null;
        }
    }
}
