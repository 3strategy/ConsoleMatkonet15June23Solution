﻿namespace ConsoleMatkonet15June23Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        // Q1
        public static void Switch(char[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
                if (arr[i] + 1 == arr[^(i + 1)]) // ניתן כמובן לגשת בדרך הישנה 
                    (arr[i], arr[^(i + 1)]) = (arr[^(i + 1)], arr[i]); // temp ניתן כמובן להחליף באמצעות 
        }

        // Q2 טבלת מעקב תחזיר 3
        // Q2 סעיף ג טבלת מעקב 2, הזימון יחזיר 2 
        // מטרת הפעולה לחשב את הפרש כמות הספרות בין שני המספרים


        //Q3 מספרים ידידים סכום מחלקים Friends
        public static int CalcDivisorsSum(int n) //א
        {
            int sum = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) sum += i;
            return sum;
        }
        //Q3 מספרים ידידים פונקציית עזר Friends
        public static bool Friends(int n1, int n2) => CalcDivisorsSum(n1) == n2 && CalcDivisorsSum(n2) == n1 && CalcDivisorsSum(n1) != n1;

        //Q3 מספרים ידידים תכנית ראשית Friends
        public static void Main3ListFriends() //print 10 friend
        {
            int n = 0;
            int last = 0;
            for (int i = 1; i <= 10; i++)
                while (true)
                {
                    int divS = CalcDivisorsSum(++n);
                    if (Friends(n, divS) && divS != last)
                    {
                        Console.WriteLine($"{i}) {n} and {divS} are mates");
                        last = n; // ניתן לחילופין לעבוד עם מערך
                        break;
                    }
                }
        }

        //Q4 סעיף ג פעולה חיצונית
        // Road.cs כל השאר נמצא בקובץ 
        public static void MostDangerousRoad(Road[] roads)
        {
            Road MaxRoad = roads[0];
            foreach (var rd in roads)
                if (rd.YoungAccidents() >= MaxRoad.YoungAccidents())
                    MaxRoad = rd;
            Console.WriteLine(MaxRoad.GetRoadNum());
        }

        //Q6 סעףיף א IsBalanced
        public bool IsBalanced(int[,] arr, int row, int col)
        {
            int s1 = 0, s2 = 0;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    s1 += arr[i, j];
            for (int i = row + 1; i < arr.GetLength(0); i++)
                for (int j = col + 1; j < arr.GetLength(1); j++)
                    s2 += arr[i, j];
            return s1 == s2;
        }

        //Q6 סעיף ב
        public void PrintIndexes(int[,] arr)
        {
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
                for (int j = 1; j < arr.GetLength(1) - 1; j++)
                    if (IsBalanced(arr, i, j))
                        Console.WriteLine(i + " " + j);
        }
    }
}