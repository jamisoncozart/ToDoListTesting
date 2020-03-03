using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item(null);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      
      //act
      string result = newItem.Description;
      
      //assert
      Assert.AreEqual(description, result);
    }
  }
}