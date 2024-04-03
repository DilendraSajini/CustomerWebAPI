namespace CustomerWindow
{
    partial class Main_Window
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
            tabControl1 = new TabControl();
            customerList = new TabPage();
            button2 = new Button();
            label43 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label44 = new Label();
            dataGridView1 = new DataGridView();
            firstName = new DataGridViewTextBoxColumn();
            surName = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            birthDate = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            transactionNumber = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            postalCode = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            textBox43 = new TextBox();
            button1 = new Button();
            customerCreate = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            textBox29 = new TextBox();
            textBox30 = new TextBox();
            textBox31 = new TextBox();
            textBox32 = new TextBox();
            textBox33 = new TextBox();
            textBox34 = new TextBox();
            textBox35 = new TextBox();
            textBox36 = new TextBox();
            textBox37 = new TextBox();
            textBox38 = new TextBox();
            textBox39 = new TextBox();
            label41 = new Label();
            label42 = new Label();
            textBox40 = new TextBox();
            textBox41 = new TextBox();
            textBox42 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label1 = new Label();
            label12 = new Label();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            textBox24 = new TextBox();
            textBox25 = new TextBox();
            label27 = new Label();
            label28 = new Label();
            textBox26 = new TextBox();
            textBox27 = new TextBox();
            textBox28 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            customerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customerCreate.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(customerList);
            tabControl1.Controls.Add(customerCreate);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(971, 612);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            customerList.Controls.Add(button2);
            customerList.Controls.Add(label43);
            customerList.Controls.Add(dateTimePicker2);
            customerList.Controls.Add(dateTimePicker1);
            customerList.Controls.Add(radioButton2);
            customerList.Controls.Add(radioButton1);
            customerList.Controls.Add(label44);
            customerList.Controls.Add(dataGridView1);
            customerList.Controls.Add(textBox43);
            customerList.Controls.Add(button1);
            customerList.Location = new Point(4, 24);
            customerList.Name = "customerList";
            customerList.Padding = new Padding(3);
            customerList.Size = new Size(963, 584);
            customerList.TabIndex = 0;
            customerList.Text = "Customer List";
            customerList.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(123, 116);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(17, 63);
            label43.Name = "label43";
            label43.Size = new Size(58, 15);
            label43.TabIndex = 19;
            label43.Text = "Start Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(427, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(92, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(797, 121);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(683, 122);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(367, 63);
            label44.Name = "label44";
            label44.Size = new Size(54, 15);
            label44.TabIndex = 20;
            label44.Text = "End Date";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstName, surName, fullName, gender, birthDate, email, transactionNumber, phoneNumber, postalCode, address });
            dataGridView1.Location = new Point(17, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(929, 388);
            dataGridView1.TabIndex = 14;
            // 
            // firstName
            // 
            firstName.HeaderText = "First Name";
            firstName.Name = "firstName";
            // 
            // surName
            // 
            surName.HeaderText = "Sur Name";
            surName.Name = "surName";
            // 
            // fullName
            // 
            fullName.HeaderText = "Full Name";
            fullName.Name = "fullName";
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            // 
            // birthDate
            // 
            birthDate.HeaderText = "Birth Date";
            birthDate.Name = "birthDate";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // transactionNumber
            // 
            transactionNumber.HeaderText = "Transaction Number";
            transactionNumber.Name = "transactionNumber";
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Phone Number";
            phoneNumber.Name = "phoneNumber";
            // 
            // postalCode
            // 
            postalCode.HeaderText = "Postal Code";
            postalCode.Name = "postalCode";
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.Name = "address";
            // 
            // textBox43
            // 
            textBox43.Location = new Point(17, 117);
            textBox43.Name = "textBox43";
            textBox43.Size = new Size(100, 23);
            textBox43.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(871, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Sign out";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            customerCreate.Controls.Add(tableLayoutPanel3);
            customerCreate.Location = new Point(4, 24);
            customerCreate.Name = "customerCreate";
            customerCreate.Padding = new Padding(3);
            customerCreate.Size = new Size(963, 584);
            customerCreate.TabIndex = 1;
            customerCreate.Text = "Customer Create";
            customerCreate.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label29, 0, 13);
            tableLayoutPanel3.Controls.Add(label30, 0, 12);
            tableLayoutPanel3.Controls.Add(label31, 0, 10);
            tableLayoutPanel3.Controls.Add(label32, 0, 9);
            tableLayoutPanel3.Controls.Add(label33, 0, 8);
            tableLayoutPanel3.Controls.Add(label34, 0, 7);
            tableLayoutPanel3.Controls.Add(label35, 0, 6);
            tableLayoutPanel3.Controls.Add(label36, 0, 5);
            tableLayoutPanel3.Controls.Add(label37, 0, 4);
            tableLayoutPanel3.Controls.Add(label38, 0, 3);
            tableLayoutPanel3.Controls.Add(label39, 0, 2);
            tableLayoutPanel3.Controls.Add(label40, 0, 1);
            tableLayoutPanel3.Controls.Add(textBox29, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox30, 1, 1);
            tableLayoutPanel3.Controls.Add(textBox31, 1, 2);
            tableLayoutPanel3.Controls.Add(textBox32, 1, 3);
            tableLayoutPanel3.Controls.Add(textBox33, 1, 4);
            tableLayoutPanel3.Controls.Add(textBox34, 1, 5);
            tableLayoutPanel3.Controls.Add(textBox35, 1, 6);
            tableLayoutPanel3.Controls.Add(textBox36, 1, 7);
            tableLayoutPanel3.Controls.Add(textBox37, 1, 8);
            tableLayoutPanel3.Controls.Add(textBox38, 1, 9);
            tableLayoutPanel3.Controls.Add(textBox39, 1, 10);
            tableLayoutPanel3.Controls.Add(label41, 0, 0);
            tableLayoutPanel3.Controls.Add(label42, 0, 11);
            tableLayoutPanel3.Controls.Add(textBox40, 1, 11);
            tableLayoutPanel3.Controls.Add(textBox41, 1, 12);
            tableLayoutPanel3.Controls.Add(textBox42, 1, 13);
            tableLayoutPanel3.Location = new Point(150, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 14;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.Size = new Size(518, 565);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(3, 529);
            label29.Name = "label29";
            label29.Size = new Size(49, 15);
            label29.TabIndex = 24;
            label29.Text = "Address";
            label29.TextAlign = ContentAlignment.TopCenter;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(3, 487);
            label30.Name = "label30";
            label30.Size = new Size(70, 15);
            label30.TabIndex = 23;
            label30.Text = "Postal Code";
            label30.TextAlign = ContentAlignment.TopCenter;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(3, 411);
            label31.Name = "label31";
            label31.Size = new Size(44, 15);
            label31.TabIndex = 21;
            label31.Text = "District";
            label31.TextAlign = ContentAlignment.TopCenter;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(3, 367);
            label32.Name = "label32";
            label32.Size = new Size(36, 15);
            label32.TabIndex = 20;
            label32.Text = "Town";
            label32.TextAlign = ContentAlignment.TopCenter;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(3, 330);
            label33.Name = "label33";
            label33.Size = new Size(28, 15);
            label33.TabIndex = 19;
            label33.Text = "City";
            label33.TextAlign = ContentAlignment.TopCenter;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(3, 291);
            label34.Name = "label34";
            label34.Size = new Size(88, 15);
            label34.TabIndex = 18;
            label34.Text = "Phone Number";
            label34.TextAlign = ContentAlignment.TopCenter;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(3, 256);
            label35.Name = "label35";
            label35.Size = new Size(115, 15);
            label35.TabIndex = 17;
            label35.Text = "Transaction Number";
            label35.TextAlign = ContentAlignment.TopCenter;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(3, 218);
            label36.Name = "label36";
            label36.Size = new Size(36, 15);
            label36.TabIndex = 16;
            label36.Text = "Email";
            label36.TextAlign = ContentAlignment.TopCenter;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(3, 180);
            label37.Name = "label37";
            label37.Size = new Size(59, 15);
            label37.TabIndex = 15;
            label37.Text = "Birth Date";
            label37.TextAlign = ContentAlignment.TopCenter;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(3, 142);
            label38.Name = "label38";
            label38.Size = new Size(45, 15);
            label38.TabIndex = 14;
            label38.Text = "Gender";
            label38.TextAlign = ContentAlignment.TopCenter;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(3, 94);
            label39.Name = "label39";
            label39.Size = new Size(61, 15);
            label39.TabIndex = 13;
            label39.Text = "Full Name";
            label39.TextAlign = ContentAlignment.TopCenter;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(3, 47);
            label40.Name = "label40";
            label40.Size = new Size(54, 15);
            label40.TabIndex = 12;
            label40.Text = "Surname";
            label40.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox29
            // 
            textBox29.Location = new Point(262, 3);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(253, 23);
            textBox29.TabIndex = 0;
            // 
            // textBox30
            // 
            textBox30.Location = new Point(262, 50);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(253, 23);
            textBox30.TabIndex = 1;
            // 
            // textBox31
            // 
            textBox31.Location = new Point(262, 97);
            textBox31.Name = "textBox31";
            textBox31.Size = new Size(253, 23);
            textBox31.TabIndex = 2;
            // 
            // textBox32
            // 
            textBox32.Location = new Point(262, 145);
            textBox32.Name = "textBox32";
            textBox32.Size = new Size(253, 23);
            textBox32.TabIndex = 3;
            // 
            // textBox33
            // 
            textBox33.Location = new Point(262, 183);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(253, 23);
            textBox33.TabIndex = 4;
            // 
            // textBox34
            // 
            textBox34.Location = new Point(262, 221);
            textBox34.Name = "textBox34";
            textBox34.Size = new Size(253, 23);
            textBox34.TabIndex = 6;
            // 
            // textBox35
            // 
            textBox35.Location = new Point(262, 259);
            textBox35.Name = "textBox35";
            textBox35.Size = new Size(253, 23);
            textBox35.TabIndex = 5;
            // 
            // textBox36
            // 
            textBox36.Location = new Point(262, 294);
            textBox36.Name = "textBox36";
            textBox36.Size = new Size(253, 23);
            textBox36.TabIndex = 7;
            // 
            // textBox37
            // 
            textBox37.Location = new Point(262, 333);
            textBox37.Name = "textBox37";
            textBox37.Size = new Size(253, 23);
            textBox37.TabIndex = 8;
            // 
            // textBox38
            // 
            textBox38.Location = new Point(262, 370);
            textBox38.Name = "textBox38";
            textBox38.Size = new Size(253, 23);
            textBox38.TabIndex = 9;
            // 
            // textBox39
            // 
            textBox39.Location = new Point(262, 414);
            textBox39.Name = "textBox39";
            textBox39.Size = new Size(253, 23);
            textBox39.TabIndex = 10;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(3, 0);
            label41.Name = "label41";
            label41.Size = new Size(64, 15);
            label41.TabIndex = 11;
            label41.Text = "First Name";
            label41.TextAlign = ContentAlignment.TopCenter;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(3, 448);
            label42.Name = "label42";
            label42.Size = new Size(37, 15);
            label42.TabIndex = 22;
            label42.Text = "Street";
            label42.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox40
            // 
            textBox40.Location = new Point(262, 451);
            textBox40.Name = "textBox40";
            textBox40.Size = new Size(253, 23);
            textBox40.TabIndex = 25;
            // 
            // textBox41
            // 
            textBox41.Location = new Point(262, 490);
            textBox41.Name = "textBox41";
            textBox41.Size = new Size(253, 23);
            textBox41.TabIndex = 26;
            // 
            // textBox42
            // 
            textBox42.Location = new Point(262, 532);
            textBox42.Name = "textBox42";
            textBox42.Size = new Size(253, 23);
            textBox42.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 24;
            label14.Text = "Address";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 23;
            label13.Text = "Postal Code";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 21;
            label11.Text = "District";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 20;
            label10.Text = "Town";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 19;
            label9.Text = "City";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 18;
            label8.Text = "Phone Number";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 30);
            label7.TabIndex = 17;
            label7.Text = "Transaction Number";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 16;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 15;
            label5.Text = "Birth Date";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 14;
            label4.Text = "Gender";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 13;
            label3.Text = "Full Name";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 12;
            label2.Text = "Surname";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(103, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(94, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(103, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(94, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(103, 148);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(94, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(103, 177);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(94, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(103, 207);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(94, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(103, 236);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(94, 23);
            textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(103, 265);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(94, 23);
            textBox10.TabIndex = 9;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(103, 294);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(94, 23);
            textBox11.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 320);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 22;
            label12.Text = "Street";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(103, 323);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(94, 23);
            textBox12.TabIndex = 25;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(103, 352);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(94, 23);
            textBox13.TabIndex = 26;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(103, 381);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(94, 23);
            textBox14.TabIndex = 27;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label14, 0, 13);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 260);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 24;
            label15.Text = "Address";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 23;
            label16.Text = "Postal Code";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 21;
            label17.Text = "District";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 0);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 20;
            label18.Text = "Town";
            label18.TextAlign = ContentAlignment.TopCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 19;
            label19.Text = "City";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 0);
            label20.Name = "label20";
            label20.Size = new Size(88, 15);
            label20.TabIndex = 18;
            label20.Text = "Phone Number";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(68, 30);
            label21.TabIndex = 17;
            label21.Text = "Transaction Number";
            label21.TextAlign = ContentAlignment.TopCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(3, 0);
            label22.Name = "label22";
            label22.Size = new Size(36, 15);
            label22.TabIndex = 16;
            label22.Text = "Email";
            label22.TextAlign = ContentAlignment.TopCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(3, 0);
            label23.Name = "label23";
            label23.Size = new Size(59, 15);
            label23.TabIndex = 15;
            label23.Text = "Birth Date";
            label23.TextAlign = ContentAlignment.TopCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(3, 0);
            label24.Name = "label24";
            label24.Size = new Size(45, 15);
            label24.TabIndex = 14;
            label24.Text = "Gender";
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(3, 0);
            label25.Name = "label25";
            label25.Size = new Size(61, 15);
            label25.TabIndex = 13;
            label25.Text = "Full Name";
            label25.TextAlign = ContentAlignment.TopCenter;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(3, 0);
            label26.Name = "label26";
            label26.Size = new Size(54, 15);
            label26.TabIndex = 12;
            label26.Text = "Surname";
            label26.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(103, 3);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(94, 23);
            textBox15.TabIndex = 0;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(103, 32);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(94, 23);
            textBox16.TabIndex = 1;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(103, 61);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(94, 23);
            textBox17.TabIndex = 2;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(103, 90);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(94, 23);
            textBox18.TabIndex = 3;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(103, 119);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(94, 23);
            textBox19.TabIndex = 4;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(103, 148);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(94, 23);
            textBox20.TabIndex = 6;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(103, 177);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(94, 23);
            textBox21.TabIndex = 5;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(103, 207);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(94, 23);
            textBox22.TabIndex = 7;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(103, 236);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(94, 23);
            textBox23.TabIndex = 8;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(103, 265);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(94, 23);
            textBox24.TabIndex = 9;
            // 
            // textBox25
            // 
            textBox25.Location = new Point(103, 294);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(94, 23);
            textBox25.TabIndex = 10;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(3, 0);
            label27.Name = "label27";
            label27.Size = new Size(64, 15);
            label27.TabIndex = 11;
            label27.Text = "First Name";
            label27.TextAlign = ContentAlignment.TopCenter;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(3, 320);
            label28.Name = "label28";
            label28.Size = new Size(37, 15);
            label28.TabIndex = 22;
            label28.Text = "Street";
            label28.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox26
            // 
            textBox26.Location = new Point(103, 323);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(94, 23);
            textBox26.TabIndex = 25;
            // 
            // textBox27
            // 
            textBox27.Location = new Point(103, 352);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(94, 23);
            textBox27.TabIndex = 26;
            // 
            // textBox28
            // 
            textBox28.Location = new Point(103, 381);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(94, 23);
            textBox28.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label15, 0, 13);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 14;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Main_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 636);
            Controls.Add(tabControl1);
            Name = "Main_Window";
            Text = "Main_Window";
            Load += Main_Window_Load;
            tabControl1.ResumeLayout(false);
            customerList.ResumeLayout(false);
            customerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customerCreate.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage customerList;
        private TabPage customerCreate;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private TextBox textBox29;
        private TextBox textBox30;
        private TextBox textBox31;
        private TextBox textBox32;
        private TextBox textBox33;
        private TextBox textBox34;
        private TextBox textBox35;
        private TextBox textBox36;
        private TextBox textBox37;
        private TextBox textBox38;
        private TextBox textBox39;
        private Label label41;
        private Label label42;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox42;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label1;
        private Label label12;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private Label label27;
        private Label label28;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox28;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private Label label43;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label44;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn surName;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn birthDate;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn transactionNumber;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn postalCode;
        private DataGridViewTextBoxColumn address;
        private TextBox textBox43;
        private Button button1;
    }
}