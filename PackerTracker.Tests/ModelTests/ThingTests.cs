using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]

  public class ThingTests : IDisposable

  {
    public void Dispose()
    {
      Thing.ClearAll();
    }

    [TestMethod]
    public void ThingConstructor_CreatesInstanceOfThing_Thing()
    {
      Thing newThing = new Thing("BackPack", 5, true, 10);
      Assert.AreEqual(typeof(Thing), newThing.GetType());
    }

    [TestMethod]
    public void ThingConstructor_CreatesInstanceOfThingWithName_Thing()
    {
      Thing newThing = new Thing("Backpack", 5, true, 10);
      Assert.AreEqual(newThing.Name, "Backpack");
    }

    [TestMethod]
    public void ThingList_IncreasesIdOfThingWhenAddedToList_Thing()
    {
      Thing newThing = new Thing("Backpack", 5, true, 10);
      Assert.AreEqual(newThing.Id, 1);
    }
  }
}
