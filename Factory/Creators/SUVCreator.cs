public class SUVCreator : CarCreator
{
    public override ICar FactoryMethod()
    {
        return new SUV();
    }
}
