namespace InheritsAndImplements
{
    public class WindFarm : Farm
    {
        public override void FeedAnimals()
        {
            throw new FarmContainsNoAnimalsException();
        }
    }
}