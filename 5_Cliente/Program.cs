using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5_Cliente;

namespace _5_Cliente
{
    class Program
    {
        /*
         * "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\SvcUtil.exe" https://localhost:44327/4_HostServer/4_2_PrimerServicioWCF.svc?wsdl /out:PrimerServicioWCFRef.cs /config:app.config
         */
        static void Main(string[] args)
        {
            // 6. Se inicializa el objeto cliente del servicio
            //var client = new PrimerServicioWCFClient();
            var client = new _2_IContratoClient();
            Console.WriteLine(client.ObtenerMensaje("Mensaje desde el cliente"));
        }
    }
}
