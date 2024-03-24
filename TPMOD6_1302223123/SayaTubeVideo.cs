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
        Contract.Requires(title != null && title.Length <= 100, "Judul video harus memiliki panjang max 100 karakter dan tidak boleh null.");

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
        Contract.Ensures(count <= 10000000, "Inputan penambahan play count max 10.000.000.");
        Contract.Ensures(playCount <= int.MaxValue - count, "Penambahan play count melebihi max.");

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