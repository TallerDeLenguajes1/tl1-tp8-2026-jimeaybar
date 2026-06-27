namespace Tareas
{
    public enum EstadoTarea
    {
        pendientes = 0,
        realizadas = 1
    }
    public class Tarea //m clase tarea tiene 4 objetos
    {
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public EstadoTarea Estado { get; set;}

        public Tarea()
        {
            Estado = EstadoTarea.pendientes;
        }

        //obtengo los valores
        public Tarea(int TareaID, string Descripcion, int Duracion, EstadoTarea Estado)
        {
            this.TareaID = TareaID;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
            Estado = Estado;
        }

        public string mostrar()
        {
            return TareaID + " | " + Descripcion + " | " + Duracion + " | " + Estado.ToString();
        }

    }
}