using FontCraft.Util.CreateJson;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace FontCraft.Util
{
  public class InstallProcess
  {
    string RPJavapath = Path.Combine(Config.javaPath, "resourcepacks");

    public void ExportToJava(Bitmap icon, string name, int ver)
    {
      string namePackPath = Path.Combine(RPJavapath, name);

      Directory.CreateDirectory(namePackPath);
      var pack = new CreateJson.PackJavaEdition
      {
        description = "Genereted automatically by FontCraft",
        pack_format = ver
      };

      File.WriteAllText(Path.Combine(namePackPath, "pack.mcmeta"), JsonSerializer.Serialize(new { pack }));

      float size = 128;
      float scale = Math.Min(size / icon.Width, size / icon.Height);

      var bmp = new Bitmap((int)size, (int)size);
      var graph = Graphics.FromImage(bmp);

      // uncomment for higher quality output
      graph.InterpolationMode = InterpolationMode.High;
      graph.CompositingQuality = CompositingQuality.HighQuality;
      graph.SmoothingMode = SmoothingMode.AntiAlias;

      var scaleWidth = (int)(icon.Width * scale);
      var scaleHeight = (int)(icon.Height * scale);

      //graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
      graph.DrawImage(icon, ((int)size - scaleWidth) / 2, ((int)size - scaleHeight) / 2, scaleWidth, scaleHeight);

      bmp.Save(Path.Combine(namePackPath, "pack.png"), ImageFormat.Png);

      string fontImgPath = Path.Combine(namePackPath, @"assets\minecraft\textures\font");
      Directory.CreateDirectory(fontImgPath);

      Config.surface.Save(Path.Combine(fontImgPath, "ascii.png"), ImageFormat.Png);

      MessageBox.Show(String.Format("{0} generated as Resourse Pack", name), "Font Exported!",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ExportToHDJava(Bitmap icon, string name, int ver)
    {
      string namePackPath = Path.Combine(RPJavapath, name);

      Directory.CreateDirectory(namePackPath);
      var pack = new CreateJson.PackJavaEdition
      {
        description = "Genereted automatically by FontCraft",
        pack_format = ver
      };

      File.WriteAllText(Path.Combine(namePackPath, "pack.mcmeta"), JsonSerializer.Serialize(new { pack }));

      float size = 128;
      float scale = Math.Min(size / icon.Width, size / icon.Height);

      var bmp = new Bitmap((int)size, (int)size);
      var graph = Graphics.FromImage(bmp);

      // uncomment for higher quality output
      graph.InterpolationMode = InterpolationMode.High;
      graph.CompositingQuality = CompositingQuality.HighQuality;
      graph.SmoothingMode = SmoothingMode.AntiAlias;

      var scaleWidth = (int)(icon.Width * scale);
      var scaleHeight = (int)(icon.Height * scale);

      //graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
      graph.DrawImage(icon, ((int)size - scaleWidth) / 2, ((int)size - scaleHeight) / 2, scaleWidth, scaleHeight);

      bmp.Save(Path.Combine(namePackPath, "pack.png"), ImageFormat.Png);

      string fontHDPath = Path.Combine(namePackPath, @"assets\minecraft\font");
      Directory.CreateDirectory(fontHDPath);

      var provider = new ProvidersHD
      {
        type = "ttf",
        file = "minecraft:font.ttf",
        shift = new float[2] { 0, 0.5F },
        size = 10.5f,
        oversample = 4.0f,
        skip = ""
      };

      List<ProvidersHD> providers = new List<ProvidersHD>();
      providers.Add(provider);

      File.WriteAllText(Path.Combine(fontHDPath, "default.json"),
        JsonSerializer.Serialize(new { providers }));

      File.Copy(Config.fontFile, Path.Combine(fontHDPath, "font.ttf"));

      MessageBox.Show(String.Format("{0} generated as Resourse Pack", name), "Font Exported!",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ExportToBedrock(Bitmap icon, string name, int ver, string path)
    {
      string namePackPath = Path.Combine(path, name);

      Directory.CreateDirectory(namePackPath);

      var header = new CreateJson.headerBR { 
        uuid = Guid.NewGuid().ToString(),
        name = name,
        description = "Genereted automatically by FontCraft",
        version = new int[3] {1, 0, 0},
        min_engine_version = (ver == 2) ? new int[3] { 1, 16, 0 } : new int[3] { 1, 2, 0 }
      };

      var modules = new CreateJson.modulesBR {
        uuid = Guid.NewGuid().ToString(),
        type = "resources",
        version = new int[3] {0, 0, 1}
      };

      var manifest = new CreateJson.PackBedrockEdition
      {
        format_version = ver,
        header = header,
        modules = new CreateJson.modulesBR[1] {modules}
      };

      File.WriteAllText(Path.Combine(namePackPath, "manifest.json"), JsonSerializer.Serialize(manifest));

      float size = 128;
      float scale = Math.Min(size / icon.Width, size / icon.Height);

      var bmp = new Bitmap((int)size, (int)size);
      var graph = Graphics.FromImage(bmp);

      // uncomment for higher quality output
      graph.InterpolationMode = InterpolationMode.High;
      graph.CompositingQuality = CompositingQuality.HighQuality;
      graph.SmoothingMode = SmoothingMode.AntiAlias;

      var scaleWidth = (int)(icon.Width * scale);
      var scaleHeight = (int)(icon.Height * scale);

      //graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
      graph.DrawImage(icon, ((int)size - scaleWidth) / 2, ((int)size - scaleHeight) / 2, scaleWidth, scaleHeight);

      bmp.Save(Path.Combine(namePackPath, "pack_icon.png"), ImageFormat.Png);

      string fontBRpath = Path.Combine(namePackPath, "font");
      Directory.CreateDirectory(fontBRpath);

      Config.surface.Save(Path.Combine(fontBRpath, "default8.png"), ImageFormat.Png);

      MessageBox.Show(String.Format("{0} generated as Resourse Pack", name), "Font Exported!",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ExportExistJava(string name)
    {
      string fontImgPath = Path.Combine(RPJavapath, name, @"assets\minecraft\textures\font");
      string fontHDPath = Path.Combine(RPJavapath, name, @"assets\minecraft\font");

      if (File.Exists(Path.Combine(fontImgPath, "ascii.png"))) 
        File.Delete(Path.Combine(fontImgPath, "ascii.png"));
      if (File.Exists(Path.Combine(fontHDPath, "font.ttf")))
        File.Delete(Path.Combine(fontHDPath, "font.ttf"));
      if (File.Exists(Path.Combine(fontImgPath, "default.json")))
        File.Delete(Path.Combine(fontImgPath, "default.json"));

      if (!Directory.Exists(fontImgPath)) Directory.CreateDirectory(fontImgPath);

      Config.surface.Save(Path.Combine(fontImgPath, "ascii.png"), ImageFormat.Png);

      MessageBox.Show(String.Format("{0} changed!", name), "Font Exported!",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ExportExistHDJava(string name)
    {
      string fontImgPath = Path.Combine(RPJavapath, name, @"assets\minecraft\textures\font");
      string fontHDPath = Path.Combine(RPJavapath, name, @"assets\minecraft\font");

      if (File.Exists(Path.Combine(fontImgPath, "ascii.png")))
        File.Delete(Path.Combine(fontImgPath, "ascii.png"));
      if (File.Exists(Path.Combine(fontHDPath, "font.ttf")))
        File.Delete(Path.Combine(fontHDPath, "font.ttf"));
      if (File.Exists(Path.Combine(fontImgPath, "default.json")))
        File.Delete(Path.Combine(fontImgPath, "default.json"));

      if (!Directory.Exists(fontHDPath)) Directory.CreateDirectory(fontHDPath);

      var provider = new ProvidersHD
      {
        type = "ttf",
        file = "minecraft:font.ttf",
        shift = new float[2] { 0, 0.5F },
        size = 10.5f,
        oversample = 4.0f,
        skip = ""
      };

      List<ProvidersHD> providers = new List<ProvidersHD>();
      providers.Add(provider);

      File.WriteAllText(Path.Combine(fontHDPath, "default.json"),
        JsonSerializer.Serialize(new { providers }));

      File.Copy(Config.fontFile, Path.Combine(fontHDPath, "font.ttf"));

      MessageBox.Show(String.Format("{0} Changed!", name), "Font Exported!",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ExportExistBedrock(string name, string path)
    {
      string fontBRpath = Path.Combine(path, name, "font");

      if (File.Exists(Path.Combine(fontBRpath, "deafault8.png")))
      File.Delete(Path.Combine(fontBRpath, "deafault8.png"));

      if (!Directory.Exists(fontBRpath)) Directory.CreateDirectory(fontBRpath);

      Config.surface.Save(Path.Combine(fontBRpath, "default8.png"), ImageFormat.Png);

      MessageBox.Show(String.Format("{0} Changed!", name), "Font Exported!",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
