using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCity_ReturnsCity_String()
    {
      //Arrange
      string city = "Walk the dog.";

      //Act
      Place newPlace = new Place(city);
      string result = newPlace.CityName;

      //Assert
      Assert.AreEqual(city, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfPlaces_PlacesList()
    {
      //Arrange
      string city1 = "Walk the dog";
      string city2 = "Feed the cat";
      Place Place1 = new Place(city1);
      Place Place2 = new Place(city2);
      List<Place> places = new List<Place>{ Place1, Place2 };

      //Act
      List<Place> result = Place.GetAll();
      //Assert
      CollectionAssert.AreEqual(places, result);
    }

    [TestMethod]
    public void ClearAll_ReturnsEmptyListOfPlaces_PlacesList()
    {
      //Arrange
      string city1 = "Walk the dog";
      string city2 = "Feed the cat";
      Place Place1 = new Place(city1);
      Place Place2 = new Place(city2);
      List<Place> emptyPlaces = new List<Place>{};

      //Act
      Place.ClearAll();

      //Assert
      CollectionAssert.AreEqual(emptyPlaces, Place.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      //Arrange
      string city1 = "Walk the dog";
      string city2 = "Feed the cat";
      Place Place1 = new Place(city1);
      Place Place2 = new Place(city2);

      //Act
      Place result = Place.Find(2);

      //Assert
      Assert.AreEqual(Place2, result);
    }
  }
}