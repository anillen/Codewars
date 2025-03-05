class MorseCodeDecoder
{
	public static string Decode(string morseCode)
	{
    if(string.IsNullOrEmpty(morseCode))
      return morseCode;

    morseCode = morseCode.Trim(' ');
    
    string[] codes = morseCode.Split(' ');
    string result = "";
  
    foreach(var code in codes)
    {
      if(string.IsNullOrEmpty(code) && result[^1] != ' ')
      {
          result+=" ";
      }
      result+=MorseCode.Get(code);
    }
		return result;
	}
}
