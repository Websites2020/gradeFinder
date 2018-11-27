using System;

public class GradeFinder
{
	public static void Main()
	{
		double points;
		string stringPoints;

		Console.Out.Write("\nPlease enter your score out of 100: ");
		stringPoints = Console.ReadLine();
		points = Convert.ToDouble(stringPoints);

		if (points >= 90 && points <= 100)
			Console.Out.Write("You got an A!  Great Job\n");
		if (points >= 80 && points < 90)
			Console.Out.Write("You got a B.  Nice work\n");
		if (points >= 70 && points < 80)
			Console.Out.Write("You got a C.  Good effort\n");
		if (points >= 60 && points < 70)
			Console.Out.Write("You got a D.  You'll need to do better\n");
		if (points < 60)
			Console.Out.Write("You got a F.  Please see me\n");
	}
}