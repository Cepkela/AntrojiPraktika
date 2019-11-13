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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIkelti_Click(object sender, EventArgs e)
        {
            Kariai.Clear();
            if (table.Rows.Count > 1)
            {
                table.Rows.Clear();
            }
            string[] lines = File.ReadAllLines(@"C:\Users\Cepatronijus\source\repos\Apskaita\Apskaita\" + comboBox1.SelectedItem.ToString() + ".txt");
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
                int taskai = Convert.ToInt32(split[4]);
                string ivertinimas = split[5];
                Kariai.Add(new Karys(id, vardas, pavarde, laipsnis, taskai, ivertinimas));
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Vardas", typeof(string));
            table.Columns.Add("Pavarde", typeof(string));
            table.Columns.Add("Laipsnis", typeof(string));
            table.Columns.Add("Taškai", typeof(int));
            table.Columns.Add("Islaikyta", typeof(string));

            dgvKariai.DataSource = table;
        }
    }
}
