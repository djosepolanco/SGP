namespace SGP.Forms.Clients
{
    partial class Clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.list = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.cmbClientType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.form.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.list);
            this.tab.Controls.Add(this.form);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(939, 573);
            this.tab.TabIndex = 1;
            // 
            // list
            // 
            this.list.Controls.Add(this.splitContainer1);
            this.list.Location = new System.Drawing.Point(4, 22);
            this.list.Name = "list";
            this.list.Padding = new System.Windows.Forms.Padding(3);
            this.list.Size = new System.Drawing.Size(931, 547);
            this.list.TabIndex = 0;
            this.list.Text = "List";
            this.list.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridClients);
            this.splitContainer1.Size = new System.Drawing.Size(925, 541);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(698, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Location = new System.Drawing.Point(808, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 43);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Nuevo";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(651, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AllowUserToOrderColumns = true;
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClients.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClients.ColumnHeadersHeight = 30;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.ClientType,
            this.Identification});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridClients.RowHeadersVisible = false;
            this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClients.Size = new System.Drawing.Size(925, 467);
            this.dataGridClients.StandardTab = true;
            this.dataGridClients.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Nombre / Razón Social";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // ClientType
            // 
            this.ClientType.HeaderText = "Tipo Cliente";
            this.ClientType.Name = "ClientType";
            this.ClientType.ReadOnly = true;
            // 
            // Identification
            // 
            this.Identification.HeaderText = "Identificación";
            this.Identification.Name = "Identification";
            this.Identification.ReadOnly = true;
            // 
            // form
            // 
            this.form.Controls.Add(this.groupBox1);
            this.form.Controls.Add(this.btnSave);
            this.form.Controls.Add(this.btnCancel);
            this.form.Controls.Add(this.grpBox);
            this.form.Location = new System.Drawing.Point(4, 22);
            this.form.Name = "form";
            this.form.Padding = new System.Windows.Forms.Padding(3);
            this.form.Size = new System.Drawing.Size(931, 547);
            this.form.TabIndex = 1;
            this.form.Text = "Form";
            this.form.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 291);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(911, 270);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn2.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(818, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(707, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.cmbClientType);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.txtIdentification);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.txtFullName);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.Location = new System.Drawing.Point(8, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(914, 165);
            this.grpBox.TabIndex = 2;
            this.grpBox.TabStop = false;
            // 
            // cmbClientType
            // 
            this.cmbClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientType.FormattingEnabled = true;
            this.cmbClientType.Location = new System.Drawing.Point(218, 117);
            this.cmbClientType.Name = "cmbClientType";
            this.cmbClientType.Size = new System.Drawing.Size(309, 28);
            this.cmbClientType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Cliente";
            // 
            // txtIdentification
            // 
            this.txtIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentification.Location = new System.Drawing.Point(218, 71);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(309, 26);
            this.txtIdentification.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identificación";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(218, 25);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(662, 26);
            this.txtFullName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre / Razon Social";
            // 
            // Clients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(939, 573);
            this.Controls.Add(this.tab);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clients_FormClosed);
            this.Load += new System.EventHandler(this.Clients_Load);
            this.tab.ResumeLayout(false);
            this.list.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.form.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage list;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.TabPage form;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identification;
        private System.Windows.Forms.ComboBox cmbClientType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}