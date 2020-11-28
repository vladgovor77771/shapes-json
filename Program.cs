using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    List<Shape> shapes = new List<Shape>();

    bool exitAndSave = false;

    Console.WriteLine("1 - create circle\n2 - create triangle\n3 - create rectangle\n4 - create n-angle\n5 - save and exit\n");

    while (!exitAndSave)
    {
      Console.Write(">> ");
      var command = Console.ReadLine();

      if (command == "1") shapes.Add(CreateCircle());
      else if (command == "2") shapes.Add(CreateTriangle());
      else if (command == "3") shapes.Add(CreateRectangle());
      else if (command == "4") shapes.Add(CreateNAngle());
      else if (command == "5") exitAndSave = true;
      else Console.WriteLine("Incorrect command!");
    }

    string json = JsonConvert.SerializeObject(shapes, Formatting.Indented);
    File.WriteAllText("shapes.json", json);
  }

  static Circle CreateCircle()
  {
    while (true)
    {
      try
      {
        Console.Write("Enter radius: ");
        var rad = double.Parse(Console.ReadLine());
        return new Circle(rad);
      }
      catch (Exception)
      {
        Console.WriteLine("Incorrect input!");
      }
    }
  }

  static Triangle CreateTriangle()
  {
    while (true)
    {
      try
      {
        Console.Write("Enter side: ");
        var side = double.Parse(Console.ReadLine());
        return new Triangle(side);
      }
      catch (Exception)
      {
        Console.WriteLine("Incorrect input!");
      }
    }
  }

  static Rectangle CreateRectangle()
  {
    while (true)
    {
      try
      {
        Console.Write("Enter length: ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        var b = double.Parse(Console.ReadLine());
        return new Rectangle(a, b);
      }
      catch (Exception)
      {
        Console.WriteLine("Incorrect input!");
      }
    }
  }

  static NAngle CreateNAngle()
  {
    while (true)
    {
      try
      {
        Console.Write("Enter side: ");
        var side = double.Parse(Console.ReadLine());
        Console.Write("Enter sides count: ");
        var count = int.Parse(Console.ReadLine());
        return new NAngle(side, count);
      }
      catch (Exception)
      {
        Console.WriteLine("Incorrect input!");
      }
    }
  }
}

