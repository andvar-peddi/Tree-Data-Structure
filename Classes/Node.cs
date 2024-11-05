using System.Drawing;

namespace Tree.Classes
{
    internal class Node<T>
    {
        public Node(T data, string name = "")
        {
            Data = data;
            Children = new List<Node<T>>();
            Name = name;
        }

        public string Name { get; set; }

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

        public void TraverseUpwards(Action<T> action)
        {
            action(Data);

            Parent?.TraverseUpwards(action);
        }


        public void DisplayNodes()
        {
            Traverse(data =>
            {
                if (data is Point point && Position.FindNode(this as Node<Point>, point) is Node<Point> node)
                {
                    Point globalPosition = Position.GetGlobalPosition(node);
                    string spacing = new(' ', node.GetDepth() * 4);

                    Console.WriteLine($"{spacing}Node: {node.Name}, Global Position: {globalPosition}");
                }
            });
        }

        public int GetDepth()
        {
            int depth = 0;
            Node<T> currentNode = this;

            while (currentNode.Parent != null)
            {
                currentNode = currentNode.Parent;
                depth++;
            }
            return depth;
        }
    }
}
