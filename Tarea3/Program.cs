// See https://aka.ms/new-console-template for more information

int tamano = 2;
string[] nombre = new string[tamano];
int[] edad = new int[tamano];
string[] cita = new string[tamano];
int opcion = 0;

menu();

void inicializar()
{
    nombre = Enumerable.Repeat("", tamano).ToArray<string>();
    cita = Enumerable.Repeat("", tamano).ToArray<string>();
    edad = Enumerable.Repeat(0, tamano).ToArray<int>();
    Console.WriteLine("Los arreglos han sido inicializados");
    Console.ReadKey();
    Console.Clear();
}

void Agregar()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    for (int i = 0; i < 1; i++)
    {
        Console.Write("Ingrese el nombre del paciente: ");
        nombre[i] = Console.ReadLine();

        Console.Write("Ingrese la edad del paciente: ");
        edad[i] = int.Parse(Console.ReadLine());
    }
}


void MostrarCita(string nombreBuscado)
{
    for (int i = 0; i < nombre.Length; i++)
    {
        if (nombreBuscado.Equals(nombre[i]))
        {
            Console.WriteLine($"Cita del paciente {nombre[i]}: {cita[i]}");
            return;
        }
    }
    Console.WriteLine($"El paciente {nombreBuscado} no tiene asignada ninguna cita");
}



void Consulta()
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    bool encontrado = false;
    Console.WriteLine("Digite el nombre del paciente a buscar");
    string nomb = Console.ReadLine();
    for (int i = 0; i < nombre.Length; i++)
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.WriteLine($"La edad del paciente {nomb} es {edad[i]}");
            encontrado = true;
            MostrarCita(nomb);  // Llamar a la nueva función
        }
    }
    if (!encontrado)
    {
        Console.WriteLine($"El paciente {nomb} no existe");
    }
}


void Reporte()
{

    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("nombre      Edad");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("-----     -----");
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nombre[i]}   {edad[i]}");
    }
}
void AsignarCita()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Digite el nombre del paciente para asignar la cita:");
    string nomb = Console.ReadLine();
    for (int i = 0; i < nombre.Length; i++)
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.Write("Ingrese la fecha de la cita: ");
            cita[i] = Console.ReadLine();
            Console.WriteLine($"Cita asignada correctamente a {nombre[i]} para el {cita[i]}");
            return;
        }
    }
    Console.WriteLine($"El paciente {nomb} no existe");
}

void menu()
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("*****CONSULTORIO MEDICO***");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1-Inicializar arreglos");
        Console.WriteLine("2-Ingrese paciente");
        Console.WriteLine("3-Consultar paciente");
        Console.WriteLine("4-Reporte");
        Console.WriteLine("5-Asignar cita");
        Console.WriteLine("6-Salir");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Digite una opcion");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {

            case 1: inicializar(); break;
            case 2: Agregar(); break;
            case 3: Consulta(); break;
            case 4: Reporte(); break;
            case 5: AsignarCita(); break;
            default:
                break;

        }
    } while (opcion != 6);
}