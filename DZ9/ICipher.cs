namespace DZ9
{
    internal interface ICipher
    {
        string Encode(string str);
        string Decode(string str);
    }
}