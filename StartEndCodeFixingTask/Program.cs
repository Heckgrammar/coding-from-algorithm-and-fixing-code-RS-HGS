namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#
           int startyear = 0;
		int endyear = 0;
		int difference = -1;
		bool validchoice = false;
		do
		{
		 difference = -1;
		Console.WriteLine("Enter a start year");
		 startyear = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter an end year");
		 endyear = Convert.ToInt32(Console.ReadLine());
		   if (startyear >= endyear)
		   {Console.WriteLine("Start year must be before end year");}
			else if (startyear >= 2000)
			{Console.WriteLine("Start year must be before 2000");}
				else
				{ validchoice = true;}
		}
		while
			( validchoice == false);
		difference = endyear - startyear;
		Console.WriteLine(difference);
        }
    }
}
