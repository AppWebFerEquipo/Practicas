using System.Data.Common;
using Alcohol.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Alcohol.Domain.Entities
{
    public class Operaciones : IDATOS
    {
        private int _cantidad;
        private int _mllitro;
        private int _peso;
        private double total;
        private double factorizacion;
        private double etanol = 0.789;
        private double op;
        private double volumen;
        private double Resultado;
        private double grado;
        private string _bebida;
        private string value;
        
        public void PrimerDato(int cantidad, string bebida)
        {
            _cantidad = cantidad;
            _bebida = bebida.ToLower();
            switch (bebida)
            {
                    case "Cerveza":
                    _mllitro = 330;
                    _cantidad = _cantidad * _mllitro;
                    grado = 5;
                    total = grado / 100 * _cantidad;
                    break;
                    case "Vino": 
                    _mllitro = 100;
                    _cantidad = _cantidad * _mllitro;
                    grado = 12;
                    total = grado / 100 * _cantidad;
                    break;
                    case "Cava": 
                    _mllitro = 100;
                    _cantidad = _cantidad * _mllitro;
                    grado = 12;
                    total = grado / 100 * _cantidad;
                    break;
                    case "Vermu":
                    _mllitro = 70;
                    _cantidad = _cantidad * _mllitro;
                    grado = 17;
                    total = grado / 100 * _cantidad;
                    break;
                    case "Licor":
                    _mllitro = 45;
                    _cantidad = _cantidad * _mllitro;
                    grado = 23;
                    total = grado / 100 * _cantidad;
                    break;
                    case "Brandy":
                    _mllitro = 45;
                    _cantidad = _cantidad * _mllitro;
                    grado = 38;
                    total = grado / 100 * _cantidad;
                    break;
                    case "Combinado":
                    _mllitro = 50;
                    _cantidad = _cantidad * _mllitro;
                    grado = 38;
                    total = grado / 100 * _cantidad;
                    break;
                default:
                Console.WriteLine("no existe este alcohol: "+bebida);
                break;
            }
            
        }

        public void SegundoDato(int peso)
        {
            _peso = peso;
            factorizacion = 0.15 * total;
            op = etanol * factorizacion;
            volumen = 0.08 * _peso;
            Resultado = op / volumen;
        }
        public string DatosTotales()
        {
                   if (Resultado < 0.8)
                {
                    return $" {Resultado} no es superior";
                }
                    return $" {Resultado} es superior";
               
        }
    }
}