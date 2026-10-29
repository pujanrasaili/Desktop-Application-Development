namespace AccessDB_CRUD
{
    partial class BackgroundWorkerex
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
            lblProgress = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            startbtn = new Button();
            cancelbtn = new Button();
            SuspendLayout();
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(299, 90);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(66, 20);
            lblProgress.TabIndex = 0;
            lblProgress.Text = "Program";
            // 
            // startbtn
            // 
            startbtn.Location = new Point(172, 208);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(94, 29);
            startbtn.TabIndex = 1;
            startbtn.Text = "Start";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += startbtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(406, 208);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(94, 29);
            cancelbtn.TabIndex = 2;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // BackgroundWorkerex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelbtn);
            Controls.Add(startbtn);
            Controls.Add(lblProgress);
            Name = "BackgroundWorkerex";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button startbtn;
        private Button cancelbtn;
    }
}