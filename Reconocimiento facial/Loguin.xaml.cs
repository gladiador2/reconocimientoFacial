using CBA.FlowV2.Caja.Notificaciones;
using CBA.FlowV2.Caja.PantallaInicio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reconocimiento_facial
{
    /// <summary>
    /// Lógica de interacción para Loguin.xaml
    /// </summary>
    public partial class Loguin : Window
    {
        Inicio_Form inicioForm;
        public Loguin()
        {
            InitializeComponent();
        }
        public Loguin(Inicio_Form formInicio)
        {
            inicioForm = formInicio;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Loguear();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            inicioForm.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        public void animar()
        {
            var fadeAnimation = new DoubleAnimation();
            fadeAnimation.From = 1;
            fadeAnimation.To = 0;
            fadeAnimation.AutoReverse = true;

            Imagelogo.BeginAnimation(OpacityProperty, fadeAnimation);
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            inicioForm.Hide();
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            animar();
        }
        private void Loguear()
        {
            try
            {

                using (ReconocimientoDb db = new ReconocimientoDb())
                {
                    var usuario = db.Usuarios.FirstOrDefault(u => u.Usernsme == textBoxUsuario.Text && u.Contrasenha == textBoxContrasena.Password);
                    if (usuario != null)
                    {
                        
                        Reconocimiento_facial.FormPrincipal form = new Reconocimiento_facial.FormPrincipal(inicioForm);
                        this.Hide();
                        form.Show();

                    }
                    else
                        throw new Exception("Usuario y/o contraseña incorrectos");
                }

            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Form_Alert.enmType.Error);

            }
        }

        private void textBoxContrasena_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Loguear();
            }
        }
    }
}
