using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BL
{
    public class cls_pedido
    {


        private string documento;
        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        private string condicion_pago;
        public string Condicion_Pago
        {
            get { return condicion_pago; }
            set { condicion_pago = value; }
        }

        private string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string fecha;
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string cliente;
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private string nombre_cliente;
        public string Nombre_Cliente
        {
            get { return nombre_cliente; }
            set { nombre_cliente = value; }
        }

        private string direccion_cliente;
        public string Direccion_Cliente
        {
            get { return direccion_cliente; }
            set { direccion_cliente = value; }
        }

        private double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        private double subtotal;
        public double SubTotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private double igv;
        public double Igv
        {
            get { return igv; }
            set { igv = value; }
        }
        private String fecha_entrega;
        public String Fecha_Entrega
        {
            get { return fecha_entrega; }
            set { fecha_entrega = value; }
        }

        private string estado_cliente;
        public string Estado_Cliente
        {
            get { return estado_cliente; }
            set { estado_cliente = value; }
        }


    }
}
