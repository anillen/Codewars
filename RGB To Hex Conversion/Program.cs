public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {    
    return GetHex(r)+GetHex(g)+GetHex(b);
  }
  
  public static string GetHex(int number)
  {
    if(number < 0)
      number = 0;

    if(number > 255)
      number = 255;
    
    return number.ToString("X2").ToUpper();
  }
}