﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class OrdenServicio
    {
        public DateTime fecha { get; set; }
        public string cdocu { get; set; }
        public string ndocu { get; set; }
        public string codcli { get; set; }
        public string nomcli { get; set; }
        public string ruccli { get; set; }
        public double tcam { get; set; }
        public double tota { get; set; }
        public double toti { get; set; }
        public double totn { get; set; }
        public string flag { get; set; }
        public string flagnombre { get; set; }
        public bool FlgCheck { get; set; }
        public string codcdv { get; set; }
        public string nomcodcdv { get; set; }
        public string mone { get; set; }
        public Boolean flag_arqueado { get; set; }
        public DateTime? fechaarqueo { get; set; }
        public string usuarioArqueo { get; set; }
        public double saldo { get; set; }
        public Boolean flag_cancelado { get; set; }

    }
}
