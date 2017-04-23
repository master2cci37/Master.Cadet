using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
#if (Linq35)
using System.Linq;           
#endif
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CADET
{
    public partial class FormCreationManuelle : Form
    {
        public FormCreationManuelle()
        {
            InitializeComponent();

            try
            {
                // connexion a la bd
                //Création de la connection 

                ClassConnexionBD.ConnexionBDCADET = new SqlConnection(ClassConnexionBD.connectionString);
                ClassConnexionBD.ConnexionBDCADET.Open();

                // affichage des comptes

                // creation de la requete
                SqlCommand selectTousLesComptes = new SqlCommand("SELECT * FROM Compte", ClassConnexionBD.ConnexionBDCADET);
                selectTousLesComptes.CommandType = System.Data.CommandType.Text;

                //on utilise le dataadapter pour remplir le dataset
                //on attribue la commande au selectTousLesComptes
                SqlDataAdapter localDataAdapter = new SqlDataAdapter(selectTousLesComptes);

                //on vide le dataset
                ClassConnexionBD.dataSetCADET.Clear();

                //On remplie le dataset
                localDataAdapter.Fill(ClassConnexionBD.dataSetCADET.Tables["Compte"]);
                ClassConnexionBD.dataSetCADET.WriteXml("c:\\cadetcci08.xml", XmlWriteMode.WriteSchema);


                //on affecte le datasource du datagrid afin de visualiser les données
                dataGridViewCompte.DataSource = ClassConnexionBD.dataSetCADET.Tables["Compte"];

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                ClassConnexionBD.ConnexionBDCADET.Close();
            }
        }
    }
}
