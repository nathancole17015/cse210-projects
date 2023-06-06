class Program
{
    static void Main()
    {
        Reference reference = new Reference("John", 3, "16");

        string words = "god gave his only begotten son that whoever";

        Scripture scripture = new Scripture(reference, words);
        scripture.Memorize();
    }
}
