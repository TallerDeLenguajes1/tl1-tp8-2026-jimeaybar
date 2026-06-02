using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Tareas;

Console.WriteLine("Desea ingresar una tarea?: \n1.Si \n2.No");

List <Tarea> tareasPendientes= new ();
List <Tarea> tareasRealizadas= new ();

if (int.TryParse(Console.ReadLine(), out int opcion))
{
    int id= 1000;
    while (opcion == 1)
    {
        Tarea tareas = new();
        tareas.TareaId = id;
        Console.WriteLine("Ingrese una Descripcion:");
        string? desc = Console.ReadLine();
        tareas.Descripcion = desc;
        Console.WriteLine("Ingrese una Duracion:");
        int dura = int.Parse(Console.ReadLine()!);

        while(dura < 10 || dura > 100)
        {
            Console.WriteLine("Ingrese una Duracion valida entre 10 y 100:");
            dura = int.Parse(Console.ReadLine()!);
        }

        tareas.Duracion = dura; 
        tareasPendientes.Add(tareas);
        id ++;

        Console.WriteLine("Desea ingresar otra tarea?: \n1.Si \n2.No");
        opcion = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine("Tareas Pendientes:\n");
    foreach (Tarea item in tareasPendientes)
    {
        Console.WriteLine($"{item.TareaId}\n{item.Descripcion}\n{item.Duracion}");
    }
    
    Console.WriteLine("Desea realizar alguna tarea?: \n1.Si \n2.No");
    if(int.TryParse(Console.ReadLine(), out int opcion2))
    {
        while (opcion2 == 1)
        {
            Console.WriteLine("Ingrese el Id de la tarea a realizar:");
            int id2 = int.Parse(Console.ReadLine()!);
            var mover = new Tarea();

            foreach(Tarea item in tareasPendientes)
            {
                if(item.TareaId == id2) {
                    tareasRealizadas.Add(item);
                    mover= item;
                }    

            }
            tareasPendientes.Remove(mover);

            Console.WriteLine("Desea realizar otra tarea?: \n1.Si \n2.No");
            opcion2 = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Tareas Realizadas:\n");
        foreach (Tarea item in tareasRealizadas)
        {
            Console.WriteLine($"{item.TareaId}\n{item.Descripcion}\n{item.Duracion}");
        }

        Console.WriteLine("Tareas Pendientes:\n");
        foreach (Tarea item in tareasPendientes)
        {
            Console.WriteLine("Tareas Pendientes:\n");
            Console.WriteLine($"{item.TareaId}\n{item.Descripcion}\n{item.Duracion}");
        }
    }

}
else
{
    Console.WriteLine("Opcion no valida.");
}



