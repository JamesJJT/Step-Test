using Step_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Step_Test
{
    public partial class Form1 : Form
    {

        public DBEntities db;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)     //This will load when the application runs.
        {
            db = new DBEntities();
            dgvDatabase.DataSource = db.Results.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)      //Saving information to the database
        {
            {
                db = new DBEntities();
                Result r = new Result();
                r.Name = tbName.Text;
                r.Age = tbAge.Text;
                r.Tester_Initial = tbTester.Text;
                r.HR_I = tbI.Text;
                r.HR_II = tbII.Text;
                r.HR_III = tbIII.Text;
                r.HR_IV = tbIV.Text;
                r.HR_V = tbV.Text;
                r.Date_of_test = tbDateOfTest.Text;
                r.Aerobic_Capacity = tbAerobic.Text;
                r.Fitness_rating = tbFitness.Text;
                r.Remarks = tbRemarks.Text;
                r.Male = rbMale.Checked;
                r.Female = rbFemale.Checked;
                r.C15cm = rbStep15.Checked;
                r.C20cm = rbStep20.Checked;
                r.C25cm = rbStep25.Checked;
                r.C30cm = rbStep30.Checked;
                db.Results.Add(r);
                db.SaveChanges();
                dgvDatabase.DataSource = db.Results.ToList();
            }
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true || rbFemale.Checked == true)
            {
                if (cbContraindication.Checked == true && cbLifestyle.Checked == true && cbReadiness.Checked == true)
                {
                    try    //This will catch if the user inputs not a number in the age box.
                    {
                        int agetest = int.Parse(tbAge.Text);
                    }
                    catch (System.Exception excep)
                    {
                        MessageBox.Show(excep.Message + " Please check the Age input.");
                        return;
                    }
                    try
                    {
                        double[] Heartratetest = new double[5];     //Making sure that the HR inputs are a number
                        Heartratetest[0] = double.Parse(tbI.Text);
                        Heartratetest[1] = double.Parse(tbII.Text);
                        Heartratetest[2] = double.Parse(tbIII.Text);
                        Heartratetest[3] = double.Parse(tbIV.Text);
                        Heartratetest[4] = double.Parse(tbV.Text);
                    }
                    catch (System.Exception excep)
                    {
                        MessageBox.Show(excep.Message + " Please check the HR inputs.");
                        return;
                    }

                    int age = int.Parse(tbAge.Text);
                    double maxhr = 220 - age;
                    double eightyfivemaxhr = maxhr * 0.85;
                    double fiftymaxhr = maxhr * 0.50;
                    lblMaxHR.Text = maxhr.ToString();
                    lblMaxHR.Visible = true;
                    if (age < 15 || age > 65)   //This is the age range of the step test.
                    {
                        MessageBox.Show("Age needs to be between 15 & 65");
                        return;
                    }
                    else
                    {
                        double[] Heartrate = new double[5];     //Inputting of the HR Readings
                        Heartrate[0] = double.Parse(tbI.Text);
                        Heartrate[1] = double.Parse(tbII.Text);
                        Heartrate[2] = double.Parse(tbIII.Text);
                        Heartrate[3] = double.Parse(tbIV.Text);
                        Heartrate[4] = double.Parse(tbV.Text);
                        if (String.IsNullOrEmpty(tbI.Text) || String.IsNullOrEmpty(tbII.Text) || String.IsNullOrEmpty(tbIII.Text) || String.IsNullOrEmpty(tbIV.Text) || String.IsNullOrEmpty(tbV.Text))
                        {
                            MessageBox.Show("Please set the remaining HR values to 0");
                            return;
                        }
                        if (rbStep15.Checked == true)
                        {
                            double[] a = { 11, 14, 18, 21, 25 };
                            StepPlot(Heartrate, eightyfivemaxhr, fiftymaxhr, maxhr, a);
                        }
                        else if (rbStep20.Checked == true)
                        {
                            double[] a = { 12, 17, 21, 25, 29 };
                            StepPlot(Heartrate, eightyfivemaxhr, fiftymaxhr, maxhr, a);
                        }
                        else if (rbStep25.Checked == true)
                        {
                            double[] a = { 14, 19, 24, 28, 33 };
                            StepPlot(Heartrate, eightyfivemaxhr, fiftymaxhr, maxhr, a);
                        }
                        else if (rbStep30.Checked == true)
                        {
                            double[] a = { 16, 21, 27, 32, 37 };
                            StepPlot(Heartrate, eightyfivemaxhr, fiftymaxhr, maxhr, a);
                        }
                        else
                        {
                            MessageBox.Show("Step size not selected. Please select a step size.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Check Boxes not ticked!");
                }
            }
            else
            {
                MessageBox.Show("Please select a gender.");
            }
        }

        private void StepPlot(double[] Heartrate, double eightyfivemaxhr, double fiftymaxhr, double maxhr, double[] a) 
        {       //Plotting graph and calculating aerobic capacity
            int count = 0;
            for (int q = 0; q < 5; q++)
            {
                if (Heartrate[q] >0)
                {
                    count++;
                }
            }
            for (int q = 0; q < 5; q++)
            {
                if (Heartrate[q] >= fiftymaxhr && Heartrate[q] <= eightyfivemaxhr)
                {
                    chart1.Series[0].Points.AddXY(a[q], Heartrate[q]);
                }
            }
            for (int q = 0; q < 5; q++)
            {
                if (Heartrate[q]==0)
                {
                    a[q] = 0;
                }
            }
            double meany = Heartrate.Sum() / count;
            double sum = 0;
            for (int k = 0; k < 5; k++)
            {
                sum = sum + a[k];
            }
            double meanx = sum / count;
            double squarex = a.Sum() * a.Sum();
            double sumxy = a.Sum() * Heartrate.Sum();
            double xsquared = 0;
            double xysum = 0;

            foreach (int item in a)
            {
                xsquared = xsquared + (item * item);
            }
            int i = 0;
            foreach (int item in a)
            {

                xysum = xysum + (Heartrate[i] * item);
                i++;
            }

            double m = (xysum - (sumxy / count)) / (xsquared - (squarex / count));
            m = Math.Round(m, 2);
            double b = meany - (m * meanx);
            b = Math.Round(b, 2);
            double y1 = (m * 0) + b; //
            double y2 = (m * 40) + b;

            //plotting two points to create line of best fit
            chart1.Series[1].Points.AddXY(0, y1);
            chart1.Series[1].Points.AddXY(40, y2);
            double x1 = (maxhr - b) / m;
            tbAerobic.Text = x1.ToString("#.##");
            FitnessRating(x1);
        }

        private void FitnessRating(double x1) //Calculating the fitness rating
        {
            Math.Round(x1);
            int age = int.Parse(tbAge.Text);
            if (rbMale.Checked == true)
            {
                if (age >= 15 && age <=19)
                {
                    if (x1 >= 60)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <=59 && x1 >=45)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <=47 && x1 >39)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 38 && x1 >30)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 30)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >=20 && age <=29)
                {
                    if (x1 >= 55)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 54 && x1 >= 44)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 43 && x1 > 35)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 34 && x1 > 28)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 28)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 30 && age <= 39)
                {
                    if (x1 >= 50)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 49 && x1 >= 40)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 39 && x1 > 34)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 33 && x1 > 26)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 36)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 40 && age <= 49)
                {
                    if (x1 >= 46)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 45 && x1 >= 37)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 36 && x1 > 32)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 31 && x1 > 25)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 25)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 50 && age <= 59)
                {
                    if (x1 >= 44)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 43 && x1 >= 35)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 34 && x1 > 29)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 28 && x1 > 23)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 23)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 60 && age <= 65)
                {
                    if (x1 >= 40)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 43 && x1 >= 35)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 34 && x1 > 29)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 28 && x1 > 23)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 23)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
            }
            if (rbFemale.Checked == true)
            {
                if (age >= 15 && age <= 19)
                {
                    if (x1 >= 55)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 54 && x1 >= 44)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 43 && x1 > 35)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 34 && x1 > 28)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 28)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 20 && age <= 29)
                {
                    if (x1 >= 50)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 49 && x1 >= 40)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 39 && x1 > 34)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 33 && x1 > 26)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 36)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 30 && age <= 39)
                {
                    if (x1 >= 45)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 45 && x1 >= 36)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 35 && x1 > 30)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 29 && x1 > 25)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 25)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 40 && age <= 49)
                {
                    if (x1 >= 43)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 42 && x1 >= 34)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 33 && x1 > 25)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 27 && x1 > 22)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 22)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 50 && age <= 59)
                {
                    if (x1 >= 41)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 40 && x1 >= 33)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 32 && x1 > 26)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 25 && x1 > 21)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 21)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
                else if (age >= 60 && age <= 65)
                {
                    if (x1 >= 39)
                    {
                        tbFitness.Text = "Excellent";
                    }
                    else if (x1 <= 38 && x1 >= 31)
                    {
                        tbFitness.Text = "Good";
                    }
                    else if (x1 <= 30 && x1 > 24)
                    {
                        tbFitness.Text = "Average";
                    }
                    else if (x1 <= 23 && x1 > 19)
                    {
                        tbFitness.Text = "Below Average";
                    }
                    else if (x1 < 19)
                    {
                        tbFitness.Text = "Poor";
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)     //clear boxes and graph on main screen
        {   
            tbI.Clear();
            tbII.Clear();
            tbIII.Clear();
            tbIV.Clear();
            tbV.Clear();
            tbName.Clear();
            tbTester.Clear();
            tbAge.Clear();
            tbAerobic.Clear();
            tbDateOfTest.Clear();
            tbFitness.Clear();
            tbRemarks.Clear();
            lblMaxHR.Visible = false;
            cbContraindication.Checked = false;
            cbLifestyle.Checked = false;
            cbReadiness.Checked = false;
            rbStep15.Checked = false;
            rbStep20.Checked = false;
            rbStep25.Checked = false;
            rbStep30.Checked = false;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)  //Opens the file dialog for importing data
        {   //open file explorer to import data from a file
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                List<string> rlist = GetInputFile(path);
                addToDp(rlist);
                db = new DBEntities();
                PopulateGrid(db.Results.ToList());
                db.SaveChanges();
            }
        }

        private void PopulateGrid(List<Result> list)    //Populating data grid view and sorting by the ID
        {
            dgvDatabase.DataSource = list;
            dgvDatabase.Columns[0].HeaderCell.Value = "Importance";
        }

        private void addToDp(List<string> rlist)    //Adding data to the database
        {   
            db = new DBEntities();
            foreach (var str in rlist)
            {
                string[] wordArray = str.Split(',');
                Result r = new Result();
                r.Name = wordArray[0].ToString();
                r.Age = wordArray[1].ToString();
                r.Tester_Initial = wordArray[2].ToString();
                r.HR_I = wordArray[3].ToString();
                r.HR_II = wordArray[4].ToString();
                r.HR_III = wordArray[5].ToString();
                r.HR_IV = wordArray[6].ToString();
                r.HR_V = wordArray[7].ToString();
                r.Date_of_test = wordArray[8].ToString();
                r.Aerobic_Capacity = wordArray[9].ToString();
                r.Fitness_rating = wordArray[10].ToString();
                r.Remarks = wordArray[11].ToString();
                r.Male = bool.Parse(wordArray[12]);
                r.Female = bool.Parse(wordArray[13]);
                r.C15cm = bool.Parse(wordArray[14]);
                r.C20cm = bool.Parse(wordArray[15]);
                r.C25cm = bool.Parse(wordArray[16]);
                r.C30cm = bool.Parse(wordArray[17]);
                db.Results.Add(r);
                db.SaveChanges();
            }
        }


        private List<string> GetInputFile(string path)  //Getting the string of the path of the file for importing.
        {
            StreamReader sr = new StreamReader(path);
            List<string> memberlist = new List<string>();
            while (sr.Peek() != -1)
            {
                memberlist.Add(sr.ReadLine());
            }
            sr.Close();
            return memberlist;
        }

        private void dgvDatabase_CellClick(object sender, DataGridViewCellEventArgs e)  //Loads data into the corrosponding fileds on the main tab from the database.
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int c = (int)dgvDatabase.Rows[e.RowIndex].Cells[0].Value;
            DBEntities db = new DBEntities();
            Result r = db.Results.Where(i => i.Id == c).First();
            tbName.Text = r.Name.ToString();
            tbAge.Text = r.Age.ToString();
            tbTester.Text = r.Tester_Initial.ToString();
            tbI.Text = r.HR_I.ToString();
            tbII.Text = r.HR_II.ToString();
            tbIII.Text = r.HR_III.ToString();
            tbIV.Text = r.HR_IV.ToString();
            tbV.Text = r.HR_V.ToString();
            tbDateOfTest.Text = r.Date_of_test.ToString();
            tbAerobic.Text = r.Aerobic_Capacity.ToString();
            tbFitness.Text = r.Fitness_rating.ToString();
            tbRemarks.Text = r.Remarks.ToString();
            rbMale.Checked = (bool)r.Male;
            rbFemale.Checked = (bool)r.Female;
            rbStep15.Checked = (bool)r.C15cm;
            rbFemale.Checked = (bool)r.C20cm;
            rbFemale.Checked = (bool)r.C25cm;
            rbFemale.Checked = (bool)r.C30cm;
        }




        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbStepHeight_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
