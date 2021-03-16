
namespace lab2
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.labelSearchYear = new System.Windows.Forms.Label();
            this.labelSearchDistrict = new System.Windows.Forms.Label();
            this.labelSearchRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelYear = new System.Windows.Forms.Panel();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.panelDistrict = new System.Windows.Forms.Panel();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.textBoxSearchRooms = new System.Windows.Forms.TextBox();
            this.treeViewResult = new System.Windows.Forms.TreeView();
            this.panelYear.SuspendLayout();
            this.panelDistrict.SuspendLayout();
            this.panelRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSearchYear
            // 
            this.labelSearchYear.AutoSize = true;
            this.labelSearchYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearchYear.Location = new System.Drawing.Point(9, 10);
            this.labelSearchYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchYear.Name = "labelSearchYear";
            this.labelSearchYear.Size = new System.Drawing.Size(119, 20);
            this.labelSearchYear.TabIndex = 0;
            this.labelSearchYear.Text = "Поиск по году:";
            // 
            // labelSearchDistrict
            // 
            this.labelSearchDistrict.AutoSize = true;
            this.labelSearchDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearchDistrict.Location = new System.Drawing.Point(9, 10);
            this.labelSearchDistrict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchDistrict.Name = "labelSearchDistrict";
            this.labelSearchDistrict.Size = new System.Drawing.Size(137, 20);
            this.labelSearchDistrict.TabIndex = 1;
            this.labelSearchDistrict.Text = "Поиск по району:";
            // 
            // labelSearchRooms
            // 
            this.labelSearchRooms.AutoSize = true;
            this.labelSearchRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearchRooms.Location = new System.Drawing.Point(9, 1);
            this.labelSearchRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchRooms.Name = "labelSearchRooms";
            this.labelSearchRooms.Size = new System.Drawing.Size(120, 40);
            this.labelSearchRooms.TabIndex = 2;
            this.labelSearchRooms.Text = "Поиск по \r\nкол-ву комнат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(256, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат поиска:";
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.dateTimePickerYear);
            this.panelYear.Controls.Add(this.labelSearchYear);
            this.panelYear.Location = new System.Drawing.Point(38, 21);
            this.panelYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(150, 81);
            this.panelYear.TabIndex = 8;
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(13, 40);
            this.dateTimePickerYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(68, 23);
            this.dateTimePickerYear.TabIndex = 23;
            this.dateTimePickerYear.ValueChanged += new System.EventHandler(this.dateTimePickerYear_ValueChanged);
            // 
            // panelDistrict
            // 
            this.panelDistrict.Controls.Add(this.comboBoxDistrict);
            this.panelDistrict.Controls.Add(this.labelSearchDistrict);
            this.panelDistrict.Location = new System.Drawing.Point(38, 94);
            this.panelDistrict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDistrict.Name = "panelDistrict";
            this.panelDistrict.Size = new System.Drawing.Size(150, 81);
            this.panelDistrict.TabIndex = 9;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.AutoCompleteCustomSource.AddRange(new string[] {
            "Ленинский",
            "Первомайский",
            "Пушкинский",
            "Якубовского",
            "Казимировка"});
            this.comboBoxDistrict.BackColor = System.Drawing.Color.LightYellow;
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Items.AddRange(new object[] {
            "Ленинский",
            "Первомайский",
            "Спутник",
            "Казимировка",
            "Пушкинский",
            "-Добавить-"});
            this.comboBoxDistrict.Location = new System.Drawing.Point(13, 41);
            this.comboBoxDistrict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(124, 24);
            this.comboBoxDistrict.TabIndex = 33;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            this.comboBoxDistrict.TextChanged += new System.EventHandler(this.comboBoxDistrict_TextChanged);
            // 
            // panelRooms
            // 
            this.panelRooms.Controls.Add(this.textBoxSearchRooms);
            this.panelRooms.Controls.Add(this.labelSearchRooms);
            this.panelRooms.Location = new System.Drawing.Point(38, 171);
            this.panelRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(150, 81);
            this.panelRooms.TabIndex = 10;
            // 
            // textBoxSearchRooms
            // 
            this.textBoxSearchRooms.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSearchRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearchRooms.Location = new System.Drawing.Point(13, 50);
            this.textBoxSearchRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchRooms.Name = "textBoxSearchRooms";
            this.textBoxSearchRooms.Size = new System.Drawing.Size(124, 23);
            this.textBoxSearchRooms.TabIndex = 3;
            this.textBoxSearchRooms.TextChanged += new System.EventHandler(this.textBoxSearchRooms_TextChanged);
            this.textBoxSearchRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchRooms_KeyPress);
            // 
            // treeViewResult
            // 
            this.treeViewResult.BackColor = System.Drawing.Color.LightYellow;
            this.treeViewResult.Location = new System.Drawing.Point(262, 52);
            this.treeViewResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeViewResult.Name = "treeViewResult";
            this.treeViewResult.Size = new System.Drawing.Size(190, 188);
            this.treeViewResult.TabIndex = 11;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(480, 274);
            this.Controls.Add(this.treeViewResult);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.panelDistrict);
            this.Controls.Add(this.panelYear);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchForm";
            this.Text = "Поисковая форма";
            this.panelYear.ResumeLayout(false);
            this.panelYear.PerformLayout();
            this.panelDistrict.ResumeLayout(false);
            this.panelDistrict.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchYear;
        private System.Windows.Forms.Label labelSearchDistrict;
        private System.Windows.Forms.Label labelSearchRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.Panel panelDistrict;
        private System.Windows.Forms.Panel panelRooms;
        public System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.TextBox textBoxSearchRooms;
        private System.Windows.Forms.TreeView treeViewResult;
    }
}