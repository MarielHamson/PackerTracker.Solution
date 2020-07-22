using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]

  public class ThingTests
  {

    [TestMethod]
    public void ThingConstructor_CreatesInstanceOfItem_Item()
    {
      Thing newThing = new Thing("BackPack", 5, true, 10);
      Assert.AreEqual(typeof(Thing), newThing.GetType());
    }

    [TestMethod]
    public void ThingConstructor_CreatesInstanceOfItemWithName_Item()
    {
      Thing newThing = new Thing("Backpack", 5, true, 10);
      Assert.AreEqual(newThing.Name, "incorrect name");
    }
  }
}
