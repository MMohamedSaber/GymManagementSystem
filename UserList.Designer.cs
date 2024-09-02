namespace gymsystemProject
{
    partial class UserList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridView dataGridView1;
            this.clEndat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStartFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPlane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clEndat
            // 
            this.clEndat.HeaderText = "End At";
            this.clEndat.Name = "clEndat";
            this.clEndat.Width = 81;
            // 
            // clStartFrom
            // 
            this.clStartFrom.HeaderText = "Start From";
            this.clStartFrom.Name = "clStartFrom";
            this.clStartFrom.Width = 113;
            // 
            // clTime
            // 
            this.clTime.HeaderText = "Time";
            this.clTime.Name = "clTime";
            this.clTime.Width = 67;
            // 
            // clPlane
            // 
            this.clPlane.HeaderText = "Plane";
            this.clPlane.Name = "clPlane";
            this.clPlane.Width = 68;
            // 
            // clPhone
            // 
            this.clPhone.HeaderText = "Phone Number";
            this.clPhone.Name = "clPhone";
            this.clPhone.Width = 129;
            // 
            // clLastName
            // 
            this.clLastName.HeaderText = "Last Name";
            this.clLastName.Name = "clLastName";
            this.clLastName.Width = 108;
            // 
            // clMidName
            // 
            this.clMidName.HeaderText = "Meddil Name";
            this.clMidName.Name = "clMidName";
            this.clMidName.Width = 122;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 52;
            // 
            // clFirstName
            // 
            this.clFirstName.HeaderText = "First Name";
            this.clFirstName.Name = "clFirstName";
            this.clFirstName.Width = 112;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFirstName,
            this.Column1,
            this.clMidName,
            this.clLastName,
            this.clPhone,
            this.clPlane,
            this.clTime,
            this.clStartFrom,
            this.clEndat});
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.Color.Chocolate;
            dataGridView1.Location = new System.Drawing.Point(1, 1);
            dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(898, 270);
            dataGridView1.TabIndex = 1;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(979, 484);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clEndat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStartFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPlane;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFirstName;
    }
}
