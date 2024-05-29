using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial.Resources
{
    public partial class FormLoguin : Form
    {
        public FormLoguin()
        {
            InitializeComponent();
        }

        private void FormLoguin_Load(object sender, EventArgs e)
        {
            this.Hide();
            // Crear e instanciar el formulario WPF
            Loguin wpfForm = new Loguin();
            // Iniciar un nuevo hilo de aplicación WPF y mostrar el formulario WPF en ese hilo
            Thread wpfThread = new Thread(() =>
            {
                System.Windows.Threading.Dispatcher.Run();
            });

            wpfThread.SetApartmentState(ApartmentState.STA);
            wpfThread.Start();
           
            wpfForm.Show();
           
        }
    }
}
