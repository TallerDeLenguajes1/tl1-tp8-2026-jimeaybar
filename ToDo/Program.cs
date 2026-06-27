using Tareas;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();

int CantTareas;
Console.WriteLine("Ingrese la cantidad de tareas:");
string? numero = Console.ReadLine();
int.TryParse(numero, out CantTareas);

string[] descripcion = {"calculo1", "calculo2", "taller", "arquitectura", "algebra"};

for (int i = 0; i < CantTareas; i++)
{
    int duracion;
    Console.WriteLine($"Ingrese la duracion de la tarea numero{i +1} :");
    string? buff = Console.ReadLine();
    int.TryParse(buff, out duracion); //hasta aqui pido la duracion de la tarea
    Tarea nueva = new Tarea(i, descripcion[i], duracion, EstadoTarea.pendientes);
    // creo una nueva tarea para poder ingresar los datos de tipo tarea y 
    // luego insertarlos en tareas pendientes
    TareasPendientes.Add(nueva); //aqui paso los datos a tarea pendiente
}
//aqui recorro con un foreach para mostrar lo que tiene TareasPendientes
foreach (Tarea pendiente in TareasPendientes)
{
    Console.WriteLine(pendiente.mostrar());
}
    int cambiar;
do
{
    cambiar = 0;
    Console.WriteLine("Si desea pasar tareas pendientes a REALIZADAS (presione 1):");
    Console.WriteLine("Si NO desea pasar tareas pendientes a realizadas (presoine 0);");
    string? buff1 = Console.ReadLine();
    int.TryParse(buff1, out cambiar);

    if (cambiar == 1)
    {
        int id;
        Console.WriteLine("Ingrese el id de la tarea que quiere pasar a realizadas:");
        string? buff2 = Console.ReadLine();
        int.TryParse(buff2, out id);

        foreach (Tarea pendientes in TareasPendientes) //recorro pendientes para pasar la tarea
        {
            if(pendientes.TareaID == id)
            {
                pendientes.Estado = EstadoTarea.realizadas;
                TareasRealizadas.Add(pendientes);
            }
        }
        //remuevo afuera, adentro de foreach no funciona
        TareasPendientes.RemoveAt(id);
    }

} while (cambiar == 1);

Console.WriteLine("Ingrese una descripcion de tarea pendiente a buscar:");
string? buscarDescrip = Console.ReadLine();

foreach (Tarea pendientes in TareasPendientes)
{
    if(pendientes.Descripcion == buscarDescrip)
    {
        Console.WriteLine(pendientes.mostrar());
    }
}

//muestro realizadas y pendientes
Console.WriteLine("-------REALIZADAS-------");
foreach(Tarea realizadas in TareasRealizadas)
{
    Console.WriteLine(realizadas.mostrar());
}

Console.WriteLine("-------PENDIENTES-------");
foreach(Tarea pendientes in TareasPendientes)
{
    Console.WriteLine(pendientes.mostrar());
}