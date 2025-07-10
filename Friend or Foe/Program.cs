using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
      return names.Where(x=>x.Length == 4);
  }
}