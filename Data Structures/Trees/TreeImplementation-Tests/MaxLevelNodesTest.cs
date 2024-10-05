using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Tests
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void TestTreeWithMultipleLevels()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            int maxLevel = Btree.FindMaxLevelNodes();
            Assert.Equal(2, maxLevel);
        }

        [Fact]
        public void TestTreeWithSameMaxNodesAtDifferentLevels()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(7);
            Btree.Root.Left.Left.Left = new Node(8);
            Btree.Root.Left.Right.Left = new Node(9);
            Btree.Root.Right.Right.Left = new Node(10);

            int maxLevel = Btree.FindMaxLevelNodes();
            Assert.Equal(2, maxLevel);
        }

        [Fact]
        public void TestEmptyTree()
        {
            BinaryTree Btree = new BinaryTree();
            int maxLevel = Btree.FindMaxLevelNodes();
            Assert.Equal(-1, maxLevel);
        }
    }

}
