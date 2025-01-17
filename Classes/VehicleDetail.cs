namespace CarMeneger
{
    class VehicleDetail
    {
        public int Id { get; private set; }
        public int TypeWorkId { get; private set; }
        public int CarId { get; private set; }
        public string Discription { get; private set; }
        public int MileageToInstallation { get; private set; }
        public int MileageLife { get; private set; }  // перенести в тип работ?
        public int ReplacementMileage { get; private set; }

        public VehicleDetail(int id, int typeWorkId, int carId, string discription, int mileageToInstallation, int mileageLife)
        {
            Id = id;
            TypeWorkId = typeWorkId;
            CarId = carId;
            Discription = discription;
            MileageToInstallation = mileageToInstallation;
            MileageLife = mileageLife;
            ReplacementMileage = mileageToInstallation + mileageLife;
        }

        public void ShowWork()
        {
            Console.WriteLine($"{Discription} - пробег на момент замены: {MileageToInstallation}, планируемая замена при {ReplacementMileage} км. пробега");
        }
    }
}
