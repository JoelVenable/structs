namespace structs
{
  public class Animal
  {
    public string Name;
    public string Sound;

    //  Static field is the same variable for all instances!
    static int numOfAnimals = 0;



    public Animal()
    {
      Name = "No name";
      Sound = "No sound";
      numOfAnimals++;
    }
    public Animal(string name = "No Name")
    {
      Name = name;
      Sound = "No sound";
      numOfAnimals++;

    }
    public Animal(string name = "No Name", string sound = "No Sound")
    {
      Name = name;
      Sound = sound;
      numOfAnimals++;

    }

    public void MakeSound()
    {
      System.Console.WriteLine("{0} says {1}",
      Name, Sound);


    }

    public static int GetNumOfAnimals()
    {
      return numOfAnimals;
    }


  }
}