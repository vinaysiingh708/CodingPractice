using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1 find even number using LINQ.
            //1.Data Source

            var numbers =new int[]{ 1, 2, 3, 4, 5, 6 };

            //2.Create the query
            var numQuery = from num in numbers
                           where (num % 2 == 0)
                           select num;

           // What is deferred query execution in LINQ?
           // LINQ queries are always executed when the query variable is iterated over, not when the query variable is created.

            //3.Execute the query
            foreach (var num in numQuery)
            {
                Console.WriteLine(num);   
            }
            Console.ReadLine();
            */

            //2.Sort the given array based on lengh in ascending and descending order and also sort based on aphabetical order
            /*
            var words =new string[]{ "the", "quick", "brown", "fox", "jumps" };

            var query = from word in words
                        orderby word.Length
                        select word;

            foreach (var word in  query)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            */

            /*
            var words =new string{ "the", "quick", "brown", "fox", "jumps" };

            var query = from word in words
                        orderby word.Length descending
                        select word;

            foreach (var word in query)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            */

            /* sort based on aphabetical order and also called primary sorting

            var words =new string[]{ "the", "quick", "brown", "fox", "jumps" };

            var query = from word in words
                        orderby word.Substring(0,1)
                        select word;

            foreach (var word in query)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            */

            // Secondary sorting based on Length and Alphabetical order

            /*
            string[] words = { "the", "quick", "brown", "fox", "jumps" };

            var query = from word in words
                        orderby word.Length,word.Substring(0, 1)
                        select word;

            foreach (var word in query)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            */

            // 3.Set Operation : Union,Intersection,Distinct,Except
            /*Union combines both list

            var list1 =new int[] { 1, 2, 3, 4 };
            var list2 = new int[] { 5, 6, 7 };

            var query = from num in list1.Union(list2)
                        select num;

            foreach (var item in query)
            {
                Console.WriteLine(item);      
            }
            Console.ReadLine();

            */

            // Intersection gives which are common in both list
            /*
            var list1 =new int[]{ 1, 2, 3, 4,5,6 };
            var list2 =new int[]{ 5, 6, 7 ,8};

            var query = from num in list1.Intersect(list2)
                        select num;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */
            // Common record from 2 string of array 
            /*
             
           var list1 =new string[] { "a","b","e","f"};
           var list2 = new string[] { "c", "d", "e", "f" };

            var query = from num in list1.Intersect(list2)
                        select num;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            */

            // Unique record from 2 string of array 

            /*
           var list1 = new string[] { "a", "b", "e", "f" };
           var list2 = new string[] { "c", "d", "e", "f" };

           var result1 = list1.Except(list2);

           var result2= list2.Except(list1);

           var result3 = result1.Concat(result2);

           foreach (var item in result3)
           {
               Console.WriteLine(item);
           }
           Console.ReadLine();

             */

            /* Distinct gives distinct records

            var list1 =new int[]{ 1,2,3,3,4,5,5};            

            var query = from num in list1.Distinct()
                        select num;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
             */

            // Except gives all numbers present in list1 but remove the number from list1 which is  present in list2

            /*
            var list1 =new int[] { 1, 2, 3, 4, 5, 6 };
            var list2 =new int[] { 5, 6 };

            var query = from num in list1.Except(list2)
                        select num;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            // 4.Filtering the array based on length of words

            /*
            string[] words = { "the", "quick", "brown", "fox", "jumps" };

            var query = from word in words
                        where word.Length == 3
                        select word;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            */

            // Filtering the array based on length of words and check if letter start with f

            /*
            string[] words = { "the", "quick", "brown", "fox", "jumps" };

            var query = from word in words
                        where word.Length == 3 && word.Substring(0,1)== "f"
                        select word;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            */

            //5. Quantifier Operations : All,Any,Contains


            //Which Markets have All the fruits whose Count of letters = 5  ?

            /*
            var Markets = new[]  {
                            new {MarketName ="Market A",Fruits=new string[]{"kiwi","cherry","banana" } },
                            new {MarketName ="Market B",Fruits=new string[]{"melon","mango","olive" } },
                            new {MarketName ="Market C",Fruits=new string[]{ "kiwi", "apple","orange" } },
             };

            var names = from market in Markets
                        where market.Fruits.All(fruit => fruit.Length == 5)
                        select market.MarketName;

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
            */


            // Which Markets have Any fruit which starts with letter 'O' ?
            /*
            var Markets = new[]  {
                            new {MarketName ="Market A",Fruits=new string[]{"kiwi","cherry","banana" } },
                            new {MarketName ="Market B",Fruits=new string[]{"melon","mango","olive" } },
                            new {MarketName ="Market C",Fruits=new string[]{ "kiwi", "apple","orange" } },
             };

            var names = from market in Markets
                        where market.Fruits.Any(fruit => fruit.StartsWith("o"))
                        select market.MarketName;

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
            */

            /*
            var Markets = new[]  {
                            new {MarketName ="Market A",Fruits=new string[]{"kiwi","cherry","banana" } },
                            new {MarketName ="Market B",Fruits=new string[]{"melon","mango","olive" } },
                            new {MarketName ="Market C",Fruits=new string[]{ "kiwi", "apple","orange" } },
             };

            var names = from market in Markets
                        where market.Fruits.Any(fruit => fruit.Contains("kiwi"))
                        select market.MarketName;

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
            */

            // 6.Project Operations => Transforming a object into new form


            // Extract first letter of each word

            /*
            var words = new string[] { "an", "apple", "a", "day" };

            var query = from word in words
                        select word.Substring(0, 1);                        

            foreach (var letter in query) {
                Console.WriteLine(letter);
            }

            Console.ReadLine();
            */

            // merge 2 sentences 

            /*
            var sentences = new string[] { "an apple a day", "the quick brown fox" };

            var query = from sentence in sentences
                        from word in sentence.Split()
                        select word;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            */

            //7.Zip Operator

            /*
            var list1= new int[] { 1, 2, 3, 4 };
            var list2 = new string[] { "A", "B", "C", "D" };

            var query =list1.Zip(list2,(num,letter) => num.ToString() + letter);

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            /*
            Output : 1A
                     2B
                     3C
                     4D 
            */

            //8.Partitioning Data : It basically refers to dividing an input sequnce

            /*
            var list = new[] { 'A', 'B', 'C', 'D', 'E' };

            var query = list.Skip(3);

            foreach (var item in query) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            // skip until we find chararcter 'C'

            /*
            var list = new[] { 'A', 'B', 'C', 'D', 'E' };

            var query = list.SkipWhile(i=>i!='C');

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            */

            // Take first 3 items from list

            /*
            var list = new[] { 'A', 'B', 'C', 'D', 'E' };

            var query = list.Take(3);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            // Take letters untill we find C

            /*
            var list = new[] { 'A', 'B', 'C', 'D', 'E' };

            var query = list.TakeWhile(i=>i!='C');

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            // 9.Join Operations

            // query syntax
            /*
            var products = new[]
            {
                new {ProductName="Cola",CategoryId=0},
                new {ProductName="Tea",CategoryId=0},
                new {ProductName="Apple",CategoryId=1},
                new {ProductName="Kiwi",CategoryId=1},
                new {ProductName="Carrot",CategoryId=2}
            };

            var categories = new[]
            {
                new {CategoryId=0,CategoryName="Bevearge"},
                new {CategoryId=1,CategoryName="Fruit"},
                new {CategoryId=2,CategoryName="Vegatable"}
            };

            var query = from c in categories
                        join p in products on c.CategoryId equals p.CategoryId 
                        select new { p.ProductName, c.CategoryName };


            foreach (var item in query)
            {
                Console.WriteLine(item.ProductName+":"+item.CategoryName);
            }
            Console.ReadLine();

            */


            // method syntax
            /*
            var products = new[]
            {
                new {ProductName="Cola",CategoryId=0},
                new {ProductName="Tea",CategoryId=0},
                new {ProductName="Apple",CategoryId=1},
                new {ProductName="Kiwi",CategoryId=1},
                new {ProductName="Carrot",CategoryId=2}
            };

            var categories = new[]
            {
                new {CategoryId=0,CategoryName="Bevearge"},
                new {CategoryId=1,CategoryName="Fruit"},
                new {CategoryId=2,CategoryName="Vegatable"}
            };

            var methodsyntax = products.Join(categories, p => p.CategoryId, c => c.CategoryId, (p, c) => new { p.ProductName, c.CategoryName });

            
            foreach (var item in methodsyntax)
            {
                Console.WriteLine(item.ProductName+":"+item.CategoryName);
            }
            Console.ReadLine();

            */

            //10. Group join

            // method syntax


            //var products = new[]
            //{
            //    new {ProductName="Cola",CategoryId=0},
            //    new {ProductName="Tea",CategoryId=0},
            //    new {ProductName="Apple",CategoryId=1},
            //    new {ProductName="Kiwi",CategoryId=1},
            //    new {ProductName="Carrot",CategoryId=2}
            //};

            //var categories = new[]
            //{
            //    new {CategoryId=0,CategoryName="Bevearge"},
            //    new {CategoryId=1,CategoryName="Fruit"},
            //    new {CategoryId=2,CategoryName="Vegatable"}
            //};

            // var methodsyntax = categories.GroupJoin(products, c => c.CategoryId, p => p.CategoryId, (c, prodts) => new { c, prodts });

            //foreach (var g in methodsyntax)
            //{
            //    Console.WriteLine(g.c.CategoryName);
            //    foreach (var p in g.prodts)
            //    {
            //         Console.WriteLine("\t" +p.ProductName);
            //    }
            //}
            //Console.ReadLine();



            //var querysyntax = from c in categories
            //                  join p in products
            //                  on c.CategoryId equals p.CategoryId into category
            //                  select new { c.CategoryName,category };

            //foreach (var g in querysyntax)
            //{
            //    Console.WriteLine(g.CategoryName);
            //    foreach (var p in g.category)
            //    {
            //        Console.WriteLine("\t" +p.ProductName);
            //    }
            //}
            //Console.ReadLine();

            // Left Join in LINQ
            /*
            var products = new []
            {
                new  { ProductName="Cola",CategoryId=0},
                new  { ProductName="Tea",CategoryId=0},
                new  { ProductName="Apple",CategoryId=1},
                new  { ProductName="Kiwi",CategoryId=1},
                new  { ProductName="Carrot",CategoryId=2}                
            };

            var categories = new[]
            {
                new {CategoryId=0,CategoryName="Bevearge"},
                new {CategoryId=1,CategoryName="Fruit"},
                new {CategoryId=2,CategoryName="Vegatable"},
                new {CategoryId=3,CategoryName="Nonveg"}
            };

            var query = from c in categories
                        join p in products on c.CategoryId equals p.CategoryId into product
                        from prdt in product.DefaultIfEmpty()
                        select new { CategoryId= c.CategoryId, CategoryName= c.CategoryName, ProductName = prdt == null ? "N/A":prdt.ProductName };


            foreach (var g in query)
            {
                Console.WriteLine("CategoryId-{0}\t CategoryName-{1}\tProductName-{2}", g.CategoryId,g.CategoryName, g.ProductName);
               
            }
            Console.ReadLine();

            */

            //10.Grouping
            // How many Odd and Even Numbers in the table ?

            /*
            var numbers = new[]
            {
                new {Number="One",Type="Odd"},
                new {Number="Two",Type="Even"},
                new {Number="Three",Type="Odd"},
                new{Number="Four",Type="Even"},
                new{Number="Five",Type="Odd"}
            };

            var query = from number in numbers
                        group number by number.Type into g
                        select new { Type = g.Key, Count = g.Count() };

            foreach (var item in query)
            {
                Console.WriteLine(item.Type+":"+item.Count);
            }

            Console.ReadLine();
            */


            // 11.Generations
            /*
            var numbers = new int[] { };

            foreach(var i in numbers.DefaultIfEmpty())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            /*
            bool[] numbers = new bool[] { };

            foreach (bool i in numbers.DefaultIfEmpty())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            /*
            var collection = Enumerable.Range(1,5);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            /*
            var collection = Enumerable.Repeat("I Love designing", 5);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            //12.Element Operation.

            /*
            var collection = new int[] { 10,20,30,40,50};

            var item = collection.First();

            Console.WriteLine(item);

            Console.ReadLine();
            */

            /*
            var collection = new int[] { };

            var item = collection.FirstOrDefault();

            Console.WriteLine(item);

            Console.ReadLine();

             */

            /*
            var collection = new int[] { 10, 20, 30, 40, 50 };

            var item = collection.Last();

            Console.WriteLine(item);

            Console.ReadLine();
            */

            /*

            var collection = new int[] { };

            var item = collection.LastOrDefault();

            Console.WriteLine(item);

            Console.ReadLine();

             */

            // Get element at position 4
            /*
           var collection = new int[] { 10, 20, 30, 40, 50 };

           var item = collection.ElementAt(3);

           Console.WriteLine(item);

           Console.ReadLine();
            */

            /*
            var fruits = new string[] { "Apple", "Banana", "Kiwi", "Orange","Apple"};

            var item = fruits.Single(f=>f.Length==4);

            Console.WriteLine(item);

            Console.ReadLine();
            */

            //13.Concatenation.

            /*
            var cats = new[]
            {
                new{Name="Barley",Age=8},
                new{Name="Boots",Age=4},
                new{Name="Whishker",Age=1},
            };

            var dogs = new[]
            {
                new{Name="Bounder",Age=3},
                new{Name="Snoopy",Age=14},
                new{Name="Fido",Age=10},
            };

            var concatCatDog = cats.Concat(dogs);

            foreach (var item in concatCatDog)
            {
                Console.WriteLine(item.Name + ":" + item.Age);
            }

            Console.ReadLine();
            */

            //14.Aggregation

            /*
            var numbers = new int[] { 10, 20, 30, 40, 50 };

            // var value = numbers.Min();
            // var value = numbers.Max();
            //var value = numbers.Sum();
            //var value = numbers.Average();
            var value = numbers.Count();

            Console.WriteLine(value);

            Console.ReadLine();

            */

            /*
            var numbers = new int[] { 10, 20, 30,30,40, 50 };

            var value = (from number in numbers
                         where number == 30
                         select number).Count();

            Console.WriteLine(value);

            Console.ReadLine();
            */

            // 15.Find occurence of a word in text.
            /*
            string text = "This is a sample text, to check the occurence of the word sample in this sample text! Thank you.";

            string searchTerm = "sample";

            string[] textArray = text.Split(' ', ',', '.' );

            var matchQuery = (from word in textArray
                              where word.Equals(searchTerm)
                              select word).Count();

            Console.WriteLine("Count of word 'Sample' = " + matchQuery);

            Console.ReadLine();
            */

            //16.Extract numbers from text

            /*
            string text = "ABCD12-3-D-EF-467";

            var query = from ch in text
                        where char.IsDigit(ch)
                        select ch;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            */

            //17.Extract letter from text
            /*
             
            string text = "ABCD12-3-D-EF-467";

            var query = from ch in text
                        where char.IsLetter(ch)
                        select ch;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            */

            //18.Extract special characters
            /*

            string text = "ABCD12-3-D-EF-467";

            var query = from ch in text
                        where (!char.IsLetter(ch)&&!char.IsDigit(ch))
                        select ch;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            */

            //19.Split data from one file to multiple files.
            /*

            string[] file_content = System.IO.File.ReadAllLines(@"C:\Users\intel\Desktop\CountCharacterInString\all_numbers.txt");

            var even_numbers = from i in file_content
                               where Convert.ToInt32(i)%2 == 0
                               select i;

            var odd_numbers = from i in file_content
                               where Convert.ToInt32(i)% 2 != 0
                               select i;

            using (System.IO.StreamWriter sw=new System.IO.StreamWriter(@"C:\Users\intel\Desktop\CountCharacterInString\odd_numbers.txt"))
            {
                foreach (var i in odd_numbers)
                {
                    sw.WriteLine(i);
                }
            }

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Users\intel\Desktop\CountCharacterInString\even_numbers.txt"))
            {
                foreach (var i in even_numbers)
                {
                    sw.WriteLine(i);
                }
            }

            Console.ReadLine();

            */

            //20.Get specific file types from a folder.
            /*

            string Folder = @"C:\Users\intel\Desktop\CountCharacterInString\";

            string[] fileList = System.IO.Directory.GetFiles(Folder);

            var fileQuery = from file in fileList
                            where System.IO.Path.GetExtension(file) == ".txt"
                            select file;

            foreach (var item in fileQuery)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            */

            //21.Get largest file from a folder.

            /*
            string folder = @"C:\Users\intel\Desktop\CountCharacterInString";

            var fileList = new System.IO.DirectoryInfo(folder).GetFiles();

            var longestFile = (from file in fileList
                               orderby file.Length descending
                               select file).First();

            Console.WriteLine(longestFile.Name +" Size " + longestFile.Length );

            Console.ReadLine();

            */
        }


    }

    public  class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
       
    }

    public class Product
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
    }

}
