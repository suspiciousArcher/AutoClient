using System.Text.Json;

namespace CarMeneger
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataCar = FileController.ReadFile("car");
            var cars = JsonSerializer.Deserialize<List<Car>>(dataCar);
            List<int> carId = new List<int>();

            string dataWorks = FileController.ReadFile("work");
            var works = JsonSerializer.Deserialize<List<Work>>(dataWorks);

            Console.ForegroundColor = ConsoleColor.Green;

            bool resultComparison;
            int optionsId;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Доступные опции:");
                Console.WriteLine("\t1 - Просмотр информации об автомобилях");
                Console.Write("\n\nВыбор операции: ");
             
                string option = Console.ReadLine();
                if(int.TryParse(option, out int numberOption))
                {
                    switch(numberOption)
                    {
                        case 1:
                            Console.Clear();
                            
                            Console.WriteLine("Список зарегестрированных автомобилей:");
                            foreach(var car in cars)
                            {
                                Console.Write("\t");
                                car.ShowCar();
                                carId.Add(car.Id);
                            }

                            Console.Write("\n\nВыберите автомобиль: ");
                            string auto = Console.ReadLine();

                            if(int.TryParse(auto, out int numberAuto))
                            {
                                resultComparison = false;
                                for (int i = 0; i < carId.Count; i++)
                                {
                                    if (carId[i] == numberAuto)
                                    {
                                        resultComparison = true;
                                        break;
                                    }
                                }

                                if (resultComparison)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Список работ:");
                                    foreach(var work in works)
                                    {
                                        if(work.CarId == numberAuto)
                                        {
                                            Console.Write("\t");
                                            work.ShowWorks();
                                        }
                                        Console.ReadLine();
                                    }
                                }
                            }



                           
                            break;
                        default:
                            Console.WriteLine("Не верная опцция");
                            break;
                    }
                }
            }
        }
    }
}
