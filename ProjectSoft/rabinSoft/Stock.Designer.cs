namespace rabinSoft
{
    partial class FormStock
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
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDataSet = new rabinSoft.itemsDataSet();
            this.detailsTableAdapter = new rabinSoft.itemsDataSetTableAdapters.detailsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.lLt = new System.Windows.Forms.Label();
            this.lAvailable = new System.Windows.Forms.Label();
            this.lSelectItem = new System.Windows.Forms.Label();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.LAmount = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "details";
            this.detailsBindingSource.DataSource = this.itemsDataSet;
            // 
            // itemsDataSet
            // 
            this.itemsDataSet.DataSetName = "itemsDataSet";
            this.itemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bReset);
            this.panel1.Controls.Add(this.lLt);
            this.panel1.Controls.Add(this.lAvailable);
            this.panel1.Controls.Add(this.lSelectItem);
            this.panel1.Controls.Add(this.cbStock);
            this.panel1.Controls.Add(this.LAmount);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 319);
            this.panel1.TabIndex = 0;
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(291, 251);
            this.bReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(112, 37);
            this.bReset.TabIndex = 35;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // lLt
            // 
            this.lLt.AutoSize = true;
            this.lLt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLt.Location = new System.Drawing.Point(517, 165);
            this.lLt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLt.Name = "lLt";
            this.lLt.Size = new System.Drawing.Size(33, 21);
            this.lLt.TabIndex = 29;
            this.lLt.Text = "*Lt.";
            // 
            // lAvailable
            // 
            this.lAvailable.AutoSize = true;
            this.lAvailable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAvailable.Location = new System.Drawing.Point(119, 161);
            this.lAvailable.Name = "lAvailable";
            this.lAvailable.Size = new System.Drawing.Size(114, 25);
            this.lAvailable.TabIndex = 28;
            this.lAvailable.Text = "# Available :";
            // 
            // lSelectItem
            // 
            this.lSelectItem.AutoSize = true;
            this.lSelectItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSelectItem.Location = new System.Drawing.Point(119, 81);
            this.lSelectItem.Name = "lSelectItem";
            this.lSelectItem.Size = new System.Drawing.Size(129, 25);
            this.lSelectItem.TabIndex = 26;
            this.lSelectItem.Text = "# Select Item :";
            // 
            // cbStock
            // 
            this.cbStock.DataSource = this.detailsBindingSource;
            this.cbStock.DisplayMember = "Items";
            this.cbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(271, 81);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(222, 29);
            this.cbStock.TabIndex = 25;
            this.cbStock.ValueMember = "Items";
            this.cbStock.SelectedIndexChanged += new System.EventHandler(this.cbStock_SelectedIndexChanged);
            // 
            // LAmount
            // 
            this.LAmount.AutoSize = true;
            this.LAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAmount.Location = new System.Drawing.Point(344, 161);
            this.LAmount.Name = "LAmount";
            this.LAmount.Size = new System.Drawing.Size(0, 25);
            this.LAmount.TabIndex = 24;
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(422, 251);
            this.bExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(112, 37);
            this.bExit.TabIndex = 23;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(156, 251);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(112, 37);
            this.bClose.TabIndex = 22;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "# Resource Status :";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::rabinSoft.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 344);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private itemsDataSet itemsDataSet;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private itemsDataSetTableAdapters.detailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lLt;
        private System.Windows.Forms.Label lAvailable;
        private System.Windows.Forms.Label lSelectItem;
        private System.Windows.Forms.ComboBox cbStock;
        private System.Windows.Forms.Label LAmount;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label1;

    }
}