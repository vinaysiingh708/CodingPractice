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





