namespace CarMeneger
{
    class FileController
    {
        static private string _fileCarsPath = Path.Combine("..", "..", "..", "Data", "cars.json");
        static private string _fileWorksPath = Path.Combine("..", "..", "..", "Data", "works.json");

        static public string ReadFile(string name)
        {
            string json;
            switch (name)
            {
                case "car":
                    json = File.ReadAllText(_fileCarsPath);
                    break;
                case "work":
                    json = File.ReadAllText(_fileWorksPath);
                    break;
                default:
                    throw new ArgumentException("Invalid name provided");
            }
            return json;
        }

        static public void ShowDirectory()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}
