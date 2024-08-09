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
    }
}