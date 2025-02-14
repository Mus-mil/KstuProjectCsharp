namespace KstuProjectCsharp
{
    internal static class Program03
    {
        public static void GetImages()
        {
            int numImages = 53;
            int numI = 3;
            int lineCount = 0;
            while (numImages >= 0) 
            {
                lineCount++;
                numImages-=numI;
            }
            Console.Write(lineCount);
        }
    }
}