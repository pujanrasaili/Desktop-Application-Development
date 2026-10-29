namespace AccessDB_CRUD
{
    partial class Form1
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
            lblBookkey = new Label();
            lblTitle = new Label();
            lblPage = new Label();
            lblPublisher = new Label();
            dataGridView1 = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtBookkey = new TextBox();
            txtTitle = new TextBox();
            txtPage = new TextBox();
            txtPublisher = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblBookkey
            // 
            lblBookkey.AutoSize = true;
            lblBookkey.Location = new Point(729, 70);
            lblBookkey.Name = "lblBookkey";
            lblBookkey.Size = new Size(65, 20);
            lblBookkey.TabIndex = 0;
            lblBookkey.Text = "Bookkey";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(729, 124);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(729, 175);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(41, 20);
            lblPage.TabIndex = 2;
            lblPage.Text = "Page";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(729, 235);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(69, 20);
            lblPublisher.TabIndex = 3;
            lblPublisher.Text = "Publisher";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(598, 337);
            dataGridView1.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(704, 321);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(848, 321);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(988, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtBookkey
            // 
            txtBookkey.Location = new Point(834, 63);
            txtBookkey.Name = "txtBookkey";
            txtBookkey.Size = new Size(184, 27);
            txtBookkey.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(834, 117);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(184, 27);
            txtTitle.TabIndex = 9;
            // 
            // txtPage
            // 
            txtPage.Location = new Point(834, 168);
            txtPage.Name = "txtPage";
            txtPage.Size = new Size(184, 27);
            txtPage.TabIndex = 10;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(834, 228);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(184, 27);
            txtPublisher.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 557);
            Controls.Add(txtPublisher);
            Controls.Add(txtPage);
            Controls.Add(txtTitle);
            Controls.Add(txtBookkey);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Controls.Add(lblPublisher);
            Controls.Add(lblPage);
            Controls.Add(lblTitle);
            Controls.Add(lblBookkey);
            Name = "Form1";
            Text = "c";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookkey;
        private Label lblTitle;
        private Label lblPage;
        private Label lblPublisher;
        private DataGridView dataGridView1;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtBookkey;
        private TextBox txtTitle;
        private TextBox txtPage;
        private TextBox txtPublisher;
    }
}
