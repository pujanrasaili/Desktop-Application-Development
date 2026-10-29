using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccessDB_CRUD
{
    public partial class BackgroundWorkerex : Form
    {
        public BackgroundWorkerex()
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
        }
        public void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    MessageBox.Show("cancelled was pressed");
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        public void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgress.Text = e.ProgressPercentage.ToString() + "%";
        }

        public void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                lblProgress.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                lblProgress.Text = "Error: " + e.Error.Message;
            }
            else
            {
                lblProgress.Text = "Done!";
            }

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
           backgroundWorker1.CancelAsync();

        }
    }
}
