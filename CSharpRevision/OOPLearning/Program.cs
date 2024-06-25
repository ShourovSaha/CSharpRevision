namespace OOPLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Salesman carSalesMan = new CarSalesman("S", "Saha");
            //carSalesMan.Sell();


            List<Salesman> salesmens = new List<Salesman>()
            {
                new RetailSalesman("R", "Roy"),
                new  CarSalesman("S", "Saha"),
            };

            foreach (var salesman in salesmens)
            {
                salesman.Sell();
            }

            List<ISelfDeveloping> selfDevelopers = new List<ISelfDeveloping>()
            {
                new WebDeveloper("C#"),
                new RetailSalesman("R", "Roy")
            };

            foreach (var selfDeveloper in selfDevelopers)
            {
                selfDeveloper.Develop();
            }
            

            //RetailSalesman penSalesMan = new RetailSalesman("R", "Roy");
            //penSalesMan.Sell();
            //penSalesMan.Develop();

            //WebDeveloper webDeveloper = new WebDeveloper("C#");
            //webDeveloper.Code("Js", "SQL");
            //webDeveloper.Develop();
        }
    }
}