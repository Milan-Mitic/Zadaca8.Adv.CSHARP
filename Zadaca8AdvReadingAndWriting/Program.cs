namespace Zadaca8AdvReadingAndWriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();

            string filePath = "C:\\Users\\Milan\\source\\repos\\Zadaca8AdvReadingAndWriting\\example.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                while (true)
                {
                    Console.WriteLine("Enter text to search or press Enter to exit");
                    string searchText = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(searchText))
                    {
                        Console.WriteLine("Exiting the app");
                        break;
                    }

                    Console.WriteLine("Lines containing the search text:");

                    bool found = false;
                    foreach (string item in lines)
                    {
                        if (item.Contains(searchText))
                        {
                            Console.WriteLine(item);
                            found = true;
                        }
                    }
                    if (found == false)
                    {
                        Console.WriteLine("No matching lines found");
                    }
                }
            }
        }
    }
}