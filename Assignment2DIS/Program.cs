using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment2DIS
    {
        class Assignment2DIS
    {
            static void Main(string[] args)
            {
                //Question1:
                Console.WriteLine("Question 1");
                Console.WriteLine(" Enter number of elements :\n");
                int n = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine(" Input  elements in the 1st array :\n");
                int[] num1 = new int[n];
                for (int i = 0; i < n; i++)
                {
                Console.Write("element - {0} : ", i);
                num1[i] = Convert.ToInt32(Console.ReadLine());
                }
                 Console.WriteLine(" Enter number of elements :\n");
                 int nn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Input  elements in the 2nd array :\n");
                int[] num2 = new int[nn];
                for (int i = 0; i < nn; i++)
                {
                Console.Write("element - {0} : ", i);
                num2[i] = Convert.ToInt32(Console.ReadLine());
                }
                Join(num1, num2);
                Console.WriteLine("");
                Console.ReadLine();

                //Question 2 
                Console.WriteLine("Question 2");
                Console.WriteLine(" Enter number of elements :\n");
                int p = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Input  elements in the 1st array :\n");
                int[] nums = new int[p];
                for (int i = 0; i < p; i++)
                {
                Console.Write("element - {0} : ", i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("target number:");
                
                int target = Int32.Parse(Console.ReadLine());
                int position = Search(nums, target);
                Console.WriteLine("Target Position  : {0}", position);
                Console.WriteLine("");

                //Question3
                Console.WriteLine("Question 3");
            Console.WriteLine(" Enter number of elements :\n");
            int zp = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Input  elements in the 1st array :\n");
                int[] arp = new int[zp];
                for (int i = 0; i < zp; i++)
                {
                Console.Write("element - {0} : ", i);
                arp[i] = Convert.ToInt32(Console.ReadLine());
                }
                int lucky = Lucky(arp);
                if (lucky == -1)
                    Console.WriteLine("No Lucky number");
                else
                    Console.WriteLine("Lucky number iis {0}", lucky);

                Console.WriteLine();

                //Question 4
                Console.WriteLine("Question 4");
                Console.WriteLine("Enter  n:");
                int total = Int32.Parse(Console.ReadLine());
                int max = Create(total);
                Console.WriteLine("Maximun integer {0}", max);
                Console.WriteLine();

                //Question 5

                Console.WriteLine("Question 5");
                List<List<string>> places = new List<List<string>>();
                 places.Add(new List<string>() { "London", "New York" });
                 places.Add(new List<string>() { "New York", "lima" });
                 places.Add(new List<string>() { "lima", "sao paulo" });

                string city = Destination(places);
                Console.WriteLine("Destination City is : {0}", city);

                Console.WriteLine();

                //Question 6
                Console.WriteLine("Question 6");
            Console.WriteLine(" Enter number of elements :\n");
            int ppp = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Input  elements in the 1st array :\n");
                int[] Nums = new int[ppp];
                for (int i = 0; i < ppp; i++)
                {
                Console.Write("element - {0} : ", i);
                Nums[i] = Convert.ToInt32(Console.ReadLine());
             }
                int target_sum = 9;
                TargetAddition(Nums, target_sum);
                Console.WriteLine();

                //Question 7
                Console.WriteLine("Question 7");
                int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
                TopFive(scores);
                Console.WriteLine();

                //Question 8
                Console.WriteLine("Question 8");
            Console.WriteLine(" Enter number of elements :\n");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Input  elements in the 1st array :\n");
            int[] arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int K = 3;
                RotateArray(arr, K);

                Console.WriteLine();

                //Question 9
                Console.WriteLine("Question 9");
            Console.WriteLine(" Enter number of elements :\n");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Input  elements in the 1st array :\n");
            int[] array = new int[y];
            for (int i = 0; i < y; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = LargestSum(array);
                Console.WriteLine("largest sum is {0}", sum);
                Console.WriteLine();

                //Question 10
                Console.WriteLine("Question 10");
            Console.WriteLine(" Enter number of elements :\n");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Input  elements in the 1st array :\n");
            int[] costs = new int[w];
            for (int i = 0; i < w; i++)
            {
                Console.Write("element - {0} : ", i);
                costs[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minimum = MinCostToReach(costs);
                Console.WriteLine("Minimum cost to reach  {0}", minimum);
                Console.WriteLine();
            }

            //Question 1


            public static void Join(int[] num1, int[] num2)
            {
                try
                {
                    //intersection of two arrays
                    int[] join = num1.Intersect(num2).ToArray();
                    
                    if (join.Length == 0)
                        Console.WriteLine("No matches");
                    else
                    {
                        Console.Write(join[0]);
                        for (int i = 1; i < join.Length; i++)
                            Console.Write(", {0}", join[i]);
                        Console.Read();
                    }
                }
                catch (Exception)
                {
                Console.WriteLine("Exception occurred in Question 1\n");
                throw;
                }
            }

            //Question 2:


            public static int Search(int[] nums, int target)
            {
                try
                {
                    int start = 0;
                    int stop = nums.Length - 1;
                    while (start <= stop)
                    {
                        int center = (start + stop) / 2;
                        //comparing 
                        if (nums[center] == target)
                            return center;

                        else if (nums[center] < target)
                            
                            start = center + 1;

                        else
                            
                            stop = center - 1;
                    }

                    //returns the insert position
                    return stop + 1;
                }
                catch (Exception)
                {
                Console.WriteLine("Exception occurred in Question 2\n");
                return -1;
                    throw;

                }
            }


            //Question 3


            private static int Lucky(int[] nums)
            {
                try
                {
                    Dictionary<int, int> frequency = new Dictionary<int, int>();
                    //checking the constraints
                    if (nums.Length >= 1 && nums.Length <= 500)
                    {
                        foreach (int x in nums)
                        {
                            
                            if (x <= 500)
                            {
                                if (frequency.ContainsKey(x))
                                    frequency[x]++;
                                else
                                    frequency.Add(x, 1);
                            }
                            else
                                //throwing exception 
                                throw new Exception();
                        }

                        int luckyNum = -1;

                        foreach (var n in frequency.Keys)
                        {
                            // checking if number is equal to  frequency
                       
                            if (n == frequency[n] && n > luckyNum)
                                luckyNum = n;
                        }

                        return luckyNum;
                    }
                    else
                        //throwing exception
                        throw new Exception();

                }
                catch (Exception)
                {
                Console.WriteLine("Exception occurred in Question 3\n");
                return -1;
                    throw;
                }
            }

            //Question 4:

            private static int Create(int total)
            {
                try
                {
                    //checking constraints
                    if (total >= 0 && total <= 100)
                    {
                        int[] nums = new int[total + 1];
                        nums[0] = 0;
                        nums[1] = 1;
                        int nlen = total / 2;
                        for (int i = 1; i <= nlen; i++)
                        {
                            if ((2 * i) < total + 1)
                                nums[2 * i] = nums[i];
                            if (((2 * i) + 1) < total + 1)
                                nums[(2 * i) + 1] = nums[i] + nums[i + 1];
                        }
                        int maxnum = nums.Max();
                        return maxnum;
                    }
                    else
                        throw new Exception();

                }
                catch (Exception)
                {
                    Console.WriteLine("Exception occurred in Question 4\n");
                    return -1;
                    throw;
                }

            }

            //Question 5

            public static string Destination(List<List<string>> routes)
            {
                try
                {
                    List<string> list = new List<string>();
                    foreach (var element in routes)
                    {
                        list.Add(element[1]);
                    }
                    foreach (var route in routes)
                    {
                        if (list.Contains(route[0]))
                        {
                            list.Remove(route[0]);
                        }
                    }
                    return (list.Last());
                }
                catch (Exception)
                {
                Console.WriteLine("Exception occurred in Question 5\n");
                throw;
                }
            }

            //Question 6:

            private static void TargetAddition(int[] nums, int target)
            {
                try
                {
                    int num1 = 0;
                    int num2 = nums.Length - 1;
                    if (nums.Length >= 2 && nums.Length <= 3 * 104)
                    {
                        while (num1 < num2)
                        {
                            if (nums[num1] >= -1000 && nums[num1] <= 1000 && nums[num2] >= -1000 && nums[num2] <= 1000)
                            {
                                if ((nums[num1] + nums[num2]) < target)
                                    num1++;
                                else if ((nums[num1] + nums[num2]) > target)
                                    num2--;
                                else if ((nums[num1] + nums[num2]) == target)
                                    break;
                            }
                            else
                                throw new Exception();
                        }
                        Console.WriteLine("{0},{1}", num1 + 1, num2 + 1);
                        Console.ReadLine();
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception occurred Question 6\n");
                    //throw;
                }
            }

            //Question 7

            private static void TopFive(int[,] items)
            {
                try
                {
                    List<int[]> list = new List<int[]>();
                    List<int[,]> result = new List<int[,]>();
                    for (int i = 0; i < items.GetLength(0); i++)
                    {
                        
                        list.Add(new int[] { items[i, 0], items[i, 1] });
                    }
                    //sorting the elements
                    list.Sort((p, q) => { return (p[0] < q[0]) ? -1 : ((p[0] == q[0]) ? ((p[1] <= q[1]) ? 1 : -1) : 1); });
                    int a = list[0][0];
                    int count = 1;
                    int sum = list[0][1];
                    for (int i = 1; i < list.Count; i++)
                    {
                        if (list[i][0] == a && count < 5)
                        {
                            sum += list[i][1];
                            count += 1;
                        }
                        else if (list[i][0] != a)
                        {

                            result.Add(new int[,] { { a, sum / 5 } });
                            Console.Write("[[" + a + "," + sum / 5 + "]" + ",");
                            a = list[i][0];
                            count = 1;
                            sum = list[i][1];
                        }
                    }
                    result.Add(new int[,] { { a, sum / 5 } });
                    Console.Write("[" + a + "," + sum / 5 + "]]");
                    Console.Write("\n");
                }
                catch (Exception)
                {
                Console.WriteLine("Exception occurred in Question 7\n");
                throw;
                }
            }

            //Question 8


            private static void RotateArray(int[] arr, int num)
            {
                try
                {
                    var looppos = 0;
                    var currentpos = 0;
                    var present = arr[currentpos];
                    //checking constraints
                    if (arr.Length >= 1 && arr.Length <= 105 && num >= 0 && num <= 105)
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            
                            if (arr[i] >= -231 && arr[i] <= 230)
                            {
                                currentpos = (currentpos + num) % arr.Length;

                                // replacing current index with next index using temp variable
                                var temp = arr[currentpos];
                                arr[currentpos] = present;
                                present = temp;

                                if (currentpos == looppos)
                                {
                                    currentpos = (++looppos) % arr.Length;
                                    present = arr[currentpos];
                                }
                            }
                            else
                                throw new Exception();
                        }
                        Console.WriteLine(String.Join(",", arr));

                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception occurred in Question 8 \n");
                    //throw;
                }
            }

            //Question 9


            private static int LargestSum(int[] arr)
            {
                try
                {
                    //checking constraints
                    if (arr.Length >= 1 && arr.Length <= 30000)
                    {
                        var max1 = arr[0];
                        var max2 = arr[0];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] >= -100000 && arr[i] <= 100000)
                            {
                                max2 = Math.Max(arr[i], max2 + arr[i]);
                                max1 = Math.Max(max1, max2);
                            }
                            else
                                throw new Exception();
                        }
                        return max1;
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                Console.WriteLine("Exception occurred in Question 9 \n");
                return 0;
                    throw;
                }
            }

            //Question 10




            private static int MinCostToReach(int[] costs)
            {
                try
                {
                    int length = costs.Length;
                    if (length == 0)
                        return 0;
                    else if (length == 1)
                        return costs[0];
                    else if (length <= 1000)
                    {
                        for (int i = 2; i < length; i++)
                        {
                            if (costs[i] >= 0 && costs[i] <= 999)
                                //calculating the minimum cost
                                costs[i] = Math.Min(costs[i - 1], costs[i - 2]) + costs[i];
                            else
                                throw new Exception();
                        }
                        return Math.Min(costs[length - 2], costs[length - 1]);
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                Console.WriteLine("Exception occurred in Question 10 \n");
                return 0;
                    throw;
                }
            }
        }
    }
