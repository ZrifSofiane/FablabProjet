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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<String> listeInfo = new List<string>();
        private int[] tabEcole = new int[] { 0, 0, 0 };
        private DateTime date;
        private String cheminURL = "";
        private String texteNom;
        private String textePrenom;
        private String texteEmail;
        private String texteButImpreesion;
        private String texteFichier;
        private String RadioEcole;
        private String date1 ;
        private int[] champsIncorrect; 
        private bool champsCompletes;
        private String indiqueCriterePasBon;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Prenom_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomTexte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            champsIncorrect= new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            champsCompletes = false;
            texteNom = NomTexte.Text;
            textePrenom = PrenomTexte.Text;
            texteEmail = EmailTexte.Text;
            texteButImpreesion = ImpressionText.Text;
            texteFichier = texteNomFichier.Text;
            RadioEcole = "";
            date = DateListe.Value;
            date1 = date.ToString();
            if(tabEcole[0] == 1)
            {
                RadioEcole = "ESILV";
            }
            else if (tabEcole[1]==1)
            {
                RadioEcole = "IIM";
            }
            else if(tabEcole[2] == 1)
            {
                RadioEcole = "EMLV";
            }
            int nombreQuantité = (int)QuantiteNombre.Value;


            String[] critere = new String[] { "Nom  ", "Prénom  ","Email  ", "Ecole  " , "But impression  ","Date  ","Quantité  ","Nom du Fichier  ", "Fichier " };
            String[] critereResultat = new String[] { texteNom, textePrenom,texteEmail, RadioEcole, texteButImpreesion, date1 ,nombreQuantité.ToString(),texteFichier,cheminURL};
            champsCompletes = true;
            for(int i=0;i<critereResultat.Length;i++)
            {
                if(critereResultat[6]=="0")
                {
                    champsCompletes = false;
                    champsIncorrect[6] = 0;
                }
                if(critereResultat[i] == "")
                {
                    champsCompletes = false;
                    champsIncorrect[i] = 0;
                }
            }
            if(champsCompletes)
            {
                //On affiche le texte 

                String recap="";
                for(int i=0; i<critere.Length;i++)
                {
                    recap = recap + critere[i] +":"+ critereResultat[i] + "\n";
                }
                recap = recap + "\n URL " + cheminURL;
                String nomFichier = texteNom + "_" + textePrenom+"_"+texteFichier;
                String reception = "C:/Users/boura/Desktop/";
                reception = reception + nomFichier;
                reception = reception + ".stl";
                File.Copy(cheminURL, reception, true);
                recap = recap + "\n"+reception;
                MessageBox.Show(recap,"Récapitulatif", MessageBoxButtons.OK);
            }
            else
            {
                indiqueCriterePasBon = "Erreur : Veuillez revérifier les champs suivant : \n- ";
                for(int i=0; i<critere.Length;i++)
                {
                    if(champsIncorrect[i] == 0)
                    {
                        indiqueCriterePasBon += critere[i] + "\n- ";
                    }
                    
                }
                indiqueCriterePasBon += "Merci :)";
                MessageBox.Show(indiqueCriterePasBon, "Erreur : Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void ESILV_CheckedChanged(object sender, EventArgs e)
        {
            tabEcole[0] = 1;
            tabEcole[1] = 0;
            tabEcole[2] = 0;
        }


        private void NomTexte_Leave(object sender, EventArgs e)
        {
           
        }

        private void PrenomTexte_Leave(object sender, EventArgs e)
        {
           
        }

        private void ESILV_Leave(object sender, EventArgs e)
        {
            
        }

        private void IIM_Leave(object sender, EventArgs e)
        {
            
        }

        private void EMLV_Leave(object sender, EventArgs e)
        {
            
        }

        private void ImpressionText_Leave(object sender, EventArgs e)
        {
            
        }

        private void QuantiteNombre_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void IIM_CheckedChanged(object sender, EventArgs e)
        {
            tabEcole[0] = 0;
            tabEcole[1] = 1;
            tabEcole[2] = 0;
        }

        private void EMLV_CheckedChanged(object sender, EventArgs e)
        {
            tabEcole[0] = 0;
            tabEcole[1] = 0;
            tabEcole[2] = 1;
        }

        private void Ouvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ouvrirDialog = new OpenFileDialog();
            ouvrirDialog.Title = "Ouverture d'un fichier STL";
            ouvrirDialog.Filter = "Fichier STL (*STL)|*STL";
            if(ouvrirDialog.ShowDialog() == DialogResult.OK)
            {
                cheminURL = ouvrirDialog.FileName;
            }
        }
    }
}
