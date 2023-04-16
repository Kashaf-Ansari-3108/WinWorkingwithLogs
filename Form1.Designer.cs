namespace WinGeorgetownCleaningService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeExpected = new System.Windows.Forms.DateTimePicker();
            this.timeLeft = new System.Windows.Forms.DateTimePicker();
            this.dateExpected = new System.Windows.Forms.DateTimePicker();
            this.dateLeft = new System.Windows.Forms.DateTimePicker();
            this.txtCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFWTotal = new System.Windows.Forms.TextBox();
            this.txtSWTotal = new System.Windows.Forms.TextBox();
            this.txtOWTotal = new System.Windows.Forms.TextBox();
            this.txtSuitsTotal = new System.Windows.Forms.TextBox();
            this.txtPantTotal = new System.Windows.Forms.TextBox();
            this.txtShirtTotal = new System.Windows.Forms.TextBox();
            this.txtFWQty = new System.Windows.Forms.TextBox();
            this.txtSWQty = new System.Windows.Forms.TextBox();
            this.txtOWQty = new System.Windows.Forms.TextBox();
            this.txtSuitsQty = new System.Windows.Forms.TextBox();
            this.txtPantQty = new System.Windows.Forms.TextBox();
            this.txtShirtQty = new System.Windows.Forms.TextBox();
            this.txtFWPrice = new System.Windows.Forms.TextBox();
            this.txtSWPrice = new System.Windows.Forms.TextBox();
            this.txtOWPrice = new System.Windows.Forms.TextBox();
            this.txtSuitsPrice = new System.Windows.Forms.TextBox();
            this.txtPantPrice = new System.Windows.Forms.TextBox();
            this.txtShirtPrice = new System.Windows.Forms.TextBox();
            this.cmbFormalWear = new System.Windows.Forms.ComboBox();
            this.cmbSportsWear = new System.Windows.Forms.ComboBox();
            this.cmbOuterWear = new System.Windows.Forms.ComboBox();
            this.cmbSuits = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtCleaningTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeExpected);
            this.groupBox1.Controls.Add(this.timeLeft);
            this.groupBox1.Controls.Add(this.dateExpected);
            this.groupBox1.Controls.Add(this.dateLeft);
            this.groupBox1.Controls.Add(this.txtCustPhone);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Identification";
            // 
            // timeExpected
            // 
            this.timeExpected.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeExpected.Location = new System.Drawing.Point(410, 114);
            this.timeExpected.Name = "timeExpected";
            this.timeExpected.ShowUpDown = true;
            this.timeExpected.Size = new System.Drawing.Size(193, 20);
            this.timeExpected.TabIndex = 11;
            // 
            // timeLeft
            // 
            this.timeLeft.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeLeft.Location = new System.Drawing.Point(410, 62);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.ShowUpDown = true;
            this.timeLeft.Size = new System.Drawing.Size(189, 20);
            this.timeLeft.TabIndex = 10;
            // 
            // dateExpected
            // 
            this.dateExpected.Location = new System.Drawing.Point(98, 114);
            this.dateExpected.Name = "dateExpected";
            this.dateExpected.ShowUpDown = true;
            this.dateExpected.Size = new System.Drawing.Size(200, 20);
            this.dateExpected.TabIndex = 9;
            // 
            // dateLeft
            // 
            this.dateLeft.Location = new System.Drawing.Point(97, 64);
            this.dateLeft.Name = "dateLeft";
            this.dateLeft.ShowUpDown = true;
            this.dateLeft.Size = new System.Drawing.Size(201, 20);
            this.dateLeft.TabIndex = 8;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(410, 21);
            this.txtCustPhone.Mask = "(999) 000-0000";
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(189, 20);
            this.txtCustPhone.TabIndex = 7;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(97, 29);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(201, 20);
            this.txtCustName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time Expected:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time Left:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Expected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFWTotal);
            this.groupBox2.Controls.Add(this.txtSWTotal);
            this.groupBox2.Controls.Add(this.txtOWTotal);
            this.groupBox2.Controls.Add(this.txtSuitsTotal);
            this.groupBox2.Controls.Add(this.txtPantTotal);
            this.groupBox2.Controls.Add(this.txtShirtTotal);
            this.groupBox2.Controls.Add(this.txtFWQty);
            this.groupBox2.Controls.Add(this.txtSWQty);
            this.groupBox2.Controls.Add(this.txtOWQty);
            this.groupBox2.Controls.Add(this.txtSuitsQty);
            this.groupBox2.Controls.Add(this.txtPantQty);
            this.groupBox2.Controls.Add(this.txtShirtQty);
            this.groupBox2.Controls.Add(this.txtFWPrice);
            this.groupBox2.Controls.Add(this.txtSWPrice);
            this.groupBox2.Controls.Add(this.txtOWPrice);
            this.groupBox2.Controls.Add(this.txtSuitsPrice);
            this.groupBox2.Controls.Add(this.txtPantPrice);
            this.groupBox2.Controls.Add(this.txtShirtPrice);
            this.groupBox2.Controls.Add(this.cmbFormalWear);
            this.groupBox2.Controls.Add(this.cmbSportsWear);
            this.groupBox2.Controls.Add(this.cmbOuterWear);
            this.groupBox2.Controls.Add(this.cmbSuits);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Processing";
            // 
            // txtFWTotal
            // 
            this.txtFWTotal.Location = new System.Drawing.Point(296, 206);
            this.txtFWTotal.Name = "txtFWTotal";
            this.txtFWTotal.Size = new System.Drawing.Size(50, 20);
            this.txtFWTotal.TabIndex = 27;
            this.txtFWTotal.Text = "0.00";
            // 
            // txtSWTotal
            // 
            this.txtSWTotal.Location = new System.Drawing.Point(296, 179);
            this.txtSWTotal.Name = "txtSWTotal";
            this.txtSWTotal.Size = new System.Drawing.Size(50, 20);
            this.txtSWTotal.TabIndex = 26;
            this.txtSWTotal.Text = "0.00";
            // 
            // txtOWTotal
            // 
            this.txtOWTotal.Location = new System.Drawing.Point(296, 152);
            this.txtOWTotal.Name = "txtOWTotal";
            this.txtOWTotal.Size = new System.Drawing.Size(50, 20);
            this.txtOWTotal.TabIndex = 25;
            this.txtOWTotal.Text = "0.00";
            // 
            // txtSuitsTotal
            // 
            this.txtSuitsTotal.Location = new System.Drawing.Point(296, 124);
            this.txtSuitsTotal.Name = "txtSuitsTotal";
            this.txtSuitsTotal.Size = new System.Drawing.Size(50, 20);
            this.txtSuitsTotal.TabIndex = 24;
            this.txtSuitsTotal.Text = "0.00";
            // 
            // txtPantTotal
            // 
            this.txtPantTotal.Location = new System.Drawing.Point(296, 91);
            this.txtPantTotal.Name = "txtPantTotal";
            this.txtPantTotal.Size = new System.Drawing.Size(50, 20);
            this.txtPantTotal.TabIndex = 23;
            this.txtPantTotal.Text = "0.00";
            // 
            // txtShirtTotal
            // 
            this.txtShirtTotal.Location = new System.Drawing.Point(296, 61);
            this.txtShirtTotal.Name = "txtShirtTotal";
            this.txtShirtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtShirtTotal.TabIndex = 22;
            this.txtShirtTotal.Text = "0.00";
            // 
            // txtFWQty
            // 
            this.txtFWQty.Location = new System.Drawing.Point(240, 206);
            this.txtFWQty.Name = "txtFWQty";
            this.txtFWQty.Size = new System.Drawing.Size(46, 20);
            this.txtFWQty.TabIndex = 21;
            this.txtFWQty.Text = "0";
            this.txtFWQty.TextChanged += new System.EventHandler(this.txtFWQty_TextChanged);
            // 
            // txtSWQty
            // 
            this.txtSWQty.Location = new System.Drawing.Point(239, 179);
            this.txtSWQty.Name = "txtSWQty";
            this.txtSWQty.Size = new System.Drawing.Size(46, 20);
            this.txtSWQty.TabIndex = 20;
            this.txtSWQty.Text = "0";
            this.txtSWQty.TextChanged += new System.EventHandler(this.txtSWQty_TextChanged);
            // 
            // txtOWQty
            // 
            this.txtOWQty.Location = new System.Drawing.Point(239, 152);
            this.txtOWQty.Name = "txtOWQty";
            this.txtOWQty.Size = new System.Drawing.Size(46, 20);
            this.txtOWQty.TabIndex = 19;
            this.txtOWQty.Text = "0";
            this.txtOWQty.TextChanged += new System.EventHandler(this.txtOWQty_TextChanged);
            // 
            // txtSuitsQty
            // 
            this.txtSuitsQty.Location = new System.Drawing.Point(239, 124);
            this.txtSuitsQty.Name = "txtSuitsQty";
            this.txtSuitsQty.Size = new System.Drawing.Size(46, 20);
            this.txtSuitsQty.TabIndex = 18;
            this.txtSuitsQty.Text = "0";
            this.txtSuitsQty.TextChanged += new System.EventHandler(this.txtSuitsQty_TextChanged);
            // 
            // txtPantQty
            // 
            this.txtPantQty.Location = new System.Drawing.Point(240, 92);
            this.txtPantQty.Name = "txtPantQty";
            this.txtPantQty.Size = new System.Drawing.Size(46, 20);
            this.txtPantQty.TabIndex = 17;
            this.txtPantQty.Text = "0";
            this.txtPantQty.TextChanged += new System.EventHandler(this.txtPantQty_TextChanged);
            // 
            // txtShirtQty
            // 
            this.txtShirtQty.Location = new System.Drawing.Point(239, 61);
            this.txtShirtQty.Name = "txtShirtQty";
            this.txtShirtQty.Size = new System.Drawing.Size(46, 20);
            this.txtShirtQty.TabIndex = 16;
            this.txtShirtQty.Text = "0";
            this.txtShirtQty.TextChanged += new System.EventHandler(this.txtShirtQty_TextChanged);
            // 
            // txtFWPrice
            // 
            this.txtFWPrice.Location = new System.Drawing.Point(183, 206);
            this.txtFWPrice.Name = "txtFWPrice";
            this.txtFWPrice.Size = new System.Drawing.Size(50, 20);
            this.txtFWPrice.TabIndex = 15;
            this.txtFWPrice.Text = "0";
            this.txtFWPrice.TextChanged += new System.EventHandler(this.txtFWPrice_TextChanged);
            // 
            // txtSWPrice
            // 
            this.txtSWPrice.Location = new System.Drawing.Point(183, 179);
            this.txtSWPrice.Name = "txtSWPrice";
            this.txtSWPrice.Size = new System.Drawing.Size(50, 20);
            this.txtSWPrice.TabIndex = 14;
            this.txtSWPrice.Text = "0";
            this.txtSWPrice.TextChanged += new System.EventHandler(this.txtSWPrice_TextChanged);
            // 
            // txtOWPrice
            // 
            this.txtOWPrice.Location = new System.Drawing.Point(183, 152);
            this.txtOWPrice.Name = "txtOWPrice";
            this.txtOWPrice.Size = new System.Drawing.Size(50, 20);
            this.txtOWPrice.TabIndex = 13;
            this.txtOWPrice.Text = "0";
            this.txtOWPrice.TextChanged += new System.EventHandler(this.txtOWPrice_TextChanged);
            // 
            // txtSuitsPrice
            // 
            this.txtSuitsPrice.Location = new System.Drawing.Point(183, 124);
            this.txtSuitsPrice.Name = "txtSuitsPrice";
            this.txtSuitsPrice.Size = new System.Drawing.Size(50, 20);
            this.txtSuitsPrice.TabIndex = 12;
            this.txtSuitsPrice.Text = "0";
            this.txtSuitsPrice.TextChanged += new System.EventHandler(this.txtSuitsPrice_TextChanged);
            // 
            // txtPantPrice
            // 
            this.txtPantPrice.Location = new System.Drawing.Point(183, 91);
            this.txtPantPrice.Name = "txtPantPrice";
            this.txtPantPrice.Size = new System.Drawing.Size(50, 20);
            this.txtPantPrice.TabIndex = 11;
            this.txtPantPrice.Text = "0";
            this.txtPantPrice.TextChanged += new System.EventHandler(this.txtPantPrice_TextChanged);
            // 
            // txtShirtPrice
            // 
            this.txtShirtPrice.Location = new System.Drawing.Point(183, 61);
            this.txtShirtPrice.Name = "txtShirtPrice";
            this.txtShirtPrice.Size = new System.Drawing.Size(50, 20);
            this.txtShirtPrice.TabIndex = 10;
            this.txtShirtPrice.Text = "0";
            this.txtShirtPrice.TextChanged += new System.EventHandler(this.txtshirtPrice_TextChanged);
            // 
            // cmbFormalWear
            // 
            this.cmbFormalWear.FormattingEnabled = true;
            this.cmbFormalWear.Items.AddRange(new object[] {
            "Shawl or wrap",
            "Staller",
            "Gown",
            "Jumsuit"});
            this.cmbFormalWear.Location = new System.Drawing.Point(19, 205);
            this.cmbFormalWear.Name = "cmbFormalWear";
            this.cmbFormalWear.Size = new System.Drawing.Size(121, 21);
            this.cmbFormalWear.TabIndex = 9;
            this.cmbFormalWear.Text = "None";
            // 
            // cmbSportsWear
            // 
            this.cmbSportsWear.FormattingEnabled = true;
            this.cmbSportsWear.Items.AddRange(new object[] {
            "Yoga pant",
            "Athletic short",
            "Workout shirt"});
            this.cmbSportsWear.Location = new System.Drawing.Point(19, 178);
            this.cmbSportsWear.Name = "cmbSportsWear";
            this.cmbSportsWear.Size = new System.Drawing.Size(121, 21);
            this.cmbSportsWear.TabIndex = 8;
            this.cmbSportsWear.Text = "None";
            // 
            // cmbOuterWear
            // 
            this.cmbOuterWear.FormattingEnabled = true;
            this.cmbOuterWear.Items.AddRange(new object[] {
            "Jacket",
            "Coat",
            "Abaya",
            "Rain coat"});
            this.cmbOuterWear.Location = new System.Drawing.Point(19, 151);
            this.cmbOuterWear.Name = "cmbOuterWear";
            this.cmbOuterWear.Size = new System.Drawing.Size(121, 21);
            this.cmbOuterWear.TabIndex = 7;
            this.cmbOuterWear.Text = "None";
            // 
            // cmbSuits
            // 
            this.cmbSuits.FormattingEnabled = true;
            this.cmbSuits.Items.AddRange(new object[] {
            "Men\'s Suit 2Pc",
            "Women\'s Suit 2Pc",
            "Women\'s Suit 3Pc"});
            this.cmbSuits.Location = new System.Drawing.Point(19, 123);
            this.cmbSuits.Name = "cmbSuits";
            this.cmbSuits.Size = new System.Drawing.Size(121, 21);
            this.cmbSuits.TabIndex = 6;
            this.cmbSuits.Text = "None";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Sub-Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Qty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Unit Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pants";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Shirts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Item Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.txtNetPrice);
            this.groupBox3.Controls.Add(this.txtTaxAmount);
            this.groupBox3.Controls.Add(this.txtTaxRate);
            this.groupBox3.Controls.Add(this.txtCleaningTotal);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Location = new System.Drawing.Point(370, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 261);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Summary";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(27, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.Location = new System.Drawing.Point(127, 178);
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.Size = new System.Drawing.Size(100, 20);
            this.txtNetPrice.TabIndex = 8;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(127, 151);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTaxAmount.TabIndex = 7;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(127, 120);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 6;
            this.txtTaxRate.Text = "7.75";
            // 
            // txtCleaningTotal
            // 
            this.txtCleaningTotal.Location = new System.Drawing.Point(127, 85);
            this.txtCleaningTotal.Name = "txtCleaningTotal";
            this.txtCleaningTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCleaningTotal.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Net Price:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tax Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tax Rate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cleaning Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 30);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(203, 39);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "C:\\Program Files (x86)\\Sunisoft\\IrisSkin\\Skins\\Steel\\SteelBlack.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(230, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Georgetown Cleaning Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker timeExpected;
        private System.Windows.Forms.DateTimePicker timeLeft;
        private System.Windows.Forms.DateTimePicker dateExpected;
        private System.Windows.Forms.DateTimePicker dateLeft;
        private System.Windows.Forms.MaskedTextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFWTotal;
        private System.Windows.Forms.TextBox txtSWTotal;
        private System.Windows.Forms.TextBox txtOWTotal;
        private System.Windows.Forms.TextBox txtSuitsTotal;
        private System.Windows.Forms.TextBox txtPantTotal;
        private System.Windows.Forms.TextBox txtShirtTotal;
        private System.Windows.Forms.TextBox txtFWQty;
        private System.Windows.Forms.TextBox txtSWQty;
        private System.Windows.Forms.TextBox txtOWQty;
        private System.Windows.Forms.TextBox txtSuitsQty;
        private System.Windows.Forms.TextBox txtPantQty;
        private System.Windows.Forms.TextBox txtShirtQty;
        private System.Windows.Forms.TextBox txtFWPrice;
        private System.Windows.Forms.TextBox txtSWPrice;
        private System.Windows.Forms.TextBox txtOWPrice;
        private System.Windows.Forms.TextBox txtSuitsPrice;
        private System.Windows.Forms.TextBox txtPantPrice;
        private System.Windows.Forms.TextBox txtShirtPrice;
        private System.Windows.Forms.ComboBox cmbFormalWear;
        private System.Windows.Forms.ComboBox cmbSportsWear;
        private System.Windows.Forms.ComboBox cmbOuterWear;
        private System.Windows.Forms.ComboBox cmbSuits;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNetPrice;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtCleaningTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCalculate;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label17;
    }
}

