namespace Alcohol.Domain.Interfaces
{
    public interface IDATOS
    {
        void PrimerDato(int cantidad, string bebida);
        void SegundoDato(int peso);
        string DatosTotales();
    }
}