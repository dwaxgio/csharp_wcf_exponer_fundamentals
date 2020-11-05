using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; // Hacer referencia a using

namespace _1_ServicioWCF
{
    [ServiceContract]
    public interface _2_IContrato
    {
        [OperationContract]
        string ObtenerMensaje(string name);
    }
}
