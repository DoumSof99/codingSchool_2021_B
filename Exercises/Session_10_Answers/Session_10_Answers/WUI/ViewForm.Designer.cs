﻿
namespace Session_10_Answers.WUI {
    partial class ViewForm {
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
            this.ctrlViewList = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlViewList
            // 
            this.ctrlViewList.Location = new System.Drawing.Point(3, 0);
            this.ctrlViewList.Name = "ctrlViewList";
            this.ctrlViewList.Size = new System.Drawing.Size(647, 448);
            this.ctrlViewList.TabIndex = 0;
            this.ctrlViewList.SelectedIndexChanged += new System.EventHandler(this.ctrlViewList_SelectedIndexChanged);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.ctrlViewList);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl ctrlViewList;
    }
}