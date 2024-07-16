public abstract class CarCreator
{
    public abstract ICar FactoryMethod();

    public void CreateCar()
    {
        var car = FactoryMethod();

        car.ApplySpecification();
    }
}
