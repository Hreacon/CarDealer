using System;
using System.Collections.Generic;

namespace Cars.Objects
{
  class CarList : List<Car>
  {
    // private List<Car> CarList
    //
    // public Cars(List<Car> newCars) {
    //   CarList = newCars;
    // }

    public List<Car> getCarsUnderPriceMiles(int price, int miles) {
      List<Car> searchCars = new List<Car>(){};
      foreach( Car car in this ) {
        if( car.getPrice() <= price && car.getMiles() <= miles) {
          searchCars.Add(car);
        }
      }
      return searchCars;
    }
  }
  public class Car
  {
    private int Id;
    private string Make;
    private string Model;
    private int Year;
    private int Miles;
    private int Price;
    private string Pic;
    private static List<Car> CarArray = new List<Car>() {};

    public Car (string newMake, string newModel, int newYear, int newMiles, int newPrice, string newPic)
    {
      Make = newMake;
      Model = newModel;
      Year = newYear;
      Miles = newMiles;
      Price = newPrice;
      Pic = newPic;
      Id = CarArray.Count;
    }

    public string getCar() {
      return Year + " " + Make +" " + Model;
    }

    public int getPrice() {
      return Price;
    }

    public int getMiles() {
      return Miles;
    }

    public int getId() {
      return Id;
    }

    public string getAllData() {
      return Year + " " + Make + " " + Model + " Odo:" + Miles + " $" + Price + " " + Pic;
    }

    public void Save() {
      CarArray.Add(this);
    }

    public static List<Car> GetAllCars() {
      return CarArray;
    }

    public static Car getCarById(int id) {
      return CarArray[id];
    }

    public static void buyCar(int id) {
      CarArray.Remove(Car.getCarById(id));
    }
  }



  // class  Program
  // {
  //
  //   static void Main()
  //   {
  //     Car bmw = new Car("BMW", "M3", 2003, 100000, 5000, "img/bmw.jpg");
  //     Car rx7 = new Car("Mazda", "RX-7", 1995, 70000, 16000, "img/rx7.jpg");
  //     Car miata = new Car("Mazda", "MX-5", 2007, 55000, 16000, "img/mx-5.jpg");
  //
  //     Cars carList = new Cars() {bmw, rx7, miata};
  //
  //     foreach (Car index in carList)
  //     {
  //       Console.WriteLine(index.getAllData());
  //     }
  //
  //     Console.WriteLine("Enter Max Price");
  //     string input = Console.ReadLine();
  //     int price = int.Parse(input);
  //
  //     Console.WriteLine("Enter Max miles");
  //     input = Console.ReadLine();
  //     int miles = int.Parse(input);
  //
  //     List<Car> searchCars = carList.getCarsUnderPriceMiles(price, miles);
  //     foreach( Car car in searchCars ) {
  //       Console.WriteLine(car.getCar());
  //     }
  //
  //
  //   }
  // }
}
