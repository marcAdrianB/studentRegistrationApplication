using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        private string selectedDate;
        public Form1()
        {
            InitializeComponent();
           
            
        }
        private void Form1Load(object sender, EventArgs e)
        {
            dateOfBirth();
        }

        private void dateOfBirth()
        {
            day.Items.Add("Day");
            day.SelectedIndex = 0;

            for (int i = 1; i <= 31; i++)
            {
                day.Items.Add(i);
            }

            month.Items.Add("Month");
            month.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
            {
                month.Items.Add(i);
            }

            year.Items.Add("Year");
            year.SelectedIndex = 0;

            for (int i = 2024; i >= 1900; i--)
            {
                year.Items.Add(i);
            }
            Controls.Add(day);
            Controls.Add(month);
            Controls.Add(year);

        }

        private void registerStud_Click(object sender, EventArgs e)
        {
            checkData();
        }

        private void checkData()
        {
            try
            {
                rLast.Text = "";
                rFirst.Text = "";
                rGender.Text = "";
                rBday.Text = "";


                if (lastName.Text == "" || lastName.Text == " ")
                {
                    rLast.Text = "*This portion is required.*";

                }
                if (firstName.Text == "" || firstName.Text == " ")
                {
                    rFirst.Text = "*This portion is required.*";
                }
                if (!maleButton.Checked && !femaleButton.Checked)
                {
                    rGender.Text = "*Required*";
                }
                if (day.SelectedIndex == 0 || month.SelectedIndex == 0 || year.SelectedIndex == 0)
                {
                    rBday.Text = "*Birthdate is required*";
                }

                else
                {
                    rLast.Text = "";
                    rFirst.Text = "";
                    rGender.Text = "";
                    rBday.Text = "";


                    string LN = lastName.Text;
                    string FN = firstName.Text;
                    string MN = middleName.Text;
                    string selectedDate = day.Text;
                    string selectedMonth = month.Text;
                    string selectedYear = year.Text;
                    string gender;

                    if (maleButton.Checked)
                    {
                        gender = "Male";
                        CustomMessageBox cb = new CustomMessageBox(FN, MN, LN, gender,
                            selectedDate, selectedMonth, selectedYear);
                        cb.Show();
                    }
                    else if (femaleButton.Checked)
                    {
                        gender = "Female";
                        CustomMessageBox cb = new CustomMessageBox(FN, MN, LN, gender,
                           selectedDate, selectedMonth, selectedYear);
                        cb.Show();
                    }
                }


                if (rLast.Text != "" || rFirst.Text != "" || rGender.Text != "" 
                    || rBday.Text != "")
                {
                    MessageBox.Show("Some required portions are empty.\nPlease fill them up.");

                }
                   



            }
            catch (FormatException)
            {



            }


        }
       






        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastName.Clear();
            firstName.Clear();
            middleName.Clear();
            maleButton.Checked = false;
            femaleButton.Checked = false;
            day.SelectedIndex = 0;
            year.SelectedIndex = 0;
            month.SelectedIndex = 0;
        }
    }
}
