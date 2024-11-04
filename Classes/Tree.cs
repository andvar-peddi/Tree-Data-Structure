using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tree.Classes
{
    internal class Tree<T>
    {
        public Tree(T rootData)
        {
            Root = new Node<T>(rootData);
        }

        public Node<T> Root { get;  private set; }


        public Node<T> AddNode(T data, Node<T> parent)
        {
            var newNode = new Node<T>(data)
            {
                Parent = parent
            };

            parent.AddChild(newNode);

            return newNode;
        }

        public void RemoveNode(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            if (node == Root)
            {
                Root.Children.Clear();
            }
            else
            {
                node.Parent?.RemoveChild(node);
            }
        }
    }
}
