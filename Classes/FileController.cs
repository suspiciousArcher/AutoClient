namespace CarMeneger
{
    class FileController
    {
        private static string _fileCarsPath = Path.Combine("..", "..", "..", "Data", "cars.json");
        private static string _fileWorksPath = Path.Combine("..", "..", "..", "Data", "works.json");

        public static string ReadFile(string name)
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

        public static void ShowDirectory()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}
