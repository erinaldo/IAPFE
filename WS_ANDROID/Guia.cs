using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Guia
    {
        public DateTime Fecha            {get;set;}
        public string Cdocu            {get;set;}
        public string Ndocu            {get;set;}
        public string Crefe            {get;set;}
        public string Nrefe            {get;set;}
        public string Orde             {get;set;}
        public string Codcli           {get;set;}
        public string Nomcli           {get;set;}
        public string Ruccli           {get;set;}
        public string Dircli           {get;set;}
        public string Codcdv           {get;set;}
        public string Condicionventa   {get;set;}
        public string Mone             {get;set;}
        public double Tcam             {get;set;}
        public double Tota             {get;set;}
        public double Toti             {get;set;}
        public double Totn             {get;set;}
        public string Codven           {get;set;}
        public string Nomven           {get;set;}
        public string Flag             {get;set;}

    }

    public class DetalleGuia
    {
        public string Cdocu    {get;set;}
        public string Ndocu    {get;set;}
        public int Item     {get;set;}
        public string Codi     {get;set;}
        public string Codf     {get;set;}
        public string Marc     {get;set;}
        public string Descr    {get;set;}
        public string Umed     {get;set;}
        public double Cant     {get;set;}
        public double Preu     {get;set;}
        public double Tota     {get;set;}
        public double Totn     {get;set;}
        public string Mone     {get;set;}

    }
}
