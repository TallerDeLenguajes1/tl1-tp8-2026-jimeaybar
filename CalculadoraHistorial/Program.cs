using CalculosHistorial;

List<Operacion> historial = new List<Operacion>();

double resultadoActual = 0;

int continuar;
do
{
    Console.WriteLine("Que operacion desear hacer:");
    Console.WriteLine("Suma .1");
    Console.WriteLine("Resta .2");
    Console.WriteLine("Multiplicacion .3");
    Console.WriteLine("Division .4");
    Console.WriteLine("Limpiar .5");

    int opcion;
    string? buff = Console.ReadLine();
    int.TryParse(buff, out opcion);

    double numero;
    Console.WriteLine("Ingrese un numero a calcular:");
    string? num = Console.ReadLine();
    double.TryParse(num, out numero);

    TipoOperacion tipo;
    switch (opcion)
    {
        case 1:
            tipo = TipoOperacion.Suma;
            break;
        case 2:
            tipo = TipoOperacion.Resta;
            break;
        case 3:
            tipo = TipoOperacion.Multiplicacion;
            break;
        case 4:
            tipo = TipoOperacion.Division;
            break;
        case 5:
            tipo = TipoOperacion.Limpiar;
            break;
        default:
            tipo = TipoOperacion.Limpiar;
            break;
    }

    Operacion nuevaOperacion = new Operacion(resultadoActual, numero, tipo);

    resultadoActual = nuevaOperacion.Resultado;
    historial.Add(nuevaOperacion);
    Console.WriteLine($"Resultado: {resultadoActual}");

    Console.WriteLine("Desea seguir calculando? 1.Si o 2.No");
    string? buff1 = Console.ReadLine();
    int.TryParse(buff1, out continuar);

} while (continuar == 1);

Console.WriteLine("===HISTORIAL===");
foreach(Operacion historia in historial)
{
    Console.WriteLine(historia.mostrar());
}
Console.WriteLine("===FIN===");
