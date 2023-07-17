// C# code for triangular
// patterns of alphabets
using System;

class GFG
{
	static public void Main ()
	{
		
		int i, j, n = 5;
		for (i = 1; i <= n; i++)
		{
			int ch = 65;
			for (j = 1; j <= i; j++)
			{
				Console.Write(((char)ch));
				ch++;
			}
		Console.WriteLine();
		}
	}
}
