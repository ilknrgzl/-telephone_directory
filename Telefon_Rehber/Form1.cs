using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehber
{
    public partial class Form1 : Form
    {
        TelefonRehberi _tr;
        public Form1()
        {
            InitializeComponent();
            _tr = new TelefonRehberi();
            Test();
            listGuncelle();

        }
        private void listGuncelle()
        {
            listBox1.Items.Clear();
            foreach (Kayıt k in _tr._tel_list)
            {
                listBox1.Items.Add(k.ToString());
            }
        }
        private void Test()
        {
            _tr.Ekle(new Kayıt("ali veli", "05025050505"));
            _tr.Ekle(new Kayıt("ayşe çalışkan", "0542424242"));
            _tr.Ekle(new Kayıt("ilknur güzel", "05323232323"));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayıt k = new Kayıt(textBox1.Text,textBox2.Text);
            _tr.Ekle(k);
            listGuncelle();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayıt k = new Kayıt(textBox1.Text, textBox2.Text);
            _tr.Guncelle(listBox1.SelectedIndex, k);
            listGuncelle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int pos = listBox1.SelectedIndex;
            _tr.Sil(pos);
            listGuncelle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kayıt k = _tr.getKayıt(listBox1.SelectedIndex);
            textBox1.Text = k.adisoyadı;
            textBox2.Text = k.telno;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}