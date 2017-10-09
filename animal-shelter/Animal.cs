using System;
using System.Collections.Generic;

public class Animal
{
  public int Age;
  public string Species;
}

class Program
{
  public static void Main()
  {
    Animal DogOne = new Animal();
    DogOne.Age = 3;
    DogOne.Species = "Labrador";

    Animal DogTwo = new Animal();
    DogTwo.Age = 4;
    DogTwo.Species = "Poodle";

    Animal DogThree = new Animal();
    DogThree.Age = 1;
    DogThree.Species = "American Bulldog";

    List<Animal> Animals = new List<Animal>() {DogOne, DogTwo, DogThree};
    foreach(Animal name in Animals)
    {
      Console.WriteLine("Species:"+name.Species);
      Console.WriteLine("Age:"+name.Age);
    }
    Console.WriteLine("Enter the maximum age you desire.");
    string stringAge = Console.ReadLine();
    int userAge = int.Parse(stringAge);
    foreach (Animal name in Animals)
    {
      if (name.Age <= userAge)
      {
        Console.WriteLine("Species:"+name.Species);
        Console.WriteLine("Age:"+name.Age);
      }
    }
  }

}
