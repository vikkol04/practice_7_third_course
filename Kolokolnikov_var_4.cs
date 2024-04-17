using System;
namespace ConsoleApp1
{
    internal class KolokolnikovVar4
    {
        public class MyClass1
        {
            public string LongestString(List<string> words)
            {
                if (words == null || words.Count == 0) return "No words";
                return words.OrderByDescending(word => word.Length).First();
            }
        }
        public class MyClass2
        {
            private List<string> words = new List<string>();
            public string LongestString()
            {
                if (words == null || words.Count == 0) return "No words";
                return words.OrderByDescending(word => word.Length).First();
            }
            public List<string> MyProperty
            {
                get { return words; }
                set { words = value; }
            }
        }
        public class MyClass3
        {
            private string word = "Default";
            private int count = 0;
            public int LongestStringRecursively()
            {
                Console.WriteLine(word);
                List<object> default_fields = new List<object>(){word, count};
                int final_count = Recursion();
                word = (string)default_fields[0];
                count = (int)default_fields[1];
                return final_count;
            }
            public int Recursion()
            {
                while (word != null && word.Length != 0)
                {
                    Console.WriteLine(word.Substring(0, word.Length - 1));
                    Thread.Sleep(150);
                    word = word.Substring(0, word.Length - 1);
                    count++;
                    Recursion();
                } 
                return count;
            }
            public string MyProperty
            {
                get { return word; }
                set { word = value; }
            }
        }
        static void Main (string[] args)
        {
            // №1. Create a method that takes a list of strings as a parameter
            // and returns the longest string.
            Console.WriteLine($"\n\n№1. --------------------------------------------------------\n");
            Console.ReadLine();
            List<string> words = new List<string>{ "one", "two", "monitor", "mouse", "RTX", "RX" };
            MyClass1 MyObject1 = new MyClass1();
            Console.WriteLine("All words: " + string.Join(", ", words) + ".");
            Console.WriteLine("The longest word: " + MyObject1.LongestString(words) + ".");


            // №2. Create a method that returns the longest string from a list of strings.
            Console.WriteLine($"\n\n№2. --------------------------------------------------------\n");
            Console.ReadLine();
            MyClass2 MyObject2 = new MyClass2();
            MyObject2.MyProperty = new List<string>{ "three", "four", "TV", "keyboard", "Lumen", "RTX" };
            Console.WriteLine("All words: " + string.Join(", ", MyObject2.MyProperty));
            Console.WriteLine("The longest word: " + MyObject2.LongestString() + ".");

            // №3. Create a recursive method to calculate the length of a string.
            Console.WriteLine($"\n\n№3. --------------------------------------------------------\n");
            Console.ReadLine();
            MyClass3 MyObject3 = new MyClass3();
            MyObject3.MyProperty = "Kolokolnikov";
            Console.WriteLine($"{MyObject3.MyProperty} length: == {MyObject3.LongestStringRecursively()}");
        }
    }
}
