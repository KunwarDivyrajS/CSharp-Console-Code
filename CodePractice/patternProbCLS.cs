﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    public interface iSample
    {
        void printM(string val = "Interface Executed");
    }
    public class Sample : iSample
    {
        public void printM(string val = "Class Executed")
        {
            Console.WriteLine(val);
        }
    }

    internal class patternProbCLS
    {
        public void pyramidPattern()
        {
            Console.WriteLine("Pyramid Pattern Problem : Using StringBuilder!");
            StringBuilder strBuild = new StringBuilder();
            Console.Write("Enter Number of Rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            //For R1 C1, R2 C3, R3 C5 in odd number increases with 2;
            //by Using Linear Equation C=mR+b and Finding b (e.q. : -1) by putting C and R is 1&1 as first case, 
            //m is slope exponational who increases with 2, So our formula becames [fn : C=2R-1]
            int column = 2 * row - 1;
            Console.WriteLine("\n");
            double center = Math.Round(((double)column / 2), MidpointRounding.AwayFromZero);


            string space = " ";
            string s = "*";
            center = center - 1;
            int numStar;
            int rowL = row;
            //Row Execution
            for (int r = 0; r < row; r++)
            {
                numStar = (int)center;
                //For Print Space 
                //upto 3-1 print space
                for (int i = 0; i < center; i++)
                {
                    strBuild.Append(space);
                }
                //print star here
                for (int j = rowL; j > numStar; j--)
                {
                    strBuild.Append(s);
                }
                center = center - 1;
                rowL = rowL + 1;
                strBuild.Append("\n");
            }
            Console.WriteLine(strBuild);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        
        public void reverseString()
        {
            Console.WriteLine("Reverse String");
            Console.WriteLine("Please, Enter Your String Here");
            string s = Console.ReadLine();
            char[] charStr = s.ToCharArray();
            StringBuilder reverseStr = new StringBuilder();
            for(int i=charStr.Length-1; i>=0; i--)
            {
                reverseStr.Append(charStr[i]);
            };
            Console.WriteLine(reverseStr.ToString());
        }

        public void rightAnglePattern()
        {
            string s = "*";
            Console.WriteLine("Enter Number of Rows You Want!");
            int row = Convert.ToInt32(Console.ReadLine());
            StringBuilder strPattern = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                strPattern.Append(s);
                Console.WriteLine(strPattern);
            }
        }

        public void isPrimeNumber()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.\n");
            }
            else
            {
                Console.Write("Number is not Prime.\n");
            }
            //Console.ReadKey();
        }   

        public void interfaceWithClass()
        {
            Sample s = new Sample();
            Console.WriteLine("Sample s = new Sample();");
            s.printM();
            iSample i = s;
            Console.WriteLine("iSample i = s;");
            i.printM();
            Console.ReadKey();
        }

        public void additionOfArray()
        {
            //\CodePractice.csproj
            string OutputPath = @"..\..\..\\DocGenerated\\FilePath\\GeneratedFile.txt";

            string directory = Path.GetDirectoryName(OutputPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);  // Create the directory if it doesn't exist
            }

            TextWriter textWriter = new StreamWriter(OutputPath, true);
            try
            {
                Console.WriteLine("Enter Array Count");
                int arCount = Convert.ToInt32(Console.ReadLine().Trim());

                //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
                Console.WriteLine("Please Enter Number :");
                List<int> ar = new List<int>();
                for (int i = 0; i < arCount; i++)
                {
                    Console.WriteLine($"Enter {i+1} Number");
                    ar.Add(int.Parse(Console.ReadLine()));
                }
                int result = ArraySum(ar);

                textWriter.WriteLine("Result \n{0} : Sum = {1}\n", DateTime.Now, result);

                textWriter.Flush();
                textWriter.Close();
            }
            catch (Exception ex)
            {

                textWriter.WriteLine("Exception \n{0} : Exception = {1}\n", DateTime.Now, ex);

                textWriter.Flush();
                textWriter.Close();
                Console.WriteLine(ex);
                throw;
            }
        }

        public static int ArraySum(List<int> ar)
        {
            int sum = 0;
            //foreach (var item in ar)
            //{
            //    sum += item;
            //}
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine($"Result {sum}");
            return sum;
        }

    }
}
