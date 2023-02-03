using System.Security;
using System.Text;

const string stringExample = "Hi there.";
byte[] stringBytes = Encoding.UTF8.GetBytes(stringExample);

Console.WriteLine("UTF32 Example");

Console.WriteLine(BitConverter.ToString(stringBytes));

string decodedString = Encoding.UTF8.GetString(stringBytes);
Console.WriteLine(decodedString);

Console.WriteLine("UTF32 Example");

var utf32Bytes = Encoding.Convert(Encoding.UTF8, Encoding.UTF32, stringBytes);
Console.WriteLine(BitConverter.ToString(utf32Bytes));

string decodedUtf32String = Encoding.UTF32.GetString(utf32Bytes);
Console.WriteLine(decodedUtf32String);

var str = new SecureString();
str.AppendChar('d');
str.Dispose();
