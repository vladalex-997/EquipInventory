using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventarEchipament
{
    public partial class MeniuForm : Form
    {
        public MeniuForm()
        {
            InitializeComponent();
        }

        private void buttonAngajati_Click(object sender, EventArgs e)
        {

            this.Hide();
            Angajati ang = new Angajati();
            ang.Show();


        }

        private void buttonVizualizare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vizualizare viz = new Vizualizare();
            viz.Show();

        }

        private void buttonEchipament_Click(object sender, EventArgs e)
        {
            this.Hide();
            Echipamente echi = new Echipamente();
            echi.Show();
        }

        private void MeniuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MeniuForm_Load(object sender, EventArgs e)
        {
            //// no smaller than design time size
            //this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            //// no larger than screen size
            //this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void buttonDeschide_Click(object sender, EventArgs e)
        {
            try
            {
                string Tip = tbxTipuri.Text;

                DataBase databaseObject = new DataBase();

               

                databaseObject.OpenConnection();

                string query = "SELECT * from ParolaModif";

                SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

                SqlDataReader re = myCommand.ExecuteReader();

                string Tipread = "";
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        Tipread = re[1].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nu exista parole inregistrare in baza de date");
                }

                re.Close();

                if (Tipread == Tip)
                {
                    NoiTipuri no = new NoiTipuri();
                    no.Show();
                    tbxTipuri.Text = "";
                }
                else
                {
                    MessageBox.Show("Parola nu este corecta");
                }



                databaseObject.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare");
            }
        }
    }
}
