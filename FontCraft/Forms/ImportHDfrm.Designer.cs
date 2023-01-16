
namespace FontCraft.Forms
{
  partial class ImportHDfrm
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
      this.label1 = new System.Windows.Forms.Label();
      this.listFont = new System.Windows.Forms.ListBox();
      this.importBtn = new System.Windows.Forms.Button();
      this.openBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(183, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Select from Installed Texture Pack";
      // 
      // listFont
      // 
      this.listFont.FormattingEnabled = true;
      this.listFont.ItemHeight = 15;
      this.listFont.Location = new System.Drawing.Point(13, 32);
      this.listFont.Name = "listFont";
      this.listFont.Size = new System.Drawing.Size(278, 214);
      this.listFont.TabIndex = 1;
      // 
      // importBtn
      // 
      this.importBtn.Location = new System.Drawing.Point(13, 252);
      this.importBtn.Name = "importBtn";
      this.importBtn.Size = new System.Drawing.Size(75, 23);
      this.importBtn.TabIndex = 2;
      this.importBtn.Text = "Import";
      this.importBtn.UseVisualStyleBackColor = true;
      this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
      // 
      // openBtn
      // 
      this.openBtn.Location = new System.Drawing.Point(94, 252);
      this.openBtn.Name = "openBtn";
      this.openBtn.Size = new System.Drawing.Size(75, 23);
      this.openBtn.TabIndex = 3;
      this.openBtn.Text = "Open";
      this.openBtn.UseVisualStyleBackColor = true;
      this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
      // 
      // ImportHDfrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(303, 284);
      this.Controls.Add(this.openBtn);
      this.Controls.Add(this.importBtn);
      this.Controls.Add(this.listFont);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ImportHDfrm";
      this.ShowInTaskbar = false;
      this.Text = "ImportHDfrm";
      this.Load += new System.EventHandler(this.ImportHDfrm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox listFont;
    private System.Windows.Forms.Button importBtn;
    private System.Windows.Forms.Button openBtn;
  }
}