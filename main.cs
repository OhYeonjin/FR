using System;

class Program {
  public static void Main (string[] args) {

    int i = 1;
    while (true)
    {
      Console.WriteLine(i++);
  
      if(i > 10)
        break;
    }
  }
}