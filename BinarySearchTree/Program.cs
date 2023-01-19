namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            binarySearchTree.Add(56);
            binarySearchTree.Add(70);
            binarySearchTree.Add(30);
            binarySearchTree.Add(40);
            binarySearchTree.Add(60);
            binarySearchTree.Add(22);
            binarySearchTree.Add(95);
            binarySearchTree.Add(65);
            binarySearchTree.Add(11);
            binarySearchTree.Add(3);
            binarySearchTree.Add(63);
            binarySearchTree.Add(67);
            binarySearchTree.Add(16);
            int data = 63;
            Node<int> node = binarySearchTree.Find(data, binarySearchTree.Root);
            if (node == null)
            {
                Console.WriteLine($"{data} is not present in Binary Tree");
            }
            else
            {
                Console.WriteLine($"{node.Data} is Present in Binaray Tree");
            }

            Console.WriteLine(" Elements in Binary Trees ");
            binarySearchTree.DisplayInorder(binarySearchTree.Root);
            Console.WriteLine();
            binarySearchTree.Size();





        }
    }
}