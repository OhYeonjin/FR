using System;

class Person {
  public string Name;
  public string Brithday;
  

  public void Eat(){
    Console.WriteLine(Name + "(이)가 식사를 합니다.");
  }
  
}

class Program {
  public static void Main (string[] args) {

    Person p1 = new Person();

    p1.Name = "서준";

    p1.Eat();
    
  }
}