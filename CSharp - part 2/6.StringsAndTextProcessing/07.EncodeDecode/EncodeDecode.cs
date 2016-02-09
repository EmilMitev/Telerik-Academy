using System;
using System.Text;

/*  Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
    the second – with the second, etc. When the last key character is reached, the next is the first.
 */

class EncodeDecode
{
    static void Main()
    {
        string text = "You are the man bitch";
        string key = "asd";
        Console.WriteLine(text);
        Console.WriteLine("Encode text: {0}", Encode(text, key));
        Console.WriteLine("Decode the text: {0}", Decode(Encode(text, key), key));
    }

    static string Encode(string textToEncode, string key)
    {
        StringBuilder encode = new StringBuilder();
        int j = 0;
        for (int i = 0; i < textToEncode.Length; i++)
        {
            if (j == key.Length - 1)
            {
                j = 0;
            }
            encode.Append(Convert.ToChar(textToEncode[i] ^ key[j]));
            ++j;
        }
        return encode.ToString();
    }

    static string Decode(string textToDecode, string key)
    {
        StringBuilder decode = new StringBuilder();
        int j = 0;

        for (int i = 0; i < textToDecode.Length; i++)
        {
            if (j == key.Length - 1)
            {
                j = 0;
            }
            decode.Append(Convert.ToChar(textToDecode[i] ^ key[j]));
            ++j;

        }
        return decode.ToString();
    }
}