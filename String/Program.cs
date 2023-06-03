class Program
{
    static void Main(string[] args)
    {
        string original = "abcde FGHI ABC abc DEFG    -";

        Console.WriteLine(original);
        string s1 = original.ToUpper(); //todas maiúsculas
        Console.WriteLine("com ToUpper = " + s1);

        string s2 = original.ToLower();
        Console.WriteLine("com ToLower = " + s2);

         string s3 = original.Trim();
        Console.WriteLine("Com trim = " + original.Trim());

        int n1 = original.IndexOf("bc");
        Console.WriteLine("IndexOf = " + n1);


        int n2 = original.LastIndexOf("bc");
        Console.WriteLine("IndexOf = " + n2);

        string s4 = original.Substring(3);
        Console.WriteLine("Substring(3) = " + s4);

        string s5 = original.Substring(3,5);
        Console.WriteLine("Substring(3,5) = " + s5);

        string s6 = original.Replace("a", "X");
        Console.WriteLine("Replace = " + s6);

        string s7 = original.Replace("abc", "XY");
        Console.WriteLine("Replace = " + s7);

        bool b1 = String.IsNullOrEmpty(original);
        Console.WriteLine("IsNullOrEmpty = " + b1);

        bool b2 = String.IsNullOrWhiteSpace(original);
        Console.WriteLine("IsNullOrWhiteSpace = " + b2);







    }
}