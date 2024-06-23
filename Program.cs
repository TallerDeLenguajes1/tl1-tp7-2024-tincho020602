using EspacioEmpleados;

DateTime fechaCumple = new DateTime(2002,6,2);
DateTime fechaIngreso = new DateTime(2020,7,19);

/*/Empleado empleado1 = new Empleado("Martin", "Ibarra", fechaCumple,'c',fechaIngreso, 700000, Cargos.Administrativo);
Console.WriteLine(empleado1);
empleado1.CalcularAntiguedad();
*/

Empleado[] empleados = new Empleado[3];
empleados[0] = new Empleado("Juan", "Perez", new DateTime(1985, 5, 20), 'C', new DateTime(2009, 6, 1), 650000, Cargos.Ingeniero);
empleados[2] = new Empleado("Carlos", "Lopez", new DateTime(1982, 8, 10), 'S', new DateTime(2008, 1, 10), 35000, Cargos.Especialista);
empleados[1] = new Empleado("Maria", "Gomez", new DateTime(1990, 3, 15), 'C', new DateTime(2015, 9, 1), 25000, Cargos.Administrativo);

double montoTotal=0;
int proxJubilar=100;
int idEmpleado=0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"*********Empleado: {i+1}*********");
    Console.WriteLine($"Apellido: { empleados[i].Apellido }");
    Console.WriteLine($"Nombre: {empleados[i].Nombre }");
    Console.WriteLine($"Edad: {empleados[i].CalcularEdad()}");
    Console.WriteLine($"Estado Civil: {empleados[i].EstadoCivil}");
    Console.WriteLine($"Anio de Ingreso: {empleados[i].FechaIngreso.ToString("dd/MM/yyyy")}");
    Console.WriteLine($"Sueldo Basico: ${empleados[i].SueldoBasico}");
    Console.WriteLine($"Cargo: {empleados[i].Cargo}");
    Console.WriteLine($"Antiguedad: {empleados[i].CalcularAntiguedad()}");
    Console.WriteLine($"Anios restante para jubilacion: {empleados[i].CalcularJubilacion()}");
    if (proxJubilar>empleados[i].CalcularJubilacion())
    {
        proxJubilar=proxJubilar=empleados[i].CalcularJubilacion();
        idEmpleado=i;
    }
    Console.WriteLine($"Salario: ${empleados[i].CalcularSalario()}");
    montoTotal=montoTotal+empleados[i].CalcularSalario();
    Console.WriteLine("");
}
    Console.WriteLine($"Monto total en concepto de salarios: ${montoTotal}");
    Console.WriteLine($"El empleado mas proximo a jubilarse es: {empleados[idEmpleado].Nombre}");
    
 

/*using EspacioCalculadora;

Calculadora calc = new Calculadora();
int opcion = 0;
do
{ 
    Console.WriteLine(">>>>Calculadora<<<<");
    Console.WriteLine(">>Elija una opcion:");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Multiplicacion");
    Console.WriteLine("4-Division");
    Console.WriteLine("5-Limpiar");
    Console.WriteLine("6-Salir");
    string opcionIngresada = Console.ReadLine();
    if (int.TryParse(opcionIngresada, out opcion) && (opcion >= 1 && opcion <= 6))
    {
        Console.WriteLine("Ingrese el valor a operar: ");
        string valorIngresado = Console.ReadLine();
        double valor;
        if (double.TryParse(valorIngresado, out valor))
        {
            switch (opcion)
            {
                case 1:
                    calc.Sumar(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 2:
                    calc.Restar(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 3:
                    calc.Multiplicar(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 4:
                    calc.Dividir(valor);
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 5:
                    calc.Limpiar();
                    Console.WriteLine($"Total: {calc.Resultado()}");
                    break;
                case 6:
                    Console.WriteLine("Salir...");
                    opcion = 0;
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
    }else{
        Console.WriteLine("Opcion incorrecta");
    }

} while (opcion != 0);
*/