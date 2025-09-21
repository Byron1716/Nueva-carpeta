public class PracticoExperimental_3
{
    static HashSet<string> ClubesdeFutbol = new HashSet<string>();         //Creamos un conjunto que se llama ClubesdeFutbol en donde se almacenarán el nombre de los clubes en donde inscribiremos a nuestros jugadores
    static HashSet<string> ConjuntoJugadores = new HashSet<string>();       //Creamos el conjunto que contendrá a diferentes jugadores
    static List<string> torneoLigadeCampeones = new List<string>();         //
    static Dictionary<string, HashSet<string>> Equipos = new Dictionary<string, HashSet<string>>();         // Diccionario para asignar jugadores a cada equipo
    static List<string> jugadoresDisponibles = ConjuntoJugadores.ToList();                                 // Convertir conjunto de jugadores a lista para acceso aleatorio
    public static void Ejecutar()
    {
        int numero = 0;


        while (numero < 264)                                            //Creamos un bucle para que se creen 264 jugadores, esto debido a que crearemos 12 equipos y en cada equipo se inscribiran a 22 jugadores
        {
            numero++;
            string jugador = $"Jugador #{numero}";                      //Agreagamos la palabra jugador junto a un número del 1 al 264
            ConjuntoJugadores.Add(jugador);                             //Agregamos cada jugador al conjunto "ConjuntoJugadores"
        }
        // Convertimoes el conjunto en lista después de llenarlo
        jugadoresDisponibles = ConjuntoJugadores.ToList();

        ClubesdeFutbol.Add("Barcelona F.C");
        ClubesdeFutbol.Add("Real Madrid");
        ClubesdeFutbol.Add("A.C Milán");
        ClubesdeFutbol.Add("Liverpool");
        ClubesdeFutbol.Add("Manchester United");
        ClubesdeFutbol.Add("Arsenal");
        ClubesdeFutbol.Add("Atlético de Madrid");
        ClubesdeFutbol.Add("Bayern München");
        ClubesdeFutbol.Add("PSG");
        ClubesdeFutbol.Add("Chelsea");
        ClubesdeFutbol.Add("Manchester City");
        ClubesdeFutbol.Add("Juventus");

        Random rnd = new Random();                                                                      // Creamos un random para escoger jugadores al alzar para cada equipo

        foreach (string club in ClubesdeFutbol)                                                         //Hacemos un foreach 
        {
            Equipos[club] = new HashSet<string>();

            while (Equipos[club].Count < 22)                                    //Creamos un bucle para que se agreguen 22 jugadores por equipo sin que ningún jugador se repita en 2 clubes
            {
                int indice = rnd.Next(jugadoresDisponibles.Count);              //Creamos una variable de tipo entero en donde vamos a asignar un índice a cada elemento de la lista jugadoresDisponibles aleatoriamente
                string jugadorSeleccionado = jugadoresDisponibles[indice];      //Guardamos la selección anterior por índice en una variable de tipo entero 

                Equipos[club].Add(jugadorSeleccionado);                         //Agregamos a cada jugador que se elija de manera aleatoria y lo añadimos a un club
                jugadoresDisponibles.RemoveAt(indice);                          // Eliminar para evitar duplicados
            }
        }

    
    }
    public static void AgregarEquipo()
    {
        Console.WriteLine("\nEscribe el equipo que deseas agregar:");
        string nuevoEquipo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nuevoEquipo))
            {
                Console.WriteLine("⚠️ No puedes dejar la opción vacía. Intenta nuevamente.");
                Console.WriteLine("\nEscribe el equipo que deseas agregar:");
                nuevoEquipo = Console.ReadLine();
            }
        if (ClubesdeFutbol.Contains(nuevoEquipo))                                    //Ponemos una condición para que analice si la palabra llave es existente
        {
            Console.WriteLine($"❌ El equipo '{nuevoEquipo}' ya existe y no se puede ingresar.");
        }
        else
        {
            Console.WriteLine($"✅ El equipo '{nuevoEquipo}' fue agregado correctamente.");
            ClubesdeFutbol.Add(nuevoEquipo);
        }
    }
    public static void MostrarEquipos()
    {
        Console.WriteLine("\nLista de los equipos de fútbol\n");
        int index = 1;
        foreach (var Equipo in ClubesdeFutbol)
        {
            Console.WriteLine($"{index}.- {Equipo}");
            index++;
        }
    }
    public static void AgregarJugador()
    {
        Console.WriteLine("\nEscribe el nombre del jugador que deseas agregar:");
        string nuevoJugador = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nuevoJugador))
            {
                Console.WriteLine("⚠️ No puedes dejar la opción vacía. Intenta nuevamente.");
                Console.WriteLine("\nEscribe el equipo que deseas agregar:");
                nuevoJugador = Console.ReadLine();
            }
        if (ConjuntoJugadores.Contains(nuevoJugador))
        {
            Console.WriteLine($"❌ El nombre '{nuevoJugador}' ya existe y no se puede ingresar.");
        }
        else
        {
            Console.WriteLine($"✅ El nombre '{nuevoJugador}' fue agregado correctamente.");
            ConjuntoJugadores.Add(nuevoJugador);
            jugadoresDisponibles.Add(nuevoJugador);

        }
    }
    public static void MostrarJugadores()
    {
        Console.WriteLine("\nLista de los jugadores\n");
        foreach (var equipo in Equipos)                                             //Creamos un ciclo para que se impriman todas las listas de los equipos
        {
            int number = 0;
            Console.WriteLine();                                                        //Finalmente creamos una varibale de tipo número para enumerar a los jugadores de cada club
            Console.WriteLine($"\n{equipo.Key} tiene los siguientes jugadores:");    //Imprimimos los jugadores que cada equipo tienen
            foreach (var jugador in equipo.Value)
            {
                number++;                                                           //aumentamos en uno cada vez que la varibale haga este ciclo
                Console.WriteLine($" {number}.- {jugador}");                        //Finalemnte imprmimos el enumerado del equipo mas el nombre del jugador
            }
            if (!torneoLigadeCampeones.Contains(equipo.Key))
            {
                torneoLigadeCampeones.Add(equipo.Key);                                                                          //agregamos cada equipo al Torneo
                Console.WriteLine($"\nEl equipo {equipo.Key} fue agregado correctamente al torneo LIGA DE CAMPEONES");              // imprimos la confirmación de que cada equipo fue agregado correctamente
            }
            
        }
    }
    
    public static void MostrarTorneo()
    {
        Console.WriteLine("\nEquipos inscritos en la LIGA DE CAMPEONES:");
        foreach (var equipo in torneoLigadeCampeones)
        {
            Console.WriteLine($"- {equipo}");
        }
    }

    public static void Salir()
    {
        Console.WriteLine("👋Hasta Luego");
    }
    public static void MenuInteractivo()
    {
        string opcion;

        do
        {
            Console.WriteLine("\n====================== MENÚ =======================\n");
            Console.WriteLine("1. Agregar Equipo");
            Console.WriteLine("2. Mostrar lista de equipos");
            Console.WriteLine("3. Agregar jugador");
            Console.WriteLine("4. Mostrar lista de jugadores");
            Console.WriteLine("5. Mostrar equipos del torneo");
            Console.WriteLine("6. Salir");
            Console.WriteLine("===================================================");
            Console.WriteLine("\nEscribe una opción:");

            opcion = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(opcion))
            {
                Console.WriteLine("⚠️ No puedes dejar la opción vacía. Intenta nuevamente.");
                Console.WriteLine("Escribe una opción:");
                opcion = Console.ReadLine();
            }

            switch (opcion)
            {
                case "1":
                    AgregarEquipo();
                    break;
                case "2":
                    MostrarEquipos();
                    break;
                case "3":
                    AgregarJugador();
                    break;
                case "4":
                    MostrarJugadores();
                    break;
                case "5":
                    MostrarTorneo();
                    break;
                case "6":
                    Salir();
                    break;
                default:
                    Console.WriteLine("⚠️ Opción no válida. Intenta nuevamente.");
                    break;
            }

        } while (opcion != "6");
    }

}