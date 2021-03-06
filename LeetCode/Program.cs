﻿using System;
using System.Collections.Generic;
using System.Text;
using DynamicPrograming;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = "\tab";
            Console.WriteLine(testStr.Length);
            Console.WriteLine(testStr.LastIndexOf('\t'));
            Console.WriteLine(testStr.Substring(2, 0));

            HeapSort hs = new HeapSort(new int[] { 49, 38, 65, 97, 76, 13, 27, 49 });
            int[] sorted = hs.Sort();
            
            Solution solution = new Solution();
            solution.lengthLongestPath("a");
            solution.IsMatch("a", "a*");
            char[,] board1 = new char[,] { { 'X', 'X', 'X', 'X' }, { 'X', 'O', 'O', 'X' }, { 'X', 'X', 'O', 'X' }, { 'X', 'O', 'X', 'X' } };
            solution.Solve(board1);
            TreeNode t1 = new TreeNode(5);
            t1.right = new TreeNode(6);
            solution.DeleteNode(t1, 6);

            var disjointSet = new DisjointSet(10);
            int r = disjointSet.Find(0);
            r = disjointSet.Find(1);
            disjointSet.Union(0, 1);
            r = disjointSet.Find(0);
            r = disjointSet.Find(1);
            disjointSet.Union(1, 2);
            disjointSet.Union(5, 6);
            disjointSet.Union(2, 5);

            var cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            Console.WriteLine(cache.Get(1));
            cache.Put(3, 3);
            Console.WriteLine(cache.Get(2));
            cache.Put(4, 4);
            Console.WriteLine(cache.Get(1));
            Console.WriteLine(cache.Get(3));
            Console.WriteLine(cache.Get(4));

            int[][] sortedArray = new int[][] { new int[] { 1, 5, 9 }, new int[] { 10, 11, 13 }, new int[] { 12, 13, 15 } };


            solution.SumUpInString("1+2-3+4-5+6-7");
            solution.WallsAndGates(new int[,] {{ int.MaxValue,-1,0,int.MaxValue},
                                                { int.MaxValue,int.MaxValue,int.MaxValue,-1},
                                                {int.MaxValue,-1,int.MaxValue,-1 },
                                                {0,-1,int.MaxValue,int.MaxValue} });
            solution.FindKthLargest(new int[] { -1, 2, 0 }, 1);
            char[,] board = new char[,] { { 'a', 'b' } };
            solution.Exist(board, "ba");

            solution.GenerateParenthesis(2);
            TreeNode m1 = new TreeNode(5);
            m1.left = new TreeNode(3);
            m1.right = new TreeNode(6);
            m1.left.left = new TreeNode(2);
            m1.left.right = new TreeNode(4);
            m1.left.left.left = new TreeNode(1);

            solution.kthSmallest(m1, 3);

            solution.ThreeSum(new int[] { -2, 0, 0, 2, 2 });

            Console.WriteLine(solution.CountPrimes(100));
            solution.SearchMatrix(new int[,] { { 1 }, { 3 }, { 5 } }, 2);
            solution.CheckInclusion("hello", "ooolleoooleh");

            string sum = solution.Sumup("980", "9152");
            solution.kthSmallest(sortedArray, 8);
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            solution.TopKFrequent(nums, 2);

            ListNode ln1 = new ListNode(2);
            ListNode ln2 = null;
            solution.GetIntersectionNode(ln2, ln1);

            int[,] lot = new int[,] { { 1, 1, 1, 1 }, { 0, 1, 1, 1 }, { 0, 1, 0, 1 }, { 1, 1, 9, 1 }, { 0, 0, 1, 1 } };
            int removeSteps = solution.removeObstacleBfs(5, 4, lot);
            int removeSteps1 = solution.removeObstacle(5, 4, lot);

            int[,] dots = new int[,] { { 3, 6 }, { 2, 4 }, { 5, 3 }, { 2, 7 }, { 1, 8 }, { 7, 9 } };
            var ret = solution.ClosestXdestinations(6, dots, 2);

            solution.CoinChange(new int[] { 9, 6, 5, 1 }, 11);
            int[,] ia = { { 6, 9, 7 } };
            solution.SpiralOrder(ia);

            int[] p = { 1, 2, 3 };
            solution.Permute(p);
            Console.WriteLine(solution.NthUglyNumber(11));

            int[] arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };
            Console.WriteLine(DynamicprogrammingQuestions.MinJumpsToEnd(arr));

            int[] w = new int[] { 30, 10, 20 };
            int[] v = new int[] { 120, 60, 100 };
            Console.WriteLine(DynamicprogrammingQuestions.Knapsack(v, w, 30));

            int[] prices = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            Console.WriteLine(DynamicprogrammingQuestions.CutRod(prices, 8));
            Console.WriteLine(DynamicprogrammingQuestions.CutRodRecursive(prices, 8));

            HashSet<string> dict = new HashSet<string> { "i", "like", "sam", "samsung", "mobile", "ice", "cream", "icecream", "man", "go", "mango" };
            Console.WriteLine(DynamicprogrammingQuestions.WordBreak(dict, "ilikei"));

            CrackCode crackCode = new CrackCode();
            crackCode.updateBits(1000000000, 10101, 2, 6);
            int n = 4;
            Stack<int> T1 = new Stack<int>();
            while (n > 0)
            {
                T1.Push(n--);
            }

            Stack<int> T2 = new Stack<int>();
            Stack<int> T3 = new Stack<int>();
            crackCode.HanoiTower(4, T1, T2, T3);

            char[,] charMatrix = new char[2, 2] {
                {'a','b'},
                {'c','d'}
            };

            int[,] intMatrix = new int[,]{
                {1,1,1},
                {2,3,0}
            };

            var zeroedMatrix = crackCode.SetRowColTo0(intMatrix);
            var rotated = crackCode.Rotate90Degrees(charMatrix);
            var rotatedInplace = crackCode.Rotate90DegreesInPlace(charMatrix);


            Console.WriteLine(crackCode.RemoveDuplicateChars("aaabbbs"));
            Console.WriteLine(crackCode.IsWithUniqueChars("aba"));
            Console.WriteLine(crackCode.ReverseString("abc12345"));

            TreeNode tn3 = new TreeNode(3);
            tn3.left = new TreeNode(9);
            TreeNode tn4 = new TreeNode(20);
            tn3.right = tn4;
            tn4.left = new TreeNode(15);
            tn4.right = new TreeNode(7);
            solution.IsBalanced(tn3);

            var f = solution.Fibonacci(12);
            Console.WriteLine("Fibonacci Numbers:");
            foreach (int i in f)
            {
                Console.WriteLine(i);
            }

            TreeNode tn1 = new TreeNode(-2);
            TreeNode tn2 = new TreeNode(-3);
            tn1.right = tn2;
            solution.PathSum(tn1, -5);

            solution.LengthOfLongestSubstring("abba");
            solution.LongestSubstringV1("aacbbbdc", 2);
            int[] a = { 8, 9, 10, 2 };
            solution.QuickSort(a);
            Console.WriteLine("After sort:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            int[] testData = new int[] { 2, 7, 11, 15 };
            int[] result = solution.TwoSum(testData, 9);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(8);
            n1.next = n2;
            ListNode n3 = new ListNode(0);
            solution.AddTwoNumbers(n1, n3);
            Console.WriteLine("Hello World!");
        }
    }
}
