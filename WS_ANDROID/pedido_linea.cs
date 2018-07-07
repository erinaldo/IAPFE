using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BL
{
    public class cls_pedido_linea
    {
        private int linea;
        public int Linea
        {
            get { return linea; }
            set { linea = value; }
        }

        private string Documento;

        public string Documento1
        {
            get { return Documento; }
            set { Documento = value; }
        }

        private string articulo;
        public string Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        private string articulo_descripcion;
        public string Articulo_Descripcion
        {
            get { return articulo_descripcion; }
            set { articulo_descripcion = value; }
        }
        private string unidad_medida;
        public string Unidad_Medida
        {
            get { return unidad_medida; }
            set { unidad_medida = value; }
        }

        private int cantidad_pedida;
        public int Cantidad_Pedida
        {
            get { return cantidad_pedida; }
            set { cantidad_pedida = value; }
        }

        private double precio_unitario;
        public double Precio_Unitario
        {
            get { return precio_unitario; }
            set { precio_unitario = value; }
        }

    }
}
