using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicHall
{
    public partial class HomeApp : Form
    {
        public HomeApp()
        {
            InitializeComponent();
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
    }
}
