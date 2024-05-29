using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconocimiento_facial
{
   public class utilidadesClass
    {
       private readonly static utilidadesClass _instance = new utilidadesClass();

       public static utilidadesClass Instance
       {
           get
           {
               return _instance;
           }
          
       }



       public byte[] ObtenerBytesDeImagen(string rutaImagen)
       {
           return File.ReadAllBytes(rutaImagen);
       }
       public Image ObtenerImagenDesdeBytes(byte[] bytes)
       {
           if (bytes == null || bytes.Length == 0)
           {
               return null;
           }

           using (MemoryStream ms = new MemoryStream(bytes))
           {
               return Image.FromStream(ms);
           }
       }
      public Image CargarImagenDesdeArchivo(string rutaArchivo)
    {
        try
        {
            // Cargar la imagen desde la ruta del archivo
            Image imagen = Image.FromFile(rutaArchivo);
            return imagen;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    }
}
