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
    public partial class Form1 : Form
    {
        readonly DataTable table = new DataTable();
        readonly List<Karys> Kariai = new List<Karys>();
        readonly List<Vadovas> Vadovai = new List<Vadovas>();
        readonly List<Kuopa> Kuopos = new List<Kuopa>();
        int ranndomNumber;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnIkelti_Click(object sender, EventArgs e)
        {
            int kuopaId = 0;
            Kariai.Clear();
            if (table.Rows.Count > 1)
            {
                table.Rows.Clear();
            }
            string[] lines = File.ReadAllLines(@"C:\Users\Cepatronijus\source\repos\AntrojiPraktika\ApskaitaKar\ApskaitaKar\" + comboBox1.SelectedItem.ToString() + ".txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(' ');
                string s = lines[i];
                string[] split = s.Split(' ');
                int id = Convert.ToInt32(split[0]);
                string vardas = split[1];
                string pavarde = split[2];
                string laipsnis = split[3];
                DateTime date = Convert.ToDateTime(split[4]);
                string ivertinimas = split[5];
                Kariai.Add(new Karys(id, vardas, pavarde, laipsnis, date, ivertinimas));
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
            Kuopos.Add(new Kuopa(kuopaId, Kariai, comboBox1.SelectedItem.ToString()));
            kuopaId++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Vardas", typeof(string));
            table.Columns.Add("Pavarde", typeof(string));
            table.Columns.Add("Laipsnis", typeof(string));
            table.Columns.Add("Data", typeof(DateTime));
            table.Columns.Add("Islaikyta", typeof(string));

            dgvKariai.DataSource = table;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            if (Convert.ToInt32(txtKartojimas.Text) >= 5)
            {
                MessageBox.Show("Negalimas");
            }
            else
            {
                foreach (var karys in Kariai)
                {
                    karys.Soviniai = karys.soviniuPaskirstymas(Convert.ToInt32(txtKartojimas.Text));
                }
                if (Vadovai.Count == 0)
                {
                    string[] lines = File.ReadAllLines(@"C:\Users\Cepatronijus\source\repos\AntrojiPraktika\ApskaitaKar\ApskaitaKar\Vadovai.txt");
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] value = lines[i].ToString().Split(' ');
                        string s = lines[i];
                        string[] split = s.Split(' ');
                        Vadovai.Add(new Vadovas(Convert.ToInt32(split[0]), split[1], split[2], split[3]));
                    }
                    ranndomNumber = r.Next(0, Vadovai.Count - 1);
                    Vadovai[ranndomNumber].printVadovas();
                    foreach (var item in Kuopos)
                    {
                        if (item.Vadovas != null)
                        {
                            vadovoPriskyrimas();
                        }
                    }
                    vadovoPriskyrimas();
                }
                else
                {
                    ranndomNumber = r.Next(0, Vadovai.Count - 1);
                    Vadovai[ranndomNumber].printVadovas();
                    foreach (var item in Kuopos)
                    {
                        if (item.Vadovas!=null)
                        {
                            vadovoPriskyrimas();
                        }
                    }
                }
                
            }
        }
        public void vadovoPriskyrimas()
        {
            foreach (var item in Kuopos)
            {
                if (item.Pavadinimas == comboBox1.SelectedItem.ToString())
                {
                    item.Vadovas = Vadovai[ranndomNumber].Vardas;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 rezultIvedimas = new Form2(Kariai, this);
            rezultIvedimas.Show();

        }
    }
}
