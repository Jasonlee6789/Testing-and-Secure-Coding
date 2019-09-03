namespace TestAssign_lijing
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
            this.components = new System.ComponentModel.Container();
            this.btnload = new System.Windows.Forms.Button();
            this.SortNum = new System.Windows.Forms.Button();
            this.lbxMyClass = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffInformationManagementTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateOfBirthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amualSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.SortAZ = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxmoney = new System.Windows.Forms.TextBox();
            this.btnSaveBin = new System.Windows.Forms.Button();
            this.btnOpenBin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(32, 41);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load";
            this.toolTip1.SetToolTip(this.btnload, "Loads a list of MyClass");
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.button1_Click);
            // 
            // SortNum
            // 
            this.SortNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortNum.Location = new System.Drawing.Point(238, 41);
            this.SortNum.Name = "SortNum";
            this.SortNum.Size = new System.Drawing.Size(75, 23);
            this.SortNum.TabIndex = 2;
            this.SortNum.Text = "SortNum";
            this.toolTip1.SetToolTip(this.SortNum, "Ascending the Num of Salary ");
            this.SortNum.UseVisualStyleBackColor = true;
            this.SortNum.Click += new System.EventHandler(this.Asc_Click);
            // 
            // lbxMyClass
            // 
            this.lbxMyClass.FormattingEnabled = true;
            this.lbxMyClass.Location = new System.Drawing.Point(32, 73);
            this.lbxMyClass.Name = "lbxMyClass";
            this.lbxMyClass.Size = new System.Drawing.Size(329, 342);
            this.lbxMyClass.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lbxMyClass, "Display a list of staff information");
            this.lbxMyClass.SelectedIndexChanged += new System.EventHandler(this.lbxMyClass_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffInformationManagementTableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffInformationManagementTableToolStripMenuItem
            // 
            this.staffInformationManagementTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffIDToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.dateOfBirthToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.amualSalaryToolStripMenuItem});
            this.staffInformationManagementTableToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffInformationManagementTableToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.staffInformationManagementTableToolStripMenuItem.Name = "staffInformationManagementTableToolStripMenuItem";
            this.staffInformationManagementTableToolStripMenuItem.Size = new System.Drawing.Size(462, 34);
            this.staffInformationManagementTableToolStripMenuItem.Text = "lijing-Staff Information Management Table";
            this.staffInformationManagementTableToolStripMenuItem.Click += new System.EventHandler(this.staffInformationManagementTableToolStripMenuItem_Click);
            // 
            // staffIDToolStripMenuItem
            // 
            this.staffIDToolStripMenuItem.Name = "staffIDToolStripMenuItem";
            this.staffIDToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.staffIDToolStripMenuItem.Text = "Staff-ID";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // dateOfBirthToolStripMenuItem
            // 
            this.dateOfBirthToolStripMenuItem.Name = "dateOfBirthToolStripMenuItem";
            this.dateOfBirthToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.dateOfBirthToolStripMenuItem.Text = "Date of birth";
            this.dateOfBirthToolStripMenuItem.Click += new System.EventHandler(this.dateOfBirthToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // amualSalaryToolStripMenuItem
            // 
            this.amualSalaryToolStripMenuItem.Name = "amualSalaryToolStripMenuItem";
            this.amualSalaryToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.amualSalaryToolStripMenuItem.Text = "Annual Salary";
            this.amualSalaryToolStripMenuItem.Click += new System.EventHandler(this.amualSalaryToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(526, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.btnSearch, "Search by the alphabet");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SortAZ
            // 
            this.SortAZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortAZ.Location = new System.Drawing.Point(130, 41);
            this.SortAZ.Name = "SortAZ";
            this.SortAZ.Size = new System.Drawing.Size(75, 23);
            this.SortAZ.TabIndex = 6;
            this.SortAZ.Text = "AZ";
            this.toolTip1.SetToolTip(this.SortAZ, "Order by the alphabet");
            this.SortAZ.UseVisualStyleBackColor = true;
            this.SortAZ.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(657, 357);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.toolTip1.SetToolTip(this.Add, "Add the selected to the MyClass");
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(657, 387);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 20;
            this.Remove.Text = "Remove";
            this.toolTip1.SetToolTip(this.Remove, "Remove the seleceted from MyClass");
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save to Text File";
            this.toolTip1.SetToolTip(this.btnSave, "Save the new list to MyClass");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(368, 43);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(127, 20);
            this.tbxSearch.TabIndex = 7;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.Location = new System.Drawing.Point(367, 73);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(281, 342);
            this.lbxSearchResults.TabIndex = 8;
            this.lbxSearchResults.SelectedIndexChanged += new System.EventHandler(this.lbxSearchResults_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Staff ID:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(657, 93);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 20);
            this.tbxID.TabIndex = 10;
            this.tbxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(657, 137);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(100, 20);
            this.tbxname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date of birth:";
            // 
            // tbxage
            // 
            this.tbxage.Location = new System.Drawing.Point(657, 187);
            this.tbxage.Name = "tbxage";
            this.tbxage.Size = new System.Drawing.Size(100, 20);
            this.tbxage.TabIndex = 14;
            this.tbxage.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // tbxemail
            // 
            this.tbxemail.Location = new System.Drawing.Point(657, 250);
            this.tbxemail.Name = "tbxemail";
            this.tbxemail.Size = new System.Drawing.Size(100, 20);
            this.tbxemail.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Annual Salary:";
            // 
            // tbxmoney
            // 
            this.tbxmoney.Location = new System.Drawing.Point(657, 316);
            this.tbxmoney.Name = "tbxmoney";
            this.tbxmoney.Size = new System.Drawing.Size(100, 20);
            this.tbxmoney.TabIndex = 18;
            // 
            // btnSaveBin
            // 
            this.btnSaveBin.Location = new System.Drawing.Point(182, 421);
            this.btnSaveBin.Name = "btnSaveBin";
            this.btnSaveBin.Size = new System.Drawing.Size(179, 23);
            this.btnSaveBin.TabIndex = 22;
            this.btnSaveBin.Text = "Save to Binary File";
            this.btnSaveBin.UseVisualStyleBackColor = true;
            this.btnSaveBin.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnOpenBin
            // 
            this.btnOpenBin.Location = new System.Drawing.Point(383, 420);
            this.btnOpenBin.Name = "btnOpenBin";
            this.btnOpenBin.Size = new System.Drawing.Size(170, 23);
            this.btnOpenBin.TabIndex = 23;
            this.btnOpenBin.Text = "Open from Binary file";
            this.btnOpenBin.UseVisualStyleBackColor = true;
            this.btnOpenBin.Click += new System.EventHandler(this.btnOpenBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenBin);
            this.Controls.Add(this.btnSaveBin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.tbxmoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxSearchResults);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.SortAZ);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbxMyClass);
            this.Controls.Add(this.SortNum);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button SortNum;
        private System.Windows.Forms.ListBox lbxMyClass;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffInformationManagementTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateOfBirthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amualSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button SortAZ;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxmoney;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveBin;
        private System.Windows.Forms.Button btnOpenBin;
    }
}

