using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void Form2_Load(object sender, EventArgs e)
        {
            
            dataGridView3.DataSource = Form1.StudentList;
            dataGridView4.DataSource = Form1.GroupList;
            cmbDisplayGroup2.DataSource = Form1.GroupList;
            cmbDisplayGroup2.DisplayMember = "GroupName";
            cmbDisplayGroup2.ValueMember = "GroupID";
            comboBoxStudentName.DataSource = Form1.StudentList;
            comboBoxStudentName.DisplayMember = "StudentFName";
            comboBoxStudentName.ValueMember = "StudentID";
            dataGridView4.Columns[1].Visible = false;



        }

        private void cmbDisplayGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (object o in Form1.StudentList.ToArray())
                {
                    string studentID = (((Student)o).StudentId);


                    if (studentID == this.comboBoxStudentName.SelectedValue.ToString())
                    {

                        ((Student)o).StudentGrade = (this.comboBox2.Text);

                        dataGridView3.DataSource = null;
                        dataGridView3.DataSource = Form1.StudentList;

                    }
                    else
                    {
                       
                    }


                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var stringLIst = new List<string> { };
            int sumOfGrades = 0;
            double groupGrade = 0;
            try
            {
                foreach(object group in Form1.GroupList)
                {
                    if (((Group)group).GroupId == cmbDisplayGroup2.SelectedValue.ToString())
                    {
                        foreach (object student in Form1.StudentList)
                        {
                            if (this.cmbDisplayGroup2.SelectedValue.ToString() == (((Student)student).GroupId))
                            {
                                sumOfGrades += Convert.ToInt32(((Student)student).StudentGrade);
                            }                            
                        }

                        groupGrade = sumOfGrades / ((Group)group).GroupSize;

                        ((Group)group).GroupGrade = groupGrade.ToString();

                    }
                }
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = Form1.GroupList;




            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //  catch (Exception ex) { MessageBox.Show(ex.ToString()); }

    }
}

