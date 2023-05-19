using System;

public class Program
{
    static bool IsValidSequence(string halfDNASequence) =>
        !halfDNASequence.Any(nucleotide => !"ATCG".Contains(nucleotide));

    static string ReplicateSequence(string halfDNASequence) =>
        string.Concat(halfDNASequence.Select(nucleotide => "TAGC"["ATCG".IndexOf(nucleotide)]));

    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (IsValidSequence(input))
            {
                Console.WriteLine("Current half DNA sequence: " + input);
                Console.WriteLine("Do you want to replicate it? (Y/N):");

                string str = Console.ReadLine();
                while (str != "Y" && str != "N")
                {
                    Console.WriteLine("Please input Y or N.");
                    str = Console.ReadLine();
                }

                if (str == "Y")
                {
                    string output = ReplicateSequence(input);
                    Console.WriteLine("Replicated half DNA sequence: " + output);
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.WriteLine("Do you want to process another sequence? (Y/N):");
            string str2 = Console.ReadLine();

            while (str2 != "Y" && str2 != "N")
            {
                Console.WriteLine("Please input Y or N.");
                str2 = Console.ReadLine();
            }

            if (str2 == "N")
            {
                break;
            }
        }
    }
}

