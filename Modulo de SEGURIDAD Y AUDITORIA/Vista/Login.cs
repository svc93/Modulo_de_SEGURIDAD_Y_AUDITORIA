using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA
{
    public partial class Form1 : Form
    {
        



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            if (textBox1.Text == "Hamlet")
            {
                if (textBox2.Text == "123456")
                {
                    this.progressBar1.Show();
                    this.timer1.Start();
            
                
                    Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista.Seguridad_y_Auditoría FSYA = new Modulo_de_SEGURIDAD_Y_AUDITORIA.Vista.Seguridad_y_Auditoría();
                    FSYA.Show();


                    this.Hide(); 

                }
                else {

                    MessageBox.Show("Contraseña incorrecta");

                    this.progressBar1.Hide();
                

   
                }
            
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(25);

        }
    }
}
