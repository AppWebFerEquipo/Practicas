using System;
using Resistencia.Domain.Interfaces;

namespace Resistencia.Domain.Entities
{
    public class Result : IOperacion
    {
        private string _Banda1;
        private string _Banda2;
        private string _Banda3;
        private string _Banda4;
        private string value1;
        private string value2;
        private string _result;
        private int valor = 0;
        public double suma = 0.0;
        private double _result2 = 0.0;
        private double _result3 = 0.0;
        private double mas = 0.0;
        private double menos =0.0;

        
        public void Banda_1(string Banda1)
        {
            _Banda1 = Banda1.ToLower();
            switch(Banda1){
                case "Negro":
                break;
                case "Cafe":
                value1 = "1";
                break;
                case "Rojo":
                value1 = "2";
                break;
                case "Naranja":
                value1 = "3";
                break;
                case "Amarillo":
                value1 = "4";
                break;
                case "Verde":
                value1 = "5";
                break;
                case "Azul":
                value1 = "6";
                break;
                case "Violeta":
                value1 = "7";
                break;
                case "Gris":
                value1 = "8";
                break;
                case "Blanco":
                value1 = "9";
                break;
                
            }
        }
        public void Banda_2(string Banda2)
        {
            _Banda2 = Banda2.ToLower();
            switch(Banda2){
                case "Negro":
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Cafe":
                value2 = "1";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Rojo":
                value2 = "2";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Naranja":
                value2 = "3";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Amarillo":
                value2 = "4";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Verde":
                value2 = "5";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Azul":
                value2 = "6";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Violeta":
                value2 = "7";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Gris":
                value2 = "8";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Blanco":
                value2 = "9";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                
            }
        }
        public void Banda_3(string Banda3)
        {

            _Banda3 = Banda3.ToLower();
            switch(Banda3){
                case "Negro":
                _result2 = 1;
                suma = valor * _result2;
                break;
                case "Cafe":
                _result2 = 10;
                suma = valor * _result2;
                break;
                case "Rojo":
                _result2 = 100;
                suma = valor * _result2;
                break;
                case "Naranja":
                _result2 = 1000;
                suma = valor * _result2;
                break;
                case "Amarillo":
                _result2 = 10000;
                suma = valor * _result2;
                break;
                case "Verde":
                _result2 = 100000;
                suma = valor * _result2;
                break;
                case "Azul":
                _result2 = 1000000;
                suma = valor * _result2;
                break;
                case "Violeta":
                _result2 = 10000000;
                suma = valor * _result2;
                break;
                case "Gris":
                _result2 = 100000000;
                suma = valor * _result2;
                break;
                case "Blanco":
                _result2 = 1000000000;
                suma = valor * _result2;
                break;
                
            }
        }
        public void Banda_gold(string Banda4)
        {
            _Banda4 = Banda4.ToLower();

                if(Banda4 == "Dorado"){
                _result3 = suma * 0.5/10;
                }
                if(Banda4 == "Plata"){
                _result3 = suma * 0.10/10;
                }
             mas= suma + _result3;
         menos= suma - _result3;  
           
        }

        public string operacion()
        {
             
             return $"el valor es {suma} y la tolerancia es {_result3} El rango de toleracia si tiene mas el {_result3} es de: {mas} El rango de tolerancia si tiene menos el {_result3} es de : {menos} ";
        }

        
    }
}