using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms_Library;

namespace GraphicInterface
{
    public partial class AddGraf : Form
    {
        List<Edge_Prim> list;
        public int res;
        public int res2;
        public int res3;
        public AddGraf(List<Edge_Prim> list)
        {
           this.list = list;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out  res) && int.TryParse(textBox2.Text, out  res2) && int.TryParse(textBox3.Text, out  res3))
            {
                list.Add(new Edge_Prim(res, res2, res3));
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Ошибка при вводу данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGraf_Load(object sender, EventArgs e)
        {

        }
    }
}
