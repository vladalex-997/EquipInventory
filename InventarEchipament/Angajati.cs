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
    public partial class Angajati : Form
    {
        public Angajati()
        {
            InitializeComponent();
        }

       

        private void Angajati_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackAng_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeniuForm men = new MeniuForm();
            men.Show();
        }

        private void buttonIntroducere_Click(object sender, EventArgs e)
        {
            try
            {
                string CodSAP=tbxsapint.Text;
                string Nume = tbxnumeint.Text;
                string Functie=tbxfucntieint.Text;
                string Responsabil=tbxresponsabilint.Text;
                string TipAngajat=tbxtipint.Text;
                string DataAngajarii=tbxdataint.Text;
                string CostCenterNr=tbxcostnrint.Text;
                string CostCenterNume=tbxcostnumeint.Text;
                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();
                if (string.IsNullOrEmpty(CodSAP) || string.IsNullOrEmpty(Nume) || string.IsNullOrEmpty(Functie) || string.IsNullOrEmpty(Responsabil) || string.IsNullOrEmpty(TipAngajat) || string.IsNullOrEmpty(DataAngajarii) || string.IsNullOrEmpty(CostCenterNr) || string.IsNullOrEmpty(CostCenterNume))
                {
                    MessageBox.Show("Completati toate campurile pentru introducere !!!");
                }
                else
                {
                    string query = "INSERT INTO Angajati (CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume) VALUES(@CodSAP,@Nume,@Functie,@Responsabil,@TipAngajat,@DataAngajarii,@CostCenterNr,@CostCenterNume)";
                    SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);



                    myCommand.Parameters.AddWithValue("@CodSAP", CodSAP);
                    myCommand.Parameters.AddWithValue("@Nume", Nume);
                    myCommand.Parameters.AddWithValue("@Functie", Functie);
                    myCommand.Parameters.AddWithValue("@Responsabil", Responsabil);
                    myCommand.Parameters.AddWithValue("@TipAngajat", TipAngajat);
                    myCommand.Parameters.AddWithValue("@DataAngajarii", DataAngajarii);
                    myCommand.Parameters.AddWithValue("@CostCenterNr", CostCenterNr);
                    myCommand.Parameters.AddWithValue("@CostCenterNume", CostCenterNume);

                    var result = myCommand.ExecuteNonQuery();

                    MessageBox.Show("Inregistrare Reusita");

                    tbxsapint.Text = "";
                    tbxnumeint.Text = "";
                    tbxfucntieint.Text = "";
                    tbxresponsabilint.Text = "";
                    tbxtipint.Text = "";
                    tbxdataint.Text = "";
                    tbxcostnrint.Text = "";
                    tbxcostnumeint.Text = "";

                    


                }
                databaseObject.CloseConnection();

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la introducere angajat");

            }
        }

        private void buttonAutocomplete_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

                string CodSAP = tbxsapmod.Text;
                if (string.IsNullOrEmpty(CodSAP))
                {
                    MessageBox.Show("Completati Cod SAP pentru autocomplete");
                }
                else
                {
                    string query = "SELECT Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume from Angajati WHERE CodSAP=@CodSAP";
                    SqlCommand mycommand = new SqlCommand(query, databaseObject.myConnection);
                    mycommand.Parameters.AddWithValue("@CodSAP",CodSAP);

                    string Numeread = "";
                    string Functieread = "";
                    string Responsabilread = "";
                    string TipAngajatread = "";
                    string DataAngajariiread = "";
                    string CostCenterNrread = "";
                    string CostCenterNumeread = "";

                    SqlDataReader re = mycommand.ExecuteReader();
                    if (re.HasRows)
                    {
                        while (re.Read())
                        {
                            Numeread = re[0].ToString();
                            Functieread = re[1].ToString();
                            Responsabilread = re[2].ToString();
                            TipAngajatread = re[3].ToString();
                            DataAngajariiread = re[4].ToString();
                            CostCenterNrread = re[5].ToString();
                            CostCenterNumeread = re[6].ToString();
                        }
                        tbxnumemod.Text = Numeread;
                        tbxfunctiemod.Text = Functieread;
                        tbxresponsabilmod.Text = Responsabilread;
                        tbxtipmod.Text = TipAngajatread;
                        tbxdatamod.Text = DataAngajariiread;
                        tbxcostnrmod.Text = CostCenterNrread;
                        tbxcostnumemod.Text = CostCenterNumeread;
                    }
                    else
                    {
                        MessageBox.Show("Nu exista angajat cu acest Cod SAP");
                    }
                    re.Close();
                        
                }

                databaseObject.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Autocomplete");

            }
        }

        private void buttonModificare_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

                string CodSAP = tbxsapmod.Text;
                string Nume = tbxnumemod.Text;
                string Functie = tbxfunctiemod.Text;
                string Responsabil = tbxresponsabilmod.Text;
                string TipAngajat = tbxtipmod.Text;
                string DataAngajarii = tbxdatamod.Text;
                string CostCenterNr = tbxcostnrmod.Text;
                string CostCenterNume = tbxcostnumemod.Text;

                if (string.IsNullOrEmpty(CodSAP) || string.IsNullOrEmpty(Nume) || string.IsNullOrEmpty(Functie) || string.IsNullOrEmpty(Responsabil) || string.IsNullOrEmpty(TipAngajat) || string.IsNullOrEmpty(DataAngajarii) || string.IsNullOrEmpty(CostCenterNr) || string.IsNullOrEmpty(CostCenterNume))
                {
                    MessageBox.Show("Completati toate campurile pentru modificare !!!");
                }
                else
                {

                    string query = "UPDATE Angajati SET Nume=@Nume,Functie=@Functie,Responsabil=@Responsabil,TipAngajat=@TipAngajat,DataAngajarii=@DataAngajarii,CostCenterNr=@CostCenterNr,CostCenterNume=@CostCenterNume " +
                        "WHERE CodSAP=@CodSAP";
                    SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);



                    myCommand.Parameters.AddWithValue("@CodSAP", CodSAP);
                    myCommand.Parameters.AddWithValue("@Nume", Nume);
                    myCommand.Parameters.AddWithValue("@Functie", Functie);
                    myCommand.Parameters.AddWithValue("@Responsabil", Responsabil);
                    myCommand.Parameters.AddWithValue("@TipAngajat", TipAngajat);
                    myCommand.Parameters.AddWithValue("@DataAngajarii", DataAngajarii);
                    myCommand.Parameters.AddWithValue("@CostCenterNr", CostCenterNr);
                    myCommand.Parameters.AddWithValue("@CostCenterNume", CostCenterNume);

                    var result = myCommand.ExecuteNonQuery();

                    if (result != 0)
                    {
                        MessageBox.Show("Modificare Reusita");
                    }
                    else
                    {
                        MessageBox.Show("Nu exista Angajatul cu acest Cod SAP");
                    }

                    

                    tbxsapmod.Text = "";
                    tbxnumemod.Text = "";
                    tbxfunctiemod.Text = "";
                    tbxresponsabilmod.Text = "";
                    tbxtipmod.Text = "";
                    tbxdatamod.Text = "";
                    tbxcostnrmod.Text = "";
                    tbxcostnumemod.Text = "";



                }

                databaseObject.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Modificare");
            }
        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

                string CodSAPdel = tbxCodSAPdel.Text;

                if (string.IsNullOrEmpty(CodSAPdel))
                {
                    MessageBox.Show("Completati campul Cod SAP (inactiv) ");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca vreti sa faceti utilizatorul inactiv cu acest Cod SAP ???","Verificare",MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string StatusAngajat = "Inactiv";
                        DateTime date;
                        date = DateTime.Now;
                        string Data = date.ToString();
                        StatusAngajat = StatusAngajat + " din data de " + Data;
                        string query = "UPDATE Angajati SET StatusAngajat=@StatusAngajat WHERE CodSAP=@CodSAP";
                        SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);
                        myCommand.Parameters.AddWithValue("@CodSAP",CodSAPdel);
                        myCommand.Parameters.AddWithValue("@StatusAngajat", StatusAngajat);

                        var result = myCommand.ExecuteNonQuery();

                        if (result != 0)
                        {
                            MessageBox.Show("Angajatul este inactiv");

                        }
                        else
                        {
                            MessageBox.Show("Nu exista Angajatul cu acest Cod SAP");
                        }

                        tbxCodSAPdel.Text = "";

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Nu s-a efectuat modificarea statusului");
                    }
                }

                databaseObject.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la modificare status");
            }
        }
    }
}
