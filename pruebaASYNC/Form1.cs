using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace pruebaASYNC
{
    public partial class Form1 : Form
    {
        SerialPort PuertoArduino; //defino serialPOrt
        
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<List<string[]>> Resultado_LeerArduino() //metodo asincrono 
        {
            return await Task.Run(() => LeerArduino());
        }
        public List<string[]> LeerArduino() //metodo para leer lo que se envia desde arduino, se obtiene una lista como la que te envie a fb
        {
            try
            {
                string DatosArduino = PuertoArduino.ReadLine();
                string[] arrayDatosArduino = DatosArduino.Replace("SEND", "").Replace("\n", "").Split('-'); //
                string[] DatosSectoresArduino;
                List<string[]> ListaSectoresArduino = new List<string[]>();
                foreach (string elemento in arrayDatosArduino)
                {
                    DatosSectoresArduino = elemento.Split(',');
                    ListaSectoresArduino.Add(DatosSectoresArduino);
                }
                return ListaSectoresArduino;
            }
            catch
            {
                return new List<string[]>();
            }
        }

        public async void EscribirInformacion()
        {
            string Informacion;
            while (PuertoArduino.IsOpen)
            {
                try
                {
                    List<string[]> LeerArduino = await Resultado_LeerArduino();
                    Informacion = LeerArduino[0][0];
                    txtDatos.Text = Informacion;
                }
                catch (Exception)
                {}                
            }
        }
        private void btnPrender_Apagar_Click(object sender, EventArgs e)
        {
            if (btnPrender_Apagar.Text == "Prender")
            {
                PuertoArduino= new SerialPort();
                PuertoArduino.PortName = "COM5";
                PuertoArduino.BaudRate = 9600;
                PuertoArduino.WriteTimeout = 300;
                PuertoArduino.Open();
                EscribirInformacion();
                btnPrender_Apagar.Text = "Apagar";
            }
            else if (btnPrender_Apagar.Text == "Apagar")
            {
                PuertoArduino.Close();
                btnPrender_Apagar.Text = "Prender";
            }
        }

        private void btnSector1_Click(object sender, EventArgs e)
        {
            Form MyForm2 = new Form2(this);
            MyForm2.Show();
        }

        private void btnSector2_Click(object sender, EventArgs e)
        {

        }

        private void btnSector3_Click(object sender, EventArgs e)
        {

        }
    }
}
