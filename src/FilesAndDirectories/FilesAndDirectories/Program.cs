void Spam()
{
    while (true)
    {
        Console.WriteLine("Choose action: 1-create directories, 2- delete all");
        int playerChoiceAction = Convert.ToInt32(Console.ReadLine());
        if (playerChoiceAction == 1)
        {
            for (int i = 0; i < 100; i++)
            {
                Directory.CreateDirectory(@"C:\Users\d1810\Рабочий стол\sorry, it's a prank" + i);
            }
        }
        else
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\d1810\Рабочий стол\");
            var directories = directoryInfo.GetDirectories("sorry, it's a prank*");

            foreach (var directory in directories)
            {
                directory.Delete();
            }
        }
    }
}