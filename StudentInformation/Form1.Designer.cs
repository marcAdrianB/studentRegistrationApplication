namespace StudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.registerStud = new System.Windows.Forms.Button();
            this.rLast = new System.Windows.Forms.Label();
            this.rFirst = new System.Windows.Forms.Label();
            this.rGender = new System.Windows.Forms.Label();
            this.rBday = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(13, 94);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(278, 20);
            this.lastName.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(13, 148);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(278, 20);
            this.firstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(13, 202);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(278, 20);
            this.middleName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Middle Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.BackColor = System.Drawing.Color.Transparent;
            this.maleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleButton.Location = new System.Drawing.Point(81, 241);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(53, 19);
            this.maleButton.TabIndex = 8;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = false;
            this.maleButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.BackColor = System.Drawing.Color.Transparent;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleButton.Location = new System.Drawing.Point(150, 241);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(67, 19);
            this.femaleButton.TabIndex = 9;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // day
            // 
            this.day.FormattingEnabled = true;
            this.day.Location = new System.Drawing.Point(13, 303);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(85, 21);
            this.day.TabIndex = 11;
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(104, 303);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(94, 21);
            this.month.TabIndex = 12;
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(204, 303);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(87, 21);
            this.year.TabIndex = 13;
            // 
            // registerStud
            // 
            this.registerStud.BackColor = System.Drawing.Color.Crimson;
            this.registerStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerStud.ForeColor = System.Drawing.Color.White;
            this.registerStud.Location = new System.Drawing.Point(81, 341);
            this.registerStud.Name = "registerStud";
            this.registerStud.Size = new System.Drawing.Size(136, 34);
            this.registerStud.TabIndex = 14;
            this.registerStud.Text = "Register Student";
            this.registerStud.UseVisualStyleBackColor = false;
            this.registerStud.Click += new System.EventHandler(this.registerStud_Click);
            // 
            // rLast
            // 
            this.rLast.AutoSize = true;
            this.rLast.BackColor = System.Drawing.Color.Transparent;
            this.rLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLast.ForeColor = System.Drawing.Color.Crimson;
            this.rLast.Location = new System.Drawing.Point(99, 71);
            this.rLast.Name = "rLast";
            this.rLast.Size = new System.Drawing.Size(0, 13);
            this.rLast.TabIndex = 15;
            // 
            // rFirst
            // 
            this.rFirst.AutoSize = true;
            this.rFirst.BackColor = System.Drawing.Color.Transparent;
            this.rFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFirst.ForeColor = System.Drawing.Color.Crimson;
            this.rFirst.Location = new System.Drawing.Point(98, 125);
            this.rFirst.Name = "rFirst";
            this.rFirst.Size = new System.Drawing.Size(0, 13);
            this.rFirst.TabIndex = 16;
            // 
            // rGender
            // 
            this.rGender.BackColor = System.Drawing.Color.Transparent;
            this.rGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rGender.ForeColor = System.Drawing.Color.Crimson;
            this.rGender.Location = new System.Drawing.Point(223, 243);
            this.rGender.Name = "rGender";
            this.rGender.Size = new System.Drawing.Size(68, 17);
            this.rGender.TabIndex = 17;
            this.rGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rBday
            // 
            this.rBday.BackColor = System.Drawing.Color.Transparent;
            this.rBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBday.ForeColor = System.Drawing.Color.Crimson;
            this.rBday.Location = new System.Drawing.Point(101, 281);
            this.rBday.Name = "rBday";
            this.rBday.Size = new System.Drawing.Size(190, 19);
            this.rBday.TabIndex = 18;
            this.rBday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(10, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "* = required";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentInformation.Properties.Resources.pngtree_blue_gradient_wavy_background_vector_image_16153040;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 387);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rBday);
            this.Controls.Add(this.rGender);
            this.Controls.Add(this.rFirst);
            this.Controls.Add(this.rLast);
            this.Controls.Add(this.registerStud);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Button registerStud;
        private System.Windows.Forms.Label rLast;
        private System.Windows.Forms.Label rFirst;
        private System.Windows.Forms.Label rGender;
        private System.Windows.Forms.Label rBday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}

