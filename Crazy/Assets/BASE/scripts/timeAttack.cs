using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class timeAttack : MonoBehaviour
{

    //public int howOftenEnemyAttacking;
    //public int n; // how many attacks
    
    static void Main(string[] args)
    {
        //Console.WriteLine("Wpisz liczbe n  dla ciagu Fibonacciego");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine();

        Task<int> zadanie1Task = Task.Run(() =>
        {
            // czas
            print("Task 1");
            for (int i = 0; i < 11; i++)
            {
                Thread.Sleep(1000);
                //Console.Write("Time: " + 3 * i + " ");
                print("thread 1 - 1 sek");
            }
            return 1;
        });

        Task<int> zadanie2Task = Task.Run(() =>
        {
            print("Task2");
            // Liczby Fibonacciego,
            //double liczba1 = 0, liczba2 = 1, suma;
            //int i;

            //for (i = 2; i < n + 2; ++i)
            //{
                Thread.Sleep(3000);
            //    //suma = liczba1 + liczba2;
            //    //Console.WriteLine(" Liczba Fibbonaciego: " + suma);
            //    //liczba1 = liczba2;
            //    //liczba2 = suma;

            //}

            print("thread 2 - 3 sek");
            return 2;
        });

        //Pokaz1Task(zadanie1Task);
        //Pokaz2Task(zadanie2Task);

        Console.ReadKey();
    }

    static async void Pokaz1Task(Task<int> zadanie1Task)
    {
        int result1 = await zadanie1Task;
        //Console.WriteLine( "Koniec zad 1 ");
    }

    static async void Pokaz2Task(Task<int> zadanie2Task)
    {
        int result2 = await zadanie2Task;
        Console.WriteLine();
        Console.WriteLine("Koniec");
        // Krzysztof Sarapuk
    }

    void Update()
    {
        //
    }
}
