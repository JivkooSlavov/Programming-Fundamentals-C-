using System.Text.RegularExpressions;

namespace _2.FancyBarcodesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfBarcodes = int.Parse(Console.ReadLine());
            string pattern = $"@#+(?<barcode>[A-Z][A-Za-z0-9]{{4,}}[A-Z])@#+";
            Regex reg = new Regex(pattern);

            for (int i = 0; i < countOfBarcodes; i++)
            {
                string line = Console.ReadLine();
                MatchCollection matches = reg.Matches(line);
                if (matches.Count == 0 )
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                foreach (Match match in matches)
                {
                    string barcode = match.Groups["barcode"].Value;
                    string barcodeDigits = new string(barcode.Where(x => char.IsDigit(x)).ToArray());
                    if (barcodeDigits.Length == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {barcodeDigits}");
                    }
                }
            }
        }
    }
}