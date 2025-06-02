using System;

public class A04_02pg_Projecte
{
    //variables a inicialitzar
    bool HasGuanyat = false;
    bool jocIniciat = false;
    int midataulell = 63;
    int posJ1 = 0;
    int posJ2 = 0;
    Random llanca = new Random();
    int posicioj1 = 0;
    int posicioj2 = 0;
    int numerodau;
    int tornjugador1 = 0;
    int tornjugador2 = 0;
    int tornsaperdre1 = 0;
    int tornsaperdre2 = 0;

    public A04_02pg_Projecte()
    {   // Constructor.
    }

    public int menu()
    {  // Menú per inicialitzar el joc.

        Console.WriteLine("----------JOC DE LA OCA----------");
        Console.WriteLine("Pitja qualsevol tecla per iniciar el joc...");
        Console.ReadKey();

        inicialitzarJoc();

        return 0;
    }

    private void inicialitzarJoc()
    {   // mentres cap jugador hagi guanyat (el HasGuanyat és fals), s'executa el codi

        while (!HasGuanyat)
        {
            if (posicioj1 == 63 || posicioj2 == 63) // la variable HasGuanyat serà falsa mentre cap jugador tingui la exacta posició de 63
            {
                HasGuanyat = true;
            }
            else
            {
                J1(); //es fa jugar tant al jugador 1 com al dos mentre cap guanyi
                J2();
            }
        }

        Console.WriteLine(posicioj1 == 63 ? "Jugador 1 ha guanyat!" : "Jugador 2 ha guanyat!"); //misatje de guanyador
    }

    private void mostrarTaulell()
    {   // Mostrar el taulell per pantalla.

        Console.WriteLine();
        Console.WriteLine("*******************************************************");
        Console.WriteLine("                        Taulell                        ");
        Console.WriteLine("*******************************************************");

        for (int i = 1; i <= 63; i++)
        {
            Console.Write(" |" + i.ToString("D2") + "| "); //es printa número per número i es va comprovant la posició de la X i la Y cada vegada

            if (i == posicioj1 && i == posicioj2)
            {
                Console.Write(" XY ");
            }
            else
            {
                Console.Write("  ");
                if (i == posicioj1)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
                if (i == posicioj2)
                {
                    Console.Write("Y");
                }
                else
                {
                    Console.Write(" ");
                }
            } 
            

        }
        Console.WriteLine();
    }

    private int llancardau()
    {   // Llançar dau amb número aleatori entre 1 i 7
        return llanca.Next(1, 7);
    }

    private void J1()
    {   // Moviments jugador 1
        if (tornsaperdre1 > 0) //si té el torn perdut haurà d'esperar
        {
            Console.WriteLine("El jugador 1 no pot tirar durant aquest torn.");
            tornsaperdre1--;
        }
        else // si no té cap torn a perdre jugarà
        {
            Console.WriteLine("\nTorn Jugador 1.\nPrem qualsevol tecla per llançar el dau.");
            Console.ReadKey();

            numerodau = llancardau();
            Console.WriteLine($"Ha sortit el número: {numerodau}");

            posicioj1 += numerodau;
            posicioj1 = casillapasada(posicioj1); //s'ha de comprovar si s'ha passat de casilla amb la funció
            casillaespecial(ref posicioj1, ref tornsaperdre1); //s'ha de comprovar si ha caigut a una casella especial
            mostrarTaulell();
            Console.WriteLine($"\nLa posició del Jugador 1 és: {posicioj1}");
        }
    }

    private void J2()
    {   // Moviments jugador 2
        Console.WriteLine("--------------------------------------------------------");
        if (tornsaperdre2 > 0)
        {
            Console.WriteLine("El jugador 2 no pot tirar durant aquest torn.");
            tornsaperdre2--;
        }
        else
        {
            Console.WriteLine("\nTorn Jugador 2.\nPrem qualsevol tecla per llançar el dau.");
            Console.ReadKey();

            numerodau = llancardau();
            Console.WriteLine($"Ha sortit el número: {numerodau}");

            posicioj2 += numerodau;
            posicioj2 = casillapasada(posicioj2);
            casillaespecial(ref posicioj2, ref tornsaperdre2);
            mostrarTaulell();
            Console.WriteLine($"\nLa posició del Jugador 2 és: {posicioj2}");
        }
    }

    private int casillapasada(int posicio)
    {
        if (posicio > 63)
        {
            int excedent = posicio - 63;
            posicio = 63 - excedent; // Bounce back from the final position
            Console.WriteLine($"Has superat la casella 63! Tornes enrere a la casella {posicio}.");
        }
        return posicio;
    }

    private void casillaespecial(ref int posicio, ref int tornsAPerder)
    {

        if (posicio == 5)
        {
            posicio = 9;
            Console.WriteLine("Has caigut en una oca, vas a la casella 9.");
        }
        else if (posicio == 9)
        {
            posicio = 14;
            Console.WriteLine("Has caigut en una oca, vas a la casella 14.");
        }
        else if (posicio == 14)
        {
            posicio = 18;
            Console.WriteLine("Has caigut en una oca, vas a la casella 18.");
        }
        else if (posicio == 18)
        {
            posicio = 23;
            Console.WriteLine("Has caigut en una oca, vas a la casella 23.");
        }
        else if (posicio == 23)
        {
            posicio = 27;
            Console.WriteLine("Has caigut en una oca, vas a la casella 27.");
        }
        else if (posicio == 27)
        {
            posicio = 32;
            Console.WriteLine("Has caigut en una oca, vas a la casella 32.");
        }
        else if (posicio == 32)
        {
            posicio = 36;
            Console.WriteLine("Has caigut en una oca, vas a la casella 36.");
        }
        else if (posicio == 36)
        {
            posicio = 41;
            Console.WriteLine("Has caigut en una oca, vas a la casella 41.");
        }
        else if (posicio == 41)
        {
            posicio = 45;
            Console.WriteLine("Has caigut en una oca, vas a la casella 45.");
        }
        else if (posicio == 45)
        {
            posicio = 50;
            Console.WriteLine("Has caigut en una oca, vas a la casella 50.");
        }
        else if (posicio == 50)
        {
            posicio = 54;
            Console.WriteLine("Has caigut en una oca, vas a la casella 54.");
        }
        else if (posicio == 54)
        {
            posicio = 59;
            Console.WriteLine("Has caigut en una oca, vas a la casella 59.");
        }
        else if (posicio == 6)
        {
            posicio = 12;
            Console.WriteLine("Has caigut en un pont, vas a la casella 12.");
        }
        else if (posicio == 19)
        {
            tornsAPerder = 1;
            Console.WriteLine("Has caigut en la Fonda, perds un torn.");
        }
        else if (posicio == 26)
        {
            posicio = 53;
            Console.WriteLine("Has caigut als daus, vas a la casella 53.");
        }
        else if (posicio == 53)
        {
            posicio = 26;
            Console.WriteLine("Has caigut als daus, tornes a la casella 26.");
        }
        else if (posicio == 31)
        {
            tornsAPerder = 2;
            Console.WriteLine("Has caigut al pou i perds dos torns.");
        }
        else if (posicio == 42)
        {
            posicio = 39;
            Console.WriteLine("Has caigut al laberint, tornes a la casella 39.");
        }
        else if (posicio == 52)
        {
            tornsAPerder = 3;
            Console.WriteLine("Has caigut a la presó, perds 3 torns.");
        }
        else if (posicio == 58)
        {
            posicio = 1;
            Console.WriteLine("Has caigut en la mort... Tornes a l'inici.");
        }
        else
        {
            Console.WriteLine("Casella normal, no passa res.");
        }
    }
}