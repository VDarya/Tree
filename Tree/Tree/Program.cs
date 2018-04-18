using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree tree = new SearchTree();
            tree.Insert("h");
            tree.Insert("l");
            tree.Insert("a");
            tree.Insert("c");
            tree.Insert("b");
            tree.Insert("e");

            Console.WriteLine("Tree: " + tree.Display(tree));
            SearchTree partOfTree = tree.Search("c");
            Console.WriteLine("Search: " + partOfTree.Display(partOfTree));
            Console.Read();
        }
    }
}
