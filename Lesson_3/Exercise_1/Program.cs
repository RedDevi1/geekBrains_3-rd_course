using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Build build_1 = new Build();
            build_1.FillInDataOfBuild();
            build_1.PrintDataOfBuild();
            Console.WriteLine($"Высота этажа: {build_1.HeightOfStorey()}");
            Console.WriteLine($"Квартир в парадной: {build_1.NumOfFlatsInTheEntrance()}");
            Console.WriteLine($"Квартир на этаже: {build_1.NumOfFlatsOnTheFloor()}");
        }
    }
}
