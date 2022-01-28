using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class TestClass
    {
        public static void Test()
        {
            Creator.CreateBuild(34.8, 10);
            Creator.CreateBuild(80, 20, 240);
            Creator.CreateBuild(100, 25, 300, 3);
            foreach (var builds in Creator.BuildsTable.Values)
                Console.WriteLine(builds.);
        }
    }
}
