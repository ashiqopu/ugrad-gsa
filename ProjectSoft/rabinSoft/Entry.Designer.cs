namespace rabinSoft
{
    partial class FormEntry
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
            this.lItems = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryItemsDataSet = new rabinSoft.entryItemsDataSet();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.lLt = new System.Windows.Forms.Label();
            this.lTk = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bStock = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.CheckBoxQuantity = new System.Windows.Forms.CheckBox();
            this.CheckBoxAmount = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCost = new System.Windows.Forms.Button();
            this.bReview = new System.Windows.Forms.Button();
            this.lcountItem = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.ITime = new System.Windows.Forms.Label();
            this.lTk6 = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lTk5 = new System.Windows.Forms.Label();
            this.lTk4 = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.CheckBox();
            this.cbDue = new System.Windows.Forms.CheckBox();
            this.tbDue = new System.Windows.Forms.TextBox();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.lDue = new System.Windows.Forms.Label();
            this.bDue = new System.Windows.Forms.Button();
            this.tbSalesman = new System.Windows.Forms.TextBox();
            this.lSalesman = new System.Windows.Forms.Label();
            this.lCn = new System.Windows.Forms.Label();
            this.lPn = new System.Windows.Forms.Label();
            this.lPlate = new System.Windows.Forms.Label();
            this.lCustomer = new System.Windows.Forms.Label();
            this.tbPlate = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.detailsTableAdapter = new rabinSoft.entryItemsDataSetTableAdapters.detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryItemsDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lItems
            // 
            this.lItems.AutoSize = true;
            this.lItems.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lItems.Location = new System.Drawing.Point(65, 264);
            this.lItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lItems.Name = "lItems";
            this.lItems.Size = new System.Drawing.Size(121, 25);
            this.lItems.TabIndex = 0;
            this.lItems.Text = "Select Items :";
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(165, 556);
            this.bReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(112, 37);
            this.bReset.TabIndex = 3;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // cbItem
            // 
            this.cbItem.DataSource = this.detailsBindingSource;
            this.cbItem.DisplayMember = "Items";
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(14, 332);
            this.cbItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(220, 29);
            this.cbItem.TabIndex = 4;
            this.cbItem.ValueMember = "Items";
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "details";
            this.detailsBindingSource.DataSource = this.entryItemsDataSet;
            // 
            // entryItemsDataSet
            // 
            this.entryItemsDataSet.DataSetName = "entryItemsDataSet";
            this.entryItemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(293, 332);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(180, 29);
            this.tbQuantity.TabIndex = 5;
            this.tbQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbQuantity_MouseClick);
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(321, 556);
            this.bSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(112, 37);
            this.bSubmit.TabIndex = 7;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // lLt
            // 
            this.lLt.AutoSize = true;
            this.lLt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLt.Location = new System.Drawing.Point(481, 332);
            this.lLt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLt.Name = "lLt";
            this.lLt.Size = new System.Drawing.Size(55, 25);
            this.lLt.TabIndex = 8;
            this.lLt.Text = "*Lt(s)";
            // 
            // lTk
            // 
            this.lTk.AutoSize = true;
            this.lTk.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTk.Location = new System.Drawing.Point(718, 336);
            this.lTk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTk.Name = "lTk";
            this.lTk.Size = new System.Drawing.Size(43, 25);
            this.lTk.TabIndex = 9;
            this.lTk.Text = "*Tk.";
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(470, 556);
            this.bExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(112, 37);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "# Choose Required Resources :";
            // 
            // bStock
            // 
            this.bStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStock.Location = new System.Drawing.Point(649, 78);
            this.bStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bStock.Name = "bStock";
            this.bStock.Size = new System.Drawing.Size(112, 37);
            this.bStock.TabIndex = 12;
            this.bStock.Text = "Stock";
            this.bStock.UseVisualStyleBackColor = true;
            this.bStock.Click += new System.EventHandler(this.bStock_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(567, 332);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(129, 29);
            this.tbAmount.TabIndex = 13;
            this.tbAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAmount_MouseClick);
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // CheckBoxQuantity
            // 
            this.CheckBoxQuantity.AutoSize = true;
            this.CheckBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxQuantity.Location = new System.Drawing.Point(336, 267);
            this.CheckBoxQuantity.Name = "CheckBoxQuantity";
            this.CheckBoxQuantity.Size = new System.Drawing.Size(89, 25);
            this.CheckBoxQuantity.TabIndex = 14;
            this.CheckBoxQuantity.Text = "Quantity";
            this.CheckBoxQuantity.UseVisualStyleBackColor = true;
            this.CheckBoxQuantity.CheckedChanged += new System.EventHandler(this.CheckBoxQuantity_CheckedChanged);
            // 
            // CheckBoxAmount
            // 
            this.CheckBoxAmount.AutoSize = true;
            this.CheckBoxAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAmount.Location = new System.Drawing.Point(608, 267);
            this.CheckBoxAmount.Name = "CheckBoxAmount";
            this.CheckBoxAmount.Size = new System.Drawing.Size(85, 25);
            this.CheckBoxAmount.TabIndex = 15;
            this.CheckBoxAmount.Text = "Amount";
            this.CheckBoxAmount.UseVisualStyleBackColor = true;
            this.CheckBoxAmount.CheckedChanged += new System.EventHandler(this.CheckBoxAmount_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bCost);
            this.panel1.Controls.Add(this.bReview);
            this.panel1.Controls.Add(this.lcountItem);
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Controls.Add(this.ITime);
            this.panel1.Controls.Add(this.lTk6);
            this.panel1.Controls.Add(this.lTime);
            this.panel1.Controls.Add(this.lTk5);
            this.panel1.Controls.Add(this.lTk4);
            this.panel1.Controls.Add(this.cbPayment);
            this.panel1.Controls.Add(this.cbDue);
            this.panel1.Controls.Add(this.tbDue);
            this.panel1.Controls.Add(this.tbPay);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.lTotal);
            this.panel1.Controls.Add(this.lDue);
            this.panel1.Controls.Add(this.bDue);
            this.panel1.Controls.Add(this.tbSalesman);
            this.panel1.Controls.Add(this.lSalesman);
            this.panel1.Controls.Add(this.lCn);
            this.panel1.Controls.Add(this.lPn);
            this.panel1.Controls.Add(this.lPlate);
            this.panel1.Controls.Add(this.lCustomer);
            this.panel1.Controls.Add(this.tbPlate);
            this.panel1.Controls.Add(this.tbCustomer);
            this.panel1.Controls.Add(this.CheckBoxAmount);
            this.panel1.Controls.Add(this.CheckBoxQuantity);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.bStock);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.lTk);
            this.panel1.Controls.Add(this.lLt);
            this.panel1.Controls.Add(this.bSubmit);
            this.panel1.Controls.Add(this.tbQuantity);
            this.panel1.Controls.Add(this.cbItem);
            this.panel1.Controls.Add(this.bReset);
            this.panel1.Controls.Add(this.lItems);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 616);
            this.panel1.TabIndex = 0;
            // 
            // bCost
            // 
            this.bCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCost.Location = new System.Drawing.Point(649, 134);
            this.bCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCost.Name = "bCost";
            this.bCost.Size = new System.Drawing.Size(112, 37);
            this.bCost.TabIndex = 63;
            this.bCost.Text = "Cost";
            this.bCost.UseVisualStyleBackColor = true;
            this.bCost.Click += new System.EventHandler(this.bCost_Click);
            // 
            // bReview
            // 
            this.bReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReview.Location = new System.Drawing.Point(567, 391);
            this.bReview.Name = "bReview";
            this.bReview.Size = new System.Drawing.Size(142, 38);
            this.bReview.TabIndex = 62;
            this.bReview.Text = "Review Item(s)";
            this.bReview.UseVisualStyleBackColor = true;
            this.bReview.Click += new System.EventHandler(this.bReview_Click);
            // 
            // lcountItem
            // 
            this.lcountItem.AutoSize = true;
            this.lcountItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcountItem.ForeColor = System.Drawing.Color.Black;
            this.lcountItem.Location = new System.Drawing.Point(307, 397);
            this.lcountItem.Name = "lcountItem";
            this.lcountItem.Size = new System.Drawing.Size(144, 25);
            this.lcountItem.TabIndex = 61;
            this.lcountItem.Text = "0 Item(s) Added";
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(55, 391);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(142, 38);
            this.bAdd.TabIndex = 59;
            this.bAdd.Text = "Add Item(s)";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // ITime
            // 
            this.ITime.AutoSize = true;
            this.ITime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITime.Location = new System.Drawing.Point(448, 14);
            this.ITime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ITime.Name = "ITime";
            this.ITime.Size = new System.Drawing.Size(109, 25);
            this.ITime.TabIndex = 58;
            this.ITime.Text = "Date-Time :";
            // 
            // lTk6
            // 
            this.lTk6.AutoSize = true;
            this.lTk6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTk6.Location = new System.Drawing.Point(717, 495);
            this.lTk6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTk6.Name = "lTk6";
            this.lTk6.Size = new System.Drawing.Size(43, 25);
            this.lTk6.TabIndex = 56;
            this.lTk6.Text = "*Tk.";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.Location = new System.Drawing.Point(567, 15);
            this.lTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(0, 25);
            this.lTime.TabIndex = 53;
            // 
            // lTk5
            // 
            this.lTk5.AutoSize = true;
            this.lTk5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTk5.Location = new System.Drawing.Point(459, 499);
            this.lTk5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTk5.Name = "lTk5";
            this.lTk5.Size = new System.Drawing.Size(43, 25);
            this.lTk5.TabIndex = 50;
            this.lTk5.Text = "*Tk.";
            // 
            // lTk4
            // 
            this.lTk4.AutoSize = true;
            this.lTk4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTk4.Location = new System.Drawing.Point(200, 497);
            this.lTk4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTk4.Name = "lTk4";
            this.lTk4.Size = new System.Drawing.Size(43, 25);
            this.lTk4.TabIndex = 49;
            this.lTk4.Text = "*Tk.";
            // 
            // cbPayment
            // 
            this.cbPayment.AutoSize = true;
            this.cbPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayment.Location = new System.Drawing.Point(340, 460);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(90, 25);
            this.cbPayment.TabIndex = 48;
            this.cbPayment.Text = "Payment";
            this.cbPayment.UseVisualStyleBackColor = true;
            this.cbPayment.CheckedChanged += new System.EventHandler(this.cbPayment_CheckedChanged);
            // 
            // cbDue
            // 
            this.cbDue.AutoSize = true;
            this.cbDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDue.Location = new System.Drawing.Point(606, 458);
            this.cbDue.Name = "cbDue";
            this.cbDue.Size = new System.Drawing.Size(57, 25);
            this.cbDue.TabIndex = 47;
            this.cbDue.Text = "Due";
            this.cbDue.UseVisualStyleBackColor = true;
            this.cbDue.CheckedChanged += new System.EventHandler(this.cbDue_CheckedChanged);
            // 
            // tbDue
            // 
            this.tbDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDue.Location = new System.Drawing.Point(567, 499);
            this.tbDue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDue.Name = "tbDue";
            this.tbDue.Size = new System.Drawing.Size(142, 29);
            this.tbDue.TabIndex = 46;
            this.tbDue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbDue_MouseClick);
            this.tbDue.TextChanged += new System.EventHandler(this.tbDue_TextChanged);
            // 
            // tbPay
            // 
            this.tbPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPay.Location = new System.Drawing.Point(309, 497);
            this.tbPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPay.Name = "tbPay";
            this.tbPay.Size = new System.Drawing.Size(142, 29);
            this.tbPay.TabIndex = 45;
            this.tbPay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPayment_MouseClick);
            this.tbPay.TextChanged += new System.EventHandler(this.tbPayment_TextChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(50, 498);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(142, 29);
            this.tbTotal.TabIndex = 42;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(87, 457);
            this.lTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(63, 25);
            this.lTotal.TabIndex = 41;
            this.lTotal.Text = "Total :";
            // 
            // lDue
            // 
            this.lDue.AutoSize = true;
            this.lDue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDue.Location = new System.Drawing.Point(761, 192);
            this.lDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDue.Name = "lDue";
            this.lDue.Size = new System.Drawing.Size(21, 25);
            this.lDue.TabIndex = 40;
            this.lDue.Text = "?";
            // 
            // bDue
            // 
            this.bDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDue.Location = new System.Drawing.Point(649, 189);
            this.bDue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bDue.Name = "bDue";
            this.bDue.Size = new System.Drawing.Size(112, 37);
            this.bDue.TabIndex = 39;
            this.bDue.Text = "Due";
            this.bDue.UseVisualStyleBackColor = true;
            this.bDue.Click += new System.EventHandler(this.bDue_Click);
            // 
            // tbSalesman
            // 
            this.tbSalesman.Enabled = false;
            this.tbSalesman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalesman.Location = new System.Drawing.Point(294, 197);
            this.tbSalesman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSalesman.Name = "tbSalesman";
            this.tbSalesman.Size = new System.Drawing.Size(263, 29);
            this.tbSalesman.TabIndex = 24;
            // 
            // lSalesman
            // 
            this.lSalesman.AutoSize = true;
            this.lSalesman.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalesman.Location = new System.Drawing.Point(50, 202);
            this.lSalesman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSalesman.Name = "lSalesman";
            this.lSalesman.Size = new System.Drawing.Size(101, 25);
            this.lSalesman.TabIndex = 23;
            this.lSalesman.Text = "Salesman :";
            // 
            // lCn
            // 
            this.lCn.AutoSize = true;
            this.lCn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCn.Location = new System.Drawing.Point(565, 82);
            this.lCn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCn.Name = "lCn";
            this.lCn.Size = new System.Drawing.Size(20, 25);
            this.lCn.TabIndex = 22;
            this.lCn.Text = "*";
            // 
            // lPn
            // 
            this.lPn.AutoSize = true;
            this.lPn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPn.Location = new System.Drawing.Point(565, 146);
            this.lPn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPn.Name = "lPn";
            this.lPn.Size = new System.Drawing.Size(20, 25);
            this.lPn.TabIndex = 21;
            this.lPn.Text = "*";
            // 
            // lPlate
            // 
            this.lPlate.AutoSize = true;
            this.lPlate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlate.Location = new System.Drawing.Point(50, 142);
            this.lPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlate.Name = "lPlate";
            this.lPlate.Size = new System.Drawing.Size(137, 25);
            this.lPlate.TabIndex = 20;
            this.lPlate.Text = "Plate Number :";
            // 
            // lCustomer
            // 
            this.lCustomer.AutoSize = true;
            this.lCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCustomer.Location = new System.Drawing.Point(50, 78);
            this.lCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCustomer.Name = "lCustomer";
            this.lCustomer.Size = new System.Drawing.Size(157, 25);
            this.lCustomer.TabIndex = 19;
            this.lCustomer.Text = "Customer Name :";
            // 
            // tbPlate
            // 
            this.tbPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlate.Location = new System.Drawing.Point(294, 138);
            this.tbPlate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(263, 29);
            this.tbPlate.TabIndex = 18;
            this.tbPlate.TextChanged += new System.EventHandler(this.tbPlate_TextChanged);
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(294, 73);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(263, 29);
            this.tbCustomer.TabIndex = 17;
            this.tbCustomer.TextChanged += new System.EventHandler(this.tbCustomer_TextChanged);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::rabinSoft.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 635);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Filling Station - Data Entry";
            this.Load += new System.EventHandler(this.FormEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryItemsDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lItems;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label lLt;
        private System.Windows.Forms.Label lTk;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStock;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.CheckBox CheckBoxQuantity;
        private System.Windows.Forms.CheckBox CheckBoxAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lPlate;
        private System.Windows.Forms.Label lCustomer;
        private System.Windows.Forms.TextBox tbPlate;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label lCn;
        private System.Windows.Forms.Label lPn;
        private System.Windows.Forms.TextBox tbSalesman;
        private System.Windows.Forms.Label lSalesman;
        private System.Windows.Forms.Button bDue;
        private System.Windows.Forms.Label lDue;
        private System.Windows.Forms.CheckBox cbPayment;
        private System.Windows.Forms.CheckBox cbDue;
        private System.Windows.Forms.TextBox tbDue;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lTk5;
        private System.Windows.Forms.Label lTk4;
        private System.Windows.Forms.Label lTk6;
        private System.Windows.Forms.Label ITime;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lcountItem;
        private System.Windows.Forms.Button bReview;
        private entryItemsDataSet entryItemsDataSet;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private entryItemsDataSetTableAdapters.detailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.Button bCost;

    }
}

