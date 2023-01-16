using FontCraft.Util;
using FontCraft.Util.Files;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace FontCraft.Forms
{
  public partial class MainFrm : Form
  {
    public Graphics graph;

    MainFile mainFile;
    MainFile oldFile;

    PrivateFontCollection customFont;

    //Timer changedValue = new Timer();
    public MainFrm()
    {
      InitializeComponent();

      if (!Directory.Exists(Config.path)) Directory.CreateDirectory(Config.path);
      if (!Directory.Exists(Config.pathTemp)) Directory.CreateDirectory(Config.pathTemp);
      if (!Directory.Exists(Config.savePath)) Directory.CreateDirectory(Config.savePath);
      if (!Directory.Exists(Path.Combine(Util.Config.path, "font"))) Directory.CreateDirectory(Path.Combine(Util.Config.path, "font"));

      previewPanel.BackgroundImageLayout = ImageLayout.None;

      foreach (string font in Directory.GetFiles(Path.Combine(Util.Config.path, "font")))
        File.Delete(font);

      int pixelX = 0;
      int pixelY = 0;

      for (int i = 0; i < 256; i++)
      {
        Panel editChar = new Panel();
        previewPanel.Controls.Add(editChar);
        editChar.BackColor = Color.Transparent;
        editChar.ForeColor = SystemColors.ButtonShadow;
        editChar.Location = new Point(pixelX, pixelY);
        editChar.Name = "char" + i.ToString();
        editChar.Size = new Size(32, 32);
        editChar.TabIndex = i;
        editChar.DoubleClick += new EventHandler((sender, e) => editCharClick(sender, e, editChar.TabIndex));

        pixelX += 32;
        if (pixelX >= 512)
        {
          pixelX = 0;
          pixelY += 32;
        }
      }

      mainFile = new CreateFile().InitFile();
      oldFile = new CreateFile().InitFile();
    }

    private void editCharClick(object sender, EventArgs e, int i)
    {
      if (Util.Config.arrayFont[i] == "")
        return;

      int chars = i;
      if (chars > 32) chars -= 8;

      FontStyle myStyle;
      myStyle = FontStyle.Regular;

      if (mainFile.bold == 1 && mainFile.italic == 0)
        myStyle = FontStyle.Bold;
      else if (mainFile.bold == 0 && mainFile.italic == 1)
        myStyle = FontStyle.Italic;
      else if (mainFile.bold == 1 && mainFile.italic == 1)
        myStyle = FontStyle.Bold & FontStyle.Italic;

      Chars c = mainFile.chars[chars];

      EditCharFrm edit = new EditCharFrm(chars, i, ComboFont.SelectedIndex - 1, myStyle, c.x, c.y, c.size);
      edit.font = ComboFont.Text;

      if (edit.ShowDialog() == DialogResult.OK)
      {
        mainFile.chars[chars].x = edit.potitionX;
        mainFile.chars[chars].y = edit.potitionY;
        mainFile.chars[chars].size = edit.size;

        changed();
      }
    }

    private void MainFrm_Load(object sender, EventArgs e)
    {
      ComboFont.Items.Add("Custom");
      foreach (var f in FontFamily.Families) ComboFont.Items.Add(f.Name);

      ComboFont.SelectedIndex = 1;
      oldFile.font_name = ComboFont.Text;
    }

    private void changed()
    {
      if (mainFile.bold == 1)
        BoldBtn.BackColor = SystemColors.GradientActiveCaption;
      else
        BoldBtn.BackColor = SystemColors.Control;

      if (mainFile.italic == 1)
        ItalicBtn.BackColor = SystemColors.GradientActiveCaption;
      else
        ItalicBtn.BackColor = SystemColors.Control;

      Config.surface = new Bitmap(512, 512);
      Config.surface.MakeTransparent();
      graph = Graphics.FromImage(Config.surface);
      graph.TextRenderingHint = TextRenderingHint.AntiAlias;
      previewPanel.BackgroundImage = Config.surface;


      Brush white = new SolidBrush(Color.White);

      FontStyle myStyle;
      myStyle = FontStyle.Regular;

      if (mainFile.bold == 1 && mainFile.italic == 0)
        myStyle = FontStyle.Bold;
      else if (mainFile.bold == 0 && mainFile.italic == 1)
        myStyle = FontStyle.Italic;
      else if (mainFile.bold == 1 && mainFile.italic == 1)
        myStyle = FontStyle.Bold & FontStyle.Italic;


      string[] fontI = Util.Config.arrayFont;
      int pixelX = 0;
      int pixelY = 0;
      int ind = 0;

      for (int i = 0; i < fontI.Length; i++)
      {


        Bitmap bmpchar = new Bitmap(32, 32);
        if (fontI[i] != "")
        {
          Font setFont = (ComboFont.Text.Contains("(")) ?
            new Font(customFont.Families[0], (float)mainFile.chars[ind].size, myStyle) :
            new Font(FontFamily.Families[ComboFont.SelectedIndex - 1], (float)mainFile.chars[ind].size, myStyle);

          Graphics grpChar = Graphics.FromImage(bmpchar);
          grpChar.TextRenderingHint = TextRenderingHint.AntiAlias;
          grpChar.DrawString(fontI[i], setFont, white, new PointF(mainFile.chars[ind].x, mainFile.chars[ind].y));

          ind += 1;
        }

        graph.DrawImage(bmpchar, new Point(pixelX, pixelY));

        pixelX += 32;
        if (pixelX >= 512)
        {
          pixelX = 0;
          pixelY += 32;
        }
      }
    }

    private void BrowseBtn_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFont = new OpenFileDialog())
      {
        openFont.Title = "Get Custom Font...";
        openFont.Filter = "TTF file|*.ttf";

        if (openFont.ShowDialog() == DialogResult.OK)
        {
          string fontDir = Path.Combine(Util.Config.path, "font");

          if (!Directory.Exists(fontDir))
            Directory.CreateDirectory(fontDir);

          int count = 0;
          string nameFont = String.Format("font{0}", count.ToString("000"));

          while (File.Exists(Path.Combine(fontDir, nameFont + ".ttf")))
            nameFont = String.Format("font{0}", count++.ToString("000"));

          Config.fontFile = Path.Combine(fontDir, nameFont + ".ttf");
          File.Copy(openFont.FileName, Config.fontFile);

          customFont = new PrivateFontCollection();
          customFont.AddFontFile(Path.Combine(Config.fontFile));

          ComboFont.Items.RemoveAt(0);
          ComboFont.Items.Insert(0, "(" + customFont.Families[0].Name + ")");
          ComboFont.SelectedIndex = 0;
        }
      }
    }

    private void SelectFont(object sender, EventArgs e)
    {
      if (ComboFont.SelectedIndex == 0 && ComboFont.Text == "Custom")
      {
        BrowseBtn_Click(sender, e);
        return;
      }

      mainFile.font_name = ComboFont.Text;
      if (ComboFont.SelectedIndex > -1)
        changed();
    }

    private void BoldBtn_Click(object sender, EventArgs e)
    {
      mainFile.bold = (mainFile.bold == 0) ? 1 : 0;

      changed();
    }

    private void ItalicBtn_Click(object sender, EventArgs e)
    {
      mainFile.italic = (mainFile.italic == 0) ? 1 : 0;

      changed();
    }

    private void ExportBtn_Click(object sender, EventArgs e)
    {
      ExportFrm expfrm = new Forms.ExportFrm();
      expfrm.nameFont = ComboFont.Text;

      expfrm.ShowDialog();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) =>
      new About().ShowDialog();

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) =>
      Application.Exit();

    private bool Saveing()
    {
      String old = JsonSerializer.Serialize(oldFile);
      String newFile = JsonSerializer.Serialize(mainFile);

      if (old == newFile) return true;
      DialogResult exit = MessageBox.Show("Are you sure for saving this file?", "Save File",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

      if (exit == DialogResult.Yes)
        return new SaveProcess().Save(mainFile, Config.filesPath, Config.fontFile);

      else if (exit == DialogResult.No)
        return true;

      return false;
    }

    private void MainFrm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !Saveing();

    private void changeAllChar(object sender, EventArgs e)
    {
      int chars = 56;

      FontStyle myStyle;
      myStyle = FontStyle.Regular;

      if (mainFile.bold == 1 && mainFile.italic == 0)
        myStyle = FontStyle.Bold;
      else if (mainFile.bold == 0 && mainFile.italic == 1)
        myStyle = FontStyle.Italic;
      else if (mainFile.bold == 1 && mainFile.italic == 1)
        myStyle = FontStyle.Bold & FontStyle.Italic;

      Chars c = mainFile.chars[chars];

      EditCharFrm edit = new EditCharFrm(-1, 64, ComboFont.SelectedIndex - 1, myStyle, c.x, c.y, c.size);
      edit.font = ComboFont.Text;

      if (edit.ShowDialog() == DialogResult.OK)
      {
        foreach (Chars chari in mainFile.chars)
        {
          chari.x = edit.potitionX;
          chari.y = edit.potitionY;
          chari.size = edit.size;
        }

        changed();
      }
    }

    private void newEvent(object sender, EventArgs e)
    {
      if (Saveing())
      {
        mainFile = new CreateFile().InitFile();
        oldFile = new CreateFile().InitFile();
        ComboFont.SelectedIndex = 1;
        Config.filesPath = "";
        oldFile.font_name = ComboFont.Text;

        if (customFont.Families.Length > 0)
        {
          ComboFont.Items.RemoveAt(0);
          ComboFont.Items.Insert(0, "Custom");

          ComboFont = null;
          Config.fontFile = "";
        }

        changed();
      }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveProcess save = new SaveProcess();

      save.Save(mainFile, fontPath: Config.fontFile);
      oldFile = mainFile;
    }

    private void openEvent(object sender, EventArgs e)
    {
      if (Saveing())
      {
        OpenFileDialog open = new OpenFileDialog();

        open.Title = "Open Packs...";
        open.Filter = "FontCraft Packs|*.fcps";

        if (open.ShowDialog() == DialogResult.OK)
        {
          if (customFont != null)
            customFont.Dispose();

          Util.OpenProcess op = new Util.OpenProcess();
          MainFile main = op.Open(open.FileName);

          mainFile = main;
          oldFile = main;

          ComboFont.Items.RemoveAt(0);
          if (File.Exists(Config.fontFile))
          {
            customFont = new PrivateFontCollection();
            customFont.AddFontFile(Config.fontFile);
            ComboFont.Items.Insert(0, "(" + customFont.Families[0].Name + ")");
          }
          else
            ComboFont.Items.Insert(0, "Custom");

          ComboFont.Text = mainFile.font_name;
          Config.filesPath = open.FileName;

          changed();
        }
      }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveProcess save = new SaveProcess();

      save.Save(mainFile, Config.filesPath, Config.fontFile);
      oldFile = mainFile;
    }

    private void importHD(object sender, EventArgs e)
    {
      ImportHDfrm ImportHD = new ImportHDfrm();

      if ((ImportHD.ShowDialog() == DialogResult.OK) && Saveing())
      {
        mainFile = ImportHD.main;
        oldFile = new CreateFile().InitFile();
        ComboFont.SelectedIndex = 1;
        Config.filesPath = "";
        oldFile.font_name = ComboFont.Text;

        Config.fontFile = ImportHD.font;
        customFont = new PrivateFontCollection();
        customFont.AddFontFile(Path.Combine(Config.fontFile));

        ComboFont.Items.RemoveAt(0);
        ComboFont.Items.Insert(0, "(" + customFont.Families[0].Name + ")");
        ComboFont.SelectedIndex = 0;

        changed();
      } 
      else
      {

      }

    }

    private void undoEvent(object sender, EventArgs e)
    {

    }

    private void redoEvent(object sender, EventArgs e)
    {

    }
  }
}
