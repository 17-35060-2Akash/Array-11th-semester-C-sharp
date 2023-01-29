using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_A_
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //1.Single-dimensional array
            //2.Multi-dimensional array
            //3.Jagged array

            //Single-dimensional array

            //string[] numberList = new string[3];
            //int[] numberList = new int[3];
            //numberList[0] = 10;
            //numberList[1] = 20;
            //numberList[2] = 30;

            //int[] numberList = new int[3] { 10, 20, 30 };
            //int[] numberList = new int[] { 10, 20, 30 };
            //int[] numberList = { 10, 20, 30 };

            //Console.WriteLine(numberList[3]);
            //for (int i = 0; i < numberList.Length; i++)
            //{
            //    Console.WriteLine(numberList[i]);
            //}
            //foreach (int item in numberList)
            //{
            //    Console.WriteLine(item);
            //}


            //Multi-dimensional array
            //int[,] numberList = new int[2, 3];
            //numberList[0, 0] = 10;
            //numberList[0, 1] = 20;
            //numberList[0, 2] = 30;

            //numberList[1, 0] = 40;
            //numberList[1, 1] = 50;
            //numberList[1, 2] = 60;

            //int[,] numberList = new int[2, 3] { 
            //                                        {10,20,30 },
            //                                        {40,50,60 }
            //                                    };
            //int[,] numberList = new int[,] {
            //                                        {10,20,30 },
            //                                        {40,50,60 }
            //                                    };

            //int[,] numberList = {
            //                        {10,20,30 },
            //                        {40,50,60 }
            //                     };

            //for (int i = 0; i < numberList.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numberList.GetLength(1); j++)
            //    {
            //        Console.Write(numberList[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            //int i = 0;
            //foreach (int item in numberList)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.Write(item+" ");
            //    i++;
            //}

            //Jagged array
            //int[][] numberList = new int[2][];
            //numberList[0] = new int[] { 10, 20, 30 };
            //numberList[1] = new int[] { 40, 50 };

            //int[][] numberList = new int[2][] {
            //                                       new int[3] {10,20,30 },
            //                                       new int[2] { 40,50}
            //                                  };
            //int[][] numberList = new int[2][] { 
            //                                        new int[] {10,20,30 },
            //                                        new int[] { 40,50}
            //                                  };
            //int[][] numberList = new int[][] {
            //                                        new int[] {10,20,30 },
            //                                        new int[] { 40,50}
            //                                  };
            //int[][] numberList ={
            //                        new int[] {10,20,30 },
            //                        new int[] { 40,50}
            //                     };
            //for (int i = 0; i < numberList.Length; i++)
            //{
            //    for (int j = 0; j < numberList[i].Length; j++)
            //    {
            //        Console.Write(numberList[i][j]+" ");
            //    }
            //    Console.Write("|");
            //}

            //foreach (int[] items in numberList)
            //{
            //    foreach (int item in items)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Array of objects

            //Book b1 = new Book() { Title = "C# Complete Reference", Author = "Herbert Scheild" };
            //Book b2 = new Book() { Title = "Teach Yourself C", Author = "Herbert Scheild" };

            //Book[] books = new Book[] { b1, b2 };
            Book[] books = new Book[] { 
                                            new Book() { Title = "C# Complete Reference", Author = "Herbert Scheild" } ,
                                            new Book() { Title = "Teach Yourself C", Author = "Herbert Scheild" }
                                       };

            foreach (Book book in books)
            {
                Console.WriteLine(book.Author);
            }

            Console.WriteLine(books[1].Title);
        }
    }
}
