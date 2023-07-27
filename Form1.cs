using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime dtnas = DateTime.Today;
            DateTime dtnas2 = dateTimePicker1.Value;

            TimeSpan resultado = dtnas.Subtract(dtnas2);
            double resultadoo = resultado.Days / 365.2425;
            lb_resul.Text = $" sua idade é: {resultadoo.ToString("0")}";


        }
    }
}
