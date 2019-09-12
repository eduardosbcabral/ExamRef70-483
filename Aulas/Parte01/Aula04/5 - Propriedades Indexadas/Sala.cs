using System;
using System.Collections.Generic;

namespace Aulas.Parte01.Aula04._5Propriedades_Indexadas
{
    class Sala
    {
        private readonly IDictionary<string, ClienteCinema> reservas
            = new Dictionary<string, ClienteCinema>();

        public ClienteCinema GetReserva(string codigoAssento)
        {
            return reservas[codigoAssento];
        }

        public void SetReserva(string codigoAssento, ClienteCinema cliente)
        {
            reservas[codigoAssento] = cliente;
        }

        // Propriedade Indexada
        public ClienteCinema this[string codigoAssento]
        {
            get
            {
                return reservas[codigoAssento];
            }
            set
            {
                reservas[codigoAssento] = value;
            }
        }

        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos Reservados");
            Console.WriteLine("==================");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} - {reserva.Value}");
            }
        }
    }
}
