using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FontCraft.Util;
using System.Text.Json;
using System.Collections.ObjectModel;
using System.Linq;
using System.Drawing.Imaging;

namespace FontCraft.Forms
{
  public partial class ExportFrm : Form
  {
    public string nameFont;
    bool checkJava, checkBedrock;
    Bitmap icon;

    string RPJavapath = Path.Combine(Config.javaPath, "resourcepacks");
    string RPBedrockpath = Path.Combine(Config.bedrockPath, @"LocalState\games\com.mojang\resource_packs");
    string RPBedrockDevpath = Path.Combine(Config.bedrockPath, 
      @"LocalState\games\com.mojang\development_resource_packs");
    public ExportFrm()
    {
      InitializeComponent();
      //checkJava = Directory.Exists(Config.javaPath);
      //checkBedrock = Directory.Exists(Config.bedrockPath);
      checkJava = true;
      checkBedrock = true;

      icon = Properties.Resources.craft_icon_8;

      if (!Directory.Exists(RPJavapath)) Directory.CreateDirectory(RPJavapath);
      if (!Directory.Exists(RPBedrockpath)) Directory.CreateDirectory(RPBedrockpath);
    }

    private void WhenType(object sender, EventArgs e)
    {
      bool check = (TypeGame.SelectedIndex == 0) ? checkJava : checkBedrock;
      string path = (TypeGame.SelectedIndex == 0) ? RPJavapath : RPBedrockpath;

      DevCheck.Enabled = TypeGame.SelectedIndex == 1 && check;
      ExistingGroup.Enabled = check && Directory.GetDirectories(path).Length > 0;
      NameFont.Enabled = check && !CheckExisting.Checked;
      VersionPack.Enabled = check && !CheckExisting.Checked;
      listRP.Enabled = check && CheckExisting.Checked;
      HdFontCheck.Enabled = TypeGame.SelectedIndex == 0 && check && nameFont.Contains("(");
      ExportBtn.Enabled = check;
      GrupIconInstall.Enabled = check;

      if (!check) CheckExisting.Checked = false;

      switch (TypeGame.SelectedIndex)
      {
        case 0:
          DevCheck.Checked = false;
          
          LblNotif.Text = (checkJava) ? "" :
            "Minecraft Java not Installed";

          string[] versionJava = {"1.6.1 - 1.8.9", "1.9 – 1.10.2", "1.11 – 1.12.2",
            "1.13 – 1.14.4", "1.15 – 1.16.1", "1.16.2 – 1.16.5", "1.17+"};

          VersionPack.Items.Clear();
          VersionPack.Items.AddRange(versionJava);
          VersionPack.SelectedIndex = VersionPack.Items.Count - 1;

          listRP.Items.Clear();
          if (Directory.GetDirectories(RPJavapath).Length > 0)
            foreach (string p in Directory.GetDirectories(RPJavapath)) listRP.Items.Add(p.Split("\\").Last());

          if (Directory.GetDirectories(RPJavapath).Length < 1) CheckExisting.Checked = false;
          break;
        case 1:
          HdFontCheck.Checked = false;

          LblNotif.Text = (checkBedrock) ? "" :
           "Minecraft Bedrock not Installed";

          string[] versionBedrock = {"1.2.* - 1.15.*", "1.16+"};

          VersionPack.Items.Clear();
          VersionPack.Items.AddRange(versionBedrock);
          VersionPack.SelectedIndex = VersionPack.Items.Count - 1;

          listRP.Items.Clear();
          if (Directory.GetDirectories(RPBedrockpath).Length > 0)
            foreach (string p in Directory.GetDirectories(RPBedrockpath)) listRP.Items.Add(p.Split("\\").Last());

          if (Directory.GetDirectories(RPBedrockpath).Length < 1) CheckExisting.Checked = false;
          break;
      }
    }

    private void ExistChecked(object sender, EventArgs e)
    {
      NameFont.Enabled = !CheckExisting.Checked;
      VersionPack.Enabled = !CheckExisting.Checked;
      listRP.Enabled = CheckExisting.Checked;
      GrupIconInstall.Enabled = !CheckExisting.Checked; 
    }

    private void DevChecked(object sender, EventArgs e)
    {
      string path = (DevCheck.Checked) ? RPBedrockDevpath : RPBedrockpath;

      ExistingGroup.Enabled = checkBedrock && Directory.GetDirectories(path).Length > 0;

      listRP.Items.Clear();
      if (Directory.GetDirectories(path).Length > 0)
        foreach (string p in Directory.GetDirectories(path)) listRP.Items.Add(p.Split("\\").Last());

      if (Directory.GetDirectories(path).Length < 1) CheckExisting.Checked = false;
    }

    private void ImportIcon(object sender, EventArgs e)
    {
      OpenFileDialog op = new OpenFileDialog();

      op.Title = "Get Icon...";
      op.Filter = "Images Only|*.jpg;*.jpeg;*.png";

      if (op.ShowDialog() == DialogResult.OK)
      {
        Bitmap tempIcon = new Bitmap(op.FileName);
        if (tempIcon.Width != tempIcon.Height)
        {
          MessageBox.Show("Image is not support square rasio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        icon = tempIcon;
        IconInstallPack.Image = icon;
        iconExportPack.Image = icon;
      }
    }

    private void InstallEvent(object sender, EventArgs e)
    {
      InstallProcess install = new InstallProcess();
      switch (TypeGame.SelectedIndex)
      {
        case 0:
          string textureJavaPath = Path.Combine(RPJavapath, NameFont.Text);

          switch (CheckExisting.Checked)
          {
            case true:
              if (HdFontCheck.Checked) install.ExportExistHDJava(listRP.SelectedItem.ToString());
              else install.ExportExistJava(listRP.SelectedItem.ToString());

              break;
            case false:
              if (Directory.Exists(textureJavaPath))
              {
                MessageBox.Show(String.Format("{0} are available, use existing resource pack!", NameFont.Text),
                  "Texture Pack Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
              }

              if (HdFontCheck.Checked) install.ExportToHDJava(icon, NameFont.Text, VersionPack.SelectedIndex + 1);
              else install.ExportToJava(icon, NameFont.Text, VersionPack.SelectedIndex + 1);
              break;
          }
          break;
        case 1:
          string BRPath = (DevCheck.Checked) ? RPBedrockDevpath : RPBedrockpath;
          string textureBRPath = Path.Combine(BRPath, NameFont.Text);

          switch (CheckExisting.Checked)
          {
          case true:
              install.ExportExistBedrock(listRP.SelectedItem.ToString(), BRPath);

              break;
            case false:
              if (Directory.Exists(textureBRPath))
              {
                MessageBox.Show(String.Format("{0} are available, use existing resource pack!", NameFont.Text),
                  "Texture Pack Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
              }

              install.ExportToBedrock(icon, NameFont.Text, VersionPack.SelectedIndex + 1, BRPath);
              break;
          }
          break;
      }
      Close();
    }

    private void TypeExSelected(object sender, EventArgs e)
    {
      VersionPack2.Enabled = TypeExport.SelectedIndex < 2;
      mcpackCheck.Enabled = TypeExport.SelectedIndex == 1 || TypeExport.SelectedIndex == 2;
      mcpackCheck.Checked = TypeExport.SelectedIndex == 1 || TypeExport.SelectedIndex == 2;
      HDCheckExport.Enabled = TypeExport.SelectedIndex == 0 && nameFont.Contains("(");

      switch (TypeExport.SelectedIndex)
      {
        case 0:
          string[] versionJava = {"1.6.1 - 1.8.9", "1.9 – 1.10.2", "1.11 – 1.12.2",
            "1.13 – 1.14.4", "1.15 – 1.16.1", "1.16.2 – 1.16.5", "1.17+"};

          VersionPack2.Items.Clear();
          VersionPack2.Items.AddRange(versionJava);
          VersionPack2.SelectedIndex = VersionPack2.Items.Count - 1;
          break;
        case 1:
          string[] versionBedrock = { "1.2.* - 1.15.*", "1.16+" };

          VersionPack2.Items.Clear();
          VersionPack2.Items.AddRange(versionBedrock);
          VersionPack2.SelectedIndex = VersionPack2.Items.Count - 1;
          break;
        case 2:
          VersionPack2.Items.Clear();
          VersionPack2.Items.Add("1.0 - 1.1");
          VersionPack2.SelectedIndex = 0;
          break;
        case 3:
          VersionPack2.Items.Clear();
          VersionPack2.Items.Add("0.12 - 0.16");
          VersionPack2.SelectedIndex = 0;
          break;
        case 4:
          VersionPack2.Items.Clear();
          VersionPack2.Items.Add("PNG");
          VersionPack2.SelectedIndex = 0;
          break;
      }
    }

    private void BrowseSaveBtn_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folder = new FolderBrowserDialog();
      folder.SelectedPath = PathTxt.Text;

      if (folder.ShowDialog() == DialogResult.OK)
        PathTxt.Text = folder.SelectedPath;
    }

    private void ExportFile(object sender, EventArgs e)
    {
      string name = NamePack.Text;
      string path = PathTxt.Text;
      int ver = VersionPack2.SelectedIndex + 1;

      SaveProcess save = new SaveProcess();
      switch (TypeExport.SelectedIndex)
      {
        case 0:
          if (HDCheckExport.Checked) save.ExportFileHDJava(icon, name, ver, path);
          else save.ExportFileJava(icon, name, ver, path);
          break;
        case 1:
          save.ExportFileBedrock(icon, name, ver, path, mcpackCheck.Checked);
          break;
        case 2:
          save.ExportFilePE(icon, name, ver, path, mcpackCheck.Checked);
          break;
        case 3:
          save.ExportFilePEA(icon, name, ver, path);
          break;
        case 4:
          save.ExportFilePNG(name, path);
          break;
      }
      Close();
    }

    private void ExportFrm_Load(object sender, EventArgs e)
    {
      TypeGame.Items.Clear();
      TypeExport.Items.Clear();
      string[] type1 = { "Java", "Bedrock" };
      string[] type2 = { "Java", "Bedrock" , "MCPE (Legacy)", "MCPE (Alpha)", "PNG"};
      // Initial Import To game
      TypeGame.Items.AddRange(type1);
      TypeGame.SelectedIndex = 0;
      // Initial to file
      TypeExport.Items.AddRange(type2);
      TypeExport.SelectedIndex = 0;

      char[] triming = { '(', ')' };
      NameFont.Text = String.Format("{0} Font Packs", nameFont.Trim(triming));
      NamePack.Text = String.Format("{0} Font Packs", nameFont.Trim(triming));

      IconInstallPack.Image = icon;
      iconExportPack.Image = icon;

      if (!Directory.Exists(Path.Combine(Config.savePath, "Export")))
        Directory.CreateDirectory(Path.Combine(Config.savePath, "Export"));
      PathTxt.Text = Path.Combine(Config.savePath, "Export");
    }
  }
}
