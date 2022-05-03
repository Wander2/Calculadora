using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculadora_Rd
{
    public partial class Form1 : Form
    {
        double Numero1=0, Numero2=0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int WMsg, int wParam, int lParam);


        private void agregarnumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (textPRUEBA.Text=="0")
                textPRUEBA.Text="";
            textPRUEBA.Text+=boton.Text;
        }

        private void BTNRESULTADODETODO_Click(object sender, EventArgs e)
        {
            Numero2= Convert.ToDouble(textPRUEBA.Text);

            if (operador == '+')
            {
                textPRUEBA.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textPRUEBA.Text);
            }
            else if(operador == '-')
            {
                if(textPRUEBA.Text !="0")
                textPRUEBA.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(textPRUEBA.Text);
            }
            else if (operador == 'x')
            {
                textPRUEBA.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textPRUEBA.Text);
            }
            else if (operador == '÷')
            {
                if (textPRUEBA.Text != "0")
                {
                    textPRUEBA.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(textPRUEBA.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero esta cantidad!!");
                }
                
            }
        }

        private void BTNBORRAR_Click(object sender, EventArgs e)
        {
            if (textPRUEBA.Text.Length > 1)
            {
                textPRUEBA.Text = textPRUEBA.Text.Substring(0,textPRUEBA.Text.Length - 1);
            }
            else
            {
                textPRUEBA.Text = "0";
            }
        }

        private void BTNBORRARTODO_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            operador='\0';
            textPRUEBA.Text = "0";
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            textPRUEBA.Text = "0";
        }

        private void BTNPUTNO_Click(object sender, EventArgs e)
        {
            if (!textPRUEBA.Text.Contains(".")) 
            { 
                textPRUEBA.Text += "."; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(textPRUEBA.Text);
            Numero1 += -1;
            textPRUEBA.Text = Numero1.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(textPRUEBA.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                textPRUEBA.Text = Numero1.ToString();
            }
            else if (operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                textPRUEBA.Text = Numero1.ToString();
            }
            else
            {
                
                textPRUEBA.Text = "0";
            }

           
        }

                
            
       
    }
}


                
            
        

        
    
    


    

