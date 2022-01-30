using System;


namespace Building
{
    internal class Build
    {
        private int numOfBuild;
        private double heightOfBuild;
        private int numOfStoreys;
        private int numOfFlats;
        private int numOfEntrances;
        private static int lastNumOfBuild;
        public int NumOfBuild
        {
            get => this.numOfBuild;
        }
        public Build(double heightOfBuild, int numOfStoreys)
        {
            GenNumOfBuild();
            numOfBuild = lastNumOfBuild;
            this.heightOfBuild = heightOfBuild;
            this.numOfStoreys = numOfStoreys;
        }
        public Build(double heightOfBuild, int numOfStoreys, int numOfFlats)
        {
            GenNumOfBuild();
            numOfBuild = lastNumOfBuild;
            this.heightOfBuild = heightOfBuild;
            this.numOfStoreys = numOfStoreys;
            this.numOfFlats = numOfFlats;
        }
        public Build(double heightOfBuild, int numOfStoreys, int numOfFlats, int numOfEntrances)
        {
            GenNumOfBuild();
            numOfBuild = lastNumOfBuild;
            this.heightOfBuild = heightOfBuild;
            this.numOfStoreys = numOfStoreys;
            this.numOfFlats = numOfFlats;
            this.numOfEntrances = numOfEntrances;
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
