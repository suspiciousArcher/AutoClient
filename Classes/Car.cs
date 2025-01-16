namespace CarMeneger
{
    class Car
    {
        public int Id { get; private set; }
        public string Stamp { get; private set; }
        public string Model { get; private set; }
        public int ReleaseDate { get; private set; }
        public int Mileage { get; private set; }
        public List<Work> details = new List<Work>();

        public Car(int id, string stamp, string model, int releaseDate, int mileage)
        {
            Id = id;
            Stamp = stamp;
            Model = model;
            ReleaseDate = releaseDate;
            Mileage = mileage;
        }

        public void ShowCar()
        {
            Console.WriteLine($"Автомобиль: {Stamp} {Model} {ReleaseDate} года выпуска.");
        }
    }
}
