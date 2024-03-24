using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {


        this.id = GenerateId();
        this.title = title;
        this.playCount = 0;
    }

    private int GenerateId()
    {
        Random IdRandom = new Random();
        return IdRandom.Next(17064, 99999);
    }

    public void IncreasePlayCount(int count)
    {


        try
        {
            checked
            {
                playCount = playCount + count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Penambahan pada play count melebihi batas maksimal.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}