﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Telesoluciones
    {
        public Telesoluciones() { }
    }

    public class TelesolucionesAdicionalCab
    {
        public string fechaVencimiento { get; set; }
        public string codigoSunatEstablecimiento { get; set; }
        public string ordenCompra { get; set; }
    }
    public class TelesolucionesFactura
    {
        public string tipoOperacion { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }
        public double montoTotalImpuestos { get; set; }
        public double importeTotal { get; set; }
        public double totalVentaGravada { get; set; }
        public double sumatoriaIgv { get; set; }
        public List<TelesolucionesGuiaRelacionada> guiasRelacionada { get; set; }
        public TelesolucionesAdicionalCab adicional { get; set; }
        public string fechaEmision { get; set; }
        public string tipoMoneda { get; set; }
        public List<TelesolucionesItems> items { get; set; }




        //public double totalVentaInafecta { get; set; }
        //public double totalVentaExonerada { get; set; }
        //public double sumatoriaIsc { get; set; }
        //public double totalVenta { get; set; }

        //public double descuentoGlobal { get; set; }
        //public double porcentajeDescuentoGlobal { get; set; }
        //public double totalDescuento { get; set; }
        //public double importePercepcion { get; set; }
        //public double porcentajePercepcion { get; set; }
        //public List<TelesolucionesDocRelacionada> docRelacionada { get; set; }

        public TelesolucionesRecceptor receptor { get; set; }


        //UBL 2.1


    }

    public class TelesolucionesRecceptor
    {
        public string tipo { get; set; }
        public string nro { get; set; }
        
    }

    public class TelesolucionesItems
    {
        public string unidadMedidaCantidad { get; set; }
        public double cantidad { get; set; }
        public string descripcion { get; set; }
        public double valorUnitario { get; set; }
        public double precioVentaUnitario { get; set; }
        public string tipoPrecioVentaUnitario { get; set; }
        public double montoTotalImpuestosItem { get; set; }
        public double baseAfectacionIgv { get; set; }
        public double montoAfectacionIgv { get; set; }
        public double porcentajeImpuesto { get; set; }
        public string tipoAfectacionIgv { get; set; }
        public string codigoTributo { get; set; }
        public double valorVenta { get; set; }
        public string codigoProducto { get; set; }
        public string codigoProductoSunat { get; set; }
        public string codigoProductoGs1 { get; set; }
        public TelesolucionesAdicionalDet adicional { get; set; }
        





        //public double montoAfectacionIsc { get; set; }
        //public string tipoAfectacionIsc { get; set; }

        //public double descuento { get; set; }
        //public double porcentajeDescuento { get; set; }



    }
    public class TelesolucionesAdicionalDet
    {
        public TelesolucionesdescuentoItem descuentoItem { get; set; }

    }
    public class TelesolucionesdescuentoItem
    {
        public string codigoMotivoDescuento { get; set; }
        public double factorNumericoDescuento { get; set; }
        public double montoDescuento { get; set; }
        public double montoBaseDescuento { get; set; }

    }

    public class TelesolucionesRespuestaFactura
    {
        public string fechaEmision { get; set; }
        public string[] leyendas { get; set; }
        public string fechaEmitido { get; set; }
        public string codigoComprobante { get; set; }
        public string importeLetras { get; set; }
        public string tipoMonedaHuman { get; set; }
        public string tipoMonedaSimbolo { get; set; }
        public Int32 idFactura { get; set; }
        public string serie { get; set; }
        public Int32 numero { get; set; }
        public double totalVentaGravada { get; set; }
        public double totalVentaInafecta { get; set; }
        public double totalVentaExonerada { get; set; }
        public double sumatoriaIgv { get; set; }
        public double sumatoriaIsc { get; set; }
        public double totalDescuento { get; set; }
        public double totalVenta { get; set; }
        public string tipoMoneda { get; set; }
        public double importePercepcion { get; set; }
        public double porcentajePercepcion { get; set; }
        public string emitido { get; set; }
        public string baja { get; set; }
        public string digestValue { get; set; }
        public string signatureValue { get; set; }
        public string idUsuario { get; set; }
        public string idEmisor { get; set; }
        public string idReceptor { get; set; }
        public string idConstancia { get; set; }
        public List<TelesolucionesRespuestaFacturaItems> items { get; set; }

        //PARA BOLETAS
        public Int32 idBoleta { get; set; }
        public Int32 idDocumento { get; set; }
    }

    public class TelesolucionesRespuestaFacturaItems
    {
        public string unidadMedidaHuman { get; set; }
        public string unidadMedidaCantidad { get; set; }
        public double cantidad { get; set; }
        public string descripcion { get; set; }
        public double valorVenta { get; set; }
        public double valorUnitario { get; set; }
        public double precioVentaUnitario { get; set; }
        public string tipoPrecioVentaUnitario { get; set; }
        public double montoAfectacionIgv { get; set; }
        public string tipoAfectacionIgv { get; set; }
        public double montoAfectacionIsc { get; set; }
        public string tipoAfectacionIsc { get; set; }
        public string codigoProducto { get; set; }
        public double descuento { get; set; }
        public double porcentajeDescuento { get; set; }
    }

    public class TelesolucionesRespuestaReceptor
    {
        public dynamic idReceptor { get; set; }
        public dynamic tipo { get; set; }
        public dynamic razonSocial { get; set; }
        public dynamic estado { get; set; }
        public dynamic condicion { get; set; }
    }

    //public class TelesolucionesDocRelacionada
    //{
    //    public string numero { get; set; }
    //    public string tipo { get; set; }
    //}

    public class TelesolucionesGuiaRelacionada
    {
        public string tipo { get; set; }
        public string numero { get; set; }
        //public string serie { get; set; }
    }
    public class TelesolucionesBajaDocumento
    {
        public string fechaEmisionDocs { get; set; }
        public string serie { get; set; }
        public Int32 numero { get; set; }
        public List<TelesolucionesBajaItem> items { get; set; }

    }
    public class TelesolucionesBajaItem
    {
        public string descripcion { get; set; }
        public string serie { get; set; }
        public Int32 numero { get; set; }
        public string tipoComprobante { get; set; }

    }

    public class TelesolucionesBajaDocumentoRespuesta
    {
        public string fechaEmision { get; set; }
        public string fechaEmitido { get; set; }
        public string fechaEmisionDocs { get; set; }
        public Int32 numero { get; set; }
        public Int32 ticketConstancia { get; set; }
        public string emitido { get; set; }
        public string baja { get; set; }
        public string digestValue { get; set; }
        public string signatureValue { get; set; }
        public string idUsuario { get; set; }
        public string idEmisor { get; set; }
        public string idReceptor { get; set; }
        public string idConstancia { get; set; }
        public string idComunicacionBaja { get; set; }
        public List<TelesolucionesBajaItem> items { get; set; }

        public string code { get; set; }
        public string status { get; set; }
        public string message { get; set; }

    }

    public class TelesolucionesConstancia
    {
        public string id { get; set; }
    }
    public class TelesolucionesConstanciaRespuesta
    {
        public string fechaEmision { get; set; }
        public string idConstancia { get; set; }
        public string idRespuesta { get; set; }
        public string serie { get; set; }
        public string numero { get; set; }
        public string tipo { get; set; }
        public string codigo { get; set; }
        public string notas { get; set; }
        public string descripcion { get; set; }

        public string code { get; set; }
        public string status { get; set; }
        public string message { get; set; }

    }
}
