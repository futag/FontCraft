
namespace FontCraft.Forms
{
  partial class EditCharFrm
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
      this.previewBox = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.paddTop = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.paddBottom = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.fontSize = new System.Windows.Forms.NumericUpDown();
      this.okBtn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddTop)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddBottom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
      this.SuspendLayout();
      // 
      // previewBox
      // 
      this.previewBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.previewBox.Location = new System.Drawing.Point(11, 97);
      this.previewBox.Name = "previewBox";
      this.previewBox.Size = new System.Drawing.Size(50, 50);
      this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.previewBox.TabIndex = 0;
      this.previewBox.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Padding Top";
      // 
      // paddTop
      // 
      this.paddTop.DecimalPlaces = 2;
      this.paddTop.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.paddTop.Location = new System.Drawing.Point(110, 11);
      this.paddTop.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.paddTop.Name = "paddTop";
      this.paddTop.Size = new System.Drawing.Size(73, 23);
      this.paddTop.TabIndex = 2;
      this.paddTop.ValueChanged += new System.EventHandler(this.Changed);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Padding Bottom";
      // 
      // paddBottom
      // 
      this.paddBottom.DecimalPlaces = 2;
      this.paddBottom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.paddBottom.Location = new System.Drawing.Point(110, 40);
      this.paddBottom.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.paddBottom.Name = "paddBottom";
      this.paddBottom.Size = new System.Drawing.Size(73, 23);
      this.paddBottom.TabIndex = 2;
      this.paddBottom.ValueChanged += new System.EventHandler(this.Changed);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 71);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 15);
      this.label3.TabIndex = 1;
      this.label3.Text = "Font Size";
      // 
      // fontSize
      // 
      this.fontSize.DecimalPlaces = 2;
      this.fontSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.fontSize.Location = new System.Drawing.Point(110, 69);
      this.fontSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.fontSize.Name = "fontSize";
      this.fontSize.Size = new System.Drawing.Size(73, 23);
      this.fontSize.TabIndex = 2;
      this.fontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.fontSize.ValueChanged += new System.EventHandler(this.Changed);
      // 
      // okBtn
      // 
      this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okBtn.Location = new System.Drawing.Point(110, 124);
      this.okBtn.Name = "okBtn";
      this.okBtn.Size = new System.Drawing.Size(75, 23);
      this.okBtn.TabIndex = 3;
      this.okBtn.Text = "OK";
      this.okBtn.UseVisualStyleBackColor = true;
      this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
      // 
      // EditCharFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(193, 159);
      this.Controls.Add(this.okBtn);
      this.Controls.Add(this.fontSize);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.paddBottom);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.paddTop);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.previewBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "EditCharFrm";
      this.ShowInTaskbar = false;
      this.Text = "EditCharFrm";
      this.Load += new System.EventHandler(this.EditCharFrm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddTop)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddBottom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox previewBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown paddTop;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown paddBottom;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown fontSize;
    private System.Windows.Forms.Button okBtn;
  }
}