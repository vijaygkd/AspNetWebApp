using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace DataHelper
{
    internal class FileOps
    {
        private string FilePath = "C:\\MySource\\Repo\\AspNetWebApp\\DataHelper\\data\\columbus.csv";


        public string ReadFile()
        {
            using (TextFieldParser parser = new TextFieldParser(FilePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("\t");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                }

            }

            return null;
        }


        

    }
}
