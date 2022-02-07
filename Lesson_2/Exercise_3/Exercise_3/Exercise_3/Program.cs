using System;
using System.IO;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {       
        static void Main(string[] args)
        {           
            GetEmailsFromFile("EmailAddressBook.txt", out var emails);
            using (var file = File.CreateText("EmailsBook.txt"))
                for (var i = 0; i < emails.Length; i++)
                    file.WriteLine(emails[i]);
        }
        private static void GetEmailsFromFile (string sourceFilePath, out string[] emails)
        {
            if (!File.Exists(sourceFilePath))
                throw new FileNotFoundException("Файл с данными не найден", sourceFilePath);

            var emailList = new List<string>();
            using (var file = File.OpenText(sourceFilePath))
                while (!file.EndOfStream)
                {
                    var s = file.ReadLine();
                    if (s.Length == 0)
                        continue;                    
                    SearchMail(ref s);
                    emailList.Add(s);
                }
     
            emails = emailList.ToArray();
        }
        private static void SearchMail(ref string s)
        {
            var data = s.Split('&');
            if (data.Length != 2)
                return;
            s = data[1].Trim();
        }
    }
}
