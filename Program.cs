namespace crowdsourcing_mini_project_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        List<string> songTitle = new List<string>();
        List<string> songArtist = new List<string>();
        List<int> songDuration = new List<int>();
        int count = 0;
        bool shouldContinue = true;

        while(shouldContinue)
        {
            Console.Write("Enter the song's title: ");
            songTitle.Add(Console.ReadLine()!);

            Console.Write("Enter the artist: ");
            songArtist.Add(Console.ReadLine()!);

            Console.Write("How many minutes is the song: ");
            songDuration.Add(Convert.ToInt32(Console.ReadLine()!));
            songDuration[count] *= 60;

            Console.Write("How many seconds are in the song: ");
            songDuration[count] += Convert.ToInt32(Console.ReadLine()!);

            shouldContinue = Redo();
            count++;
            if(!shouldContinue)
            {
                break;
            }

        }

        Count(count, songTitle, songArtist, songDuration);
        
    }

    static void Count(int subCount, List<string> songTitle, List<string> songArtist, List<int> songDuration)
    {
        int totalDuration = 0;
        float average = 0;

        for(int i = 0; i < songDuration.Count; i++)
        {
            totalDuration += songDuration[i];
        }
        average = totalDuration / songDuration.Count;

        Console.WriteLine($"Total duration: {totalDuration}");
        Console.WriteLine($"Average duration: {average}");
        Console.WriteLine($"Longest song: ");
        Console.WriteLine($"Longest song: Shortest song: ");
    }

    static bool Redo()
    {
        while(true)
        {
            Console.WriteLine("Would you like to enter another song? y/n: ");
            string redo = Console.ReadLine()!.Trim().ToLower();

            switch (redo)
            {
                case "y":
                    return true;
                case "n":
                   return false;
               default:
                   Console.WriteLine("Invalid input. 'y' or 'n'");
                   break;
            }  
        }
        
    }
}
