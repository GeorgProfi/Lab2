using static LabsShareLibrary.Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestTree
{


    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]

        public void Test_append_1(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(1), $"rrr");
            Console.WriteLine(tree.Search(1)); // Output: True
        }
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 })]

        public void Test_append_2(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(1), $"rrr");
            Console.WriteLine(tree.Search(1)); // Output: True
        }
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, })]

        public void Test_append_3(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(1), $"rrr");
            Console.WriteLine(tree.Search(1)); // Output: True
        }
        [TestMethod]
        [DataRow(new char[] { '1', '2', '3' })]

        public void Test_append_4(char[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search('2'), $"rrr");
            Console.WriteLine(tree.Search('2')); // Output: True
        }
        [TestMethod]
        [DataRow(new char[] { 's', 'a', 's' })]
        public void Test_append_5(char[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search('s'), $"rrr");
            Console.WriteLine(tree.Search('s')); // Output: True
        }
        [TestMethod]
        [DataRow(new char[] { 's', 'a', 's' })]
        public void Test_append_6(char[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search('s'), $"rrr");
            Console.WriteLine(tree.Search('s')); // Output: True
        }

        [TestMethod]
        [DataRow(new char[] { 's', 'a', ' ' })]
        public void Test_append_7(char[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(' '), $"rrr");
            Console.WriteLine(tree.Search(' ')); // Output: True
        }

        [TestMethod]
        [DataRow(new char[] { 's', 'a', ' ', 'a', '1', '1', '1' })]
        public void Test_append_8(char[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search('1'), $"rrr");
            Console.WriteLine(tree.Search(' ')); // Output: True
        }
        [TestMethod]
        [DataRow(new int[] { 1,2,3,4,5,6,7,8,9,10 })]
        public void int_in_char(char[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search('1'), $"rrr");
            Console.WriteLine(tree.Search(' ')); // Output: True
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void Test_append_10(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(20), $"rrr");
            Console.WriteLine(tree.Search(20)); // Output: False
        }
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]

        public void Test_append_11(int[] values)
        {
            //вызов .Search несколько раз
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Console.WriteLine(tree.Search(1)); // Output: True
            Console.WriteLine(tree.Search(1)); // Output: True
            Console.WriteLine(tree.Search(1)); // Output: True
            Console.WriteLine(tree.Search(1)); // Output: True
            Assert.IsTrue(tree.Search(1), $"rrr");
            
        }
        [TestMethod]
        [DataRow(new string[] { "Вася","Петя","Андрей" })]

        public void Test_append_12(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(1), $"rrr");
            Console.WriteLine(tree.Search(1)); // Output: True
        }
        [TestMethod]
        [DataRow(new int[] {6,6,6,6,6,6,6,6})]

        public void Test_append_13(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(6), $"rrr");
            Console.WriteLine(tree.Search(1)); // Output: True
        }
        [TestMethod]
        [DataRow(new int[] { 6, 6, 6, 6, 6, 6, 6, 6 })]

        public void Test_append_14(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(6), $"rrr");
            Console.WriteLine(tree.Search(1)); // Output: True
        }

        [TestMethod]
        [DataRow(new float[] { 6, 6, 6, 6, 6, 6, 6, 6 })]

        public void Test_append_15(int[] values)
        {
            Tree tree = new Tree();
            for (int i = 0; i < values.Length; i++)
            {
                tree.Insert(values[i]);
            }
            Assert.IsTrue(tree.Search(6), $"rrr");
            Console.WriteLine(tree.Search(1)); // Output: True
        }
    }
}