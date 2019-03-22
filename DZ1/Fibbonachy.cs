using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Fibbonachy
    {
        public void FibbonachyInText()
        {
            List<int> strings = new List<int>();
            var loadFile = new StreamReader("fibbonachy.txt");
            string _string = "";
            while (!loadFile.EndOfStream)
            {
                _string = loadFile.ReadToEnd();
                string[] splitString = _string.Split(',');
                for (int i = 0; i < splitString.Count(); i++)
                {
                    strings.Add(int.Parse(splitString[i]));
                }
            }
            loadFile.Close();
            int countElements = strings.Count;
            for (int i = 0; i < countElements; i++)
            {
                strings.Add(strings[strings.Count - 1] + strings[strings.Count - 2]);
            }
            foreach (var c in strings)
            {
                Console.Write(c.ToString() + " ");
            }
            Console.ReadKey();

        }
    }
}
