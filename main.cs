using System;

class Person 
{
  public string Name;
  
  public void Eat()
  {
    Console.WriteLine(Name + "(이)가 식사를 합니다.");
  }

  public void Run()
  {
    Console.WriteLine(Name + "(이)가 뜁니다.");
  }
  
}

class Program 
{
  public static void Main (string[] args) 
  {

    Person p1 = new Person();
    Person p2 = new Person();
    
    p1.Name = "서준";
    p2.Name = "다윤";
    
    p1.Eat();
    p1.Run();
    p2.Eat();
    p2.Run();
  }
}