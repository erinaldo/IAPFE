﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IAP.Win.ServicioAndroid {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://suarpe.com/", ConfigurationName="ServicioAndroid.ServicioClientesSoap")]
    public interface ServicioClientesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/LoginUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string LoginUsuario(string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/LoginUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<string> LoginUsuarioAsync(string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/crearXML2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode crearXML2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/crearXML2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> crearXML2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string consultar_pedidos(string ruc, string fechainicial, string fechafinal, string estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos", ReplyAction="*")]
        System.Threading.Tasks.Task<string> consultar_pedidosAsync(string ruc, string fechainicial, string fechafinal, string estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos_eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string consultar_pedidos_eliminar(string ruc, string fechainicial, string fechafinal, string estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos_eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string> consultar_pedidos_eliminarAsync(string ruc, string fechainicial, string fechafinal, string estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/buscar_pedidos_aprobados_precios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string buscar_pedidos_aprobados_precios(string ruc, string fechainicial, string fechafinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/buscar_pedidos_aprobados_precios", ReplyAction="*")]
        System.Threading.Tasks.Task<string> buscar_pedidos_aprobados_preciosAsync(string ruc, string fechainicial, string fechafinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_familias", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string listar_familias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_familias", ReplyAction="*")]
        System.Threading.Tasks.Task<string> listar_familiasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_subfamilias", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string listar_subfamilias(string familias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_subfamilias", ReplyAction="*")]
        System.Threading.Tasks.Task<string> listar_subfamiliasAsync(string familias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_articulos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string listar_articulos(string subfamilias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_articulos", ReplyAction="*")]
        System.Threading.Tasks.Task<string> listar_articulosAsync(string subfamilias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_articulos_stock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string listar_articulos_stock(string subfamilias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/listar_articulos_stock", ReplyAction="*")]
        System.Threading.Tasks.Task<string> listar_articulos_stockAsync(string subfamilias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/iniciar_sesionv2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string iniciar_sesionv2(string usuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/iniciar_sesionv2", ReplyAction="*")]
        System.Threading.Tasks.Task<string> iniciar_sesionv2Async(string usuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/registrar_pedido", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string registrar_pedido(string pedido, string pedido_linea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/registrar_pedido", ReplyAction="*")]
        System.Threading.Tasks.Task<string> registrar_pedidoAsync(string pedido, string pedido_linea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/cancelar_pedido", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string cancelar_pedido(string pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/cancelar_pedido", ReplyAction="*")]
        System.Threading.Tasks.Task<string> cancelar_pedidoAsync(string pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/resumen_pedido", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string resumen_pedido(string pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/resumen_pedido", ReplyAction="*")]
        System.Threading.Tasks.Task<string> resumen_pedidoAsync(string pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/estados_cuenta_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string estados_cuenta_cliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/estados_cuenta_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<string> estados_cuenta_clienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/Listar_usuarios_android_pc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Listar_usuarios_android_pc(string tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/Listar_usuarios_android_pc", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> Listar_usuarios_android_pcAsync(string tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos_pc_cabecera", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable consultar_pedidos_pc_cabecera(string fecha_inicial, string fecha_final, string ruc, string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos_pc_cabecera", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> consultar_pedidos_pc_cabeceraAsync(string fecha_inicial, string fecha_final, string ruc, string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos_pc_detalle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable consultar_pedidos_pc_detalle(string pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/consultar_pedidos_pc_detalle", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> consultar_pedidos_pc_detalleAsync(string pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/actualizar_pedidos_pc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_pedidos_pc(IAP.Win.ServicioAndroid.cls_pedido cls_pedido, System.Data.DataTable dt_pedido_linea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/actualizar_pedidos_pc", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_pedidos_pcAsync(IAP.Win.ServicioAndroid.cls_pedido cls_pedido, System.Data.DataTable dt_pedido_linea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/ConsultaArticulos_pc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable ConsultaArticulos_pc(string familia, string articulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/ConsultaArticulos_pc", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> ConsultaArticulos_pcAsync(string familia, string articulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/Actualizar_lista_articulos_pc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Actualizar_lista_articulos_pc(System.Data.DataTable dt_articulos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/Actualizar_lista_articulos_pc", ReplyAction="*")]
        System.Threading.Tasks.Task<int> Actualizar_lista_articulos_pcAsync(System.Data.DataTable dt_articulos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/Insertar_articulos_pc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Insertar_articulos_pc(System.Data.DataTable dt_articulos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://suarpe.com/Insertar_articulos_pc", ReplyAction="*")]
        System.Threading.Tasks.Task<int> Insertar_articulos_pcAsync(System.Data.DataTable dt_articulos);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://suarpe.com/")]
    public partial class cls_pedido : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string documentoField;
        
        private string condicion_PagoField;
        
        private string estadoField;
        
        private System.DateTime fechaField;
        
        private string clienteField;
        
        private string nombre_ClienteField;
        
        private string direccion_ClienteField;
        
        private double totalField;
        
        private double subTotalField;
        
        private double igvField;
        
        private string fecha_EntregaField;
        
        private string estado_ClienteField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Documento {
            get {
                return this.documentoField;
            }
            set {
                this.documentoField = value;
                this.RaisePropertyChanged("Documento");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Condicion_Pago {
            get {
                return this.condicion_PagoField;
            }
            set {
                this.condicion_PagoField = value;
                this.RaisePropertyChanged("Condicion_Pago");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("Estado");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
                this.RaisePropertyChanged("Fecha");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
                this.RaisePropertyChanged("Cliente");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Nombre_Cliente {
            get {
                return this.nombre_ClienteField;
            }
            set {
                this.nombre_ClienteField = value;
                this.RaisePropertyChanged("Nombre_Cliente");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Direccion_Cliente {
            get {
                return this.direccion_ClienteField;
            }
            set {
                this.direccion_ClienteField = value;
                this.RaisePropertyChanged("Direccion_Cliente");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public double Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
                this.RaisePropertyChanged("Total");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public double SubTotal {
            get {
                return this.subTotalField;
            }
            set {
                this.subTotalField = value;
                this.RaisePropertyChanged("SubTotal");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public double Igv {
            get {
                return this.igvField;
            }
            set {
                this.igvField = value;
                this.RaisePropertyChanged("Igv");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Fecha_Entrega {
            get {
                return this.fecha_EntregaField;
            }
            set {
                this.fecha_EntregaField = value;
                this.RaisePropertyChanged("Fecha_Entrega");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Estado_Cliente {
            get {
                return this.estado_ClienteField;
            }
            set {
                this.estado_ClienteField = value;
                this.RaisePropertyChanged("Estado_Cliente");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioClientesSoapChannel : IAP.Win.ServicioAndroid.ServicioClientesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioClientesSoapClient : System.ServiceModel.ClientBase<IAP.Win.ServicioAndroid.ServicioClientesSoap>, IAP.Win.ServicioAndroid.ServicioClientesSoap {
        
        public ServicioClientesSoapClient() {
        }
        
        public ServicioClientesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioClientesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClientesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClientesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string LoginUsuario(string user, string password) {
            return base.Channel.LoginUsuario(user, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginUsuarioAsync(string user, string password) {
            return base.Channel.LoginUsuarioAsync(user, password);
        }
        
        public System.Xml.XmlNode crearXML2() {
            return base.Channel.crearXML2();
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> crearXML2Async() {
            return base.Channel.crearXML2Async();
        }
        
        public string consultar_pedidos(string ruc, string fechainicial, string fechafinal, string estado) {
            return base.Channel.consultar_pedidos(ruc, fechainicial, fechafinal, estado);
        }
        
        public System.Threading.Tasks.Task<string> consultar_pedidosAsync(string ruc, string fechainicial, string fechafinal, string estado) {
            return base.Channel.consultar_pedidosAsync(ruc, fechainicial, fechafinal, estado);
        }
        
        public string consultar_pedidos_eliminar(string ruc, string fechainicial, string fechafinal, string estado) {
            return base.Channel.consultar_pedidos_eliminar(ruc, fechainicial, fechafinal, estado);
        }
        
        public System.Threading.Tasks.Task<string> consultar_pedidos_eliminarAsync(string ruc, string fechainicial, string fechafinal, string estado) {
            return base.Channel.consultar_pedidos_eliminarAsync(ruc, fechainicial, fechafinal, estado);
        }
        
        public string buscar_pedidos_aprobados_precios(string ruc, string fechainicial, string fechafinal) {
            return base.Channel.buscar_pedidos_aprobados_precios(ruc, fechainicial, fechafinal);
        }
        
        public System.Threading.Tasks.Task<string> buscar_pedidos_aprobados_preciosAsync(string ruc, string fechainicial, string fechafinal) {
            return base.Channel.buscar_pedidos_aprobados_preciosAsync(ruc, fechainicial, fechafinal);
        }
        
        public string listar_familias() {
            return base.Channel.listar_familias();
        }
        
        public System.Threading.Tasks.Task<string> listar_familiasAsync() {
            return base.Channel.listar_familiasAsync();
        }
        
        public string listar_subfamilias(string familias) {
            return base.Channel.listar_subfamilias(familias);
        }
        
        public System.Threading.Tasks.Task<string> listar_subfamiliasAsync(string familias) {
            return base.Channel.listar_subfamiliasAsync(familias);
        }
        
        public string listar_articulos(string subfamilias) {
            return base.Channel.listar_articulos(subfamilias);
        }
        
        public System.Threading.Tasks.Task<string> listar_articulosAsync(string subfamilias) {
            return base.Channel.listar_articulosAsync(subfamilias);
        }
        
        public string listar_articulos_stock(string subfamilias) {
            return base.Channel.listar_articulos_stock(subfamilias);
        }
        
        public System.Threading.Tasks.Task<string> listar_articulos_stockAsync(string subfamilias) {
            return base.Channel.listar_articulos_stockAsync(subfamilias);
        }
        
        public string iniciar_sesionv2(string usuario, string password) {
            return base.Channel.iniciar_sesionv2(usuario, password);
        }
        
        public System.Threading.Tasks.Task<string> iniciar_sesionv2Async(string usuario, string password) {
            return base.Channel.iniciar_sesionv2Async(usuario, password);
        }
        
        public string registrar_pedido(string pedido, string pedido_linea) {
            return base.Channel.registrar_pedido(pedido, pedido_linea);
        }
        
        public System.Threading.Tasks.Task<string> registrar_pedidoAsync(string pedido, string pedido_linea) {
            return base.Channel.registrar_pedidoAsync(pedido, pedido_linea);
        }
        
        public string cancelar_pedido(string pedido) {
            return base.Channel.cancelar_pedido(pedido);
        }
        
        public System.Threading.Tasks.Task<string> cancelar_pedidoAsync(string pedido) {
            return base.Channel.cancelar_pedidoAsync(pedido);
        }
        
        public string resumen_pedido(string pedido) {
            return base.Channel.resumen_pedido(pedido);
        }
        
        public System.Threading.Tasks.Task<string> resumen_pedidoAsync(string pedido) {
            return base.Channel.resumen_pedidoAsync(pedido);
        }
        
        public string estados_cuenta_cliente() {
            return base.Channel.estados_cuenta_cliente();
        }
        
        public System.Threading.Tasks.Task<string> estados_cuenta_clienteAsync() {
            return base.Channel.estados_cuenta_clienteAsync();
        }
        
        public System.Data.DataTable Listar_usuarios_android_pc(string tabla) {
            return base.Channel.Listar_usuarios_android_pc(tabla);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Listar_usuarios_android_pcAsync(string tabla) {
            return base.Channel.Listar_usuarios_android_pcAsync(tabla);
        }
        
        public System.Data.DataTable consultar_pedidos_pc_cabecera(string fecha_inicial, string fecha_final, string ruc, string cliente) {
            return base.Channel.consultar_pedidos_pc_cabecera(fecha_inicial, fecha_final, ruc, cliente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> consultar_pedidos_pc_cabeceraAsync(string fecha_inicial, string fecha_final, string ruc, string cliente) {
            return base.Channel.consultar_pedidos_pc_cabeceraAsync(fecha_inicial, fecha_final, ruc, cliente);
        }
        
        public System.Data.DataTable consultar_pedidos_pc_detalle(string pedido) {
            return base.Channel.consultar_pedidos_pc_detalle(pedido);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> consultar_pedidos_pc_detalleAsync(string pedido) {
            return base.Channel.consultar_pedidos_pc_detalleAsync(pedido);
        }
        
        public int actualizar_pedidos_pc(IAP.Win.ServicioAndroid.cls_pedido cls_pedido, System.Data.DataTable dt_pedido_linea) {
            return base.Channel.actualizar_pedidos_pc(cls_pedido, dt_pedido_linea);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_pedidos_pcAsync(IAP.Win.ServicioAndroid.cls_pedido cls_pedido, System.Data.DataTable dt_pedido_linea) {
            return base.Channel.actualizar_pedidos_pcAsync(cls_pedido, dt_pedido_linea);
        }
        
        public System.Data.DataTable ConsultaArticulos_pc(string familia, string articulo) {
            return base.Channel.ConsultaArticulos_pc(familia, articulo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ConsultaArticulos_pcAsync(string familia, string articulo) {
            return base.Channel.ConsultaArticulos_pcAsync(familia, articulo);
        }
        
        public int Actualizar_lista_articulos_pc(System.Data.DataTable dt_articulos) {
            return base.Channel.Actualizar_lista_articulos_pc(dt_articulos);
        }
        
        public System.Threading.Tasks.Task<int> Actualizar_lista_articulos_pcAsync(System.Data.DataTable dt_articulos) {
            return base.Channel.Actualizar_lista_articulos_pcAsync(dt_articulos);
        }
        
        public int Insertar_articulos_pc(System.Data.DataTable dt_articulos) {
            return base.Channel.Insertar_articulos_pc(dt_articulos);
        }
        
        public System.Threading.Tasks.Task<int> Insertar_articulos_pcAsync(System.Data.DataTable dt_articulos) {
            return base.Channel.Insertar_articulos_pcAsync(dt_articulos);
        }
    }
}
