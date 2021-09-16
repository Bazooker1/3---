using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class MyNode<T>
    {
        public MyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public MyNode<T> Next { get; set; }
    }
    
    public class MyAVL
    {
        public int comps = 0;
        public class Node
        {
            public List<int> index;
            public string key;
            public Node left;
            public Node right;
            public Node(string key, int index)
            {
                this.index = new List<int>();
                this.index.Add(index);
                this.key = key;
                //this.index = index;
            }
        }
        public Node root;
        public MyAVL()
        {
        }
        public void Add(string data, int index)
        {
            Node newItem = new Node(data, index);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
        }
        private Node RecursiveInsert(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.key.CompareTo(current.key) > 0)
            {
                current.left = RecursiveInsert(current.left, n);
                current = balance_tree(current);
            }
            else if (n.key.CompareTo(current.key) == 0)
            {
                current.index.Add(n.index._root.Value);
                current = balance_tree(current);
            }
            else if (n.key.CompareTo(current.key) < 0)
            {
                current.right = RecursiveInsert(current.right, n);
                current = balance_tree(current);
            }
            return current;
        }

        private Node balance_tree(Node current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        public void Delete(string target)
        {//and here
            root = Delete(root, target);
        }
        private Node Delete(Node current, string target)
        {
            Node parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (target.CompareTo(current.key) > 0)
                {
                    current.left = Delete(current.left, target);
                    if (balance_factor(current) == -2)//here
                    {
                        if (balance_factor(current.right) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (target.CompareTo(current.key) < 0)
                {
                    current.right = Delete(current.right, target);
                    if (balance_factor(current) == 2)
                    {
                        if (balance_factor(current.left) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.right != null)
                    {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.key = parent.key;
                        current.right = Delete(current.right, parent.key);
                        if (balance_factor(current) == 2)//rebalancing
                        {
                            if (balance_factor(current.left) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }
        public List<int> finds;
        /*public int Find(MyDate key)
        {
            finds = new List<int>();
            if(Find(key, root) != null)
            {
                if (Find(key, root).data.compareDates(key)==0)
                {
                    Console.WriteLine("{0} was found!", key);
                    finds.Add(Find(key, root).index);
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Nothing found !");
                return -1;
            }

        }*/
        public Node Find(string target, Node current)
        {
            if ((current != null))
            {
                if (target.CompareTo(current.key) > 0)
                {
                    comps++;
                    if (target.CompareTo(current.key) == 0)
                    {
                        comps++;
                        var i = current.index._root;
                        finds.Add(i.Value);
                        i = i.Next;
                        while (i != current.index._root)
                        {
                            finds.Add(i.Value);
                            i = i.Next;
                        }

                        return Find(target, current.right);
                    }
                    else
                        return Find(target, current.left);
                }
                else
                {
                    if (target.CompareTo(current.key) == 0)
                    {
                        comps++;
                        var i = current.index._root;
                        finds.Add(i.Value);
                        i = i.Next;
                        while (i != current.index._root)
                        {
                            finds.Add(i.Value);
                            i = i.Next;
                        }
                        return Find(target, current.right);
                    }
                    else
                        return Find(target, current.right);
                }
            }
            else
            {
                return null;
            }
        }
        public List<int> findAll(string target)
        {
            comps = 0;
            //List<int> f = new List<int>();
            finds = new List<int>();
            Find(target, root);
            return finds;
        }
        public List<int> findInRange(string targetLeft, string targetRight)
        {
            comps = 0;
            finds = new List<int>();
            findInRangeHelp(root, targetLeft, targetRight);
            return finds;
        }
        public void findInRangeHelp(Node node, string targetLeft, string targetRight)
        {
            if (node == null)
            {
                return;
            }
            if (targetLeft.CompareTo(node.key) > 0)
            {
                comps++;
                findInRangeHelp(node.left, targetLeft, targetRight);
            }
            if ((targetLeft.CompareTo(node.key) >= 0) && (targetRight.CompareTo(node.key) <= 0))
            {
                comps++;
                var i = node.index._root;
                finds.Add(i.Value);
                i = i.Next;
                while (i != node.index._root)
                {
                    finds.Add(i.Value);
                    i = i.Next;
                }
            }
            if (targetRight.CompareTo(node.key) < 0)
            {
                comps++;
                findInRangeHelp(node.right, targetLeft, targetRight);
            }

        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(Node current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }
}
