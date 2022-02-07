using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    interface ICoder
    {
        public void Encode(string filePathToCode, string encodedFilePath);
        public void Decode(string filePathToDecode, string decodedFilePath);
    }
}
