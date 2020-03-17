namespace rabinSoft
{
    partial class FormDue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lDue = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.bHistory = new System.Windows.Forms.Button();
            this.lTk = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lAmount = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.tbPlate = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.lList = new System.Windows.Forms.Label();
            this.lCustomer = new System.Windows.Forms.Label();
            this.lPlate = new System.Windows.Forms.Label();
            this.dgvDue = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDue)).BeginInit();
            this.SuspendLayout();
            // 
            // lDue
            // 
            this.lDue.AutoSize = true;
            this.lDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDue.Location = new System.Drawing.Point(12, 24);
            this.lDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDue.Name = "lDue";
            this.lDue.Size = new System.Drawing.Size(105, 21);
            this.lDue.TabIndex = 9;
            this.lDue.Text = "# Due Status :";
            // 
            // bClose
            // 
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(151, 430);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(112, 32);
            this.bClose.TabIndex = 22;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(449, 430);
            this.bExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(112, 32);
            this.bExit.TabIndex = 23;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bReset);
            this.panel1.Controls.Add(this.bHistory);
            this.panel1.Controls.Add(this.lTk);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.lAmount);
            this.panel1.Controls.Add(this.bUpdate);
            this.panel1.Controls.Add(this.tbPlate);
            this.panel1.Controls.Add(this.tbCustomer);
            this.panel1.Controls.Add(this.lList);
            this.panel1.Controls.Add(this.lCustomer);
            this.panel1.Controls.Add(this.lPlate);
            this.panel1.Controls.Add(this.dgvDue);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.lDue);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 486);
            this.panel1.TabIndex = 1;
            // 
            // bReset
            // 
            this.bReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(298, 430);
            this.bReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(112, 32);
            this.bReset.TabIndex = 37;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bHistory
            // 
            this.bHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHistory.Location = new System.Drawing.Point(552, 11);
            this.bHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bHistory.Name = "bHistory";
            this.bHistory.Size = new System.Drawing.Size(112, 32);
            this.bHistory.TabIndex = 36;
            this.bHistory.Text = "History";
            this.bHistory.UseVisualStyleBackColor = true;
            this.bHistory.Click += new System.EventHandler(this.bHistory_Click);
            // 
            // lTk
            // 
            this.lTk.AutoSize = true;
            this.lTk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTk.Location = new System.Drawing.Point(324, 113);
            this.lTk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTk.Name = "lTk";
            this.lTk.Size = new System.Drawing.Size(29, 21);
            this.lTk.TabIndex = 35;
            this.lTk.Text = "Tk.";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(123, 109);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(180, 29);
            this.tbAmount.TabIndex = 34;
            this.tbAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAmount_MouseClick);
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmount.Location = new System.Drawing.Point(21, 111);
            this.lAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(73, 21);
            this.lAmount.TabIndex = 33;
            this.lAmount.Text = "Amount :";
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(552, 103);
            this.bUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(112, 32);
            this.bUpdate.TabIndex = 32;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // tbPlate
            // 
            this.tbPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlate.Location = new System.Drawing.Point(484, 60);
            this.tbPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(180, 29);
            this.tbPlate.TabIndex = 31;
            this.tbPlate.TextChanged += new System.EventHandler(this.tbPlate_TextChanged);
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(123, 60);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(180, 29);
            this.tbCustomer.TabIndex = 30;
            this.tbCustomer.TextChanged += new System.EventHandler(this.tbCustomer_TextChanged);
            // 
            // lList
            // 
            this.lList.AutoSize = true;
            this.lList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lList.Location = new System.Drawing.Point(294, 145);
            this.lList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lList.Name = "lList";
            this.lList.Size = new System.Drawing.Size(86, 21);
            this.lList.TabIndex = 28;
            this.lList.Text = "# Due List :";
            // 
            // lCustomer
            // 
            this.lCustomer.AutoSize = true;
            this.lCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCustomer.Location = new System.Drawing.Point(21, 63);
            this.lCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCustomer.Name = "lCustomer";
            this.lCustomer.Size = new System.Drawing.Size(85, 21);
            this.lCustomer.TabIndex = 26;
            this.lCustomer.Text = "Customer :";
            // 
            // lPlate
            // 
            this.lPlate.AutoSize = true;
            this.lPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlate.Location = new System.Drawing.Point(424, 63);
            this.lPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlate.Name = "lPlate";
            this.lPlate.Size = new System.Drawing.Size(51, 21);
            this.lPlate.TabIndex = 25;
            this.lPlate.Text = "Plate :";
            // 
            // dgvDue
            // 
            this.dgvDue.AllowUserToAddRows = false;
            this.dgvDue.AllowUserToDeleteRows = false;
            this.dgvDue.AllowUserToResizeColumns = false;
            this.dgvDue.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDue.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDue.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDue.Location = new System.Drawing.Point(24, 177);
            this.dgvDue.Name = "dgvDue";
            this.dgvDue.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDue.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDue.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDue.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDue.Size = new System.Drawing.Size(625, 220);
            this.dgvDue.TabIndex = 24;
            // 
            // FormDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::rabinSoft.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(696, 503);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Due";
            this.Load += new System.EventHandler(this.Due_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lDue;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDue;
        private System.Windows.Forms.Label lList;
        private System.Windows.Forms.Label lCustomer;
        private System.Windows.Forms.Label lPlate;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbPlate;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Label lTk;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Button bHistory;
        private System.Windows.Forms.Button bReset;

    }
}