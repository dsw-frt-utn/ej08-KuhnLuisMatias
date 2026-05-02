namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notas = new int?[] { nota1, nota2, nota3 };
            var notasValidas = notas.Where(nota => nota.HasValue && nota.Value > 0 && nota.Value <= 10);

            return !notasValidas.Any()
                ? 0
                : (double) notasValidas.Average(x => x.Value);

        }
    }
}
