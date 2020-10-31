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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerSzuDatum.Format = DateTimePickerFormat.Custom;
        }


        private List<Szemely> szemelyekList = new List<Szemely>();

        static bool valid;


        private void btnHozzad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUjHobbi.Text))
            {
                MessageBox.Show("Nem adtál meg hobbit (vagy csak szöközöket)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUjHobbi.Focus();
                return;
            }

            string ujHobbi = txtUjHobbi.Text.Trim();

            if (!listHobbi.Items.Contains(ujHobbi))
            {
                listHobbi.Items.Add(ujHobbi);
            }

            else
            {
                MessageBox.Show("A medadott új hobbi már szerepel a listában!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUjHobbi.Focus();
            }
        }


        private void btnMentes_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result != DialogResult.OK)
            {
                MessageBox.Show("Nem választott ki fájlt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNev.Focus();
                valid = false;
                return;
            }


            // ------- Név -------

            if (String.IsNullOrWhiteSpace(txtNev.Text))
            {
                MessageBox.Show("Nem adtad meg a nevedet (vagy csak szöközöket)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNev.Focus();
                valid = false;
                return;
            }

            else
            {
                valid = true;
            }

            string nev = txtNev.Text.Trim();


            // ------- Születési dátum -------

            DateTime szulDatum = DateTime.MinValue;

            if (dateTimePickerSzuDatum.Value.Date > DateTime.Now)
            {
                MessageBox.Show("A születési dátum nem lehet újabb a jelenlegi dátumnál!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerSzuDatum.Focus();
                valid = false;
            }

            else
            {
                szulDatum = dateTimePickerSzuDatum.Value.Date;
                valid = true;
            }


            // ------- Nem -------

            string nem = null;


            if (!rdoFerfi.Checked && !rdoNo.Checked)
            {
                MessageBox.Show("Nem adtad meg a nemedet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
                return;
            }


            if (rdoFerfi.Checked == true)
            {
                nem = "ferfi";
                valid = true;
            }

            if (rdoNo.Checked == true)
            {
                nem = "no";
                valid = true;
            }


            // ------- Hobbi -------

            string hobbi = "";

            if (listHobbi.SelectedIndex == -1)
            {
                MessageBox.Show("Nem adtad meg a kedvenc hobbidat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }

            else
            {
                hobbi = listHobbi.SelectedItem.ToString();
                valid = true;
            }



            // ------- Példány létrehozása, és listába helyezése -------

            Szemely ujSzemely = new Szemely(nev, szulDatum, nem, hobbi);

            szemelyekList.Add(ujSzemely);



            // ------- Fájlba írás -------

            if (valid == true)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName)) //true, Encoding.UTF8
                    {
                        foreach (Szemely item in szemelyekList)
                        {
                            sw.WriteLine(item.Nev); // sw.WriteLine(item.Nev + ";");
                            sw.WriteLine(item.SzulDatum);
                            sw.WriteLine(item.Nem);
                            sw.WriteLine(item.Hobbi);
                        }


                        foreach (var item in listHobbi.Items)
                        {
                            sw.WriteLine("HobbiLista: " + item); //sw.WriteLine("HobbiLista: " + item + ";");
                        }

                        MessageBox.Show("Sikeres mentés!");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Hiba a fájlba mentéskor!");
                }

            }
        }


        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK)
            {
                MessageBox.Show("Nem választott ki fájlt, így nem fog betöltődni!");
                return;
            }


            try
            {
                using (var sr = new StreamReader(openFileDialog1.FileName))
                {
                    listHobbi.Items.Clear();
                    txtNev.Clear();
                    rdoFerfi.Checked = false;
                    rdoNo.Checked = false;

                    txtNev.Text = sr.ReadLine();
                    dateTimePickerSzuDatum.Value = DateTime.Parse(sr.ReadLine());

                    if (sr.ReadLine() == "ferfi")
                    {
                        rdoFerfi.Checked = true;
                    }

                    else
                    {
                        rdoNo.Checked = true;
                    }

                    

                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();

                        if (sor.StartsWith("HobbiLista: "))
                        {
                            string asd = sor.Substring(12);
                            listHobbi.Items.Add(asd);
                            listHobbi.SelectedItem = asd;
                        }
                    }
                    
                    MessageBox.Show("Sikeres fájl beolvasás!");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Hiba a beolvasás során!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a fájl feldolgozása közben!");
            }
        }
    }
}
