using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] windows = { "Windows", "Windows", "Windows", "Games", "Games", "OtherGames", "OtherGames" };
            string games = "Games";
            List<string> fileName1 = new List<string> { "keygen.exe", "wow.exe", "keygen.exe", "wow.exe", "keygen.exe" };
            List<long> size1 = new List<long> { 1024, 2056, 4128, 8256, 16512 };

            Dictionary<string, Dictionary<string, long>> filesNamesAndSizes = new Dictionary<string, Dictionary<string, long>>();
            // windows = new Dict()
            //{windows : {kyegen.exe, 1024, wow.exe, 2056}}
            for (int i = 0; i < 5; i++)
            {
                // Check if windows exist, 
                if (filesNamesAndSizes.ContainsKey(windows[i]) == false)
                {
                    //create Dict, and add key, value to this new dict with key windows
                    filesNamesAndSizes[windows[i]] = new Dictionary<string, long>();
                    if (filesNamesAndSizes[windows[i]].ContainsKey(fileName1[i]) == false)
                    {
                        //if key for the inner dict does not exist create new pair key, value
                        filesNamesAndSizes[windows[i]].Add(fileName1[i], size1[i]);

                    }

                    else
                    {   // if the key for the inner dict exist, override the value, or if you want accumulate it with +=
                        filesNamesAndSizes[windows[i]][fileName1[i]] = size1[i];
                    }
                }
                else
                {
                    // if exist, check if there is a key existing agains windows key in the other dictionary,
                    if (filesNamesAndSizes[windows[i]].ContainsKey(fileName1[i]) == false)
                    {
                        //if does not exist, create such a such a key, with size
                        filesNamesAndSizes[windows[i]].Add(fileName1[i], size1[i]);
                    }

                    else
                    {
                        //if it not exist add the value to this key, 
                        filesNamesAndSizes[windows[i]][fileName1[i]] += size1[i];
                        //or delete the existing value with a new one
                        //filesNamesAndSizes[windows[i]][fileName1[i]] = size1[i];
                    }

                }
            }


            foreach (var folder in filesNamesAndSizes.Values)
            {
                foreach (var fileNameAndSize in folder.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{fileNameAndSize.Key} - {fileNameAndSize.Value} KB");
                }
            }

            List<string> someStr = new List<string> { "List1Element", "List1Element" };
            someStr.fo
        }
    }
}
