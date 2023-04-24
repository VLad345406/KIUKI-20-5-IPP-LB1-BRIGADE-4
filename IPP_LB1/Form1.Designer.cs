using System.Windows.Forms;

namespace IPP_LB1
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
            this.buttonStartFirstThread = new System.Windows.Forms.Button();
            this.buttonStartSecondThread = new System.Windows.Forms.Button();
            this.groupBoxValue1 = new System.Windows.Forms.GroupBox();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelValue1 = new System.Windows.Forms.Label();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.groupBoxValue2 = new System.Windows.Forms.GroupBox();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelValue2 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.buttonUpPriorityThread1 = new System.Windows.Forms.Button();
            this.buttonUpPriorityThread2 = new System.Windows.Forms.Button();
            this.buttonDownPriorityThread1 = new System.Windows.Forms.Button();
            this.buttonDownPriorityThread2 = new System.Windows.Forms.Button();
            this.groupBoxValue1.SuspendLayout();
            this.groupBoxValue2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartFirstThread
            // 
            this.buttonStartFirstThread.Location = new System.Drawing.Point(12, 39);
            this.buttonStartFirstThread.Name = "buttonStartFirstThread";
            this.buttonStartFirstThread.Size = new System.Drawing.Size(210, 61);
            this.buttonStartFirstThread.TabIndex = 0;
            this.buttonStartFirstThread.Text = "Запустити перший потік";
            this.buttonStartFirstThread.UseVisualStyleBackColor = true;
            this.buttonStartFirstThread.Click += new System.EventHandler(this.buttonStartFirstThread_Click);
            // 
            // buttonStartSecondThread
            // 
            this.buttonStartSecondThread.Location = new System.Drawing.Point(230, 39);
            this.buttonStartSecondThread.Name = "buttonStartSecondThread";
            this.buttonStartSecondThread.Size = new System.Drawing.Size(209, 61);
            this.buttonStartSecondThread.TabIndex = 1;
            this.buttonStartSecondThread.Text = "Запустити другий потік";
            this.buttonStartSecondThread.UseVisualStyleBackColor = true;
            this.buttonStartSecondThread.Click += new System.EventHandler(this.buttonStartSecondThread_Click);
            // 
            // groupBoxValue1
            // 
            this.groupBoxValue1.Controls.Add(this.labelTime1);
            this.groupBoxValue1.Controls.Add(this.labelValue1);
            this.groupBoxValue1.Controls.Add(this.labelStatus1);
            this.groupBoxValue1.Location = new System.Drawing.Point(12, 240);
            this.groupBoxValue1.Name = "groupBoxValue1";
            this.groupBoxValue1.Size = new System.Drawing.Size(191, 202);
            this.groupBoxValue1.TabIndex = 6;
            this.groupBoxValue1.TabStop = false;
            this.groupBoxValue1.Text = "Value thread 1";
            // 
            // labelTime1
            // 
            this.labelTime1.Location = new System.Drawing.Point(6, 95);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(159, 29);
            this.labelTime1.TabIndex = 2;
            this.labelTime1.Text = "Spent time: 0";
            // 
            // labelValue1
            // 
            this.labelValue1.Location = new System.Drawing.Point(6, 66);
            this.labelValue1.Name = "labelValue1";
            this.labelValue1.Size = new System.Drawing.Size(159, 29);
            this.labelValue1.TabIndex = 1;
            this.labelValue1.Text = "Current value: 0";
            // 
            // labelStatus1
            // 
            this.labelStatus1.Location = new System.Drawing.Point(6, 37);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(159, 29);
            this.labelStatus1.TabIndex = 0;
            this.labelStatus1.Text = "Status: inactive";
            // 
            // groupBoxValue2
            // 
            this.groupBoxValue2.Controls.Add(this.labelTime2);
            this.groupBoxValue2.Controls.Add(this.labelValue2);
            this.groupBoxValue2.Controls.Add(this.labelStatus2);
            this.groupBoxValue2.Location = new System.Drawing.Point(248, 240);
            this.groupBoxValue2.Name = "groupBoxValue2";
            this.groupBoxValue2.Size = new System.Drawing.Size(191, 202);
            this.groupBoxValue2.TabIndex = 7;
            this.groupBoxValue2.TabStop = false;
            this.groupBoxValue2.Text = "Value thread 2";
            // 
            // labelTime2
            // 
            this.labelTime2.Location = new System.Drawing.Point(6, 95);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(159, 29);
            this.labelTime2.TabIndex = 3;
            this.labelTime2.Text = "Spent time: 0";
            // 
            // labelValue2
            // 
            this.labelValue2.Location = new System.Drawing.Point(6, 66);
            this.labelValue2.Name = "labelValue2";
            this.labelValue2.Size = new System.Drawing.Size(159, 29);
            this.labelValue2.TabIndex = 2;
            this.labelValue2.Text = "Current value: 0";
            // 
            // labelStatus2
            // 
            this.labelStatus2.Location = new System.Drawing.Point(6, 37);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(159, 29);
            this.labelStatus2.TabIndex = 1;
            this.labelStatus2.Text = "Status: inactive";
            // 
            // buttonUpPriorityThread1
            // 
            this.buttonUpPriorityThread1.Location = new System.Drawing.Point(12, 106);
            this.buttonUpPriorityThread1.Name = "buttonUpPriorityThread1";
            this.buttonUpPriorityThread1.Size = new System.Drawing.Size(210, 61);
            this.buttonUpPriorityThread1.TabIndex = 2;
            this.buttonUpPriorityThread1.Text = "Збільшити пріорітет першого потоку";
            this.buttonUpPriorityThread1.UseVisualStyleBackColor = true;
            // 
            // buttonUpPriorityThread2
            // 
            this.buttonUpPriorityThread2.Location = new System.Drawing.Point(230, 106);
            this.buttonUpPriorityThread2.Name = "buttonUpPriorityThread2";
            this.buttonUpPriorityThread2.Size = new System.Drawing.Size(210, 61);
            this.buttonUpPriorityThread2.TabIndex = 3;
            this.buttonUpPriorityThread2.Text = "Збільшити пріорітет другого потоку";
            this.buttonUpPriorityThread2.UseVisualStyleBackColor = true;
            // 
            // buttonDownPriorityThread1
            // 
            this.buttonDownPriorityThread1.Location = new System.Drawing.Point(12, 173);
            this.buttonDownPriorityThread1.Name = "buttonDownPriorityThread1";
            this.buttonDownPriorityThread1.Size = new System.Drawing.Size(210, 61);
            this.buttonDownPriorityThread1.TabIndex = 4;
            this.buttonDownPriorityThread1.Text = "Зменшити пріорітет першого потоку";
            this.buttonDownPriorityThread1.UseVisualStyleBackColor = true;
            // 
            // buttonDownPriorityThread2
            // 
            this.buttonDownPriorityThread2.Location = new System.Drawing.Point(230, 173);
            this.buttonDownPriorityThread2.Name = "buttonDownPriorityThread2";
            this.buttonDownPriorityThread2.Size = new System.Drawing.Size(210, 61);
            this.buttonDownPriorityThread2.TabIndex = 5;
            this.buttonDownPriorityThread2.Text = "Зменшити пріорітет другого потоку";
            this.buttonDownPriorityThread2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 454);
            this.Controls.Add(this.buttonDownPriorityThread2);
            this.Controls.Add(this.buttonDownPriorityThread1);
            this.Controls.Add(this.buttonUpPriorityThread2);
            this.Controls.Add(this.buttonUpPriorityThread1);
            this.Controls.Add(this.groupBoxValue2);
            this.Controls.Add(this.groupBoxValue1);
            this.Controls.Add(this.buttonStartSecondThread);
            this.Controls.Add(this.buttonStartFirstThread);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxValue1.ResumeLayout(false);
            this.groupBoxValue2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelValue1;
        private System.Windows.Forms.Label labelValue2;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelTime2;

        private System.Windows.Forms.Label labelStatus2;

        private System.Windows.Forms.Label labelStatus1;

        private System.Windows.Forms.GroupBox groupBoxValue1;
        private System.Windows.Forms.GroupBox groupBoxValue2;

        private System.Windows.Forms.Button buttonStartSecondThread;

        private System.Windows.Forms.Button buttonStartFirstThread;
        private Button buttonUpPriorityThread1;
        private Button buttonUpPriorityThread2;
        private Button buttonDownPriorityThread1;
        private Button buttonDownPriorityThread2;
    }
    #endregion
}