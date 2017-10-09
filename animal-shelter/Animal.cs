using System;
using System.Collections.Generic;

public class Animal
{
  public string Name;
  public int Age;
  public string Species;
  public bool Adopted;

  public void IsACat(string stringSpecies)
  {
    if(stringSpecies == "Cat")
    {
      Console.WriteLine("Animal is a Cat");
    } else {
      Console.WriteLine("Animal is not a cat");
    }
  }

  public void IsAdopted(string stringName, bool boolAdopted)
  {
    if(boolAdopted == false) {
      Console.WriteLine(stringName+" is available.");
    }
  }
}


class Program
{
  public static void Main()
  {
    Animal Labrador = new Animal();
    Labrador.Name = "Labrador";
    Labrador.Age = 3;
    Labrador.Species = "Dog";
    Labrador.Adopted = false;


    Animal Poodle = new Animal();
    Poodle.Name = "Poodle";
    Poodle.Age = 4;
    Poodle.Species = "Dog";
    Poodle.Adopted = true;


    Animal Bulldog = new Animal();
    Bulldog.Name = "Bulldog";
    Bulldog.Age = 1;
    Bulldog.Species = "Dog";
    Bulldog.Adopted = false;


    List<Animal> Animals = new List<Animal>() {Labrador, Poodle, Bulldog};
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
        string stringSpecies = name.Species;

        name.IsACat(stringSpecies);
      }
    }
    Console.WriteLine("Animals Available:");
    foreach (Animal name in Animals)
    {
      string stringName = name.Name;
      bool boolAdopted = name.Adopted;
      name.IsAdopted(stringName, boolAdopted);
    }
    Console.WriteLine("Which Animal would you like to Adopt?");
    string animalToAdopt = Console.ReadLine();
    foreach (Animal name in Animals)
    {
      if(name.Name == animalToAdopt && name.Adopted == false)
      {
      name.Adopted = true;
      Console.WriteLine("Congrats! You have adopted " +name.Name);
      bool adoptionStatus = name.Adopted;
      Console.WriteLine("Adopted? "+adoptionStatus);
      } else if (name.Name == animalToAdopt && name.Adopted == true)
      Console.WriteLine("Sorry, "+name.Name+" is not available.");
    }
  }

}
