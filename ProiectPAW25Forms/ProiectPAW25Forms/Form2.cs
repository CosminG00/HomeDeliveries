using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProiectPAW25Forms
{
    public partial class Form2 : Form
    {
        List<Comenzi> lista2;

        public Form2(List<Comenzi> lista)
        {
           
            lista2 = lista;
            InitializeComponent();
            foreach(Clienti c in lista)
                textBox1.Text +=c.ToString() + Environment.NewLine;
        }

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(.txt)|.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(.txt)|.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    BinaryFormatter bf = new BinaryFormatter();
        //    FileStream fs = new FileStream("fisier.dat",
        //        FileMode.Create, FileAccess.Write);
        //    //bf.Serialize(fs, textBox1.Text);
        //    bf.Serialize(fs, lista2);
        //    fs.Close();
        //    textBox1.Clear();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    BinaryFormatter bf = new BinaryFormatter();
        //    FileStream fs = new FileStream("fisier.dat",
        //        FileMode.Open, FileAccess.Read);
        //    //textBox1.Text = (string)bf.Deserialize(fs);
        //    List<Clienti> lista3 = (List<Clienti>)bf.Deserialize(fs);
        //    foreach (Clienti c in lista3)
        //        textBox1.Text += c.ToString() + Environment.NewLine;
        //    fs.Close();
        }
    }
}
