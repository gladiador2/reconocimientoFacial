using CBA.FlowV2.Caja.Notificaciones;
using CBA.FlowV2.Caja.PantallaInicio;
using Reconocimiento_facial.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public static class Alert
    {

        public static void Show(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
    }
    static class Program
    {
       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Crear una nueva CultureInfo con el formato de fecha deseado
            CultureInfo culturaPersonalizada = new CultureInfo("es-ES"); // Puedes ajustar la cultura según tus necesidades
            culturaPersonalizada.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"; // Establecer el formato de fecha deseado
            //AutoActualizarClass.Actualizar();

            // Aplicar la cultura personalizada a la aplicación
            System.Threading.Thread.CurrentThread.CurrentCulture = culturaPersonalizada;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio_Form());
        }
    }
}
