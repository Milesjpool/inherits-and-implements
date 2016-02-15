using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace InheritsAndImplements.Test
{
    [TestFixture]
    public class InheritanceAndFarms
    {
        [Test]
        public void WeCanCreateMultipleFarms()
        {
            var sunnydaleFarm = new Farm(); 
            var willowFarm = new Farm();

            // TODO Please remove the incorrect assertion.
            Assert.That(sunnydaleFarm, Is.EqualTo(willowFarm));
            Assert.That(sunnydaleFarm, Is.Not.EqualTo(willowFarm));
        }

        [Test, Ignore("")]
        public void OrWeCanHaveMoreSpecificFarms()
        {
            var hilltopFarm = new WindFarm(); // 'WindFarm' INHERITS from 'Farm'
            var manorFarm = new AnimalFarm(); // 'AnimalFarm' INHERITS from 'Farm'

            // TODO Please remove the incorrect assertion.
            Assert.That(hilltopFarm.GetType(), Is.EqualTo(manorFarm.GetType()));
            Assert.That(hilltopFarm.GetType(), Is.Not.EqualTo(manorFarm.GetType()));
        }

        [Test, Ignore("")]
        public void ButTheyAreStillFarms()
        {
            var windFarm = new WindFarm(); // 'WindFarm' INHERITS from 'Farm'

            // TODO Please remove the incorrect assertion.
            Assert.That(windFarm, Is.AssignableTo<Farm>());
            Assert.That(windFarm, Is.Not.AssignableTo<Farm>());
        }

        [Test, Ignore("")]
        public void SoTheyMayShareSomeBehavour()
        {
            var animalFarm = new AnimalFarm();
            // The default 'Farm' location is outdoors.
            Assert.That(animalFarm.GetLocation(), Is.EqualTo("outdoors"));

            var windFarm = new WindFarm();

            // TODO Please remove the incorrect assertion.
            Assert.That(windFarm.GetLocation(), Is.EqualTo("indoors"));
            Assert.That(windFarm.GetLocation(), Is.EqualTo("outdoors"));

        }

        [Test, Ignore("")]
        public void ButTheyMayAlsoHaveVeryDifferentBehavour()
        {
            var sunnydaleFarm = new Farm();
            var manorFarm = new AnimalFarm();
            var windFarm = new WindFarm();

            // You can feed animals on these two farms
            Assert.That(() => FeedTheAnimalsAt(sunnydaleFarm), Throws.Nothing);
            Assert.That(() => FeedTheAnimalsAt(manorFarm), Throws.Nothing);

            // TODO Please remove the incorrect assertion.
            Assert.That(() => FeedTheAnimalsAt(windFarm), Throws.Nothing);
            Assert.That(() => FeedTheAnimalsAt(windFarm), Throws.InstanceOf<FarmContainsNoAnimalsException>());
        }

        // Note, this method can take *any* type (BASE CLASS or INHERITOR) of 'Farm', 
        // as 'FeedAnimals()' is defined as 'virtual' (i.e. overrideable) 'Farm' behaviour.  
        private void FeedTheAnimalsAt(Farm farm)
        {
            farm.FeedAnimals();
        }

        [Test, Ignore("")]
        public void ThisAllowsUsToDoThingsLikeThis()
        {
            var farmCatalogue2016 = new List<Farm>
            {
                new Farm(),
                new AnimalFarm(),
                new WindFarm(),
                new AnimalFarm(),
                new AnimalFarm(),
                new WindFarm(),
                new Farm(),
                new WindFarm(),
                new AnimalFarm()
            };

            // TODO Please remove the incorrect assertion.
            Assert.That(farmCatalogue2016.Count(farm => farm is AnimalFarm), Is.EqualTo(4));
            Assert.That(farmCatalogue2016.Count(farm => farm is AnimalFarm), Is.EqualTo(9));
        }
    }
}
