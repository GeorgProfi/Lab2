using static LabsShareLibrary.Lab2;

namespace TestTree
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(new int[] { 1,2,3,4,5 })]
        public void Test_append_1 (int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }

            Console.WriteLine(tree.Search(1)); // Output: True
        }
        [TestMethod]
        public void Test_append_2()
        {
            Tree tree = new Tree();
            tree.Insert(4);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(1);

            

            Console.WriteLine(tree.Search(3)); // Output: True
            Console.WriteLine(tree.Search(5)); // Output: False
        }
    }
}