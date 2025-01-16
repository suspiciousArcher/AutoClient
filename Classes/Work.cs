namespace CarMeneger
{
    class Work
    {
        public int CarId { get; private set; }
        public int Id { get; private set; }
        public string Discription { get; private set; }
        public int MileageToInstallation { get; private set; }
        public int MileageLife { get; private set; }
        public int ReplacementMileage { get; private set; }

        public Work(int carId, int id, string discription, int mileageToInstallation, int mileageLife)
        {
            CarId = carId;
            Id = id;
            Discription = discription;
            MileageToInstallation = mileageToInstallation;
            MileageLife = mileageLife;
            ReplacementMileage = mileageToInstallation + mileageLife;
        }

        public void ShowWorks()
        {
            Console.WriteLine($"{Discription} - пробег на момент замены: {MileageToInstallation}, планируемая замена при {ReplacementMileage} км. пробега");
        }
    }
}
