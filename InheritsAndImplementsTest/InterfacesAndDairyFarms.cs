using Implements;
using NUnit.Framework;

namespace InheritsAndImplements.Test
{
    [TestFixture]
    public class InterfacesAndDairyFarms
    {
        [Test]
        public void A_cow_farm_gives_us_cows_milk()
        {
            var cow = new Cow();
            var farm = new DairyFarm(cow); //The farm is 'given' the animal to be milked

            // TODO Please remove the incorrect assertion.
            Assert.That(farm.GetProduce(), Is.EqualTo("Cow's milk"));
            Assert.That(farm.GetProduce(), Is.EqualTo("Pig's milk"));
        }

        [Test, Ignore("")]
        public void The_same_farm_can_give_us_goats_milk_too()
        {
            var goat = new Goat();
            var farm = new DairyFarm(goat); //This is the essence of 'dependency injection'

            // TODO Please remove the incorrect assertion.
            Assert.That(farm.GetProduce(), Is.EqualTo("Cow's milk"));
            Assert.That(farm.GetProduce(), Is.EqualTo("Goat's milk"));
        }

        [Test, Ignore("")]
        public void This_is_because_cows_and_goats_are_milkable()
        {
            IMilkable cow = new Cow(); //Cow IMPLEMENTS the IMilkable contract
            IMilkable goat = new Goat(); //Goat IMPLEMENTS the IMilkable contract

            // TODO Please remove the incorrect assertion.
            Assert.Throws<ThisIsntMilkableException>(() => cow.Milk());
            Assert.DoesNotThrow(() => goat.Milk());
        }

        [Test, Ignore("")]
        public void But_milking_animals_for_tests_is_wasteful()
        {
            var mockAnimal = new FakeAnimal();
            var farm = new DairyFarm(mockAnimal); //We can test the farm machinery on a MOCK animal.

            // TODO Please remove the incorrect assertion.
            Assert.That(farm.GetProduce(), Is.EqualTo("Pretend milk"));
            Assert.That(farm.GetProduce(), Is.EqualTo("Real milk"));
        }

        [Test, Ignore("")]
        public void As_long_as_this_mock_animal_is_also_milkable()
        {
            IMilkable mockAnimal = new FakeAnimal();

            // TODO Please remove the incorrect assertion.
            Assert.DoesNotThrow(() => mockAnimal.Milk());
            Assert.Throws<ThisIsntMilkableException>(() => mockAnimal.Milk());
        }
    }

    // The mock animal belongs to the tests, not to the production farm
    public class FakeAnimal : IMilkable
    {
        public string Milk()
        {
            return "Pretend milk";
        }
    }
}