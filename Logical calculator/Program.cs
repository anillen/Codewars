public class Kata
{
  public static bool LogicalCalc(bool[] array, string op)
  {    
    for(int i = 0; i+1 < array.Length; i++)
    {
      switch(op)
      {
          case "AND": 
          array[i+1]=(array[i]&&array[i+1]);
          break;
          case "OR": 
          array[i+1]=(array[i]||array[i+1]);
          break;
          case "XOR": 
          array[i+1]=(array[i]^array[i+1]);
          break;
      }
    }
    return array[^1];
  }
}