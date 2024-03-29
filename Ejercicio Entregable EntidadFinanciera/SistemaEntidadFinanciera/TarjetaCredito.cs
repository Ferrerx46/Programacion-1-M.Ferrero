﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEntidadFinanciera
{
    public class TarjetaCredito
    {
        [Key]
        public int TarjetaID { get; set; }
        public string? NumeroTarjeta { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal SaldoDisponible { get; set; }
        public string? Estado { get; set; }// "Activa", "Pausada" o "Bloqueada"
        public decimal MontoDeuda { get; set; } 

        /*public void PagarTarjeta(decimal montoPago)
        {
            if (montoPago <= 0)
            {
                Console.WriteLine ("El monto del pago debe ser mayor que cero.");
                return;
            }

            if (montoPago > MontoDeuda)
            {
               Console.WriteLine("El monto del pago no puede superar la deuda actual.");
                return;
            }

            SaldoDisponible += montoPago;
            MontoDeuda -= montoPago;
        }*/

    }
}
