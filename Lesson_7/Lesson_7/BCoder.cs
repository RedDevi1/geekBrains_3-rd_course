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
                    var encodedString = EncodeDecode(s);
                    File.AppendAllText(encodedByBCoderFilePath, encodedString.ToString());
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
                    EncodeDecode(s);
                    var decodedString = EncodeDecode(s);
                    File.AppendAllText(decodedByBCoderFilePath, decodedString.ToString());
                }
        }
        private static StringBuilder EncodeDecode (string s)
        {
            StringBuilder sb = new (s.Length);
            for (var i = 0; i < s.Length; i++)
            {
                if (!Char.IsLetter(s[i]) || (int)s[i] == 1025 || (int)s[i] == 1105)
                    sb.Append(s[i]);
                else
                {
                    if ((int)s[i] >= 65 && (int)s[i] <= 90)
                        sb.Append((char)(90 - ((int)s[i] - 65)));
                    else if ((int)s[i] >= 97 && (int)s[i] <= 122)
                        sb.Append((char)(122 - ((int)s[i] - 97)));
                    else if ((int)s[i] >= 1040 && (int)s[i] <= 1071)
                        sb.Append((char)(1071 - ((int)s[i] - 1040)));
                    else if ((int)s[i] >= 1072 && (int)s[i] <= 1103)
                        sb.Append((char)(1103 - ((int)s[i] - 1072)));
                }
            }
            sb.Append("\r\n");
            return sb;
        }
    }
}
