using System;
using System.Collections.Generic;
using zadacha4;
class Program
{
            static void Main(string[] args)
            {
                TwoSumSolver solver = new TwoSumSolver();

                Console.WriteLine("Enter numbers (separated with space):");
                string[] input = Console.ReadLine().Split();
                int[] nums = Array.ConvertAll(input, int.Parse);

                Console.WriteLine("Enter target:");
                int target = int.Parse(Console.ReadLine());

                int[] result = solver.TwoSum(nums, target);

                if (result[0] != -1)
                {
                    Console.WriteLine($"Result: Index: {result[0]} {result[1]}, numbers: {nums[result[0]]} {nums[result[1]]}");
                }
                else
                {
                    Console.WriteLine("There isn't that numbers.");
                }
            }
        }