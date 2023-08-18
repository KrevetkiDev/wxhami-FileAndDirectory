namespace FilesAndDirectories;

public static class ArrayExtensions
{
    public static void Sort(this FileInfo[] fileInfos)
    {
        for (int i = 0; i < fileInfos.Length - 1; i++)
        {
            for (int j = i + 1; j < fileInfos.Length; j++)
            {
                if (fileInfos[i].LastWriteTimeUtc > fileInfos[j].LastWriteTimeUtc)
                {
                    var temp = fileInfos[i];
                    fileInfos[i] = fileInfos[j];
                    fileInfos[j] = temp;
                }
            }
        }
    }
}