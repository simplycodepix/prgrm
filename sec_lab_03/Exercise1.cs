using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace sec_lab_03
{
    class Exercise1
    {
        public Exercise1()
        {
            string projectDIR = System.IO.Path.GetFullPath(@"..\..\");
            char separator = ' ';
            using (StreamReader TextFile = new StreamReader(projectDIR + "TextFile.txt"))
            {
                string text = TextFile.ReadLine();
                string[] words = text.Split(separator);

                StringBuilder finalOutpup = new StringBuilder();
                foreach (string word in words)
                {
                    if (word.StartsWith("*"))
                    {
                        finalOutpup.Append(ReplaceCharactersWithStars(word) + " ");
                    } else
                    {
                        finalOutpup.Append(word + " ");
                    }
                }
                Console.WriteLine(finalOutpup);
            }
        }

        string ReplaceCharactersWithStars(string word)
        {
            StringBuilder stars = new StringBuilder(word.Length);
            for (int i = 0; i < word.Length; i++)
            {
                stars.Append('*');
            }

            return stars.ToString();
        }
    }
}
