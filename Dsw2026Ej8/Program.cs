namespace Dsw2026Ej8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(0001, "Yerba Mate RosaMonte", 500m));
        }
    }

    public static partial class ProductHelper
    {
        public static string AgregarFormatoAlPrecio(decimal price) =>
            price.ToString("C2", new System.Globalization.CultureInfo("es-AR"));
    }
}
