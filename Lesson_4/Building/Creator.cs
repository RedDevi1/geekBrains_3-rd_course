using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Creator
    {
        private string nameOfCreator;
        public string NameOfCreator
        {
            get => nameOfCreator;
        }
        private static Hashtable buildsTable = new Hashtable();

        public static Hashtable BuildsTable
        {
            get => buildsTable;
        }
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
            if (!buildsTable.ContainsKey(numOfBuild))
                Console.WriteLine("Дома с номером {0} не существует", numOfBuild);
            buildsTable.Remove(numOfBuild);
        }
    }
}
