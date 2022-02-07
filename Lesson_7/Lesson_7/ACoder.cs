using System;
using System.IO;
using System.Text;

namespace Lesson_7
{
    public class ACoder : ICoder
    {
        public void Encode(string filePathToCode, string encodedByACoderFilePath)
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
                            sb.Append((char)((int)s[i] + 1));
                    }
                    sb.Append("\r\n");
                    File.AppendAllText(encodedByACoderFilePath, sb.ToString());
                }
            
        }
        public void Decode(string filePathToDecode, string decodedByACoderFilePath)
        {
            if (!File.Exists(filePathToDecode))
                throw new FileNotFoundException("Файл с данными не найден", filePathToDecode);
            using (var file = File.OpenText(filePathToDecode))
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
                        else if (s[i] == 'A')
                            sb.Append('Z');
                        else if (s[i] == 'a')
                            sb.Append('z');
                        else if (s[i] == 'А')
                            sb.Append('Я');
                        else if (s[i] == 'а')
                            sb.Append('я');
                        else
                            sb.Append((char)((int)s[i] - 1));
                    }
                    sb.Append("\r\n");
                    File.AppendAllText(decodedByACoderFilePath, sb.ToString());
                }
        }
    }
}
