Censor();

void Censor()
{
    List<string> StopWords = new List<string>()
    {
        "блят",
        "еб",
        "муда",
        "ебан",
        "ебучий",
        "хуи",
        "хуя",
        "долб",
        "хуй",
        "муди",
        "бляд"
    };
    Console.WriteLine("Specify the path to the directory");
    string Path = Console.ReadLine();
    string newWord = "***";
    FileInfo fileInfo = new FileInfo(Path);
    
    Process(@"C:\Users\d1810\Рабочий стол\папка\случай в казино.txt");

    void Process(string path)
    {
        path = Path;

        string textForCensor = File.ReadAllText(path);
        
        
        foreach (var word in StopWords)
        {
            
           textForCensor = textForCensor.Replace(word, newWord, StringComparison.InvariantCultureIgnoreCase);
           
        }
        File.WriteAllText(fileInfo.DirectoryName + "\\New.txt", textForCensor);
    }
}