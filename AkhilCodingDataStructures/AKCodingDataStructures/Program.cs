using System;
using System.Collections;
using System.Collections.Generic;

namespace AKCodingDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your Options:"
                              + "\n 1) Frequently Occuring Item"
                              + "\n 2) Common Elements In Two Sorted Arrays"
                              + "\n 3) Common Elements In Two Sorted Arrays UsingDictionary"
                              + "\n 4) Array Rotation"
                              + "\n 5) Non Repeating character using conversion of string to array as input"
                              + "\n 6) Non Repeating character using string as input"
                              + "\n 7) One Edit Away"
                              + "\n 8) Mine Sweeper"
                              + "\n 9) Mine Sweeper Click Using Jagged Array"
                              + "\n 10) Mine Sweeper Click Using 2D Array"
                              + "\n 11) Roatate 2D Array 90 Degrees Out Of Place Solution(By Creating A New Array)"
                              + "\n 12) Roatate 2D Array 90 Degrees In Place Solution (Without Creating A New Array)"
                              + "\n 13) Nth Element Of A Linked List"
                              + "\n 14) Binary Search tree"
                              + "\n 15) Lowest Common Ancestor"
                              + "\n 16) given three numbers,  and c. Write a program to find the largest number which is less than or equal to c and leaves a remainder b when divided by a.");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int[] array1_1 = new[] { 1, 3, 1, 3, 2, 1 };
                    int result1 = FrequentlyOccuringItem(array1_1);
                    Console.WriteLine(result1);
                    Console.ReadLine();
                    break;

                case 2:
                    int[] array2_1 = new[] { 1, 3, 4, 6, 7, 9 };
                    int[] array2_2 = new[] { 1, 2, 4, 5, 9, 10 };
                    List<int> result2 = CommonElementsInTwoSortedArrays(array2_1, array2_2);
                    for (int i = 0; i < result2.Count; i++)
                    {
                        Console.Write(result2[i] + " ");
                    }

                    Console.ReadLine();
                    break;

                case 3:
                    int[] array3_1 = new[] { 1, 3, 4, 6, 7, 9 };
                    int[] array3_2 = new[] { 1, 2, 4, 5, 9, 10 };
                    List<int> result3 = CommonElementsInTwoSortedArraysUsingDictionary(array3_1, array3_2);
                    for (int i = 0; i < result3.Count; i++)
                    {
                        Console.Write(result3[i] + " ");
                    }

                    Console.ReadLine();
                    break;

                case 4:
                    int[] array4_1 = new[] { 1, 2, 3, 4, 5, 6, 7 };
                    int[] array4_2 = new[] { 4, 5, 6, 7, 1, 2, 3 };
                    bool result4 = ArrayRotation(array4_1, array4_2);
                    Console.WriteLine(result4 == true
                        ? "Success!!!.. Given Two Arrays are in Rotation"
                        : "Sorry...Given Two Arrays are not in Rotation");
                    Console.ReadLine();
                    break;

                case 5:
                    string s5_1 = "abbacd";
                    char[] array5_1 = s5_1.ToCharArray();
                    char result5 = NonRepeatingCharacterForStringToArrayConversion(array5_1);
                    Console.Write(result5);
                    Console.ReadLine();
                    break;

                case 6:
                    string s6 = "abbaecd";
                    char result6 = NonRepeatingCharacterForString(s6);
                    Console.Write(result6);
                    Console.ReadLine();
                    break;

                case 7:
                    string s7_1 = "abacd";
                    string s7_2 = "abace";
                    bool result7 = IsOneEditAway(s7_1, s7_2);
                    Console.WriteLine(result7 == true
                        ? "\nSuccess!!!.. Given Two strings are one edit away"
                        : "\nSorry...Given Two strings are not one edit away");
                    Console.ReadLine();
                    break;

                case 8:
                    int[][] bombs = { new[] { 0, 0 }, new[] { 0, 1 } };
                    int[,] result8 = MineSweeper(bombs, 3, 4);
                    for (int i = 0; i < result8.GetLength(0); i++)
                    {
                        for (int j = 0; j < result8.GetLength(1); j++)
                        {
                            Console.Write(string.Format("\t{0}", result8[i, j]));
                        }
                        Console.WriteLine();
                    }

                    Console.ReadLine();
                    break;

                case 9:
                    int[][] field9 = {new[]{-1, 1, 0, 0},
                       new[] {1, 1, 0, 0},
                        new[]{0, 0, 1, 1},
                       new[] {0, 0, 1, -1}};
                    int[][] result9 = MineSweeperClickWithJaggedArray(field9, 4, 4, 1, 2);
                    foreach (int[] resultingArray in result9)
                    {
                        foreach (int element in resultingArray)
                        {
                            Console.Write("  " + element.ToString());
                        }
                        Console.WriteLine();
                    }

                    Console.ReadLine();
                    break;

                case 10:
                    int[,] field10 = new int[4, 4]{{-1, 1, 0, 0},
                       {1, 1, 0, 0},
                        {0, 0, 1, 1},
                      {0, 0, 1, -1}};
                    int[,] result10 = MineSweeperClickWith2DArray(field10, 4, 4, 1, 2);
                    for (int i = 0; i < result10.GetLength(0); i++)
                    {
                        for (int j = 0; j < result10.GetLength(1); j++)
                        {

                            Console.Write(string.Format("  " + "{0}", result10[i, j]));

                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                    break;

                case 11:
                    int[,] field11 = new int[4, 4] {
                        {1, 2, 3, 4},
                        {5, 6, 7, 8},
                        {9, 10, 11, 12},
                        {13, 14, 15, 16}
                    };
                    int[,] result11 = RotationOf2DArrayOutOfPlace(field11, 4);
                    for (int i = 0; i < result11.GetLength(0); i++)
                    {
                        for (int j = 0; j < result11.GetLength(1); j++)
                        {
                            Console.Write(string.Format("  " + "{0}", result11[i, j]));
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                    break;

                case 12:
                    int[,] field12 = new int[3, 3] {
                        {1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}

                    };
                    int[,] result12 = RotationOf2DArrayInPlace(field12, 3);
                    for (int i = 0; i < result12.GetLength(0); i++)
                    {
                        for (int j = 0; j < result12.GetLength(1); j++)
                        {
                            Console.Write(string.Format("  " + "{0}", result12[i, j]));
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                    break;

                case 13:
                    Node head13 = new Node(1, null);
                    for (int i = 2; i < 8; i++)
                    {
                        head13 = new Node(i, head13);
                    }
                    Node result13 = NthFromLastNode(head13, 5);
                    Console.WriteLine(result13.Value);
                    Console.ReadLine();
                    break;

                case 14:
                    Dictionary<int, int[]> Tree14 = new Dictionary<int, int[]>();
                    int[] ChildNode14A = new int[] { 1, 5 };
                    int[] ChildNode14B = new int[] { 0, 2 };
                    int[] ChildNode14C = new int[] { 4, 6 };
                    Tree14[3] = ChildNode14A;
                    Tree14[1] = ChildNode14B;
                    Tree14[5] = ChildNode14C;
                    NodeBst head14 = BinarySearchTree.CreatingTree(Tree14, 3);
                    bool result14 = IsBinarySearchTree(head14, null, null);
                    Console.WriteLine(result14 == true
                        ? "The Given Tree Is Binary Search Tree"
                        : "The Given Tree Is Not Binary Search Tree");
                    Console.ReadLine();
                    break;

                case 15:
                    Dictionary<int, int[]> Tree15 = new Dictionary<int, int[]>();
                    int[] ChildNode15A = new int[] { 1, 4 };
                    int[] ChildNode15B = new int[] { 3, 8 };
                    int[] ChildNode15C = new int[] { 9, 2 };
                    int[] ChildNode15D = new int[] { 6, 7 };
                    Tree15[5] = ChildNode15A;
                    Tree15[1] = ChildNode15B;
                    Tree15[4] = ChildNode15C;
                    Tree15[3] = ChildNode15D;
                    NodeBst head15 = BinarySearchTree.CreatingTree(Tree15, 5);
                    NodeBst result15 = LeastCommonAncestor(head15, 8, 7);
                    Console.WriteLine(result15 == null ? "Null. The entered node doesn't exist" : result15.Value.ToString());
                    Console.ReadLine();
                    break;

                case 16:
                    Console.WriteLine("Please enter the test cases: ");
                    int testcases = Convert.ToInt32(Console.ReadLine());
                    int[] arrayresult16 = new int[testcases];
                    for (int i = 0; i < testcases; i++)
                    {

                        var input16 = Console.ReadLine();

                        int result16 = LargestNumber(Convert.ToInt32(input16.Split(' ')[0]), Convert.ToInt32(input16.Split(' ')[1]), Convert.ToInt32(input16.Split(' ')[2]));

                        arrayresult16[i] = result16;
                    }

                    for (int i = 0; i < testcases; i++)
                    {
                        Console.WriteLine(arrayresult16[i]);
                    }

                    Console.ReadLine();
                    break;
            }
        }

        static int FrequentlyOccuringItem(int[] array)
        {
            int max_count = -1;
            int max_item = 0;
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int i in array)
            {
                if (!count.ContainsKey(i))
                    count[i] = 1;
                else
                    count[i] += 1;
                if (count[i] > max_count)
                {
                    max_count = count[i];
                    max_item = i;
                }
            }

            return max_item;

        }

        static List<int> CommonElementsInTwoSortedArrays(int[] array1, int[] array2)
        {
            List<int> common_items = new List<int>();
            int p1 = 0, p2 = 0;
            while (p1 < array1.Length && p2 < array2.Length)
            {
                if (array1[p1] == array2[p2])
                    common_items.Add(array1[p1]);
                else if (array1[p1] > array2[p2])
                    p2 += 1;
                else
                    p1 += 1;
            }
            return common_items;
        }


        static List<int> CommonElementsInTwoSortedArraysUsingDictionary(int[] array1, int[] array2)
        {
            List<int> common_items = new List<int>();
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int i in array1)
            {
                count[i] = 1;
            }
            foreach (int i in array2)
            {
                if (!count.ContainsKey(i))
                    count[i] = 1;
                else
                    count[i] += 1;
                if (count[i] == 2)
                {

                    common_items.Add(i);
                }
            }
            return common_items;
        }

        static bool ArrayRotation(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            int key_1 = array1[0];
            int key_2 = -1;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] == key_1)
                {
                    key_2 = i;
                    break;
                }
            }
            if (key_2 == -1)
                return false;
            for (int i = 0; i < array1.Length; i++)
            {
                int j = (key_2 + i) % array1.Length;
                if (array1[i] != array2[j])
                    return false;
            }
            return true;
        }

        static char NonRepeatingCharacterForStringToArrayConversion(char[] array1)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (char i in array1)
            {
                if (!count.ContainsKey(i))
                    count[i] = 1;
                else
                    count[i] += 1;
            }
            foreach (char i in array1)
            {
                if (count[i] == 1)
                    return i;
            }
            return ' ';
        }

        static char NonRepeatingCharacterForString(String s)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (char i in s)
            {
                if (!count.ContainsKey(i))
                    count[i] = 1;
                else
                    count[i] += 1;
            }
            foreach (char i in s)
            {
                if (count[i] == 1)
                    return i;
            }
            return ' ';
        }


        static bool IsOneEditAway(String s1, String s2)
        {
            if (s1.Length - s2.Length > 1 || s2.Length - s1.Length > 1)
                return false;
            else if (s1.Length == s2.Length)
                return IsOneEditAwaySameLength(s1, s2);
            else if (s1.Length > s2.Length)
                return IsOneEditAwayDifferentLength(s1, s2);
            else
                return IsOneEditAwayDifferentLength(s2, s1);
        }

        static bool IsOneEditAwaySameLength(String s1, String s2)
        {
            int count_diff = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    count_diff += 1;
                    if (count_diff > 1)
                        return false;
                }
            }
            return true;
        }


        static bool IsOneEditAwayDifferentLength(String s1, String s2)
        {
            int i = 0, count_diff = 0;
            while (i < s2.Length)
            {
                if (s1[i + count_diff] == s2[i])
                    i++;
                else
                {
                    count_diff++;
                    if (count_diff > 1)
                        return false;
                }
            }
            return true;
        }

        static int[,] MineSweeper(int[][] bombs, int num_rows, int num_cols)
        {
            int[,] field = new int[num_rows, num_cols];
            foreach (int[] bomb in bombs)
            {
                int rows = bomb[0];
                int cols = bomb[1];
                field[rows, cols] = -1;
                for (int i = rows - 1; i <= rows + 1; i++)
                {
                    for (int j = cols - 1; j <= cols + 1; j++)
                    {
                        if (0 <= i && i < num_rows && 0 <= j && j < num_cols && field[i, j] != -1)
                        {
                            field[i, j] += 1;
                        }
                    }
                }
            }
            return field;
        }

        static int[][] MineSweeperClickWithJaggedArray(int[][] field, int num_rows, int num_cols, int clicked_i, int clicked_j)
        {
            Queue<int[]> to_check = new Queue<int[]>();
            if (field[clicked_i][clicked_j] == 0)
            {
                field[clicked_i][clicked_j] = -2;
                int[] coordinates = { clicked_i, clicked_j };
                to_check.Enqueue(coordinates);
            }
            else
                return field;

            while (to_check.Count != 0)
            {
                int[] currentCoordinates = to_check.Dequeue();
                int current_i = currentCoordinates[0];
                int current_j = currentCoordinates[1];

                for (int i = current_i - 1; i <= current_i + 1; i++)
                {
                    for (int j = current_j - 1; j <= current_j + 1; j++)
                    {
                        if (0 <= i && i < num_rows && 0 <= j && j < num_cols && field[i][j] == 0)
                        {
                            field[i][j] = -2;
                            int[] coordinates = { i, j };
                            to_check.Enqueue(coordinates);
                        }
                    }
                }
            }

            return field;
        }

        static int[,] MineSweeperClickWith2DArray(int[,] field, int num_rows, int num_cols, int clicked_i, int clicked_j)
        {
            Queue<int[]> to_check = new Queue<int[]>();
            if (field[clicked_i, clicked_j] == 0)
            {
                field[clicked_i, clicked_j] = -2;
                int[] coordinates = { clicked_i, clicked_j };
                to_check.Enqueue(coordinates);
            }
            else
                return field;

            while (to_check.Count != 0)
            {
                int[] currentCoordinates = to_check.Dequeue();
                int current_i = currentCoordinates[0];
                int current_j = currentCoordinates[1];

                for (int i = current_i - 1; i <= current_i + 1; i++)
                {
                    for (int j = current_j - 1; j <= current_j + 1; j++)
                    {
                        if (0 <= i && i < num_rows && 0 <= j && j < num_cols && field[i, j] == 0)
                        {
                            field[i, j] = -2;
                            int[] coordinates = { i, j };
                            to_check.Enqueue(coordinates);
                        }
                    }
                }
            }

            return field;
        }

        static int[,] RotationOf2DArrayOutOfPlace(int[,] Array1, int n)
        {
            //int[,] Array2 = new int[n,n];
            //Array.Copy(Array1, Array2, n);
            int[,] Array2 = (int[,])Array1.Clone();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Array2[j, n - 1 - i] = Array1[i, j];
                }
            }
            return Array2;
        }

        static int[,] RotationOf2DArrayInPlace(int[,] array1, int n)
        {
            for (int i = 0; i < (n / 2) + (n % 2); i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int[] temp = new int[] { -1, -1, -1, -1 };
                    int current_i = i;
                    int current_j = j;
                    for (int k = 0; k <= 3; k++)
                    {
                        temp[k] = array1[current_i, current_j];
                        int[] newCoordinates = RotateSub(current_i, current_j, n);
                        current_i = newCoordinates[0];
                        current_j = newCoordinates[1];
                    }
                    for (int k = 0; k <= 3; k++)
                    {
                        array1[current_i, current_j] = temp[(k + 3) % 4];
                        int[] newCoordinates = RotateSub(current_i, current_j, n);
                        current_i = newCoordinates[0];
                        current_j = newCoordinates[1];
                    }
                }
            }
            return array1;
        }

        static int[] RotateSub(int i, int j, int n)
        {
            int[] newCoordinates = new int[2];
            newCoordinates[0] = j;
            newCoordinates[1] = n - 1 - i;
            return newCoordinates;
        }

        static Node NthFromLastNode(Node head, int n)
        {
            Node left = head;
            Node right = head;
            for (int i = 0; i <= n - 1; i++)
            {
                if (right == null)
                {
                    return null;
                }
                right = right.Next;
            }

            while (right != null)
            {
                right = right.Next;
                left = left.Next;
            }

            return left;
        }

        static bool IsBinarySearchTree(NodeBst node, int? lowerLimit, int? upperLimit)
        {
            if (lowerLimit != null && node.Value < lowerLimit)
                return false;
            if (upperLimit != null && upperLimit < node.Value)
                return false;
            bool isLeftBst = true;
            bool isRightBst = true;

            if (node.Left != null)
            {
                isLeftBst = IsBinarySearchTree(node.Left, lowerLimit, node.Value);
            }
            if (isLeftBst && node.Right != null)
            {
                isRightBst = IsBinarySearchTree(node.Right, node.Value, upperLimit);
            }
            return isLeftBst && isRightBst;
        }


        static NodeBst LeastCommonAncestor(NodeBst root, int j, int k)
        {
            Stack PathToJ = new Stack();
            PathToJ = PathToX(root, j);
            Stack PathToK = new Stack();
            PathToK = PathToX(root, k);
            if (PathToJ == null || PathToK == null)
                return null;
            NodeBst LcaToReturn = null;

            while (PathToJ.Count != 0 && PathToK.Count != 0)
            {
                object jPop = PathToJ.Pop();
                object kPop = PathToK.Pop();
                if (jPop == kPop)
                    LcaToReturn = (NodeBst)jPop;
                else
                {
                    break;
                }
            }

            return LcaToReturn;
        }


        static Stack PathToX(NodeBst root, int x)
        {
            if (root == null)
                return null;

            if (root.Value == x)
            {
                Stack path = new Stack();
                path.Push(root);
                return path;
            }

            Stack LeftPath = PathToX(root.Left, x);
            if (LeftPath != null)
            {
                LeftPath.Push(root);
                return LeftPath;
            }

            Stack RightPath = PathToX(root.Right, x);
            if (RightPath != null)
            {
                RightPath.Push(root);
                return RightPath;
            }

            return null;

        }

        static int LargestNumber(int a, int b, int c)
        {
            if (c == 0 || a == 0 || b == 0)
                return -1;
            else if (a > b)
            {
                while (true)
                {
                    c--;
                    if (c % a == b)
                    {
                        break;
                    }
                }
            }
            else
            {
                return -1;
            }

            return c;
        }


    }

    class Node
    {
        public int Value;
        public Node Next;


        public Node(int value, Node next)
        {

            this.Next = next;
            this.Value = value;
        }
    }

    class NodeBst
    {
        public NodeBst Left;
        public NodeBst Right;
        public int Value;

        public NodeBst(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;

        }

    }

    class BinarySearchTree
    {

        public static NodeBst CreatingTree(Dictionary<int, int[]> tree, int head)
        {
            NodeBst newhead = new NodeBst(head);
            Dictionary<int, NodeBst> nodes = new Dictionary<int, NodeBst>
            {
                { head, newhead }
            };
            foreach (int key in tree.Keys)
            {
                int[] value = tree[key];
                NodeBst leftChild = new NodeBst(value[0]);
                NodeBst rightChild = new NodeBst(value[1]);
                nodes[value[0]] = leftChild;
                nodes[value[1]] = rightChild;
            }

            foreach (int key in tree.Keys)
            {
                int[] value = tree[key];
                nodes[key].Left = nodes[value[0]];
                nodes[key].Right = nodes[value[1]];
            }

            return newhead;
        }
    }
}
