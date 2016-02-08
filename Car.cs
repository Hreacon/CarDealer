using System;
using System.Collections.Generic;

class Car
{
  private string Make { get; set; }
  private string Model { get; set; }
  private int Year { get; set; }
  private int Miles { get; set; }
  public int Price { get; set; }

  public Car (string newMake, string newModel, int newYear, int newMiles, int newPrice)
  {
    Make = newMake;
    Model = newModel;
    Year = newYear;
    Miles = newMiles;
    Price = newPrice;
  }

  public string getCar() {
    return Year + " " + Make +" " + Model;
  }

  public int getPrice() {
    return Price;
  }
}

class Cars : List<Car>
{
  // private List<Car> CarList { get; set; }
  //
  // public Cars(List<Car> newCars) {
  //   CarList = newCars;
  // }

  public List<Car> getCarsUnderPrice(int price) {
    List<Car> searchCars = new List<Car>(){};
    foreach( Car car in this ) {
      if( car.Price <= price ) {
        searchCars.Add(car);
      }
    }
    return searchCars;
  }
}

class  Program
{

  static void Main()
  {
    Car bmw = new Car("BMW", "M3", 2003, 100000, 5000);
    Car rx7 = new Car("Mazda", "RX-7", 1995, 70000, 16000);
    Car miata = new Car("Mazda", "MX-5", 2007, 55000, 16000);

    Cars carList = new Cars() {bmw, rx7, miata};

    Console.WriteLine("Enter Max Price");
    string input = Console.ReadLine();
    int price = int.Parse(input);

    List<Car> searchCars = carList.getCarsUnderPrice(price);
    foreach( Car car in searchCars ) {
      Console.WriteLine(car.getCar());
    }
  }
}
