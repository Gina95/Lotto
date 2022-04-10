using Lotto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorsolas
{
    public partial class Form1 : Form
    {
        private List<int> tipp = new List<int>();
        private SzamokDbContext db = new SzamokDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void BeKapcsol()
        {
            Sorsol_Button.Enabled = false;
            foreach (CheckBox box in panel.Controls)
                box.Enabled = true;
        }

        private void KiKapcsol()
        {
            Sorsol_Button.Enabled = true;
            foreach (CheckBox box in panel.Controls)
            {
                if (!box.Checked) box.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tipp.Add(Convert.ToInt32(box.Text));
                if (tipp.Count() == 7) KiKapcsol();
            }
            else
            {
                tipp.Remove(Convert.ToInt32(box.Text));
                if (tipp.Count() < 7) BeKapcsol();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sorsol_Button.Enabled = false;
            panel.Size = new Size(600, 530);
            for (int j = 0; j < 5; j++)
                for (int i = 0; i < 7; i++)
                {
                    CheckBox box = new CheckBox();
                    box.AutoSize = true;
                    box.Text = (j * 7 + i + 1).ToString();
                    box.Tag = (j * 7 + i + 1).ToString();

                    box.CheckedChanged += checkBox1_CheckedChanged;

                    box.Location = new Point(i * 50 + 50, j * 50 + 50);
                    panel.Controls.Add(box);
                }
        }

        private void Sorsol_Button_Click(object sender, EventArgs e)
        {
            HashSet<int> keziSzamok = sorsolSzamok();
            HashSet<int> gepiSzamok = sorsolSzamok();
            var keziTalalat = keziSzamok.Intersect(tipp);
            var gepiTalalat = gepiSzamok.Intersect(tipp);

            MessageBox.Show($"Kisorsolt Kezi számok: {string.Join(", ", keziSzamok.OrderBy(x => x))}!" +
              $" {keziTalalat.Count()} találatod volt," +
              $" a {string.Join(", ", keziTalalat)}");

            MessageBox.Show($"Kisorsolt gepi számok: {string.Join(", ", gepiSzamok.OrderBy(x => x))}!" +
                $" {gepiTalalat.Count()} találatod volt," +
                $" a {string.Join(", ", gepiTalalat)}");
        }

        private HashSet<int> sorsolSzamok()
        {
            HashSet<int> gerenraltSzamok = new HashSet<int>();
            Random rnd = new Random();

            do
            {
                gerenraltSzamok.Add(rnd.Next(1, 35));
            } while (gerenraltSzamok.Count() != 7);

            db.Lottoszamok.Add(new Lotto.Szamok(gerenraltSzamok));
            db.SaveChanges();
            return gerenraltSzamok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
