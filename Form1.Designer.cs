namespace Ignacio_LabAct3
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

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPatientName = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            txtReason = new TextBox();
            label6 = new Label();
            cmbPatientType = new ComboBox();
            btnAddQueue = new Button();
            btnClear = new Button();
            label7 = new Label();
            lblQueueNumber = new Label();
            lblPatientType = new Label();
            lblPriority = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(510, 37);
            label1.TabIndex = 0;
            label1.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 1;
            label2.Text = "Patient Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 125);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 2;
            label3.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(176, 124);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(250, 23);
            txtPatientName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 163);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 4;
            label4.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(176, 162);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 201);
            label5.Name = "label5";
            label5.Size = new Size(107, 19);
            label5.TabIndex = 6;
            label5.Text = "Reason for Visit:";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(176, 200);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(250, 23);
            txtReason.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 239);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 8;
            label6.Text = "Patient Type:";
            // 
            // cmbPatientType
            // 
            cmbPatientType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatientType.FormattingEnabled = true;
            cmbPatientType.Items.AddRange(new object[] { "Emergency", "Senior", "Pregnant", "Regular" });
            cmbPatientType.Location = new Point(176, 238);
            cmbPatientType.Name = "cmbPatientType";
            cmbPatientType.Size = new Size(180, 23);
            cmbPatientType.TabIndex = 9;
            // 
            // btnAddQueue
            // 
            btnAddQueue.BackColor = Color.Orange;
            btnAddQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddQueue.Location = new Point(63, 285);
            btnAddQueue.Name = "btnAddQueue";
            btnAddQueue.Size = new Size(140, 35);
            btnAddQueue.TabIndex = 10;
            btnAddQueue.Text = "ADD TO QUEUE";
            btnAddQueue.UseVisualStyleBackColor = false;
            btnAddQueue.Click += btnAddQueue_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(220, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(35, 350);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 12;
            label7.Text = "Queue Result";
            // 
            // lblQueueNumber
            // 
            lblQueueNumber.AutoSize = true;
            lblQueueNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueueNumber.Location = new Point(63, 390);
            lblQueueNumber.Name = "lblQueueNumber";
            lblQueueNumber.Size = new Size(111, 19);
            lblQueueNumber.TabIndex = 13;
            lblQueueNumber.Text = "Queue Number: ";
            // 
            // lblPatientType
            // 
            lblPatientType.AutoSize = true;
            lblPatientType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatientType.Location = new Point(63, 420);
            lblPatientType.Name = "lblPatientType";
            lblPatientType.Size = new Size(91, 19);
            lblPatientType.TabIndex = 14;
            lblPatientType.Text = "Patient Type: ";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPriority.ForeColor = Color.Black;
            lblPriority.Location = new Point(63, 449);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(60, 19);
            lblPriority.TabIndex = 15;
            lblPriority.Text = "Priority: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 500);
            Controls.Add(lblPriority);
            Controls.Add(lblPatientType);
            Controls.Add(lblQueueNumber);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnAddQueue);
            Controls.Add(cmbPatientType);
            Controls.Add(label6);
            Controls.Add(txtReason);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtPatientName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Queue Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPatientName;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtReason;
        private Label label6;
        private ComboBox cmbPatientType;
        private Button btnAddQueue;
        private Button btnClear;
        private Label label7;
        private Label lblQueueNumber;
        private Label lblPatientType;
        private Label lblPriority;
    }
}
