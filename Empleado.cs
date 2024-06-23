namespace EspacioEmpleados
{
    enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    class Empleado
    {
        //Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public char EstadoCivil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargos Cargo { get; set; }

        //Constructor
        public Empleado(string _nombre, string _apellido, DateTime _fechaNacimiento, char _estadoCivil, DateTime _fechaIngreso, double _sueldoBasico, Cargos _cargo){
            Nombre = _nombre;
            Apellido = _apellido;
            FechaNacimiento = _fechaNacimiento;
            EstadoCivil = _estadoCivil;
            FechaIngreso = _fechaIngreso;
            SueldoBasico = _sueldoBasico;
            Cargo = _cargo;
        }

        //Metodos
        public int CalcularAntiguedad()
        {
            int antiguedad;
            //Obtengo la fecha actual
            DateTime fechaActual = DateTime.Now;//datetime.now me da la fecha actual
            return antiguedad=(fechaActual.Year - FechaIngreso.Year);
        }

        public int CalcularEdad()
        {
            //obtengo la edad del empleado
            int edad;
            DateTime fechaActual = DateTime.Now;
           return edad=(fechaActual.Year - FechaNacimiento.Year);
        }

        public int CalcularJubilacion()
        {
            int jubilacion;
            DateTime fechaActual = DateTime.Now;
            return jubilacion=(65 - (fechaActual.Year - FechaNacimiento.Year));
        }
    }

}