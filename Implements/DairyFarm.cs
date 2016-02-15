namespace Implements
{
    public class DairyFarm
    {
        private readonly IMilkable _animal;

        public DairyFarm(IMilkable animal)
        {
            _animal = animal;
        }

        public string GetProduce()
        {
            return _animal.Milk();
        }
    }
}