namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            var valueAux = originalValue;
            valueAux++;

            var productAux = product;
            product.Description = "nNew description";

            return $"{originalValue}-{valueAux}-{product.Description}";
        }
    }
}
