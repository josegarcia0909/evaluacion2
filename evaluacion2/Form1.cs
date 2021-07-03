using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularprombutton_Click(object sender, EventArgs e)
        {
           
            Promedio NombreAlumno = new Promedio();
            NombreAlumno.Nombre = nombretextBox.Text;
            NombreAlumno.Cuenta = Convert.ToInt64(cuentatextBox.Text);
            NombreAlumno.Nota1 = Convert.ToInt32(nota1textBox.Text);
            NombreAlumno.Nota2 = Convert.ToInt32(nota2textBox.Text);
            NombreAlumno.Nota3 = Convert.ToInt32(nota3textBox.Text);
            NombreAlumno.Nota4 = Convert.ToInt32(nota4textBox.Text);
            
            int promedio = NombreAlumno.promedionotas();


            MessageBox.Show(NombreAlumno.Nombre + " " +  "Cuenta" + " " + NombreAlumno.Cuenta);

            MessageBox.Show(Convert.ToString(promedio));
            
            string resultadoAprobar = NombreAlumno.aprobacion();
            MessageBox.Show(Convert.ToString(resultadoAprobar));
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            nombretextBox.Clear();
            cuentatextBox.Clear();
            nota1textBox.Clear();
            nota2textBox.Clear();
            nota3textBox.Clear();
            nota4textBox.Clear();
        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
