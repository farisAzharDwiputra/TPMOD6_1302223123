// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = null;

        try
        {
            video = new SayaTubeVideo("Tutorial Design By Contract - Faris Azhar Dwiputra");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            if (video != null)
            {
                video.PrintVideoDetails();
            }
        }
    }
}