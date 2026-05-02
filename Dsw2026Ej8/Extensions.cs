namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string texto)
        {
            return texto
                .Trim()              // Eliminar espacios al inicio y final
                .ToUpper()           // Convertir a mayúsculas
                .Replace(" ", "-");  // Reemplazar espacios internos por guiones
        }
    }
}
