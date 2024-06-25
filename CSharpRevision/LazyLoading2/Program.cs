namespace LazyLoading2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //PatientDetails patientDetails = new PatientDetails()
            //{
            //    Id = 1,
            //    FName = "AA",
            //    LName = "LL"
            //};

            var patientDetails = new Lazy<PatientDetails>(() => new PatientDetails() {
                Id = 1,
                FName = "AA",
                LName = "LL"
            });
            Console.WriteLine(patientDetails.Value.GetFullName());
            if (patientDetails.IsValueCreated) Console.WriteLine("Obj created");
            else Console.WriteLine("Obj not created");

            Console.ReadKey();
        }
    }
}