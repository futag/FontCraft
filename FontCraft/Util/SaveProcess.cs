using System.IO;
using System.IO.Compression;
using System.Text.Json;
using FontCraft.Util.Files;
using FontCraft.Util.CreateJson;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace FontCraft.Util
{
  public class SaveProcess
  {
    ClsEncryptDecryptFiles decryptFiles = new ClsEncryptDecryptFiles("fontcraftfile");
    // public string savePath = "";

    public bool Save(MainFile main, string path = "", string fontPath = "")
    {
      string locate = "";
      if (path == "")
      {
        SaveFileDialog save = new SaveFileDialog();
        save.Title = "Save as...";
        save.Filter = "FontCraft Packs|*.fcps";

        int count = 1;
        string nameFile = String.Format("Font Pack {0}.fcps", count);

        while (File.Exists(save.FileName))
          nameFile = String.Format("Font Pack {0}.fcps", count++);

        save.FileName = nameFile;

        if (save.ShowDialog() == DialogResult.OK)
          locate = save.FileName;
      }
      else
        locate = path;

      if (locate == "")
        return false;

      if (!Directory.Exists(Path.Combine(Config.pathTemp, "file"))) 
        Directory.CreateDirectory(Path.Combine(Config.pathTemp, "file"));

      string json = JsonSerializer.Serialize(main);
      File.WriteAllText(Path.Combine(Config.pathTemp, @"file\config.json"), json);
      if (fontPath != "")
        File.Copy(fontPath, Path.Combine(Config.pathTemp, @"file\font.ttf"));

      ZipFile.CreateFromDirectory(Path.Combine(Config.pathTemp, "file"), Path.Combine(Config.pathTemp, "file.zip"));
      File.Copy(Path.Combine(Config.pathTemp, "file.zip"), locate);
      //File.WriteAllBytes(locate, decryptFiles.Encryption(Path.Combine(Config.pathTemp, "file.zip")));

      Directory.Delete(Path.Combine(Config.pathTemp, "file"), true);
      File.Delete(Path.Combine(Config.pathTemp, "file.zip"));

      Config.filesPath = locate;

      return true;
    }

    public void ExportFileJava(Bitmap icon, string name, int ver, string path)
    {
      string namePackPath = Path.Combine(Config.pathTemp, name);

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

      CreateZip(String.Format("{0}.zip", name), path, namePackPath);
    }

    public void ExportFileHDJava(Bitmap icon, string name, int ver, string path)
    {
      string namePackPath = Path.Combine(Config.pathTemp, name);

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

      CreateZip(String.Format("{0}.zip", name), path, namePackPath);
    }

    public void ExportFileBedrock(Bitmap icon, string name, int ver, string path, bool ext)
    {
      string namePackPath = Path.Combine(Config.pathTemp, name);

      Directory.CreateDirectory(namePackPath);

      var header = new CreateJson.headerBR
      {
        uuid = Guid.NewGuid().ToString(),
        name = name,
        description = "Genereted automatically by FontCraft",
        version = new int[3] { 1, 0, 0 },
        min_engine_version = (ver == 2) ? new int[3] { 1, 16, 0 } : new int[3] { 1, 2, 0 }
      };

      var modules = new CreateJson.modulesBR
      {
        uuid = Guid.NewGuid().ToString(),
        type = "resources",
        version = new int[3] { 0, 0, 1 }
      };

      var manifest = new CreateJson.PackBedrockEdition
      {
        format_version = ver,
        header = header,
        modules = new CreateJson.modulesBR[1] { modules }
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

      CreateZip(String.Format("{0}.{1}", name, ext ? "mcpack" : "zip"), path, namePackPath);
    }

    public void ExportFilePE(Bitmap icon, string name, int ver, string path, bool ext)
    {
      string namePackPath = Path.Combine(Config.pathTemp, name);

      Directory.CreateDirectory(namePackPath);

      var header = new CreateJson.headerBR
      {
        uuid = Guid.NewGuid().ToString(),
        name = name,
        description = "Genereted automatically by FontCraft",
        version = new int[3] { 1, 0, 0 }
      };

      var modules = new CreateJson.modulesBR
      {
        uuid = Guid.NewGuid().ToString(),
        type = "resources",
        version = new int[3] { 1, 0, 0 }
      };

      var manifest = new CreateJson.PackBedrockEdition
      {
        format_version = ver,
        header = header,
        modules = new CreateJson.modulesBR[1] { modules }
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

      CreateZip(String.Format("{0}.{1}", name, ext ? "mcpack" : "zip"), path, namePackPath);
    }

    public void ExportFilePEA(Bitmap icon, string name, int ver, string path)
    {
      string namePackPath = Path.Combine(Config.pathTemp, name);

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

      string fontImgPath = Path.Combine(namePackPath, @"assets\images\font");
      Directory.CreateDirectory(fontImgPath);

      Config.surface.Save(Path.Combine(fontImgPath, "default8.png"), ImageFormat.Png);

      CreateZip(String.Format("{0}.zip", name), path, namePackPath);
    }

    public void ExportFilePNG(string name, string path)
    {
      string finalPath = Path.Combine(path, name + ".png");

      if (File.Exists(finalPath))
      {
        int count = 1;
        string newname = String.Format("{0} {1}", name, count);

        while (File.Exists(Path.Combine(path, newname + ".png")))
          newname = String.Format("{0} {1}", name, count++);

        name = newname;
      }

      Config.surface.Save(Path.Combine(path, string.Format("{0}.png", name)), ImageFormat.Png);

      MessageBox.Show(String.Format("{0}.png Exported in {1}!", name, path), "Font Exported!",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void CreateZip(string name, string path, string from)
    {
      string finalPath = Path.Combine(path, name);

      if (File.Exists(finalPath))
      {
        int count = 1;
        string newname = String.Format("{0} {1}.{2}",name.Split(".")[0], count, name.Split(".")[1]);

        while (File.Exists(Path.Combine(path, newname)))
          newname = String.Format("{0} {1}.{2}", name.Split(".")[0], count++, name.Split(".")[1]);

        name = newname;
      }

      ZipFile.CreateFromDirectory(from, Path.Combine(path, name));
      Directory.Delete(from, true);

      MessageBox.Show(String.Format("{0} Exported in {1}!", name, path), "Font Exported!",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
