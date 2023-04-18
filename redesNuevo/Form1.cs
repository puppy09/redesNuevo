using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace redesNuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public String[] octetos = new String[4];
        public int[] octetos_int = new int[4];
        public string[] octetos_bit = new string[4];
        public String[] mascara_str = new string[4];
        public int[] mascara_int = new int[4];
        public String[] mascara_bit = new string[4];
        public String mascara="";
        public String idRed ="";
        public String clase = "";

        private void rbnSubredes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnSubredes.Checked == true)
            {
                tbxSubredes.Enabled = true;
            }
            else
            {
                tbxSubredes.Enabled = false;
            }
        }

        private void rbnHost_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnHost.Checked == true)
            {
                tbxHost.Enabled = true;
            }
            else
            {
                tbxHost.Enabled = false;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Se captura el id de red inicial
            idRed = tbxIdRed.Text;
            //Se hace un split guardandolo en un array
            octetos = idRed.Split('.');
            //Se hace un for para convertir cada elemento del array en int
            for (int i = 0; i < 4;i++)
            {
                octetos_int[i] = Convert.ToInt16(octetos[i]);
                octetos_bit[i] = Convert.ToString(octetos_int[i], 2);
            }
            //Se hacen ifs para validar la clase de la id brindada
            //a partir de eso se calculara su mascara que estara guardad en una variable
            if (octetos_int[0] >= 0 && octetos_int[0] <= 127)
            {
                //Se guarda en una variable
                mascara = "255.0.0.0";
                //Se hace un split a esa variable guardandola en un array de tipo string
                mascara_str = mascara.Split('.');
                //Se pasa a un array de tipo int
                //Posterior a eso se pasara a un array de tipo string 
                //esto se hace para lograr convertir un arreglo donde en vez de
                //encontrarse el numero representado en decimal,
                //se encontrara en binario
                for (int i = 0; i < 4; i++)
                {
                    mascara_int[i] = Convert.ToInt16(mascara_str[i]);
                    mascara_bit[i] = Convert.ToString(mascara_int[i], 2);
                    tbxNewMasc.Text = mascara_bit[0];
                    tbxHosPra.Text = mascara_int[0].ToString();
                }
                
                //Se hace un for para convertir cada elemento de int a byte
                /*for (int i = 0; i < 4; i++)
                {
                    mascara_byt[i] = Convert.ToByte(mascara_int[i]);
                }
                //Se determina su clase
                clase = "A";
            }
            else if (octetos_int[0] >= 128 && octetos_int[0] <= 191)
            {
                //Se guarda en una variable
                mascara = "255.255.0.0";
                //Se hace un split a esa variable guardandola en un array de tipo string
                mascara_str = mascara.Split('.');
                //Se pasa a un array de tipo int
                for (int i = 0; i < 4; i++)
                {
                    mascara_int[i] = Convert.ToInt16(mascara_str[i]);
                }
                //Se hace un for para convertir cada elemento de int a byte
                for (int i = 0; i < 4; i++)
                {
                    mascara_byte[i] = Convert.ToByte(mascara_int[i]);
                }
                //Se determina su clase
                clase = "B";
            }
            else if (octetos_int[0]>=192 && octetos_int[0] <= 223)
            {
                //Se guarda en una variable
                mascara = "255.255.255.0";
                //Se hace un split a esa variable guardandola en un array de tipo string
                mascara_str = mascara.Split('.');
                //Se pasa a un array de tipo int
                for (int i = 0; i < 4; i++)
                {
                    mascara_int[i] = Convert.ToInt16(mascara_str[i]);
                }
                //Se hace un for para convertir cada elemento de int a byte
                for (int i = 0; i < 4; i++)
                {
                    mascara_byte[i] = Convert.ToByte(mascara_int[i]);
                }
                //Se determina su clase
                clase = "C";*/
            }
        }
        public void limpiar()
        {
           /* i = 0;
            j = 0;
            aux = 0;
            aux2 = 0;
            aux2_int = 0;
            aux3 = 0;
            idRed = "";
            mascara = "";
            mascara_desa = "";
            mascara_Nueva = "";
            subredes = 0;
            subredesPrac = 0;
            host = 0;
            hostPrac = 0;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}