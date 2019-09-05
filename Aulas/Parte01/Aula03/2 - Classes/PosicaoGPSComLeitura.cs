using System;

namespace Aulas.Parte01.Aula03._2Classes
{
    // internal: visivel somente no assembly (projeto no caso)
    // private: visível somente caso declarado dentro de outra classe
    // public: visível no assembly atual e em projetos que fazem referência a esse assembly
    internal class PosicaoGPSComLeitura : ClassePosicaoGPS
    {
        private readonly DateTime dataLeitura;

        public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) 
            : base(latitude, longitude)
        {
            this.dataLeitura = dataLeitura;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude} - Longitude: {Longitude} - DataLeitura: {dataLeitura}";
        }
    }
}
