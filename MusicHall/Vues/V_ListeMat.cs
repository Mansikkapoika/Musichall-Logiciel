using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicHall.Modeles;
using MusicHall.Classes;

namespace MusicHall.Vues
{
    public partial class V_ListeMat : Form
    {
        public V_ListeMat()
        {
            InitializeComponent();
        }

        private void V_ListeMat_Load(object sender, EventArgs e)
        {
            DataTable dtMat;
            dtMat = M_Materiel.getMaterielDt();
            tableauMateriel.DataSource = dtMat;
        }
    }
}
