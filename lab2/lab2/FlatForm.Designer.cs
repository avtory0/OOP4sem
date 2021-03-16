﻿namespace lab2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Минск");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Могилев");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Гомель");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Беларусь", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Колорадо");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Вайоминг");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Техас");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("США", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Киев");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Львов");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Одесса");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Украина", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Нюрбург");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Франкфурт");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Берлин");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Германия", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Москва");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Санкт-Петербург");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Владивосток");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Россия", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Страна", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16,
            treeNode20});
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
            this.textBoxNumberFlat = new System.Windows.Forms.TextBox();
            this.textBoxNumberHouse = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelFlatNumber = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.treeViewCountry = new System.Windows.Forms.TreeView();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.textBoxRoomInfo = new System.Windows.Forms.TextBox();
            this.numericUpDownRooms = new System.Windows.Forms.NumericUpDown();
            this.buttonOutputFlatInfo = new System.Windows.Forms.Button();
            this.textBoxFlatInfo = new System.Windows.Forms.TextBox();
            this.buttonClearInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCostFlat = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.buttonGetCost = new System.Windows.Forms.Button();
            this.labelBucks = new System.Windows.Forms.Label();
            this.buttonOutputRoomInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).BeginInit();
            this.groupBoxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(20, 21);
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
            this.labelFootage.Location = new System.Drawing.Point(92, 58);
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
            this.labelRooms.Location = new System.Drawing.Point(92, 135);
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
            this.checkBoxKitchen.Location = new System.Drawing.Point(97, 200);
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
            this.checkBoxLivingRoom.Location = new System.Drawing.Point(97, 228);
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
            this.checkBoxBathroom.Location = new System.Drawing.Point(97, 255);
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
            this.checkBoxBalcony.Location = new System.Drawing.Point(97, 284);
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
            this.checkBoxBasement.Location = new System.Drawing.Point(97, 314);
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
            this.trackBarFootage.Location = new System.Drawing.Point(90, 80);
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
            this.labelYear.Location = new System.Drawing.Point(92, 355);
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
            this.dateTimePickerYear.Location = new System.Drawing.Point(97, 384);
            this.dateTimePickerYear.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(57, 23);
            this.dateTimePickerYear.TabIndex = 12;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMaterial.Location = new System.Drawing.Point(93, 425);
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
            this.comboBoxMaterial.Location = new System.Drawing.Point(97, 450);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(119, 24);
            this.comboBoxMaterial.TabIndex = 14;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFloor.Location = new System.Drawing.Point(92, 487);
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
            this.numericUpDownFloor.Location = new System.Drawing.Point(97, 509);
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
            this.groupBoxAddress.Controls.Add(this.textBoxNumberFlat);
            this.groupBoxAddress.Controls.Add(this.textBoxNumberHouse);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Controls.Add(this.labelFlatNumber);
            this.groupBoxAddress.Controls.Add(this.labelHouse);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Controls.Add(this.textBoxDistrict);
            this.groupBoxAddress.Controls.Add(this.labelDistrict);
            this.groupBoxAddress.Controls.Add(this.treeViewCountry);
            this.groupBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxAddress.Location = new System.Drawing.Point(310, 29);
            this.groupBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAddress.Size = new System.Drawing.Size(380, 240);
            this.groupBoxAddress.TabIndex = 17;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Адрес квартиры";
            // 
            // textBoxNumberFlat
            // 
            this.textBoxNumberFlat.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxNumberFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumberFlat.Location = new System.Drawing.Point(206, 190);
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
            this.textBoxNumberHouse.Location = new System.Drawing.Point(207, 136);
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
            this.labelFlatNumber.Location = new System.Drawing.Point(203, 171);
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
            this.labelHouse.Location = new System.Drawing.Point(203, 118);
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
            // textBoxDistrict
            // 
            this.textBoxDistrict.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDistrict.Location = new System.Drawing.Point(206, 38);
            this.textBoxDistrict.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.ShortcutsEnabled = false;
            this.textBoxDistrict.Size = new System.Drawing.Size(110, 23);
            this.textBoxDistrict.TabIndex = 2;
            this.textBoxDistrict.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDistrict_KeyPress);
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
            treeNode1.Name = "Minsk";
            treeNode1.Text = "Минск";
            treeNode2.Name = "Mogilev";
            treeNode2.Text = "Могилев";
            treeNode3.Name = "Gomel";
            treeNode3.Text = "Гомель";
            treeNode4.Name = "Belarus";
            treeNode4.Text = "Беларусь";
            treeNode5.Name = "Colorado";
            treeNode5.Text = "Колорадо";
            treeNode6.Name = "Wayoming";
            treeNode6.Text = "Вайоминг";
            treeNode7.Name = "Texas";
            treeNode7.Text = "Техас";
            treeNode8.Name = "USA";
            treeNode8.Text = "США";
            treeNode9.Name = "Kiev";
            treeNode9.Text = "Киев";
            treeNode10.Name = "Lviv";
            treeNode10.Text = "Львов";
            treeNode11.Name = "Odessa";
            treeNode11.Text = "Одесса";
            treeNode12.Name = "Ukraine";
            treeNode12.Text = "Украина";
            treeNode13.Name = "Nurburg";
            treeNode13.Text = "Нюрбург";
            treeNode14.Name = "Frankfurt";
            treeNode14.Text = "Франкфурт";
            treeNode15.Name = "Berlin";
            treeNode15.Text = "Берлин";
            treeNode16.Name = "Germany";
            treeNode16.Text = "Германия";
            treeNode17.Name = "Moscow";
            treeNode17.Text = "Москва";
            treeNode18.Name = "SPB";
            treeNode18.Text = "Санкт-Петербург";
            treeNode19.Name = "Vladivostok";
            treeNode19.Text = "Владивосток";
            treeNode20.Name = "Russia";
            treeNode20.Text = "Россия";
            treeNode21.Name = "Country";
            treeNode21.Text = "Страна";
            this.treeViewCountry.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.treeViewCountry.Size = new System.Drawing.Size(162, 174);
            this.treeViewCountry.TabIndex = 0;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.BackColor = System.Drawing.Color.Coral;
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddRoom.Location = new System.Drawing.Point(310, 280);
            this.buttonAddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(181, 69);
            this.buttonAddRoom.TabIndex = 18;
            this.buttonAddRoom.Text = "Добавить информацию о комнате";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            this.buttonAddRoom.MouseEnter += new System.EventHandler(this.buttonGetCost_MouseEnter);
            this.buttonAddRoom.MouseLeave += new System.EventHandler(this.buttonGetCost_MouseLeave);
            // 
            // textBoxRoomInfo
            // 
            this.textBoxRoomInfo.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRoomInfo.Location = new System.Drawing.Point(310, 443);
            this.textBoxRoomInfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoomInfo.Multiline = true;
            this.textBoxRoomInfo.Name = "textBoxRoomInfo";
            this.textBoxRoomInfo.ReadOnly = true;
            this.textBoxRoomInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRoomInfo.Size = new System.Drawing.Size(182, 140);
            this.textBoxRoomInfo.TabIndex = 19;
            // 
            // numericUpDownRooms
            // 
            this.numericUpDownRooms.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownRooms.Location = new System.Drawing.Point(95, 164);
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
            this.buttonOutputFlatInfo.Location = new System.Drawing.Point(508, 280);
            this.buttonOutputFlatInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOutputFlatInfo.Name = "buttonOutputFlatInfo";
            this.buttonOutputFlatInfo.Size = new System.Drawing.Size(182, 69);
            this.buttonOutputFlatInfo.TabIndex = 22;
            this.buttonOutputFlatInfo.Text = "Вывести информацию о квартире";
            this.buttonOutputFlatInfo.UseVisualStyleBackColor = false;
            this.buttonOutputFlatInfo.Click += new System.EventHandler(this.buttonOutputInfo_Click);
            this.buttonOutputFlatInfo.MouseEnter += new System.EventHandler(this.buttonGetCost_MouseEnter);
            this.buttonOutputFlatInfo.MouseLeave += new System.EventHandler(this.buttonGetCost_MouseLeave);
            // 
            // textBoxFlatInfo
            // 
            this.textBoxFlatInfo.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxFlatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFlatInfo.Location = new System.Drawing.Point(508, 360);
            this.textBoxFlatInfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlatInfo.Multiline = true;
            this.textBoxFlatInfo.Name = "textBoxFlatInfo";
            this.textBoxFlatInfo.ReadOnly = true;
            this.textBoxFlatInfo.Size = new System.Drawing.Size(183, 223);
            this.textBoxFlatInfo.TabIndex = 23;
            // 
            // buttonClearInfo
            // 
            this.buttonClearInfo.BackColor = System.Drawing.Color.Coral;
            this.buttonClearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClearInfo.Location = new System.Drawing.Point(176, 636);
            this.buttonClearInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearInfo.Name = "buttonClearInfo";
            this.buttonClearInfo.Size = new System.Drawing.Size(122, 47);
            this.buttonClearInfo.TabIndex = 24;
            this.buttonClearInfo.Text = "ОЧИСТИТЬ";
            this.buttonClearInfo.UseVisualStyleBackColor = false;
            this.buttonClearInfo.Click += new System.EventHandler(this.buttonClearInfo_Click);
            this.buttonClearInfo.MouseEnter += new System.EventHandler(this.buttonGetCost_MouseEnter);
            this.buttonClearInfo.MouseLeave += new System.EventHandler(this.buttonGetCost_MouseLeave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Coral;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(490, 636);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 47);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "СОХРАНИТЬ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonGetCost_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonGetCost_MouseLeave);
            // 
            // labelCostFlat
            // 
            this.labelCostFlat.AutoSize = true;
            this.labelCostFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCostFlat.Location = new System.Drawing.Point(95, 549);
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
            this.textBoxCost.Location = new System.Drawing.Point(97, 581);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(76, 23);
            this.textBoxCost.TabIndex = 28;
            // 
            // buttonGetCost
            // 
            this.buttonGetCost.BackColor = System.Drawing.Color.Coral;
            this.buttonGetCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonGetCost.Location = new System.Drawing.Point(332, 636);
            this.buttonGetCost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetCost.Name = "buttonGetCost";
            this.buttonGetCost.Size = new System.Drawing.Size(127, 47);
            this.buttonGetCost.TabIndex = 29;
            this.buttonGetCost.Text = "РАССЧИТАТЬ СТОИМОСТЬ";
            this.buttonGetCost.UseVisualStyleBackColor = false;
            this.buttonGetCost.Click += new System.EventHandler(this.buttonGetCost_Click);
            this.buttonGetCost.MouseEnter += new System.EventHandler(this.buttonGetCost_MouseEnter);
            this.buttonGetCost.MouseLeave += new System.EventHandler(this.buttonGetCost_MouseLeave);
            // 
            // labelBucks
            // 
            this.labelBucks.AutoSize = true;
            this.labelBucks.BackColor = System.Drawing.Color.Transparent;
            this.labelBucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBucks.Location = new System.Drawing.Point(175, 582);
            this.labelBucks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBucks.Name = "labelBucks";
            this.labelBucks.Size = new System.Drawing.Size(18, 20);
            this.labelBucks.TabIndex = 30;
            this.labelBucks.Text = "$";
            // 
            // buttonOutputRoomInfo
            // 
            this.buttonOutputRoomInfo.BackColor = System.Drawing.Color.Coral;
            this.buttonOutputRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOutputRoomInfo.Location = new System.Drawing.Point(310, 360);
            this.buttonOutputRoomInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOutputRoomInfo.Name = "buttonOutputRoomInfo";
            this.buttonOutputRoomInfo.Size = new System.Drawing.Size(181, 69);
            this.buttonOutputRoomInfo.TabIndex = 31;
            this.buttonOutputRoomInfo.Text = "Вывести информацию о комнате";
            this.buttonOutputRoomInfo.UseVisualStyleBackColor = false;
            this.buttonOutputRoomInfo.Click += new System.EventHandler(this.buttonOutputRoomInfo_Click);
            this.buttonOutputRoomInfo.MouseEnter += new System.EventHandler(this.buttonGetCost_MouseEnter);
            this.buttonOutputRoomInfo.MouseLeave += new System.EventHandler(this.buttonGetCost_MouseLeave);
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(760, 740);
            this.Controls.Add(this.buttonOutputRoomInfo);
            this.Controls.Add(this.labelBucks);
            this.Controls.Add(this.buttonGetCost);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCostFlat);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClearInfo);
            this.Controls.Add(this.textBoxFlatInfo);
            this.Controls.Add(this.buttonOutputFlatInfo);
            this.Controls.Add(this.numericUpDownRooms);
            this.Controls.Add(this.textBoxRoomInfo);
            this.Controls.Add(this.buttonAddRoom);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(776, 779);
            this.MinimumSize = new System.Drawing.Size(776, 779);
            this.Name = "FlatForm";
            this.Text = "Квартира";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).EndInit();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TreeView treeViewCountry;
        private System.Windows.Forms.Label labelFlatNumber;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.TextBox textBoxRoomInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms;
        private System.Windows.Forms.Button buttonOutputFlatInfo;
        private System.Windows.Forms.TextBox textBoxFlatInfo;
        private System.Windows.Forms.Button buttonClearInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCostFlat;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonGetCost;
        private System.Windows.Forms.TextBox textBoxNumberFlat;
        private System.Windows.Forms.TextBox textBoxNumberHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelBucks;
        private System.Windows.Forms.Button buttonOutputRoomInfo;
    }
}

