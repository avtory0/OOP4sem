﻿
namespace lab2
{
    partial class District
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(District));
            this.labelDistrict = new System.Windows.Forms.Label();
            this.textBoxAddDistrict = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDistrict.Location = new System.Drawing.Point(35, 24);
            this.labelDistrict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(185, 17);
            this.labelDistrict.TabIndex = 0;
            this.labelDistrict.Text = "Введите название района:";
            // 
            // textBoxAddDistrict
            // 
            this.textBoxAddDistrict.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxAddDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAddDistrict.Location = new System.Drawing.Point(38, 53);
            this.textBoxAddDistrict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddDistrict.Name = "textBoxAddDistrict";
            this.textBoxAddDistrict.Size = new System.Drawing.Size(176, 23);
            this.textBoxAddDistrict.TabIndex = 1;
            this.textBoxAddDistrict.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddDistrict_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(76, 120);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 41);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ДОБАВИТЬ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonAdd_MouseEnter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
            // 
            // District
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(257, 185);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAddDistrict);
            this.Controls.Add(this.labelDistrict);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "District";
            this.Text = "Добавление района";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TextBox textBoxAddDistrict;
        private System.Windows.Forms.Button buttonAdd;
    }
}