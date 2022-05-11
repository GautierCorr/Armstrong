using System;

namespace Armstrong
{
    class Program
    {
	// Rôle : Indique si un nombre est de Armstrong
        // Paramètres d'entrée   
        // - nombre : entier à tester (en entrée)
        // Valeur de sortie : True si nombre Armstrong sinon False 
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
            int nombre;
	    Console.Write("Saissisez un nombre : ");
	    try {
			nombre  = Convert.ToInt32(Console.ReadLine());
            }
	    catch(Exception e)
	    {
		Console.WriteLine(e.Message); 
	        return;
	    }
	    // Ici, tout va bien
	    Console.WriteLine(Armstrong(nombre));
        }
    }
}
