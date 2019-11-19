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

namespace ApskaitaKar
{
    public partial class Form2 : Form
    {
        Form1 formm1;
        List<Karys> Kariais;
        DateTime date;
        public Form2(List<Karys> Kariai, Form1 form1)
        {
            formm1 = form1;
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
                        item.Data = DateTime.Now.Date;
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

        private void BtnIšsaugoti_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\Users\Cepatronijus\source\repos\AntrojiPraktika\ApskaitaKar\ApskaitaKar\" +
                formm1.comboBox1.SelectedItem.ToString() + ".txt", String.Empty);
            foreach (var item in Kariais)
            {
                string[] lines = { item.Id + " " + item.Vardas + " " + item.Pavarde + " " + item.Laipsnis + " " + item.Data.Date.ToShortDateString() + " " + item.Ivertinimas };
                System.IO.File.AppendAllLines(@"C:\Users\Cepatronijus\source\repos\AntrojiPraktika\ApskaitaKar\ApskaitaKar\"+formm1.comboBox1.SelectedItem.ToString()+".txt", lines);
            }
            MessageBox.Show("Issaugota");
        }

        private void BtnGryžti_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
