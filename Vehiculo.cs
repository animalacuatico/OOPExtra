namespace OOPExtra
{
    public class Vehiculo
    {
        public string Marca;
        public string Modelo;
        protected int Velocidad = 0;
        public Vehiculo()
        {

        }
        public Vehiculo(string marca, string modelo, int velocidad)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Velocidad = velocidad;
        }
        public void Acelerar(int velocidadAAcelerar)
        {
            Velocidad += velocidadAAcelerar;
        }
        public void Decelerar(int velocidadAAdecelerar)
        {
            Velocidad -= velocidadAAdecelerar;
            if (Velocidad < 0)
            {
                Velocidad = 0;
            }
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Velocidad: " + Velocidad);
        }
    }
}
