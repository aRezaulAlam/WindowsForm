namespace SaveLoadDataWindowsForm
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
            this.rowNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBrowse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.depLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBrowse = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rowNameTextBox
            // 
            this.rowNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowNameTextBox.Location = new System.Drawing.Point(39, 41);
            this.rowNameTextBox.Name = "rowNameTextBox";
            this.rowNameTextBox.Size = new System.Drawing.Size(162, 34);
            this.rowNameTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(238, 41);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(701, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 34);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(836, 41);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(122, 34);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save and Load Data";
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.rowName,
            this.indLocation,
            this.iBrowse,
            this.depLocation,
            this.dBrowse});
            this.mainDataGridView.Location = new System.Drawing.Point(39, 108);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowTemplate.Height = 24;
            this.mainDataGridView.Size = new System.Drawing.Size(919, 449);
            this.mainDataGridView.TabIndex = 5;
            this.mainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentClick);
            // 
            // checkBox
            // 
            this.checkBox.HeaderText = "Check";
            this.checkBox.Name = "checkBox";
            this.checkBox.Width = 30;
            // 
            // rowName
            // 
            this.rowName.HeaderText = "rowName";
            this.rowName.Name = "rowName";
            // 
            // indLocation
            // 
            this.indLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.indLocation.HeaderText = "iLocation";
            this.indLocation.Name = "indLocation";
            // 
            // iBrowse
            // 
            this.iBrowse.HeaderText = "iBrowse";
            this.iBrowse.Name = "iBrowse";
            // 
            // depLocation
            // 
            this.depLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depLocation.HeaderText = "dLocation";
            this.depLocation.MinimumWidth = 25;
            this.depLocation.Name = "depLocation";
            // 
            // dBrowse
            // 
            this.dBrowse.HeaderText = "dBrowse";
            this.dBrowse.Name = "dBrowse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 589);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.rowNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn indLocation;
        private System.Windows.Forms.DataGridViewButtonColumn iBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn depLocation;
        private System.Windows.Forms.DataGridViewButtonColumn dBrowse;
    }
}

