using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //Arraylist Declaration to store all the students and groups, they participate in
        public static ArrayList StudentList = new ArrayList();
        public static ArrayList GroupList = new ArrayList();
        
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initilize employees for testing purpose
            for (int i = 0; i < 3; i++)
            {
                //initialise the array with numberOfEmployees Employee object
                StudentList.Add(new Student((i + 1).ToString())); //this is because emptId is declared as string
            }

            // binding the datagrid to the arraylist
            dataGridView1.DataSource = StudentList;

            //initilize groups for testing purpose
            for (int i = 0; i < 4; i++)
            {
                //initialise the array with numberOfDepartments Depertment object
                GroupList.Add(new Group((i + 1).ToString())); //this is because DeptId is declared as string
                ((Group)GroupList[i]).GroupName = "Group no. " + (i + 1);
            }

            //set the combobox datasource to the dept arraylist
            cmbDisplayGroup.DataSource = GroupList;
            cmbDisplayGroup.DisplayMember = "GroupName";
            cmbDisplayGroup.ValueMember = "GroupId";

            
            cmbBoxGroupID.DataSource = GroupList;
            cmbBoxGroupID.DisplayMember = "GroupName";
            cmbBoxGroupID.ValueMember = "GroupId";
        }

        //add a new employee to the dataGrideView
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                //check the new empID - must be unique
                foreach (object o in StudentList.ToArray())
                {
                    string studentID = (((Student)o).StudentId);

                    //if found an existing employee with the same ID
                    if (studentID == this.txtStudentID.Text)
                    {
                        // Initializes the variables to pass to the MessageBox.Show method. 

                        string message = "An student with ID = " + studentID + " already exists!\n Do you really want to update this employee's record with new details";
                        string caption = "Employee already exists!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.

                        result = MessageBox.Show(message, caption, buttons);

                        if (result == DialogResult.Yes)
                        {
                            // update the employee record
                            ((Student)o).StudentId = this.txtStudentID.Text;
                            ((Student)o).StudentFName = this.txtStudentFName.Text;
                            ((Student)o).StudentLName = this.txtStudentLName.Text;
                            ((Student)o).StudentStatus = this.checkBoxFulltime.Checked;

                            foreach (object group in GroupList)
                            {
                                string groupID = (((Group)group).GroupId).ToUpper();

                                //Enter the group which is selected in the combo box by comparing the ID of the group object and the selected ID from the View
                                if (groupID == new String((this.cmbBoxGroupID.Text).Where(Char.IsDigit).ToArray()) && ((Student)o).GroupId != this.cmbBoxGroupID.SelectedValue.ToString())
                                {
                                    if (((Group)group).GroupSize < 4)
                                    {
                                        //Assign the student with the group value
                                        ((Student)o).GroupId = this.cmbBoxGroupID.SelectedValue.ToString();

                                        //Update the group size
                                        ((Group)group).GroupSize += 1;

                                        

                                        UpdateGroup(this.cmbDisplayGroup);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Group is full.");
                                    }
                                }
                            }

                            MessageBox.Show(((Student)o).StudentFName + " record has been updated with new details, except the ID.");

                            UpdateStudentList();

                            return;

                        }

                    }

                    else
                    { 
                        if (o == StudentList[StudentList.Count-1]) {
                            foreach (object group in GroupList)
                            {
                                string groupID = (((Group)group).GroupId).ToUpper();
                                if (groupID.CompareTo(new String((this.cmbBoxGroupID.Text).Where(Char.IsDigit).ToArray())) == 0)
                                {
                                    if (((Group)group).GroupSize < 4)
                                    {
                                        // the value of the entered employee ID in the textbox is new
                                        //create a new Employee object

                                        Student student = new Student(this.txtStudentID.Text)
                                        {
                                            StudentId = this.txtStudentID.Text,
                                            StudentFName = this.txtStudentFName.Text,
                                            StudentLName = this.txtStudentLName.Text,
                                            StudentStatus = this.checkBoxFulltime.Checked,
                                            GroupId = this.cmbBoxGroupID.SelectedValue.ToString()
                                        };

                                        StudentList.Add(student);
                                        MessageBox.Show(student.StudentFName + " " + student.StudentLName + " has been added to the employee list");

                                        UpdateStudentList();
                                        UpdateGroup(this.cmbDisplayGroup);

                                        return;
                                    }

                                    else
                                    {
                                        MessageBox.Show("Group is full.");
                                    }
                                }
                            }
                        }
                        continue;
                        
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Whoopsie!"); 
            }

        } 


        


        //serialization (save to file)
        private void button2_Click(object sender, EventArgs e)
        {
            //code below is for serialization

            // Open a file and serialize the object into it in binary format.
            // EmployeeDetails.dat is the file that we are creating. 
            // Note:- you can give any extension you want for your file
            // If you use custom extensions, then the user will now 
            //   that the file is associated with your program.
            Stream stream = File.Open("StudentDetails.dat", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, StudentList);
            stream.Close();

            //save department details
            stream = File.Open("GroupDetails.dat", FileMode.Create);
            bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, GroupList);
            stream.Close();

            MessageBox.Show("Students and Departments Data saved to file");
        }

        //de-serialization (retrieve from file)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //Open the file written above and read values from it.
                Stream stream = File.Open("StudentDetails.dat", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

                //Reading Employee Information
                StudentList = (ArrayList)bformatter.Deserialize(stream);

                stream.Close();

                UpdateStudentList();


                //Open the file written above and read values from it.
                stream = File.Open("GroupDetails.dat", FileMode.Open);
                bformatter = new BinaryFormatter();

                //Reading Department Information
                GroupList = (ArrayList)bformatter.Deserialize(stream);

                stream.Close();

                //refresh the combobox of departments
                cmbDisplayGroup.DataSource = null;
                cmbDisplayGroup.DataSource = GroupList;
                cmbDisplayGroup.DisplayMember = "GroupName";
                cmbDisplayGroup.ValueMember = "GroupId";

                MessageBox.Show("Student & Department Data retrieved from file");
                
            }
         
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ERROR reading file!"); }

            foreach (object student in StudentList)
            {
                foreach (object group in GroupList)
                {
                    if (((Student)student).GroupId == (((Group)group).GroupId)) {
                        ((Group)group).GroupSize++;

                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;
        }


        //terminate the application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSortByEmpName_Click(object sender, EventArgs e)
        {
            StudentList.Sort();            
            UpdateStudentList();
        }

        //sort by sort of numeric value using IComparer.
        private void buttonSortByEmpID_Click(object sender, EventArgs e)
        {
            
                StudentList.Sort(Student.sortByStudentID());
            UpdateStudentList();
        }

        //add and update departments
        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
          
           
            //validate the new deptID - must be unique
                foreach (object o in GroupList)
                {
                    string groupID = (((Group)o).GroupId).ToUpper();

                    //if found an existing employee with the same ID
                    if (groupID.CompareTo((this.txtGroupID.Text).ToUpper()) == 0)
                    {

                        // Initializes the variables to pass to the MessageBox.Show method. 

                        string message = "A department with ID = " + groupID + " already exists!\n Do you really want to update this department's record with new details";
                        string caption = "Department already exists!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.

                        result = MessageBox.Show(message, caption, buttons);

                        if (result == DialogResult.Yes)
                        {
                            // update the employee record

                            ((Group)o).GroupName = this.txtGroupName.Text;
                            MessageBox.Show(((Group)o).GroupId + " record has been updated with new details, except the deptID.");

                            UpdateGroup(this.cmbDisplayGroup);

                            cmbDisplayGroup.DataSource = null;
                            cmbDisplayGroup.DataSource = GroupList;
                            cmbDisplayGroup.DisplayMember = "GroupName";
                            cmbDisplayGroup.ValueMember = "GroupId";
                        }
                        else
                        {
                            // the value of the entered deptId in the textbox is new

                            //create a new Department object
                            Group newGroup = new Group(this.txtGroupID.Text);
                            newGroup.GroupName = this.txtGroupName.Text;
                            GroupList.Add(newGroup);

                            MessageBox.Show(newGroup.GroupName + " department has been created");

                            //refresh the combobox
                            dataGridView2.DataSource = null;
                            dataGridView2.DataSource = GroupList;

                            cmbDisplayGroup.DataSource = null;
                            cmbDisplayGroup.DataSource = GroupList;
                            cmbDisplayGroup.DisplayMember = "GroupName";
                            cmbDisplayGroup.ValueMember = "GroupId";
                        }

                        return;
                    }
                }
            


        }
     


        //display the content of the selected row of the datagrid in the textboxes
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Initializes the variables to pass to the messageBox.Show method

            string message = "Do you want to replace the current data?";
            string caption = "Import from CSV file";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Display the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result != System.Windows.Forms.DialogResult.Yes) //the user click no
            {
                return;
            }

            //The user click yes

            //Delete the current data in the EmployeeList arraylist
            StudentList.Clear();

            //import from employee.csv file located in the bin/debuh folder within the project folder

            string CSVFileName = "employees.csv";

            string csvData = "";

            //read from file into a string 
            using (StreamReader oStreamReader = new StreamReader(File.OpenRead(CSVFileName)))
            {
                csvData = oStreamReader.ReadToEnd();
            }
            //parse the string csvData to object collection

            string[] rows = csvData.Replace("\r", "").Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row)) continue;

                string[] cols = row.Split(',');

                //Instantiate a new Employee object to store the row to import
                Student empObj = new Student("");

                //the employee csv file has 3 columns, which contain empId, empName and employment status
               
                    empObj.StudentId = cols[0];
                empObj.StudentFName = cols[1];
                empObj.StudentLName = cols[2];
                empObj.StudentStatus = Boolean.Parse(cols[3]);
             
                
                //True or False to boolean value
                foreach (Group group in GroupList)
                {
                    if (group.GroupId == empObj.GroupId)
                    {
                        group.GroupSize += 1;
                    }
                }
                StudentList.Add(empObj);

            }

            UpdateStudentList();

            //reset the textboxes
            this.txtStudentID.Text = "";
            this.txtStudentFName.Text = "";
            this.txtStudentLName.Text = "";
            this.cmbBoxGroupID.SelectedValue = 0;
            this.checkBoxFulltime.Checked = false;
        
        }
        //bulk-assign employees to new departments
        private void button3_Click_1(object sender, EventArgs e)
        {
            //declare an arraylist to store the employees who are not in any department
            ArrayList employeeWithoutDept = new ArrayList(); 

            foreach (object obj in StudentList)
            {
                string str = (((Student)obj).GroupId);

                if (str == null || str.Trim()== "")
                    employeeWithoutDept.Add((Student)obj);

            }
            int numOfEmpRemaining = employeeWithoutDept.Count;

            // Initializes the variables to pass to the MessageBox.Show method.

            string message = numOfEmpRemaining + "employees with no department" + "\nDo you want to execute bulk-assignment?";
            string caption = "Bulk-Assign";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Display the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            //bulk assign
            if (result == DialogResult.Yes)
            {
                const int maxPerGroup = 4;
                const int minPerGroup = 2;

                int numberOfRequiredGroups = (numOfEmpRemaining + maxPerGroup - 1) / maxPerGroup;
                int remainder = numOfEmpRemaining % maxPerGroup;

                int autoGroupCount = 0;
                int memberCount = 0;
                string newGroupId = "";
                
               

                //traversing thru the arraylist of the employees without dept, creating new groups to assign them to
                foreach (object obj in employeeWithoutDept)
                {

                    if (memberCount == 0) // then create new group
                    {
                        //create a new Department object
                        autoGroupCount++;
                        newGroupId = txtGroupIDPrefix.Text + autoGroupCount;
                        Group newGroup = new Group(newGroupId);
                       

                        newGroup.GroupName = txtGroupIDPrefix.Text + autoGroupCount;
                        GroupList.Add(newGroup);
                        
                    }

                    //assign employee to the newly created dept
                    ((Student)obj).GroupId = newGroupId;
                    memberCount++;
                    // current number of members in group with ID =newGroupID
                    
                    //simplistic solution but the last group may have only one member
                    //if (memberCount == maxPerGroup)
                    //{
                    // memberCount = 0;
                    //}

                    //better solution
                    if ((numberOfRequiredGroups > 1 && remainder > 0 && autoGroupCount ==1 && memberCount == Math.Max(remainder,minPerGroup)) || (memberCount == maxPerGroup))
                    {
                        //reset group members count to create another new group
                        memberCount = 0;
                    }

                }

                UpdateStudentList();
                UpdateGroup(cmbDisplayGroup);
                cmbDisplayGroup.DisplayMember = "GroupName";
                cmbDisplayGroup.ValueMember = "GroupID";

                //refresh the combobox
                cmbDisplayGroup.DataSource = null;
                cmbDisplayGroup.DataSource = GroupList;
                cmbDisplayGroup.DisplayMember = "GroupName";
                cmbDisplayGroup.ValueMember = "GroupId";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void UpdateGroup(ComboBox comboBox)
        {
            //display the students in the selected group

            if (comboBox.SelectedValue != null)
            {
                string selGroup = comboBox.SelectedValue.ToString();

                ArrayList GroupStaff = new ArrayList();

                foreach (object obj in StudentList)
                {
                    string GroupID = (((Student)obj).GroupId);

                    if (GroupID.CompareTo(selGroup) == 0)
                        GroupStaff.Add((Student)obj);
                }

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = GroupStaff;
            }
        }

        public void UpdateStudentList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;
        }

        private void btnUpdateGroupTable_Click(object sender, EventArgs e)
        {
            UpdateGroup(this.cmbDisplayGroup);
        }

        private void cmbDisplayGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 temp = new Form2();
           
            this.Hide();           //Hide the main form before showing the secondary
            temp.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();           //When frm2 is closed, continue with the code (show main form)


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
