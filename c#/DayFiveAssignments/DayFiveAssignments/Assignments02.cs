using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DayFiveAssignments
{
    public class Assignments02
    {
        public void CopyArrayExample ()
            {
            //========================================
            //02 Arrays and Strings
            //1.Copying an Array
            int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            string ArrString = string.Concat(arr.Select(x => x.ToString()));
            string Arr2String = string.Concat(arr2.Select(x => x.ToString()));

            Console.WriteLine(ArrString);
            Console.WriteLine(Arr2String);
            }

        public void ManageList()
        {
            // 2. program that lets the user manage a list of elements. 
            int hold = 0;
            List<string> list = new List<string>();
            while (hold == 0)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string? command = Console.ReadLine();
                if (command[0] == '+' && command[1] == ' ')
                {
                    command = command.Trim('-', '+', command[1]);
                    list.Add(command);
                }
                else if (command[0] == '-' && command[1] == '-')
                {
                    list.Clear();
                }
                else if (command[0] == '-' && command[1] == ' ')
                {
                    command = command.Trim('-', '+', command[1]);
                    list.Remove(command);
                }
                else
                {
                    Console.WriteLine("please enter a valid command");
                }
                string result = String.Join(",", list);
                Console.WriteLine(result);
            }
        }

        public int[] CalculatePrime(int startNum, int endNum)
        {
            //3. method that calculates all prime numbers in given range and returns tham as array of integers.
                List<int> list = new List<int>();
                for (int i = startNum; i <= endNum; i++)
                {
                    int test = -1;
                    for (int j = 1; j < i + 1; j++)
                    {
                        if (i % j == 0)
                        {
                            test++;
                        }
                    }
                    if (test < 2 && i != 1)
                    {
                        list.Add(i);
                    }
                }
                return list.ToArray();
            
        }

        public void RotateTheArray ()
        {
            //4. rotate array k times and sum the obtained arrays after each rotation. (might want to try again.)
            int[] ints = [1, 2, 3, 4, 5];
            int k = 3;
            int[] hold = new int[ints.Length - 1];
            int[] result = new int[ints.Length];
            Array.Copy(ints, 0, hold, 0, hold.Length);
            for (int i = 0; i < k; i++)
            {
                ints[0] = ints[ints.Length - 1];
                result[0] += ints[ints.Length - 1];
                for (int j = 1; j < ints.Length; j++)
                {
                    ints[j] = hold[j - 1];
                    result[j] += hold[j - 1];
                }
                Array.Copy(ints, 0, hold, 0, hold.Length);
            }
            Console.WriteLine(String.Join(", ", result));

        }


        public void LongestSequence ()
        {
            //5. finds the longest sequence of equal elements in an array of integers.
            int[] ints1 = [1, 1, 1, 2, 3, 1, 3, 3];
            int[] ints2 = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
            int[] ints3 = [4, 4, 4, 4];
            int[] ints4 = [0, 1, 1, 5, 2, 2, 6, 3, 3];
            int[] ints = ints4;
            int start = 0;
            int max = 0;
            int count = 0;
            int end = 0;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] == ints[i + 1])
                {
                    count++;
                }
                else if (count > max)
                {
                    max = count;
                    start = i - count;
                    end = start + max;
                    count = 0;
                }
                else
                {
                    count = 0;
                }
            }
            if (max != 0)
            {
                string result = $"{ints[start]}";
                for (int i = start; i < end; i++)
                {
                    result += $" {ints[i]}";
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(String.Join(",", ints));
            }
        }

        public void MostFrequentNumber()
        {
            //7. most frequent number in a given sequence of numbers.
            int[] arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
            int count = 0;
            int max = 0;
            int hold = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length > 1)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    if (count > max)
                    {
                        max = count;
                        hold = arr[i];
                    }
                    count = 0;
                }
                else { hold = arr[0]; }
            }
            Console.WriteLine($"{hold} occurs {max + 1}");
        }



        public void ReverseLetters()
        {
            //Practice Strings
            //1. reverse letters in a string and print the results
            string text = "sample";
            //using char array
            char[] reverse = text.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(String.Join("", reverse));
            //using for loop
            string reverse1 = "";
            for (int i = text.Length - 1; i > -1; i--)
                {
                    reverse1 = reverse1 + text[i];
                }
            Console.WriteLine(reverse1);
        }

        public void ReverseSentence()
        {
            //2. reverse the words in a given sentence without changing the punctuation and spaces.???
            string test = "C# is not C++, and PHP is not Delphi!";
            // desired result: Delphi not is PHP, and C++ not is C#!
            string pattern = @"[,:;=()&\[\]""'\\/!?\s]";
            List<String> l1 = new List<String>(Regex.Split(test, pattern));
            l1.RemoveAll(s => string.IsNullOrEmpty(s));
            l1.Reverse();
            List<String> l2 = new List<string>(Regex.Matches(test, pattern).Cast<Match>().Select(m => m.Value));

            List<String> joinedStrings = new List<String>();
            for (int i = 0; i < l1.Count; i++)
            {
                if (i < l1.Count)
                {
                    joinedStrings.Add(l1[i]);
                }
                if (i < l2.Count)
                {
                    joinedStrings.Add(l2[i]);
                }
            }
            Console.WriteLine(string.Join("", joinedStrings.ToArray()));

        }

        public void PrintPalidromes ()
        {
            //3 get palidromes and print them
            string test = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            string[] strings = test.Split(new char[] { ',', ' ', '.', '?', '!', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> values = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                bool check = true;
                for (int j = 0; j < (strings[i].Length / 2); j++)
                {
                    if (strings[i][j] != strings[i][(strings[i].Length - 1) - j])
                    {
                        check = false;
                    }
                }
                if (check == true) { values.Add(strings[i]); }
            }
            values.Sort();
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        public void ParseURL()
        {
            //4 program that parses an URL
            string url = "https://www.apple.com/iphone";
            string protocal = "";
            string server = "";
            string resource = "";
            int start = 0;
            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == ':')
                {
                    protocal = url.Substring(0, i);
                }
                if ((url[i] == '/') && (url[i + 1] == '/'))
                {
                    server = url.Substring(i + 2, url.IndexOf(".com") - 4);
                    i = url.IndexOf('.');
                }
                if (url[i] == '/')
                {
                    resource = url.Substring(i + 1);
                }
            }
            Console.WriteLine($"[protocol] = {protocal}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");
        }













    }
}
