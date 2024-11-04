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
        public static Point CalculateGlobalPosition<T>(Node<T> node)
        {
            if (node.Data is not Point currentPoint)
            {
                return Point.Empty;
            }

            if (node.Parent == null)
            {
                return currentPoint;
            }

            Point parentGlobalPosition = CalculateGlobalPosition(node.Parent);

            return new Point(parentGlobalPosition.X + currentPoint.X, parentGlobalPosition.Y + currentPoint.Y);
        }

    }
}
