
namespace FontCraft.Forms
{
  partial class ExportFrm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.DevCheck = new System.Windows.Forms.CheckBox();
      this.GrupIconInstall = new System.Windows.Forms.GroupBox();
      this.BrowseInstall = new System.Windows.Forms.Button();
      this.IconInstallPack = new System.Windows.Forms.PictureBox();
      this.VersionPack = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.HdFontCheck = new System.Windows.Forms.CheckBox();
      this.ExportBtn = new System.Windows.Forms.Button();
      this.LblNotif = new System.Windows.Forms.Label();
      this.NameFont = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ExistingGroup = new System.Windows.Forms.GroupBox();
      this.listRP = new System.Windows.Forms.ListBox();
      this.CheckExisting = new System.Windows.Forms.CheckBox();
      this.TypeGame = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.mcpackCheck = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.BrowseExport = new System.Windows.Forms.Button();
      this.iconExportPack = new System.Windows.Forms.PictureBox();
      this.HDCheckExport = new System.Windows.Forms.CheckBox();
      this.VersionPack2 = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.BrowseSaveBtn = new System.Windows.Forms.Button();
      this.NamePack = new System.Windows.Forms.TextBox();
      this.ExportBtn2 = new System.Windows.Forms.Button();
      this.PathTxt = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.TypeExport = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.GrupIconInstall.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.IconInstallPack)).BeginInit();
      this.ExistingGroup.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconExportPack)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(411, 450);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.DevCheck);
      this.tabPage1.Controls.Add(this.GrupIconInstall);
      this.tabPage1.Controls.Add(this.VersionPack);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.HdFontCheck);
      this.tabPage1.Controls.Add(this.ExportBtn);
      this.tabPage1.Controls.Add(this.LblNotif);
      this.tabPage1.Controls.Add(this.NameFont);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.ExistingGroup);
      this.tabPage1.Controls.Add(this.TypeGame);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Location = new System.Drawing.Point(4, 24);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(403, 422);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Add in the game";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // DevCheck
      // 
      this.DevCheck.AutoSize = true;
      this.DevCheck.Location = new System.Drawing.Point(23, 48);
      this.DevCheck.Name = "DevCheck";
      this.DevCheck.Size = new System.Drawing.Size(263, 19);
      this.DevCheck.TabIndex = 13;
      this.DevCheck.Text = "Set as Development Resource Pack (Bedrock)";
      this.DevCheck.UseVisualStyleBackColor = true;
      this.DevCheck.CheckedChanged += new System.EventHandler(this.DevChecked);
      // 
      // GrupIconInstall
      // 
      this.GrupIconInstall.Controls.Add(this.BrowseInstall);
      this.GrupIconInstall.Controls.Add(this.IconInstallPack);
      this.GrupIconInstall.Location = new System.Drawing.Point(265, 99);
      this.GrupIconInstall.Name = "GrupIconInstall";
      this.GrupIconInstall.Size = new System.Drawing.Size(117, 179);
      this.GrupIconInstall.TabIndex = 12;
      this.GrupIconInstall.TabStop = false;
      this.GrupIconInstall.Text = "Icons";
      // 
      // BrowseInstall
      // 
      this.BrowseInstall.Location = new System.Drawing.Point(8, 138);
      this.BrowseInstall.Name = "BrowseInstall";
      this.BrowseInstall.Size = new System.Drawing.Size(100, 23);
      this.BrowseInstall.TabIndex = 1;
      this.BrowseInstall.Text = "Browse";
      this.BrowseInstall.UseVisualStyleBackColor = true;
      this.BrowseInstall.Click += new System.EventHandler(this.ImportIcon);
      // 
      // IconInstallPack
      // 
      this.IconInstallPack.Location = new System.Drawing.Point(8, 22);
      this.IconInstallPack.Name = "IconInstallPack";
      this.IconInstallPack.Size = new System.Drawing.Size(100, 100);
      this.IconInstallPack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.IconInstallPack.TabIndex = 0;
      this.IconInstallPack.TabStop = false;
      // 
      // VersionPack
      // 
      this.VersionPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.VersionPack.FormattingEnabled = true;
      this.VersionPack.Location = new System.Drawing.Point(102, 331);
      this.VersionPack.Name = "VersionPack";
      this.VersionPack.Size = new System.Drawing.Size(271, 23);
      this.VersionPack.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 335);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 15);
      this.label3.TabIndex = 8;
      this.label3.Text = "Version Pack";
      // 
      // HdFontCheck
      // 
      this.HdFontCheck.AutoSize = true;
      this.HdFontCheck.Location = new System.Drawing.Point(8, 394);
      this.HdFontCheck.Name = "HdFontCheck";
      this.HdFontCheck.Size = new System.Drawing.Size(175, 19);
      this.HdFontCheck.TabIndex = 7;
      this.HdFontCheck.Text = "Export as HD Font (Optifine)";
      this.HdFontCheck.UseVisualStyleBackColor = true;
      // 
      // ExportBtn
      // 
      this.ExportBtn.Location = new System.Drawing.Point(320, 391);
      this.ExportBtn.Name = "ExportBtn";
      this.ExportBtn.Size = new System.Drawing.Size(75, 23);
      this.ExportBtn.TabIndex = 6;
      this.ExportBtn.Text = "Export";
      this.ExportBtn.UseVisualStyleBackColor = true;
      this.ExportBtn.Click += new System.EventHandler(this.InstallEvent);
      // 
      // LblNotif
      // 
      this.LblNotif.AutoSize = true;
      this.LblNotif.Location = new System.Drawing.Point(22, 72);
      this.LblNotif.Name = "LblNotif";
      this.LblNotif.Size = new System.Drawing.Size(38, 15);
      this.LblNotif.TabIndex = 5;
      this.LblNotif.Text = "label3";
      // 
      // NameFont
      // 
      this.NameFont.Location = new System.Drawing.Point(102, 302);
      this.NameFont.Name = "NameFont";
      this.NameFont.Size = new System.Drawing.Size(271, 23);
      this.NameFont.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 305);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Name";
      // 
      // ExistingGroup
      // 
      this.ExistingGroup.Controls.Add(this.listRP);
      this.ExistingGroup.Controls.Add(this.CheckExisting);
      this.ExistingGroup.Location = new System.Drawing.Point(10, 99);
      this.ExistingGroup.Name = "ExistingGroup";
      this.ExistingGroup.Size = new System.Drawing.Size(249, 179);
      this.ExistingGroup.TabIndex = 2;
      this.ExistingGroup.TabStop = false;
      this.ExistingGroup.Text = "Add in Existing Resource Pack";
      // 
      // listRP
      // 
      this.listRP.FormattingEnabled = true;
      this.listRP.ItemHeight = 15;
      this.listRP.Location = new System.Drawing.Point(9, 47);
      this.listRP.Name = "listRP";
      this.listRP.Size = new System.Drawing.Size(230, 124);
      this.listRP.TabIndex = 1;
      // 
      // CheckExisting
      // 
      this.CheckExisting.AutoSize = true;
      this.CheckExisting.Location = new System.Drawing.Point(14, 22);
      this.CheckExisting.Name = "CheckExisting";
      this.CheckExisting.Size = new System.Drawing.Size(187, 19);
      this.CheckExisting.TabIndex = 0;
      this.CheckExisting.Text = "Save to Existing Resource Pack";
      this.CheckExisting.UseVisualStyleBackColor = true;
      this.CheckExisting.CheckedChanged += new System.EventHandler(this.ExistChecked);
      // 
      // TypeGame
      // 
      this.TypeGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.TypeGame.FormattingEnabled = true;
      this.TypeGame.Location = new System.Drawing.Point(59, 19);
      this.TypeGame.Name = "TypeGame";
      this.TypeGame.Size = new System.Drawing.Size(314, 23);
      this.TypeGame.TabIndex = 1;
      this.TypeGame.SelectedIndexChanged += new System.EventHandler(this.WhenType);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Type";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.mcpackCheck);
      this.tabPage2.Controls.Add(this.groupBox2);
      this.tabPage2.Controls.Add(this.HDCheckExport);
      this.tabPage2.Controls.Add(this.VersionPack2);
      this.tabPage2.Controls.Add(this.label6);
      this.tabPage2.Controls.Add(this.BrowseSaveBtn);
      this.tabPage2.Controls.Add(this.NamePack);
      this.tabPage2.Controls.Add(this.ExportBtn2);
      this.tabPage2.Controls.Add(this.PathTxt);
      this.tabPage2.Controls.Add(this.label7);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.TypeExport);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Location = new System.Drawing.Point(4, 24);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(403, 422);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Export File";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // mcpackCheck
      // 
      this.mcpackCheck.AutoSize = true;
      this.mcpackCheck.Location = new System.Drawing.Point(20, 159);
      this.mcpackCheck.Name = "mcpackCheck";
      this.mcpackCheck.Size = new System.Drawing.Size(112, 19);
      this.mcpackCheck.TabIndex = 19;
      this.mcpackCheck.Text = "Save as .mcpack";
      this.mcpackCheck.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.BrowseExport);
      this.groupBox2.Controls.Add(this.iconExportPack);
      this.groupBox2.Location = new System.Drawing.Point(254, 137);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(117, 179);
      this.groupBox2.TabIndex = 18;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Icons";
      // 
      // BrowseExport
      // 
      this.BrowseExport.Location = new System.Drawing.Point(8, 138);
      this.BrowseExport.Name = "BrowseExport";
      this.BrowseExport.Size = new System.Drawing.Size(100, 23);
      this.BrowseExport.TabIndex = 1;
      this.BrowseExport.Text = "Browse";
      this.BrowseExport.UseVisualStyleBackColor = true;
      this.BrowseExport.Click += new System.EventHandler(this.ImportIcon);
      // 
      // iconExportPack
      // 
      this.iconExportPack.Location = new System.Drawing.Point(8, 22);
      this.iconExportPack.Name = "iconExportPack";
      this.iconExportPack.Size = new System.Drawing.Size(100, 100);
      this.iconExportPack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.iconExportPack.TabIndex = 0;
      this.iconExportPack.TabStop = false;
      // 
      // HDCheckExport
      // 
      this.HDCheckExport.AutoSize = true;
      this.HDCheckExport.Location = new System.Drawing.Point(8, 394);
      this.HDCheckExport.Name = "HDCheckExport";
      this.HDCheckExport.Size = new System.Drawing.Size(175, 19);
      this.HDCheckExport.TabIndex = 17;
      this.HDCheckExport.Text = "Export as HD Font (Optifine)";
      this.HDCheckExport.UseVisualStyleBackColor = true;
      // 
      // VersionPack2
      // 
      this.VersionPack2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.VersionPack2.FormattingEnabled = true;
      this.VersionPack2.Location = new System.Drawing.Point(99, 76);
      this.VersionPack2.Name = "VersionPack2";
      this.VersionPack2.Size = new System.Drawing.Size(272, 23);
      this.VersionPack2.TabIndex = 16;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(20, 111);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(39, 15);
      this.label6.TabIndex = 15;
      this.label6.Text = "Name";
      // 
      // BrowseSaveBtn
      // 
      this.BrowseSaveBtn.Location = new System.Drawing.Point(330, 47);
      this.BrowseSaveBtn.Name = "BrowseSaveBtn";
      this.BrowseSaveBtn.Size = new System.Drawing.Size(41, 23);
      this.BrowseSaveBtn.TabIndex = 14;
      this.BrowseSaveBtn.Text = "...";
      this.BrowseSaveBtn.UseVisualStyleBackColor = true;
      this.BrowseSaveBtn.Click += new System.EventHandler(this.BrowseSaveBtn_Click);
      // 
      // NamePack
      // 
      this.NamePack.Location = new System.Drawing.Point(99, 108);
      this.NamePack.Name = "NamePack";
      this.NamePack.Size = new System.Drawing.Size(272, 23);
      this.NamePack.TabIndex = 12;
      // 
      // ExportBtn2
      // 
      this.ExportBtn2.Location = new System.Drawing.Point(320, 391);
      this.ExportBtn2.Name = "ExportBtn2";
      this.ExportBtn2.Size = new System.Drawing.Size(75, 23);
      this.ExportBtn2.TabIndex = 13;
      this.ExportBtn2.Text = "Export";
      this.ExportBtn2.UseVisualStyleBackColor = true;
      this.ExportBtn2.Click += new System.EventHandler(this.ExportFile);
      // 
      // PathTxt
      // 
      this.PathTxt.Location = new System.Drawing.Point(99, 47);
      this.PathTxt.Name = "PathTxt";
      this.PathTxt.ReadOnly = true;
      this.PathTxt.Size = new System.Drawing.Size(225, 23);
      this.PathTxt.TabIndex = 12;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(20, 79);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(73, 15);
      this.label7.TabIndex = 11;
      this.label7.Text = "Version Pack";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(20, 50);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 15);
      this.label5.TabIndex = 11;
      this.label5.Text = "Location";
      // 
      // TypeExport
      // 
      this.TypeExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.TypeExport.FormattingEnabled = true;
      this.TypeExport.Location = new System.Drawing.Point(99, 18);
      this.TypeExport.Name = "TypeExport";
      this.TypeExport.Size = new System.Drawing.Size(272, 23);
      this.TypeExport.TabIndex = 10;
      this.TypeExport.SelectedIndexChanged += new System.EventHandler(this.TypeExSelected);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(20, 21);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 15);
      this.label4.TabIndex = 9;
      this.label4.Text = "Type";
      // 
      // ExportFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(411, 450);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ExportFrm";
      this.ShowInTaskbar = false;
      this.Text = "Export...";
      this.Load += new System.EventHandler(this.ExportFrm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.GrupIconInstall.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.IconInstallPack)).EndInit();
      this.ExistingGroup.ResumeLayout(false);
      this.ExistingGroup.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.iconExportPack)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TextBox NameFont;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox ExistingGroup;
    private System.Windows.Forms.ListBox listRP;
    private System.Windows.Forms.CheckBox CheckExisting;
    private System.Windows.Forms.ComboBox TypeGame;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button ExportBtn;
    private System.Windows.Forms.Label LblNotif;
    private System.Windows.Forms.CheckBox HdFontCheck;
    private System.Windows.Forms.ComboBox VersionPack;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox HDCheckExport;
    private System.Windows.Forms.ComboBox VersionPack2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button BrowseSaveBtn;
    private System.Windows.Forms.Button ExportBtn2;
    private System.Windows.Forms.TextBox PathTxt;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox TypeExport;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox NamePack;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox GrupIconInstall;
    private System.Windows.Forms.Button BrowseInstall;
    private System.Windows.Forms.PictureBox IconInstallPack;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button BrowseExport;
    private System.Windows.Forms.PictureBox iconExportPack;
    private System.Windows.Forms.CheckBox DevCheck;
    private System.Windows.Forms.CheckBox mcpackCheck;
  }
}