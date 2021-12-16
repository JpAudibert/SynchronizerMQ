using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Helper;

public class FileReader
{
    public static List<string> ReadFile(string file)
    {
        string[] lines = Array.Empty<string>();

        if (File.Exists(file))
        {
            lines = File.ReadAllLines(file);
        }

        List<string> linesList = lines.ToList();

        return linesList;
    }

    public class PathCombiner
    {
        public static string combineInputPaths(List<string> fileToCombine)
        {
            string currentDir = Environment.CurrentDirectory;
            fileToCombine.Insert(0, currentDir);
            string fileCombined = Path.GetFullPath(Path.Combine(fileToCombine.ToArray()));
            return fileCombined;
        }
    }
}
