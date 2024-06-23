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
        public void CalcularAntiguedad()
        {
            //Obtengo la fecha actual
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(fechaActual.Year - FechaIngreso.Year);
        }

        public void CalcularEdad(){
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(fechaActual.Year - FechaNacimiento.Year);
        }

        public void CalcularJubilacion(){
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(65 - (fechaActual.Year - FechaNacimiento.Year));
        }
    }

}