using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ProiectPAW25Forms
{

    public partial class Form1 : Form
    {
        List<Comenzi> listaComenzi = new List<Comenzi>();
        string connString;

        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Statut");
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DatabaseBobi.accdb"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti varsta!");
            else
                if (tbAdresa.Text == "")
                errorProvider1.SetError(tbAdresa, "Introduceti adresa!");
            else
                if (tbId.Text == "")
                errorProvider1.SetError(tbId, "Introduceti ID-ul!");
            else
                if (tbCantitate.Text == "")
                errorProvider1.SetError(tbCantitate, "Introduceti cantitatea!");
            else
                if (tbPret.Text == "")
                errorProvider1.SetError(tbPret, "Introduceti pretul!");


            else
            {
                errorProvider1.Clear();
                OleDbConnection conexiune = new OleDbConnection(connString);
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                try
                {


                    string nume = tbNume.Text;
                    int varsta = Convert.ToInt32(tbVarsta.Text);
                    string adresa = tbAdresa.Text;
                    int idComanda = Convert.ToInt32(tbId.Text);
                    int cantitate = Convert.ToInt32(tbCantitate.Text);
                    float pretProdus = float.Parse(tbPret.Text, CultureInfo.InvariantCulture.NumberFormat);

                    Comenzi c = new Comenzi(nume, varsta, adresa, idComanda, cantitate, pretProdus);
                    listaComenzi.Add(c);
                    MessageBox.Show("Clientul a fost creat!!");

                    
                    comanda.CommandText = "INSERT INTO rute VALUES(?,?,?,?,?,?)";
                    comanda.Parameters.Add("Nume", OleDbType.Char, 30).Value = tbNume.Text;
                    comanda.Parameters.Add("Varsta", OleDbType.Char, 30).Value = tbVarsta.Text;
                    comanda.Parameters.Add("Adresa", OleDbType.Char, 30).Value = tbAdresa.Text;
                    comanda.Parameters.Add("Id Comanda", OleDbType.Char, 30).Value = tbId.Text;
                    comanda.Parameters.Add("Cantitate produs", OleDbType.Char, 15).Value = tbCantitate.Text;
                    comanda.Parameters.Add("Pret produs", OleDbType.Char, 15).Value = tbPret.Text;

                    comanda.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNume.Clear();
                    tbVarsta.Clear();
                    tbAdresa.Clear();
                    tbId.Clear();
                    tbCantitate.Clear();
                    tbPret.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaComenzi);
            frm.ShowDialog();
        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
                this.BackColor = dlg.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if( dlg.ShowDialog() == DialogResult.OK )
                this.Font = dlg.Font;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                listView1.Items.Clear();
                foreach (Comenzi c in listaComenzi)
                {
                    ListViewItem itm = new ListViewItem(c.Nume);
                    itm.SubItems.Add(c.Varsta.ToString());
                    itm.SubItems.Add(c.Adresa);
                    itm.SubItems.Add(c.IdComanda.ToString());
                    itm.SubItems.Add(c.Cantitate.ToString());
                    itm.SubItems.Add(c.PretUnitate.ToString());
                if (c.Varsta >= 18)
                    itm.SubItems.Add("Major");
                else itm.SubItems.Add("Minor");
                listView1.Items.Add(itm);
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                listaComenzi.RemoveAt(index);
                listView1.Items.RemoveAt(index);
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;
                tbNume.Text = e.Item.SubItems[0].Text;
                tbVarsta.Text = e.Item.SubItems[1].Text;
                tbAdresa.Text = e.Item.SubItems[2].Text;
                tbId.Text = e.Item.SubItems[3].Text;
                tbCantitate.Text = e.Item.SubItems[4].Text;
                tbPret.Text = e.Item.SubItems[5].Text;
            }
            if (e.Item.Checked == false)
            {
                
                tbNume.Clear();
                tbVarsta.Clear();
                tbAdresa.Clear();
                tbId.Clear();
                tbCantitate.Clear();
                tbPret.Clear();
            }
        }
        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int varsta = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaComenzi.Count; i++)
                        if (listaComenzi[i].Varsta == varsta)
                            listaComenzi.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach (Comenzi c in listaComenzi)
            {
                sw.Write(c.Nume);
                sw.Write(",");
                sw.Write(c.Varsta);
                sw.Write(",");
                sw.Write(c.Adresa);
                sw.Write(",");
                sw.Write(c.IdComanda);
                sw.Write(",");
                sw.Write(c.Cantitate);
                sw.Write(",");
                sw.Write(c.PretUnitate);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date salvate!");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //MessageBox.Show("S-a deschis!");
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "SELECT * FROM comenzi";
                comanda.Connection = conexiune;

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["Nume"].ToString());
                    itm.SubItems.Add(reader["Varsta"].ToString());
                    itm.SubItems.Add(reader["Adresa"].ToString());
                    itm.SubItems.Add(reader["ID"].ToString());
                    itm.SubItems.Add(reader["Cantitate"].ToString());
                    itm.SubItems.Add(reader["Pret"].ToString());

                    listView1.Items.Add(itm);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int id = Convert.ToInt32(itm.SubItems[3].Text);
                        comanda.CommandText = "DELETE FROM comenzi WHERE id=" + id;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                button7_Click(sender, e);
            }
        
    }

        private void button8_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.CommandText = "SELECT MAX(ID) FROM comenzi";
                

                comanda.CommandText = "INSERT INTO comenzi VALUES(?,?,?,?,?,?)";
                comanda.Parameters.Add("Nume", OleDbType.Char, 30).Value = tbNume.Text;
                comanda.Parameters.Add("Varsta", OleDbType.Integer).Value = tbVarsta.Text;
                comanda.Parameters.Add("Adresa", OleDbType.Char, 30).Value = tbAdresa.Text;
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = tbId.Text;
                comanda.Parameters.Add("Cantitate", OleDbType.Integer).Value = tbCantitate.Text;
                comanda.Parameters.Add("Pret", OleDbType.Integer).Value = tbPret.Text;
                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbVarsta.Clear();
                tbAdresa.Clear();
                tbId.Clear();
                tbCantitate.Clear();
                tbPret.Clear();

            }
        }
    }
}
