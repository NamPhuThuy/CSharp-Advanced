using System.Diagnostics;
using IEnumerable_and_IEnumerator;

class Program
{
    static void Main()
    {
        
        if (false)
            HeroAcademyExample();
        
        if (false)
            ExampleWithLINQ();
        
        if (false)
            ExampleWithLINQ2();

        if (true)
            ExampleWithYield();

    }

    /// <summary>
    /// Introduce to IEnumerable
    /// </summary>
    static void HeroAcademyExample()
    {
        var academy = new HeroAcademy();
        Console.WriteLine($"Academy: {academy.Name}");

        foreach (var olympian in academy)
        {
            Console.WriteLine(olympian);
        }
        
    }

    static void ExampleWithLINQ()
    {
        var rand = new Random();
        List<int> numbers = Enumerable.Range(0, 10).ToList();
        
        IEnumerable<int> randomNumbers = numbers.OrderBy(n => rand.Next()).Take(3);
        // IEnumerable<int> randomNumbers = numbers.OrderBy(n => rand.Next()).Take(3).ToList();

        /*
         - With "ToList()" method:
            - The randomNumbers will act as a container => the random numbers will be the same every time we iterate over it
            - You grab all items and putting them all in the heap memory
            
         - Without "ToList()" method:
            - The randomNumbers will act as a query => every time you iterate over it, it will generate new random numbers
            - The number will be generated and processed one-by-one: IEnumerable uses deferred execution, meaning the query is not executed until you iterate over it
        */
        
        /*
         - Deferred Execution: The query is not executed when it is defined. Instead, it is executed when you start iterating over the IEnumerable.
         
         - One-by-One Processing: Each element is generated, processed, and then discarded before the next element is generated.
        */
        

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Random number the {i + 1} time");
            foreach (int randomNumber in randomNumbers)
            {
                Console.WriteLine($"number: {randomNumber}");
            }
            Console.WriteLine();
        }

        
    }

    static void ExampleWithLINQ2()
    {
        var rand = new Random();
        List<int> numbers = Enumerable.Range(0, 10).ToList();
        
        /*
         - With ToList(): Elapsed: 5
         - Without ToList(): Elapsed: 1542
         */
        var randNumbers = numbers.Where(n =>
        {
            Task.Delay(10).Wait();
            return true;
        });
        
        /*var randNumbers = numbers.Where(n =>
        {
            Task.Delay(10).Wait();
            return true;
        });*/

        var watch = new Stopwatch();
        watch.Start();

        for (int i = 0; i < 10; i++)
        {
            string s = "";
            foreach (int randNUm in randNumbers)
            {
                s += $"{randNUm} ";
            }
            Console.WriteLine(s);
        }
        watch.Stop();
        Console.WriteLine($"Elapsed: {watch.ElapsedMilliseconds}");
    }

    static void ExampleWithYield()
    {
        IEnumerable<int> GetNumbers()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Processed: {i}");
                yield return i;
            }
        }

        foreach(var num in GetNumbers())
            Console.WriteLine(num);

        /* Result:
        Processed: 0
        0
        Processed: 1
        1
        Processed: 2
        2
        */

        IEnumerable<int> threeNumbers = GetNumbers().Take(3);

        //Because we're only take 1 number -> the rest are ignored
        Console.WriteLine($"First number: {threeNumbers.First()}");
        Console.WriteLine($"We're done!!!!");
        
        /* Result
        Processed: 0
        First number: 0
        We're done!!!!
         */
    }
    
}