using System;
using System.Collections.Generic;
using System.Text;

namespace FontCraft.Util.CreateJson
{
  public class PackJavaEdition
  {
    public string description { get; set; }
    public int pack_format { get; set; }
  }

  public class ProvidersHD
  {
    public string type { get; set; }
    public string file { get; set; }
    public float[] shift { get; set; }
    public float size { get; set; }
    public float oversample { get; set; }
    public string skip { get; set; }
  }

  public class FontHDJava
  {
    public List<ProvidersHD> providers { get; set; }
  }

  public class modulesBR
  {
    public string type { get; set; }
    public string uuid { get; set; }
    public int[] version { get; set; }
  }

  public class headerBR
  {
    public string description { get; set; }
    public string name { get; set; }
    public string uuid { get; set; }
    public int[] version { get; set; }
    public int[] min_engine_version { get; set; }
  }

  public class PackBedrockEdition
  {
    public int format_version { get; set; }
    public headerBR header { get; set; }
    public modulesBR[] modules { get; set; }
  }

  public class modulesPE
  {
    public string type { get; set; }
    public string uuid { get; set; }
    public string version { get; set; }
  }

  public class PackPocketEdition
  {
    public string description { get; set; }
    public string name { get; set; }
    public string pack_id { get; set; }
    public string packs_version { get; set; }
    public modulesPE[] modules { get; set; }
  }
}
