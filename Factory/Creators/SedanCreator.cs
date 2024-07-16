public class SedanCreator : CarCreator
{
    public override ICar FactoryMethod()
    {
        return new Sedan();
    }
}
