namespace Resistencia.Domain.Interfaces
{
    public interface IOperacion
    {
        void Banda_1(string Banda1 );
        void Banda_2(string Banda2);
        void Banda_3(string Banda3);
        void Banda_gold(string Banda4);
        string operacion();
    }
}