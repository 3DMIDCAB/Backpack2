using System;

namespace RyggsäckenTvå
{
    internal class Program
    {
        //Skapar en metod för MenyVal1 - Lägg till föremål i ryggsäcken.
        static void MenyVal1(string [] läggTillFöremål)
        {
            for (int i = 0; i < läggTillFöremål.Length; i++)
            {
                Console.Write("\tSkriv in ett föremål: ");
                läggTillFöremål[i] = Console.ReadLine();
            }
        }

        //Skapar en metod för MenyVal2 - Skriv ut alla föremål i ryggsäcken.
        static void MenyVal2(string [] läggTillFöremål)
        {
            //Informerar användaren med en utskrift att dessa föremål finns i ryggsäcken.
            Console.WriteLine("\n\tDessa föremål finns nu i ryggsäcken");

            //Skapar en for loop som loopar så länge som index är mindre än antalet element i vektorn, med Console.WriteLine så skrivs 
            //innehållet i ryggsäcken ut. 
            for (int i = 0; i < läggTillFöremål.Length; i++)
            {
                Console.WriteLine("\t" + läggTillFöremål[i]);
            }
        }

        //Skapar en metod för MenyVal3 - Sök ett föremål.
        static void MenyVal3(string [] läggTillFöremål)
        {
            //Ber användaren ange ett föremål att söka efter i ryggsäcken
            Console.Write("\tSök ett föremål: ");

            //Deklarerar en string variabel med namnet sökFöremål som tilldelas värde från användarens input. 
            string sökFöremål = Console.ReadLine();

            //Deklarerar en bool variabel med namnet sökning och tilldelar värdet falskt, för att inte skriva ut varje index vid loopen. 
            //Variabeln blir sann om användarens sökord och ett föremål i ryggsäcken är lika. 
            bool sökning = false;

            //Skapar en for loop som loopar igenom ryggsäcken för att se vad som finns i den.
            for (int i = 0; i < läggTillFöremål.Length; i++)
            {
                //Använder en if sats och kontrollerar om variabeln sökFöremål med versaler är samma som något av,
                //föremålen i ryggsäcken och har även där versaler för tillagda föremål.
                if (sökFöremål.ToUpper() == läggTillFöremål[i].ToUpper())
                {
                    //Om sant så skriver programmet ut att föremålet finns på plats x i ryggsäcken
                    sökning = true;
                    Console.WriteLine("\t" + sökFöremål + " finns på plats " + i + " i ryggsäcken!");
                }
            }
            //Om variabeln sökning är falsk så skriver programmet ut att föremålet ej finns i ryggsäcken. 
            if (sökning == false)
            {
                Console.WriteLine("\tFöremålet finns ej i ryggsäcken");
            }
        }

        //Skapar en metod för MenyVal4 - Plocka ur alla föremål ur ryggsäcken.
        static void MenyVal4(string [] läggTillFöremål)
        {
            //Informerar användaren att föremålen plockas ur ryggsäcken
            Console.WriteLine("Plockar ur alla föremål i ryggsäcken");
            //Använder metoden Array.Clear för att tömma ryggsäcken på föremål.
            Array.Clear(läggTillFöremål, 0, läggTillFöremål.Length);
        }

        //Skapar en metod för MenyVal5 - Avsluta programmet (lite onödigt kanske med tanke på så få kodrader)
        static void MenyVal5()
        {
            //Information till användaren hur den avslutar programmet.
            Console.WriteLine("\tProgrammet avslutas, genom att trycka på enter!");
            //Använder Console.ReadLine för att användaren ska trycka på enter för att avsluta programmet.
            Console.ReadLine();
        }

        //Skapar en metod för att skriva ut information till användaren, som används så länge ryggsäcken är tom.
        static void InformationVidFel()
        {
            //Information till användaren att den måste lägga till föremål eftersom ryggsäcken är tom.
            Console.WriteLine("\tDu måste lägga till föremål i ryggsäcken först!");
        }

        //Skapar en metod för att skriva ut information till användaren om den skriver in annat än de tillåtna siffrorna enligt menyvalet. 
        static void InformationVidFelaktigtMenyVal()
        {
            //Information till användaren att ange en siffra 1 till 5.
            Console.WriteLine("\tDu måste välja en siffra 1-5!");
        }   

        //Huvudprogrammet startar här:
        static void Main(string[] args)
        {
            //Deklarerar en bool variabel med namnet sluta och tilldelar värdet sann.
            bool sluta = true;

            //Deklarerar en string vektor med plats för fem element.
            string[] läggTillFöremål = new string[5];

            //Deklarerar en bool variabel med namnet har LagtTillFöremål som jag använder för att kontrollera att ryggsäcken inte är tom,
            //om användaren försöker att söka i ryggsäcken då programmet startar, variabeln blir sann om användaren har gjort menyval 1.
            bool harLagtTillFöremål = false;

            //Skapar en while loop som loopar så länge användaren inte väljer att avsluta.
            while (sluta)
            {
                //Skapar en menystruktur där användaren väljer funktion genom att ange siffran för funktionen.
                //Använder en Consol.WriteLine för att skapa en tom rad och får luft mellan. 
                Console.WriteLine("");
                Console.WriteLine("\tVälkommen till Ryggsäckens meny!");
                Console.WriteLine("\t[1] Lägg till föremål");
                Console.WriteLine("\t[2] Skriv ut alla föremål i ryggsäcken");
                Console.WriteLine("\t[3] Sök föremål i ryggsäcken");
                Console.WriteLine("\t[4] Plocka ur alla föremål ur ryggsäcken");
                Console.WriteLine("\t[5] Avsluta programmet");
                Console.Write("\tVälj genom att ange en siffra 1-5: ");

                //Deklarerar en int variabel med namnet menyVal och tilldelar värdet 0 för kommande felhantering med TryParse. 
                int menyVal = 0;

                // Deklarerar en bool variabel med namn lyckadTryParse för att kontrollera att användarens input är en siffra, annars får
                // användaren ett felmeddelande.
                bool lyckadTryParse = Int32.TryParse(Console.ReadLine(), out menyVal);

                //Använder en if-sats för att kontrollera om användarens input var en siffra genom att,
                //variabeln lyckadTryParse blir sann för att då exekvera switch satsen. 
                if (lyckadTryParse)
                {
                    //Skapar en switch sats för hantering av användarens menyval och dess funktion. 
                    switch (menyVal)
                    {
                        //Om användarens val är 1 : Lägg till föremål i ryggsäcken.
                        case 1:

                            //Tilldelar variabeln harLagtTillFöremål värdet sann eftersom användaren har valt att lägga till föremål 
                            //i ryggsäcken, använder denna variabel för felhantering i koden för case2, 3 och 4. 
                            harLagtTillFöremål = true;

                            //Anropar metoden MenyVal1. 
                            MenyVal1(läggTillFöremål);

                            break;

                        //Om användarens val är 2: Skriv ut alla föremål som finns i ryggsäcken. 
                        case 2:

                            //Kontrollerar med en if-sats om användaren har börjat programmet med att lägga till föremål i ryggsäcken,
                            //innan försöker att söka efter föremål. 
                            if (harLagtTillFöremål == true)
                            {
                                //Anropar metoden MenyVal2.
                                MenyVal2(läggTillFöremål);
                            }
                            //I de fall där användaren inte har lagt till något i ryggsäcken så skriver programmet ut,
                            //att användren måste lägga till föremål i ryggsäcken först.                             
                            else
                            {
                                //Anropar metoden InformationVidFel som visar information till användaren.
                                InformationVidFel();
                            }
                            break;

                        //Om användarens val är 3: Sök föremål i ryggsäcken.
                        case 3:

                            //Kontrollerar med en if-sats om användaren har börjat programmet med att lägga till föremål i ryggsäcken,
                            //innan försöker att söka efter föremål. 
                            if (harLagtTillFöremål == true)
                            {
                                //Anropar metoden MenyVal3.
                                MenyVal3(läggTillFöremål);
                            }
                        //I de fall där användaren inte har lagt till något i ryggsäcken så skriver programmet ut,
                        //att användren måste lägga till föremål i ryggsäcken först.                                    
                        else
                        {
                                //Anropar metoden InformationVidFel som visar information till användaren.
                                InformationVidFel();
                        }

                        break;

                        //Om användarens val är 4: Plocka ur alla föremål ur ryggsäcken.
                        case 4:

                            //Använder en if sats för att kontrollera om det finns några föremål i ryggsäcken.
                            if (harLagtTillFöremål == true)
                            {
                                //Anropar metoden MenyVal4.
                                MenyVal4(läggTillFöremål);

                                harLagtTillFöremål = false; //Sätter variabeln till falsk eftersom ryggsäcken blir tömd
                            }
                            else
                            {
                                //Anropar metoden InformationVidFel som visar information till användaren.
                                InformationVidFel();
                            }

                            break;

                        //Om användaren väljer att avsluta så skriver programmet ut instruktion för hur man avslutar.
                        case 5:
                            {
                                //Anropar metoden MenyVal5.
                                MenyVal5();
                                sluta = false;
                            }
                            break;

                        //För de fall användaren skriver in fel så meddelas användaren om att välja en siffra 1 till 4.                        
                        default:
                            //Anropar metoden InformationVidFelaktigtMenyVal som visar information till användaren.
                            InformationVidFelaktigtMenyVal();

                            break;
                    }
                }
                //I de fall användaren skriver annat än siffror så skriver programmet ut att användaren måste ange en siffra.                
                else
                {
                    //Anropar metoden InformationVidFelaktigtMenyVal som visar information till användaren.
                    InformationVidFelaktigtMenyVal();
                }

            }

        }
    }
}



