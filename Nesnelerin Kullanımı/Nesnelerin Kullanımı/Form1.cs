using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesnelerin_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            comboBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();

            f2.label1.Text = "Sonuçlarınız aşağıda listelenmiştir ---> ";
            
            if (radioButton1.Checked==true)
            {
                f2.label11.Text = "Bekarsın";

            }
            else if (radioButton2.Checked==true)
            {
                f2.label11.Text = "Evlisin";
            }
            else if (radioButton3.Checked==true)
            {
                f2.label11.Text = "Boşanmışsın";
            }

            if (checkBox1.Checked==true)
            {
                f2.label10.Text = "Film İzlemeyi seviyorsun".ToString();
            }
            else if (checkBox2.Checked == true)
            {
               f2.label10.Text = "Kitap okumayı seviyorsun".ToString();
            }
            else if (checkBox3.Checked == true)
            {
                f2.label10.Text = "Tatil yapmayı seviyorsun".ToString();
            }

            if (checkBox1.Checked==true&&checkBox2.Checked==true)
            {
                f2.label10.Text="Film İzlemeyi ve kitap okumayı seviyorsun".ToString();
            }

            if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                f2.label10.Text = "Kitap Okumayı ve Tatil Yapmayı seviyorsun".ToString();
            }
            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                f2.label10.Text = "Film İzlemeyi ve Tatil yapmayı seviyorsun".ToString();
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked==true)
            {
                f2.label10.Text = "Film İzlemeyi, kitap okumayı ve Tatil yapmayı seviyorsun".ToString();
            }

            f2.listBox1.Items.Add(textBox1.Text);
            f2.listBox1.Items.Add(textBox2.Text);
            f2.listBox1.Items.Add(textBox3.Text);
            f2.listBox1.Items.Add(comboBox1.Text);
            f2.listBox1.Items.Add(dateTimePicker1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "NESNELERİN KULLANIMI";
            comboBox1.Items.Add("Bursa");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Burdur");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Düzce");
            comboBox1.Items.Add("Erzurum");
            comboBox1.Items.Add("Kastamonu");

        }
    }
}
