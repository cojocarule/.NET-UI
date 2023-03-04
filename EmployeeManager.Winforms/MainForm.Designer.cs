namespace EmployeeManager.Winforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new System.Windows.Forms.Panel();
            headerControl1 = new Controls.HeaderControl();
            pnlNavigation = new System.Windows.Forms.Panel();
            lsbEmployees = new System.Windows.Forms.ListBox();
            pnlRefresh = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            pnlMainArea = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            chkIsCofeeDrinker = new System.Windows.Forms.CheckBox();
            cboJobRole = new System.Windows.Forms.ComboBox();
            dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblJobRole = new System.Windows.Forms.Label();
            lblEntryDate = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            employeeBindingSource = new System.Windows.Forms.BindingSource(components);
            pnlHeader.SuspendLayout();
            pnlNavigation.SuspendLayout();
            pnlRefresh.SuspendLayout();
            pnlMainArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(headerControl1);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(599, 65);
            pnlHeader.TabIndex = 0;
            // 
            // headerControl1
            // 
            headerControl1.BackColor = System.Drawing.Color.FromArgb(240, 90, 40);
            headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            headerControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            headerControl1.Location = new System.Drawing.Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new System.Drawing.Size(599, 65);
            headerControl1.TabIndex = 0;
            headerControl1.Load += headerControl1_Load;
            // 
            // pnlNavigation
            // 
            pnlNavigation.Controls.Add(lsbEmployees);
            pnlNavigation.Controls.Add(pnlRefresh);
            pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            pnlNavigation.Location = new System.Drawing.Point(0, 65);
            pnlNavigation.Margin = new System.Windows.Forms.Padding(2);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new System.Drawing.Size(148, 379);
            pnlNavigation.TabIndex = 1;
            // 
            // lsbEmployees
            // 
            lsbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            lsbEmployees.FormattingEnabled = true;
            lsbEmployees.ItemHeight = 15;
            lsbEmployees.Location = new System.Drawing.Point(0, 55);
            lsbEmployees.Name = "lsbEmployees";
            lsbEmployees.Size = new System.Drawing.Size(148, 324);
            lsbEmployees.TabIndex = 1;
            // 
            // pnlRefresh
            // 
            pnlRefresh.Controls.Add(btnRefresh);
            pnlRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            pnlRefresh.Location = new System.Drawing.Point(0, 0);
            pnlRefresh.Name = "pnlRefresh";
            pnlRefresh.Size = new System.Drawing.Size(148, 55);
            pnlRefresh.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnRefresh.Location = new System.Drawing.Point(12, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(131, 23);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlMainArea
            // 
            pnlMainArea.Controls.Add(btnSave);
            pnlMainArea.Controls.Add(chkIsCofeeDrinker);
            pnlMainArea.Controls.Add(cboJobRole);
            pnlMainArea.Controls.Add(dtpEntryDate);
            pnlMainArea.Controls.Add(txtFirstName);
            pnlMainArea.Controls.Add(lblJobRole);
            pnlMainArea.Controls.Add(lblEntryDate);
            pnlMainArea.Controls.Add(lblFirstName);
            pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainArea.Location = new System.Drawing.Point(148, 65);
            pnlMainArea.Margin = new System.Windows.Forms.Padding(2);
            pnlMainArea.Name = "pnlMainArea";
            pnlMainArea.Size = new System.Drawing.Size(451, 379);
            pnlMainArea.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSave.Location = new System.Drawing.Point(23, 278);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // chkIsCofeeDrinker
            // 
            chkIsCofeeDrinker.AutoSize = true;
            chkIsCofeeDrinker.Location = new System.Drawing.Point(26, 229);
            chkIsCofeeDrinker.Name = "chkIsCofeeDrinker";
            chkIsCofeeDrinker.Size = new System.Drawing.Size(106, 19);
            chkIsCofeeDrinker.TabIndex = 6;
            chkIsCofeeDrinker.Text = "Is cofee drinker";
            chkIsCofeeDrinker.UseVisualStyleBackColor = true;
            // 
            // cboJobRole
            // 
            cboJobRole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboJobRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboJobRole.FormattingEnabled = true;
            cboJobRole.Location = new System.Drawing.Point(22, 174);
            cboJobRole.Name = "cboJobRole";
            cboJobRole.Size = new System.Drawing.Size(417, 23);
            cboJobRole.TabIndex = 5;
            // 
            // dtpEntryDate
            // 
            dtpEntryDate.Location = new System.Drawing.Point(22, 103);
            dtpEntryDate.Name = "dtpEntryDate";
            dtpEntryDate.Size = new System.Drawing.Size(199, 23);
            dtpEntryDate.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFirstName.Location = new System.Drawing.Point(23, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(416, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblJobRole
            // 
            lblJobRole.AutoSize = true;
            lblJobRole.Location = new System.Drawing.Point(23, 156);
            lblJobRole.Name = "lblJobRole";
            lblJobRole.Size = new System.Drawing.Size(48, 15);
            lblJobRole.TabIndex = 2;
            lblJobRole.Text = "Job role";
            // 
            // lblEntryDate
            // 
            lblEntryDate.AutoSize = true;
            lblEntryDate.Location = new System.Drawing.Point(22, 85);
            lblEntryDate.Name = "lblEntryDate";
            lblEntryDate.Size = new System.Drawing.Size(60, 15);
            lblEntryDate.TabIndex = 1;
            lblEntryDate.Text = "Entry date";
            lblEntryDate.Click += lblEntryDate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(23, 18);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(59, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Firstname";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(599, 444);
            Controls.Add(pnlMainArea);
            Controls.Add(pnlNavigation);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlNavigation.ResumeLayout(false);
            pnlRefresh.ResumeLayout(false);
            pnlMainArea.ResumeLayout(false);
            pnlMainArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.ListBox lsbEmployees;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlMainArea;
        private System.Windows.Forms.Label lblJobRole;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkIsCofeeDrinker;
        private System.Windows.Forms.ComboBox cboJobRole;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}
