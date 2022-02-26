using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7
{
    class ACoder : ICoder
    {
        public string Encode(string filePathToCode, string encodedFilePath)
        {
            if (!File.Exists(filePathToCode))
                throw new FileNotFoundException("Файл с данными не найден", filePathToCode);
            using (var file = File.OpenText(filePathToCode))
                while (!file.EndOfStream)
                {
                    var s = file.ReadLine();
                    if (s.Length == 0)
                        continue;
                    StringBuilder sb = new StringBuilder(s.Length);
                    for (var i = 0; i < s.Length; i++)
                    {
                        if (!Char.IsLetter(s[i]))
                            sb.Append(s[i]);
                        else if (s[i] == 'Z')
                            sb.Append('A');
                        else if (s[i] == 'z')
                            sb.Append('a');
                        else if (s[i] == 'Я')
                            sb.Append('А');
                        else if (s[i] == 'я')
                            sb.Append('а');
                        else

                    }
                }
                    return;
        }
        public string Decode(string filePath)
        {
            return;
        }
    }
}
