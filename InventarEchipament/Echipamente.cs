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
using System.Globalization;

namespace InventarEchipament
{
    public partial class Echipamente : Form
    {
        public Echipamente()
        {
            InitializeComponent();
        }

        private void Echipamente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackEchip_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeniuForm men = new MeniuForm();
            men.Show();
        }

        private void buttonIntroducere_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase databaseObject = new DataBase();
              //  databaseObject.OpenConnection();

                string CodSAP = tbxCodSAPint.Text;

                string Incaltaminte = comboBoxincalint.Text + "  " + comboBoxincalsizeint.Text;
                string DIncaltaminte = dateTimePickerincalint.Value.ToString("dd-MM-yyyy");
                DateTime dataincal = DateTime.ParseExact(DIncaltaminte,"dd-MM-yyyy",CultureInfo.InvariantCulture);

                string Bluze = comboBoxbluzeint.Text + "  " + comboBoxbluzesizeint.Text;
                string DBluze = dateTimePickerbluzeint.Value.ToString("dd-MM-yyyy");
                DateTime databluze = DateTime.ParseExact(DBluze, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Pantaloni = comboBoxpantaint.Text + "  " + comboBoxpantasizeint.Text;
                string DPantaloni = dateTimePickerpantaloniint.Value.ToString("dd-MM-yyyy");
                DateTime datapantaloni = DateTime.ParseExact(DPantaloni, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Tricouri = comboBoxtricouriint.Text + "  " + comboBoxtricourisizeint.Text;
                string DTricouri = dateTimePickertricouriint.Value.ToString("dd-MM-yyyy");
                DateTime datatricouri = DateTime.ParseExact(DTricouri, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Jachete = comboBoxjacheteint.Text + "  " + comboBoxjachetesizeint.Text;
                string DJachete = dateTimePickerjacheteint.Value.ToString("dd-MM-yyyy");
                DateTime datajachete = DateTime.ParseExact(DJachete, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Auxiliare = comboBoxauxiliareint.Text + "  " + comboBoxauxiliaresizeint.Text;
                string DAuxiliare = dateTimePickerauxiliareint.Value.ToString("dd-MM-yyyy");
                DateTime dataauxiliare = DateTime.ParseExact(DAuxiliare, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                if (string.IsNullOrEmpty(CodSAP))
                {
                    MessageBox.Show("Introduceti un Cod SAP");
                }
                else
                {
                    GetAngajat g = new GetAngajat();

                    string verifSAP = "";
                    string verifId = "";
                    verifSAP = g.GetSAP(CodSAP);
                    verifId = g.GetIdAngajat(CodSAP);

                    if (verifSAP == ""||verifId=="")
                    {
                        MessageBox.Show("Acest Cod SAP / Angajat nu exista");
                    }
                    else
                    {
                        string query = "INSERT INTO Echipament (IdAngajat,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare,CodSAP) VALUES (@IdAngajat,@Incaltaminte,@DataIncaltaminte,@Bluze,@DataBluze,@Pantaloni,@DataPantaloni,@Tricouri,@DataTricouri,@Jachete,@DataJachete,@Auxiliare,@DataAuxiliare,@CodSAP)";

                        SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

                        myCommand.Parameters.AddWithValue("@IdAngajat",verifId);
                        myCommand.Parameters.AddWithValue("@Incaltaminte", Incaltaminte);
                        myCommand.Parameters.AddWithValue("@DataIncaltaminte", dataincal);
                        myCommand.Parameters.AddWithValue("@Bluze", Bluze);
                        myCommand.Parameters.AddWithValue("@DataBluze", databluze);
                        myCommand.Parameters.AddWithValue("@Pantaloni", Pantaloni);
                        myCommand.Parameters.AddWithValue("@DataPantaloni", datapantaloni);
                        myCommand.Parameters.AddWithValue("@Tricouri", Tricouri);
                        myCommand.Parameters.AddWithValue("@DataTricouri", datatricouri);
                        myCommand.Parameters.AddWithValue("@Jachete", Jachete);
                        myCommand.Parameters.AddWithValue("@DataJachete", datajachete);
                        myCommand.Parameters.AddWithValue("@Auxiliare", Auxiliare);
                        myCommand.Parameters.AddWithValue("@DataAuxiliare", dataauxiliare);
                        myCommand.Parameters.AddWithValue("@CodSAP", verifSAP);


                    databaseObject.OpenConnection();

                    var result = myCommand.ExecuteNonQuery();

                    databaseObject.CloseConnection();

                        MessageBox.Show("Inregistrare Echipament Reusita");

                    tbxCodSAPint.Text = "";
                    comboBoxincalint.SelectedIndex = -1;
                    comboBoxincalsizeint.SelectedIndex = -1;
                    comboBoxbluzeint.SelectedIndex = -1;
                    comboBoxbluzesizeint.SelectedIndex = -1;
                    comboBoxpantaint.SelectedIndex = -1;
                    comboBoxpantasizeint.SelectedIndex = -1;
                    comboBoxtricouriint.SelectedIndex = -1;
                    comboBoxtricourisizeint.SelectedIndex = -1;
                    comboBoxjacheteint.SelectedIndex = -1;
                    comboBoxjachetesizeint.SelectedIndex = -1;
                    comboBoxauxiliareint.SelectedIndex = -1;
                    comboBoxauxiliaresizeint.SelectedIndex = -1;


                    dateTimePickerincalint.Value = DateTime.Now;
                    dateTimePickerbluzeint.Value = DateTime.Now;
                    dateTimePickerpantaloniint.Value = DateTime.Now;
                    dateTimePickertricouriint.Value = DateTime.Now;
                    dateTimePickerjacheteint.Value = DateTime.Now;
                    dateTimePickerauxiliareint.Value = DateTime.Now;



                }
                }





             //   databaseObject.CloseConnection();

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la introducere echipament");

            }

            
        }

        private void buttonAutocomplete_Click(object sender, EventArgs e)
        {
          /*  try
            {
                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

               // Cleanmod();

                string IdRecord = tbxIdRecordmod.Text;
                if (string.IsNullOrEmpty(IdRecord))
                {
                    MessageBox.Show("Completati Id Record pentru autocomplete");
                }
                else
                {
                    string query = "SELECT * from Echipament WHERE IdRecord=@IdRecord";
                    SqlCommand mycommand = new SqlCommand(query, databaseObject.myConnection);
                    mycommand.Parameters.AddWithValue("@IdRecord", IdRecord);

                    string Incaltaminte = "";
                    string DataIncaltaminte = "";
                    string Bluze = "";
                    string DataBluze = "";
                    string Pantaloni = "";
                    string DataPantaloni = "";
                    string Tricouri = "";
                    string DataTricouri = "";
                    string Jachete = "";
                    string DataJachete = "";
                    string Auxiliare = "";
                    string DataAuxiliare = "";

                    SqlDataReader re = mycommand.ExecuteReader();
                    if (re.HasRows)
                    {
                        while (re.Read())
                        {
                            Incaltaminte = re[2].ToString();
                            DataIncaltaminte = re[3].ToString();
                            Bluze = re[4].ToString();
                            DataBluze = re[5].ToString();
                            Pantaloni = re[6].ToString();
                            DataPantaloni = re[7].ToString();
                            Tricouri = re[8].ToString();
                            DataTricouri = re[9].ToString();
                            Jachete = re[10].ToString();
                            DataJachete = re[11].ToString();
                            Auxiliare = re[12].ToString();
                            DataAuxiliare = re[13].ToString();
                        }
                        tbxincalmod.Text = Incaltaminte;
                        tbxbluzemod.Text = Bluze;
                        tbxpantalonimod.Text = Pantaloni;
                        tbxtricourimod.Text = Tricouri;
                        tbxjachetemod.Text = Jachete;
                        tbxauxiliaremod.Text = Auxiliare;
                        dateTimePickerincalmod.Value = DateTime.Parse(DataIncaltaminte);
                        dateTimePickerbluzemod.Value = DateTime.Parse(DataBluze);
                        dateTimePickerpantalonimod.Value = DateTime.Parse(DataPantaloni);
                        dateTimePickertricourimod.Value = DateTime.Parse(DataTricouri);
                        dateTimePickerjachetemod.Value = DateTime.Parse(DataJachete);
                        dateTimePickerauxiliaremod.Value = DateTime.Parse(DataAuxiliare);
                    }
                    else
                    {
                        MessageBox.Show("Nu exista angajat cu acest Id Record");
                    }
                    re.Close();

                }

                databaseObject.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Autocomplete");

            }
          */
        }

        private void buttonModificare_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

                string Incaltaminte = comboBoxincalmod.Text + "  " + comboBoxincalsizemod.Text;
                string DIncaltaminte = dateTimePickerincalmod.Value.ToString("dd-MM-yyyy");
                DateTime dataincal = DateTime.ParseExact(DIncaltaminte, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Bluze = comboBoxbluzemod.Text + "  " + comboBoxbluzesizemod.Text;
                string DBluze = dateTimePickerbluzemod.Value.ToString("dd-MM-yyyy");
                DateTime databluze = DateTime.ParseExact(DBluze, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Pantaloni = comboBoxpantalonimod.Text + "  " + comboBoxpantalonisizemod.Text;
                string DPantaloni = dateTimePickerpantalonimod.Value.ToString("dd-MM-yyyy");
                DateTime datapantaloni = DateTime.ParseExact(DPantaloni, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Tricouri = comboBoxtricourimod.Text + "  " + comboBoxtricourisizemod.Text;
                string DTricouri = dateTimePickertricourimod.Value.ToString("dd-MM-yyyy");
                DateTime datatricouri = DateTime.ParseExact(DTricouri, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Jachete = comboBoxjachetemod.Text + "  " + comboBoxjachetesizemod.Text;
                string DJachete = dateTimePickerjachetemod.Value.ToString("dd-MM-yyyy");
                DateTime datajachete = DateTime.ParseExact(DJachete, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string Auxiliare = comboBoxauxiliaremod.Text + "  " + comboBoxauxiliaresizemod.Text;
                string DAuxiliare = dateTimePickerauxiliaremod.Value.ToString("dd-MM-yyyy");
                DateTime dataauxiliare = DateTime.ParseExact(DAuxiliare, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                string IdRecord = tbxIdRecordmod.Text;
                if (string.IsNullOrEmpty(IdRecord))
                {
                    MessageBox.Show("Completati Id Record pentru autocomplete");
                }
                else
                {
                    string query = "UPDATE Echipament SET Incaltaminte=@Incaltaminte,DataIncaltaminte=@DataIncaltaminte,Bluze=@Bluze,DataBluze=@DataBluze,Pantaloni=@Pantaloni,DataPantaloni=@DataPantaloni,Tricouri=@Tricouri,DataTricouri=@DataTricouri,Jachete=@Jachete,DataJachete=@DataJachete,Auxiliare=@Auxiliare,DataAuxiliare=@DataAuxiliare WHERE IdRecord=@IdRecord";

                    SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

                    myCommand.Parameters.AddWithValue("@IdRecord", IdRecord);
                    myCommand.Parameters.AddWithValue("@Incaltaminte", Incaltaminte);
                    myCommand.Parameters.AddWithValue("@DataIncaltaminte", dataincal);
                    myCommand.Parameters.AddWithValue("@Bluze", Bluze);
                    myCommand.Parameters.AddWithValue("@DataBluze", databluze);
                    myCommand.Parameters.AddWithValue("@Pantaloni", Pantaloni);
                    myCommand.Parameters.AddWithValue("@DataPantaloni", datapantaloni);
                    myCommand.Parameters.AddWithValue("@Tricouri", Tricouri);
                    myCommand.Parameters.AddWithValue("@DataTricouri", datatricouri);
                    myCommand.Parameters.AddWithValue("@Jachete", Jachete);
                    myCommand.Parameters.AddWithValue("@DataJachete", datajachete);
                    myCommand.Parameters.AddWithValue("@Auxiliare", Auxiliare);
                    myCommand.Parameters.AddWithValue("@DataAuxiliare", dataauxiliare);


                    var result = myCommand.ExecuteNonQuery();

                    MessageBox.Show("Modificare Echipament Reusita");

                    comboBoxincalmod.SelectedIndex = -1;
                    comboBoxincalsizemod.SelectedIndex = -1;
                    comboBoxbluzemod.SelectedIndex = -1;
                    comboBoxbluzesizemod.SelectedIndex = -1;
                    comboBoxpantalonimod.SelectedIndex = -1;
                    comboBoxpantalonisizemod.SelectedIndex = -1;
                    comboBoxtricourimod.SelectedIndex = -1;
                    comboBoxtricourisizemod.SelectedIndex = -1;
                    comboBoxjachetemod.SelectedIndex = -1;
                    comboBoxjachetesizemod.SelectedIndex = -1;
                    comboBoxauxiliaremod.SelectedIndex = -1;
                    comboBoxauxiliaresizemod.SelectedIndex = -1;

                    dateTimePickerincalmod.Value = DateTime.Now;
                    dateTimePickerbluzemod.Value = DateTime.Now;
                    dateTimePickerpantalonimod.Value = DateTime.Now;
                    dateTimePickertricourimod.Value = DateTime.Now;
                    dateTimePickerjachetemod.Value = DateTime.Now;
                    dateTimePickerauxiliaremod.Value = DateTime.Now;


                }


                databaseObject.CloseConnection();

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Modificare Echipament");
            }
          
        }
        public void Cleanmod()
        {
            tbxIdRecordmod.Text = "";
            comboBoxincalmod.SelectedIndex = -1;
            comboBoxincalsizemod.SelectedIndex = -1;
            comboBoxbluzemod.SelectedIndex = -1;
            comboBoxbluzesizemod.SelectedIndex = -1;
            comboBoxpantalonimod.SelectedIndex = -1;
            comboBoxpantalonisizemod.SelectedIndex = -1;
            comboBoxtricourimod.SelectedIndex = -1;
            comboBoxtricourisizemod.SelectedIndex = -1;
            comboBoxjachetemod.SelectedIndex = -1;
            comboBoxjachetesizemod.SelectedIndex = -1;
            comboBoxauxiliaremod.SelectedIndex = -1;
            comboBoxauxiliaresizemod.SelectedIndex = -1;

            dateTimePickerincalmod.Value = DateTime.Now;
            dateTimePickerbluzemod.Value = DateTime.Now;
            dateTimePickerpantalonimod.Value = DateTime.Now;
            dateTimePickertricourimod.Value = DateTime.Now;
            dateTimePickerjachetemod.Value = DateTime.Now;
            dateTimePickerauxiliaremod.Value = DateTime.Now;

        }

        public void Cleanint()
        {
            tbxCodSAPint.Text = "";
            comboBoxincalint.SelectedIndex = -1;
            comboBoxincalsizeint.SelectedIndex = -1;
            comboBoxbluzeint.SelectedIndex = -1;
            comboBoxbluzesizeint.SelectedIndex = -1;
            comboBoxpantaint.SelectedIndex = -1;
            comboBoxpantasizeint.SelectedIndex = -1;
            comboBoxtricouriint.SelectedIndex = -1;
            comboBoxtricourisizeint.SelectedIndex = -1;
            comboBoxjacheteint.SelectedIndex = -1;
            comboBoxjachetesizeint.SelectedIndex = -1;
            comboBoxauxiliareint.SelectedIndex = -1;
            comboBoxauxiliaresizeint.SelectedIndex = -1;


            dateTimePickerincalint.Value = DateTime.Now;
            dateTimePickerbluzeint.Value = DateTime.Now;
            dateTimePickerpantaloniint.Value = DateTime.Now;
            dateTimePickertricouriint.Value = DateTime.Now;
            dateTimePickerjacheteint.Value = DateTime.Now;
            dateTimePickerauxiliareint.Value = DateTime.Now;


        }




        private void Echipamente_Load(object sender, EventArgs e)
        {
            try
            {
                

                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

                string query = "SELECT * from TipEchipament";

                SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

                SqlDataReader re = myCommand.ExecuteReader();

                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        comboBoxincalint.Items.Add(re["Incaltaminte"].ToString());
                        comboBoxincalsizeint.Items.Add(re["MarimeIncaltaminte"].ToString());

                        comboBoxbluzeint.Items.Add(re["Bluze"].ToString());
                        comboBoxbluzesizeint.Items.Add(re["MarimeBluze"].ToString());

                        comboBoxtricouriint.Items.Add(re["Tricouri"].ToString());
                        comboBoxtricourisizeint.Items.Add(re["MarimeTricouri"].ToString());

                        comboBoxpantaint.Items.Add(re["Pantaloni"].ToString());
                        comboBoxpantasizeint.Items.Add(re["MarimePantaloni"].ToString());

                        comboBoxjacheteint.Items.Add(re["Jachete"].ToString());
                        comboBoxjachetesizeint.Items.Add(re["MarimeJachete"].ToString());

                        comboBoxauxiliareint.Items.Add(re["Auxiliare"].ToString());
                        comboBoxauxiliaresizeint.Items.Add(re["MarimeAuxiliare"].ToString());




                        comboBoxincalmod.Items.Add(re["Incaltaminte"].ToString());
                        comboBoxincalsizemod.Items.Add(re["MarimeIncaltaminte"].ToString());

                        comboBoxbluzemod.Items.Add(re["Bluze"].ToString());
                        comboBoxbluzesizemod.Items.Add(re["MarimeBluze"].ToString());

                        comboBoxtricourimod.Items.Add(re["Tricouri"].ToString());
                        comboBoxtricourisizemod.Items.Add(re["MarimeTricouri"].ToString());

                        comboBoxpantalonimod.Items.Add(re["Pantaloni"].ToString());
                        comboBoxpantalonisizemod.Items.Add(re["MarimePantaloni"].ToString());

                        comboBoxjachetemod.Items.Add(re["Jachete"].ToString());
                        comboBoxjachetesizemod.Items.Add(re["MarimeJachete"].ToString());

                        comboBoxauxiliaremod.Items.Add(re["Auxiliare"].ToString());
                        comboBoxauxiliaresizemod.Items.Add(re["MarimeAuxiliare"].ToString());







                    }
                }
                else
                {
                    MessageBox.Show("Eroare Reader");
                }
                re.Close();

                databaseObject.CloseConnection();

                int countincalint = comboBoxincalint.Items.Count;
                int countincalsizeint = comboBoxincalsizeint.Items.Count;

                int countbluzeint = comboBoxbluzeint.Items.Count;
                int countbluzesizeint = comboBoxbluzesizeint.Items.Count;

                int countpantaint = comboBoxpantaint.Items.Count;
                int countpantasizeint = comboBoxpantasizeint.Items.Count;

                int counttricouriint = comboBoxtricouriint.Items.Count;
                int counttricourisizeint = comboBoxtricourisizeint.Items.Count;

                int countjacheteint = comboBoxjacheteint.Items.Count;
                int countjachetesizeint = comboBoxjachetesizeint.Items.Count;

                int countauxiliareint = comboBoxauxiliareint.Items.Count;
                int countauxiliaresizeint = comboBoxauxiliaresizeint.Items.Count;

                for (int i = countincalint - 1; i >= 0; i--)
                {
                    if (comboBoxincalint.Items[i].ToString() == "")
                    {
                        comboBoxincalint.Items.RemoveAt(i);
                    }
                }

                for (int i = countincalsizeint - 1; i >= 0; i--)
                {
                    if (comboBoxincalsizeint.Items[i].ToString() == "")
                    {
                        comboBoxincalsizeint.Items.RemoveAt(i);
                    }
                }

                for (int i = countbluzeint - 1; i >= 0; i--)
                {
                    if (comboBoxbluzeint.Items[i].ToString() == "")
                    {
                        comboBoxbluzeint.Items.RemoveAt(i);
                    }
                }

                for (int i = countbluzesizeint - 1; i >= 0; i--)
                {
                    if (comboBoxbluzesizeint.Items[i].ToString() == "")
                    {
                        comboBoxbluzesizeint.Items.RemoveAt(i);
                    }
                }

                for (int i = countpantaint - 1; i >= 0; i--)
                {
                    if (comboBoxpantaint.Items[i].ToString() == "")
                    {
                        comboBoxpantaint.Items.RemoveAt(i);
                    }
                }

                for (int i = countpantasizeint - 1; i >= 0; i--)
                {
                    if (comboBoxpantasizeint.Items[i].ToString() == "")
                    {
                        comboBoxpantasizeint.Items.RemoveAt(i);
                    }
                }


                for (int i = counttricouriint - 1; i >= 0; i--)
                {
                    if (comboBoxtricouriint.Items[i].ToString() == "")
                    {
                        comboBoxtricouriint.Items.RemoveAt(i);
                    }
                }

                for (int i = counttricourisizeint - 1; i >= 0; i--)
                {
                    if (comboBoxtricourisizeint.Items[i].ToString() == "")
                    {
                        comboBoxtricourisizeint.Items.RemoveAt(i);
                    }
                }

                for (int i = countjacheteint - 1; i >= 0; i--)
                {
                    if (comboBoxjacheteint.Items[i].ToString() == "")
                    {
                        comboBoxjacheteint.Items.RemoveAt(i);
                    }
                }

                for (int i = countjachetesizeint - 1; i >= 0; i--)
                {
                    if (comboBoxjachetesizeint.Items[i].ToString() == "")
                    {
                        comboBoxjachetesizeint.Items.RemoveAt(i);
                    }
                }


                for (int i = countauxiliareint - 1; i >= 0; i--)
                {
                    if (comboBoxauxiliareint.Items[i].ToString() == "")
                    {
                        comboBoxauxiliareint.Items.RemoveAt(i);
                    }
                }

                for (int i = countauxiliaresizeint - 1; i >= 0; i--)
                {
                    if (comboBoxauxiliaresizeint.Items[i].ToString() == "")
                    {
                        comboBoxauxiliaresizeint.Items.RemoveAt(i);
                    }
                }





                int countincalmod = comboBoxincalmod.Items.Count;
                int countincalsizemod = comboBoxincalsizemod.Items.Count;

                int countbluzemod = comboBoxbluzemod.Items.Count;
                int countbluzesizemod = comboBoxbluzesizemod.Items.Count;

                int countpantamod = comboBoxpantalonimod.Items.Count;
                int countpantasizemod = comboBoxpantalonisizemod.Items.Count;

                int counttricourimod = comboBoxtricourimod.Items.Count;
                int counttricourisizemod = comboBoxtricourisizemod.Items.Count;

                int countjachetemod = comboBoxjachetemod.Items.Count;
                int countjachetesizemod = comboBoxjachetesizemod.Items.Count;

                int countauxiliaremod = comboBoxauxiliaremod.Items.Count;
                int countauxiliaresizemod = comboBoxauxiliaresizemod.Items.Count;

                for (int i = countincalmod - 1; i >= 0; i--)
                {
                    if (comboBoxincalmod.Items[i].ToString() == "")
                    {
                        comboBoxincalmod.Items.RemoveAt(i);
                    }
                }

                for (int i = countincalsizemod - 1; i >= 0; i--)
                {
                    if (comboBoxincalsizemod.Items[i].ToString() == "")
                    {
                        comboBoxincalsizemod.Items.RemoveAt(i);
                    }
                }

                for (int i = countbluzemod - 1; i >= 0; i--)
                {
                    if (comboBoxbluzemod.Items[i].ToString() == "")
                    {
                        comboBoxbluzemod.Items.RemoveAt(i);
                    }
                }

                for (int i = countbluzesizemod - 1; i >= 0; i--)
                {
                    if (comboBoxbluzesizemod.Items[i].ToString() == "")
                    {
                        comboBoxbluzesizemod.Items.RemoveAt(i);
                    }
                }

                for (int i = countpantamod - 1; i >= 0; i--)
                {
                    if (comboBoxpantalonimod.Items[i].ToString() == "")
                    {
                        comboBoxpantalonimod.Items.RemoveAt(i);
                    }
                }

                for (int i = countpantasizemod - 1; i >= 0; i--)
                {
                    if (comboBoxpantalonisizemod.Items[i].ToString() == "")
                    {
                        comboBoxpantalonisizemod.Items.RemoveAt(i);
                    }
                }


                for (int i = counttricourimod - 1; i >= 0; i--)
                {
                    if (comboBoxtricourimod.Items[i].ToString() == "")
                    {
                        comboBoxtricourimod.Items.RemoveAt(i);
                    }
                }

                for (int i = counttricourisizemod - 1; i >= 0; i--)
                {
                    if (comboBoxtricourisizemod.Items[i].ToString() == "")
                    {
                        comboBoxtricourisizemod.Items.RemoveAt(i);
                    }
                }

                for (int i = countjachetemod - 1; i >= 0; i--)
                {
                    if (comboBoxjachetemod.Items[i].ToString() == "")
                    {
                        comboBoxjachetemod.Items.RemoveAt(i);
                    }
                }

                for (int i = countjachetesizemod - 1; i >= 0; i--)
                {
                    if (comboBoxjachetesizemod.Items[i].ToString() == "")
                    {
                        comboBoxjachetesizemod.Items.RemoveAt(i);
                    }
                }


                for (int i = countauxiliaremod - 1; i >= 0; i--)
                {
                    if (comboBoxauxiliaremod.Items[i].ToString() == "")
                    {
                        comboBoxauxiliaremod.Items.RemoveAt(i);
                    }
                }

                for (int i = countauxiliaresizemod - 1; i >= 0; i--)
                {
                    if (comboBoxauxiliaresizemod.Items[i].ToString() == "")
                    {
                        comboBoxauxiliaresizemod.Items.RemoveAt(i);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare conexiune baza de date");
            }
        }

        private void buttonClearInt_Click(object sender, EventArgs e)
        {
            Cleanint();
        }

        private void buttonClearMod_Click_1(object sender, EventArgs e)
        {
            Cleanmod();
        }
    }
}
