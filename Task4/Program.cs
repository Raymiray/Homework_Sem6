string makeReversePhrase(string strNew)
{
    string[] strNewSplit = strNew.Split(); // ["Hello", "my", "world"]
    string res = "";

    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        res += strNewSplit[i] + " ";
    }
    return res;
}


Console.WriteLine("Enter some words: ");
string strNew = Console.ReadLine();
// string strNew = "Hello my world";
string res = makeReversePhrase(strNew);
Console.WriteLine(res);

