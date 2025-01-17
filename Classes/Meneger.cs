using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace CarMeneger
{
    class Meneger
    {
        private static int TryParseOptions(int lengthOptionsList)
        {
            string optionId = Console.ReadLine();
            if (int.TryParse(optionId, out int id) && id > 0 && id <= lengthOptionsList)
                return id;
            else
            {
                Console.WriteLine("Неверная команда. Для продолжения нажмите любую кнопку...");
                Console.ReadKey();
                return 0;
            }
        }


        public static int ChoiceOfOption(List<string> options)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Доступные опции:");
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] - {options[i]}");
                }

                Console.Write("\n\nВыбор операции: ");
                int optionId = TryParseOptions(options.Count);
                if (optionId > 0)
                    return optionId;
                else
                    continue;
            }
        }


        public static int ChoiceOfOption(List<Car> cars)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Список зарегестрированных автомобилей:");

                for (int i = 0; i < cars.Count; i++)
                {
                    Console.Write($"[{i + 1}] - ");
                    cars[i].ShowCar();
                }

                Console.Write("\n\nВыбор автомобиля: ");
                int optionId = TryParseOptions(cars.Count);
                if (optionId > 0)
                    return optionId;
                else
                    continue;
            }
        }


        //public static int ChoiceOfOption(List<Work> works)
        //{
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Проводимые работы:");

        //        for (int i = 0; i < works.Count; i++)
        //        {
        //            Console.Write($"[{i + 1}] - ");
        //            works[i].ShowWork();
        //        }

        //        Console.Write("\n\nВыбор автомобиля: ");
        //        int optionId = TryParseOptions(works.Count);
        //        if (optionId > 0)
        //            return optionId;
        //        else
        //            continue;
        //    }
        //}
    }
}
