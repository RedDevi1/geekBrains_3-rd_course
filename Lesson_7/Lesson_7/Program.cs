using System;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder aCoder = new();
            aCoder.Encode("NeedToCode.txt", "EncodedByACoder.txt");
            aCoder.Decode("EncodedByACoder.txt", "DecodedByACoder.txt");
            BCoder bCoder = new();
            bCoder.Encode("NeedToCode.txt", "EncodedByBCoder.txt");
            bCoder.Decode("EncodedByBCoder.txt", "DecodedByBCoder.txt");
        }
    }
}
