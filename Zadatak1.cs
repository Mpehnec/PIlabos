using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<string> listaTroskova = new List<string>();
        public Form1()
        {
            InitializeComponent();
            uiActionIzborTroska.Items.Add("Hrana");
            uiActionIzborTroska.Items.Add("Zabava");
            uiActionIzborTroska.Items.Add("Zdravlje");
            uiActionIzborTroska.Items.Add("Edukacija");
            

        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            string unos = uiActionIzborTroska.SelectedItem + " " + uiCijena.Text + " " + "kuna";
            listaTroskova.Add(unos);
            uiIspis.Text = "";
            for (int i = listaTroskova.Count-1; i >= 0; i--)
            {
                uiIspis.Text += listaTroskova[i] + Environment.NewLine;
            }
            
        }

        private void uiActionFilter_Click(object sender, EventArgs e)
        {
           
            for (int i = listaTroskova.Count-1; i >=0; i--)
            {
 
            if (uiActionIzborTroska.SelectedIndex==1)
            {
                uiIspis.Text += listaTroskova[i].Equals("Hrana");
            }
            else if (uiActionIzborTroska.SelectedIndex == 2)
            {
                    uiIspis.Text += listaTroskova[i].Equals("Zabava");
            }
            else if (uiActionIzborTroska.SelectedIndex == 3)
            {
                    uiIspis.Text += listaTroskova[i].Equals("Zdravlje");
            }
            else
            {
                    uiIspis.Text += listaTroskova[i].Equals("Edukacija");
            }


            }
    }
    }
}
