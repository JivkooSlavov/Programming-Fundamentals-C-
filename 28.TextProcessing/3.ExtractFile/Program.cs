namespace _3.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directions = Console.ReadLine();
            int file = directions.LastIndexOf('\\');
            int extension = directions.LastIndexOf('.');
            string fileName = directions.Substring(file+1, extension-file-1);
            string fileExtension = directions.Substring(extension+1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}