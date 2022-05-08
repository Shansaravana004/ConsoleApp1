namespace ConsoleApp1
{
	internal class Task
	{
		static void Main(string[] args)
		{
			int inputLength = int.Parse(Console.ReadLine() ?? "");
			string arrayElementStr = Console.ReadLine() ?? "";
			string[] arrayString = arrayElementStr.Split(' ');
			string strresult = string.Empty;
			for (int i = 0; i < arrayString.Length; i++)
			{
				strresult += arrayString[i][arrayString[i].Length - 1].ToString();
			}

			if(int.Parse(strresult) % 10 == 0)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
			
		}
	}
}