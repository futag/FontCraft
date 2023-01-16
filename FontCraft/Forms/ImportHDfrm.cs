using FontCraft.Util;
using FontCraft.Util.CreateJson;
using FontCraft.Util.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace FontCraft.Forms
{
  public partial class ImportHDfrm : Form
  {
    string RPJavapath = Path.Combine(Config.javaPath, "resourcepacks");
    public MainFile main;
    public string font;

    public ImportHDfrm()
    {
      InitializeComponent();
    }

    private void ImportHDfrm_Load(object sender, EventArgs e)
    {
      foreach (string texture in Directory.GetDirectories(RPJavapath))
      {
        bool isTTF = false;
        string locationFont = Path.Combine(texture, @"assets\minecraft\font");

        if (Directory.Exists(locationFont))
        {
          foreach (string font in Directory.GetFiles(locationFont))
          {
            if (Path.GetExtension(font).ToLower() == ".ttf")
              isTTF = true;
          }
        }

        if (isTTF)
          listFont.Items.Add(texture.Split("\\").Last());
      }

      importBtn.Enabled = listFont.SelectedIndex < 0;
    }

    private void openBtn_Click(object sender, EventArgs e)
    {
      OpenFileDialog open = new OpenFileDialog();

      open.Title = "Import Texture Pack...";
      open.Filter = "Zip file|*.zip";

      if (open.ShowDialog() == DialogResult.OK)
      {
        string tempfolder = Path.Combine(Config.pathTemp, Path.GetFileNameWithoutExtension(open.FileName));
        ZipFile.ExtractToDirectory(open.FileName, tempfolder);

        bool isTTF = false;
        string locationFont = Path.Combine(tempfolder, @"assets\minecraft\font");

        if (Directory.Exists(locationFont))
        {
          foreach (string font in Directory.GetFiles(locationFont))
          {
            if (Path.GetExtension(font).ToLower() == ".ttf")
              isTTF = true;
          }
        }

        bool result = false;

        if (isTTF)
          result = import(tempfolder);
        else
          MessageBox.Show("Font not found!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        Directory.Delete(tempfolder);

        if (isTTF && result)
          DialogResult = DialogResult.OK;
      }
    }

    private void importBtn_Click(object sender, EventArgs e)
    {
      bool result = import(Path.Combine(RPJavapath, listFont.SelectedItem.ToString()));
      if (result) DialogResult = DialogResult.OK;
    }

    private bool import(string path)
    {
      try
      {
        string fontDir = Path.Combine(Util.Config.path, "font");
        string locationFont = Path.Combine(path, @"assets\minecraft\font");
        List<String> fonts = new List<string>();

        foreach (string font in Directory.GetFiles(locationFont))
        {
          if (Path.GetExtension(font).ToLower() == ".ttf")
            fonts.Add(font);
        }

        int count = 0;
        string nameFont = String.Format("font{0}", count.ToString("000"));

        while (File.Exists(Path.Combine(fontDir, nameFont + ".ttf")))
          nameFont = String.Format("font{0}", count++.ToString("000"));

        font = Path.Combine(fontDir, nameFont + ".ttf");
        File.Copy(fonts[0], font);

        FontHDJava fontHD =
          JsonSerializer.Deserialize<FontHDJava>(File.ReadAllText(Path.Combine(locationFont, "default.json")));

        MainFile mainFile = new CreateFile().InitFile();

        for (int i = 0; i < mainFile.chars.Count - 1; i++)
          mainFile.chars[i].size = fontHD.providers[0].size;

        main = mainFile;

        return true;
      }
      catch (Exception)
      {
        MessageBox.Show("Format Json not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      return false;
    }
  }
}
