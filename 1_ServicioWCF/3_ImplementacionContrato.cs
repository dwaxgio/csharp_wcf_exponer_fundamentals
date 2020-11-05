using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ServicioWCF
{
    // 1. Se crea libreria de clases y
    // Se agrega referencia a la libreria System.ServiceModel
    // 3. Se implementa Interfaz (contrato)
    public class _3_ImplementacionContrato : _2_IContrato
    {
        public string ObtenerMensaje(string name)
        {
            return "Mensaje desde Contrato implementado " + name;
        }
    }
}
