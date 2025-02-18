namespace crowdsourcing_mini_project_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        List<string> songTitle = new List<string>();
        List<string> songArtist = new List<string>();
        List<int> songDuration = new List<int>();

        while(true)
        {
            for(int i, i=0; i<4; i++)
            {

            }
            Console.Write("Enter the song's title: ");
            songTitle.Add(Console.ReadLine()!);

            Console.Write("Enter the artist: ");
            songArtist.Add(Console.ReadLine()!);

            Console.Write("How many minutes is the song");
            songDuration.Add(Convert.ToInt32(Console.ReadLine()!));

            Console.Write("How many seconds are in the song");


            Redo();
        }
    }

    static bool Redo()
    {
        while(true)
        {
            Console.WriteLine("Would you like to enter another song? y/n");
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
