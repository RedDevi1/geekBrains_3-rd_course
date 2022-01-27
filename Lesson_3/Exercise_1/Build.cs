using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Build
    {
        private int numOfBuild;
        private double heightOfBuild;
        private int numOfStoreys;
        private int numOfFlats;
        private int numOfEntrances;
        private static int lastNumOfBuild;
        public Build()
        {
            GenNumOfBuild();
            this.numOfBuild = lastNumOfBuild;
        }
        public void FillInDataOfBuild()
        {
            Console.WriteLine("Введите высоту дома");
            this.heightOfBuild = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество этажей дома");
            this.numOfStoreys = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество квартир в доме");
            this.numOfFlats = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество парадных в доме");
            this.numOfEntrances = int.Parse(Console.ReadLine());
        }
        public void PrintDataOfBuild()
        {
            Console.WriteLine($"Номер дома: {numOfBuild}");
            Console.WriteLine($"Высота дома: {heightOfBuild}");
            Console.WriteLine($"Количество этажей дома: {numOfStoreys}");
            Console.WriteLine($"Количество квартир в доме: {numOfFlats}");
            Console.WriteLine($"Количество парадных в доме: {numOfEntrances}");
        }
        public double HeightOfStorey()
        {
            return this.heightOfBuild / this.numOfStoreys;
        }
        public int NumOfFlatsInTheEntrance()
        {
            return this.numOfFlats / this.numOfEntrances;
        }
        public int NumOfFlatsOnTheFloor()
        {
            return this.numOfFlats / this.numOfEntrances / this.numOfStoreys;
        }
        private static int GenNumOfBuild()
        {
            return ++lastNumOfBuild;
        }
    }
}
