using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.XPath;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    public bool Login(string user, string pass)
    {
       if(user.Equals("Erick") && pass.Equals("Erick2026"))
       {
           return true;
       }
       else
       {
           return false;
       }
    }

    public int procesarPago(int total, int pago)
    {
       if(pago >= total)
        {
            return pago - total;
        }
        else
        {
            return -1; 
        }
    }
}
 