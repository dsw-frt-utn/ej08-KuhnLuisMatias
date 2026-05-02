namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity <= 0 ? 0 : quantity,
                Total = unitPrice * quantity
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}
