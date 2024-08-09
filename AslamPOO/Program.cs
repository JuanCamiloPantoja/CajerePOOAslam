using System;

namespace CajeroAutomatico
{
    public class Cajero
    {
        static void Main(string[] args)
        {
            Cajero cajero = new Cajero("123456789", "clave123", 1000);

            Console.WriteLine("Bienvenido al cajero automático");
            Console.Write("Ingrese su número de cuenta: ");
            string numeroCuentaIngresada = Console.ReadLine();
            Console.Write("Ingrese su clave: ");
            string claveIngresada = Console.ReadLine();

            cajero.IniciarSesion(numeroCuentaIngresada, claveIngresada);
        }

        private string numeroCuenta;
        private string clave;
        private decimal saldo;
        public Cajero(string numeroCuenta, string clave, decimal saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.clave = clave;
            this.saldo = saldo;
        }
        public void IniciarSesion(string numeroCuentaIngresada, string claveIngresada)
        {
            if (numeroCuentaIngresada == numeroCuenta && claveIngresada == clave)
            {
                Console.WriteLine("Bienvenido, usted ha iniciado sesión correctamente");
                Menu();
            }
            else
            {
                Console.WriteLine("Cuenta o clave incorrecta, no se puede iniciar sesión");
            }
        }
        private void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Mostrar saldo");
                Console.WriteLine("2. Transferir dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Depositar dinero");
                Console.WriteLine("5. Cambiar clave");
                Console.WriteLine("6. Salir");

                Console.Write("Ingrese su opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarSaldo();
                        break;
                    case 2:
                        TransferirDinero();
                        break;
                    case 3:
                        RetirarDinero();
                        break;
                    case 4:
                        DepositarDinero();
                        break;
                    case 5:
                        CambiarClave();
                        break;
                    case 6:
                        Console.WriteLine("Gracias por utilizar el cajero automático");
                        return;
                    default:
                        Console.WriteLine("Opción inválida, por favor ingrese una opción válida");
                        break;
                }
            }
        }
        private void MostrarSaldo()
        {
            Console.WriteLine($"Su saldo es: {saldo}");
        }
        private void TransferirDinero()
        {
            Console.Write("Ingrese el monto a transferir: ");
            decimal montoTransferir = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese la cuenta de destino: ");
            string cuentaDestino = Console.ReadLine();

            if (saldo >= montoTransferir)
            {
                saldo -= montoTransferir;
                Console.WriteLine($"Se ha transferido {montoTransferir} a la cuenta {cuentaDestino}");
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo para realizar la transferencia");
            }
        }
        private void RetirarDinero()
        {
            Console.Write("Ingrese el monto a retirar: ");
            decimal montoRetirar = Convert.ToDecimal(Console.ReadLine());

            if (saldo >= montoRetirar)
            {
                saldo -= montoRetirar;
                Console.WriteLine($"Se ha retirado {montoRetirar}");
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo para realizar el retiro");
            }
        }

    }
}