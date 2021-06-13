﻿using Session_8_Answers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Session_8_Answers.University;

namespace Session_8_Answers {

    public partial class StudentForm : Form {

        public Student NewStudent { get; set; }

        public StudentForm() {
            InitializeComponent();
        }

        private void TextEditName_EditValueChanged(object sender, EventArgs e) {
            
        }

        private void ButtonSubmitStudent_Click(object sender, EventArgs e) {

            NewStudent.Name = Convert.ToString(ctrlName.EditValue);
            NewStudent.Surname = Convert.ToString(ctrlSurname.EditValue);

            DialogResult = DialogResult.OK;

            Close();

            //Message();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        //public void Message() {
        //    MessageBox.Show("Data Succesfully added!.", "Success",
        //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}
    }
}
