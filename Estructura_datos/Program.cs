string opcion;
do
{
    Console.WriteLine("\n==================ESTRUCTURA DE DATOS===============");
    Console.WriteLine("1. ");
    Console.WriteLine("2. ");
    Console.WriteLine("3. Diccionarios");
    Console.WriteLine("4. Práctico Experimental III");
    Console.WriteLine("5. ");
    Console.WriteLine("6. ");
    Console.WriteLine("7. ");
    Console.WriteLine("8. ");
    Console.WriteLine("9. Salir");
    Console.WriteLine("======================================================\n");
    Console.WriteLine("\n¿Qué opción deseas elegir?\n");
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
            Console.WriteLine("Funcionalidad 1 aún no implementada.");
            break;
        case "2":
            Console.WriteLine("Funcionalidad 2 aún no implementada.");
            break;
        case "3":
            Diccionarios.MenuInteractivo();
            break;
        case "4":
            PracticoExperimental_3.Ejecutar();
            PracticoExperimental_3.MenuInteractivo();
            break;
        case "5":
            Console.WriteLine("Funcionalidad 5 aún no implementada.");
            break;
        case "6":
            Console.WriteLine("Funcionalidad 6 aún no implementada.");
            break;
        case "7":
            Console.WriteLine("Funcionalidad 7 aún no implementada.");
            break;
        case "8":
            Console.WriteLine("Funcionalidad 8 aún no implementada.");
            break;
        case "9":
            Salida.Salir();
            break;
        default:
            Console.WriteLine("⚠️ Opción no válida. Intenta nuevamente.");
            break;
    }
} while (opcion != "9");
