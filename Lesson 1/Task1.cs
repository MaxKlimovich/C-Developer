namespace DeveloperC;

internal class Task1
{
    public void Task(string[] args)
    {
        if (args.Length > 0)
        {
            int[] array = Array.ConvertAll(args, int.Parse);
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            System.Console.WriteLine($"min = {min}");
        }
        else
        {
            System.Console.WriteLine("No arguments");
        }

    }
}