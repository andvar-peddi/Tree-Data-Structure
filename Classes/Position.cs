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
        public static Point CalculateGlobalPosition(Node<Point> node)
        {
            if (node is null)
            {
                return Point.Empty;
            }

            Point parentGlobalPosition = node.Parent != null 
                ? CalculateGlobalPosition(node.Parent) 
                : Point.Empty;

            return new Point(parentGlobalPosition.X + node.Data.X, parentGlobalPosition.Y + node.Data.Y);
        }
    }
}
