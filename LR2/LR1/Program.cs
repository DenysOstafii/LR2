using System.Diagnostics;
using LR1;

static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введіть розмір даних:");
            int size = int.Parse(Console.ReadLine());
            Sort sort = new Sort();
            List<Animal> animals = RandomData.GenerateRandomData(size);
        
            Stopwatch time = new Stopwatch();
            time.Start();
            sort.SortByBreed(animals);
            sort.SortByAge(animals);
            sort.SortByType(animals);
            time.Stop();
            Console.WriteLine($"Casual sort : {time.ElapsedMilliseconds} ms");
        
            animals = RandomData.GenerateRandomData(size);
            time.Reset();
            time.Start();
            sort.SortAgeByTask(animals);
            sort.SortTypeByTask(animals);
            sort.SortBreedByTask(animals);
           time.Stop();
            Console.WriteLine($"Single Thread : {time.ElapsedMilliseconds} ms");
            
            animals = RandomData.GenerateRandomData(size);
            time.Reset();
            time.Start();
            sort.MultiSort(animals);
            time.Stop();
            Console.WriteLine($"Multi thread sort :  {time.ElapsedMilliseconds} ms");
            
    }
    }

    
