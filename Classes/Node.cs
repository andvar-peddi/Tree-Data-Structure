using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Classes
{
    internal class Node<T>
    {
        public Node(T data)
        {
            Data = data;
            Children = new List<Node<T>>();
        }

        public T Data { get; set; }

        public List<Node<T>> Children { get; set; }

        public Node<T>? Parent { get; set; }


        public void AddChild(Node<T> node)
        {
            Children.Add(node);
            node.Parent = this;
        }

        public void RemoveChild(Node<T> node)
        {
            node.Parent = null;
            Children.Remove(node);
        }

        public void Traverse(Action<T> action)
        {
            action(Data);

            foreach (var child in Children)
            {
                child.Traverse(action);
            }
        }

        public Point GetGlobalPosition()
        {
            if (Data is not Point currentPoint)
            {
                return Point.Empty;
            }

            if (Parent == null)
            {
                return currentPoint;
            }

            Point parentGlobalPosition = Parent.GetGlobalPosition();
            return new Point(parentGlobalPosition.X + currentPoint.X, parentGlobalPosition.Y + currentPoint.Y);
        }
    }
}
