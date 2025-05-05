using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLopresti20250505
{
    public partial class FrmIProyectoBase : Form
    {
        public FrmIProyectoBase()
        {
            InitializeComponent();
        }

        private void FrmIProyectoBase_Load(object sender, EventArgs e)
        {
            cmbHeroes.Items.Clear();
            cmbHeroes.Items.Add("Superman");
            cmbHeroes.Items.Add("Batman");
            cmbHeroes.Items.Add("WonderWoman");
        }

        private void cmbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbHeroes.SelectedIndex == 0)
            {
                imgHeroes.SizeMode = PictureBoxSizeMode.StretchImage;
                imgHeroes.Image = Image.FromFile("descargasuperman");

            }
        }
    }
}
