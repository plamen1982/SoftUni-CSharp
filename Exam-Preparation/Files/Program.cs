using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

          
            Dictionary<string, Dictionary<string, long>> rootsExtentionsAndSizes = new Dictionary<string, Dictionary<string, long>>();
            while (n-- > 0)
            {
                //Windows\Temp\win.exe;5423 - test
                string[] line = Console.ReadLine().Split("\\");
                string root = line[0];
                string fileNameAndSize= line[line.Length - 1];
                string fileName = fileNameAndSize.Split(";")[0];
                long size = long.Parse(fileNameAndSize.Split(";")[1]);

                //does not exist
                if (rootsExtentionsAndSizes.ContainsKey(root) == false)
                {
                    rootsExtentionsAndSizes.Add(root, new Dictionary<string, long>());
                    if (rootsExtentionsAndSizes[root].ContainsKey(fileName) == false)
                    {
                        rootsExtentionsAndSizes[root].Add(fileName, size);
                    }
                    else
                    {
                        rootsExtentionsAndSizes[root][fileName] = size;
                    }
                }
                else
                {
                    if (rootsExtentionsAndSizes[root].ContainsKey(fileName) == false)
                    {
                        rootsExtentionsAndSizes[root].Add(fileName, size);
                    }
                    else
                    {
                        rootsExtentionsAndSizes[root][fileName] = size;
                    }
                }
            }

            string[] output = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string extentionOutput = output[0];
            string rootOutput = output[2];
            bool isExist = false;
            bool isPrint = false;
            //rootsExtentionsAndSizes = [Games: {keygen.exe: 1024, wow.exe: 1024}, Windows : { someKey: someVaue}  }]; output = "Games"
            if (rootsExtentionsAndSizes.ContainsKey(rootOutput))
            {

                var result = rootsExtentionsAndSizes.Where(x => x.Key.Contains(rootOutput)).ToDictionary(x => x.Key, v => v.Value);
                foreach (var filesSizes in result.Values)
                {
                    //filesSizes = [{keygen.exe: 1024}, {k:v}]
                    //fileSize k:v
                    foreach (var fileSize in filesSizes.Where(x => x.Key.Contains(extentionOutput)).ToDictionary(x => x.Key, v => v.Value))
                    {
                        //k : "string"
                        if (fileSize.Key.Contains($".{extentionOutput}") == false)
                        {
                            isExist = false;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{fileSize.Key} - {fileSize.Value} KB");
                            isExist = true;
                            isPrint = true;
                        }
                    }
                } 
            }
            else
            {
                Console.WriteLine("No");
            }
            if (isPrint == false && isExist == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
