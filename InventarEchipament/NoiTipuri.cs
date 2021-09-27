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
    public partial class NoiTipuri : Form
    {
        public NoiTipuri()
        {
            InitializeComponent();
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            string Incaltaminte = tbxincal.Text;
            string Bluze = tbxbluze.Text;
            string Tricouri = tbxtricouri.Text;
            string Pantaloni = tbxpantaloni.Text;
            string Jachete = tbxjachete.Text;
            string Auxiliare = tbxauxiliare.Text;

            DataBase databaseObject = new DataBase();
            databaseObject.OpenConnection();

            string query = "INSERT into TipEchipament (Incaltaminte,Bluze,Tricouri,Pantaloni,Jachete,Auxiliare) VALUES (@Incaltaminte,@Bluze,@Tricouri,@Pantaloni,@Jachete,@Auxiliare)";
            SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

            myCommand.Parameters.AddWithValue("@Incaltaminte",Incaltaminte);
            myCommand.Parameters.AddWithValue("@Bluze", Bluze);
            myCommand.Parameters.AddWithValue("@Tricouri", Tricouri);
            myCommand.Parameters.AddWithValue("@Pantaloni", Pantaloni);
            myCommand.Parameters.AddWithValue("@Jachete", Jachete);
            myCommand.Parameters.AddWithValue("@Auxiliare", Auxiliare);

            var result = myCommand.ExecuteNonQuery();

            MessageBox.Show("Adaugare Reusita");

            this.Close();


            databaseObject.CloseConnection();

        }
    }
}
