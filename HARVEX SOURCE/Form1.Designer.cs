namespace Eggpies
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cbRealm = new System.Windows.Forms.ComboBox();
			this.labRealmCB = new System.Windows.Forms.Label();
			this.labCountryCB = new System.Windows.Forms.Label();
			this.cbCountry = new System.Windows.Forms.ComboBox();
			this.labTotalSp = new System.Windows.Forms.Label();
			this.sliderSpecies = new System.Windows.Forms.TrackBar();
			this.txtMinYear = new System.Windows.Forms.TextBox();
			this.labFromYear = new System.Windows.Forms.Label();
			this.txtMaxYear = new System.Windows.Forms.TextBox();
			this.btnApplyYear = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnResetYear = new System.Windows.Forms.Button();
			this.labSliderSpecies = new System.Windows.Forms.Label();
			this.labAuthorCB = new System.Windows.Forms.Label();
			this.cbAuthor = new System.Windows.Forms.ComboBox();
			this.panDebug = new System.Windows.Forms.Panel();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnSearchDebug = new System.Windows.Forms.Button();
			this.cb1Debug = new System.Windows.Forms.ComboBox();
			this.txtDebugSearch = new System.Windows.Forms.TextBox();
			this.btnCloseDebugPanel = new System.Windows.Forms.Button();
			this.rtbDebug = new System.Windows.Forms.RichTextBox();
			this.txtDebugIndex = new System.Windows.Forms.TextBox();
			this.labDebugMode = new System.Windows.Forms.Label();
			this.labCountryName = new System.Windows.Forms.Label();
			this.radioGenus = new System.Windows.Forms.RadioButton();
			this.radioSubfamily = new System.Windows.Forms.RadioButton();
			this.radioFamily = new System.Windows.Forms.RadioButton();
			this.cbGenus = new System.Windows.Forms.ComboBox();
			this.labGenusCB = new System.Windows.Forms.Label();
			this.cbSubfamily = new System.Windows.Forms.ComboBox();
			this.labSubfamilyCB = new System.Windows.Forms.Label();
			this.cbFamily = new System.Windows.Forms.ComboBox();
			this.labFamilyCB = new System.Windows.Forms.Label();
			this.panGroupMode = new System.Windows.Forms.Panel();
			this.radioCountry = new System.Windows.Forms.RadioButton();
			this.radioRealm = new System.Windows.Forms.RadioButton();
			this.checkEndemic = new System.Windows.Forms.CheckBox();
			this.labFamAndSub = new System.Windows.Forms.Label();
			this.panContinents = new System.Windows.Forms.Panel();
			this.picANT = new System.Windows.Forms.PictureBox();
			this.picOCE = new System.Windows.Forms.PictureBox();
			this.picASI = new System.Windows.Forms.PictureBox();
			this.picAFR = new System.Windows.Forms.PictureBox();
			this.picEUR = new System.Windows.Forms.PictureBox();
			this.picSAM = new System.Windows.Forms.PictureBox();
			this.picNAM = new System.Windows.Forms.PictureBox();
			this.panCountries = new System.Windows.Forms.Panel();
			this.rtbPanCountries = new System.Windows.Forms.RichTextBox();
			this.picPhys = new System.Windows.Forms.PictureBox();
			this.picLoc = new System.Windows.Forms.PictureBox();
			this.labCountryNamePanCountries = new System.Windows.Forms.Label();
			this.picFlagPanCountries = new System.Windows.Forms.PictureBox();
			this.cbCountriesPanCountries = new System.Windows.Forms.ComboBox();
			this.btnClosePanCountries = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.picHand = new System.Windows.Forms.PictureBox();
			this.picFlag = new System.Windows.Forms.PictureBox();
			this.panModes = new System.Windows.Forms.Panel();
			this.picGlobe = new System.Windows.Forms.PictureBox();
			this.picLeaf = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sliderSpecies)).BeginInit();
			this.panel1.SuspendLayout();
			this.panDebug.SuspendLayout();
			this.panGroupMode.SuspendLayout();
			this.panContinents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picANT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picOCE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picASI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAFR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picEUR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSAM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNAM)).BeginInit();
			this.panCountries.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPhys)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFlagPanCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picHand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
			this.panModes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picGlobe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeaf)).BeginInit();
			this.SuspendLayout();
			// 
			// pie
			// 
			this.pie.BackColor = System.Drawing.Color.Linen;
			chartArea3.BackColor = System.Drawing.Color.Linen;
			chartArea3.Name = "ChartArea1";
			this.pie.ChartAreas.Add(chartArea3);
			legend3.AutoFitMinFontSize = 12;
			legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			legend3.IsTextAutoFit = false;
			legend3.Name = "Legend1";
			this.pie.Legends.Add(legend3);
			this.pie.Location = new System.Drawing.Point(162, 12);
			this.pie.Name = "pie";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			series3.Legend = "Legend1";
			series3.Name = "s1";
			series3.SmartLabelStyle.MaxMovingDistance = 100D;
			this.pie.Series.Add(series3);
			this.pie.Size = new System.Drawing.Size(1336, 675);
			this.pie.TabIndex = 0;
			this.pie.Text = "chart1";
			// 
			// cbRealm
			// 
			this.cbRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRealm.FormattingEnabled = true;
			this.cbRealm.Location = new System.Drawing.Point(29, 243);
			this.cbRealm.Name = "cbRealm";
			this.cbRealm.Size = new System.Drawing.Size(98, 28);
			this.cbRealm.TabIndex = 1;
			this.cbRealm.SelectedIndexChanged += new System.EventHandler(this.cbRealm_SelectedIndexChanged);
			// 
			// labRealmCB
			// 
			this.labRealmCB.AutoSize = true;
			this.labRealmCB.BackColor = System.Drawing.Color.Black;
			this.labRealmCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labRealmCB.ForeColor = System.Drawing.Color.White;
			this.labRealmCB.Location = new System.Drawing.Point(29, 218);
			this.labRealmCB.Name = "labRealmCB";
			this.labRealmCB.Size = new System.Drawing.Size(102, 24);
			this.labRealmCB.TabIndex = 2;
			this.labRealmCB.Text = "Pick realm:";
			// 
			// labCountryCB
			// 
			this.labCountryCB.AutoSize = true;
			this.labCountryCB.BackColor = System.Drawing.Color.Black;
			this.labCountryCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCountryCB.ForeColor = System.Drawing.Color.White;
			this.labCountryCB.Location = new System.Drawing.Point(23, 274);
			this.labCountryCB.Name = "labCountryCB";
			this.labCountryCB.Size = new System.Drawing.Size(117, 24);
			this.labCountryCB.TabIndex = 3;
			this.labCountryCB.Text = "Pick country:";
			// 
			// cbCountry
			// 
			this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCountry.FormattingEnabled = true;
			this.cbCountry.Location = new System.Drawing.Point(29, 299);
			this.cbCountry.Name = "cbCountry";
			this.cbCountry.Size = new System.Drawing.Size(98, 28);
			this.cbCountry.TabIndex = 4;
			this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
			// 
			// labTotalSp
			// 
			this.labTotalSp.AutoSize = true;
			this.labTotalSp.BackColor = System.Drawing.Color.Linen;
			this.labTotalSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTotalSp.ForeColor = System.Drawing.Color.Black;
			this.labTotalSp.Location = new System.Drawing.Point(163, 544);
			this.labTotalSp.Name = "labTotalSp";
			this.labTotalSp.Size = new System.Drawing.Size(126, 24);
			this.labTotalSp.TabIndex = 5;
			this.labTotalSp.Text = "Total species:";
			// 
			// sliderSpecies
			// 
			this.sliderSpecies.BackColor = System.Drawing.Color.Linen;
			this.sliderSpecies.Location = new System.Drawing.Point(162, 642);
			this.sliderSpecies.Maximum = 50;
			this.sliderSpecies.Name = "sliderSpecies";
			this.sliderSpecies.Size = new System.Drawing.Size(277, 45);
			this.sliderSpecies.TabIndex = 6;
			this.sliderSpecies.Scroll += new System.EventHandler(this.sliderSpecies_Scroll);
			// 
			// txtMinYear
			// 
			this.txtMinYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMinYear.Location = new System.Drawing.Point(6, 34);
			this.txtMinYear.Name = "txtMinYear";
			this.txtMinYear.Size = new System.Drawing.Size(60, 29);
			this.txtMinYear.TabIndex = 7;
			// 
			// labFromYear
			// 
			this.labFromYear.AutoSize = true;
			this.labFromYear.BackColor = System.Drawing.Color.DarkSlateGray;
			this.labFromYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFromYear.ForeColor = System.Drawing.Color.White;
			this.labFromYear.Location = new System.Drawing.Point(12, 3);
			this.labFromYear.Name = "labFromYear";
			this.labFromYear.Size = new System.Drawing.Size(124, 24);
			this.labFromYear.TabIndex = 8;
			this.labFromYear.Text = "Year (from-to)";
			// 
			// txtMaxYear
			// 
			this.txtMaxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaxYear.Location = new System.Drawing.Point(74, 34);
			this.txtMaxYear.Name = "txtMaxYear";
			this.txtMaxYear.Size = new System.Drawing.Size(60, 29);
			this.txtMaxYear.TabIndex = 9;
			// 
			// btnApplyYear
			// 
			this.btnApplyYear.Location = new System.Drawing.Point(22, 69);
			this.btnApplyYear.Name = "btnApplyYear";
			this.btnApplyYear.Size = new System.Drawing.Size(99, 33);
			this.btnApplyYear.TabIndex = 11;
			this.btnApplyYear.Text = "Make me happy";
			this.btnApplyYear.UseVisualStyleBackColor = true;
			this.btnApplyYear.Click += new System.EventHandler(this.btnApplyYear_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.Controls.Add(this.btnResetYear);
			this.panel1.Controls.Add(this.labFromYear);
			this.panel1.Controls.Add(this.btnApplyYear);
			this.panel1.Controls.Add(this.txtMinYear);
			this.panel1.Controls.Add(this.txtMaxYear);
			this.panel1.Location = new System.Drawing.Point(9, 486);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(144, 154);
			this.panel1.TabIndex = 12;
			// 
			// btnResetYear
			// 
			this.btnResetYear.Location = new System.Drawing.Point(21, 108);
			this.btnResetYear.Name = "btnResetYear";
			this.btnResetYear.Size = new System.Drawing.Size(99, 33);
			this.btnResetYear.TabIndex = 12;
			this.btnResetYear.Text = "Reset";
			this.btnResetYear.UseVisualStyleBackColor = true;
			this.btnResetYear.Click += new System.EventHandler(this.btnResetYear_Click);
			// 
			// labSliderSpecies
			// 
			this.labSliderSpecies.AutoSize = true;
			this.labSliderSpecies.BackColor = System.Drawing.Color.Linen;
			this.labSliderSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSliderSpecies.ForeColor = System.Drawing.Color.Black;
			this.labSliderSpecies.Location = new System.Drawing.Point(164, 611);
			this.labSliderSpecies.Name = "labSliderSpecies";
			this.labSliderSpecies.Size = new System.Drawing.Size(140, 24);
			this.labSliderSpecies.TabIndex = 13;
			this.labSliderSpecies.Text = "Showing sp > 0";
			// 
			// labAuthorCB
			// 
			this.labAuthorCB.AutoSize = true;
			this.labAuthorCB.BackColor = System.Drawing.Color.Black;
			this.labAuthorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAuthorCB.ForeColor = System.Drawing.Color.White;
			this.labAuthorCB.Location = new System.Drawing.Point(27, 164);
			this.labAuthorCB.Name = "labAuthorCB";
			this.labAuthorCB.Size = new System.Drawing.Size(108, 24);
			this.labAuthorCB.TabIndex = 14;
			this.labAuthorCB.Text = "Pick author:";
			// 
			// cbAuthor
			// 
			this.cbAuthor.DropDownWidth = 700;
			this.cbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAuthor.FormattingEnabled = true;
			this.cbAuthor.Location = new System.Drawing.Point(29, 189);
			this.cbAuthor.Name = "cbAuthor";
			this.cbAuthor.Size = new System.Drawing.Size(98, 28);
			this.cbAuthor.TabIndex = 15;
			this.cbAuthor.SelectedIndexChanged += new System.EventHandler(this.cbAuthor_SelectedIndexChanged);
			// 
			// panDebug
			// 
			this.panDebug.Controls.Add(this.btnTest);
			this.panDebug.Controls.Add(this.btnSearchDebug);
			this.panDebug.Controls.Add(this.cb1Debug);
			this.panDebug.Controls.Add(this.txtDebugSearch);
			this.panDebug.Controls.Add(this.btnCloseDebugPanel);
			this.panDebug.Controls.Add(this.rtbDebug);
			this.panDebug.Controls.Add(this.txtDebugIndex);
			this.panDebug.Controls.Add(this.labDebugMode);
			this.panDebug.Location = new System.Drawing.Point(1468, 0);
			this.panDebug.Name = "panDebug";
			this.panDebug.Size = new System.Drawing.Size(42, 699);
			this.panDebug.TabIndex = 16;
			this.panDebug.Visible = false;
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(1280, 53);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(99, 41);
			this.btnTest.TabIndex = 16;
			this.btnTest.Text = "TEST";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnSearchDebug
			// 
			this.btnSearchDebug.Location = new System.Drawing.Point(1174, 53);
			this.btnSearchDebug.Name = "btnSearchDebug";
			this.btnSearchDebug.Size = new System.Drawing.Size(99, 41);
			this.btnSearchDebug.TabIndex = 15;
			this.btnSearchDebug.Text = "Make me happy";
			this.btnSearchDebug.UseVisualStyleBackColor = true;
			this.btnSearchDebug.Click += new System.EventHandler(this.btnSearchDebug_Click);
			// 
			// cb1Debug
			// 
			this.cb1Debug.AutoCompleteCustomSource.AddRange(new string[] {
            "Year",
            "Author",
            "Realm",
            "Country",
            "Genus"});
			this.cb1Debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb1Debug.FormattingEnabled = true;
			this.cb1Debug.Items.AddRange(new object[] {
            "Realm",
            "Country",
            "Author",
            "Year",
            "Genus"});
			this.cb1Debug.Location = new System.Drawing.Point(980, 63);
			this.cb1Debug.Name = "cb1Debug";
			this.cb1Debug.Size = new System.Drawing.Size(171, 28);
			this.cb1Debug.TabIndex = 14;
			// 
			// txtDebugSearch
			// 
			this.txtDebugSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDebugSearch.Location = new System.Drawing.Point(192, 63);
			this.txtDebugSearch.Name = "txtDebugSearch";
			this.txtDebugSearch.Size = new System.Drawing.Size(759, 31);
			this.txtDebugSearch.TabIndex = 13;
			// 
			// btnCloseDebugPanel
			// 
			this.btnCloseDebugPanel.Location = new System.Drawing.Point(1385, 53);
			this.btnCloseDebugPanel.Name = "btnCloseDebugPanel";
			this.btnCloseDebugPanel.Size = new System.Drawing.Size(99, 41);
			this.btnCloseDebugPanel.TabIndex = 12;
			this.btnCloseDebugPanel.Text = "Quit Debug Mode";
			this.btnCloseDebugPanel.UseVisualStyleBackColor = true;
			this.btnCloseDebugPanel.Click += new System.EventHandler(this.btnCloseDebugPanel_Click);
			// 
			// rtbDebug
			// 
			this.rtbDebug.BackColor = System.Drawing.Color.MediumAquamarine;
			this.rtbDebug.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbDebug.Location = new System.Drawing.Point(27, 105);
			this.rtbDebug.Name = "rtbDebug";
			this.rtbDebug.ReadOnly = true;
			this.rtbDebug.Size = new System.Drawing.Size(1457, 562);
			this.rtbDebug.TabIndex = 5;
			this.rtbDebug.Text = "";
			// 
			// txtDebugIndex
			// 
			this.txtDebugIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDebugIndex.Location = new System.Drawing.Point(28, 63);
			this.txtDebugIndex.Name = "txtDebugIndex";
			this.txtDebugIndex.Size = new System.Drawing.Size(115, 31);
			this.txtDebugIndex.TabIndex = 4;
			this.txtDebugIndex.TextChanged += new System.EventHandler(this.txtDebugIndex_TextChanged);
			// 
			// labDebugMode
			// 
			this.labDebugMode.AutoSize = true;
			this.labDebugMode.BackColor = System.Drawing.Color.Black;
			this.labDebugMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDebugMode.ForeColor = System.Drawing.Color.White;
			this.labDebugMode.Location = new System.Drawing.Point(697, 31);
			this.labDebugMode.Name = "labDebugMode";
			this.labDebugMode.Size = new System.Drawing.Size(121, 24);
			this.labDebugMode.TabIndex = 3;
			this.labDebugMode.Text = "Debug Mode";
			// 
			// labCountryName
			// 
			this.labCountryName.AutoSize = true;
			this.labCountryName.BackColor = System.Drawing.Color.Linen;
			this.labCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCountryName.ForeColor = System.Drawing.Color.Black;
			this.labCountryName.Location = new System.Drawing.Point(165, 21);
			this.labCountryName.Name = "labCountryName";
			this.labCountryName.Size = new System.Drawing.Size(149, 25);
			this.labCountryName.TabIndex = 18;
			this.labCountryName.Text = "Country Name";
			this.labCountryName.Visible = false;
			// 
			// radioGenus
			// 
			this.radioGenus.AutoSize = true;
			this.radioGenus.Checked = true;
			this.radioGenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioGenus.ForeColor = System.Drawing.Color.White;
			this.radioGenus.Location = new System.Drawing.Point(30, 332);
			this.radioGenus.Name = "radioGenus";
			this.radioGenus.Size = new System.Drawing.Size(84, 28);
			this.radioGenus.TabIndex = 19;
			this.radioGenus.TabStop = true;
			this.radioGenus.Text = "Genus";
			this.radioGenus.UseVisualStyleBackColor = true;
			this.radioGenus.Visible = false;
			this.radioGenus.CheckedChanged += new System.EventHandler(this.radioGenus_CheckedChanged);
			// 
			// radioSubfamily
			// 
			this.radioSubfamily.AutoSize = true;
			this.radioSubfamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioSubfamily.ForeColor = System.Drawing.Color.White;
			this.radioSubfamily.Location = new System.Drawing.Point(29, 366);
			this.radioSubfamily.Name = "radioSubfamily";
			this.radioSubfamily.Size = new System.Drawing.Size(109, 28);
			this.radioSubfamily.TabIndex = 20;
			this.radioSubfamily.Text = "Subfamily";
			this.radioSubfamily.UseVisualStyleBackColor = true;
			this.radioSubfamily.Visible = false;
			this.radioSubfamily.CheckedChanged += new System.EventHandler(this.radioSubfamily_CheckedChanged);
			// 
			// radioFamily
			// 
			this.radioFamily.AutoSize = true;
			this.radioFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioFamily.ForeColor = System.Drawing.Color.White;
			this.radioFamily.Location = new System.Drawing.Point(28, 400);
			this.radioFamily.Name = "radioFamily";
			this.radioFamily.Size = new System.Drawing.Size(83, 28);
			this.radioFamily.TabIndex = 21;
			this.radioFamily.Text = "Family";
			this.radioFamily.UseVisualStyleBackColor = true;
			this.radioFamily.Visible = false;
			this.radioFamily.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
			// 
			// cbGenus
			// 
			this.cbGenus.DropDownWidth = 300;
			this.cbGenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbGenus.FormattingEnabled = true;
			this.cbGenus.Location = new System.Drawing.Point(20, 27);
			this.cbGenus.Name = "cbGenus";
			this.cbGenus.Size = new System.Drawing.Size(98, 28);
			this.cbGenus.TabIndex = 23;
			this.cbGenus.SelectedIndexChanged += new System.EventHandler(this.cbGenus_SelectedIndexChanged);
			// 
			// labGenusCB
			// 
			this.labGenusCB.AutoSize = true;
			this.labGenusCB.BackColor = System.Drawing.Color.Black;
			this.labGenusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labGenusCB.ForeColor = System.Drawing.Color.White;
			this.labGenusCB.Location = new System.Drawing.Point(17, 2);
			this.labGenusCB.Name = "labGenusCB";
			this.labGenusCB.Size = new System.Drawing.Size(108, 24);
			this.labGenusCB.TabIndex = 22;
			this.labGenusCB.Text = "Pick genus:";
			// 
			// cbSubfamily
			// 
			this.cbSubfamily.DropDownWidth = 300;
			this.cbSubfamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSubfamily.FormattingEnabled = true;
			this.cbSubfamily.Location = new System.Drawing.Point(20, 83);
			this.cbSubfamily.Name = "cbSubfamily";
			this.cbSubfamily.Size = new System.Drawing.Size(98, 28);
			this.cbSubfamily.TabIndex = 25;
			this.cbSubfamily.SelectedIndexChanged += new System.EventHandler(this.cbSubfamily_SelectedIndexChanged);
			// 
			// labSubfamilyCB
			// 
			this.labSubfamilyCB.AutoSize = true;
			this.labSubfamilyCB.BackColor = System.Drawing.Color.Black;
			this.labSubfamilyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSubfamilyCB.ForeColor = System.Drawing.Color.White;
			this.labSubfamilyCB.Location = new System.Drawing.Point(6, 58);
			this.labSubfamilyCB.Name = "labSubfamilyCB";
			this.labSubfamilyCB.Size = new System.Drawing.Size(133, 24);
			this.labSubfamilyCB.TabIndex = 24;
			this.labSubfamilyCB.Text = "Pick subfamily:";
			// 
			// cbFamily
			// 
			this.cbFamily.DropDownWidth = 300;
			this.cbFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFamily.FormattingEnabled = true;
			this.cbFamily.Location = new System.Drawing.Point(20, 141);
			this.cbFamily.Name = "cbFamily";
			this.cbFamily.Size = new System.Drawing.Size(98, 28);
			this.cbFamily.TabIndex = 27;
			this.cbFamily.SelectedIndexChanged += new System.EventHandler(this.cbFamily_SelectedIndexChanged);
			// 
			// labFamilyCB
			// 
			this.labFamilyCB.AutoSize = true;
			this.labFamilyCB.BackColor = System.Drawing.Color.Black;
			this.labFamilyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFamilyCB.ForeColor = System.Drawing.Color.White;
			this.labFamilyCB.Location = new System.Drawing.Point(19, 114);
			this.labFamilyCB.Name = "labFamilyCB";
			this.labFamilyCB.Size = new System.Drawing.Size(102, 24);
			this.labFamilyCB.TabIndex = 26;
			this.labFamilyCB.Text = "Pick family:";
			// 
			// panGroupMode
			// 
			this.panGroupMode.Controls.Add(this.radioCountry);
			this.panGroupMode.Controls.Add(this.radioRealm);
			this.panGroupMode.Controls.Add(this.labGenusCB);
			this.panGroupMode.Controls.Add(this.cbGenus);
			this.panGroupMode.Controls.Add(this.cbFamily);
			this.panGroupMode.Controls.Add(this.labSubfamilyCB);
			this.panGroupMode.Controls.Add(this.labFamilyCB);
			this.panGroupMode.Controls.Add(this.cbSubfamily);
			this.panGroupMode.Location = new System.Drawing.Point(7, 164);
			this.panGroupMode.Name = "panGroupMode";
			this.panGroupMode.Size = new System.Drawing.Size(141, 264);
			this.panGroupMode.TabIndex = 28;
			this.panGroupMode.Visible = false;
			// 
			// radioCountry
			// 
			this.radioCountry.AutoSize = true;
			this.radioCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioCountry.ForeColor = System.Drawing.Color.White;
			this.radioCountry.Location = new System.Drawing.Point(23, 212);
			this.radioCountry.Name = "radioCountry";
			this.radioCountry.Size = new System.Drawing.Size(93, 28);
			this.radioCountry.TabIndex = 29;
			this.radioCountry.Text = "Country";
			this.radioCountry.UseVisualStyleBackColor = true;
			this.radioCountry.Visible = false;
			this.radioCountry.CheckedChanged += new System.EventHandler(this.radioCountry_CheckedChanged);
			// 
			// radioRealm
			// 
			this.radioRealm.AutoSize = true;
			this.radioRealm.Checked = true;
			this.radioRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioRealm.ForeColor = System.Drawing.Color.White;
			this.radioRealm.Location = new System.Drawing.Point(24, 178);
			this.radioRealm.Name = "radioRealm";
			this.radioRealm.Size = new System.Drawing.Size(82, 28);
			this.radioRealm.TabIndex = 28;
			this.radioRealm.TabStop = true;
			this.radioRealm.Text = "Realm";
			this.radioRealm.UseVisualStyleBackColor = true;
			this.radioRealm.Visible = false;
			this.radioRealm.CheckedChanged += new System.EventHandler(this.radioRealm_CheckedChanged);
			// 
			// checkEndemic
			// 
			this.checkEndemic.AutoSize = true;
			this.checkEndemic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkEndemic.ForeColor = System.Drawing.Color.White;
			this.checkEndemic.Location = new System.Drawing.Point(28, 434);
			this.checkEndemic.Name = "checkEndemic";
			this.checkEndemic.Size = new System.Drawing.Size(80, 20);
			this.checkEndemic.TabIndex = 30;
			this.checkEndemic.Text = "Endemic";
			this.checkEndemic.UseVisualStyleBackColor = true;
			this.checkEndemic.Visible = false;
			this.checkEndemic.CheckedChanged += new System.EventHandler(this.checkEndemic_CheckedChanged);
			// 
			// labFamAndSub
			// 
			this.labFamAndSub.AutoSize = true;
			this.labFamAndSub.BackColor = System.Drawing.Color.Linen;
			this.labFamAndSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFamAndSub.ForeColor = System.Drawing.Color.Black;
			this.labFamAndSub.Location = new System.Drawing.Point(247, 212);
			this.labFamAndSub.Name = "labFamAndSub";
			this.labFamAndSub.Size = new System.Drawing.Size(126, 25);
			this.labFamAndSub.TabIndex = 31;
			this.labFamAndSub.Text = "Placeholder";
			this.labFamAndSub.Visible = false;
			// 
			// panContinents
			// 
			this.panContinents.BackColor = System.Drawing.Color.Linen;
			this.panContinents.Controls.Add(this.picANT);
			this.panContinents.Controls.Add(this.picOCE);
			this.panContinents.Controls.Add(this.picASI);
			this.panContinents.Controls.Add(this.picAFR);
			this.panContinents.Controls.Add(this.picEUR);
			this.panContinents.Controls.Add(this.picSAM);
			this.panContinents.Controls.Add(this.picNAM);
			this.panContinents.Location = new System.Drawing.Point(154, 10);
			this.panContinents.Name = "panContinents";
			this.panContinents.Size = new System.Drawing.Size(1341, 664);
			this.panContinents.TabIndex = 32;
			this.panContinents.Visible = false;
			// 
			// picANT
			// 
			this.picANT.BackColor = System.Drawing.Color.Coral;
			this.picANT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picANT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picANT.Location = new System.Drawing.Point(92, 348);
			this.picANT.Name = "picANT";
			this.picANT.Size = new System.Drawing.Size(300, 300);
			this.picANT.TabIndex = 6;
			this.picANT.TabStop = false;
			this.picANT.Click += new System.EventHandler(this.picANT_Click);
			this.picANT.MouseEnter += new System.EventHandler(this.picANT_MouseHover);
			this.picANT.MouseLeave += new System.EventHandler(this.picANT_MouseLeave);
			// 
			// picOCE
			// 
			this.picOCE.BackColor = System.Drawing.Color.Coral;
			this.picOCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picOCE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picOCE.Location = new System.Drawing.Point(1094, 348);
			this.picOCE.Name = "picOCE";
			this.picOCE.Size = new System.Drawing.Size(300, 300);
			this.picOCE.TabIndex = 5;
			this.picOCE.TabStop = false;
			this.picOCE.Click += new System.EventHandler(this.picOCE_Click);
			this.picOCE.MouseEnter += new System.EventHandler(this.picOCE_MouseHover);
			this.picOCE.MouseLeave += new System.EventHandler(this.picOCE_MouseLeave);
			// 
			// picASI
			// 
			this.picASI.BackColor = System.Drawing.Color.Coral;
			this.picASI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picASI.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picASI.Location = new System.Drawing.Point(1094, 16);
			this.picASI.Name = "picASI";
			this.picASI.Size = new System.Drawing.Size(300, 300);
			this.picASI.TabIndex = 4;
			this.picASI.TabStop = false;
			this.picASI.Click += new System.EventHandler(this.picASI_Click);
			this.picASI.MouseEnter += new System.EventHandler(this.picASI_MouseHover);
			this.picASI.MouseLeave += new System.EventHandler(this.picASI_MouseLeave);
			// 
			// picAFR
			// 
			this.picAFR.BackColor = System.Drawing.Color.Coral;
			this.picAFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picAFR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picAFR.Location = new System.Drawing.Point(761, 348);
			this.picAFR.Name = "picAFR";
			this.picAFR.Size = new System.Drawing.Size(300, 300);
			this.picAFR.TabIndex = 3;
			this.picAFR.TabStop = false;
			this.picAFR.Click += new System.EventHandler(this.picAFR_Click);
			this.picAFR.MouseEnter += new System.EventHandler(this.picAFR_MouseHover);
			this.picAFR.MouseLeave += new System.EventHandler(this.picAFR_MouseLeave);
			// 
			// picEUR
			// 
			this.picEUR.BackColor = System.Drawing.Color.Coral;
			this.picEUR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picEUR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picEUR.Location = new System.Drawing.Point(761, 16);
			this.picEUR.Name = "picEUR";
			this.picEUR.Size = new System.Drawing.Size(300, 300);
			this.picEUR.TabIndex = 2;
			this.picEUR.TabStop = false;
			this.picEUR.Click += new System.EventHandler(this.picEUR_Click);
			this.picEUR.MouseEnter += new System.EventHandler(this.picEUR_MouseHover);
			this.picEUR.MouseLeave += new System.EventHandler(this.picEUR_MouseLeave);
			// 
			// picSAM
			// 
			this.picSAM.BackColor = System.Drawing.Color.Coral;
			this.picSAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picSAM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picSAM.Location = new System.Drawing.Point(427, 348);
			this.picSAM.Name = "picSAM";
			this.picSAM.Size = new System.Drawing.Size(300, 300);
			this.picSAM.TabIndex = 1;
			this.picSAM.TabStop = false;
			this.picSAM.Click += new System.EventHandler(this.picSAM_Click);
			this.picSAM.MouseEnter += new System.EventHandler(this.picSAM_MouseHover);
			this.picSAM.MouseLeave += new System.EventHandler(this.picSAM_MouseLeave);
			// 
			// picNAM
			// 
			this.picNAM.BackColor = System.Drawing.Color.Coral;
			this.picNAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picNAM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picNAM.Location = new System.Drawing.Point(427, 16);
			this.picNAM.Name = "picNAM";
			this.picNAM.Size = new System.Drawing.Size(300, 300);
			this.picNAM.TabIndex = 0;
			this.picNAM.TabStop = false;
			this.picNAM.Click += new System.EventHandler(this.picNAM_Click);
			this.picNAM.MouseEnter += new System.EventHandler(this.picNAM_MouseHover);
			this.picNAM.MouseLeave += new System.EventHandler(this.picNAM_MouseLeave);
			// 
			// panCountries
			// 
			this.panCountries.BackColor = System.Drawing.Color.Linen;
			this.panCountries.Controls.Add(this.rtbPanCountries);
			this.panCountries.Controls.Add(this.picPhys);
			this.panCountries.Controls.Add(this.picLoc);
			this.panCountries.Controls.Add(this.labCountryNamePanCountries);
			this.panCountries.Controls.Add(this.picFlagPanCountries);
			this.panCountries.Controls.Add(this.cbCountriesPanCountries);
			this.panCountries.Controls.Add(this.btnClosePanCountries);
			this.panCountries.Location = new System.Drawing.Point(427, 10);
			this.panCountries.Name = "panCountries";
			this.panCountries.Size = new System.Drawing.Size(841, 677);
			this.panCountries.TabIndex = 34;
			this.panCountries.Visible = false;
			// 
			// rtbPanCountries
			// 
			this.rtbPanCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
			this.rtbPanCountries.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbPanCountries.Location = new System.Drawing.Point(590, 11);
			this.rtbPanCountries.Name = "rtbPanCountries";
			this.rtbPanCountries.Size = new System.Drawing.Size(875, 590);
			this.rtbPanCountries.TabIndex = 29;
			this.rtbPanCountries.Text = "";
			// 
			// picPhys
			// 
			this.picPhys.BackColor = System.Drawing.Color.Linen;
			this.picPhys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPhys.BackgroundImage")));
			this.picPhys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picPhys.Location = new System.Drawing.Point(34, 229);
			this.picPhys.Name = "picPhys";
			this.picPhys.Size = new System.Drawing.Size(531, 435);
			this.picPhys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPhys.TabIndex = 28;
			this.picPhys.TabStop = false;
			this.picPhys.Visible = false;
			// 
			// picLoc
			// 
			this.picLoc.BackColor = System.Drawing.Color.Linen;
			this.picLoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLoc.BackgroundImage")));
			this.picLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picLoc.Location = new System.Drawing.Point(225, 6);
			this.picLoc.Name = "picLoc";
			this.picLoc.Size = new System.Drawing.Size(340, 217);
			this.picLoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLoc.TabIndex = 27;
			this.picLoc.TabStop = false;
			this.picLoc.Visible = false;
			// 
			// labCountryNamePanCountries
			// 
			this.labCountryNamePanCountries.AutoSize = true;
			this.labCountryNamePanCountries.BackColor = System.Drawing.Color.Linen;
			this.labCountryNamePanCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCountryNamePanCountries.ForeColor = System.Drawing.Color.Black;
			this.labCountryNamePanCountries.Location = new System.Drawing.Point(29, 24);
			this.labCountryNamePanCountries.Name = "labCountryNamePanCountries";
			this.labCountryNamePanCountries.Size = new System.Drawing.Size(149, 25);
			this.labCountryNamePanCountries.TabIndex = 26;
			this.labCountryNamePanCountries.Text = "Country Name";
			this.labCountryNamePanCountries.Visible = false;
			// 
			// picFlagPanCountries
			// 
			this.picFlagPanCountries.BackColor = System.Drawing.Color.Linen;
			this.picFlagPanCountries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFlagPanCountries.BackgroundImage")));
			this.picFlagPanCountries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picFlagPanCountries.Location = new System.Drawing.Point(34, 94);
			this.picFlagPanCountries.Name = "picFlagPanCountries";
			this.picFlagPanCountries.Size = new System.Drawing.Size(175, 129);
			this.picFlagPanCountries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFlagPanCountries.TabIndex = 25;
			this.picFlagPanCountries.TabStop = false;
			this.picFlagPanCountries.Visible = false;
			// 
			// cbCountriesPanCountries
			// 
			this.cbCountriesPanCountries.DropDownWidth = 300;
			this.cbCountriesPanCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCountriesPanCountries.FormattingEnabled = true;
			this.cbCountriesPanCountries.Location = new System.Drawing.Point(34, 63);
			this.cbCountriesPanCountries.Name = "cbCountriesPanCountries";
			this.cbCountriesPanCountries.Size = new System.Drawing.Size(144, 28);
			this.cbCountriesPanCountries.TabIndex = 24;
			this.cbCountriesPanCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountriesPanCountries_SelectedIndexChanged);
			// 
			// btnClosePanCountries
			// 
			this.btnClosePanCountries.Location = new System.Drawing.Point(1366, 621);
			this.btnClosePanCountries.Name = "btnClosePanCountries";
			this.btnClosePanCountries.Size = new System.Drawing.Size(99, 33);
			this.btnClosePanCountries.TabIndex = 13;
			this.btnClosePanCountries.Text = "Close";
			this.btnClosePanCountries.UseVisualStyleBackColor = true;
			this.btnClosePanCountries.Click += new System.EventHandler(this.btnClosePanCountries_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// picHand
			// 
			this.picHand.BackgroundImage = global::Eggpies.Properties.Resources.harvex_icon_hand;
			this.picHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picHand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picHand.Location = new System.Drawing.Point(225, 192);
			this.picHand.Name = "picHand";
			this.picHand.Size = new System.Drawing.Size(300, 300);
			this.picHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picHand.TabIndex = 35;
			this.picHand.TabStop = false;
			this.picHand.Click += new System.EventHandler(this.picHand_Click);
			this.picHand.MouseEnter += new System.EventHandler(this.picHand_MouseEnter);
			this.picHand.MouseLeave += new System.EventHandler(this.picHand_MouseLeave);
			// 
			// picFlag
			// 
			this.picFlag.BackColor = System.Drawing.Color.Linen;
			this.picFlag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFlag.BackgroundImage")));
			this.picFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picFlag.Location = new System.Drawing.Point(168, 48);
			this.picFlag.Name = "picFlag";
			this.picFlag.Size = new System.Drawing.Size(141, 94);
			this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFlag.TabIndex = 17;
			this.picFlag.TabStop = false;
			this.picFlag.Visible = false;
			// 
			// panModes
			// 
			this.panModes.BackColor = System.Drawing.Color.Linen;
			this.panModes.Controls.Add(this.picGlobe);
			this.panModes.Controls.Add(this.picLeaf);
			this.panModes.Controls.Add(this.picHand);
			this.panModes.Location = new System.Drawing.Point(134, 16);
			this.panModes.Name = "panModes";
			this.panModes.Size = new System.Drawing.Size(774, 545);
			this.panModes.TabIndex = 36;
			// 
			// picGlobe
			// 
			this.picGlobe.BackgroundImage = global::Eggpies.Properties.Resources.harvex_icon_world;
			this.picGlobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picGlobe.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picGlobe.Location = new System.Drawing.Point(973, 192);
			this.picGlobe.Name = "picGlobe";
			this.picGlobe.Size = new System.Drawing.Size(300, 300);
			this.picGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picGlobe.TabIndex = 37;
			this.picGlobe.TabStop = false;
			this.picGlobe.Click += new System.EventHandler(this.picGlobe_Click);
			this.picGlobe.MouseEnter += new System.EventHandler(this.picGlobe_MouseEnter);
			this.picGlobe.MouseLeave += new System.EventHandler(this.picGlobe_MouseLeave);
			// 
			// picLeaf
			// 
			this.picLeaf.BackgroundImage = global::Eggpies.Properties.Resources.harvex_icon_leaf;
			this.picLeaf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picLeaf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picLeaf.Location = new System.Drawing.Point(599, 192);
			this.picLeaf.Name = "picLeaf";
			this.picLeaf.Size = new System.Drawing.Size(300, 300);
			this.picLeaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLeaf.TabIndex = 36;
			this.picLeaf.TabStop = false;
			this.picLeaf.Click += new System.EventHandler(this.picLeaf_Click);
			this.picLeaf.MouseEnter += new System.EventHandler(this.picLeaf_MouseEnter);
			this.picLeaf.MouseLeave += new System.EventHandler(this.picLeaf_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1510, 699);
			this.Controls.Add(this.panDebug);
			this.Controls.Add(this.panModes);
			this.Controls.Add(this.panGroupMode);
			this.Controls.Add(this.panCountries);
			this.Controls.Add(this.labFamAndSub);
			this.Controls.Add(this.checkEndemic);
			this.Controls.Add(this.radioFamily);
			this.Controls.Add(this.radioSubfamily);
			this.Controls.Add(this.radioGenus);
			this.Controls.Add(this.labCountryName);
			this.Controls.Add(this.picFlag);
			this.Controls.Add(this.cbAuthor);
			this.Controls.Add(this.labAuthorCB);
			this.Controls.Add(this.labSliderSpecies);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.sliderSpecies);
			this.Controls.Add(this.labTotalSp);
			this.Controls.Add(this.cbCountry);
			this.Controls.Add(this.labCountryCB);
			this.Controls.Add(this.labRealmCB);
			this.Controls.Add(this.cbRealm);
			this.Controls.Add(this.pie);
			this.Controls.Add(this.panContinents);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Harvex                                                                           " +
    "                                                                              by" +
    " Pinhata";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sliderSpecies)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panDebug.ResumeLayout(false);
			this.panDebug.PerformLayout();
			this.panGroupMode.ResumeLayout(false);
			this.panGroupMode.PerformLayout();
			this.panContinents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picANT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picOCE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picASI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAFR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picEUR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSAM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNAM)).EndInit();
			this.panCountries.ResumeLayout(false);
			this.panCountries.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPhys)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFlagPanCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picHand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
			this.panModes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picGlobe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeaf)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pie;
        private System.Windows.Forms.ComboBox cbRealm;
        private System.Windows.Forms.Label labRealmCB;
        private System.Windows.Forms.Label labCountryCB;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label labTotalSp;
        private System.Windows.Forms.TrackBar sliderSpecies;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.Label labFromYear;
        private System.Windows.Forms.TextBox txtMaxYear;
        private System.Windows.Forms.Button btnApplyYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetYear;
        private System.Windows.Forms.Label labSliderSpecies;
        private System.Windows.Forms.Label labAuthorCB;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Panel panDebug;
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.TextBox txtDebugIndex;
        private System.Windows.Forms.Label labDebugMode;
        private System.Windows.Forms.Button btnCloseDebugPanel;
        private System.Windows.Forms.Button btnSearchDebug;
        private System.Windows.Forms.ComboBox cb1Debug;
        private System.Windows.Forms.TextBox txtDebugSearch;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.Label labCountryName;
        private System.Windows.Forms.RadioButton radioGenus;
        private System.Windows.Forms.RadioButton radioSubfamily;
        private System.Windows.Forms.RadioButton radioFamily;
        private System.Windows.Forms.ComboBox cbGenus;
        private System.Windows.Forms.Label labGenusCB;
        private System.Windows.Forms.ComboBox cbSubfamily;
        private System.Windows.Forms.Label labSubfamilyCB;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.Label labFamilyCB;
        private System.Windows.Forms.Panel panGroupMode;
        private System.Windows.Forms.RadioButton radioCountry;
        private System.Windows.Forms.RadioButton radioRealm;
        private System.Windows.Forms.CheckBox checkEndemic;
        private System.Windows.Forms.Label labFamAndSub;
        private System.Windows.Forms.Panel panContinents;
        private System.Windows.Forms.PictureBox picANT;
        private System.Windows.Forms.PictureBox picOCE;
        private System.Windows.Forms.PictureBox picASI;
        private System.Windows.Forms.PictureBox picAFR;
        private System.Windows.Forms.PictureBox picEUR;
        private System.Windows.Forms.PictureBox picSAM;
        private System.Windows.Forms.PictureBox picNAM;
        private System.Windows.Forms.Panel panCountries;
        private System.Windows.Forms.Button btnClosePanCountries;
        private System.Windows.Forms.ComboBox cbCountriesPanCountries;
        private System.Windows.Forms.Label labCountryNamePanCountries;
        private System.Windows.Forms.PictureBox picFlagPanCountries;
        private System.Windows.Forms.PictureBox picPhys;
        private System.Windows.Forms.PictureBox picLoc;
        private System.Windows.Forms.RichTextBox rtbPanCountries;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picHand;
        private System.Windows.Forms.Panel panModes;
        private System.Windows.Forms.PictureBox picLeaf;
        private System.Windows.Forms.PictureBox picGlobe;
    }
}

