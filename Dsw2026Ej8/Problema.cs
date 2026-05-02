namespace Dsw2026Ej8
{
    public class Problema6
    {
        public static string NormalizarCodigoProducto(string code)
        {
            if (string.IsNullOrEmpty(code))
                return "SIN-CODIGO";

            return code.ToProductCode();
        }
    }
}