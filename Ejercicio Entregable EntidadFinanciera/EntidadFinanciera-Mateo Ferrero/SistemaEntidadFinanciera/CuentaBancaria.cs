﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEntidadFinanciera
{
    public class CuentaBancaria
    {
        public int CuentaID { get; set; }
        public int NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public string Tipo { get; set; } // ´´Corriente´´ o ´´Ahorro´´

    }
}
