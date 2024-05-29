namespace _3.Inventary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventary = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] items = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string function = items[0];
                
                if (function== "Collect")
                {
                    string item = items[1];
                    if (!inventary.Contains(item))
                    {
                        inventary.Add(item);
                    }
                }
                else if (function == "Drop")
                {
                    string item = items[1];
                    if (inventary.Contains(item))
                    {
                        inventary.Remove(item);
                    }
                }
                else if (function== "Combine Items")
                {
                    string[] item = items[1].Split(":");
                    int oldItemsIndex = inventary.IndexOf(item[0]);
                    if (oldItemsIndex>=0)
                    {
                        if (oldItemsIndex>=inventary.Count)
                        {
                            inventary.Add(item[1]);
                        }
                        else
                        {
                            inventary.Insert(oldItemsIndex + 1, item[1]);
                        }

                    }

                }
                else if (function == "Renew")
                {
                    string item = items[1];
                    if (inventary.Contains(item))
                    {
                        int indexOfElement = inventary.IndexOf(item);
                        inventary.RemoveAt(indexOfElement);
                        inventary.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", inventary));
        }
    }
}