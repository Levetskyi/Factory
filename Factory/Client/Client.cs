public class Client
{
    public void Main()
    {
        CreateObject(new SedanCreator());

        Console.WriteLine("");

        CreateObject(new SUVCreator());

        Console.WriteLine("");

        CreateObject(new CoupeCreator());
    }

    public void CreateObject(CarCreator carCreator)
    {
        carCreator.CreateCar();
    }
}
