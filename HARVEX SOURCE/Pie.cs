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

namespace Eggpies
{
    public partial class Form1 : Form
    {
        private void GeneratePie()
        {
            occurrencesDesconto = 0;
            List<string> speciesListed = new List<string>();
            chosenElement = "";
            chosenCountry = 0;
            if (mode.byRealm) chosenElement = cbRealm.SelectedItem.ToString();
            else if (mode.byCountry)
            {
                chosenElement = cbCountry.SelectedItem.ToString();
                chosenCountry = countries.BinarySearch(chosenElement);
            }
            else if (mode.byGenus) chosenElement = cbGenus.SelectedItem.ToString();
            else if (mode.bySubfamily) chosenElement = cbSubfamily.SelectedItem.ToString();
            else if (mode.byFamily) chosenElement = cbFamily.SelectedItem.ToString();
            else chosenElement = cbAuthor.SelectedItem.ToString();
            int temp_list_size = 0;
            if (mode.byRealm || mode.byCountry || mode.byAuthor)
            {
                if (mode.genus) temp_list_size = genera.Count;
                else if (mode.family) temp_list_size = families.Count;
                else if (mode.subfamily) temp_list_size = subfamilies.Count;
            }
            else
            {
                if (mode.country) temp_list_size = countries.Count;
                else if (mode.realm) temp_list_size = realms.Count;
            }
            int[] speciesInGroup = new int[temp_list_size];
            int maxIndex = sp.Count;
            if (mode.byCountry) maxIndex = sp_in_country[chosenCountry].Count;
            for (int i = 0; i < maxIndex; i++)
            {
                Species cur_sp;
                if (mode.byCountry) cur_sp = sp[sp_in_country[chosenCountry][i]];
                else cur_sp = sp[i];
                string currentElement = "";
                if (cur_sp.year < minYear || cur_sp.year > maxYear) continue;
                if (mode.byAuthor == true && cbAuthor.Text != "All authors")
                {
                    if (cur_sp.author != cbAuthor.Text) continue;
                }
                int r_or_c_size = 1;
                if (mode.byRealm)
                {
                    if (mode.endemic) if (cur_sp.realm.Count > 1) continue;
                    r_or_c_size = cur_sp.realm.Count;
                }
                else if (mode.byCountry)
                {
                    if (mode.endemic) if (cur_sp.countries.Count > 1) continue;
                    r_or_c_size = cur_sp.countries.Count;
                }
                for (int j = 0; j < r_or_c_size; j++)
                {
                    if (mode.byRealm) currentElement = cur_sp.realm[j];
                    else if (mode.byCountry) currentElement = cur_sp.countries[j];
                    else if (mode.byGenus) currentElement = cur_sp.genus;
                    else if (mode.bySubfamily) currentElement = cur_sp.subfamily;
                    else if (mode.byFamily) currentElement = cur_sp.family;
                    else currentElement = cur_sp.author;
                    if (currentElement == chosenElement || chosenElement == "All authors")
                    {
                        int result = 0;
                        if (mode.byRealm || mode.byCountry || mode.byAuthor)
                        {
                            if (mode.genus) result = genera.BinarySearch(cur_sp.genus);
                            else if (mode.subfamily) result = subfamilies.BinarySearch(cur_sp.subfamily);
                            else if (mode.family) result = families.BinarySearch(cur_sp.family);
                            if (result >= 0) speciesInGroup[result]++;
                        }
                        else
                        {
                            if (mode.realm)
                            {
                                if (mode.endemic)
                                {
                                    if (cur_sp.realm.Count == 1)
                                    {
                                        result = realms.BinarySearch(cur_sp.realm[0]);
                                        if (result >= 0) speciesInGroup[result]++;
                                    }
                                }
                                else
                                {
                                    for (int k = 0; k < cur_sp.realm.Count; k++)
                                    {
                                        result = realms.BinarySearch(cur_sp.realm[k]);
                                        if (result >= 0)
                                        {
                                            if (speciesListed.Contains(cur_sp.epithet))
                                                occurrencesDesconto++;
                                            else speciesListed.Add(cur_sp.epithet);
                                            speciesInGroup[result]++;
                                        }
                                    }
                                }
                            }
                            else if (mode.country)
                            {
                                if (mode.endemic)
                                {
                                    if (cur_sp.realm.Count == 1)
                                    {
                                        result = countries.BinarySearch(cur_sp.countries[0]);
                                        if (result >= 0)
                                            speciesInGroup[result]++;
                                    }
                                }
                                else
                                {
                                    for (int k = 0; k < cur_sp.countries.Count; k++)
                                    {
                                        result = countries.BinarySearch(cur_sp.countries[k]);
                                        if (result >= 0)
                                        {
                                            if (speciesListed.Contains(cur_sp.epithet))
                                                occurrencesDesconto++;
                                            else speciesListed.Add(cur_sp.epithet);
                                            speciesInGroup[result]++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            ResetChart();
            UpdateTotal(speciesInGroup);
            for (int i = 0; i < speciesInGroup.Length; i++)
            {
                string groupName = "";
                if (mode.byRealm || mode.byCountry || mode.byAuthor)
                {
                    if (mode.genus) groupName = genera[i];
                    else if (mode.subfamily) groupName = subfamilies[i];
                    else if (mode.family) groupName = families[i];
                }
                else
                {
                    if (mode.realm) groupName = ShowCountryName(realms[i]);
                    else if (mode.country) groupName = ShowCountryName(countries[i]);
                }
                if (speciesInGroup[i] > minSP) Add(groupName, speciesInGroup[i]);
            }
            if (others > 0) Add("Others", others);
            if (mode.byRealm)
            {
                int index = GetRealmIndex(chosenElement);
                for (int i = startRC[index]; i < endRC[index]; i++)
                    if (NonEmpty[i]) cbCountry.Items.Add(RC[i]);
            }
        }
    }
}
