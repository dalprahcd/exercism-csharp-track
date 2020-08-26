using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var rna = nucleotide.ToCharArray();

        for (int i = 0; i < rna.Length; i++)
        {
            switch (rna[i])
            {
                case 'G':
                    rna[i] = 'C';
                    break;

                case 'C':
                    rna[i] = 'G';
                    break;

                case 'T':
                    rna[i] = 'A';
                    break;

                case 'A':
                    rna[i] = 'U';
                    break;
            }
        }

        return new string(rna);
    }
}