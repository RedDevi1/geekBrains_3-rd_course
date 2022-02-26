using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    interface ICoder
    {
        public string Encode(string filePathToCode, string encodedFilePath);
        public string Decode(string filePathToCode, string decodedFilePath);
    }
}
