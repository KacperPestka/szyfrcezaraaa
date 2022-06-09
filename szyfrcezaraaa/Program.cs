
using System.Text;

string text;
int key;
string kodCezara(string t, int k)
{
    t = t.ToUpper();
    string encryptedText = "";
    for (int i = 0; i < t.Length; i++)
    {
        char letter = t[i];
        int letterCode = (int)letter;
        letterCode += k;
        letterCode = ((letterCode - 65) % 26) + 65;
        char encryptedLetter = (char)letterCode;
        encryptedText += encryptedLetter;
    }
    return encryptedText;
}
Console.WriteLine("Tekst który ma być zaszyfrowany");
text = Console.ReadLine() ?? "";
Console.WriteLine("O ile przesunac litery:");
key = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Zaszyfrowany tekst: " + kodCezara(text, key));
