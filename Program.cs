using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }        
        }

        public static void PrintOdds()
        {
            for (int i = 0; i <= 255; i++)
            {
                if (i %2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                // Console.WriteLine("New number: " + i + " Sum: " + sum);
                //OR
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            // foreach (var num in numbers)
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void FindMax(int[] numbers)
        {   
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach (var i in numbers)
            {
                sum += i;
            } 
        float average = sum / numbers.Length; // or int average
        Console.WriteLine($"the average is {average}");
        }

        
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].

        public static int[] OddArray()
        {
            List<int> OddList = new List<int>();
            for (int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    OddList.Add(i);
                }
            }
            int[] OddNum = OddList.ToArray();

            for(var i = 0; i <= OddNum.Length; i++){
                Console.WriteLine(OddNum[i]);
            }
            return OddNum;
            
        }


        //Or
        // public static int[] OddArray()
        // {
        //     int[] odds = new int[128]; // 128 is the length of the arr which is all the odds # from 1-255
        //     int j = 0;
        //     for(int i = 0; i <= 255; i++){
        //         if(i%2==1){
        //             odds[j] = i;
        //             j++;
        //         }
        //     }
        //     for(var i=0; i<=odds.Length; i++){

        //     Console.WriteLine(odds[i]);
        //     }
        //     return odds;
        // }

        // public static int[] OddArray()
        // {

        //     List<int> numList = new List<int>();
        //     for (int i = 1; i <= 255; i=i+2)
        //     {
        //         numList.Add(i);
        //     }
        //     int[] numArray = numList.ToArray();
        //     for(int i = 0; i < numArray.Length; i++)
        //     {
        //         Console.WriteLine(numArray[i]);
        //     }
        //     return numArray;
        // }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            for(var i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    count += 1;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for(var i = 0; i < numbers.Length; i++){
                
                numbers[i] *= numbers[i];
                //Or
                // numbers[i] = numbers[i] * numbers[i];

                Console.WriteLine(numbers[i]);
            }

        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (var i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0){
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            for(var i = 1; i < numbers.Length; i++){
                sum += numbers[i];

                if(numbers[i] < min){
                    min = numbers[i];
                }
                if(numbers[i] > max){
                    max = numbers[i];
                }
            }
            int average = sum / numbers.Length;
            Console.WriteLine($"The min is {min}, the max is {max} and the average is {average}");
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function,
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1 ] = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] NewArr = new object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    NewArr[i] = "Dojo";
                }
                else{
                    NewArr[i] = numbers[i];
                }

                Console.WriteLine(NewArr[i]);
            }
            
            return NewArr;
        }


        static void Main(string[] args) 
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(new int[] { 1, 5, 7, 9, 4 });
            // FindMax(new int [] {-50,-5,63,8,9});
            // GetAverage(new int [] {2,5,9,1,2,3});
            // OddArray();
            // GreaterThanY(new int []{8,6,7,5,1,2,0}, 3);
            // SquareArrayValues(new int[]{2,22,2,2,3});
            // EliminateNegatives(new int[]{-2,2,4,-9,2,-7});
            // MinMaxAverage(new int[]{5,9,4,6,8,2,10});
            // ShiftValues(new int[]{1,5,7,9,58,7});
            NumToString(new int[]{1,5,7,9,-58,7});


        }

    }
}
