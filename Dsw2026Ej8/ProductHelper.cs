namespace Dsw2026Ej8
{
    public static partial class ProductHelper
    {
        public static string ObtenerEtiquetaProducto(long code, string description, decimal price)
        => $"[{code}] {description} - {AgregarFormatoAlPrecio(price)}";
    }
}
