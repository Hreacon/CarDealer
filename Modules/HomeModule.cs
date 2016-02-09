using Nancy;
using Cars.Objects;
using System.Collections.Generic;
using System;

namespace CarDealer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // Car bmw = new Car("BMW", "M3", 2003, 100000, 5000, "img/bmw.jpg");
      // bmw.Save(bmw);
      // bmw.Save(new Car("Porshe", "M3", 2003, 100000, 5000, "img/bmw.jpg"));

      Get["/"] = _ => {
        List<Car> listOfCars = Car.GetAllCars();
        // Console.WriteLine(listOfCars[1].getCar());
        return View["list_all_cars.cshtml", listOfCars];
      };
      Get["/car/{id}"] = parameters => {
        return View["car.cshtml", Car.getCarById(parameters.id)];
      };
      Get["/car/{id}/buy"] = parameters => {
        Car.buyCar(parameters.id);
        return View["list_all_cars.cshtml", Car.GetAllCars()];
      };
      Post["/addCar"] = _ => {
        string year = Request.Form["year"];
        string model = Request.Form["model"];
        string make = Request.Form["make"];
        string miles = Request.Form["miles"];
        int milesInt = 0;
        int.TryParse(miles, out milesInt);
        string price = Request.Form["price"];
        int priceInt = 0;
        int.TryParse(price, out priceInt);
        int yearInt = 0;
        int.TryParse(year, out yearInt);
        string pic = Request.Form["pic"];
        Car newCar = new Car(model, make, yearInt, milesInt, priceInt, pic);
        newCar.Save();
        return View["list_all_cars.cshtml", Car.GetAllCars()];
      };


    }
  }
}
