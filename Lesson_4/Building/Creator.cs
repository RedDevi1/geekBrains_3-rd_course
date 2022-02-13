using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Creator
    {
        private static Hashtable buildsTable = new Hashtable();

        public static Hashtable BuildsTable => buildsTable;
        
        public static void CreateBuild(double heightOfBuild, int numOfStoreys)
        {
            var build = new Build(heightOfBuild, numOfStoreys);
            buildsTable.Add(build.NumOfBuild, build);
        }
        public static void CreateBuild(double heightOfBuild, int numOfStoreys, int numOfFlats)
        {
            var build = new Build(heightOfBuild, numOfStoreys, numOfFlats);
            buildsTable.Add(build.NumOfBuild, build);
        }
        public static void CreateBuild(double heightOfBuild, int numOfStoreys, int numOfFlats, int numOfEntrances)
        {
            var build = new Build(heightOfBuild, numOfStoreys, numOfFlats, numOfEntrances);
            buildsTable.Add(build.NumOfBuild, build);
        }
        public static void DeleteBuild(int numOfBuild)
        {
            if (!buildsTable.ContainsKey((int)numOfBuild))
                Console.WriteLine("Дома с номером {0} не существует", numOfBuild);
            buildsTable.Remove(numOfBuild);
        }
    }
}
