namespace ReposteriaSammy_s
{
    public class Factura : Usuario
    {
        private int ValorPagar;

        public Factura(string Nombres, string Apellidos, int Telefono, string Dirección, int ValorPagar) :
            base(Nombres, Apellidos, Telefono, Dirección)
        {
            this.ValorPagar = ValorPagar;
        }

        public int getValorPagar()
        {
            return ValorPagar;
        }
        public void setValorPagar(int ValorPagar)
        {
            this.ValorPagar = ValorPagar;
        }
        public void ImprimirValorTotal()
        {
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("                              FACTURA                          ");
            Console.WriteLine("///////////////////////////////////////////////////////////////\n");


            Console.WriteLine("Nombre del cliente: " + getNombres());
            Console.WriteLine("Apellido del cliente: " + getApellidos());
            Console.WriteLine("Telefono: " + getTelefono());
            Console.WriteLine("Direccion: " + getDirección());
            Console.WriteLine("El valor a cancelar es: $" + getValorPagar());

            Console.ReadKey();
        }
    }
}
