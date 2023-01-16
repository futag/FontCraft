using System;
using System.Collections.Generic;

namespace FontCraft.Util.Files
{
  public class MainFile
  {
    public string font_name { get; set; }
    public int bold { get; set; }
    public int italic { get; set; }
    //public float hd_size { get; set; }
    public List<Chars> chars { get; set; }
  }

  public class Chars
  {
    public float x { get; set; }
    public float y { get; set; }
    public float size { get; set; }
  }

  public class CreateFile
  {
    public MainFile InitFile()
    {
      List<Chars> chars = new List<Chars>();
      for (int i = 0; i < 247; i++)
        chars.Add(new Chars { x = 0, y = 0, size = 20 });


      return new MainFile
      {
        font_name = "",
        bold = 0,
        italic = 0,
        chars = chars
      };
    }
  }
}
