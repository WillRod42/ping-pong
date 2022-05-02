using System;

public class PingPong
{
  public static void Main()
  {
    Console.Write("Enter a number: ");
    int maxCount = int.Parse(Console.ReadLine());
    PingPongReplace(maxCount);
  }

  private static void PingPongReplace(int max)
  {
    for (int i = 1; i <= max; i++)
    {
      
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}