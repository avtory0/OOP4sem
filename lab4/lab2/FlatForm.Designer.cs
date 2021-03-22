namespace lab2
{
    partial class FlatForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Минск");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Могилев");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Гомель");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Беларусь", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Колорадо");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Вайоминг");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Техас");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("США", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Киев");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Львов");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Одесса");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Украина", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Нюрбург");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Франкфурт");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Берлин");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Германия", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Москва");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Санкт-Петербург");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Владивосток");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Россия", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Страна", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode29,
            treeNode33,
            treeNode37,
            treeNode41});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlatForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelFootage = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.checkBoxKitchen = new System.Windows.Forms.CheckBox();
            this.checkBoxLivingRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxBathroom = new System.Windows.Forms.CheckBox();
            this.checkBoxBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxBasement = new System.Windows.Forms.CheckBox();
            this.trackBarFootage = new System.Windows.Forms.TrackBar();
            this.labelYear = new System.Windows.Forms.Label();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.numericUpDownFloor = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.textBoxNumberFlat = new System.Windows.Forms.TextBox();
            this.textBoxNumberHouse = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelFlatNumber = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.treeViewCountry = new System.Windows.Forms.TreeView();
            this.numericUpDownRooms = new System.Windows.Forms.NumericUpDown();
            this.buttonOutputFlatInfo = new System.Windows.Forms.Button();
            this.textBoxFlatInfo = new System.Windows.Forms.TextBox();
            this.buttonClearInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCostFlat = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.buttonAutoFill = new System.Windows.Forms.Button();
            this.labelBucks = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchAmountRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortFootage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHideTool = new System.Windows.Forms.ToolStripMenuItem();
            this.фокусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearched = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            this.buttonSearchSave = new System.Windows.Forms.Button();
            this.buttonSortSave = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonSearch = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemYearSear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDistrictSear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRoomsSear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFootage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearInfo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelObjectsAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.renovation = new System.Windows.Forms.RadioButton();
            this.noRenovation = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).BeginInit();
            this.groupBoxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о квартире";
            // 
            // labelFootage
            // 
            this.labelFootage.AutoSize = true;
            this.labelFootage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFootage.Location = new System.Drawing.Point(58, 94);
            this.labelFootage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFootage.Name = "labelFootage";
            this.labelFootage.Size = new System.Drawing.Size(130, 20);
            this.labelFootage.TabIndex = 1;
            this.labelFootage.Text = "Метраж:     (м^2)";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRooms.Location = new System.Drawing.Point(58, 163);
            this.labelRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(159, 20);
            this.labelRooms.TabIndex = 3;
            this.labelRooms.Text = "Количество комнат";
            // 
            // checkBoxKitchen
            // 
            this.checkBoxKitchen.AutoSize = true;
            this.checkBoxKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxKitchen.Location = new System.Drawing.Point(63, 228);
            this.checkBoxKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxKitchen.Name = "checkBoxKitchen";
            this.checkBoxKitchen.Size = new System.Drawing.Size(70, 24);
            this.checkBoxKitchen.TabIndex = 5;
            this.checkBoxKitchen.Text = "Кухня";
            this.checkBoxKitchen.UseVisualStyleBackColor = true;
            // 
            // checkBoxLivingRoom
            // 
            this.checkBoxLivingRoom.AutoSize = true;
            this.checkBoxLivingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxLivingRoom.Location = new System.Drawing.Point(63, 256);
            this.checkBoxLivingRoom.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLivingRoom.Name = "checkBoxLivingRoom";
            this.checkBoxLivingRoom.Size = new System.Drawing.Size(99, 24);
            this.checkBoxLivingRoom.TabIndex = 6;
            this.checkBoxLivingRoom.Text = "Гостиная";
            this.checkBoxLivingRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxBathroom
            // 
            this.checkBoxBathroom.AutoSize = true;
            this.checkBoxBathroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBathroom.Location = new System.Drawing.Point(63, 284);
            this.checkBoxBathroom.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBathroom.Name = "checkBoxBathroom";
            this.checkBoxBathroom.Size = new System.Drawing.Size(152, 24);
            this.checkBoxBathroom.TabIndex = 7;
            this.checkBoxBathroom.Text = "Ванная комната";
            this.checkBoxBathroom.UseVisualStyleBackColor = true;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.AutoSize = true;
            this.checkBoxBalcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBalcony.Location = new System.Drawing.Point(63, 313);
            this.checkBoxBalcony.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBalcony.Name = "checkBoxBalcony";
            this.checkBoxBalcony.Size = new System.Drawing.Size(84, 24);
            this.checkBoxBalcony.TabIndex = 8;
            this.checkBoxBalcony.Text = "Балкон";
            this.checkBoxBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasement
            // 
            this.checkBoxBasement.AutoSize = true;
            this.checkBoxBasement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBasement.Location = new System.Drawing.Point(63, 342);
            this.checkBoxBasement.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBasement.Name = "checkBoxBasement";
            this.checkBoxBasement.Size = new System.Drawing.Size(88, 24);
            this.checkBoxBasement.TabIndex = 9;
            this.checkBoxBasement.Text = "Подвал";
            this.checkBoxBasement.UseVisualStyleBackColor = true;
            // 
            // trackBarFootage
            // 
            this.trackBarFootage.AllowDrop = true;
            this.trackBarFootage.BackColor = System.Drawing.Color.MistyRose;
            this.trackBarFootage.Location = new System.Drawing.Point(52, 116);
            this.trackBarFootage.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarFootage.Maximum = 300;
            this.trackBarFootage.Minimum = 1;
            this.trackBarFootage.Name = "trackBarFootage";
            this.trackBarFootage.Size = new System.Drawing.Size(146, 45);
            this.trackBarFootage.TabIndex = 10;
            this.trackBarFootage.TickFrequency = 50;
            this.trackBarFootage.Value = 1;
            this.trackBarFootage.Scroll += new System.EventHandler(this.trackBarFootage_Scroll);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelYear.Location = new System.Drawing.Point(58, 384);
            this.labelYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(121, 20);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Год постройки";
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(63, 413);
            this.dateTimePickerYear.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(57, 23);
            this.dateTimePickerYear.TabIndex = 12;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMaterial.Location = new System.Drawing.Point(59, 447);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(124, 20);
            this.labelMaterial.TabIndex = 13;
            this.labelMaterial.Text = "Тип материала";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.BackColor = System.Drawing.Color.LightYellow;
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Кирпич",
            "Дерево",
            "Блоки",
            "Бетонные плиты"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(63, 472);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(119, 24);
            this.comboBoxMaterial.TabIndex = 14;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFloor.Location = new System.Drawing.Point(62, 499);
            this.labelFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(50, 20);
            this.labelFloor.TabIndex = 15;
            this.labelFloor.Text = "Этаж";
            // 
            // numericUpDownFloor
            // 
            this.numericUpDownFloor.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownFloor.Location = new System.Drawing.Point(68, 530);
            this.numericUpDownFloor.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownFloor.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFloor.Name = "numericUpDownFloor";
            this.numericUpDownFloor.Size = new System.Drawing.Size(66, 23);
            this.numericUpDownFloor.TabIndex = 16;
            this.numericUpDownFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.textBoxIndex);
            this.groupBoxAddress.Controls.Add(this.labelIndex);
            this.groupBoxAddress.Controls.Add(this.comboBoxDistrict);
            this.groupBoxAddress.Controls.Add(this.textBoxNumberFlat);
            this.groupBoxAddress.Controls.Add(this.textBoxNumberHouse);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Controls.Add(this.labelFlatNumber);
            this.groupBoxAddress.Controls.Add(this.labelHouse);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Controls.Add(this.labelDistrict);
            this.groupBoxAddress.Controls.Add(this.treeViewCountry);
            this.groupBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxAddress.Location = new System.Drawing.Point(283, 61);
            this.groupBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAddress.Size = new System.Drawing.Size(467, 240);
            this.groupBoxAddress.TabIndex = 17;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Адрес квартиры";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxIndex.Location = new System.Drawing.Point(206, 140);
            this.textBoxIndex.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.ShortcutsEnabled = false;
            this.textBoxIndex.Size = new System.Drawing.Size(110, 23);
            this.textBoxIndex.TabIndex = 34;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelIndex.Location = new System.Drawing.Point(205, 121);
            this.labelIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(56, 17);
            this.labelIndex.TabIndex = 33;
            this.labelIndex.Text = "Индекс";
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
            this.comboBoxDistrict.Location = new System.Drawing.Point(206, 38);
            this.comboBoxDistrict.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(110, 24);
            this.comboBoxDistrict.TabIndex = 32;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // textBoxNumberFlat
            // 
            this.textBoxNumberFlat.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxNumberFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumberFlat.Location = new System.Drawing.Point(342, 86);
            this.textBoxNumberFlat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumberFlat.Name = "textBoxNumberFlat";
            this.textBoxNumberFlat.ShortcutsEnabled = false;
            this.textBoxNumberFlat.Size = new System.Drawing.Size(110, 23);
            this.textBoxNumberFlat.TabIndex = 11;
            this.textBoxNumberFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberFlat_KeyPress);
            // 
            // textBoxNumberHouse
            // 
            this.textBoxNumberHouse.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxNumberHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumberHouse.Location = new System.Drawing.Point(343, 32);
            this.textBoxNumberHouse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumberHouse.Name = "textBoxNumberHouse";
            this.textBoxNumberHouse.ShortcutsEnabled = false;
            this.textBoxNumberHouse.Size = new System.Drawing.Size(110, 23);
            this.textBoxNumberHouse.TabIndex = 10;
            this.textBoxNumberHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberHouse_KeyPress);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStreet.Location = new System.Drawing.Point(206, 84);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.ShortcutsEnabled = false;
            this.textBoxStreet.Size = new System.Drawing.Size(110, 23);
            this.textBoxStreet.TabIndex = 9;
            this.textBoxStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStreet_KeyPress);
            // 
            // labelFlatNumber
            // 
            this.labelFlatNumber.AutoSize = true;
            this.labelFlatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFlatNumber.Location = new System.Drawing.Point(339, 67);
            this.labelFlatNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFlatNumber.Name = "labelFlatNumber";
            this.labelFlatNumber.Size = new System.Drawing.Size(118, 17);
            this.labelFlatNumber.TabIndex = 8;
            this.labelFlatNumber.Text = "Номер квартиры";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHouse.Location = new System.Drawing.Point(339, 14);
            this.labelHouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(88, 17);
            this.labelHouse.TabIndex = 7;
            this.labelHouse.Text = "Номер дома";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStreet.Location = new System.Drawing.Point(203, 67);
            this.labelStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(49, 17);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Улица";
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDistrict.Location = new System.Drawing.Point(203, 17);
            this.labelDistrict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(49, 17);
            this.labelDistrict.TabIndex = 1;
            this.labelDistrict.Text = "Район";
            // 
            // treeViewCountry
            // 
            this.treeViewCountry.BackColor = System.Drawing.Color.LightYellow;
            this.treeViewCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeViewCountry.Location = new System.Drawing.Point(20, 38);
            this.treeViewCountry.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewCountry.Name = "treeViewCountry";
            treeNode22.Name = "Minsk";
            treeNode22.Text = "Минск";
            treeNode23.Name = "Mogilev";
            treeNode23.Text = "Могилев";
            treeNode24.Name = "Gomel";
            treeNode24.Text = "Гомель";
            treeNode25.Name = "Belarus";
            treeNode25.Text = "Беларусь";
            treeNode26.Name = "Colorado";
            treeNode26.Text = "Колорадо";
            treeNode27.Name = "Wayoming";
            treeNode27.Text = "Вайоминг";
            treeNode28.Name = "Texas";
            treeNode28.Text = "Техас";
            treeNode29.Name = "USA";
            treeNode29.Text = "США";
            treeNode30.Name = "Kiev";
            treeNode30.Text = "Киев";
            treeNode31.Name = "Lviv";
            treeNode31.Text = "Львов";
            treeNode32.Name = "Odessa";
            treeNode32.Text = "Одесса";
            treeNode33.Name = "Ukraine";
            treeNode33.Text = "Украина";
            treeNode34.Name = "Nurburg";
            treeNode34.Text = "Нюрбург";
            treeNode35.Name = "Frankfurt";
            treeNode35.Text = "Франкфурт";
            treeNode36.Name = "Berlin";
            treeNode36.Text = "Берлин";
            treeNode37.Name = "Germany";
            treeNode37.Text = "Германия";
            treeNode38.Name = "Moscow";
            treeNode38.Text = "Москва";
            treeNode39.Name = "SPB";
            treeNode39.Text = "Санкт-Петербург";
            treeNode40.Name = "Vladivostok";
            treeNode40.Text = "Владивосток";
            treeNode41.Name = "Russia";
            treeNode41.Text = "Россия";
            treeNode42.Name = "Country";
            treeNode42.Text = "Страна";
            this.treeViewCountry.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42});
            this.treeViewCountry.Size = new System.Drawing.Size(162, 174);
            this.treeViewCountry.TabIndex = 0;
            // 
            // numericUpDownRooms
            // 
            this.numericUpDownRooms.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownRooms.Location = new System.Drawing.Point(62, 193);
            this.numericUpDownRooms.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRooms.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRooms.Name = "numericUpDownRooms";
            this.numericUpDownRooms.Size = new System.Drawing.Size(67, 23);
            this.numericUpDownRooms.TabIndex = 21;
            this.numericUpDownRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOutputFlatInfo
            // 
            this.buttonOutputFlatInfo.BackColor = System.Drawing.Color.Coral;
            this.buttonOutputFlatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOutputFlatInfo.Location = new System.Drawing.Point(283, 314);
            this.buttonOutputFlatInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOutputFlatInfo.Name = "buttonOutputFlatInfo";
            this.buttonOutputFlatInfo.Size = new System.Drawing.Size(202, 69);
            this.buttonOutputFlatInfo.TabIndex = 22;
            this.buttonOutputFlatInfo.Text = "Вывести информацию о квартире";
            this.buttonOutputFlatInfo.UseVisualStyleBackColor = false;
            this.buttonOutputFlatInfo.Click += new System.EventHandler(this.buttonOutputInfo_Click);
            // 
            // textBoxFlatInfo
            // 
            this.textBoxFlatInfo.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxFlatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFlatInfo.Location = new System.Drawing.Point(283, 392);
            this.textBoxFlatInfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlatInfo.Multiline = true;
            this.textBoxFlatInfo.Name = "textBoxFlatInfo";
            this.textBoxFlatInfo.ReadOnly = true;
            this.textBoxFlatInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFlatInfo.Size = new System.Drawing.Size(203, 223);
            this.textBoxFlatInfo.TabIndex = 23;
            // 
            // buttonClearInfo
            // 
            this.buttonClearInfo.BackColor = System.Drawing.Color.Coral;
            this.buttonClearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonClearInfo.Location = new System.Drawing.Point(66, 654);
            this.buttonClearInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearInfo.Name = "buttonClearInfo";
            this.buttonClearInfo.Size = new System.Drawing.Size(108, 46);
            this.buttonClearInfo.TabIndex = 24;
            this.buttonClearInfo.Text = "ОЧИСТИТЬ";
            this.buttonClearInfo.UseVisualStyleBackColor = false;
            this.buttonClearInfo.Click += new System.EventHandler(this.buttonClearInfo_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Coral;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(340, 654);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(148, 45);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "СОХРАНИТЬ\r\n данные о квартире\r\n";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCostFlat
            // 
            this.labelCostFlat.AutoSize = true;
            this.labelCostFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCostFlat.Location = new System.Drawing.Point(64, 596);
            this.labelCostFlat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCostFlat.Name = "labelCostFlat";
            this.labelCostFlat.Size = new System.Drawing.Size(170, 20);
            this.labelCostFlat.TabIndex = 27;
            this.labelCostFlat.Text = "Стоимость квартиры";
            // 
            // textBoxCost
            // 
            this.textBoxCost.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCost.Location = new System.Drawing.Point(66, 619);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(76, 23);
            this.textBoxCost.TabIndex = 28;
            // 
            // buttonAutoFill
            // 
            this.buttonAutoFill.BackColor = System.Drawing.Color.Coral;
            this.buttonAutoFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAutoFill.Location = new System.Drawing.Point(178, 654);
            this.buttonAutoFill.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAutoFill.Name = "buttonAutoFill";
            this.buttonAutoFill.Size = new System.Drawing.Size(158, 46);
            this.buttonAutoFill.TabIndex = 29;
            this.buttonAutoFill.Text = "АВТОЗАПОЛНЕНИЕ";
            this.buttonAutoFill.UseVisualStyleBackColor = false;
            this.buttonAutoFill.Click += new System.EventHandler(this.buttonAutoFill_Click);
            // 
            // labelBucks
            // 
            this.labelBucks.AutoSize = true;
            this.labelBucks.BackColor = System.Drawing.Color.Transparent;
            this.labelBucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBucks.Location = new System.Drawing.Point(146, 620);
            this.labelBucks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBucks.Name = "labelBucks";
            this.labelBucks.Size = new System.Drawing.Size(18, 20);
            this.labelBucks.TabIndex = 30;
            this.labelBucks.Text = "$";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSearch,
            this.toolStripMenuItemSort,
            this.toolStripMenuItemSave,
            this.ToolStripMenuItemHideTool,
            this.фокусToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1021, 24);
            this.menuStripMain.TabIndex = 32;
            // 
            // toolStripMenuItemSearch
            // 
            this.toolStripMenuItemSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSearchYear,
            this.toolStripMenuItemSearchDistrict,
            this.toolStripMenuItemSearchAmountRooms});
            this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
            this.toolStripMenuItemSearch.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemSearch.Text = "Поиск";
            // 
            // toolStripMenuItemSearchYear
            // 
            this.toolStripMenuItemSearchYear.Name = "toolStripMenuItemSearchYear";
            this.toolStripMenuItemSearchYear.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemSearchYear.Text = "По году";
            this.toolStripMenuItemSearchYear.Click += new System.EventHandler(this.toolStripMenuItemSearchYear_Click);
            // 
            // toolStripMenuItemSearchDistrict
            // 
            this.toolStripMenuItemSearchDistrict.Name = "toolStripMenuItemSearchDistrict";
            this.toolStripMenuItemSearchDistrict.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemSearchDistrict.Text = "По району";
            this.toolStripMenuItemSearchDistrict.Click += new System.EventHandler(this.toolStripMenuItemSearchDistrict_Click);
            // 
            // toolStripMenuItemSearchAmountRooms
            // 
            this.toolStripMenuItemSearchAmountRooms.Name = "toolStripMenuItemSearchAmountRooms";
            this.toolStripMenuItemSearchAmountRooms.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemSearchAmountRooms.Text = "По кол-ву комнат";
            this.toolStripMenuItemSearchAmountRooms.Click += new System.EventHandler(this.toolStripMenuItemSearchAmountRooms_Click);
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSortYear,
            this.toolStripMenuItemSortFootage,
            this.toolStripMenuItemSortPrice});
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(110, 20);
            this.toolStripMenuItemSort.Text = "Сортировать по:";
            // 
            // toolStripMenuItemSortYear
            // 
            this.toolStripMenuItemSortYear.Name = "toolStripMenuItemSortYear";
            this.toolStripMenuItemSortYear.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemSortYear.Text = "Году";
            this.toolStripMenuItemSortYear.Click += new System.EventHandler(this.toolStripMenuItemSortYear_Click);
            // 
            // toolStripMenuItemSortFootage
            // 
            this.toolStripMenuItemSortFootage.Name = "toolStripMenuItemSortFootage";
            this.toolStripMenuItemSortFootage.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemSortFootage.Text = "Метражу";
            this.toolStripMenuItemSortFootage.Click += new System.EventHandler(this.toolStripMenuItemSortFootage_Click);
            // 
            // toolStripMenuItemSortPrice
            // 
            this.toolStripMenuItemSortPrice.Name = "toolStripMenuItemSortPrice";
            this.toolStripMenuItemSortPrice.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemSortPrice.Text = "Цене";
            this.toolStripMenuItemSortPrice.Click += new System.EventHandler(this.toolStripMenuItemSortPrice_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItemSave.Text = "О программе";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemHideTool
            // 
            this.ToolStripMenuItemHideTool.Name = "ToolStripMenuItemHideTool";
            this.ToolStripMenuItemHideTool.Size = new System.Drawing.Size(183, 20);
            this.ToolStripMenuItemHideTool.Text = "Скрыть панель инструментов";
            this.ToolStripMenuItemHideTool.Click += new System.EventHandler(this.ToolStripMenuItemHideTool_Click);
            // 
            // фокусToolStripMenuItem
            // 
            this.фокусToolStripMenuItem.Name = "фокусToolStripMenuItem";
            this.фокусToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.фокусToolStripMenuItem.Text = "Фокус";
            this.фокусToolStripMenuItem.Click += new System.EventHandler(this.фокусToolStripMenuItem_Click);
            // 
            // textBoxSearched
            // 
            this.textBoxSearched.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearched.Location = new System.Drawing.Point(517, 392);
            this.textBoxSearched.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearched.Multiline = true;
            this.textBoxSearched.Name = "textBoxSearched";
            this.textBoxSearched.ReadOnly = true;
            this.textBoxSearched.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSearched.Size = new System.Drawing.Size(234, 223);
            this.textBoxSearched.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(521, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Результат поискового запроса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(775, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Результат сортировки:";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSorted.Location = new System.Drawing.Point(778, 99);
            this.textBoxSorted.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSorted.Multiline = true;
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.ReadOnly = true;
            this.textBoxSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSorted.Size = new System.Drawing.Size(183, 517);
            this.textBoxSorted.TabIndex = 37;
            // 
            // buttonSearchSave
            // 
            this.buttonSearchSave.BackColor = System.Drawing.Color.Coral;
            this.buttonSearchSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSearchSave.Location = new System.Drawing.Point(517, 614);
            this.buttonSearchSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchSave.Name = "buttonSearchSave";
            this.buttonSearchSave.Size = new System.Drawing.Size(233, 61);
            this.buttonSearchSave.TabIndex = 38;
            this.buttonSearchSave.Text = "СОХРАНИТЬ\r\n результат поиска";
            this.buttonSearchSave.UseVisualStyleBackColor = false;
            this.buttonSearchSave.Click += new System.EventHandler(this.buttonSearchSave_Click);
            // 
            // buttonSortSave
            // 
            this.buttonSortSave.BackColor = System.Drawing.Color.Coral;
            this.buttonSortSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSortSave.Location = new System.Drawing.Point(778, 613);
            this.buttonSortSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSortSave.Name = "buttonSortSave";
            this.buttonSortSave.Size = new System.Drawing.Size(182, 61);
            this.buttonSortSave.TabIndex = 39;
            this.buttonSortSave.Text = "СОХРАНИТЬ\r\n результат поиска";
            this.buttonSortSave.UseVisualStyleBackColor = false;
            this.buttonSortSave.Click += new System.EventHandler(this.buttonSortSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonSearch,
            this.toolStripDropDownButtonSort,
            this.toolStripButtonAbout,
            this.toolStripButtonClearInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 27);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonSearch
            // 
            this.toolStripDropDownButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemYearSear,
            this.toolStripMenuItemDistrictSear,
            this.toolStripMenuItemRoomsSear});
            this.toolStripDropDownButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSearch.Image")));
            this.toolStripDropDownButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSearch.Name = "toolStripDropDownButtonSearch";
            this.toolStripDropDownButtonSearch.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButtonSearch.Text = "Поиск";
            // 
            // toolStripMenuItemYearSear
            // 
            this.toolStripMenuItemYearSear.Name = "toolStripMenuItemYearSear";
            this.toolStripMenuItemYearSear.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemYearSear.Text = "Году";
            this.toolStripMenuItemYearSear.Click += new System.EventHandler(this.toolStripMenuItemYearSear_Click);
            // 
            // toolStripMenuItemDistrictSear
            // 
            this.toolStripMenuItemDistrictSear.Name = "toolStripMenuItemDistrictSear";
            this.toolStripMenuItemDistrictSear.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemDistrictSear.Text = "Району";
            this.toolStripMenuItemDistrictSear.Click += new System.EventHandler(this.toolStripMenuItemDistrictSear_Click);
            // 
            // toolStripMenuItemRoomsSear
            // 
            this.toolStripMenuItemRoomsSear.Name = "toolStripMenuItemRoomsSear";
            this.toolStripMenuItemRoomsSear.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemRoomsSear.Text = "Кол-ву комнат";
            this.toolStripMenuItemRoomsSear.Click += new System.EventHandler(this.toolStripMenuItemRoomsSear_Click);
            // 
            // toolStripDropDownButtonSort
            // 
            this.toolStripDropDownButtonSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemYear,
            this.toolStripMenuItemFootage,
            this.toolStripMenuItemPrice});
            this.toolStripDropDownButtonSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSort.Image")));
            this.toolStripDropDownButtonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSort.Name = "toolStripDropDownButtonSort";
            this.toolStripDropDownButtonSort.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButtonSort.Text = "Сортировка по:";
            // 
            // toolStripMenuItemYear
            // 
            this.toolStripMenuItemYear.Name = "toolStripMenuItemYear";
            this.toolStripMenuItemYear.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemYear.Text = "Году";
            this.toolStripMenuItemYear.Click += new System.EventHandler(this.toolStripMenuItemYear_Click);
            // 
            // toolStripMenuItemFootage
            // 
            this.toolStripMenuItemFootage.Name = "toolStripMenuItemFootage";
            this.toolStripMenuItemFootage.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemFootage.Text = "Метражу";
            this.toolStripMenuItemFootage.Click += new System.EventHandler(this.toolStripMenuItemFootage_Click);
            // 
            // toolStripMenuItemPrice
            // 
            this.toolStripMenuItemPrice.Name = "toolStripMenuItemPrice";
            this.toolStripMenuItemPrice.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemPrice.Text = "Цене";
            this.toolStripMenuItemPrice.Click += new System.EventHandler(this.toolStripMenuItemRooms_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAbout.Text = "О программе";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonClearInfo
            // 
            this.toolStripButtonClearInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearInfo.Image")));
            this.toolStripButtonClearInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearInfo.Name = "toolStripButtonClearInfo";
            this.toolStripButtonClearInfo.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonClearInfo.Text = "Очистить";
            this.toolStripButtonClearInfo.Click += new System.EventHandler(this.toolStripButtonClearInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabelLastAction,
            this.toolStripStatusLabelAction,
            this.toolStripStatusLabelObjectsAmount,
            this.toolStripStatusLabelAmount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1021, 24);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(109, 19);
            this.toolStripStatusLabelDate.Text = "Текущее время:";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(48, 19);
            this.toolStripStatusLabelTime.Text = "время";
            // 
            // toolStripStatusLabelLastAction
            // 
            this.toolStripStatusLabelLastAction.Name = "toolStripStatusLabelLastAction";
            this.toolStripStatusLabelLastAction.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabelLastAction.Text = "Последнее действие:";
            // 
            // toolStripStatusLabelAction
            // 
            this.toolStripStatusLabelAction.Name = "toolStripStatusLabelAction";
            this.toolStripStatusLabelAction.Size = new System.Drawing.Size(130, 19);
            this.toolStripStatusLabelAction.Text = "ничего не произошло";
            // 
            // toolStripStatusLabelObjectsAmount
            // 
            this.toolStripStatusLabelObjectsAmount.Name = "toolStripStatusLabelObjectsAmount";
            this.toolStripStatusLabelObjectsAmount.Size = new System.Drawing.Size(206, 19);
            this.toolStripStatusLabelObjectsAmount.Text = "Количество сохраненных объектов:";
            // 
            // toolStripStatusLabelAmount
            // 
            this.toolStripStatusLabelAmount.Name = "toolStripStatusLabelAmount";
            this.toolStripStatusLabelAmount.Size = new System.Drawing.Size(71, 19);
            this.toolStripStatusLabelAmount.Text = "количество";
            // 
            // renovation
            // 
            this.renovation.AutoSize = true;
            this.renovation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.renovation.Location = new System.Drawing.Point(49, 567);
            this.renovation.Name = "renovation";
            this.renovation.Size = new System.Drawing.Size(91, 19);
            this.renovation.TabIndex = 42;
            this.renovation.TabStop = true;
            this.renovation.Text = "С отделкой";
            this.renovation.UseVisualStyleBackColor = true;
            this.renovation.CheckedChanged += new System.EventHandler(this.renovation_CheckedChanged);
            // 
            // noRenovation
            // 
            this.noRenovation.AutoSize = true;
            this.noRenovation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noRenovation.Location = new System.Drawing.Point(150, 567);
            this.noRenovation.Name = "noRenovation";
            this.noRenovation.Size = new System.Drawing.Size(97, 19);
            this.noRenovation.TabIndex = 43;
            this.noRenovation.TabStop = true;
            this.noRenovation.Text = "Без отделки";
            this.noRenovation.UseVisualStyleBackColor = true;
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1021, 757);
            this.Controls.Add(this.noRenovation);
            this.Controls.Add(this.renovation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonSortSave);
            this.Controls.Add(this.buttonSearchSave);
            this.Controls.Add(this.textBoxSorted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearched);
            this.Controls.Add(this.labelBucks);
            this.Controls.Add(this.buttonAutoFill);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCostFlat);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClearInfo);
            this.Controls.Add(this.textBoxFlatInfo);
            this.Controls.Add(this.buttonOutputFlatInfo);
            this.Controls.Add(this.numericUpDownRooms);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.numericUpDownFloor);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.trackBarFootage);
            this.Controls.Add(this.checkBoxBasement);
            this.Controls.Add(this.checkBoxBalcony);
            this.Controls.Add(this.checkBoxBathroom);
            this.Controls.Add(this.checkBoxLivingRoom);
            this.Controls.Add(this.checkBoxKitchen);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelFootage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlatForm";
            this.Text = "Квартира";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).EndInit();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFootage;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.CheckBox checkBoxKitchen;
        private System.Windows.Forms.CheckBox checkBoxLivingRoom;
        private System.Windows.Forms.CheckBox checkBoxBathroom;
        private System.Windows.Forms.CheckBox checkBoxBalcony;
        private System.Windows.Forms.CheckBox checkBoxBasement;
        private System.Windows.Forms.TrackBar trackBarFootage;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.NumericUpDown numericUpDownFloor;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TreeView treeViewCountry;
        private System.Windows.Forms.Label labelFlatNumber;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms;
        private System.Windows.Forms.Button buttonOutputFlatInfo;
        private System.Windows.Forms.TextBox textBoxFlatInfo;
        private System.Windows.Forms.Button buttonClearInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCostFlat;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonAutoFill;
        private System.Windows.Forms.TextBox textBoxNumberFlat;
        private System.Windows.Forms.TextBox textBoxNumberHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelBucks;
        public System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortFootage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchDistrict;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchAmountRooms;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSearched;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxSorted;
        private System.Windows.Forms.Button buttonSearchSave;
        private System.Windows.Forms.Button buttonSortSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemYearSear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDistrictSear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRoomsSear;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFootage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrice;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHideTool;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastAction;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelObjectsAmount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAmount;
        private System.Windows.Forms.ToolStripMenuItem фокусToolStripMenuItem;
        private System.Windows.Forms.RadioButton renovation;
        private System.Windows.Forms.RadioButton noRenovation;
    }
}

