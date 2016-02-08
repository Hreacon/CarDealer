using System.IO;
using Microsoft.AspNet.Builder;
using Nancy.Owin;
using Nancy;

namespace CarsName
{
  public class Startup
  {
    public void Configure(IApplicationBuilder app)
    {
      app.UseOwin(x => x.UseNancy());
    }
  }
  public class CustomRootPathProvider : IRootPathProvider
  {
    public string GetRootPath()
    {
      return Directory.GetCurrentDirectory();
    }
  }

  public static class ListExtensions
  {
    public static void OutputAll(this IEnumerable<Car> carList)
    {
      foreach( var car in carList) {
        Console.WriteLine(car.getCar());
      }
    }
  }
}
