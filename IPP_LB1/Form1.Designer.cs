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
            this.labelPriorityThread1 = new System.Windows.Forms.Label();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.groupBoxValue2 = new System.Windows.Forms.GroupBox();
            this.labelPriorityThread2 = new System.Windows.Forms.Label();
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
            this.buttonStartSecondThread.Location = new System.Drawing.Point(342, 39);
            this.buttonStartSecondThread.Name = "buttonStartSecondThread";
            this.buttonStartSecondThread.Size = new System.Drawing.Size(209, 61);
            this.buttonStartSecondThread.TabIndex = 1;
            this.buttonStartSecondThread.Text = "Запустити другий потік";
            this.buttonStartSecondThread.UseVisualStyleBackColor = true;
            this.buttonStartSecondThread.Click += new System.EventHandler(this.buttonStartSecondThread_Click);
            // 
            // groupBoxValue1
            // 
            this.groupBoxValue1.Controls.Add(this.labelPriorityThread1);
            this.groupBoxValue1.Controls.Add(this.labelStatus1);
            this.groupBoxValue1.Location = new System.Drawing.Point(12, 240);
            this.groupBoxValue1.Name = "groupBoxValue1";
            this.groupBoxValue1.Size = new System.Drawing.Size(250, 104);
            this.groupBoxValue1.TabIndex = 6;
            this.groupBoxValue1.TabStop = false;
            this.groupBoxValue1.Text = "Value thread 1";
            // 
            // labelPriorityThread1
            // 
            this.labelPriorityThread1.Location = new System.Drawing.Point(6, 66);
            this.labelPriorityThread1.Name = "labelPriorityThread1";
            this.labelPriorityThread1.Size = new System.Drawing.Size(238, 29);
            this.labelPriorityThread1.TabIndex = 3;
            this.labelPriorityThread1.Text = "Priority: null";
            // 
            // labelStatus1
            // 
            this.labelStatus1.Location = new System.Drawing.Point(6, 37);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(238, 29);
            this.labelStatus1.TabIndex = 0;
            this.labelStatus1.Text = "Status: inactive";
            // 
            // groupBoxValue2
            // 
            this.groupBoxValue2.Controls.Add(this.labelPriorityThread2);
            this.groupBoxValue2.Controls.Add(this.labelStatus2);
            this.groupBoxValue2.Location = new System.Drawing.Point(301, 240);
            this.groupBoxValue2.Name = "groupBoxValue2";
            this.groupBoxValue2.Size = new System.Drawing.Size(250, 104);
            this.groupBoxValue2.TabIndex = 7;
            this.groupBoxValue2.TabStop = false;
            this.groupBoxValue2.Text = "Value thread 2";
            // 
            // labelPriorityThread2
            // 
            this.labelPriorityThread2.Location = new System.Drawing.Point(6, 66);
            this.labelPriorityThread2.Name = "labelPriorityThread2";
            this.labelPriorityThread2.Size = new System.Drawing.Size(238, 29);
            this.labelPriorityThread2.TabIndex = 4;
            this.labelPriorityThread2.Text = "Priority: null";
            // 
            // labelStatus2
            // 
            this.labelStatus2.Location = new System.Drawing.Point(6, 37);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(238, 29);
            this.labelStatus2.TabIndex = 1;
            this.labelStatus2.Text = "Status: inactive";
            // 
            // buttonUpPriorityThread1
            // 
            this.buttonUpPriorityThread1.Enabled = false;
            this.buttonUpPriorityThread1.Location = new System.Drawing.Point(12, 106);
            this.buttonUpPriorityThread1.Name = "buttonUpPriorityThread1";
            this.buttonUpPriorityThread1.Size = new System.Drawing.Size(210, 61);
            this.buttonUpPriorityThread1.TabIndex = 2;
            this.buttonUpPriorityThread1.Text = "Збільшити пріорітет першого потоку";
            this.buttonUpPriorityThread1.UseVisualStyleBackColor = true;
            this.buttonUpPriorityThread1.Click += new System.EventHandler(this.buttonUpPriorityThread1_Click);
            // 
            // buttonUpPriorityThread2
            // 
            this.buttonUpPriorityThread2.Enabled = false;
            this.buttonUpPriorityThread2.Location = new System.Drawing.Point(342, 106);
            this.buttonUpPriorityThread2.Name = "buttonUpPriorityThread2";
            this.buttonUpPriorityThread2.Size = new System.Drawing.Size(210, 61);
            this.buttonUpPriorityThread2.TabIndex = 3;
            this.buttonUpPriorityThread2.Text = "Збільшити пріорітет другого потоку";
            this.buttonUpPriorityThread2.UseVisualStyleBackColor = true;
            this.buttonUpPriorityThread2.Click += new System.EventHandler(this.buttonUpPriorityThread2_Click);
            // 
            // buttonDownPriorityThread1
            // 
            this.buttonDownPriorityThread1.Enabled = false;
            this.buttonDownPriorityThread1.Location = new System.Drawing.Point(12, 173);
            this.buttonDownPriorityThread1.Name = "buttonDownPriorityThread1";
            this.buttonDownPriorityThread1.Size = new System.Drawing.Size(210, 61);
            this.buttonDownPriorityThread1.TabIndex = 4;
            this.buttonDownPriorityThread1.Text = "Зменшити пріорітет першого потоку";
            this.buttonDownPriorityThread1.UseVisualStyleBackColor = true;
            this.buttonDownPriorityThread1.Click += new System.EventHandler(this.buttonDownPriorityThread1_Click);
            // 
            // buttonDownPriorityThread2
            // 
            this.buttonDownPriorityThread2.Enabled = false;
            this.buttonDownPriorityThread2.Location = new System.Drawing.Point(342, 173);
            this.buttonDownPriorityThread2.Name = "buttonDownPriorityThread2";
            this.buttonDownPriorityThread2.Size = new System.Drawing.Size(210, 61);
            this.buttonDownPriorityThread2.TabIndex = 5;
            this.buttonDownPriorityThread2.Text = "Зменшити пріорітет другого потоку";
            this.buttonDownPriorityThread2.UseVisualStyleBackColor = true;
            this.buttonDownPriorityThread2.Click += new System.EventHandler(this.buttonDownPriorityThread2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 356);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxValue1.ResumeLayout(false);
            this.groupBoxValue2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelStatus2;

        private System.Windows.Forms.Label labelStatus1;

        private System.Windows.Forms.GroupBox groupBoxValue1;
        private System.Windows.Forms.GroupBox groupBoxValue2;

        private System.Windows.Forms.Button buttonStartSecondThread;

        private System.Windows.Forms.Button buttonStartFirstThread;
        private System.Windows.Forms.Button buttonUpPriorityThread1;
        private System.Windows.Forms.Button buttonUpPriorityThread2;
        private System.Windows.Forms.Button buttonDownPriorityThread1;
        private System.Windows.Forms.Button buttonDownPriorityThread2;
        private Label labelPriorityThread1;
        private Label labelPriorityThread2;
    }
    #endregion
}