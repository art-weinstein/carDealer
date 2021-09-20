using System;

namespace Dealership.Models {

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

// public string MakeModel //public property
// {
//     get // a property accessor used to return the property value
//     {
//         return _makeModel; 
//     }
//     set // a property accessor used to assign a new value
//     {
//         _makeModel = value;
//     }
// }
  public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
    }
    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
    
    public static string MakeSound(string sound)
    {
        return "Our cars sound like " + sound;
    }
  }
}