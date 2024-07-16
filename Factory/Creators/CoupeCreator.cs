public class CoupeCreator : CarCreator
{
    public override ICar FactoryMethod()
    {
        return new Coupe();
    }
}
