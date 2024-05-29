using Reconocimiento_facial.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public partial class Frm_panel : Form
    {
        public Frm_panel()
        {
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e) 
        {
        base.OnLoad(e);
            using (ReconocimientoDb db = new ReconocimientoDb())
            {
                lblNumPersonas.Text = db.Personas.Count().ToString();
                lblTotalConAntecentes.Text = db.Personas.Count(p => p.Antecedentes.Any()).ToString();
                lblTotalSinAntecedentes.Text = db.Personas.Count(p => !p.Antecedentes.Any()).ToString();
                lblNumfotos.Text = db.Fotos.Count().ToString();
                lblNumantecedentes.Text = db.Antecedentes.Count().ToString();
                decimal sinAntecedentes = db.Personas.Count(p => !p.Antecedentes.Any());
                decimal conAntecedentes = db.Personas.Count(p => p.Antecedentes.Any());
                decimal total = (decimal)db.Personas.Count();
               decimal porAntecedentes = (conAntecedentes / total) * 100;
                decimal porSinAntecedentes = (sinAntecedentes / total) * 100;
                lblPorcentajeAntecedentes.Text = porAntecedentes.ToString("0.0") + "%";
                lblPorcentajeSinAntecedentes.Text = porSinAntecedentes.ToString("0.0") + "%";

            }
                
        }
    }
}
