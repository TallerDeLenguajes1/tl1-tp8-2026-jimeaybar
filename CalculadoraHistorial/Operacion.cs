namespace CalculosHistorial
{
    public class Operacion
    {
        private double resultadoAnterior; //almacena el resultado previo al calculo actual
        private double nuevoValor; // el valor con el que se opera sobre el resultadoActual
        private TipoOperacion operacion; // el tipo de operacion realizada
        public double ResultadoAnterior {get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor {get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion Tipo {get => operacion; set => operacion = value; }

        public double Resultado
        {
            //Logica para calcular o devolver el resultado
            get
            {
                switch (operacion)
                {
                    case TipoOperacion.Suma:
                        return resultadoAnterior + nuevoValor;
                        break;
                    case TipoOperacion.Resta:
                        return resultadoAnterior - nuevoValor;
                        break;
                    case TipoOperacion.Multiplicacion:
                        return resultadoAnterior * nuevoValor;
                        break;
                    case TipoOperacion.Division:
                        return ResultadoAnterior / nuevoValor;
                        break;
                    case TipoOperacion.Limpiar:
                        return 0;
                        break;
                    default:
                        return 0;
                        break;
                }
            }
        }

        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }
        public double mostrar()
        {
            return ResultadoAnterior;
        }

    }



    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Accion de borrar
    }
}