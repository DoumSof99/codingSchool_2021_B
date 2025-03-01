﻿
namespace Session_8_Answers {
    partial class CoursesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSubmitStudent = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlHours = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(500, 388);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 35);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Close";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(250, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(213, 53);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Course Data";
            // 
            // ButtonSubmitStudent
            // 
            this.ButtonSubmitStudent.Appearance.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmitStudent.Appearance.Options.UseFont = true;
            this.ButtonSubmitStudent.Location = new System.Drawing.Point(348, 388);
            this.ButtonSubmitStudent.Name = "ButtonSubmitStudent";
            this.ButtonSubmitStudent.Size = new System.Drawing.Size(146, 35);
            this.ButtonSubmitStudent.TabIndex = 19;
            this.ButtonSubmitStudent.Text = "Submit Courses";
            this.ButtonSubmitStudent.Click += new System.EventHandler(this.ButtonSubmitStudent_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(148, 188);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 20);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Course Hours: ";
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(302, 152);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(269, 20);
            this.ctrlSubject.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(154, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 20);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Course Subject: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(148, 230);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 20);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Course Category: ";
            // 
            // ctrlHours
            // 
            this.ctrlHours.Location = new System.Drawing.Point(302, 190);
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(269, 20);
            this.ctrlHours.TabIndex = 29;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ButtonSubmitStudent);
            this.Controls.Add(this.labelControl3);
            this.Name = "CoursesForm";
            this.Text = "CoursesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmitStudent;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ctrlSubject;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ctrlHours;
    }
}