using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAssign_lijing
{
    public partial class Form1 : Form
    {
        List<MyClass> staffs = new List<MyClass>();//global staffs
        private List<MyClass> newlist;

        public MessageBoxIcon YesNo { get; private set; }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//return valiad
        {
            staffs.Clear();
            FileManager fm = new FileManager();
            staffs = fm.LoadMyClass();
            if(staffs == null)
            {
                MessageBox.Show("Error loading staffList", "File IO Error");
            }
            else
            {
                lbxMyClass.Items.Clear();
                lbxMyClass.Items.AddRange(staffs.ToArray());//dispaly
            }
            
        }

        private void dateOfBirthToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void amualSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Asc_Click(object sender, EventArgs e)//return valiad
        {
            Filter sFilter = new Filter();
            staffs = sFilter.SortNum(staffs);// call different metod
            lbxMyClass.Items.Clear();
            lbxMyClass.Items.AddRange(staffs.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)//return valiad
        {
            List<MyClass> results = new List<MyClass>();
            Filter sFilter = new Filter();
            string term = tbxSearch.Text;

            lbxSearchResults.Items.Clear();
            lbxSearchResults.Items.AddRange(sFilter.Search(staffs, term).ToArray());
            //lbxSearchResults.Items.AddRange(staffs.ToArray());


        }

        private void lbxMyClass_SelectedIndexChanged(object sender, EventArgs e)//return valiad
        {

        }

        private void SortAZ_Click(object sender, EventArgs e)
        {
            Filter sFilter = new Filter();
            staffs = sFilter.SortAZ(staffs);//call th method
            lbxMyClass.Items.Clear();
            lbxMyClass.Items.AddRange(staffs.ToArray());
        }

        private void lbxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MyClass s = (MyClass)lbxSearchResults.SelectedItem;
                tbxID.Text = s.StaffID.ToString();
                tbxname.Text = s.Name;
                tbxage.Text = s.Birthday.ToString();
                tbxemail.Text = s.Email;
                tbxmoney.Text = s.Salary.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
              
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }
        // Add  button 
        private void button1_Click_1(object sender, EventArgs e)  
        {

            if (tbxID.Text == String.Empty||tbxmoney.Text ==String.Empty) // I will limit the empty Num which can't go on 
            {
                MessageBox.Show("Please input the num ");
            }
            else
            {
                MyClass addList = new MyClass();

                addList.StaffID = int.Parse(tbxID.Text);
                addList.Name = tbxname.Text;
                addList.Birthday = tbxage.Text;
                addList.Email = tbxemail.Text;
                addList.Salary = int.Parse(tbxmoney.Text);

                staffs.Add(addList);
                lbxMyClass.Items.Clear();
                lbxMyClass.Items.AddRange(staffs.ToArray());
            }
                



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyClass removeList = new MyClass();

            MyClass r = (MyClass)lbxMyClass.SelectedItem;

            staffs.Remove(r);

            lbxMyClass.Items.Clear();
            lbxMyClass.Items.AddRange(staffs.ToArray());
        }  // Remoce button


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            fm.SaveMyClass(staffs);
            MessageBox.Show("Data being successfully saved in a Text File");
        }

        private void staffInformationManagementTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // save to binary File 
        private void button1_Click_2(object sender, EventArgs e)
        {
            bool saveSucccess = false;
            FileManager SBF = new FileManager();
            saveSucccess = SBF.saveToBinary(staffs);//nzlist? or newlist? or staffs?

            if (saveSucccess == true)
            {
                MessageBox.Show("Data being successfully saved in a Binary File");
                lbxMyClass.Items.Clear();
                //staffs.Clear();
            }
            else
            {
                MessageBox.Show("Error in saving Binary");
            }
        }

        private void btnOpenBin_Click(object sender, EventArgs e)
        {
            FileManager OPB = new FileManager();
            staffs = OPB.openBinaryFile();
            DisPlayListobjOnListBox();

        }

        private void DisPlayListobjOnListBox()
        {
            lbxMyClass.Items.Clear();
            lbxMyClass.Items.AddRange(staffs.ToArray());
        }
    }
}
