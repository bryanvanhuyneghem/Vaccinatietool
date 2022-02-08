using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaccinatietool.DA;
using Vaccinatietool.Model;

namespace Vaccinatietool
{
    public partial class VaccinatieTool : Form
    {
        private Vaccinator huidigeVaccinator;
        private Vaccin huidigVaccin;
        public VaccinatieTool()
        {
            InitializeComponent();
            FillVaccins();
            FillVaccinatoren();
        }
        private void FillVaccins()
        {
            foreach (Vaccin vac in VaccinDA.GetVaccins())
            {
                cbVaccin.Items.Add(vac.Naam);
            }
        }
        private void FillVaccinatoren()
        {
            foreach (Vaccinator vaccinator in VaccinatorDA.GetVaccinatoren())
            {
                cbVaccinator.Items.Add(vaccinator.Voornaam + " " + vaccinator.Familienaam);
            }
        }

        private void FillVaccinaties()
        {
            //Lijst eerst leegmaken
            lvVaccinaties.Items.Clear();
            //Elke vaccinatie uit de lijst halen
            if (VaccinatieDA.GetVaccinaties(BurgerDA.GetBurger(txtVoornaam.Text, txtNaam.Text)).Count != 0)
            {
                foreach (Vaccinatie vac in VaccinatieDA.GetVaccinaties(BurgerDA.GetBurger(txtVoornaam.Text, txtNaam.Text)))
                {
                    //Listviewitem aanmaken met meerdere kolommen
                    ListViewItem item = new ListViewItem(new String[] { vac.Vaccin.Naam, vac.Vaccin.Producent, vac.Vaccin.Type, vac.Datum.ToString() });
                    //Listviewitem toevoegen
                    lvVaccinaties.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Geen vaccinaties gevonden", "VaccinNet");
            }
        }
        private void btnZoekVaccinaties_Click(object sender, EventArgs e)
        {
            FillVaccinaties();
        }

        private void cbVaccin_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVaccinProducent.Text = "Producent: " + VaccinDA.GetVaccin(cbVaccin.SelectedItem.ToString()).Producent;
            lblVaccinType.Text = "Type: " + VaccinDA.GetVaccin(cbVaccin.SelectedItem.ToString()).Type;
            huidigVaccin = VaccinDA.GetVaccin(cbVaccin.SelectedIndex + 1);
        }

        private void btnVaccineer_Click(object sender, EventArgs e)
        {
            Vaccinatie vaccinatie = new Vaccinatie
            {
                Datum = DateTime.Today,
                Burger = BurgerDA.GetBurger(txtVoornaam.Text, txtNaam.Text),
                Vaccinator = huidigeVaccinator,
                Vaccin = huidigVaccin
            };
            VaccinatieDA.SaveVaccinatie(vaccinatie);
            FillVaccinaties();
        }

        private void cbVaccinator_SelectedIndexChanged(object sender, EventArgs e)
        {
            huidigeVaccinator = VaccinatorDA.GetVaccinator(cbVaccinator.SelectedIndex + 1);
            //Met strings:
            //string voornaam = cbVaccinator.SelectedItem.ToString().Substring(0, cbVaccinator.SelectedItem.ToString().IndexOf(" "));
            //string familienaam = cbVaccinator.SelectedItem.ToString().Substring(cbVaccinator.SelectedItem.ToString().IndexOf(" "));
            //huidigeVaccinator = VaccinatorDA.GetVaccinator(voornaam, familienaam);
        }
    }
}
