using System;
using System.Linq;

public class Kata
{

  public static string GoodVsEvil(string good, string evil)
  {
    int[] goodScores = [1,2,3,3,4,10];
    int[] evilScores = [1,2,2,2,3,5,10];

    var goodScore = good.Split(' ').Select((x,i)=>int.Parse(x) * goodScores[i]).Sum();
    var evilScore = evil.Split(' ').Select((x,i)=>int.Parse(x) * evilScores[i]).Sum();

    var result = goodScore - evilScore;

    if(result == 0)
      return "Battle Result: No victor on this battle field";
    if(result > 0)
      return "Battle Result: Good triumphs over Evil";
    else
      return "Battle Result: Evil eradicates all trace of Good";
  }
}