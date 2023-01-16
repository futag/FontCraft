using System.IO;
using System.Text;
using System.Security.Cryptography;

public class ClsEncryptDecryptFiles
{
  public ClsEncryptDecryptFiles(string _KEY)
  {
    KeyStr = _KEY;
  }

  private string KeyValue;
  public string KeyStr
  {
    get
    {
      return KeyValue;
    }
    set
    {
      KeyValue = value;
    }
  }

  public byte[] Encryption(string file)
  {
    byte[] input = File.ReadAllBytes(file);

    var AES = Aes.Create("AesManaged");
    SHA256 SHA256hash;
    SHA256hash = SHA256.Create();

    // Try
    AES.Key = SHA256hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(KeyStr));
    AES.Mode = CipherMode.ECB;
    ICryptoTransform DESEncrypter = AES.CreateEncryptor();
    byte[] Buffer = input;
    return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length);
  }

  public byte[] Decryption(string file)
  {

    byte[] input = File.ReadAllBytes(file);

    var AES = Aes.Create("AesManaged");
    SHA256 SHA256hash;
    SHA256hash = SHA256.Create();

    // Try
    AES.Key = SHA256hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(KeyStr));
    AES.Mode = CipherMode.ECB;
    ICryptoTransform DESDecrypter = AES.CreateDecryptor();
    byte[] Buffer = input;
    return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length);
  }
}
