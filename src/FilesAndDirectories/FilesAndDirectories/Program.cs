void Spam()
{
    while (true)
    {
        Console.WriteLine("Choose action: 1 - create directories, 2 - delete all");
        int playerChoiceAction = Convert.ToInt32(Console.ReadLine());
        switch (playerChoiceAction)
        {
            case 1:
                for (int i = 0; i < 100; i++)
                {
                    Directory.CreateDirectory(@"C:\Users\d1810\Рабочий стол\sorry, it's a prank" + i);
                }

                break;

            case 2:
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\d1810\Рабочий стол\");
                var directories = directoryInfo.GetDirectories("sorry, it's a prank*");

                foreach (var directory in directories)
                {
                    directory.Delete();
                }

                break;

            default:
                Console.WriteLine("Incorrect comand");
                break;
        }
    }
}