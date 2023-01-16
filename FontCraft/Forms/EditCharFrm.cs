using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FontCraft.Forms
{
  public partial class EditCharFrm : Form
  {
    string str;
    int ids;
    int fontid;

    public float potitionX;
    public float potitionY;
    public float size;

    float x;
    float y;
    float s;

    public string font;
    PrivateFontCollection customFont;
    FontStyle style;

    Graphics graph;
    Bitmap bitmap;
    public EditCharFrm(int Ichar, int idChar, int fontid, FontStyle style, float x, float y, float s)
    {
      InitializeComponent();
      ids = Ichar;
      this.fontid = fontid;
      this.style = style;

      this.x = x;
      this.y = y;
      this.s = s;

      str = (Ichar < 0) ? "A" : Util.Config.arrayFont[idChar];
    }

    private void EditCharFrm_Load(object sender, EventArgs e)
    {
      paddBottom.Value = (decimal)x;
      paddTop.Value = (decimal)y;
      fontSize.Value = (decimal)s;

      Text = (ids < 0) ? "Edit All Charachers" : String.Format("Edit Characher {0}", str);

      Changed(sender, e);
    }

    private void okBtn_Click(object sender, EventArgs e)
    {
      potitionX = (float)paddBottom.Value;
      potitionY = (float)paddTop.Value;
      size = (float)fontSize.Value;
    }

    private void Changed(object sender, EventArgs e)
    {
      bitmap = new Bitmap(32, 32);
      bitmap.MakeTransparent();
      graph = Graphics.FromImage(bitmap);
      previewBox.Image = bitmap;

      Brush white = new SolidBrush(Color.White);

      if (font.Contains("("))
      {
        customFont = new PrivateFontCollection();
        customFont.AddFontFile(Util.Config.fontFile);

        Font setFont = new Font(customFont.Families[0], (float)fontSize.Value, style);
        graph.DrawString(str, setFont, white, new PointF((float)paddBottom.Value, (float)paddTop.Value));
      }
      else
      {
        Font setFont = new Font(FontFamily.Families[fontid], (float)fontSize.Value, style);
        graph.DrawString(str, setFont, white, new PointF((float)paddBottom.Value, (float)paddTop.Value));
      }
    }
  }
}
