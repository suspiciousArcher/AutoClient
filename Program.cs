using System.Text.Json;

namespace CarMeneger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string> {
                "Просмотр информации об автомобилях"
            };

            string dataCar = FileController.ReadFile("car");
            var cars = JsonSerializer.Deserialize<List<Car>>(dataCar);
            List<int> carId = new List<int>();

            string dataWorks = FileController.ReadFile("work");
            var works = JsonSerializer.Deserialize<List<Work>>(dataWorks);

            Console.ForegroundColor = ConsoleColor.Green;

            int optionsId;

            while(true)
            {
                //Console.Clear();
               
                optionsId = Meneger.ChoiceOfOption(options);

                switch(optionsId)
                {
                    case 1:
                        optionsId = Meneger.ChoiceOfOption(cars);
                        break;
                      
                }
            }
        }
    }
}
