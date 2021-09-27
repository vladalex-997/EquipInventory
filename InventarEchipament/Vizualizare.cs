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
    public partial class Vizualizare : Form
    {
        public Vizualizare()
        {
            InitializeComponent();
        }

        private void Vizualizare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void buttonBackViz_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeniuForm men = new MeniuForm();
            men.Show();
        }

        private void Vizualizare_Load(object sender, EventArgs e)
        {
            try
            {
               // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               // dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
               dataGridView1.AllowUserToOrderColumns = true;
               dataGridView1.AllowUserToResizeColumns = true;

            


                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

                string query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat";

                SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

                SqlDataAdapter daquery = new SqlDataAdapter(myCommand);
                DataTable tab = new DataTable();
                DataSet ds = new DataSet();
                daquery.Fill(tab);
                daquery.Fill(ds);
                dataGridView1.DataSource = tab;
              


                databaseObject.CloseConnection();


            }
            catch (Exception)
            {
                MessageBox.Show("Eroare incarcare baza de date");
            }
        }

        private void buttonFiltrare_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase databaseObject = new DataBase();
                databaseObject.OpenConnection();

                string CodSAP = tbxCodSAP.Text;
                string Nume = tbxNume.Text;
                string Responsabil = tbxResponsabil.Text;
                string TipAngajat = tbxTipAngajat.Text;

                var v1 = (CodSAP == "" && Nume == "" && Responsabil == "" && TipAngajat == "");
                var v2 = (CodSAP == "" && Nume == "" && Responsabil == "" && TipAngajat != "");
                var v3 = (CodSAP == "" && Nume == "" && Responsabil != "" && TipAngajat == "");
                var v4 = (CodSAP == "" && Nume == "" && Responsabil != "" && TipAngajat != "");
                var v5 = (CodSAP == "" && Nume != "" && Responsabil == "" && TipAngajat == "");
                var v6 = (CodSAP == "" && Nume != "" && Responsabil == "" && TipAngajat != "");
                var v7 = (CodSAP == "" && Nume != "" && Responsabil != "" && TipAngajat == "");
                var v8 = (CodSAP == "" && Nume != "" && Responsabil != "" && TipAngajat != "");
                var v9 = (CodSAP != "" && Nume == "" && Responsabil == "" && TipAngajat == "");
                var v10 = (CodSAP != "" && Nume == "" && Responsabil == "" && TipAngajat != "");
                var v11 = (CodSAP != "" && Nume == "" && Responsabil != "" && TipAngajat == "");
                var v12 = (CodSAP != "" && Nume == "" && Responsabil != "" && TipAngajat != "");
                var v13 = (CodSAP != "" && Nume != "" && Responsabil == "" && TipAngajat == "");
                var v14 = (CodSAP != "" && Nume != "" && Responsabil == "" && TipAngajat != "");
                var v15 = (CodSAP != "" && Nume != "" && Responsabil != "" && TipAngajat == "");
                var v16 = (CodSAP != "" && Nume != "" && Responsabil != "" && TipAngajat != "");

                string query = "";

                if (v1)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat";
                }
                else if (v2)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                        "WHERE TipAngajat LIKE '%" +TipAngajat+ "%'";
                }
                else if (v3)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                        "WHERE Responsabil LIKE '%" + Responsabil + "%'";
                }
                else if (v4)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                        "WHERE TipAngajat LIKE '%" + TipAngajat + "%' " +
                        "AND Responsabil LIKE '%" + Responsabil + "%'";
                        
                }
                else if (v5)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                   "WHERE Nume LIKE '%" + Nume + "%'";
                }
                else if (v6)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                "WHERE Nume LIKE '%" + Nume + "%' " +
                "AND TipAngajat LIKE '%" + TipAngajat + "%'";
                }
                else if (v7)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                "WHERE Nume LIKE '%" + Nume + "%' " +
                "AND Responsabil LIKE '%" + Responsabil + "%'";
                }
                else if (v8)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
            "WHERE Nume LIKE '%" + Nume + "%' " +
            "AND Responsabil LIKE '%" + Responsabil + "%' " +
            "AND TipAngajat LIKE '%" + TipAngajat + "%'";
                }
                else if (v9)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                "WHERE A.CodSAP LIKE '%" + CodSAP + "%'";
                }
                else if (v10)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
              "WHERE A.CodSAP LIKE '%" + CodSAP + "%' " +
              "AND TipAngajat LIKE '%" + TipAngajat + "%'";
                }
                else if (v11)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
             "WHERE A.CodSAP LIKE '%" + CodSAP + "%' " +
             "AND Responsabil LIKE '%" + Responsabil + "%'";
                }
                else if (v12)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
             "WHERE A.CodSAP LIKE '%" + CodSAP + "%' " +
             "AND Responsabil LIKE '%" + Responsabil + "%' " +
             "AND TipAngajat LIKE '%" + TipAngajat + "%'";
                }
                else if (v13)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                "WHERE A.CodSAP LIKE '%" + CodSAP + "%' " +
                "AND Nume LIKE '%" + Nume + "%'";
                }
                else if (v14)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                "WHERE A.CodSAP LIKE '%" + CodSAP + "%' " +
                "AND Nume LIKE '%" + Nume + "%' " +
                "AND TipAngajat LIKE '%" + TipAngajat + "%'";
                }
                else if (v15)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
                "WHERE A.CodSAP LIKE '%" + CodSAP + "%' " +
                "AND Nume LIKE '%" + Nume + "%' " +
                "AND Responsabil LIKE '%" + Responsabil + "%'";
                }
                else if (v16)
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat " +
               "WHERE A.CodSAP LIKE '%" + CodSAP + "%' " +
               "AND Nume LIKE '%" + Nume + "%' " +
               "AND Responsabil LIKE '%" + Responsabil + "%' " +
               "AND TipAngajat LIKE '%" + TipAngajat + "%'";
                }
                else
                {
                    query = "SELECT IdRecord,StatusAngajat,A.CodSAP,Nume,Functie,Responsabil,TipAngajat,DataAngajarii,CostCenterNr,CostCenterNume,Incaltaminte,DataIncaltaminte,Bluze,DataBluze,Pantaloni,DataPantaloni,Tricouri,DataTricouri,Jachete,DataJachete,Auxiliare,DataAuxiliare from Angajati as A FULL JOIN Echipament as B ON A.IdAngajat=B.IdAngajat";
                }

                SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);

                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                


                



                databaseObject.CloseConnection();

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Filtrare");
            }

        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
        
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
    }
}
