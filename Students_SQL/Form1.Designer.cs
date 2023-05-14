namespace Students_SQL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxTables = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonGenerateData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOrderBy = new System.Windows.Forms.Button();
            this.boxFindId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.boxOrderBy = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boxFindFirstName = new System.Windows.Forms.TextBox();
            this.boxFindLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.boxFindAge = new System.Windows.Forms.TextBox();
            this.boxFindEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.boxFindPhone = new System.Windows.Forms.TextBox();
            this.boxFindGender = new System.Windows.Forms.ComboBox();
            this.grboxAdd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxAge = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.boxGender = new System.Windows.Forms.ComboBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grboxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxTables);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.buttonGenerateData);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grboxAdd);
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 647);
            this.panel1.TabIndex = 0;
            // 
            // boxTables
            // 
            this.boxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxTables.FormattingEnabled = true;
            this.boxTables.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.boxTables.Location = new System.Drawing.Point(85, 314);
            this.boxTables.Name = "boxTables";
            this.boxTables.Size = new System.Drawing.Size(146, 26);
            this.boxTables.TabIndex = 28;
            this.boxTables.SelectedIndexChanged += new System.EventHandler(this.boxTables_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 17.75F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(13, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 27);
            this.label17.TabIndex = 29;
            this.label17.Text = "Table: ";
            // 
            // buttonGenerateData
            // 
            this.buttonGenerateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGenerateData.Location = new System.Drawing.Point(1159, 3);
            this.buttonGenerateData.Name = "buttonGenerateData";
            this.buttonGenerateData.Size = new System.Drawing.Size(22, 275);
            this.buttonGenerateData.TabIndex = 27;
            this.buttonGenerateData.Text = "Generate data";
            this.buttonGenerateData.UseVisualStyleBackColor = true;
            this.buttonGenerateData.Click += new System.EventHandler(this.buttonGenerateData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonOrderBy);
            this.groupBox1.Controls.Add(this.boxFindId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.boxOrderBy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.boxFindFirstName);
            this.groupBox1.Controls.Add(this.boxFindLastName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.boxFindAge);
            this.groupBox1.Controls.Add(this.boxFindEmail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.boxFindPhone);
            this.groupBox1.Controls.Add(this.boxFindGender);
            this.groupBox1.Location = new System.Drawing.Point(413, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 311);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(177, 255);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 51);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete selected ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonOrderBy
            // 
            this.buttonOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOrderBy.Location = new System.Drawing.Point(152, 278);
            this.buttonOrderBy.Name = "buttonOrderBy";
            this.buttonOrderBy.Size = new System.Drawing.Size(17, 28);
            this.buttonOrderBy.TabIndex = 19;
            this.buttonOrderBy.UseVisualStyleBackColor = true;
            this.buttonOrderBy.Click += new System.EventHandler(this.buttonOrderBy_Click);
            // 
            // boxFindId
            // 
            this.boxFindId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFindId.Location = new System.Drawing.Point(85, 158);
            this.boxFindId.Name = "boxFindId";
            this.boxFindId.Size = new System.Drawing.Size(65, 26);
            this.boxFindId.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Order by:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(85, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 23);
            this.label16.TabIndex = 26;
            this.label16.Text = "Id";
            // 
            // boxOrderBy
            // 
            this.boxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxOrderBy.FormattingEnabled = true;
            this.boxOrderBy.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.boxOrderBy.Location = new System.Drawing.Point(6, 279);
            this.boxOrderBy.Name = "boxOrderBy";
            this.boxOrderBy.Size = new System.Drawing.Size(146, 26);
            this.boxOrderBy.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "First name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(78, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 40);
            this.label10.TabIndex = 17;
            this.label10.Text = "Find Person";
            // 
            // boxFindFirstName
            // 
            this.boxFindFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFindFirstName.Location = new System.Drawing.Point(10, 88);
            this.boxFindFirstName.Name = "boxFindFirstName";
            this.boxFindFirstName.Size = new System.Drawing.Size(146, 26);
            this.boxFindFirstName.TabIndex = 23;
            // 
            // boxFindLastName
            // 
            this.boxFindLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFindLastName.Location = new System.Drawing.Point(177, 88);
            this.boxFindLastName.Name = "boxFindLastName";
            this.boxFindLastName.Size = new System.Drawing.Size(146, 26);
            this.boxFindLastName.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(177, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Last name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(173, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "Email";
            // 
            // boxFindAge
            // 
            this.boxFindAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFindAge.Location = new System.Drawing.Point(6, 158);
            this.boxFindAge.Name = "boxFindAge";
            this.boxFindAge.Size = new System.Drawing.Size(65, 26);
            this.boxFindAge.TabIndex = 8;
            // 
            // boxFindEmail
            // 
            this.boxFindEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFindEmail.Location = new System.Drawing.Point(177, 223);
            this.boxFindEmail.Name = "boxFindEmail";
            this.boxFindEmail.Size = new System.Drawing.Size(146, 26);
            this.boxFindEmail.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "Phone number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(177, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 23);
            this.label15.TabIndex = 11;
            this.label15.Text = "M/F";
            // 
            // boxFindPhone
            // 
            this.boxFindPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFindPhone.Location = new System.Drawing.Point(6, 223);
            this.boxFindPhone.MaxLength = 12;
            this.boxFindPhone.Name = "boxFindPhone";
            this.boxFindPhone.Size = new System.Drawing.Size(146, 26);
            this.boxFindPhone.TabIndex = 13;
            // 
            // boxFindGender
            // 
            this.boxFindGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFindGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFindGender.FormattingEnabled = true;
            this.boxFindGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            " "});
            this.boxFindGender.Location = new System.Drawing.Point(177, 158);
            this.boxFindGender.Name = "boxFindGender";
            this.boxFindGender.Size = new System.Drawing.Size(146, 26);
            this.boxFindGender.TabIndex = 12;
            // 
            // grboxAdd
            // 
            this.grboxAdd.Controls.Add(this.label1);
            this.grboxAdd.Controls.Add(this.boxFirstName);
            this.grboxAdd.Controls.Add(this.label7);
            this.grboxAdd.Controls.Add(this.buttonAdd);
            this.grboxAdd.Controls.Add(this.boxLastName);
            this.grboxAdd.Controls.Add(this.label2);
            this.grboxAdd.Controls.Add(this.label6);
            this.grboxAdd.Controls.Add(this.boxAge);
            this.grboxAdd.Controls.Add(this.boxEmail);
            this.grboxAdd.Controls.Add(this.label3);
            this.grboxAdd.Controls.Add(this.label5);
            this.grboxAdd.Controls.Add(this.label4);
            this.grboxAdd.Controls.Add(this.boxPhone);
            this.grboxAdd.Controls.Add(this.boxGender);
            this.grboxAdd.Location = new System.Drawing.Point(12, 3);
            this.grboxAdd.Name = "grboxAdd";
            this.grboxAdd.Size = new System.Drawing.Size(328, 311);
            this.grboxAdd.TabIndex = 20;
            this.grboxAdd.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            // 
            // boxFirstName
            // 
            this.boxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxFirstName.Location = new System.Drawing.Point(6, 88);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(146, 26);
            this.boxFirstName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(78, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "Add Person";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(6, 255);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(316, 50);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // boxLastName
            // 
            this.boxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxLastName.Location = new System.Drawing.Point(177, 88);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(146, 26);
            this.boxLastName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(177, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(173, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // boxAge
            // 
            this.boxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxAge.Location = new System.Drawing.Point(6, 158);
            this.boxAge.Name = "boxAge";
            this.boxAge.Size = new System.Drawing.Size(146, 26);
            this.boxAge.TabIndex = 8;
            // 
            // boxEmail
            // 
            this.boxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxEmail.Location = new System.Drawing.Point(177, 223);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(146, 26);
            this.boxEmail.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(177, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "M/F";
            // 
            // boxPhone
            // 
            this.boxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxPhone.Location = new System.Drawing.Point(6, 223);
            this.boxPhone.MaxLength = 12;
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(146, 26);
            this.boxPhone.TabIndex = 13;
            // 
            // boxGender
            // 
            this.boxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxGender.FormattingEnabled = true;
            this.boxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.boxGender.Location = new System.Drawing.Point(177, 158);
            this.boxGender.Name = "boxGender";
            this.boxGender.Size = new System.Drawing.Size(146, 26);
            this.boxGender.TabIndex = 12;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "NULL";
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(0, 344);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1181, 303);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 647);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students_SQL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grboxAdd.ResumeLayout(false);
            this.grboxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxFirstName;
        private System.Windows.Forms.ComboBox boxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox grboxAdd;
        private System.Windows.Forms.ComboBox boxOrderBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxFindFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxFindLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox boxFindAge;
        private System.Windows.Forms.TextBox boxFindEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox boxFindPhone;
        private System.Windows.Forms.ComboBox boxFindGender;
        private System.Windows.Forms.TextBox boxFindId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonOrderBy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonGenerateData;
        private System.Windows.Forms.ComboBox boxTables;
        private System.Windows.Forms.Label label17;
    }
}

