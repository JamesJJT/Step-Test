namespace Step_Test
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gbStepHeight = new System.Windows.Forms.TabPage();
            this.lblMaxHR = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.tbFitness = new System.Windows.Forms.TextBox();
            this.tbAerobic = new System.Windows.Forms.TextBox();
            this.tbDateOfTest = new System.Windows.Forms.TextBox();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIII = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.lblTester = new System.Windows.Forms.Label();
            this.tbTester = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbCheckBox = new System.Windows.Forms.GroupBox();
            this.cbLifestyle = new System.Windows.Forms.CheckBox();
            this.cbContraindication = new System.Windows.Forms.CheckBox();
            this.cbReadiness = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStep30 = new System.Windows.Forms.RadioButton();
            this.rbStep20 = new System.Windows.Forms.RadioButton();
            this.rbStep25 = new System.Windows.Forms.RadioButton();
            this.rbStep15 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.gbStepHeight.SuspendLayout();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbResults.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbInformation.SuspendLayout();
            this.gbCheckBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gbStepHeight);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 703);
            this.tabControl1.TabIndex = 0;
            // 
            // gbStepHeight
            // 
            this.gbStepHeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbStepHeight.Controls.Add(this.lblMaxHR);
            this.gbStepHeight.Controls.Add(this.label13);
            this.gbStepHeight.Controls.Add(this.btnSave);
            this.gbStepHeight.Controls.Add(this.gbGender);
            this.gbStepHeight.Controls.Add(this.chart1);
            this.gbStepHeight.Controls.Add(this.btnClear);
            this.gbStepHeight.Controls.Add(this.btnCalculate);
            this.gbStepHeight.Controls.Add(this.gbResults);
            this.gbStepHeight.Controls.Add(this.gbData);
            this.gbStepHeight.Controls.Add(this.gbInformation);
            this.gbStepHeight.Controls.Add(this.gbCheckBox);
            this.gbStepHeight.Controls.Add(this.groupBox1);
            this.gbStepHeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbStepHeight.Location = new System.Drawing.Point(4, 22);
            this.gbStepHeight.Name = "gbStepHeight";
            this.gbStepHeight.Padding = new System.Windows.Forms.Padding(3);
            this.gbStepHeight.Size = new System.Drawing.Size(806, 677);
            this.gbStepHeight.TabIndex = 0;
            this.gbStepHeight.Text = "Main";
            this.gbStepHeight.Click += new System.EventHandler(this.gbStepHeight_Click);
            // 
            // lblMaxHR
            // 
            this.lblMaxHR.AutoSize = true;
            this.lblMaxHR.Location = new System.Drawing.Point(323, 102);
            this.lblMaxHR.Name = "lblMaxHR";
            this.lblMaxHR.Size = new System.Drawing.Size(0, 13);
            this.lblMaxHR.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "MaxHR:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(486, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(283, 117);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(105, 72);
            this.gbGender.TabIndex = 30;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(7, 44);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 20);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 195);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerSize = 10;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(779, 476);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(487, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(487, 166);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.tbFitness);
            this.gbResults.Controls.Add(this.tbAerobic);
            this.gbResults.Controls.Add(this.tbDateOfTest);
            this.gbResults.Controls.Add(this.tbRemarks);
            this.gbResults.Controls.Add(this.label12);
            this.gbResults.Controls.Add(this.label11);
            this.gbResults.Controls.Add(this.label10);
            this.gbResults.Controls.Add(this.label9);
            this.gbResults.Location = new System.Drawing.Point(568, 7);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(217, 182);
            this.gbResults.TabIndex = 26;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // tbFitness
            // 
            this.tbFitness.Location = new System.Drawing.Point(101, 65);
            this.tbFitness.Name = "tbFitness";
            this.tbFitness.Size = new System.Drawing.Size(110, 20);
            this.tbFitness.TabIndex = 2;
            // 
            // tbAerobic
            // 
            this.tbAerobic.Location = new System.Drawing.Point(101, 39);
            this.tbAerobic.Name = "tbAerobic";
            this.tbAerobic.Size = new System.Drawing.Size(110, 20);
            this.tbAerobic.TabIndex = 1;
            // 
            // tbDateOfTest
            // 
            this.tbDateOfTest.Location = new System.Drawing.Point(77, 13);
            this.tbDateOfTest.Name = "tbDateOfTest";
            this.tbDateOfTest.Size = new System.Drawing.Size(134, 20);
            this.tbDateOfTest.TabIndex = 0;
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(9, 108);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(202, 68);
            this.tbRemarks.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Remarks:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Fitness rating:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Aerobic capacity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Date of test:";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.tbI);
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.tbIV);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.tbV);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.tbIII);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.tbII);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Location = new System.Drawing.Point(6, 118);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(271, 71);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "HR:";
            // 
            // tbI
            // 
            this.tbI.Location = new System.Drawing.Point(41, 38);
            this.tbI.Name = "tbI";
            this.tbI.Size = new System.Drawing.Size(38, 20);
            this.tbI.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "V";
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(177, 38);
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(38, 20);
            this.tbIV.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "IV";
            // 
            // tbV
            // 
            this.tbV.Location = new System.Drawing.Point(224, 38);
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(38, 20);
            this.tbV.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "III";
            // 
            // tbIII
            // 
            this.tbIII.Location = new System.Drawing.Point(129, 38);
            this.tbIII.Name = "tbIII";
            this.tbIII.Size = new System.Drawing.Size(38, 20);
            this.tbIII.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "II";
            // 
            // tbII
            // 
            this.tbII.Location = new System.Drawing.Point(85, 38);
            this.tbII.Name = "tbII";
            this.tbII.Size = new System.Drawing.Size(38, 20);
            this.tbII.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "I";
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.lblTester);
            this.gbInformation.Controls.Add(this.tbTester);
            this.gbInformation.Controls.Add(this.label2);
            this.gbInformation.Controls.Add(this.tbAge);
            this.gbInformation.Controls.Add(this.label1);
            this.gbInformation.Controls.Add(this.tbName);
            this.gbInformation.Location = new System.Drawing.Point(6, 6);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(254, 106);
            this.gbInformation.TabIndex = 0;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Information";
            // 
            // lblTester
            // 
            this.lblTester.AutoSize = true;
            this.lblTester.Location = new System.Drawing.Point(6, 74);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(67, 13);
            this.lblTester.TabIndex = 3;
            this.lblTester.Text = "Tester Initial:";
            // 
            // tbTester
            // 
            this.tbTester.Location = new System.Drawing.Point(79, 71);
            this.tbTester.Name = "tbTester";
            this.tbTester.Size = new System.Drawing.Size(36, 20);
            this.tbTester.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Age:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(79, 40);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(36, 20);
            this.tbAge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 20);
            this.tbName.TabIndex = 1;
            // 
            // gbCheckBox
            // 
            this.gbCheckBox.Controls.Add(this.cbLifestyle);
            this.gbCheckBox.Controls.Add(this.cbContraindication);
            this.gbCheckBox.Controls.Add(this.cbReadiness);
            this.gbCheckBox.Location = new System.Drawing.Point(266, 7);
            this.gbCheckBox.Name = "gbCheckBox";
            this.gbCheckBox.Size = new System.Drawing.Size(171, 90);
            this.gbCheckBox.TabIndex = 8;
            this.gbCheckBox.TabStop = false;
            this.gbCheckBox.Text = "Extra";
            // 
            // cbLifestyle
            // 
            this.cbLifestyle.AutoSize = true;
            this.cbLifestyle.Location = new System.Drawing.Point(7, 67);
            this.cbLifestyle.Name = "cbLifestyle";
            this.cbLifestyle.Size = new System.Drawing.Size(158, 17);
            this.cbLifestyle.TabIndex = 2;
            this.cbLifestyle.Text = "Lifestyle activity level check";
            this.cbLifestyle.UseVisualStyleBackColor = true;
            // 
            // cbContraindication
            // 
            this.cbContraindication.AutoSize = true;
            this.cbContraindication.Location = new System.Drawing.Point(7, 43);
            this.cbContraindication.Name = "cbContraindication";
            this.cbContraindication.Size = new System.Drawing.Size(164, 17);
            this.cbContraindication.TabIndex = 1;
            this.cbContraindication.Text = "Contra-indications to exercise";
            this.cbContraindication.UseVisualStyleBackColor = true;
            // 
            // cbReadiness
            // 
            this.cbReadiness.AutoSize = true;
            this.cbReadiness.Location = new System.Drawing.Point(7, 20);
            this.cbReadiness.Name = "cbReadiness";
            this.cbReadiness.Size = new System.Drawing.Size(163, 17);
            this.cbReadiness.TabIndex = 0;
            this.cbReadiness.Text = "Readiness to exercise check";
            this.cbReadiness.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStep30);
            this.groupBox1.Controls.Add(this.rbStep20);
            this.groupBox1.Controls.Add(this.rbStep25);
            this.groupBox1.Controls.Add(this.rbStep15);
            this.groupBox1.Location = new System.Drawing.Point(443, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step Height";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbStep30
            // 
            this.rbStep30.AutoSize = true;
            this.rbStep30.Location = new System.Drawing.Point(64, 43);
            this.rbStep30.Name = "rbStep30";
            this.rbStep30.Size = new System.Drawing.Size(51, 17);
            this.rbStep30.TabIndex = 3;
            this.rbStep30.TabStop = true;
            this.rbStep30.Text = "30cm";
            this.rbStep30.UseVisualStyleBackColor = true;
            // 
            // rbStep20
            // 
            this.rbStep20.AutoSize = true;
            this.rbStep20.Location = new System.Drawing.Point(64, 20);
            this.rbStep20.Name = "rbStep20";
            this.rbStep20.Size = new System.Drawing.Size(51, 17);
            this.rbStep20.TabIndex = 2;
            this.rbStep20.TabStop = true;
            this.rbStep20.Text = "20cm";
            this.rbStep20.UseVisualStyleBackColor = true;
            // 
            // rbStep25
            // 
            this.rbStep25.AutoSize = true;
            this.rbStep25.Location = new System.Drawing.Point(7, 44);
            this.rbStep25.Name = "rbStep25";
            this.rbStep25.Size = new System.Drawing.Size(51, 17);
            this.rbStep25.TabIndex = 1;
            this.rbStep25.TabStop = true;
            this.rbStep25.Text = "25cm";
            this.rbStep25.UseVisualStyleBackColor = true;
            // 
            // rbStep15
            // 
            this.rbStep15.AutoSize = true;
            this.rbStep15.Location = new System.Drawing.Point(7, 20);
            this.rbStep15.Name = "rbStep15";
            this.rbStep15.Size = new System.Drawing.Size(51, 17);
            this.rbStep15.TabIndex = 0;
            this.rbStep15.TabStop = true;
            this.rbStep15.Text = "15cm";
            this.rbStep15.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.dgvDatabase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Location = new System.Drawing.Point(6, 32);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.Size = new System.Drawing.Size(794, 639);
            this.dgvDatabase.TabIndex = 0;
            this.dgvDatabase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatabase_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 727);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Step Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.gbStepHeight.ResumeLayout(false);
            this.gbStepHeight.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.gbCheckBox.ResumeLayout(false);
            this.gbCheckBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gbStepHeight;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCheckBox;
        private System.Windows.Forms.CheckBox cbLifestyle;
        private System.Windows.Forms.CheckBox cbContraindication;
        private System.Windows.Forms.CheckBox cbReadiness;
        private System.Windows.Forms.RadioButton rbStep30;
        private System.Windows.Forms.RadioButton rbStep20;
        private System.Windows.Forms.RadioButton rbStep25;
        private System.Windows.Forms.RadioButton rbStep15;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIII;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.TextBox tbTester;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFitness;
        private System.Windows.Forms.TextBox tbAerobic;
        private System.Windows.Forms.TextBox tbDateOfTest;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMaxHR;
        private System.Windows.Forms.Label label13;
    }
}

