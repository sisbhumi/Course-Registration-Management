using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace TempProjet
{
    public partial class Form1 : Form
    {
        string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bhumi\source\repos\TempProjet\TempDB.mdf;Integrated Security=True";
        public string name, course , enrol ;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tempTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tempTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tempDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tempDBDataSet.courseTemp' table. You can move, or remove it, as needed.
            this.courseTempTableAdapter.Fill(this.tempDBDataSet.courseTemp);
            // TODO: This line of code loads data into the 'tempDBDataSet.TempTable' table. You can move, or remove it, as needed.
            this.tempTableTableAdapter1.Fill(this.tempDBDataSet.TempTable);

            courseComboBox.Text = "";
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            name = ti.ToTitleCase(nameTextBox.Text);
        }

        private void enrollTextBox_TextChanged(object sender, EventArgs e)
        {
            enrol = enrollTextBox.Text;
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            course = courseComboBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = " INSERT INTO dbo.TempTable (Name , Enroll , Course) VALUES ( '" + name + "', '" + enrol + "', '" + courseComboBox.Text + "') ";
            string squery = "Select Name from dbo.TempTable where Name = '" + name + "' and Course = '" + course + "';";

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Focus();
                MessageBox.Show("Name should not be left blank!");
                errorProviderApp.SetError(nameTextBox, "Name should not be left blank!");
            }
           
            else if (string.IsNullOrWhiteSpace(enrollTextBox.Text) && string.IsNullOrWhiteSpace(courseComboBox.Text))
            {
                enrollTextBox.Focus();
                courseComboBox.Focus();
                MessageBox.Show("Please Provide your Enrollment and Select a Course.");
            }
            
            else if (string.IsNullOrWhiteSpace(enrollTextBox.Text))
            {
                enrollTextBox.Focus();
                MessageBox.Show("Enrollement shouldnot be left blank!");
                errorProviderApp.SetError(enrollTextBox, "Enrollment should not be left blank!");
            }
            
            else if (string.IsNullOrWhiteSpace(courseComboBox.Text))
            {
                courseComboBox.Focus();
                MessageBox.Show("Please Select a Course!");
                errorProviderApp.SetError(courseComboBox, "Please Select a Course!");
            }
            
            else
            {
                errorProviderApp.Clear();
                SqlConnection con = new SqlConnection(strconn);
                SqlCommand cmd1 = new SqlCommand(squery, con);
                SqlCommand cmd = new SqlCommand(query, con);
                
                con.Open();
                SqlDataReader r = cmd1.ExecuteReader();
                
                if (r.Read())
                {
                    try
                    {
                        int x = r.GetOrdinal("Name");
                        int b = r.GetInt32(x);

                        cEnrolltxt.Text = Convert.ToString(b);
                        MessageBox.Show(name + " have alredy enrolled in " + course + " Course.");
                    }
                    
                    catch (Exception y)
                    {
                        MessageBox.Show(name + " have alredy enrolled in " + course + " Course.");
                    }
                }
                
                else
                {
                    errorProviderApp.Clear();
                    con.Close();
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    MessageBox.Show("Dear " + name + " you have successfully Enrolled in " + course + " course.");
                    con.Close();

                    nameTextBox.Text = "";
                    enrollTextBox.Text = "";
                    courseComboBox.Text = "";
                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string delquery = " DELETE FROM dbo.TempTable where  Name = '" + name + "' and Enroll = " + enrol + "  ";
            
            SqlConnection con = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand(delquery, con);
           
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted.");
                con.Close();
            }
            
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

            nameTextBox.Text = "";
            enrollTextBox.Text = "";
            courseComboBox.Text = "";
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT( course ) as no_of_courses from [dbo].[TempTable] where Enroll = " + enrol + " group by Name having Name = '" + name + "' ";
           
            SqlConnection con = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand(query, con);
            
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(enrol))
            {
                nameTextBox.Focus();
                enrollTextBox.Focus();
                nameTextBox.Focus();
                MessageBox.Show("Name and Enrollement Required!");
                errorProviderApp.SetError(nameTextBox , "Name Required!");
                errorProviderApp.SetError(enrollTextBox, "Enrollement Required!"); 
            }
            
            else if (string.IsNullOrWhiteSpace(name))
            {
                nameTextBox.Focus();
                MessageBox.Show("Name Required!");
                errorProviderApp.SetError(nameTextBox, "Name Required!");
            }
            
            else if (string.IsNullOrWhiteSpace(enrol))
            {
                enrollTextBox.Focus();
                MessageBox.Show("Enrollement Required!");
                errorProviderApp.SetError(enrollTextBox, "Enrollement Required!");
            }
            
            else
            {
                errorProviderApp.Clear();
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    try
                    {
                        int x = r.GetOrdinal("no_of_courses");
                        int b = r.GetInt32(x);

                        cEnrolltxt.Text = Convert.ToString(b);
                        MessageBox.Show(name + " have enrolled in " + cEnrolltxt.Text + " Courses.");
                    }
                   
                    catch (Exception y)
                    {
                        MessageBox.Show(y.Message + "\nNot Enrolled yet");
                    }
                }
                
                else
                {
                    MessageBox.Show("\nNot Enrolled yet");
                    cEnrolltxt.Clear();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT COUNT( Name ) as no_of_students from [dbo].[TempTable] group by Course having Course = '" + courseComboBox.Text + "' ";
            
            SqlConnection con = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand(query, con);
            
            if (string.IsNullOrWhiteSpace(courseComboBox.Text))
            {
                courseComboBox.Focus();
                MessageBox.Show("Please Select a Course!");
                errorProviderApp.SetError(courseComboBox, "Please Select a Course!");
            }
            
            else
            {
                errorProviderApp.Clear();
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    int x = r.GetOrdinal("no_of_students");
                    int b = r.GetInt32(x);
                    sEnrolltxt.Text = Convert.ToString(b);
                    if (Convert.ToInt32(sEnrolltxt.Text) == 0)  
                        MessageBox.Show("Not Enrolled Yet!");
                    else
                        MessageBox.Show(sEnrolltxt.Text + " students have Enrolled in " + courseComboBox.Text + " Course");
                    courseComboBox.Text = "";
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void courseTextBox_validating(object sender, CancelEventArgs e)
        {

        }
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
        private void enrollTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
        private void tempTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void courseLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
