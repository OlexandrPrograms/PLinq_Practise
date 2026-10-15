namespace PLinq_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ======== TASK 1 ========
            //List<int> list1 = new List<int> { 1, 2, 2, 3, 4, 5, 6 };
            //List<int> list2 = new List<int> { 2, 4, 4, 7, 8 };

            //var res1 = list1.AsParallel()
            //                .Where(n => !list2.Contains(n));
            //Print(res1);

            //var res2 = list1.AsParallel()
            //                .Where(n => list2.Contains(n))
            //                .Distinct();
            //Print(res2);

            //var res3 = list1.AsParallel()
            //                .Union(list2.AsParallel());
            //Print(res3);

            //var res4 = list1.AsParallel()
            //                .Distinct();
            //Print(res4);




            //// ======== TASK 2 ========
            //List<Car> cars1 = new List<Car>
            //{
            //    new Car("Camry", "Toyota", 2022),
            //    new Car("Mustang", "Ford", 2021),
            //    new Car("X5", "BMW", 2023),
            //    new Car("A4", "Audi", 2020)
            //};

            //List<Car> cars2 = new List<Car>
            //{
            //    new Car("Focus", "Ford", 2019),
            //    new Car("M3", "BMW", 2022),
            //    new Car("GLE", "Mercedes", 2023),
            //    new Car("Civic", "Honda", 2021)
            //};

            //var res1 = cars1.AsParallel()
            //                .Where(c => !(cars2.Select(c2 => c2.brand)).Contains(c.brand))
            //                .Distinct();
            //PrintCar(res1);

            //var res2 = cars1.AsParallel()
            //                .Where(c => (cars2.Select(c2 => c2.brand)).Contains(c.brand))
            //                .Distinct();
            //PrintCar(res2);

            //var res3 = cars1.AsParallel()
            //                .Concat(cars2.AsParallel())
            //                .DistinctBy(c => c.brand);
            //PrintCar(res3);




            //// ======== TASK 3 ========
            //int[] numbers = { 2, 9, 18, 952, 1000, 4, 7, 63, 14, 5 };

            //Int128 d = numbers.AsParallel().Aggregate((Int128)1, (acc, next) => acc * next);
            //Console.WriteLine(d);

            //int count = numbers.AsParallel().Count();
            //Console.WriteLine(count);

            //int count9 = numbers.AsParallel().Count(n => n % 9 == 0);
            //Console.WriteLine(count9);

            //int count7_945 = numbers.AsParallel().Count(n => n % 7 == 0 && n > 945);
            //Console.WriteLine(count7_945);

            //int sum = numbers.AsParallel().Sum();
            //Console.WriteLine(sum);

            //int sumEven = numbers.AsParallel().Where(n => n % 2 == 0).Sum();
            //Console.WriteLine(sumEven);

            //int min = numbers.AsParallel().Min();
            //Console.WriteLine(min);

            //int max = numbers.AsParallel().Max();
            //Console.WriteLine(max);

            //double avarage = numbers.AsParallel().Average();
            //Console.WriteLine(avarage);




            //// ======== TASK 4 ========
            //int[] numbers = { 2, 9, 18, 952, 1000, 4, 7, 63, 14, 5 };

            //var res1 = numbers.AsParallel()
            //                  .OrderDescending()
            //                  .Take(3);
            //Print(res1);

            //var res2 = numbers.AsParallel()
            //                  .Order()
            //                  .Take(3);
            //Print(res2);





            //// ======== TASK 5 ========
            //int[] numbers = { 2, 9, 18, 952, 1000, 4, 7, 63, 14, 5 };

            //var res1 = numbers.AsParallel()
            //                  .GroupBy(x => x)
            //                  .Select(x => new { Number = x.Key, Count = x.Count() });

            //foreach (var item in res1)
            //{
            //    Console.WriteLine($"{item.Number} — {item.Count} рази");
            //}
            //Console.WriteLine();


            //var res2 = numbers.AsParallel()
            //                  .Where(x => x % 2 == 0)
            //                  .GroupBy(x => x)
            //                  .Select(x => new { Number = x.Key, Count = x.Count() });

            //foreach (var item in res2)
            //{
            //    Console.WriteLine($"{item.Number} — {item.Count} рази");
            //}
            //Console.WriteLine();


            //var res3 = numbers.AsParallel()
            //                  .GroupBy(x => x % 2 == 0 ? "парні" : "непарні")
            //                  .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var item in res3)
            //{
            //    Console.WriteLine($"{item.Category} — {item.Count} рази");
            //}
        }

        public record Car(string model, string brand, int year);

        static void Print(IEnumerable<int> list)
        {
            foreach (int num in list)
                Console.Write(num + ", ");
            Console.WriteLine("\n=================================");
        }

        static void PrintCar(IEnumerable<Car> cars)
        {
            foreach(Car car in cars)
            {
                Console.WriteLine(car.brand + " / " + car.model + " / " + car.year);
            }
            Console.WriteLine("==================================");
        }
    }
}
