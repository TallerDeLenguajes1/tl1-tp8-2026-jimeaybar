using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Tareas;

Console.WriteLine("Desea ingresar una tarea?: \n1.Si \n2.No");

List <Tarea> tareasPendientes= new ();

if (int.TryParse(Console.ReadLine(), out int opcion))
{
    while (opcion!= 2)
    {
        Tarea tareas = new();
        Console.WriteLine("Ingrese un Id:");
        int id = int.Parse(Console.ReadLine()!);
        tareas.TareaId = id;
        Console.WriteLine("Ingrese una Descripcion:");
        string? desc = Console.ReadLine();
        tareas.Descripcion = desc;
        Console.WriteLine("Ingrese una Duracion:");
        int dura = int.Parse(Console.ReadLine()!);
        tareas.Duracion = dura;

        while(dura < 10 || dura > 100)
        {
            Console.WriteLine("Ingrese una Duracion valida entre 10 y 100:");
            int durac = int.Parse(Console.ReadLine()!);
        }

        tareas.Duracion = dura; 
        tareasPendientes.Add(tareas);

        Console.WriteLine("Desea ingresar otra tarea?: \n1.Si \n2.No");
        opcion = int.Parse(Console.ReadLine()!);
    }

    foreach (Tarea item in tareasPendientes)
    {
        Console.WriteLine($"{item.TareaId}\n{item.Descripcion}\n{item.Duracion}");
    }
    

}
else
{
    Console.WriteLine("No se escribio ningun numero.");
}

