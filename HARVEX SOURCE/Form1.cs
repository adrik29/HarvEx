using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
/*
family
subfamily
genus
specificEpithet
WWF realm code
ISO 3166 country code
Author
year described
parentheses
valid status (taxonomic status)
fossil status
 */

namespace Eggpies
{
  public partial class Form1 : Form
  {
    #region Data
        public struct Species
        {
            public string genus, epithet, author, family, subfamily;
            public List<string> countries, realm;
            public int year;
      public bool parentheses;
      public void Print()
      {
        MessageBox.Show(family + " " + subfamily + " " + genus + " " + epithet
           + " " + author + " " + year.ToString() + " " + parentheses.ToString()
            + " " + countries[0] + " " + realm[0]);
      }
        }
        Mode mode;
        Size uniSize = new Size(1510, 699);
        Point uniPoint = new Point(0, 0);
        string chosenElement; // See Generate Pie
        string last_update;
        int chosenCountry, occurrencesDesconto;
        string[] Realms = { "AA", "AN", "AT", "IM", "NA", "NT", "OC", "PA" };
        int currentYear, minYear, maxYear, minSP; // Inicializados no load
        int total = 0, col, others = 0;
        const int linesPerCol = 11, SIZE = 7000, MINYEAR = 1758;
        List<Species> sp = new List<Species>();
        List<string> genera = new List<string>();
        List<string> authors = new List<string>();
        int[] sp_parents;
        int[] genera_parents;
        int[] genera_grandparents;
        int[] sub_parents;
        List<int>[] sp_in_country;
        List<int>[] families_in_country;
        List<int>[] species_in_family;
        List<int>[] authors_in_country;
        List<int>[] authors_in_realm;
        List<string> subfamilies = new List<string>();
        List<string> families = new List<string>();
        List<string> realms = new List<string>();
        List<string> countries = new List<string>();
        List<int> largestLegends = new List<int>();
        string[] RC;
        // Indices das listas de cada realm pra serem usados dentro de RC:
        int[] startRC = new int[8];
        int[] endRC = new int[8];
        bool[] NonEmpty = new bool[300];
        int chosen_continent;
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

    private int GetRealmIndex(string key)
    {
        for (int i = 0; i < 8; i++)
            if (Realms[i] == key) return i;
        return 0;
    }

    private int GetCountryIndex(string key)
    {
      for (int i = 0; i < 8; i++)
      {
        for (int j = startRC[i]; j < endRC[i]; j++)
        {
            if (key == RC[j]) return j;
        }
      }
      return -1;
    }

    private void Add(string ss, int y)
    {
      string s = "";
      double porc = (100.0 * y) / total;
      if (porc > 4.0 && porc <= 16.0) s = "" + ss[0] + ss[1] + ss[2];
      else if (porc > 16.0) s = ss;
      System.Windows.Forms.DataVisualization.Charting.DataPoint item = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, y);
      int index = largestLegends.BinarySearch(y);
      if (index >= 0)
      {
          item.IsVisibleInLegend = true;
          item.LegendText = ss + " " + y.ToString();
          largestLegends.RemoveAt(index);
      }
      else item.IsVisibleInLegend = false;
      item.Label = s;
      pie.Series["s1"].Points.Add(item);
    }

    List<string> Decode (string s)
    {
      List<string> result = new List<string>();
      string[] sub = s.Split(',', '/');
      for (int i = 0; i < sub.Length; i++)
          sub[i] = RemoveWhitespace(sub[i]);
      for (int i = 0; i < sub.Length; i++) result.Add(sub[i]);
      return result;
    }

    private bool NotAvailable(string s)
    {
      return (s == "NA, U" || s == "NA,U" || s == "NA");
    }

    private void Absorb_Buttons()
    {
      if (panModes.Visible == true || mode.byContinents)
      {
        panModes.Visible = false;
        Controls.Add(picHand);
        Controls.Add(picLeaf);
        Controls.Add(picGlobe);
        picHand.Size = picLeaf.Size = picGlobe.Size = new Size(65, 65);
        picHand.Location = new Point(14, 15);
        picLeaf.Location = new Point(84, 15);
        picGlobe.Location = new Point(49, 85);
      }
      Reset_Pics_Modes_Color();
    }

    private void PanContinents_Absorb_Buttons()
    {
      panModes.Visible = false;
      panContinents.Controls.Add(picHand);
      panContinents.Controls.Add(picLeaf);
      panContinents.Controls.Add(picGlobe);
      picHand.Size = picLeaf.Size = picGlobe.Size = new Size(90, 90);
      picHand.Location = new Point(130, 90);
      picLeaf.Location = new Point(230, 90);
      picGlobe.Location = new Point(180, 182);
    }

    private void CloseContinents()
    {
      panContinents.Visible = false;
    }

    private void EnterRankMode()
    {
      ResetChart();
      HideFlag();
      cbCountry.SelectedItem = null;
      cbRealm.SelectedItem = null;
      cbCountry.Text = "";
      cbRealm.Text = "";
      mode.byAuthor = false;
      panGroupMode.Visible = true;
      radioGenus.Visible = false;
      radioSubfamily.Visible = false;
      radioFamily.Visible = false;
      checkEndemic.Visible = false;
      labFamAndSub.Location = new Point(labCountryName.Location.X, labCountryName.Location.Y);
      labFamAndSub.Visible = true;
      panGroupMode.BringToFront();
    }

    private void QuitRankMode()
    {
      ResetChart();
      radioRealm.Visible = false;
      radioCountry.Visible = false;
      checkEndemic.Visible = false;
      panGroupMode.Visible = false;
      cbGenus.SelectedItem = null;
      cbFamily.SelectedItem = null;
      cbSubfamily.SelectedItem = null;
      cbGenus.Text = "";
      cbFamily.Text = "";
      cbSubfamily.Text = "";
      if (mode.country) mode.ByCountry();
      else if (mode.realm) mode.ByRealm();
      labFamAndSub.Visible = false;
    }

    private void ResetChart()
    {
      pie.Series["s1"].Points.Clear();
    }

    private void btnResetYear_Click(object sender, EventArgs e)
    {
      txtMaxYear.Clear();
      txtMinYear.Clear();
      minYear = MINYEAR;
      maxYear = currentYear;
      GeneratePie();
    }

    private void sliderSpecies_Scroll(object sender, EventArgs e)
    {
      minSP = sliderSpecies.Value;
      labSliderSpecies.Text = "Showing sp > " + minSP;
      GeneratePie();
    }

    public static string RemoveWhitespace(string s)
    {
      return new string(s.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
    }

    private void Reset_Continent_Pics()
    {
      picAFR.BackgroundImage = imgAFR;
      picANT.BackgroundImage = imgANT;
      picASI.BackgroundImage = imgASI;
      picEUR.BackgroundImage = imgEUR;
      picNAM.BackgroundImage = imgNAM;
      picOCE.BackgroundImage = imgOCE;
      picSAM.BackgroundImage = imgSAM;
      picAFR.BackColor = Color.Linen;
      picANT.BackColor = Color.Linen;
      picASI.BackColor = Color.Linen;
      picEUR.BackColor = Color.Linen;
      picNAM.BackColor = Color.Linen;
      picOCE.BackColor = Color.Linen;
      picSAM.BackColor = Color.Linen;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      last_update = "";
      int flag;
      HttpWebRequest request = null;
      HttpWebResponse response = null;
      try
      {
        request = (HttpWebRequest)HttpWebRequest.Create("https://dl.dropboxusercontent.com/s/jcdu8fcu6cma387/input.txt");
        request.Timeout = 30000;
        response = (System.Net.HttpWebResponse)request.GetResponse();
        using (WebClient myWebClient = new WebClient())
        {
          myWebClient.DownloadFile("https://dl.dropboxusercontent.com/s/jcdu8fcu6cma387/input.txt", "input.txt");
        }
        flag = 1;
      }
      catch
      {
        flag = -1;
      }
      if (flag == 1)
      {
        MessageBox.Show("Successfully updated!");
        last_update = " (latest)";
      }
      else
      {
        MessageBox.Show("Failed to update", "C'est la vie:");
      }
      Reset_Continent_Pics();
      panModes.Size = uniSize;
      panModes.Location = uniPoint;
      mode = new Mode();
      DateTime now = DateTime.Now;
      currentYear = now.Year;
      minYear = MINYEAR;
      maxYear = currentYear;
      minSP = 0;
      labFamAndSub.Text = "";
      checkEndemic.Text = "Show only\r\nendemic species";
      InitializeRealmCountries();
      StreamReader reader = new StreamReader(@"input.txt", Encoding.Default);
      last_update = reader.ReadLine();
      Text = "Harvex                                                Database version: " + last_update;
      Species current = new Species();
      int resto;
      string[] lines;
      string line;
      for (int i = 1; true; i++)
      {
        try
        {
          resto = i % linesPerCol;
          line = reader.ReadLine();
          if (line == null)
            break;
          lines = line.Split('\t');
          string g = "";
          foreach (string lh in lines)
            g += lh + "\n";

          if (lines[9][0] == 'i' || lines[9][0] == 'I')
            continue; // invalid
          if (lines[10][0] == 'f' || lines[10][0] == 'F')
            continue; // fossil

          // 0 - family
          current.family = RemoveWhitespace(lines[0]);
          if (families.Contains(current.family) == false)
            families.Add(current.family);

          // 1 - subfamily
          current.subfamily = RemoveWhitespace(lines[1]);
          if (subfamilies.Contains(current.subfamily) == false)
              subfamilies.Add(current.subfamily);

          // 2 - genus
          current.genus = RemoveWhitespace(lines[2]);
          if (genera.Contains(current.genus) == false)
            genera.Add(current.genus);

          // 3 - epithet
          current.epithet = RemoveWhitespace(lines[3]);

          // 4 - realm
          current.realm = Decode(lines[4]);
          for (int j = 0; j < current.realm.Count; j++)
            if (realms.Contains(current.realm[j]) == false)
              realms.Add(current.realm[j]);

          // 5 - countries
          current.countries = Decode(lines[5]);
          for (int j = 0; j < current.countries.Count; j++)
            if (countries.Contains(current.countries[j]) == false)
              countries.Add(current.countries[j]);

          // 6 - author
          current.author = lines[6];
          if (authors.Contains(current.author) == false)
            authors.Add(current.author);

          // 7 - year
          current.year = int.Parse(lines[7]);

          // 8 - parentheses
          current.parentheses = ((lines[8][0] == 't') ? true : false);

          // 9 & 10 - valid / invalid , fossil / non-fossil : treated before 0

          sp.Add(current);
          current = new Species();
        }
        catch
        {
          MessageBox.Show("Line " + i.ToString() + " is bugged.");
          break;
        }
      }
      reader.Close();

      genera.Sort();
      authors.Sort();
      families.Sort();
      subfamilies.Sort();
      countries.Sort();
      realms.Sort();

      sp_parents = new int[sp.Count];
      genera_parents = new int[genera.Count];
      genera_grandparents = new int[genera.Count];
      sub_parents = new int[subfamilies.Count];
      sp_in_country = new List<int>[countries.Count];
      families_in_country = new List<int>[countries.Count];
      species_in_family = new List<int>[families.Count];
      authors_in_country = new List<int>[countries.Count];
      authors_in_realm = new List<int>[realms.Count];
      for (int i = 0; i < countries.Count; i++)
      {
        sp_in_country[i] = new List<int>();
        families_in_country[i] = new List<int>();
        authors_in_country[i] = new List<int>();
      }
      for (int i = 0; i < families.Count; i++)
        species_in_family[i] = new List<int>();
      for (int i = 0; i < realms.Count; i++)
        authors_in_realm[i] = new List<int>();

      for (int i = 0; i < sp.Count; i++)
      {
        int authorIndex = authors.BinarySearch(sp[i].author);
        int genusIndex = genera.BinarySearch(sp[i].genus);
        int subIndex = subfamilies.BinarySearch(sp[i].subfamily);
        int famIndex = families.BinarySearch(sp[i].family);
        sp_parents[i] = genusIndex;
        if (genusIndex >= 0)
        {
            if (NotAvailable(sp[i].subfamily)) genera_parents[genusIndex] = -1;
            else genera_parents[genusIndex] = subIndex;
            if (NotAvailable(sp[i].family)) genera_grandparents[genusIndex] = -1;
            else genera_grandparents[genusIndex] = famIndex;
        }
        if (subIndex >= 0)
        {
            if (NotAvailable(sp[i].family)) sub_parents[subIndex] = -1;
            else sub_parents[subIndex] = famIndex;
        }
        if (famIndex >= 0 && species_in_family[famIndex].Contains(i) == false)
            species_in_family[famIndex].Add(i);
        for (int j = 0; j < sp[i].countries.Count; j++)
        {
            int countryIndex = countries.BinarySearch(sp[i].countries[j]);
            sp_in_country[countryIndex].Add(i);
            if (families_in_country[countryIndex].Contains(famIndex) == false)
                families_in_country[countryIndex].Add(famIndex);
            if (authors_in_country[countryIndex].Contains(authorIndex) == false)
                authors_in_country[countryIndex].Add(authorIndex);
        }
        for (int j = 0; j < sp[i].realm.Count; j++)
        {
          int realmIndex = realms.BinarySearch(sp[i].realm[j]);
          if (authors_in_realm[realmIndex].Contains(authorIndex) == false)
            authors_in_realm[realmIndex].Add(authorIndex);
        }
      }
      for (int i = 0; i < countries.Count; i++)
      {
        families_in_country[i].Sort();
        authors_in_country[i].Sort();
      }
      for (int i = 0; i < realms.Count; i++)
        authors_in_realm[i].Sort();

      cbRealm.Items.Add("ALL");
      for (int i = 0; i < Realms.Length; i++)
       cbRealm.Items.Add(Realms[i]);
      for (int i = 0; i < genera.Count; i++)
        cbGenus.Items.Add(genera[i]);
      for (int i = 0; i < families.Count; i++)
        cbFamily.Items.Add(families[i]);
      for (int i = 0; i < subfamilies.Count; i++)
        cbSubfamily.Items.Add(subfamilies[i]);

      for (int i = 0; i < sp.Count; i++)
      {
        for (int j = 0; j < sp[i].countries.Count; j++)
        {
          int temp = GetCountryIndex(sp[i].countries[j]);
          if (temp >= 0)
            NonEmpty[temp] = true;
        }
      }

      cbRealm.SelectedItem = "ALL";
      cbAuthor.SelectedItem = "All authors";
      radioGenus.Checked = false;
      radioFamily.Checked = true;
    }
  }
}
