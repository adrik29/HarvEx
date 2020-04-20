using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eggpies
{
    public partial class Form1 : Form
    {
        #region UPDATE
        private void AddCountriesToCB_panCountries()
        { // 1 NAM, 2 EUR, 3 ASI, 4 SAM, 5 AFR, 6 OCE, 7 ANT
            cbCountriesPanCountries.Items.Clear();
            cbCountriesPanCountries.Text = "";
            if (chosen_continent == 1)
            {
                for (int i = 0; i < countriesNAM.Length; i++)
                    if (countries.BinarySearch(countriesNAM[i]) >= 0)
                        cbCountriesPanCountries.Items.Add(countriesNAM[i]);
            }

            else if (chosen_continent == 2)
            {
                for (int i = 0; i < countriesEUR.Length; i++)
                    if (countries.BinarySearch(countriesEUR[i]) >= 0)
                        cbCountriesPanCountries.Items.Add(countriesEUR[i]);
            }
            else if (chosen_continent == 3)
            {
                for (int i = 0; i < countriesASI.Length; i++)
                    if (countries.BinarySearch(countriesASI[i]) >= 0)
                        cbCountriesPanCountries.Items.Add(countriesASI[i]);
            }
            else if (chosen_continent == 4)
            {
                for (int i = 0; i < countriesSAM.Length; i++)
                    if (countries.BinarySearch(countriesSAM[i]) >= 0)
                        cbCountriesPanCountries.Items.Add(countriesSAM[i]);
            }
            else if (chosen_continent == 5)
            {
                for (int i = 0; i < countriesAFR.Length; i++)
                    if (countries.BinarySearch(countriesAFR[i]) >= 0)
                        cbCountriesPanCountries.Items.Add(countriesAFR[i]);
            }
            else if (chosen_continent == 6)
            {
                for (int i = 0; i < countriesOCE.Length; i++)
                    if (countries.BinarySearch(countriesOCE[i]) >= 0)
                        cbCountriesPanCountries.Items.Add(countriesOCE[i]);
            }
            else if (chosen_continent == 7)
            {
                for (int i = 0; i < countriesANT.Length; i++)
                    if (countries.BinarySearch(countriesANT[i]) >= 0)
                        cbCountriesPanCountries.Items.Add(countriesANT[i]);
            }
        }

        private void UpdateTotal(int[] speciesInGroup)
        {
            largestLegends.Clear();
            List<int> temp = new List<int>();
            total = 0;
            for (int i = 0; i < speciesInGroup.Length; i++)
            {
                if (speciesInGroup[i] > minSP)
                {
                    total += speciesInGroup[i];
                    temp.Add(speciesInGroup[i]);
                }
            }
            others = total;
            temp.Sort();
            while (temp.Count > 0 && largestLegends.Count < 50)
            {
                largestLegends.Insert(0, temp.Last());
                others -= temp.Last();
                temp.RemoveAt(temp.Count - 1);
            }
            labTotalSp.Text = "Total species: ";
            //labTotalSp.Text += (sp_in_country[chosenCountry]).Count.ToString();
            //if (mode.byCountry) labTotalSp.Text += pie.Series["s1"].Points.Count.ToString();
            if (mode.byRealm || mode.byCountry) labTotalSp.Text += total.ToString();
            else
            {
                labTotalSp.Text += (total - occurrencesDesconto).ToString();
                labTotalSp.Text += "\n(" + total.ToString() + " occurrences)";
            }
        }

        private void UpdateFamLabel(int code, string key)
        {  // code: 1 = genus + fam + sub, 2 = fam + sub, 3 = fam
            if (NotAvailable(key))
            {
                labFamAndSub.Text = "Not available";
                return;
            }
            string s = "";
            if (code == 2)
            {
                int subIndex = subfamilies.BinarySearch(key);
                if (subIndex >= 0)
                {
                    try
                    {
                        if (sub_parents[subIndex] >= 0)
                            s += families[sub_parents[subIndex]] + ", ";
                    }
                    catch
                    {
                        s += "[Not Found], ";
                    }
                }

            }
            else if (code == 1)
            {
                int genIndex = genera.BinarySearch(key);
                if (genIndex >= 0)
                {
                    try
                    {
                        if (genera_grandparents[genIndex] >= 0)
                            s += families[genera_grandparents[genIndex]] + ", ";
                        if (genera_parents[genIndex] >= 0)
                            s += subfamilies[genera_parents[genIndex]] + ", ";
                    }
                    catch
                    {
                        s += "[Not Found], ";
                    }
                }
            }
            s += key;
            labFamAndSub.Text = s;
        }

        private void UpdateFlagAndName(string s)
        {
            if (panCountries.Visible)
            {
                labCountryNamePanCountries.Visible = true;
                picFlagPanCountries.Visible = true;
                picLoc.Visible = true;
                picPhys.Visible = true;
                labCountryNamePanCountries.Text = ShowCountryName(s);
            }
            else
            {
                labCountryName.Visible = true;
                picFlag.Visible = true;
                labCountryName.Text = ShowCountryName(s);
            }
            string path = "country flags/";
            path += s + ".png";
            if (panCountries.Visible)
            {
                try
                {
                    picFlagPanCountries.BackgroundImage = Image.FromFile(path);
                }
                catch
                {
                    path = "country flags/XXX.png";
                    picFlagPanCountries.BackgroundImage = Image.FromFile(path);
                }
                path = "country_maps_loc/" + s + "-loc.jpg";
                try
                {
                    picLoc.BackgroundImage = Image.FromFile(path);
                }
                catch
                {
                    path = "country flags/XXX.png";
                    picLoc.BackgroundImage = Image.FromFile(path);
                }
                path = "country_maps_loc/" + s + "-phys.jpg";
                try
                {
                    picPhys.BackgroundImage = Image.FromFile(path);
                }
                catch
                {
                    path = "country flags/XXX.png";
                    picPhys.BackgroundImage = Image.FromFile(path);
                }
            }
            else
            {
                try
                {
                    picFlag.BackgroundImage = Image.FromFile(path);
                }
                catch
                {
                    path = "country flags/XXX.png";
                    picFlag.BackgroundImage = Image.FromFile(path);
                }
            }
        }

        private void Update_rtb_PanCountries()
        {
                rtbPanCountries.Clear();
                int countryIndex = countries.BinarySearch(cbCountriesPanCountries.Text);
                if (countryIndex >= 0)
                {
                    string s = "";
                    for (int i = 0; i < families_in_country[countryIndex].Count; i++)
                    {
                        int famIndex = -1;
                        string family;
                        try
                        {
                            famIndex = families_in_country[countryIndex][i];
                            family = families[famIndex];
                        }
                    catch { family = "Erro malukossauro"; famIndex = -1; }
                        if (NotAvailable(family))
                            s += "Unknown family" + "\n";
                        else s += family + "\n";
                        if (famIndex > -1)
                        {
                            List<string> linhas = new List<string>();
                            for (int j = 0; j < species_in_family[famIndex].Count; j++)
                            {
                                int spIndex = -1;
                                try { spIndex = species_in_family[famIndex][j]; }
                                catch { spIndex = -1; }
                                if (sp_in_country[countryIndex].BinarySearch(spIndex) >= 0)
                                {
									string species, author, year;
									try { species = sp[spIndex].epithet; }
									catch { species = "Erro MaaLuKozzAURO"; }
									try { author = sp[spIndex].author; }
									catch { author = "Erro MaaLuKozzAwRO"; }
									try { year = sp[spIndex].year.ToString(); }
									catch { year = "Erru MaaLuKkossAwRO"; }
									int genusIndex;
									string genus;
									try
									{
										genusIndex = sp_parents[spIndex];
										genus = genera[genusIndex];
									}
									catch { genus = "Erro malucossauro"; }
									string nome = "\t\t\t\t" + genus + " " + species + " ";
									if (sp[spIndex].parentheses) nome += "(";
									nome += (author + ", " + year);
									if (sp[spIndex].parentheses) nome += ")";
									linhas.Add(nome + "\n");
                                }
                            }
                            linhas.Sort();
                            for (int j = 0; j < linhas.Count; j++)
                                s += linhas[j];
                        }
                    }
                    rtbPanCountries.Text = s;
                }
                else rtbPanCountries.Text = "ERROR -- BINARY SEARCH RETURNED -1.";

        }

        private void Reset_Pics_Modes_Color()
        {
            picHand.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_hand;
            picLeaf.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_leaf;
            picGlobe.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_world;
        }
        #endregion

        #region COMBO BOXES
        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthor.SelectedItem == null) return;
            mode.byAuthor = true;
            radioGenus.Visible = true;
            radioSubfamily.Visible = true;
            radioFamily.Visible = true;
            if (cbRealm.SelectedItem != null) GeneratePie();
        }

        private void cbRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRealm.SelectedItem == null) return;
            if (cbAuthor.Text == "") mode.byAuthor = false;
            cbAuthor.Items.Clear();
            cbAuthor.Items.Add("All authors");
            if (cbRealm.SelectedItem == "ALL")
            {
                ResetChart();
                HideFlag();
                for (int i = 0; i < authors.Count; i++)
                    cbAuthor.Items.Add(authors[i]);
                mode.byRealm = false;
                mode.byCountry = false;
                return;
            }
            int realmIndex = realms.BinarySearch(cbRealm.Text);
            for (int i = 0; i < authors_in_realm[realmIndex].Count; i++)
                cbAuthor.Items.Add(authors[authors_in_realm[realmIndex][i]]);
            mode.ByRealm();
            cbCountry.Items.Clear();
            cbCountry.Text = "";
            GeneratePie();
            UpdateFlagAndName(cbRealm.Text);
            radioGenus.Visible = true;
            radioSubfamily.Visible = true;
            radioFamily.Visible = true;
            checkEndemic.Visible = true;
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedItem == null) return;
            if (cbAuthor.Text == "") mode.byAuthor = false;
            mode.ByCountry();
            cbAuthor.Items.Clear();
            cbAuthor.Items.Add("All authors");
            int countryIndex = countries.BinarySearch(cbCountry.Text);
            for (int i = 0; i < authors_in_country[countryIndex].Count; i++)
                cbAuthor.Items.Add(authors[authors_in_country[countryIndex][i]]);
            GeneratePie();
            UpdateFlagAndName(cbCountry.Text);
            radioGenus.Visible = true;
            radioSubfamily.Visible = true;
            radioFamily.Visible = true;
            checkEndemic.Visible = true;
        }

        private void cbGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGenus.SelectedItem == null) return;
            cbSubfamily.SelectedItem = null;
            cbSubfamily.Text = "";
            cbFamily.SelectedItem = null;
            cbFamily.Text = "";
            mode.ByGenus();
            GeneratePie();
            radioRealm.Visible = true;
            radioCountry.Visible = true;
            checkEndemic.Visible = true;
            UpdateFamLabel(1, cbGenus.Text);
        }

        private void cbSubfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubfamily.SelectedItem == null) return;
            cbFamily.SelectedItem = null;
            cbFamily.Text = "";
            cbGenus.SelectedItem = null;
            cbGenus.Text = "";
            if (cbSubfamily.SelectedItem == null) return;
            mode.BySubfamily();
            GeneratePie();
            radioRealm.Visible = true;
            radioCountry.Visible = true;
            checkEndemic.Visible = true;
            UpdateFamLabel(2, cbSubfamily.Text);
        }

        private void cbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFamily.SelectedItem == null) return;
            cbSubfamily.SelectedItem = null;
            cbSubfamily.Text = "";
            cbGenus.SelectedItem = null;
            cbGenus.Text = "";
            if (cbFamily.SelectedItem == null) return;
            mode.ByFamily();
            GeneratePie();
            radioRealm.Visible = true;
            radioCountry.Visible = true;
            checkEndemic.Visible = true;
            UpdateFamLabel(3, cbFamily.Text);
        }

        private void radioGenus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGenus.Checked == true)
            {
                mode.genus = true;
                mode.subfamily = false;
                mode.family = false;
            }
            GeneratePie();
        }

        private void radioSubfamily_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSubfamily.Checked == true)
            {
                mode.genus = false;
                mode.subfamily = true;
                mode.family = false;
            }
            GeneratePie();
        }

        // COUNTRIES PANEL
        private void cbCountriesPanCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountriesPanCountries.SelectedItem == null) return;
            UpdateFlagAndName(cbCountriesPanCountries.Text);
            Update_rtb_PanCountries();
        }
        #endregion

        #region BUTTON CLICKS

        private void btnContinents_Click(object sender, EventArgs e)
        {
            OpenContinents();
        }

        private void picNAM_Click(object sender, EventArgs e)
        {
            chosen_continent = 1;
            OpenCountries();
        }

        private void picEUR_Click(object sender, EventArgs e)
        {
            chosen_continent = 2;
            OpenCountries();
        }

        private void picASI_Click(object sender, EventArgs e)
        {
            chosen_continent = 3;
            OpenCountries();
        }

        private void picSAM_Click(object sender, EventArgs e)
        {
            chosen_continent = 4;
            OpenCountries();
        }

        private void picAFR_Click(object sender, EventArgs e)
        {
            chosen_continent = 5;
            OpenCountries();
        }

        private void picOCE_Click(object sender, EventArgs e)
        {
            chosen_continent = 6;
            OpenCountries();
        }

        private void picANT_Click(object sender, EventArgs e)
        {
            chosen_continent = 7;
            OpenCountries();
        }

        private void picHand_Click(object sender, EventArgs e)
        {
            Text = "Harvex   -   MODE: DIVERSITY BY AREA / AUTHORS                          Database version: " + last_update;
            Absorb_Buttons();
            if (mode.byContinents) CloseContinents();
            if (mode.byFamily || mode.bySubfamily || mode.byGenus) QuitRankMode();
            mode.ByRealm();
            picHand.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_hand_inverted;
        }

        private void picLeaf_Click(object sender, EventArgs e)
        {
            Text = "Harvex   -   MODE: TAXON DISTRIBUTION                          Database version: " + last_update;
            Absorb_Buttons();
            if (mode.byContinents) CloseContinents();
            if ((mode.byFamily || mode.bySubfamily || mode.byGenus) == false) EnterRankMode();
            mode.ByGenus();
            picLeaf.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_leaf_inverted;
        }

        private void picGlobe_Click(object sender, EventArgs e)
        {
            if (mode.byContinents == false)
            {
                Text = "Harvex   -   MODE: CHECKLIST                          Database version: " + last_update;
                Absorb_Buttons();
                if (mode.byFamily || mode.bySubfamily || mode.byGenus) QuitRankMode();
                OpenContinents();
                picGlobe.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_world_inverted;
            }
        }

        private void btnClosePanCountries_Click(object sender, EventArgs e)
        {
            rtbPanCountries.Clear();
            panCountries.Visible = false;
            OpenContinents();
        }

        private void btnApplyYear_Click(object sender, EventArgs e)
        {
            try
            {
                int minY = int.Parse(txtMinYear.Text);
                int maxY = int.Parse(txtMaxYear.Text);
                if (minY > maxY || minY < MINYEAR || maxY > currentYear)
                    throw new Exception();
                minYear = minY;
                maxYear = maxY;
                GeneratePie();
            }
            catch
            {
                btnResetYear_Click(null, null);
                MessageBox.Show("Invalid year range\n(Must be " + MINYEAR + "-" + currentYear + ")");
                txtMinYear.Text = minYear.ToString();
                txtMaxYear.Text = maxYear.ToString();
            }
        }
        #endregion

        # region RADIO
        private void radioFamily_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFamily.Checked)
            {
                mode.genus = false;
                mode.subfamily = false;
                mode.family = true;
            }
            GeneratePie();
        }

        private void radioRealm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRealm.Checked)
            {
                mode.realm = true;
                mode.country = false;
            }
            GeneratePie();
        }

        private void radioCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCountry.Checked)
            {
                mode.realm = false;
                mode.country = true;
            }
            GeneratePie();
        }
        #endregion

        #region HOVER
        private void picHand_MouseEnter(object sender, EventArgs e)
        {
            if (mode.byRealm == false && mode.byCountry == false)
            {
                picHand.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_hand2;
            }
        }

        private void picLeaf_MouseEnter(object sender, EventArgs e)
        {
            if (mode.byGenus == false && mode.bySubfamily == false && mode.byFamily == false)
            {
                picLeaf.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_leaf2;
            }
        }

        private void picGlobe_MouseEnter(object sender, EventArgs e)
        {
            if (mode.byContinents == false)
            {
                picGlobe.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_world2;
            }
        }

        private void picHand_MouseLeave(object sender, EventArgs e)
        {
            if (mode.byRealm == false && mode.byCountry == false)
            {
                picHand.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_hand;
            }
        }

        private void picLeaf_MouseLeave(object sender, EventArgs e)
        {
            if (mode.byGenus == false && mode.bySubfamily == false && mode.byFamily == false)
            {
                picLeaf.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_leaf;
            }        
        }

        private void picGlobe_MouseLeave(object sender, EventArgs e)
        {
            if (mode.byContinents == false)
            {
                picGlobe.BackgroundImage = Eggpies.Properties.Resources.harvex_icon_world;
            }   
        }

        private void picNAM_MouseHover(object sender, EventArgs e)
        {
            picNAM.BackgroundImage = imgNAMsat;
        }

        private void picNAM_MouseLeave(object sender, EventArgs e)
        {
            picNAM.BackgroundImage = imgNAM;
        }

        private void picSAM_MouseHover(object sender, EventArgs e)
        {
            picSAM.BackgroundImage = imgSAMsat;
        }

        private void picSAM_MouseLeave(object sender, EventArgs e)
        {
            picSAM.BackgroundImage = imgSAM;
        }

        private void picEUR_MouseHover(object sender, EventArgs e)
        {
            picEUR.BackgroundImage = imgEURsat;
        }

        private void picEUR_MouseLeave(object sender, EventArgs e)
        {
            picEUR.BackgroundImage = imgEUR;
        }

        private void picAFR_MouseHover(object sender, EventArgs e)
        {
            picAFR.BackgroundImage = imgAFRsat;
        }

        private void picAFR_MouseLeave(object sender, EventArgs e)
        {
            picAFR.BackgroundImage = imgAFR;
        }

        private void picASI_MouseHover(object sender, EventArgs e)
        {
            picASI.BackgroundImage = imgASIsat;
        }

        private void picASI_MouseLeave(object sender, EventArgs e)
        {
            picASI.BackgroundImage = imgASI;
        }

        private void picOCE_MouseHover(object sender, EventArgs e)
        {
            picOCE.BackgroundImage = imgOCEsat;
        }

        private void picOCE_MouseLeave(object sender, EventArgs e)
        {
            picOCE.BackgroundImage = imgOCE;
        }

        private void picANT_MouseHover(object sender, EventArgs e)
        {
            picANT.BackgroundImage = imgANTsat;
        }

        private void picANT_MouseLeave(object sender, EventArgs e)
        {
            picANT.BackgroundImage = imgANT;
        }
        #endregion

        private void HideFlag()
        {
            labCountryName.Visible = false;
            picFlag.Visible = false;
        }

        private void HideFlagsPanCountries()
        {
            picFlagPanCountries.Visible = false;
            picLoc.Visible = false;
            picPhys.Visible = false;
            labCountryNamePanCountries.Visible = false;
        }

        private void checkEndemic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEndemic.Checked) mode.endemic = true;
            else mode.endemic = false;
            GeneratePie();
        }

        private void OpenCountries()
        {
            HideFlagsPanCountries();
            AddCountriesToCB_panCountries();
            panCountries.Size = uniSize;
            panCountries.Location = uniPoint;
            panCountries.Visible = true;
            panContinents.Visible = false;
            panCountries.BringToFront();
        }

        private void OpenContinents()
        {
            mode.ByContinents();
            PanContinents_Absorb_Buttons();
            panContinents.Size = uniSize;
            panContinents.Location = uniPoint;
            panContinents.Visible = true;
            panContinents.BringToFront();
        }
    }
}
