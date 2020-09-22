using System;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample program  
            //int myint = 5;
            //console.writeline("value of myint {0}", myint);
            //console.writeline("hello world!");
            //int age = 10;
            //if (age < 10 & age != 5)
            //{
            //    Console.WriteLine("Age is less than 10");
            //}
            //else if (age > 10)
            //{
            //    Console.WriteLine("Age is more than 10");
            //    //else
            //    //    Console.WriteLine("Age is 5");
            //    Console.WriteLine("Done");
            //}

            //input from console
            //Console.WriteLine("What's ur name");
            //int name=int.Parse(Console.ReadLine());
            //Console.WriteLine("My Name is {0}", name);

            //Console.WriteLine("Enter a year");
            //int year = int.Parse(Console.ReadLine());

            //switch (year)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("years 1");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("year 2");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("year 3");
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("This is default block");
            //        break;
            //}

            //int x = 160 ,y = 15;
            //int biggestNo = (x > y ? x : y);
            //Console.WriteLine("biggest no is {0}", biggestNo);

            //bool myBool = true;
            //if (!myBool)
            //{
            //    Console.WriteLine("Negation not applied",myBool);
            //}
            //else
            //    Console.WriteLine("Negation applied" ,!myBool);


            //int value = 6;
            //switch(value > 5)
            //{
            //    case true:
            //        {
            //            Console.WriteLine("true");
            //            break;
            //        }
            //}

            //int x = 1;
            //while (x < 5)
            //{
            //    Console.WriteLine("{0}", x);
            //    x++;
            //}

            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }

            //for(; ; )
            //{

            //}

            //int[] grade = { 66, 75, 23, 50, 88 };

            //for (int i = 0; i < grade.Length; i++)
            //{
            //    grade[i] = grade[i] + 3;
            //    Console.WriteLine(grade[i]);
            //}

            //int[] numArray = { 68, 45, 24, 55, 98, 101 };
            //Console.WriteLine("enter no to search in array");
            //int searchNum=int.Parse(Console.ReadLine());

            //for(int i = 0; i < numArray.Length; i++)
            //{
            //    if(numArray[i] == searchNum)
            //    {
            //        Console.WriteLine("number found {0} at {1}", numArray[i], i);
            //    }
            //}

            //sorting array
            //int[] myArray = {55,78,14,24}
            // Array.Sort(myArray);
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //reverse array
            //int[] reverseArray = { 33, 18, 99, 63 };
            //Array.Reverse(reverseArray);
            //foreach(int num in reverseArray)
            //{
            //    Console.WriteLine(num);
            //}

            //rectangle array
            //int[,] twoDArray =
            //{
            //    {5,6,7,8 },
            //    {1,2,3,4 },
            //    {7,8,9,10 }
            //};

            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        Console.Write(twoDArray[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            ////jagged array
            //int[][] myArray = new int[3][];
            //myArray[0] = new int[2] { 5, 6 };
            //myArray[1] = new int[4] { 1, 2, 3, 4 };
            //myArray[2] = new int[3] { 5, 6, 7 };

            //for(int i=0; i < 3; i++)
            //{
            //    for(int j=0;j< myArray[i].Length; j++)
            //    {
            //        Console.Write(myArray[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //not worked
            //int[] myArray = { 5, 6, 7 };

            //foreach (int x in myArray)

            //{

            //    x += 5;

            //}

            //pass by reference
            //    int[] vref = new int[1];
            //    vref[0] = 5;
            //    Console.WriteLine("before function called {0}", vref[0]);
            //    funValue(vref);
            //    Console.WriteLine("after function called {0}",vref[0]);

            //ref keyword
            //int i = 5;
            //method1(ref i);
            //Console.WriteLine("Value of variable {0}", i);

            //out keyword
            //int x,y;
            //methodOut(out x,out y);
            //Console.WriteLine("Value of x and y variable {0} {1}", x,y);

            //param keyword
            //int add= paramMethod(2, 3, 4, 5, 6,1);
            //Console.WriteLine("Added values in param method {0}", add);

            //optional and named argument
            //Console.WriteLine(methodOptional(5));
            //Console.WriteLine(methodOptional(5 ,c:10));

            //Person[] people = new Person[2];

            //people[0].Name = "Fred";

            //people[0].Age = 5;

            //people[1].Name = "Bob";

            //people[1].Age = 10;



        }
        //public static void funValue(int[] vref)
        //{
        //    vref[0] += 3;
        //}

        //ref method
        //public static void method1(ref int j)
        //{
        //    j++;
        //}

        //out method
        //public static void methodOut(out int x ,out int y)
        //{
        //    x = 10; y = 1;
        //    x++;
        //    y *= 2;

        //}

        //param method
        //public static int paramMethod(params int [] myArray)
        //{

        //    int total = 0;
        //    foreach(int i in myArray)
        //    {
        //        total += i;
        //    }
        //    return total;
        //}

        //optional and named argument method
        //public static int methodOptional(int a, int b =2, int c =3)
        //{

        //   int add = a + b + c;
        //    return add;
        //}

    }
}

