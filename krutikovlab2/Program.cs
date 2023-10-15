using LabsShareLibrary;
using static LabsShareLibrary.Lab2;

namespace krutikovlab2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            Tree tree = new Tree();

            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);

            Console.WriteLine(tree.Search(3)); // Output: True
            Console.WriteLine(tree.Search(5)); // Output: False
        }
    }
}