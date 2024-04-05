namespace RestaurantFrontEnd
{
    partial class RestaurantsMainWindow
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
            mainWindow = new TabControl();
            customerList = new TabPage();
            search = new Button();
            endDate = new Label();
            startDate = new Label();
            dateTimePickerEndDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            dataGridView = new DataGridView();
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
            searchText = new TextBox();
            signOut = new Button();
            createCustomer = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            addressLabel = new Label();
            postalCodeLabel = new Label();
            districtLabel = new Label();
            townLabel = new Label();
            cityLabel = new Label();
            phoneNumberLabel = new Label();
            transactionNumberLabel = new Label();
            emailLabel = new Label();
            birthDateLabel = new Label();
            genderLabel = new Label();
            fullNameLabel = new Label();
            surnameLabel = new Label();
            firstNameText = new TextBox();
            surNameText = new TextBox();
            fullNameText = new TextBox();
            genderText = new TextBox();
            birthDateText = new TextBox();
            emailText = new TextBox();
            transactionNumberText = new TextBox();
            phoneNumberText = new TextBox();
            cityText = new TextBox();
            towntext = new TextBox();
            districtText = new TextBox();
            firstnameLabel = new Label();
            streetLabel = new Label();
            streetText = new TextBox();
            postalCodeText = new TextBox();
            addressText = new TextBox();
            mainWindow.SuspendLayout();
            customerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            createCustomer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainWindow
            // 
            mainWindow.Controls.Add(customerList);
            mainWindow.Controls.Add(createCustomer);
            mainWindow.Location = new Point(12, 12);
            mainWindow.Name = "mainWindow";
            mainWindow.SelectedIndex = 0;
            mainWindow.Size = new Size(984, 588);
            mainWindow.TabIndex = 0;
            // 
            // customerList
            // 
            customerList.Controls.Add(search);
            customerList.Controls.Add(endDate);
            customerList.Controls.Add(startDate);
            customerList.Controls.Add(dateTimePickerEndDate);
            customerList.Controls.Add(dateTimePickerStartDate);
            customerList.Controls.Add(radioButtonFemale);
            customerList.Controls.Add(radioButtonMale);
            customerList.Controls.Add(dataGridView);
            customerList.Controls.Add(searchText);
            customerList.Controls.Add(signOut);
            customerList.Location = new Point(4, 24);
            customerList.Name = "customerList";
            customerList.Padding = new Padding(3);
            customerList.Size = new Size(976, 560);
            customerList.TabIndex = 0;
            customerList.Text = "Customer List";
            customerList.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            search.Location = new Point(129, 102);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 21;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.Location = new Point(373, 49);
            endDate.Name = "endDate";
            endDate.Size = new Size(54, 15);
            endDate.TabIndex = 20;
            endDate.Text = "End Date";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(23, 49);
            startDate.Name = "startDate";
            startDate.Size = new Size(58, 15);
            startDate.TabIndex = 19;
            startDate.Text = "Start Date";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(433, 43);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(200, 23);
            dateTimePickerEndDate.TabIndex = 18;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(98, 43);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(200, 23);
            dateTimePickerStartDate.TabIndex = 17;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(803, 107);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 16;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(689, 108);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { firstName, surName, fullName, gender, birthDate, email, transactionNumber, phoneNumber, postalCode, address });
            dataGridView.Location = new Point(23, 151);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(929, 388);
            dataGridView.TabIndex = 14;
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
            // searchText
            // 
            searchText.Location = new Point(23, 103);
            searchText.Name = "searchText";
            searchText.Size = new Size(100, 23);
            searchText.TabIndex = 13;
            // 
            // signOut
            // 
            signOut.Location = new Point(877, 17);
            signOut.Name = "signOut";
            signOut.Size = new Size(75, 23);
            signOut.TabIndex = 12;
            signOut.Text = "Sign out";
            signOut.UseVisualStyleBackColor = true;
            // 
            // createCustomer
            // 
            createCustomer.Controls.Add(tableLayoutPanel1);
            createCustomer.Location = new Point(4, 24);
            createCustomer.Name = "createCustomer";
            createCustomer.Padding = new Padding(3);
            createCustomer.Size = new Size(976, 560);
            createCustomer.TabIndex = 1;
            createCustomer.Text = "Create Customer";
            createCustomer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(addressLabel, 0, 13);
            tableLayoutPanel1.Controls.Add(postalCodeLabel, 0, 12);
            tableLayoutPanel1.Controls.Add(districtLabel, 0, 10);
            tableLayoutPanel1.Controls.Add(townLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(cityLabel, 0, 8);
            tableLayoutPanel1.Controls.Add(phoneNumberLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(transactionNumberLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(emailLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(birthDateLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(genderLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(fullNameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(surnameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(firstNameText, 1, 0);
            tableLayoutPanel1.Controls.Add(surNameText, 1, 1);
            tableLayoutPanel1.Controls.Add(fullNameText, 1, 2);
            tableLayoutPanel1.Controls.Add(genderText, 1, 3);
            tableLayoutPanel1.Controls.Add(birthDateText, 1, 4);
            tableLayoutPanel1.Controls.Add(emailText, 1, 5);
            tableLayoutPanel1.Controls.Add(transactionNumberText, 1, 6);
            tableLayoutPanel1.Controls.Add(phoneNumberText, 1, 7);
            tableLayoutPanel1.Controls.Add(cityText, 1, 8);
            tableLayoutPanel1.Controls.Add(towntext, 1, 9);
            tableLayoutPanel1.Controls.Add(districtText, 1, 10);
            tableLayoutPanel1.Controls.Add(firstnameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(streetLabel, 0, 11);
            tableLayoutPanel1.Controls.Add(streetText, 1, 11);
            tableLayoutPanel1.Controls.Add(postalCodeText, 1, 12);
            tableLayoutPanel1.Controls.Add(addressText, 1, 13);
            tableLayoutPanel1.Location = new Point(229, -2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(518, 565);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(3, 529);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(49, 15);
            addressLabel.TabIndex = 24;
            addressLabel.Text = "Address";
            addressLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(3, 487);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(70, 15);
            postalCodeLabel.TabIndex = 23;
            postalCodeLabel.Text = "Postal Code";
            postalCodeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // districtLabel
            // 
            districtLabel.AutoSize = true;
            districtLabel.Location = new Point(3, 411);
            districtLabel.Name = "districtLabel";
            districtLabel.Size = new Size(44, 15);
            districtLabel.TabIndex = 21;
            districtLabel.Text = "District";
            districtLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Location = new Point(3, 367);
            townLabel.Name = "townLabel";
            townLabel.Size = new Size(35, 15);
            townLabel.TabIndex = 20;
            townLabel.Text = "Town";
            townLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(3, 330);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 19;
            cityLabel.Text = "City";
            cityLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(3, 291);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 18;
            phoneNumberLabel.Text = "Phone Number";
            phoneNumberLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // transactionNumberLabel
            // 
            transactionNumberLabel.AutoSize = true;
            transactionNumberLabel.Location = new Point(3, 256);
            transactionNumberLabel.Name = "transactionNumberLabel";
            transactionNumberLabel.Size = new Size(114, 15);
            transactionNumberLabel.TabIndex = 17;
            transactionNumberLabel.Text = "Transaction Number";
            transactionNumberLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(3, 218);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email";
            emailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(3, 180);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(59, 15);
            birthDateLabel.TabIndex = 15;
            birthDateLabel.Text = "Birth Date";
            birthDateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(3, 142);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 14;
            genderLabel.Text = "Gender";
            genderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(3, 94);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(61, 15);
            fullNameLabel.TabIndex = 13;
            fullNameLabel.Text = "Full Name";
            fullNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(3, 47);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(54, 15);
            surnameLabel.TabIndex = 12;
            surnameLabel.Text = "Surname";
            surnameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(262, 3);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(253, 23);
            firstNameText.TabIndex = 0;
            // 
            // surNameText
            // 
            surNameText.Location = new Point(262, 50);
            surNameText.Name = "surNameText";
            surNameText.Size = new Size(253, 23);
            surNameText.TabIndex = 1;
            // 
            // fullNameText
            // 
            fullNameText.Location = new Point(262, 97);
            fullNameText.Name = "fullNameText";
            fullNameText.Size = new Size(253, 23);
            fullNameText.TabIndex = 2;
            // 
            // genderText
            // 
            genderText.Location = new Point(262, 145);
            genderText.Name = "genderText";
            genderText.Size = new Size(253, 23);
            genderText.TabIndex = 3;
            // 
            // birthDateText
            // 
            birthDateText.Location = new Point(262, 183);
            birthDateText.Name = "birthDateText";
            birthDateText.Size = new Size(253, 23);
            birthDateText.TabIndex = 4;
            // 
            // emailText
            // 
            emailText.Location = new Point(262, 221);
            emailText.Name = "emailText";
            emailText.Size = new Size(253, 23);
            emailText.TabIndex = 6;
            // 
            // transactionNumberText
            // 
            transactionNumberText.Location = new Point(262, 259);
            transactionNumberText.Name = "transactionNumberText";
            transactionNumberText.Size = new Size(253, 23);
            transactionNumberText.TabIndex = 5;
            // 
            // phoneNumberText
            // 
            phoneNumberText.Location = new Point(262, 294);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(253, 23);
            phoneNumberText.TabIndex = 7;
            // 
            // cityText
            // 
            cityText.Location = new Point(262, 333);
            cityText.Name = "cityText";
            cityText.Size = new Size(253, 23);
            cityText.TabIndex = 8;
            // 
            // towntext
            // 
            towntext.Location = new Point(262, 370);
            towntext.Name = "towntext";
            towntext.Size = new Size(253, 23);
            towntext.TabIndex = 9;
            // 
            // districtText
            // 
            districtText.Location = new Point(262, 414);
            districtText.Name = "districtText";
            districtText.Size = new Size(253, 23);
            districtText.TabIndex = 10;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(3, 0);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(64, 15);
            firstnameLabel.TabIndex = 11;
            firstnameLabel.Text = "First Name";
            firstnameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(3, 448);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(37, 15);
            streetLabel.TabIndex = 22;
            streetLabel.Text = "Street";
            streetLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // streetText
            // 
            streetText.Location = new Point(262, 451);
            streetText.Name = "streetText";
            streetText.Size = new Size(253, 23);
            streetText.TabIndex = 25;
            // 
            // postalCodeText
            // 
            postalCodeText.Location = new Point(262, 490);
            postalCodeText.Name = "postalCodeText";
            postalCodeText.Size = new Size(253, 23);
            postalCodeText.TabIndex = 26;
            // 
            // addressText
            // 
            addressText.Location = new Point(262, 532);
            addressText.Name = "addressText";
            addressText.Size = new Size(253, 23);
            addressText.TabIndex = 27;
            // 
            // RestaurantsMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 609);
            Controls.Add(mainWindow);
            Name = "RestaurantsMainWindow";
            Text = "RestaurantsMainWindow";
            mainWindow.ResumeLayout(false);
            customerList.ResumeLayout(false);
            customerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            createCustomer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainWindow;
        private TabPage customerList;
        private TabPage createCustomer;
        private Button search;
        private Label endDate;
        private Label startDate;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private DataGridView dataGridView;
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
        private TextBox searchText;
        private Button signOut;
        private TableLayoutPanel tableLayoutPanel1;
        private Label addressLabel;
        private Label postalCodeLabel;
        private Label districtLabel;
        private Label townLabel;
        private Label cityLabel;
        private Label phoneNumberLabel;
        private Label transactionNumberLabel;
        private Label emailLabel;
        private Label birthDateLabel;
        private Label genderLabel;
        private Label fullNameLabel;
        private Label surnameLabel;
        private TextBox firstNameText;
        private TextBox surNameText;
        private TextBox fullNameText;
        private TextBox genderText;
        private TextBox birthDateText;
        private TextBox emailText;
        private TextBox transactionNumberText;
        private TextBox phoneNumberText;
        private TextBox cityText;
        private TextBox towntext;
        private TextBox districtText;
        private Label firstnameLabel;
        private Label streetLabel;
        private TextBox streetText;
        private TextBox postalCodeText;
        private TextBox addressText;
    }
}