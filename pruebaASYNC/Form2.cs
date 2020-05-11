using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaASYNC
{
    public partial class Form2 : Form
    {
        Form1 formulario1;
        public Form2(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }
        public async void dato()
        {
            while (true)
            {
                try
                {           
                    List<string[]> Lista = await formulario1.Resultado_LeerArduino();
                    textBox1.Text = Lista[1][0];
                }
                catch { }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dato();
        }

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    Form1 MyForm1 = Owner as Form1;
        //    List<string[]> Lista = await MyForm1.Resultado_LeerArduino();
        //    textBox1.Text = Lista[1][1]; 
        //}
    }
}
