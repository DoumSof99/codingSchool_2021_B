﻿using Session_10_Answers.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_10_Answers.WUI {
    public partial class ViewForm : Form {

        public List<string> ViewData { get; set; }
        public EntityTypeEnum Type { get; set; }
        public University MasterData { get; set; }

        public string LogFile { get; set; }

        // private University university = new University();


        public ViewForm() {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e) {

            RefreshList();
          
        }

        public void RefreshList() {

            ctrlViewList.Items.Clear();

            foreach (string item in ViewData) {
                ctrlViewList.Items.Add(item);
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e) {

            //switch (Type) {
            //    case EntityTypeEnum.Course:
            //        AddEntity(EntityTypeEnum.Course);
            //        break;
            //    case EntityTypeEnum.Student:
            //        AddEntity(EntityTypeEnum.Student);
            //        break;
            //    case EntityTypeEnum.Professor:
            //        AddEntity(EntityTypeEnum.Professor);
            //        break;
            //    default:
            //        break;
            //}
        }

        

        private void ctrlViewList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            EditSelectedRecored();
        }
        private void ctrlViewList_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditSelectedRecored();
        }

        private void EditSelectedRecored() {

            Guid id = GetListID();
            Object editObject = null;

            switch (Type) {
                case EntityTypeEnum.Course:
                    editObject = MasterData.Courses.Find(x => x.ID == id);

                    break;
                case EntityTypeEnum.Student:
                    editObject = MasterData.Students.Find(x => x.ID == id);

                    break;
                case EntityTypeEnum.Professor:
                    editObject = MasterData.Students.Find(x => x.ID == id);

                    break;
                default:
                    break;
            }

            EditForm form = new EditForm();
            form.Type = Type;
            form.EditObject = editObject;
            form.ShowDialog();

        }

        private Guid GetListID() {
            object listSelection = ctrlViewList.SelectedItem;
            List<string> listParse = listSelection.ToString().Split(' ').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));
            return id;
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            RemoveSelectedRecored();
        }

        private void RemoveSelectedRecored() {

            Guid id = GetListID();

            switch (Type) {
                case EntityTypeEnum.Course:
                    MasterData.Courses.RemoveAll(x => x.ID == id);

                    break;
                case EntityTypeEnum.Student:
                    MasterData.Students.RemoveAll(x => x.ID == id);

                    break;
                case EntityTypeEnum.Professor:
                    MasterData.Professors.RemoveAll(x => x.ID == id);

                    break;
                default:
                    break;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            RefreshListBox();
        }

        private void RefreshListBox() {

            Controller controller = new Controller();

            switch (Type) {
                case EntityTypeEnum.Course:

                    controller.CodingSchool = MasterData;
                    controller.LogFile = LogFile;

                    ViewData = controller.GetList();

                    RefreshList();

                    break;
                case EntityTypeEnum.Student:

                    controller.CodingSchool = MasterData;
                    controller.LogFile = LogFile;

                    ViewData = controller.GetList();

                    RefreshList();

                    break;
                case EntityTypeEnum.Professor:
                    controller.CodingSchool = MasterData;
                    controller.LogFile = LogFile;

                    ViewData = controller.GetList();

                    RefreshList();
                    break;
                default:
                    break;
            }

        }

    }
}
