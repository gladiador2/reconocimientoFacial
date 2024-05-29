
using Reconocimiento_facial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace CBA.FlowV2.Caja.PantallaInicio
{
    public partial class Inicio_Form : Form
    {
        private bool abrirform = true;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public Inicio_Form()
        {
            InitializeComponent();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 30));
        }

        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        private async void Inicio_Form_Load(object sender, EventArgs e)
        {
            
            int totalSteps = 100;
            int currentStep = 0;
            this.Text = String.Format("Acerca de {0}", AssemblyTitle);
            this.lblNombre.Text = "SecureFace Pro"; //AssemblyProduct;
            this.lblVersion.Text = String.Format("Versión {0}", AssemblyVersion);
            this.lblCopi.Text = AssemblyCopyright;
            this.lblCompania.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
            await Task.Delay(5000);
            abrirLoguin(true);

            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromMilliseconds(20); 
            //timer.Tick += (s, args) =>
            //{
            //    if (currentStep < totalSteps)
            //        currentStep++;
            //    progressBar1.Value = currentStep;

            //    if (currentStep == totalSteps)
            //    {
            //        abrirLoguin(abrirform);
            //        abrirform = false;
            //    }
            //};


            // Iniciar el temporizador
            //timer.Start();
        }
        private void abrirLoguin(bool abrir) 
        {
            if (abrir) 
            {
                Loguin wpfForm = new Loguin(this);
                // Iniciar un nuevo hilo de aplicación WPF y mostrar el formulario WPF en ese hilo
                //Thread wpfThread = new Thread(() =>
                //{
                //    System.Windows.Threading.Dispatcher.Run();
                //});
                Thread wpfThread = new Thread(() =>
                {
                    // Mostrar el formulario de WPF desde el hilo de la interfaz de usuario
                    wpfForm.Dispatcher.Invoke(() => wpfForm.ShowDialog());

                    // Cerrar el formulario de Windows después de que el formulario de WPF se haya cerrado
                    System.Windows.Threading.Dispatcher.CurrentDispatcher.InvokeShutdown();
                });

                wpfThread.SetApartmentState(ApartmentState.STA);
                wpfThread.Start();
            }
            
        }
    }
}
