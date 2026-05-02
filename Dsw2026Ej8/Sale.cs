namespace Dsw2026Ej8
{
    public class Sale
    {
        public virtual decimal CalculateTotal() => 100M;
    }

    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return base.CalculateTotal();
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            var totalSinDescuento = base.CalculateTotal();
            var descuento = totalSinDescuento * 0.10M;

            return totalSinDescuento - descuento;
        }
    }
}
