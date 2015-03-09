using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace serializar
{
    public class serializar
    {
        
        public String nombre_Encargado { get; set; }
        public String Apellido_Encargado { get; set; }
        public String telefono_Encargado { get; set; }




        public String nombre { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public String encargado { get; set; }
        public String carnet { get; set; }
        
        public void save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(serializar));
                XML.Serialize(stream, this);
            }
        }
    }
}
