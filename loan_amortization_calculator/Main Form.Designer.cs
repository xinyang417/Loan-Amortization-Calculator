namespace VehicleLoanCalculator
{
    partial class MainForm
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
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.aprLabel = new System.Windows.Forms.Label();
            this.rebateCheckBox = new System.Windows.Forms.CheckBox();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.sixRadioButton = new System.Windows.Forms.RadioButton();
            this.aprComboBox = new System.Windows.Forms.ComboBox();
            this.monthGroupBox = new System.Windows.Forms.GroupBox();
            this.twentyfourRadioButton = new System.Windows.Forms.RadioButton();
            this.twelveRadioButton = new System.Windows.Forms.RadioButton();
            this.eightteenRadioButton = new System.Windows.Forms.RadioButton();
            this.monthLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.principalLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.rebateTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.talLoansLabel = new System.Windows.Forms.Label();
            this.talInterestlabel = new System.Windows.Forms.Label();
            this.totalLoanLabel = new System.Windows.Forms.Label();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monthGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.loanAmountLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.loanAmountLabel.Location = new System.Drawing.Point(24, 61);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(81, 15);
            this.loanAmountLabel.TabIndex = 1;
            this.loanAmountLabel.Text = "&Loan amount:";
            // 
            // aprLabel
            // 
            this.aprLabel.AutoSize = true;
            this.aprLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.aprLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprLabel.ForeColor = System.Drawing.Color.Black;
            this.aprLabel.Location = new System.Drawing.Point(25, 89);
            this.aprLabel.Name = "aprLabel";
            this.aprLabel.Size = new System.Drawing.Size(96, 15);
            this.aprLabel.TabIndex = 2;
            this.aprLabel.Text = "Ann&ual APR (%):";
            // 
            // rebateCheckBox
            // 
            this.rebateCheckBox.AutoSize = true;
            this.rebateCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.rebateCheckBox.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebateCheckBox.ForeColor = System.Drawing.Color.Black;
            this.rebateCheckBox.Location = new System.Drawing.Point(27, 117);
            this.rebateCheckBox.Name = "rebateCheckBox";
            this.rebateCheckBox.Size = new System.Drawing.Size(70, 19);
            this.rebateCheckBox.TabIndex = 3;
            this.rebateCheckBox.Text = "&Rebate?";
            this.rebateCheckBox.UseVisualStyleBackColor = false;
            this.rebateCheckBox.CheckStateChanged += new System.EventHandler(this.rebateCheckBox_CheckStateChanged);
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.BackColor = System.Drawing.Color.White;
            this.loanAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanAmountTextBox.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountTextBox.ForeColor = System.Drawing.Color.Black;
            this.loanAmountTextBox.Location = new System.Drawing.Point(116, 6);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.loanAmountTextBox.TabIndex = 0;
            this.loanAmountTextBox.Click += new System.EventHandler(this.loanAmountTextBox_Click);
            this.loanAmountTextBox.TextChanged += new System.EventHandler(this.loanAmountTextBox_TextChanged);
            this.loanAmountTextBox.Enter += new System.EventHandler(this.loanAmountTextBox_Enter);
            this.loanAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanAmountTextBox_KeyPress);
            // 
            // sixRadioButton
            // 
            this.sixRadioButton.AutoSize = true;
            this.sixRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.sixRadioButton.Checked = true;
            this.sixRadioButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixRadioButton.ForeColor = System.Drawing.Color.Black;
            this.sixRadioButton.Location = new System.Drawing.Point(30, 22);
            this.sixRadioButton.Name = "sixRadioButton";
            this.sixRadioButton.Size = new System.Drawing.Size(32, 19);
            this.sixRadioButton.TabIndex = 0;
            this.sixRadioButton.TabStop = true;
            this.sixRadioButton.Text = "6";
            this.sixRadioButton.UseVisualStyleBackColor = false;
            this.sixRadioButton.CheckedChanged += new System.EventHandler(this.sixRadioButton_CheckedChanged);
            // 
            // aprComboBox
            // 
            this.aprComboBox.BackColor = System.Drawing.Color.White;
            this.aprComboBox.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprComboBox.ForeColor = System.Drawing.Color.Black;
            this.aprComboBox.FormattingEnabled = true;
            this.aprComboBox.Location = new System.Drawing.Point(116, 33);
            this.aprComboBox.Name = "aprComboBox";
            this.aprComboBox.Size = new System.Drawing.Size(100, 23);
            this.aprComboBox.TabIndex = 1;
            this.aprComboBox.SelectedIndexChanged += new System.EventHandler(this.aprComboBox_SelectedIndexChanged);
            this.aprComboBox.TextChanged += new System.EventHandler(this.aprComboBox_TextChanged);
            this.aprComboBox.Click += new System.EventHandler(this.aprComboBox_Click);
            this.aprComboBox.Enter += new System.EventHandler(this.aprComboBox_Enter);
            this.aprComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aprComboBox_KeyPress);
            // 
            // monthGroupBox
            // 
            this.monthGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.monthGroupBox.Controls.Add(this.twentyfourRadioButton);
            this.monthGroupBox.Controls.Add(this.twelveRadioButton);
            this.monthGroupBox.Controls.Add(this.eightteenRadioButton);
            this.monthGroupBox.Controls.Add(this.sixRadioButton);
            this.monthGroupBox.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthGroupBox.ForeColor = System.Drawing.Color.Black;
            this.monthGroupBox.Location = new System.Drawing.Point(246, 9);
            this.monthGroupBox.Name = "monthGroupBox";
            this.monthGroupBox.Size = new System.Drawing.Size(138, 77);
            this.monthGroupBox.TabIndex = 3;
            this.monthGroupBox.TabStop = false;
            this.monthGroupBox.Text = "Loan Months";
            // 
            // twentyfourRadioButton
            // 
            this.twentyfourRadioButton.AutoSize = true;
            this.twentyfourRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.twentyfourRadioButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twentyfourRadioButton.ForeColor = System.Drawing.Color.Black;
            this.twentyfourRadioButton.Location = new System.Drawing.Point(82, 51);
            this.twentyfourRadioButton.Name = "twentyfourRadioButton";
            this.twentyfourRadioButton.Size = new System.Drawing.Size(39, 19);
            this.twentyfourRadioButton.TabIndex = 3;
            this.twentyfourRadioButton.Text = "24";
            this.twentyfourRadioButton.UseVisualStyleBackColor = false;
            this.twentyfourRadioButton.CheckedChanged += new System.EventHandler(this.twentyfourRadioButton_CheckedChanged);
            // 
            // twelveRadioButton
            // 
            this.twelveRadioButton.AutoSize = true;
            this.twelveRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.twelveRadioButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twelveRadioButton.ForeColor = System.Drawing.Color.Black;
            this.twelveRadioButton.Location = new System.Drawing.Point(30, 51);
            this.twelveRadioButton.Name = "twelveRadioButton";
            this.twelveRadioButton.Size = new System.Drawing.Size(39, 19);
            this.twelveRadioButton.TabIndex = 1;
            this.twelveRadioButton.Text = "12";
            this.twelveRadioButton.UseVisualStyleBackColor = false;
            this.twelveRadioButton.CheckedChanged += new System.EventHandler(this.twelveRadioButton_CheckedChanged);
            // 
            // eightteenRadioButton
            // 
            this.eightteenRadioButton.AutoSize = true;
            this.eightteenRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.eightteenRadioButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightteenRadioButton.ForeColor = System.Drawing.Color.Black;
            this.eightteenRadioButton.Location = new System.Drawing.Point(82, 22);
            this.eightteenRadioButton.Name = "eightteenRadioButton";
            this.eightteenRadioButton.Size = new System.Drawing.Size(39, 19);
            this.eightteenRadioButton.TabIndex = 2;
            this.eightteenRadioButton.Text = "18";
            this.eightteenRadioButton.UseVisualStyleBackColor = false;
            this.eightteenRadioButton.CheckedChanged += new System.EventHandler(this.eightteenRadioButton_CheckedChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.monthLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ForeColor = System.Drawing.Color.Black;
            this.monthLabel.Location = new System.Drawing.Point(28, 157);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(42, 15);
            this.monthLabel.TabIndex = 4;
            this.monthLabel.Text = "Month";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.interestLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLabel.ForeColor = System.Drawing.Color.Black;
            this.interestLabel.Location = new System.Drawing.Point(99, 157);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(47, 15);
            this.interestLabel.TabIndex = 5;
            this.interestLabel.Text = "Interest";
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.principalLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLabel.ForeColor = System.Drawing.Color.Black;
            this.principalLabel.Location = new System.Drawing.Point(180, 157);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(54, 15);
            this.principalLabel.TabIndex = 6;
            this.principalLabel.Text = "Principal";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.paymentLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.Color.Black;
            this.paymentLabel.Location = new System.Drawing.Point(261, 157);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(54, 15);
            this.paymentLabel.TabIndex = 7;
            this.paymentLabel.Text = "Payment";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.balanceLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.Black;
            this.balanceLabel.Location = new System.Drawing.Point(342, 157);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(49, 15);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "Balance";
            // 
            // resultListBox
            // 
            this.resultListBox.BackColor = System.Drawing.Color.White;
            this.resultListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultListBox.ForeColor = System.Drawing.Color.Black;
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 14;
            this.resultListBox.Location = new System.Drawing.Point(27, 178);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(404, 242);
            this.resultListBox.TabIndex = 9;
            // 
            // rebateTextBox
            // 
            this.rebateTextBox.BackColor = System.Drawing.Color.White;
            this.rebateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rebateTextBox.Enabled = false;
            this.rebateTextBox.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebateTextBox.ForeColor = System.Drawing.Color.Black;
            this.rebateTextBox.Location = new System.Drawing.Point(116, 63);
            this.rebateTextBox.Name = "rebateTextBox";
            this.rebateTextBox.Size = new System.Drawing.Size(100, 23);
            this.rebateTextBox.TabIndex = 2;
            this.rebateTextBox.Click += new System.EventHandler(this.rebateTextBox_Click);
            this.rebateTextBox.TextChanged += new System.EventHandler(this.rebateTextBox_TextChanged);
            this.rebateTextBox.Enter += new System.EventHandler(this.rebateTextBox_Enter);
            this.rebateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebateTextBox_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 52);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueforSAS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(149, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amortization Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // talLoansLabel
            // 
            this.talLoansLabel.AutoSize = true;
            this.talLoansLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.talLoansLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talLoansLabel.ForeColor = System.Drawing.Color.Black;
            this.talLoansLabel.Location = new System.Drawing.Point(30, 54);
            this.talLoansLabel.Name = "talLoansLabel";
            this.talLoansLabel.Size = new System.Drawing.Size(72, 15);
            this.talLoansLabel.TabIndex = 2;
            this.talLoansLabel.Text = "Total Loans:";
            // 
            // talInterestlabel
            // 
            this.talInterestlabel.AutoSize = true;
            this.talInterestlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.talInterestlabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talInterestlabel.ForeColor = System.Drawing.Color.Black;
            this.talInterestlabel.Location = new System.Drawing.Point(27, 6);
            this.talInterestlabel.Name = "talInterestlabel";
            this.talInterestlabel.Size = new System.Drawing.Size(79, 15);
            this.talInterestlabel.TabIndex = 0;
            this.talInterestlabel.Text = "Total Interest:";
            // 
            // totalLoanLabel
            // 
            this.totalLoanLabel.BackColor = System.Drawing.Color.White;
            this.totalLoanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLoanLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLoanLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLoanLabel.Location = new System.Drawing.Point(13, 70);
            this.totalLoanLabel.Name = "totalLoanLabel";
            this.totalLoanLabel.Size = new System.Drawing.Size(106, 26);
            this.totalLoanLabel.TabIndex = 3;
            this.totalLoanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.BackColor = System.Drawing.Color.White;
            this.totalInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalInterestLabel.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestLabel.ForeColor = System.Drawing.Color.Black;
            this.totalInterestLabel.Location = new System.Drawing.Point(13, 22);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(106, 26);
            this.totalInterestLabel.TabIndex = 1;
            this.totalInterestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.totalInterestLabel);
            this.panel1.Controls.Add(this.totalLoanLabel);
            this.panel1.Controls.Add(this.talInterestlabel);
            this.panel1.Controls.Add(this.talLoansLabel);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(450, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 104);
            this.panel1.TabIndex = 13;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.calcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.calcButton.FlatAppearance.BorderSize = 0;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.Black;
            this.calcButton.Image = global::VehicleLoanCalculator.Properties.Resources.calculator__4_;
            this.calcButton.Location = new System.Drawing.Point(450, 53);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(132, 69);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "&Calculate";
            this.calcButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calcButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            this.calcButton.MouseEnter += new System.EventHandler(this.calcButton_MouseEnter);
            this.calcButton.MouseLeave += new System.EventHandler(this.calcButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Image = global::VehicleLoanCalculator.Properties.Resources.log_out2;
            this.exitButton.Location = new System.Drawing.Point(450, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 69);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.displayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.displayButton.FlatAppearance.BorderSize = 0;
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.ForeColor = System.Drawing.Color.Black;
            this.displayButton.Image = global::VehicleLoanCalculator.Properties.Resources.finance;
            this.displayButton.Location = new System.Drawing.Point(450, 189);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(132, 69);
            this.displayButton.TabIndex = 12;
            this.displayButton.Text = "&Display All Loans";
            this.displayButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.displayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            this.displayButton.MouseEnter += new System.EventHandler(this.displayButton_MouseEnter);
            this.displayButton.MouseLeave += new System.EventHandler(this.displayButton_MouseLeave);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("HelveticaNeueforSAS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.Black;
            this.acceptButton.Image = global::VehicleLoanCalculator.Properties.Resources.personal__2_;
            this.acceptButton.Location = new System.Drawing.Point(450, 121);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(132, 69);
            this.acceptButton.TabIndex = 11;
            this.acceptButton.Text = "&Accept Loan";
            this.acceptButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.acceptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            this.acceptButton.MouseEnter += new System.EventHandler(this.acceptButton_MouseEnter);
            this.acceptButton.MouseLeave += new System.EventHandler(this.acceptButton_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.monthGroupBox);
            this.panel3.Controls.Add(this.loanAmountTextBox);
            this.panel3.Controls.Add(this.aprComboBox);
            this.panel3.Controls.Add(this.rebateTextBox);
            this.panel3.Location = new System.Drawing.Point(18, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 377);
            this.panel3.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(600, 448);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.principalLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.rebateCheckBox);
            this.Controls.Add(this.aprLabel);
            this.Controls.Add(this.loanAmountLabel);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Loan Amortization Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.monthGroupBox.ResumeLayout(false);
            this.monthGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanAmountLabel;
        private System.Windows.Forms.Label aprLabel;
        private System.Windows.Forms.CheckBox rebateCheckBox;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.RadioButton sixRadioButton;
        private System.Windows.Forms.ComboBox aprComboBox;
        private System.Windows.Forms.GroupBox monthGroupBox;
        private System.Windows.Forms.RadioButton twentyfourRadioButton;
        private System.Windows.Forms.RadioButton twelveRadioButton;
        private System.Windows.Forms.RadioButton eightteenRadioButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.TextBox rebateTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label talLoansLabel;
        private System.Windows.Forms.Label talInterestlabel;
        private System.Windows.Forms.Label totalLoanLabel;
        private System.Windows.Forms.Label totalInterestLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}

