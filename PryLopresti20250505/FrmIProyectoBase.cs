using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string csvPath = @"heroes.csv";
        private void FrmIProyectoBase_Load(object sender, EventArgs e)
        {
            
            cmbHeroes.Items.Clear();
            cmbHeroes.Items.Add("Superman");
            cmbHeroes.Items.Add("Batman");
            cmbHeroes.Items.Add("WonderWoman");

            numFuerza.Maximum = 10;
            numFuerza.Minimum = 1;
            numDestreza.Maximum = 10;
            numDestreza.Minimum = 1;
            if (!File.Exists(csvPath))
            {
                using (StreamWriter writer = new StreamWriter(csvPath, false))
                {
                    writer.WriteLine("Fuerza,Destreza");
                   
                }
            }
        }


        private void cmbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHeroes.SelectedIndex != -1)
            {
                imgHeroes.SizeMode = PictureBoxSizeMode.StretchImage;
                imgHeroes.Image = Properties.Resources.descargasuperman;
            }
            if (cmbHeroes.SelectedIndex == 1)
            {
                imgHeroes.SizeMode = PictureBoxSizeMode.StretchImage;
                imgHeroes.Image = Properties.Resources.descargabatman;
            }
            if (cmbHeroes.SelectedIndex == 2)
            {
                imgHeroes.SizeMode = PictureBoxSizeMode.StretchImage;
                imgHeroes.Image = Properties.Resources.descargawonderwoman;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cmbHeroes.SelectedItem != null)
            {
               
                int fuerza = (int)numFuerza.Value;
                int destreza = (int)numDestreza.Value;

                
                GuardarDatosCSV(fuerza, destreza);

                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un héroe antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GuardarDatosCSV(int fuerza, int destreza)
        {
            string csvPath = @"heroes.csv"; 

            using (StreamWriter writer = new StreamWriter(csvPath, true))
            {
                writer.WriteLine($"{fuerza},{destreza}");
                
            }
        }

    }
}
