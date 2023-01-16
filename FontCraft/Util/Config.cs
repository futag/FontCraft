using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace FontCraft.Util
{
  public static class Config
  {
    public static Bitmap surface;
    public static string fontFile = "";
    public static string filesPath = "";

    public static string javaPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
    public static string bedrockPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
      "Packages", "Microsoft.MinecraftUWP_8wekyb3d8bbwe");

    public static string[] arrayFont = {"À", "Á", "Â", "È", "Ê", "Ë", "Í", "Ó", "Ô", "Õ", "Ú", "ß", "ã", "õ", "ğ", "İ",
                                        "¹", "Œ", "œ", "Ş", "ş", "Ŵ", "ŵ", "ž", "ê", "", "", "", "", "", "", "",
                                        "", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/",
                                        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?",
                                        "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
                                        "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "\\", "]", "^", "_",
                                        "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                                        "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{", "|", "}", "~", "⌂",
                                        "Ç", "ü", "é", "â", "ä", "à", "å", "ç", "ê", "ë", "è", "ï", "î", "ì", "Ä", "Å",
                                        "È", "æ", "Æ", "ô", "ö", "ò", "û", "ú", "ÿ", "Ǔ", "Ü", "ø", "£", "Ø", "*", "ƒ",
                                        "á", "í", "ó", "ú", "ṅ", "Ṅ", "ḁ", "ọ", "¿", "®", "┐", "½", "¼", "¡", "«", "»",
                                        "░", "▒", "▓", "│", "┤", "╡", "╢", "╖", "╕", "╣", "║", "╗", "╝", "╜", "╛", "┐",
                                        "└", "┴", "┬", "├", "─", "┼", "╞", "╟", "╚", "╔", "╩", "╦", "╠", "═", "╬", "╧",
                                        "╨", "╤", "╥", "╙", "╘", "╒", "╓", "╫", "╪", "┘", "┌", "█", "▄", "▌", "▐", "▀",
                                        "α", "β", "Γ", "π", "Σ", "σ", "μ", "γ", "Θ", "θ", "Ω", "δ", "∞", "ϕ", "ε", "η",
                                        "≡", "±", "≥", "≤", "⌡", "⌠", "÷", "≈", "°", "▪", "·", "√", "ⁿ", "²", "■", ""};

    public static string pathTemp = Path.Combine(Path.GetTempPath(), "FontCraft");
    public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                @"yansaan\FontCraft");
    public static string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                @"yansaan\FontCraft");
  }
}
