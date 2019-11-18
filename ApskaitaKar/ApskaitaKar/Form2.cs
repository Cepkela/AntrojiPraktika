using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApskaitaKar
{
    public partial class Form2 : Form
    {
        List<Karys> Kariais;
        public Form2(List<Karys> Kariai)
        {
            InitializeComponent();
            Kariais = Kariai;
            pridetiKaruius();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Kariais)
            {
                if (item.Vardas + " " + item.Pavarde == cbVardas.SelectedItem.ToString())
                {
                    item.padeciuIrasymas(Convert.ToInt32(txtGulint.Text), Convert.ToInt32(txtStovint.Text), Convert.ToInt32(txtIsApkaso.Text),
                        Convert.ToInt32(txtSedint.Text), Convert.ToInt32(txtPriklaupus.Text));
                    if (Convert.ToInt32(txtGulint.Text)<201 && Convert.ToInt32(txtStovint.Text)<451 && Convert.ToInt32(txtIsApkaso.Text)<201 && Convert.ToInt32(txtSedint.Text)<251
                        && Convert.ToInt32(txtPriklaupus.Text)<250 && Convert.ToInt32(txtGulint.Text) > 0 && Convert.ToInt32(txtStovint.Text) > 0 && Convert.ToInt32(txtIsApkaso.Text) > 0 
                        && Convert.ToInt32(txtSedint.Text) > 0 && Convert.ToInt32(txtPriklaupus.Text) > 0)
                    {
                        item.Ivertinimas = "Į";
                        item.Soviniai = 0;
                    }
                    else
                    {
                        item.Ivertinimas = "NĮ";
                        item.Soviniai = 0;
                    }
                }
            }
        }
        private void pridetiKaruius()
        {
            foreach (var item in Kariais)
            {
                cbVardas.Items.Add(item.Vardas + " " + item.Pavarde);
            }
        }
    }
}
