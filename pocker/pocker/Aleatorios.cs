using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocker
{
    class Aleatorios
    {
        private static List<double> t = new List<double>();
        private Random num = new Random();
        private static List<double> cartas = new List<double>();
        public void Generar_Valores(int rango)
        {
            Aleatorio(rango);
            Obtener_ValoresCartas();
        }
        private void Aleatorio(int rango)
        {
            for (double i = 0; i < rango; i++)
                t.Add(divicion(num.NextDouble()));
        }
        private double divicion(double num)
        {
            return (Math.Truncate(num * 100000) / 100000);
        }
        private void Obtener_ValoresCartas()
        {
            cartas.Add(0.3048);
            cartas.Add(0.5040);
            cartas.Add(0.1080);
            cartas.Add(0.0720);
            cartas.Add(0.0090);
            cartas.Add(0.0045);
            cartas.Add(0.0001);
        }
        public List<double> T
        {
            set { t = value; }
            get { return t; }
        }
        public List<double> Cartas
        {
            set { cartas = value; }
            get { return cartas; }
        }
    
    }
}
