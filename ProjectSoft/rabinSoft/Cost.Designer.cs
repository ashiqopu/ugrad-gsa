namespace rabinSoft
{
    partial class FormCost
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bOption = new System.Windows.Forms.Button();
            this.bHistory = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lTk = new System.Windows.Forms.Label();
            this.lLt = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lAmount = new System.Windows.Forms.Label();
            this.lQuantity = new System.Windows.Forms.Label();
            this.lOption = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costDataSet = new rabinSoft.costDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsDataSet = new rabinSoft.itemsDataSet();
            this.itemsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTableAdapter = new rabinSoft.costDataSetTableAdapters.detailsTableAdapter();
            this.cbOthers = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbOthers);
            this.panel1.Controls.Add(this.bOption);
            this.panel1.Controls.Add(this.bHistory);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.lTk);
            this.panel1.Controls.Add(this.lLt);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.lAmount);
            this.panel1.Controls.Add(this.lQuantity);
            this.panel1.Controls.Add(this.lOption);
            this.panel1.Controls.Add(this.bSubmit);
            this.panel1.Controls.Add(this.tbQuantity);
            this.panel1.Controls.Add(this.cbItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 479);
            this.panel1.TabIndex = 0;
            // 
            // bOption
            // 
            this.bOption.Location = new System.Drawing.Point(500, 113);
            this.bOption.Name = "bOption";
            this.bOption.Size = new System.Drawing.Size(25, 25);
            this.bOption.TabIndex = 40;
            this.bOption.Text = "*";
            this.bOption.UseVisualStyleBackColor = true;
            this.bOption.Click += new System.EventHandler(this.bOption_Click);
            // 
            // bHistory
            // 
            this.bHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHistory.Location = new System.Drawing.Point(545, 15);
            this.bHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bHistory.Name = "bHistory";
            this.bHistory.Size = new System.Drawing.Size(112, 37);
            this.bHistory.TabIndex = 37;
            this.bHistory.Text = "History";
            this.bHistory.UseVisualStyleBackColor = true;
            this.bHistory.Click += new System.EventHandler(this.bHistory_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(162, 368);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(112, 37);
            this.bClose.TabIndex = 12;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(463, 368);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(112, 37);
            this.bExit.TabIndex = 11;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lTk
            // 
            this.lTk.AutoSize = true;
            this.lTk.Location = new System.Drawing.Point(496, 246);
            this.lTk.Name = "lTk";
            this.lTk.Size = new System.Drawing.Size(36, 21);
            this.lTk.TabIndex = 10;
            this.lTk.Text = "*Tk.";
            // 
            // lLt
            // 
            this.lLt.AutoSize = true;
            this.lLt.Location = new System.Drawing.Point(496, 186);
            this.lLt.Name = "lLt";
            this.lLt.Size = new System.Drawing.Size(33, 21);
            this.lLt.TabIndex = 9;
            this.lLt.Text = "*Lt.";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(259, 246);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(220, 29);
            this.tbAmount.TabIndex = 7;
            this.tbAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAmount_MouseClick);
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Location = new System.Drawing.Point(74, 254);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(73, 21);
            this.lAmount.TabIndex = 6;
            this.lAmount.Text = "Amount :";
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Location = new System.Drawing.Point(74, 190);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(77, 21);
            this.lQuantity.TabIndex = 5;
            this.lQuantity.Text = "Quantity :";
            // 
            // lOption
            // 
            this.lOption.AutoSize = true;
            this.lOption.Location = new System.Drawing.Point(74, 113);
            this.lOption.Name = "lOption";
            this.lOption.Size = new System.Drawing.Size(93, 21);
            this.lOption.TabIndex = 4;
            this.lOption.Text = "Select Item :";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(315, 368);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(112, 37);
            this.bSubmit.TabIndex = 3;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(259, 183);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(220, 29);
            this.tbQuantity.TabIndex = 2;
            this.tbQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbQuantity_MouseClick);
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // cbItem
            // 
            this.cbItem.DataSource = this.detailsBindingSource;
            this.cbItem.DisplayMember = "Items";
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(259, 111);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(220, 29);
            this.cbItem.TabIndex = 1;
            this.cbItem.ValueMember = "Items";
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "details";
            this.detailsBindingSource.DataSource = this.costDataSet;
            // 
            // costDataSet
            // 
            this.costDataSet.DataSetName = "costDataSet";
            this.costDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Cost :";
            // 
            // itemsDataSet
            // 
            this.itemsDataSet.DataSetName = "itemsDataSet";
            this.itemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsDataSetBindingSource
            // 
            this.itemsDataSetBindingSource.DataSource = this.itemsDataSet;
            this.itemsDataSetBindingSource.Position = 0;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // cbOthers
            // 
            this.cbOthers.FormattingEnabled = true;
            this.cbOthers.Items.AddRange(new object[] {
            "টেস্ট পণ্য",
            "টি এল ভাড়া",
            "কর্মচারীদের বেতন",
            "আন্ত পরিবহন ট্রাক ও ভ্যান ভাড়া",
            "পে-অর্ডার কমিশন",
            "ডিপো খরচ",
            "আপ্যায়ন",
            "যাতায়াত",
            "বিদ্যুৎ বিল",
            "ফোন বিল টি এন্ড টি",
            "মোবাইল ফোন বিল",
            "জেনারেটর খরচ",
            "ষ্টেশনারী খরচ",
            "পাম্প উন্নয়ন ও বিবিধ খরচ",
            "পিকআপ ৯৩ খরচ",
            "দান ও চাঁদা",
            "পত্রিকা বিল",
            "বিবিধ প্রিন্টিং, ফটোকপি ও কম্পিউটার বিল",
            "মেশিন মেরামত খরচ",
            "মটর সাইকেল",
            "চেক কালেকশন চার্জ খরচ",
            "সাহেব নেওয়া",
            "বাসায় খরচ"});
            this.cbOthers.Location = new System.Drawing.Point(259, 111);
            this.cbOthers.Name = "cbOthers";
            this.cbOthers.Size = new System.Drawing.Size(220, 29);
            this.cbOthers.TabIndex = 41;
            // 
            // FormCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::rabinSoft.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(696, 503);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cost";
            this.Load += new System.EventHandler(this.FormCost_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.Label lOption;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Label lTk;
        private System.Windows.Forms.Label lLt;
        private itemsDataSet itemsDataSet;
        private System.Windows.Forms.BindingSource itemsDataSetBindingSource;
        private costDataSet costDataSet;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private costDataSetTableAdapters.detailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bHistory;
        private System.Windows.Forms.Button bOption;
        private System.Windows.Forms.ComboBox cbOthers;

    }
}