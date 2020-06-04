namespace k163965_Q1
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
            this.username = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.emailText = new System.Windows.Forms.TextBox();
            this.bpmLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.bpmValue = new System.Windows.Forms.NumericUpDown();
            this.genderList = new System.Windows.Forms.ListBox();
            this.bpmTimeLabel = new System.Windows.Forms.Label();
            this.bpmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bpmButton = new System.Windows.Forms.Button();
            this.bpmDateLabel = new System.Windows.Forms.Label();
            this.bpmDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confidenceLabel = new System.Windows.Forms.Label();
            this.confidenceValue = new System.Windows.Forms.NumericUpDown();
            this.userText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bpmValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confidenceValue)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(88, 69);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 17);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(88, 140);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(38, 17);
            this.dob.TabIndex = 1;
            this.dob.Text = "DOB";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(88, 214);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(56, 17);
            this.gender.TabIndex = 2;
            this.gender.Text = "Gender";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(88, 285);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(278, 140);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(243, 22);
            this.dobPicker.TabIndex = 5;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(278, 280);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(243, 22);
            this.emailText.TabIndex = 8;
            // 
            // bpmLabel
            // 
            this.bpmLabel.AutoSize = true;
            this.bpmLabel.Location = new System.Drawing.Point(642, 79);
            this.bpmLabel.Name = "bpmLabel";
            this.bpmLabel.Size = new System.Drawing.Size(35, 17);
            this.bpmLabel.TabIndex = 9;
            this.bpmLabel.Text = "bpm";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(163, 350);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(180, 47);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Add Patient";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // bpmValue
            // 
            this.bpmValue.Location = new System.Drawing.Point(746, 74);
            this.bpmValue.Name = "bpmValue";
            this.bpmValue.Size = new System.Drawing.Size(236, 22);
            this.bpmValue.TabIndex = 12;
            this.bpmValue.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // genderList
            // 
            this.genderList.FormattingEnabled = true;
            this.genderList.ItemHeight = 16;
            this.genderList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderList.Location = new System.Drawing.Point(278, 211);
            this.genderList.Name = "genderList";
            this.genderList.Size = new System.Drawing.Size(243, 20);
            this.genderList.TabIndex = 0;
            this.genderList.Tag = "";
            this.genderList.SelectedIndexChanged += new System.EventHandler(this.genderList_SelectedIndexChanged);
            // 
            // bpmTimeLabel
            // 
            this.bpmTimeLabel.AutoSize = true;
            this.bpmTimeLabel.Location = new System.Drawing.Point(614, 283);
            this.bpmTimeLabel.Name = "bpmTimeLabel";
            this.bpmTimeLabel.Size = new System.Drawing.Size(89, 17);
            this.bpmTimeLabel.TabIndex = 13;
            this.bpmTimeLabel.Text = "Record Time";
            // 
            // bpmTimePicker
            // 
            this.bpmTimePicker.Location = new System.Drawing.Point(746, 280);
            this.bpmTimePicker.Name = "bpmTimePicker";
            this.bpmTimePicker.Size = new System.Drawing.Size(236, 22);
            this.bpmTimePicker.TabIndex = 14;
            // 
            // bpmButton
            // 
            this.bpmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmButton.Location = new System.Drawing.Point(733, 350);
            this.bpmButton.Name = "bpmButton";
            this.bpmButton.Size = new System.Drawing.Size(198, 45);
            this.bpmButton.TabIndex = 15;
            this.bpmButton.Text = "Add Record";
            this.bpmButton.UseVisualStyleBackColor = true;
            this.bpmButton.Click += new System.EventHandler(this.bpmButton_Click);
            // 
            // bpmDateLabel
            // 
            this.bpmDateLabel.AutoSize = true;
            this.bpmDateLabel.Location = new System.Drawing.Point(615, 156);
            this.bpmDateLabel.Name = "bpmDateLabel";
            this.bpmDateLabel.Size = new System.Drawing.Size(88, 17);
            this.bpmDateLabel.TabIndex = 16;
            this.bpmDateLabel.Text = "Record Date";
            // 
            // bpmDatePicker
            // 
            this.bpmDatePicker.Location = new System.Drawing.Point(746, 156);
            this.bpmDatePicker.Name = "bpmDatePicker";
            this.bpmDatePicker.Size = new System.Drawing.Size(236, 22);
            this.bpmDatePicker.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(175, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(706, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Patient Heart Rate";
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.Location = new System.Drawing.Point(614, 219);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(117, 17);
            this.confidenceLabel.TabIndex = 20;
            this.confidenceLabel.Text = "Confidence Level";
            // 
            // confidenceValue
            // 
            this.confidenceValue.Location = new System.Drawing.Point(746, 217);
            this.confidenceValue.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.confidenceValue.Name = "confidenceValue";
            this.confidenceValue.ReadOnly = true;
            this.confidenceValue.Size = new System.Drawing.Size(236, 22);
            this.confidenceValue.TabIndex = 21;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(278, 64);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(243, 22);
            this.userText.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 611);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.confidenceValue);
            this.Controls.Add(this.confidenceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bpmDatePicker);
            this.Controls.Add(this.bpmDateLabel);
            this.Controls.Add(this.bpmButton);
            this.Controls.Add(this.bpmTimePicker);
            this.Controls.Add(this.bpmTimeLabel);
            this.Controls.Add(this.genderList);
            this.Controls.Add(this.bpmValue);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.bpmLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.email);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bpmValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confidenceValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label bpmLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.NumericUpDown bpmValue;
        private System.Windows.Forms.ListBox genderList;
        private System.Windows.Forms.Label bpmTimeLabel;
        private System.Windows.Forms.DateTimePicker bpmTimePicker;
        private System.Windows.Forms.Button bpmButton;
        private System.Windows.Forms.Label bpmDateLabel;
        private System.Windows.Forms.DateTimePicker bpmDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label confidenceLabel;
        private System.Windows.Forms.NumericUpDown confidenceValue;
        private System.Windows.Forms.TextBox userText;
    }
}

