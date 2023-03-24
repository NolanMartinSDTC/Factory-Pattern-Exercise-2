namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use: a List, SQL, or Mongo?");
            var userBase = Console.ReadLine();
            IDataAccess viewData = DataAccessFactory.GetDataAccessType(userBase);
            viewData.LoadData();
            viewData.SaveData();

        }
    }
}
