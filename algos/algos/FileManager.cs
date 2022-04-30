using algos;

namespace files
{
    static public class FileManager
    {
        public static string[] GetDirectoriesRecur(string path)
        {
            string[] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            return dirs;   
        }

        public static string[] GetFilesRecur(string path, Boolean onlyFileName = false)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            return !onlyFileName 
                ? files 
                : files.Select(f => Path.GetFileName(f)).ToArray();
        }

        public static string PathToFile(string path, string filename, Boolean onlyPath = false)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            string result = files.First(f => Path.GetFileName(f) == filename);
            return onlyPath 
                ? Path.GetDirectoryName(result) ?? ""
                : result;
        }

        public static string[] AllPathsToFile(string path, string filename, Boolean onlyPath = false)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            IEnumerable<string> results = files.Where(f => Path.GetFileName(f) == filename);
            return onlyPath
                ? results.Select(f => Path.GetDirectoryName(f) ?? "").ToArray()
                : results.ToArray();
        }
    }
}
