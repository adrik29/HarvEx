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
        private void txtDebugIndex_TextChanged(object sender, EventArgs e)
        {
            if (txtDebugIndex.Text == "") return;
            try
            {
                int i = int.Parse(txtDebugIndex.Text);
                rtbDebug.Clear();
                rtbDebug.Text += "Object number " + i + "\n";
                rtbDebug.Text += "Genus: " + sp[i].genus + "\n";
                rtbDebug.Text += "Epithet: " + sp[i].epithet + "\n";
                rtbDebug.Text += "Author: " + sp[i].author + "\n";
                rtbDebug.Text += "Year: " + sp[i].year.ToString() + "\n";
                rtbDebug.Text += "Realms: ";
                for (int j = 0; j < sp[i].realm.Count; j++)
                {
                    rtbDebug.Text += sp[i].realm[j];
                    if (j < sp[i].realm.Count - 1) rtbDebug.Text += ", ";
                }
                rtbDebug.Text += "\nCountries: ";
                for (int j = 0; j < sp[i].countries.Count; j++)
                {
                    rtbDebug.Text += ">>" + sp[i].countries[j] + "<<";
                    if (j < sp[i].countries.Count - 1) rtbDebug.Text += ", ";
                }
                rtbDebug.Text += "\n";
            }
            catch
            {
                rtbDebug.Clear();
                txtDebugIndex.Clear();
                MessageBox.Show("Wrong input");
            }
        }

        private void btnCloseDebugPanel_Click(object sender, EventArgs e)
        {
            panDebug.Visible = false;
            picFlag.Visible = true;
            labCountryName.Visible = true;
        }

        private void btnSearchDebug_Click(object sender, EventArgs e)
        {
            rtbDebug.Clear();
            int count = 0;
            string s = "", key = txtDebugSearch.Text;
            if (cb1Debug.SelectedItem == "Author")
            {
                for (int i = 0; i < sp.Count(); i++)
                {
                    if (sp[i].author.Contains(key))
                    {
                        count++;
                        s += "Object number: " + i + ". Object epithet: ";
                        s += sp[i].epithet + "\n";
                    }
                }
            }
            else if (cb1Debug.SelectedItem == "Year")
            {
                try
                {
                    int yy = int.Parse(key);
                    for (int i = 0; i < sp.Count(); i++)
                    {
                        if (sp[i].year == yy)
                        {
                            count++;
                            s += "Object number: " + i + ". Object epithet: ";
                            s += sp[i].epithet + "\n";
                        }
                    }
                }
                catch { }
            }
            else if (cb1Debug.SelectedItem == "Genus")
            {
                for (int i = 0; i < sp.Count(); i++)
                {
                    if (sp[i].genus == key)
                    {
                        count++;
                        s += "Object number: " + i + ". Object epithet: ";
                        s += sp[i].epithet + "\n";
                    }
                }
            }
            else if (cb1Debug.SelectedItem == "Realm")
            {
                for (int i = 0; i < sp.Count(); i++)
                {
                    for (int j = 0; j < sp[i].realm.Count; j++)
                    {
                        if (sp[i].realm[j] == key)
                        {
                            count++;
                            s += "Object number: " + i + ". Object epithet: ";
                            s += sp[i].epithet + "\n";
                            break;
                        }
                    }

                }
            }
            else if (cb1Debug.SelectedItem == "Country")
            {
                for (int i = 0; i < sp.Count(); i++)
                {
                    for (int j = 0; j < sp[i].countries.Count; j++)
                    {
                        if (sp[i].countries[j] == key)
                        {
                            count++;
                            s += "Object number: " + i + ". Object epithet: ";
                            s += sp[i].epithet + "\n";
                            break;
                        }
                    }
                }
            }
            if (count > 0)
            {
                rtbDebug.Text = "Number of objects found: " + count + "\n";
                rtbDebug.Text += s;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
 }
