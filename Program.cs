using System;

namespace Armstrong
{
    class Program
    {
	static bool Armstrong(int nombre)
	{
		int centaine,dizaine,unite,reste;
		centaine = (nombre / 100);
		reste = (nombre % 100);
		dizaine = (reste / 10);
		unite = reste % 10;
		
		if (centaine*centaine*centaine + dizaine*dizaine*dizaine + unite*unite*unite == nombre)
		{
			return true;
		} else 
			return false;
	}

        static void Main(string[] args)
        {
            Console.WriteLine(Armstrong(153));
        }
    }
}
