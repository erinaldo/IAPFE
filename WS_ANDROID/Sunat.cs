using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Sunat
    {
        public Sunat()
        {
        }
    }

    public class SunatDocumentoFBN_V2
    {
        public string operacion { get; set; }
        public Int32 tipo_de_comprobante { get; set; }
        public string serie { get; set; }
        public Int32 numero { get; set; }
        public Int32 sunat_transaction { get; set; }
        public Int32 cliente_tipo_de_documento { get; set; }
        public string cliente_numero_de_documento { get; set; }
        public string cliente_denominacion { get; set; }
        public string cliente_direccion { get; set; }
        public string cliente_email { get; set; }
        public string cliente_email_1 { get; set; }
        public string cliente_email_2 { get; set; }
        public DateTime fecha_de_emision { get; set; }
        public DateTime fecha_de_vencimiento { get; set; }
        public Int32 moneda { get; set; }
        public double tipo_de_cambio { get; set; }
        public double porcentaje_de_igv { get; set; }
        public double descuento_global { get; set; }
        public double total_descuento { get; set; }
        public double total_anticipo { get; set; }
        public double total_gravada { get; set; }
        public double total_inafecta { get; set; }
        public double total_exonerada { get; set; }
        public double total_igv { get; set; }
        public double total_gratuita { get; set; }
        public double total_otros_cargos { get; set; }
        public double total { get; set; }
        public dynamic percepcion_tipo { get; set; }
        public double percepcion_base_imponible { get; set; }
        public double total_percepcion { get; set; }
        public double total_incluido_percepcion { get; set; }
        public String detraccion { get; set; }
        public String observaciones { get; set; }
        public dynamic documento_que_se_modifica_tipo { get; set; }
        public string documento_que_se_modifica_serie { get; set; }
        public dynamic documento_que_se_modifica_numero { get; set; }
        public dynamic tipo_de_nota_de_credito { get; set; }
        public dynamic tipo_de_nota_de_debito { get; set; }
        public Boolean enviar_automaticamente_a_la_sunat { get; set; }
        public Boolean enviar_automaticamente_al_cliente { get; set; }
        public String codigo_unico { get; set; }
        public String condiciones_de_pago { get; set; }
        public String medio_de_pago { get; set; }
        public String placa_vehiculo { get; set; }
        public String orden_compra_servicio { get; set; }
        public String tabla_personalizada_codigo { get; set; }
        public String formato_de_pdf { get; set; }
        public List<SunatDocumentoDetalleFBN> items { get; set; }
        public List<SunatDocumentoGuias> guias { get; set; }

        public SunatDocumentoFBN_V2() { }

    }

    public class SunatDocumentoFBN
    {
        public string operacion { get; set; }
        public Int32 tipo_de_comprobante { get; set; }
        public string serie { get; set; }
        public Int32 numero { get; set; }
        public Int32 sunat_transaction { get; set; }
        public Int32 cliente_tipo_de_documento { get; set; }
        public string cliente_numero_de_documento { get; set; }
        public string cliente_denominacion { get; set; }
        public string cliente_direccion { get; set; }
        public string cliente_email { get; set; }
        public string cliente_email_1 { get; set; }
        public string cliente_email_2 { get; set; }
        public DateTime fecha_de_emision { get; set; }
        public DateTime fecha_de_vencimiento { get; set; }
        public Int32 moneda { get; set; }
        public double tipo_de_cambio { get; set; }
        public double porcentaje_de_igv { get; set; }
        public double descuento_global { get; set; }
        public double total_descuento { get; set; }
        public double total_anticipo { get; set; }
        public double total_gravada { get; set; }
        public double total_inafecta { get; set; }
        public double total_exonerada { get; set; }
        public double total_igv { get; set; }
        public double total_gratuita { get; set; }
        public double total_otros_cargos { get; set; }
        public double total { get; set; }
        public dynamic percepcion_tipo { get; set; }
        public double percepcion_base_imponible { get; set; }
        public double total_percepcion { get; set; }
        public double total_incluido_percepcion { get; set; }
        public String detraccion  { get; set; }
        public String observaciones { get; set; }
        public dynamic documento_que_se_modifica_tipo { get; set; }
        public string documento_que_se_modifica_serie { get; set; }
        public dynamic documento_que_se_modifica_numero { get; set; }
        public dynamic tipo_de_nota_de_credito { get; set; }
        public dynamic tipo_de_nota_de_debito { get; set; }
        public Boolean enviar_automaticamente_a_la_sunat { get; set; }
        public Boolean enviar_automaticamente_al_cliente { get; set; }
        public String codigo_unico { get; set; }
        public String condiciones_de_pago { get; set; }
        public String medio_de_pago { get; set; }
        public String placa_vehiculo { get; set; }
        public String orden_compra_servicio { get; set; }
        public String tabla_personalizada_codigo { get; set; }
        public String formato_de_pdf { get; set; }
        public List<SunatDocumentoDetalleFBN> items { get; set; }
        public List<SunatDocumentoGuias> guia { get; set; }

        public string cdocu { get; set; }
        public string ndocu { get; set; }

        public SunatDocumentoFBN() { }
        
    }

    public class SunatDocumentoDetalleFBN
    {
        public String unidad_de_medida { get; set; }
        public String codigo { get; set; }
        public String descripcion { get; set; }
        public double cantidad { get; set; }
        public double valor_unitario { get; set; }
        public double precio_unitario { get; set; }
        public double descuento { get; set; }
        public double subtotal { get; set; }
        public Int32 tipo_de_igv { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
        public Boolean anticipo_regularizacion { get; set; }
        public dynamic anticipo_documento_serie { get; set; }
        public dynamic anticipo_documento_numero { get; set; }
        

        public SunatDocumentoDetalleFBN() { }
    }

    public class SunatDocumentoGuias
    {
        public int guia_tipo { get; set; }
        public string guia_serie_numero { get; set; }

        public SunatDocumentoGuias(){}
    }

    public class SunatConsultaFBN
    {
        public string operacion { get; set; }
        public Int32 tipo_de_comprobante { get; set; }
        public string serie { get; set; }
        public Int32 numero { get; set; }

        public SunatConsultaFBN() { }
    }

    public class SunatRespuestaFBN
    {
        //public string errors { get; set; }
        public Int32 tipo_de_comprobante { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }
        public string enlace { get; set; }
        public bool aceptada_por_sunat { get; set; }
        public string sunat_description { get; set; }
        public string sunat_note { get; set; }
        public string sunat_responsecode { get; set; }
        public string sunat_soap_error { get; set; }
        public string pdf_zip_base64 { get; set; }
        public string xml_zip_base64 { get; set; }
        public string cdr_zip_base64 { get; set; }
        public string cadena_para_codigo_qr { get; set; }
        public string codigo_hash { get; set; }
        public string codigo_de_barras { get; set; }
        public string enlace_del_pdf { get; set; }
        public string enlace_del_xml { get; set; }
        public string enlace_del_cdr { get; set; }

        public string errors { get; set; }
        public string fe_codigo { get; set; }

        public SunatRespuestaFBN() { }
    }

    public class SunatGenerarAnulacionFBN
    {
        public string operacion { get; set; }
        public int tipo_de_comprobante { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }
        public string motivo { get; set; }
        public string codigo_unico { get; set; }

        public SunatGenerarAnulacionFBN() { }
    }

    public class SunatConsultarAnulacionFBN
    {
        public string operacion { get; set; }
        public int tipo_de_comprobante { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }

        public SunatConsultarAnulacionFBN() { }
    }

    public class SunatRespuestaAnulacionFBN
    {
        public int numero { get; set; }
        public string enlace { get; set; }
        public string sunat_ticket_numero { get; set; }
        public Boolean aceptada_por_sunat { get; set; }
        public string sunat_description { get; set; }
        public string sunat_note { get; set; }
        public string sunat_responsecode { get; set; }
        public string sunat_soap_error { get; set; }
        public string xml_zip_base64 { get; set; }
        public string pdf_zip_base64 { get; set; }
        public string cdr_zip_base64 { get; set; }

        public SunatRespuestaAnulacionFBN() { }

    }

}
