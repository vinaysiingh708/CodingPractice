using System;
using System.Collections.Generic;

namespace CountCharacterInString
{
    /*
    public class Employee 
    {
        public int GetSalary(int designation)
        {
            return 1000;
        }
        public string GetSalary(int designation)
        {
            return "1000";
        }
    }
    */

    public class Program
    {
        static void Main(string[] args)
        {
            //1.Count characters in a string
            /*
            string str = "interview point";
            Dictionary<char,int> charCount =new Dictionary<char, int>();
            foreach(var character in str)
            {
                if (character!= ' ')
                {
                    if(!charCount.ContainsKey(character))
                    {
                        charCount.Add(character, 1);
                    }
                    else
                    {
                        charCount[character]++;
                    }
                }                
            }
            foreach(var character in charCount)
            {
                Console.WriteLine("{0} - {1}", character.Key,character.Value);
            }
            Console.ReadLine();
            */

            //2.Find Duplicate Characters Count in a String in C#
            /*
            string str = "interview point";
            Dictionary<char,int> charCount =new Dictionary<char, int>();
            foreach (var character in str)
            {
                if (character!= ' ')
                {
                    if(!charCount.ContainsKey(character))
                    {
                        charCount.Add(character, 1);
                    }
                    else
                    {
                        charCount[character]++;
                    }
                }                
            }
            foreach(var character in charCount)
            {
               if (character.Value > 1 )
                Console.WriteLine($"Character {character.Key} repeating {character.Value} times");
            }
            Console.ReadLine();
            
            */

            /*
             Alternate way using LINQ : Count characters in a string

                string str = "interview point";

                var charCount = from c in str
						        where c != ' ' 
						        group c by c into g
						        select new {g.Key,Count= g.Count() } ;
			

                foreach (var character in charCount)
                {
                    Console.WriteLine("{0} - {1}", character.Key, character.Count);
                }

                Console.ReadLine();
             
             */

            //3.Reverse a string
            /*
            string str1 = "my name is arun singh";
            string revstr = "";

            for(int i = str1.Length - 1; i>= 0 ; i--)
            {
                revstr = revstr + str1[i];
            }
            Console.WriteLine(revstr);

            Console.ReadLine();
            */

            //4.Reverse Each word in String Program
            /*  
             // Enter a String: my name is arun singh
             // Reverse Word String: ym eman si nura hgnis

             /*
             string inputString = "my name is arun singh";
             var resultString = string.Join(" ", inputString.Split(' ').Select(x => new String(x.Reverse().ToArray()) ));
             Console.WriteLine(resultString);
             Console.ReadLine();
             */

            /*
            Method1_2();

            int k = Method3();

            Console.WriteLine(k);
            Console.ReadLine();
            
            */


            /*  Find second highest in an array in c#
             *  
                   var array =new int[]{ 10, 20, 4, 45, 99, 6, 78 };

                   int highest = int.MinValue;
                   int secondHighest = int.MinValue;

                   for (int i = 0; i < array.Length; i++)
                   {
                       if (array[i] > highest)
                       {
                           secondHighest = highest;
                           highest = array[i];
                       }
                       else if (array[i] > secondHighest && array[i] != highest)
                       {
                           secondHighest = array[i];
                       }
                   }

                   Console.WriteLine("Second highest is {0} and highest is {1} ", secondHighest, highest);

               */

            /*
             
             * Find second highest in an array using LINQ in c#
             
                    var array = new int[] { 10, 20, 4, 45, 99, 6, 78 };

                    var query = (from arr in array
                                 orderby arr descending
                                 select arr).Skip(1).Take(1);

                    foreach (var arr in query)
                    {
                        Console.WriteLine(arr);
                    }

            */

            /*
             * Swapping of 2 numbers without using 3rd variable
             
                int a = 50;
		        int b = 100;
		
		        a = a + b;
		        b = a - b;
		        a = a - b;
		
		        Console.WriteLine("a = {0}, b = {1}",a,b);

            */

            //DSA Data Structures and Algorithms

            
            /*
            N(length of input) is an integer within the range[1, 600]
            each element of array A is a string consisting of three characters: "+" or "-"; a digit "0" - "9"; and uppercase English letter "A" - "Z"
            the sequence is correct.That is every booked room was previously free and every freed room was previously booked.


            Example:
            Input:["+1A", "+3E", "-1A", "+4F", "+1A", "-3E"]
            Output: "1A"
            Explanation: 1A as it has been booked 2 times.

            */
            /*
            string[] bookings = { "+1A", "+3E", "-1A", "+4F", "+1A", "-3E" };
            Dictionary<string, int> roomBookings = new Dictionary<string, int>();

            foreach (var booking in bookings)
            {
                // Get the action (+ or -) and the room (e.g., 1A)
                char action = booking[0];
                string room = booking.Substring(1);

                // If it's a booking (+), increment the count for that room
                if (action == '+')
                {
                    if (!roomBookings.ContainsKey(room))
                    {
                        roomBookings.Add(room,1);
                    }
                    else
                    {
                        roomBookings[room]++;
                    }
                }
            }

            // Find the room with the highest number of bookings               
            foreach (var entry in roomBookings)
            {
                if (entry.Value > 1)
                    Console.WriteLine("Room {0} booked {1} times",entry.Key, entry.Value);
            }
            Console.ReadLine();
            */
            

            /*
                    //To find the equilibrium index in an array in C#, you need to identify an index where the sum of elements to
                    //the left is equal to the sum of elements to the right.
            */
            /*
                    int[] arr = { 1, 3, 5, 2, 2 };
                    int totalSum = 0, leftSum = 0;

                    // Calculate the total sum of the array
                    for (int i = 0; i < arr.Length; i++)
                        totalSum = totalSum + arr[i];

                    // Traverse the array and check for the equilibrium index
                    for (int i = 0; i < arr.Length; i++)
                    {
                        // totalSum - arr[i] is now the right sum for index i
                        totalSum = totalSum - arr[i];

                        // If leftSum equals the right sum, return the index
                        if (leftSum == totalSum)
                        Console.WriteLine(i);

                        // Update leftSum for the next iteration
                        leftSum = leftSum + arr[i];
                    }
                    Console.ReadLine();

            */

            /*
                To merge two sorted arrays in C# efficiently, you can use a two-pointer approach, which is optimal in terms of time complexity. 
                This method leverages the fact that both arrays are already sorted, allowing you to combine them while maintaining sorted order.
             */

            
            int[] arr1 = { 1, 3, 5, 7,9 };
            int[] arr2 = { 2, 4, 6, 8 };

            int n1 = arr1.Length;
            int n2 = arr2.Length;
            int[] mergedArray = new int[n1 + n2];

            int i = 0, j = 0, k = 0;

            // Traverse both arrays and merge them
            while (i < n1 && j < n2)
            {
                if (arr1[i] <= arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }

            // Store remaining elements of arr1 (if any)
            while (i < n1)
            {
                mergedArray[k++] = arr1[i++];
            }

            // Store remaining elements of arr2 (if any)
            while (j < n2)
            {
                mergedArray[k++] = arr2[j++];
            }

            Console.WriteLine("Merged Sorted Array: ");
            foreach (var item in mergedArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
            

            /*    
             static int Method1()
             {
                 Thread.Sleep(1000);
                 return 10;
             }
             static int Method2(int i)
             {

                 return 20 * i;
             }
             static int Method3()
             {            
                 return 30;
             }

             static async void Method1_2()
             {
                 Console.WriteLine("Test");

                 var i = await Task.Run(() =>
                 {
                     return Method1();
                 });

                 Console.WriteLine(i);

                 int j= Method2(i); 
                 Console.WriteLine(j);
             }

             */
        }
    }
}





