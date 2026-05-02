namespace Dsw2026Ej8
{
    public class Program
    {
        static void Main(string[] args)
        {
            var codigo = 0001;
            var descripcion = "Yerba Mate RosaMonte";
            var precio = 500M;
            var cantidad = 2;

            //Ejercicio N1
            //Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(codigo, descripcion, precio));

            //Ejercicio N2
            //var problema2 = new Problema2();
            //Console.WriteLine(problema2.CrearResumenVenta(codigo, descripcion, cantidad, precio));

            //Ejercicio N3
            //var numero = 1;
            //var product = new Product() { Description = "Old description" };
            //var problema3 = new Problema3();
            //Console.WriteLine(problema3.CompararCopias(numero, product));

            //Ejercicio N4
            //var problema4 = new Problema4();
            //double resultado = problema4.CalcularPromedio(null, 10, 5);
            //Console.WriteLine(resultado);

            //Ejercicio N5
            var problema5 = new Problema5();
            var retail = new RetailSale();
            var wholesaleSale = new WholesaleSale();
            Console.WriteLine($" Total Retail: {problema5.ObtenerImporteFinal(retail)}");
            Console.WriteLine($" Total WholesaleSale: {problema5.ObtenerImporteFinal(wholesaleSale)}");

        }
    }

    public static partial class ProductHelper
    {
        public static string AgregarFormatoAlPrecio(decimal price) =>
            price.ToString("C2", new System.Globalization.CultureInfo("es-AR"));
    }
}
