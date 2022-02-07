using System;
using System.IO;
using System.Text;

namespace Lesson_7
{
    public class BCoder : ICoder
    {
        public void Encode(string filePathToCode, string encodedByBCoderFilePath)
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
                        else
                        {
                            if ((int)s[i] >= 65 && (int)s[i] <= 90)
                                sb.Append((char)(90 - ((int)s[i]) - 65));
                            else if ((int)s[i] >= 97 && (int)s[i] <= 122)
                                sb.Append((char)(122 - ((int)s[i]) - 97));
                            else if ((int)s[i] >= 192 && (int)s[i] <= 223)
                                sb.Append((char)(223 - ((int)s[i]) - 192));
                            else if ((int)s[i] >= 224 && (int)s[i] <= 255)
                                sb.Append((char)(255 - ((int)s[i]) - 224));
                        }
                    }
                    sb.Append("\r\n");
                    File.AppendAllText(encodedByBCoderFilePath, sb.ToString());
                }
        }
        public void Decode(string filePathToDecode, string decodedByBCoderFilePath)
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
                        else
                        {
                            if ((int)s[i] >= 65 && (int)s[i] <= 90)
                                sb.Append((char)(90 - ((int)s[i]) - 65));
                            else if ((int)s[i] >= 97 && (int)s[i] <= 122)
                                sb.Append((char)(122 - ((int)s[i]) - 97));
                            else if ((int)s[i] >= 192 && (int)s[i] <= 223)
                                sb.Append((char)(223 - ((int)s[i]) - 192));
                            else if ((int)s[i] >= 224 && (int)s[i] <= 255)
                                sb.Append((char)(255 - ((int)s[i]) - 224));
                        }
                    }
                    sb.Append("\r\n");
                    File.AppendAllText(decodedByBCoderFilePath, sb.ToString());
                }
        }
    }
}
