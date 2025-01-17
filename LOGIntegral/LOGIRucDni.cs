using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace LOGIntegral
{
    internal class LOGIRucDni
    {
        public static string dni;
        public static string nombres;
        public static string apellidoPaterno;
        public static string apellidoMaterno;
        public static string codVerifica;

        public static string ruc;
        public static string razonSocial;
        public static object nombreComercial;
        public static List<object> telefonos;
        public static object tipo;
        public static string estado;
        public static string condicion;
        public static string direccion;
        public static string departamento;
        public static string provincia;
        public static string distrito;
        public static object fechaInscripcion;
        public static object sistEmsion;
        public static object sistContabilidad;
        public static object actExterior;
        public static List<object> actEconomicas;
        public static List<object> cpPago;
        public static List<object> sistElectronica;
        public static object fechaEmisorFe;
        public static List<object> cpeElectronico;
        public static object fechaPle;
        public static List<object> padrones;
        public static object fechaBaja;
        public static object profesion;
        public static string ubigeo;
        public static string capital;

        public void RUCJson(string rucvalor)
        {
            RUC rUC;
            var url = $"https://dniruc.apisperu.com/api/v1/ruc/{rucvalor}?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImdyZWdvcmlvLm9kdWJlckBnbWFpbC5jb20ifQ.FbIeODpiNo-WpOjabdmODYRW-NYc93l6kHBcseDrGBw";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                rUC = JsonConvert.DeserializeObject<RUC>(json);
            }
            ruc = rUC.ruc;
            razonSocial = rUC.razonSocial;
            nombreComercial = rUC.nombreComercial;
            telefonos = rUC.telefonos;
            tipo = rUC.tipo;
            estado = rUC.estado;
            condicion = rUC.condicion;
            direccion = rUC.direccion;
            departamento = rUC.departamento;
            provincia = rUC.provincia;
            distrito = rUC.distrito;
            fechaInscripcion = rUC.fechaInscripcion;
            sistEmsion = rUC.sistEmsion;
            sistContabilidad = rUC.sistContabilidad;
            actExterior = rUC.actExterior;
            actEconomicas = rUC.actEconomicas;
            cpPago = rUC.cpPago;
            sistElectronica = rUC.sistElectronica;
            fechaEmisorFe = rUC.fechaEmisorFe;
            cpeElectronico = rUC.cpeElectronico;
            fechaPle = rUC.fechaPle;
            padrones = rUC.padrones;
            fechaBaja = rUC.fechaBaja;
            profesion = rUC.profesion;
            ubigeo = rUC.ubigeo;
            capital = rUC.capital;
        }

        public void DNIJson(string valordni)
        {
            DNI dNI;
            var url = $"https://dniruc.apisperu.com/api/v1/dni/{valordni}?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImdyZWdvcmlvLm9kdWJlckBnbWFpbC5jb20ifQ.FbIeODpiNo-WpOjabdmODYRW-NYc93l6kHBcseDrGBw";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                dNI = JsonConvert.DeserializeObject<DNI>(json);
            }
            dni = dNI.dni;
            nombres = dNI.nombres;
            apellidoPaterno = dNI.apellidoPaterno;
            apellidoMaterno = dNI.apellidoMaterno;
            codVerifica = dNI.codVerifica;
        }
    }

    public class RUC
    {
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public object nombreComercial { get; set; }
        public List<object> telefonos { get; set; }
        public object tipo { get; set; }
        public string estado { get; set; }
        public string condicion { get; set; }
        public string direccion { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public object fechaInscripcion { get; set; }
        public object sistEmsion { get; set; }
        public object sistContabilidad { get; set; }
        public object actExterior { get; set; }
        public List<object> actEconomicas { get; set; }
        public List<object> cpPago { get; set; }
        public List<object> sistElectronica { get; set; }
        public object fechaEmisorFe { get; set; }
        public List<object> cpeElectronico { get; set; }
        public object fechaPle { get; set; }
        public List<object> padrones { get; set; }
        public object fechaBaja { get; set; }
        public object profesion { get; set; }
        public string ubigeo { get; set; }
        public string capital { get; set; }
    }
    public class DNI
    {
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string codVerifica { get; set; }
    }
}
