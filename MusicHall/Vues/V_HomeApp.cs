using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicHall.Vues;

namespace MusicHall
{
    public partial class HomeApp : Form
    {
        public HomeApp()
        {
            InitializeComponent();
            // Definition de la couleur des MDI containers (propriété Backcolor du MDI buguée)
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = SystemColors.ActiveCaption;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aPropos fenetre;
            fenetre = new aPropos();
            // fenetre.MdiParent = this; // Retiré pour affichage extérieur indépendant
            fenetre.Show();
        }

        private void materielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMat fenetre;
            fenetre = new GestionMat();
            fenetre.MdiParent = this;
            fenetre.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void commandesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            V_GestionCom fenetre;
            fenetre = new V_GestionCom();
            fenetre.MdiParent = this;
            fenetre.Show();
        }

        private void locationsEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_ListeMat fenetre;
            fenetre = new V_ListeMat();
            fenetre.MdiParent = this;
            fenetre.Show();
        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_ListeCom fenetre;
            fenetre = new V_ListeCom();
            fenetre.MdiParent = this;
            fenetre.Show();
        }

        private void gestionDesStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_GestionStock fenetre;
            fenetre = new V_GestionStock();
            fenetre.MdiParent = this;
            fenetre.Show();
        }
    }
}
