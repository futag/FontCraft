
namespace FontCraft.Forms
{
  partial class MainFrm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
      this.previewPanel = new System.Windows.Forms.Panel();
      this.BgPanel = new System.Windows.Forms.Panel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fromHDFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.OpenBtn = new System.Windows.Forms.ToolStripSplitButton();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.importAsHDPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.undoBtn = new System.Windows.Forms.ToolStripSplitButton();
      this.redoBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.ComboFont = new System.Windows.Forms.ToolStripComboBox();
      this.BrowseBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.BoldBtn = new System.Windows.Forms.ToolStripButton();
      this.ItalicBtn = new System.Windows.Forms.ToolStripButton();
      this.ExportBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.changeAllCharBtn = new System.Windows.Forms.ToolStripButton();
      this.BgPanel.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // previewPanel
      // 
      this.previewPanel.BackColor = System.Drawing.Color.Transparent;
      this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewPanel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.previewPanel.Location = new System.Drawing.Point(0, 0);
      this.previewPanel.Name = "previewPanel";
      this.previewPanel.Size = new System.Drawing.Size(512, 512);
      this.previewPanel.TabIndex = 2;
      // 
      // BgPanel
      // 
      this.BgPanel.BackColor = System.Drawing.SystemColors.Control;
      this.BgPanel.BackgroundImage = global::FontCraft.Properties.Resources.background;
      this.BgPanel.Controls.Add(this.previewPanel);
      this.BgPanel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BgPanel.Location = new System.Drawing.Point(1, 54);
      this.BgPanel.Name = "BgPanel";
      this.BgPanel.Size = new System.Drawing.Size(512, 512);
      this.BgPanel.TabIndex = 3;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditMenu,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(514, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // newToolStripMenuItem1
      // 
      this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
      this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
      this.newToolStripMenuItem1.Text = "&New";
      this.newToolStripMenuItem1.Click += new System.EventHandler(this.newEvent);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.openToolStripMenuItem.Text = "&Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openEvent);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.saveAsToolStripMenuItem.Text = "S&ave as...";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
      // 
      // importToolStripMenuItem
      // 
      this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromHDFontToolStripMenuItem});
      this.importToolStripMenuItem.Name = "importToolStripMenuItem";
      this.importToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.importToolStripMenuItem.Text = "&Import...";
      // 
      // fromHDFontToolStripMenuItem
      // 
      this.fromHDFontToolStripMenuItem.Name = "fromHDFontToolStripMenuItem";
      this.fromHDFontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
      this.fromHDFontToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
      this.fromHDFontToolStripMenuItem.Text = "&From HD Font";
      this.fromHDFontToolStripMenuItem.Click += new System.EventHandler(this.importHD);
      // 
      // exportToolStripMenuItem
      // 
      this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
      this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
      this.exportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.exportToolStripMenuItem.Text = "E&xport";
      this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportBtn_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(190, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.exitToolStripMenuItem.Text = "&Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // EditMenu
      // 
      this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
      this.EditMenu.Name = "EditMenu";
      this.EditMenu.Size = new System.Drawing.Size(39, 20);
      this.EditMenu.Text = "E&dit";
      this.EditMenu.Click += new System.EventHandler(this.undoEvent);
      // 
      // undoToolStripMenuItem
      // 
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.undoToolStripMenuItem.Text = "&Undo";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.redoToolStripMenuItem.Text = "&Redo";
      this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoEvent);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikiToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // wikiToolStripMenuItem
      // 
      this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
      this.wikiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.wikiToolStripMenuItem.Text = "&Wiki";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "A&bout";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBtn,
            this.toolStripSeparator1,
            this.undoBtn,
            this.redoBtn,
            this.toolStripSeparator6,
            this.ComboFont,
            this.BrowseBtn,
            this.toolStripSeparator2,
            this.BoldBtn,
            this.ItalicBtn,
            this.ExportBtn,
            this.toolStripSeparator3,
            this.changeAllCharBtn});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(514, 25);
      this.toolStrip1.TabIndex = 5;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // OpenBtn
      // 
      this.OpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.OpenBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.importAsHDPackToolStripMenuItem});
      this.OpenBtn.Image = global::FontCraft.Properties.Resources.browse_8;
      this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.OpenBtn.Name = "OpenBtn";
      this.OpenBtn.Size = new System.Drawing.Size(32, 22);
      this.OpenBtn.Text = "Open";
      this.OpenBtn.ToolTipText = "Open";
      this.OpenBtn.ButtonClick += new System.EventHandler(this.openEvent);
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newEvent);
      // 
      // importAsHDPackToolStripMenuItem
      // 
      this.importAsHDPackToolStripMenuItem.Name = "importAsHDPackToolStripMenuItem";
      this.importAsHDPackToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
      this.importAsHDPackToolStripMenuItem.Text = "Import on HD Font";
      this.importAsHDPackToolStripMenuItem.Click += new System.EventHandler(this.importHD);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // undoBtn
      // 
      this.undoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.undoBtn.Image = global::FontCraft.Properties.Resources.undo_8;
      this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.undoBtn.Name = "undoBtn";
      this.undoBtn.Size = new System.Drawing.Size(32, 22);
      this.undoBtn.Text = "Undo";
      this.undoBtn.ButtonClick += new System.EventHandler(this.undoEvent);
      // 
      // redoBtn
      // 
      this.redoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.redoBtn.Image = global::FontCraft.Properties.Resources.redo_8;
      this.redoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.redoBtn.Name = "redoBtn";
      this.redoBtn.Size = new System.Drawing.Size(23, 22);
      this.redoBtn.Text = "Redo";
      this.redoBtn.Click += new System.EventHandler(this.redoEvent);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
      // 
      // ComboFont
      // 
      this.ComboFont.Name = "ComboFont";
      this.ComboFont.Size = new System.Drawing.Size(190, 25);
      this.ComboFont.SelectedIndexChanged += new System.EventHandler(this.SelectFont);
      // 
      // BrowseBtn
      // 
      this.BrowseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BrowseBtn.Image = global::FontCraft.Properties.Resources.browse_font_8;
      this.BrowseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BrowseBtn.Name = "BrowseBtn";
      this.BrowseBtn.Size = new System.Drawing.Size(23, 22);
      this.BrowseBtn.Text = "toolStripButton1";
      this.BrowseBtn.ToolTipText = "Browse a font...";
      this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // BoldBtn
      // 
      this.BoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BoldBtn.Image = global::FontCraft.Properties.Resources.bold_8;
      this.BoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BoldBtn.Name = "BoldBtn";
      this.BoldBtn.Size = new System.Drawing.Size(23, 22);
      this.BoldBtn.Text = "Bold";
      this.BoldBtn.Click += new System.EventHandler(this.BoldBtn_Click);
      // 
      // ItalicBtn
      // 
      this.ItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ItalicBtn.Image = global::FontCraft.Properties.Resources.italic_8;
      this.ItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ItalicBtn.Name = "ItalicBtn";
      this.ItalicBtn.Size = new System.Drawing.Size(23, 22);
      this.ItalicBtn.Text = "Italic";
      this.ItalicBtn.Click += new System.EventHandler(this.ItalicBtn_Click);
      // 
      // ExportBtn
      // 
      this.ExportBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ExportBtn.Image = global::FontCraft.Properties.Resources.export_8;
      this.ExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ExportBtn.Name = "ExportBtn";
      this.ExportBtn.Size = new System.Drawing.Size(23, 22);
      this.ExportBtn.Text = "Export";
      this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // changeAllCharBtn
      // 
      this.changeAllCharBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.changeAllCharBtn.Image = global::FontCraft.Properties.Resources.edit_font_8;
      this.changeAllCharBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.changeAllCharBtn.Name = "changeAllCharBtn";
      this.changeAllCharBtn.Size = new System.Drawing.Size(23, 22);
      this.changeAllCharBtn.Text = "Change All Char";
      this.changeAllCharBtn.Click += new System.EventHandler(this.changeAllChar);
      // 
      // MainFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(514, 567);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.BgPanel);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "MainFrm";
      this.Text = "Fontcraft";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
      this.Load += new System.EventHandler(this.MainFrm_Load);
      this.BgPanel.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel previewPanel;
    private System.Windows.Forms.Panel BgPanel;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fromHDFontToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripSplitButton OpenBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripComboBox ComboFont;
    private System.Windows.Forms.ToolStripButton BrowseBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton BoldBtn;
    private System.Windows.Forms.ToolStripButton ItalicBtn;
    private System.Windows.Forms.ToolStripButton ExportBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton changeAllCharBtn;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem importAsHDPackToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSplitButton undoBtn;
    private System.Windows.Forms.ToolStripButton redoBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem EditMenu;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
  }
}

