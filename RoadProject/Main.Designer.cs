namespace RoadProject
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStripRoad = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСоединенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПроектеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlRoadMain = new System.Windows.Forms.TabControl();
            this.tabPageRoadOwner = new System.Windows.Forms.TabPage();
            this.tabControlRoad = new System.Windows.Forms.TabControl();
            this.tabPageTypeRoad = new System.Windows.Forms.TabPage();
            this.tbTypeRoad_TypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageRoadDirection = new System.Windows.Forms.TabPage();
            this.tbRoadDirection_Distance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRoadDirection_Direction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageRoadComposition = new System.Windows.Forms.TabPage();
            this.tbRoadComposition_Composition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageRoad = new System.Windows.Forms.TabPage();
            this.cbRoad_fkComposition = new System.Windows.Forms.ComboBox();
            this.cbRoad_fkRoadDirection = new System.Windows.Forms.ComboBox();
            this.cbRoad_fkTypeRoad = new System.Windows.Forms.ComboBox();
            this.dtpRoad_CloseDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRoad_OpenDate = new System.Windows.Forms.DateTimePicker();
            this.tbRoad_Name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageRoadStatus = new System.Windows.Forms.TabPage();
            this.cbRoadStatus_fkRoad = new System.Windows.Forms.ComboBox();
            this.cbRoadStatus_Status = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbRoadStatus_Describe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPageEquipmentOwner = new System.Windows.Forms.TabPage();
            this.tabControlEquipment = new System.Windows.Forms.TabControl();
            this.tabPageEquipmentType = new System.Windows.Forms.TabPage();
            this.tbEquipmentType_Appoinment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEquipmentType_typeName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageManufacturer = new System.Windows.Forms.TabPage();
            this.dtpManufacturer_CreateDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.tbManufacturer_Country = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbManufacturer_Name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPageLocation = new System.Windows.Forms.TabPage();
            this.tbLocation_Location = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPageDepartments = new System.Windows.Forms.TabPage();
            this.cbDepartments_fkLocation = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbDepartments_Adress = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbDepartments_Name = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPageEquipment = new System.Windows.Forms.TabPage();
            this.cbEquipment_fkDepartments = new System.Windows.Forms.ComboBox();
            this.cbEquipment_fkLocation = new System.Windows.Forms.ComboBox();
            this.cbEquipment_fkManufacturer = new System.Windows.Forms.ComboBox();
            this.cbEquipment_fkEqType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbEquipment_Name = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPageWorkStaffOwner = new System.Windows.Forms.TabPage();
            this.tabControlWorkStaff = new System.Windows.Forms.TabControl();
            this.tabPageWorkStaff = new System.Windows.Forms.TabPage();
            this.cbWorkStaff_fkRoadBrigade = new System.Windows.Forms.ComboBox();
            this.cbWorkStaff_fkDepartments = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbWorkStaff_FIO = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tbWorkStaff_Experience = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbWorkStaff_Address = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbWorkStaff_Phone = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbWorkStaff_Position = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPageRoadBrigade = new System.Windows.Forms.TabPage();
            this.tbRoadBrigade_Describe = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbRoadBrigade_Name = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPageImportantPlacesOwner = new System.Windows.Forms.TabPage();
            this.tabControlImportantPlaces = new System.Windows.Forms.TabControl();
            this.tabPageTypeImportantPlaces = new System.Windows.Forms.TabPage();
            this.cbTypeImportantPlaces_Priority = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tbTypeImportantPlaces_TypeName = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tabPageImportantPlaces = new System.Windows.Forms.TabPage();
            this.cbImportantPlaces_fkTypeImpPlaces = new System.Windows.Forms.ComboBox();
            this.cbImportantPlaces_fkRoad = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tbImportantPlaces_Describe = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tbImportantPlaces_Name = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tabPageRoadOrder = new System.Windows.Forms.TabPage();
            this.cbRoadOrder_fkRoad = new System.Windows.Forms.ComboBox();
            this.cbRoadOrder_fkRoadBrigade = new System.Windows.Forms.ComboBox();
            this.cbRoadOrder_Status = new System.Windows.Forms.ComboBox();
            this.dtpRoadOrder_Date = new System.Windows.Forms.DateTimePicker();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tbRoadOrder_Name = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.bNavigatorMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.bSearch = new System.Windows.Forms.ToolStripButton();
            this.bClearSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bEdit = new System.Windows.Forms.ToolStripButton();
            this.bAdd = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.helpProviderRoad = new System.Windows.Forms.HelpProvider();
            this.menuStripRoad.SuspendLayout();
            this.tabControlRoadMain.SuspendLayout();
            this.tabPageRoadOwner.SuspendLayout();
            this.tabControlRoad.SuspendLayout();
            this.tabPageTypeRoad.SuspendLayout();
            this.tabPageRoadDirection.SuspendLayout();
            this.tabPageRoadComposition.SuspendLayout();
            this.tabPageRoad.SuspendLayout();
            this.tabPageRoadStatus.SuspendLayout();
            this.tabPageEquipmentOwner.SuspendLayout();
            this.tabControlEquipment.SuspendLayout();
            this.tabPageEquipmentType.SuspendLayout();
            this.tabPageManufacturer.SuspendLayout();
            this.tabPageLocation.SuspendLayout();
            this.tabPageDepartments.SuspendLayout();
            this.tabPageEquipment.SuspendLayout();
            this.tabPageWorkStaffOwner.SuspendLayout();
            this.tabControlWorkStaff.SuspendLayout();
            this.tabPageWorkStaff.SuspendLayout();
            this.tabPageRoadBrigade.SuspendLayout();
            this.tabPageImportantPlacesOwner.SuspendLayout();
            this.tabControlImportantPlaces.SuspendLayout();
            this.tabPageTypeImportantPlaces.SuspendLayout();
            this.tabPageImportantPlaces.SuspendLayout();
            this.tabPageRoadOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorMain)).BeginInit();
            this.bNavigatorMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripRoad
            // 
            this.menuStripRoad.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripRoad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.toolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStripRoad.Location = new System.Drawing.Point(0, 0);
            this.menuStripRoad.Name = "menuStripRoad";
            this.menuStripRoad.Size = new System.Drawing.Size(872, 26);
            this.menuStripRoad.TabIndex = 0;
            this.menuStripRoad.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("менюToolStripMenuItem.Image")));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиСоединенияToolStripMenuItem});
            this.настройкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкиToolStripMenuItem.Image")));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиСоединенияToolStripMenuItem
            // 
            this.настройкиСоединенияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкиСоединенияToolStripMenuItem.Image")));
            this.настройкиСоединенияToolStripMenuItem.Name = "настройкиСоединенияToolStripMenuItem";
            this.настройкиСоединенияToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.настройкиСоединенияToolStripMenuItem.Text = "Настройки соединения";
            this.настройкиСоединенияToolStripMenuItem.Click += new System.EventHandler(this.настройкиСоединенияToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 22);
            this.toolStripMenuItem1.Text = "|";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОПроектеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.справкаF1ToolStripMenuItem});
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // информацияОПроектеToolStripMenuItem
            // 
            this.информацияОПроектеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("информацияОПроектеToolStripMenuItem.Image")));
            this.информацияОПроектеToolStripMenuItem.Name = "информацияОПроектеToolStripMenuItem";
            this.информацияОПроектеToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.информацияОПроектеToolStripMenuItem.Text = "Информация о проекте";
            this.информацияОПроектеToolStripMenuItem.Click += new System.EventHandler(this.информацияОПроектеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // справкаF1ToolStripMenuItem
            // 
            this.справкаF1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаF1ToolStripMenuItem.Image")));
            this.справкаF1ToolStripMenuItem.Name = "справкаF1ToolStripMenuItem";
            this.справкаF1ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.справкаF1ToolStripMenuItem.Text = "Справка (F1)";
            this.справкаF1ToolStripMenuItem.Click += new System.EventHandler(this.справкаF1ToolStripMenuItem_Click);
            // 
            // tabControlRoadMain
            // 
            this.tabControlRoadMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlRoadMain.Controls.Add(this.tabPageRoadOwner);
            this.tabControlRoadMain.Controls.Add(this.tabPageEquipmentOwner);
            this.tabControlRoadMain.Controls.Add(this.tabPageWorkStaffOwner);
            this.tabControlRoadMain.Controls.Add(this.tabPageImportantPlacesOwner);
            this.tabControlRoadMain.Controls.Add(this.tabPageRoadOrder);
            this.tabControlRoadMain.Location = new System.Drawing.Point(0, 56);
            this.tabControlRoadMain.Name = "tabControlRoadMain";
            this.tabControlRoadMain.SelectedIndex = 0;
            this.tabControlRoadMain.Size = new System.Drawing.Size(458, 445);
            this.tabControlRoadMain.TabIndex = 1;
            this.tabControlRoadMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlRoadMain_Selecting);
            // 
            // tabPageRoadOwner
            // 
            this.tabPageRoadOwner.BackColor = System.Drawing.Color.DimGray;
            this.tabPageRoadOwner.Controls.Add(this.tabControlRoad);
            this.tabPageRoadOwner.Location = new System.Drawing.Point(4, 27);
            this.tabPageRoadOwner.Name = "tabPageRoadOwner";
            this.tabPageRoadOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoadOwner.Size = new System.Drawing.Size(450, 414);
            this.tabPageRoadOwner.TabIndex = 0;
            this.tabPageRoadOwner.Text = "Дороги";
            // 
            // tabControlRoad
            // 
            this.tabControlRoad.Controls.Add(this.tabPageTypeRoad);
            this.tabControlRoad.Controls.Add(this.tabPageRoadDirection);
            this.tabControlRoad.Controls.Add(this.tabPageRoadComposition);
            this.tabControlRoad.Controls.Add(this.tabPageRoad);
            this.tabControlRoad.Controls.Add(this.tabPageRoadStatus);
            this.tabControlRoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRoad.Location = new System.Drawing.Point(3, 3);
            this.tabControlRoad.Name = "tabControlRoad";
            this.tabControlRoad.SelectedIndex = 0;
            this.tabControlRoad.Size = new System.Drawing.Size(444, 408);
            this.tabControlRoad.TabIndex = 0;
            this.tabControlRoad.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlRoad_Selecting);
            // 
            // tabPageTypeRoad
            // 
            this.tabPageTypeRoad.BackColor = System.Drawing.Color.DimGray;
            this.tabPageTypeRoad.Controls.Add(this.tbTypeRoad_TypeName);
            this.tabPageTypeRoad.Controls.Add(this.label2);
            this.tabPageTypeRoad.Location = new System.Drawing.Point(4, 27);
            this.tabPageTypeRoad.Name = "tabPageTypeRoad";
            this.tabPageTypeRoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeRoad.Size = new System.Drawing.Size(436, 377);
            this.tabPageTypeRoad.TabIndex = 0;
            this.tabPageTypeRoad.Text = "Типы";
            // 
            // tbTypeRoad_TypeName
            // 
            this.tbTypeRoad_TypeName.Location = new System.Drawing.Point(10, 111);
            this.tbTypeRoad_TypeName.MaxLength = 99;
            this.tbTypeRoad_TypeName.Name = "tbTypeRoad_TypeName";
            this.tbTypeRoad_TypeName.Size = new System.Drawing.Size(420, 23);
            this.tbTypeRoad_TypeName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип дороги:";
            // 
            // tabPageRoadDirection
            // 
            this.tabPageRoadDirection.BackColor = System.Drawing.Color.DimGray;
            this.tabPageRoadDirection.Controls.Add(this.tbRoadDirection_Distance);
            this.tabPageRoadDirection.Controls.Add(this.label4);
            this.tabPageRoadDirection.Controls.Add(this.tbRoadDirection_Direction);
            this.tabPageRoadDirection.Controls.Add(this.label3);
            this.tabPageRoadDirection.Location = new System.Drawing.Point(4, 27);
            this.tabPageRoadDirection.Name = "tabPageRoadDirection";
            this.tabPageRoadDirection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoadDirection.Size = new System.Drawing.Size(436, 377);
            this.tabPageRoadDirection.TabIndex = 1;
            this.tabPageRoadDirection.Text = "Направления";
            // 
            // tbRoadDirection_Distance
            // 
            this.tbRoadDirection_Distance.Location = new System.Drawing.Point(10, 161);
            this.tbRoadDirection_Distance.MaxLength = 99;
            this.tbRoadDirection_Distance.Name = "tbRoadDirection_Distance";
            this.tbRoadDirection_Distance.Size = new System.Drawing.Size(420, 23);
            this.tbRoadDirection_Distance.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Длинна дороги:";
            // 
            // tbRoadDirection_Direction
            // 
            this.tbRoadDirection_Direction.Location = new System.Drawing.Point(10, 111);
            this.tbRoadDirection_Direction.MaxLength = 99;
            this.tbRoadDirection_Direction.Name = "tbRoadDirection_Direction";
            this.tbRoadDirection_Direction.Size = new System.Drawing.Size(420, 23);
            this.tbRoadDirection_Direction.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Направление дороги:";
            // 
            // tabPageRoadComposition
            // 
            this.tabPageRoadComposition.BackColor = System.Drawing.Color.DimGray;
            this.tabPageRoadComposition.Controls.Add(this.tbRoadComposition_Composition);
            this.tabPageRoadComposition.Controls.Add(this.label5);
            this.tabPageRoadComposition.Location = new System.Drawing.Point(4, 27);
            this.tabPageRoadComposition.Name = "tabPageRoadComposition";
            this.tabPageRoadComposition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoadComposition.Size = new System.Drawing.Size(436, 377);
            this.tabPageRoadComposition.TabIndex = 2;
            this.tabPageRoadComposition.Text = "Состав";
            // 
            // tbRoadComposition_Composition
            // 
            this.tbRoadComposition_Composition.Location = new System.Drawing.Point(10, 111);
            this.tbRoadComposition_Composition.MaxLength = 254;
            this.tbRoadComposition_Composition.Multiline = true;
            this.tbRoadComposition_Composition.Name = "tbRoadComposition_Composition";
            this.tbRoadComposition_Composition.Size = new System.Drawing.Size(420, 118);
            this.tbRoadComposition_Composition.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Состав дороги:";
            // 
            // tabPageRoad
            // 
            this.tabPageRoad.BackColor = System.Drawing.Color.DimGray;
            this.tabPageRoad.Controls.Add(this.cbRoad_fkComposition);
            this.tabPageRoad.Controls.Add(this.cbRoad_fkRoadDirection);
            this.tabPageRoad.Controls.Add(this.cbRoad_fkTypeRoad);
            this.tabPageRoad.Controls.Add(this.dtpRoad_CloseDate);
            this.tabPageRoad.Controls.Add(this.dtpRoad_OpenDate);
            this.tabPageRoad.Controls.Add(this.tbRoad_Name);
            this.tabPageRoad.Controls.Add(this.label11);
            this.tabPageRoad.Controls.Add(this.label10);
            this.tabPageRoad.Controls.Add(this.label9);
            this.tabPageRoad.Controls.Add(this.label8);
            this.tabPageRoad.Controls.Add(this.label7);
            this.tabPageRoad.Controls.Add(this.label6);
            this.tabPageRoad.Location = new System.Drawing.Point(4, 27);
            this.tabPageRoad.Name = "tabPageRoad";
            this.tabPageRoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoad.Size = new System.Drawing.Size(436, 377);
            this.tabPageRoad.TabIndex = 3;
            this.tabPageRoad.Text = "Дороги";
            // 
            // cbRoad_fkComposition
            // 
            this.cbRoad_fkComposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoad_fkComposition.FormattingEnabled = true;
            this.cbRoad_fkComposition.Location = new System.Drawing.Point(7, 294);
            this.cbRoad_fkComposition.Name = "cbRoad_fkComposition";
            this.cbRoad_fkComposition.Size = new System.Drawing.Size(420, 26);
            this.cbRoad_fkComposition.TabIndex = 25;
            // 
            // cbRoad_fkRoadDirection
            // 
            this.cbRoad_fkRoadDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoad_fkRoadDirection.FormattingEnabled = true;
            this.cbRoad_fkRoadDirection.Location = new System.Drawing.Point(7, 241);
            this.cbRoad_fkRoadDirection.Name = "cbRoad_fkRoadDirection";
            this.cbRoad_fkRoadDirection.Size = new System.Drawing.Size(420, 26);
            this.cbRoad_fkRoadDirection.TabIndex = 24;
            // 
            // cbRoad_fkTypeRoad
            // 
            this.cbRoad_fkTypeRoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoad_fkTypeRoad.FormattingEnabled = true;
            this.cbRoad_fkTypeRoad.Location = new System.Drawing.Point(7, 188);
            this.cbRoad_fkTypeRoad.Name = "cbRoad_fkTypeRoad";
            this.cbRoad_fkTypeRoad.Size = new System.Drawing.Size(420, 26);
            this.cbRoad_fkTypeRoad.TabIndex = 23;
            // 
            // dtpRoad_CloseDate
            // 
            this.dtpRoad_CloseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRoad_CloseDate.Location = new System.Drawing.Point(7, 138);
            this.dtpRoad_CloseDate.Name = "dtpRoad_CloseDate";
            this.dtpRoad_CloseDate.Size = new System.Drawing.Size(420, 23);
            this.dtpRoad_CloseDate.TabIndex = 22;
            // 
            // dtpRoad_OpenDate
            // 
            this.dtpRoad_OpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRoad_OpenDate.Location = new System.Drawing.Point(7, 88);
            this.dtpRoad_OpenDate.Name = "dtpRoad_OpenDate";
            this.dtpRoad_OpenDate.Size = new System.Drawing.Size(420, 23);
            this.dtpRoad_OpenDate.TabIndex = 21;
            // 
            // tbRoad_Name
            // 
            this.tbRoad_Name.Location = new System.Drawing.Point(7, 38);
            this.tbRoad_Name.MaxLength = 99;
            this.tbRoad_Name.Name = "tbRoad_Name";
            this.tbRoad_Name.Size = new System.Drawing.Size(420, 23);
            this.tbRoad_Name.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Название дороги:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Дата открытия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Состав дороги:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Направление дороги:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Тип дороги:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата закрытия:";
            // 
            // tabPageRoadStatus
            // 
            this.tabPageRoadStatus.BackColor = System.Drawing.Color.DimGray;
            this.tabPageRoadStatus.Controls.Add(this.cbRoadStatus_fkRoad);
            this.tabPageRoadStatus.Controls.Add(this.cbRoadStatus_Status);
            this.tabPageRoadStatus.Controls.Add(this.label14);
            this.tabPageRoadStatus.Controls.Add(this.tbRoadStatus_Describe);
            this.tabPageRoadStatus.Controls.Add(this.label12);
            this.tabPageRoadStatus.Controls.Add(this.label13);
            this.tabPageRoadStatus.Location = new System.Drawing.Point(4, 27);
            this.tabPageRoadStatus.Name = "tabPageRoadStatus";
            this.tabPageRoadStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoadStatus.Size = new System.Drawing.Size(436, 377);
            this.tabPageRoadStatus.TabIndex = 4;
            this.tabPageRoadStatus.Text = "Статус";
            // 
            // cbRoadStatus_fkRoad
            // 
            this.cbRoadStatus_fkRoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoadStatus_fkRoad.FormattingEnabled = true;
            this.cbRoadStatus_fkRoad.Location = new System.Drawing.Point(10, 214);
            this.cbRoadStatus_fkRoad.Name = "cbRoadStatus_fkRoad";
            this.cbRoadStatus_fkRoad.Size = new System.Drawing.Size(420, 26);
            this.cbRoadStatus_fkRoad.TabIndex = 20;
            // 
            // cbRoadStatus_Status
            // 
            this.cbRoadStatus_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoadStatus_Status.FormattingEnabled = true;
            this.cbRoadStatus_Status.Items.AddRange(new object[] {
            "Отличное",
            "Приемлимое",
            "Плохое"});
            this.cbRoadStatus_Status.Location = new System.Drawing.Point(10, 111);
            this.cbRoadStatus_Status.Name = "cbRoadStatus_Status";
            this.cbRoadStatus_Status.Size = new System.Drawing.Size(420, 26);
            this.cbRoadStatus_Status.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Дорога:";
            // 
            // tbRoadStatus_Describe
            // 
            this.tbRoadStatus_Describe.Location = new System.Drawing.Point(10, 164);
            this.tbRoadStatus_Describe.MaxLength = 99;
            this.tbRoadStatus_Describe.Name = "tbRoadStatus_Describe";
            this.tbRoadStatus_Describe.Size = new System.Drawing.Size(420, 23);
            this.tbRoadStatus_Describe.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Описание:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Статус дороги:";
            // 
            // tabPageEquipmentOwner
            // 
            this.tabPageEquipmentOwner.BackColor = System.Drawing.Color.DimGray;
            this.tabPageEquipmentOwner.Controls.Add(this.tabControlEquipment);
            this.tabPageEquipmentOwner.Location = new System.Drawing.Point(4, 27);
            this.tabPageEquipmentOwner.Name = "tabPageEquipmentOwner";
            this.tabPageEquipmentOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEquipmentOwner.Size = new System.Drawing.Size(450, 414);
            this.tabPageEquipmentOwner.TabIndex = 1;
            this.tabPageEquipmentOwner.Text = "Техника";
            // 
            // tabControlEquipment
            // 
            this.tabControlEquipment.Controls.Add(this.tabPageEquipmentType);
            this.tabControlEquipment.Controls.Add(this.tabPageManufacturer);
            this.tabControlEquipment.Controls.Add(this.tabPageLocation);
            this.tabControlEquipment.Controls.Add(this.tabPageDepartments);
            this.tabControlEquipment.Controls.Add(this.tabPageEquipment);
            this.tabControlEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEquipment.Location = new System.Drawing.Point(3, 3);
            this.tabControlEquipment.Name = "tabControlEquipment";
            this.tabControlEquipment.SelectedIndex = 0;
            this.tabControlEquipment.Size = new System.Drawing.Size(444, 408);
            this.tabControlEquipment.TabIndex = 1;
            this.tabControlEquipment.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlEquipment_Selecting);
            // 
            // tabPageEquipmentType
            // 
            this.tabPageEquipmentType.BackColor = System.Drawing.Color.DimGray;
            this.tabPageEquipmentType.Controls.Add(this.tbEquipmentType_Appoinment);
            this.tabPageEquipmentType.Controls.Add(this.label16);
            this.tabPageEquipmentType.Controls.Add(this.tbEquipmentType_typeName);
            this.tabPageEquipmentType.Controls.Add(this.label15);
            this.tabPageEquipmentType.Location = new System.Drawing.Point(4, 27);
            this.tabPageEquipmentType.Name = "tabPageEquipmentType";
            this.tabPageEquipmentType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEquipmentType.Size = new System.Drawing.Size(436, 377);
            this.tabPageEquipmentType.TabIndex = 0;
            this.tabPageEquipmentType.Text = "Типы";
            // 
            // tbEquipmentType_Appoinment
            // 
            this.tbEquipmentType_Appoinment.Location = new System.Drawing.Point(10, 161);
            this.tbEquipmentType_Appoinment.MaxLength = 99;
            this.tbEquipmentType_Appoinment.Name = "tbEquipmentType_Appoinment";
            this.tbEquipmentType_Appoinment.Size = new System.Drawing.Size(420, 23);
            this.tbEquipmentType_Appoinment.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(214, 21);
            this.label16.TabIndex = 11;
            this.label16.Text = "Назначение техники:";
            // 
            // tbEquipmentType_typeName
            // 
            this.tbEquipmentType_typeName.Location = new System.Drawing.Point(10, 111);
            this.tbEquipmentType_typeName.MaxLength = 99;
            this.tbEquipmentType_typeName.Name = "tbEquipmentType_typeName";
            this.tbEquipmentType_typeName.Size = new System.Drawing.Size(420, 23);
            this.tbEquipmentType_typeName.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 21);
            this.label15.TabIndex = 9;
            this.label15.Text = "Тип техники:";
            // 
            // tabPageManufacturer
            // 
            this.tabPageManufacturer.BackColor = System.Drawing.Color.DimGray;
            this.tabPageManufacturer.Controls.Add(this.dtpManufacturer_CreateDate);
            this.tabPageManufacturer.Controls.Add(this.label19);
            this.tabPageManufacturer.Controls.Add(this.tbManufacturer_Country);
            this.tabPageManufacturer.Controls.Add(this.label18);
            this.tabPageManufacturer.Controls.Add(this.tbManufacturer_Name);
            this.tabPageManufacturer.Controls.Add(this.label17);
            this.tabPageManufacturer.Location = new System.Drawing.Point(4, 27);
            this.tabPageManufacturer.Name = "tabPageManufacturer";
            this.tabPageManufacturer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManufacturer.Size = new System.Drawing.Size(436, 377);
            this.tabPageManufacturer.TabIndex = 1;
            this.tabPageManufacturer.Text = "Производитель";
            // 
            // dtpManufacturer_CreateDate
            // 
            this.dtpManufacturer_CreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManufacturer_CreateDate.Location = new System.Drawing.Point(10, 211);
            this.dtpManufacturer_CreateDate.Name = "dtpManufacturer_CreateDate";
            this.dtpManufacturer_CreateDate.Size = new System.Drawing.Size(420, 23);
            this.dtpManufacturer_CreateDate.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(6, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 21);
            this.label19.TabIndex = 15;
            this.label19.Text = "Дата создания:";
            // 
            // tbManufacturer_Country
            // 
            this.tbManufacturer_Country.Location = new System.Drawing.Point(10, 161);
            this.tbManufacturer_Country.MaxLength = 99;
            this.tbManufacturer_Country.Name = "tbManufacturer_Country";
            this.tbManufacturer_Country.Size = new System.Drawing.Size(420, 23);
            this.tbManufacturer_Country.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "Страна:";
            // 
            // tbManufacturer_Name
            // 
            this.tbManufacturer_Name.Location = new System.Drawing.Point(10, 111);
            this.tbManufacturer_Name.MaxLength = 99;
            this.tbManufacturer_Name.Name = "tbManufacturer_Name";
            this.tbManufacturer_Name.Size = new System.Drawing.Size(420, 23);
            this.tbManufacturer_Name.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 21);
            this.label17.TabIndex = 11;
            this.label17.Text = "Производитель:";
            // 
            // tabPageLocation
            // 
            this.tabPageLocation.BackColor = System.Drawing.Color.DimGray;
            this.tabPageLocation.Controls.Add(this.tbLocation_Location);
            this.tabPageLocation.Controls.Add(this.label20);
            this.tabPageLocation.Location = new System.Drawing.Point(4, 27);
            this.tabPageLocation.Name = "tabPageLocation";
            this.tabPageLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocation.Size = new System.Drawing.Size(436, 377);
            this.tabPageLocation.TabIndex = 2;
            this.tabPageLocation.Text = "Локация";
            // 
            // tbLocation_Location
            // 
            this.tbLocation_Location.Location = new System.Drawing.Point(10, 111);
            this.tbLocation_Location.MaxLength = 99;
            this.tbLocation_Location.Name = "tbLocation_Location";
            this.tbLocation_Location.Size = new System.Drawing.Size(420, 23);
            this.tbLocation_Location.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 21);
            this.label20.TabIndex = 13;
            this.label20.Text = "Расположение:";
            // 
            // tabPageDepartments
            // 
            this.tabPageDepartments.BackColor = System.Drawing.Color.DimGray;
            this.tabPageDepartments.Controls.Add(this.cbDepartments_fkLocation);
            this.tabPageDepartments.Controls.Add(this.label23);
            this.tabPageDepartments.Controls.Add(this.tbDepartments_Adress);
            this.tabPageDepartments.Controls.Add(this.label22);
            this.tabPageDepartments.Controls.Add(this.tbDepartments_Name);
            this.tabPageDepartments.Controls.Add(this.label21);
            this.tabPageDepartments.Location = new System.Drawing.Point(4, 27);
            this.tabPageDepartments.Name = "tabPageDepartments";
            this.tabPageDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartments.Size = new System.Drawing.Size(436, 377);
            this.tabPageDepartments.TabIndex = 3;
            this.tabPageDepartments.Text = "Подразделения";
            // 
            // cbDepartments_fkLocation
            // 
            this.cbDepartments_fkLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments_fkLocation.FormattingEnabled = true;
            this.cbDepartments_fkLocation.Location = new System.Drawing.Point(10, 211);
            this.cbDepartments_fkLocation.Name = "cbDepartments_fkLocation";
            this.cbDepartments_fkLocation.Size = new System.Drawing.Size(420, 26);
            this.cbDepartments_fkLocation.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(6, 187);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 21);
            this.label23.TabIndex = 19;
            this.label23.Text = "Расположение:";
            // 
            // tbDepartments_Adress
            // 
            this.tbDepartments_Adress.Location = new System.Drawing.Point(10, 161);
            this.tbDepartments_Adress.MaxLength = 99;
            this.tbDepartments_Adress.Name = "tbDepartments_Adress";
            this.tbDepartments_Adress.Size = new System.Drawing.Size(420, 23);
            this.tbDepartments_Adress.TabIndex = 18;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(6, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 21);
            this.label22.TabIndex = 17;
            this.label22.Text = "Адрес:";
            // 
            // tbDepartments_Name
            // 
            this.tbDepartments_Name.Location = new System.Drawing.Point(10, 111);
            this.tbDepartments_Name.MaxLength = 99;
            this.tbDepartments_Name.Name = "tbDepartments_Name";
            this.tbDepartments_Name.Size = new System.Drawing.Size(420, 23);
            this.tbDepartments_Name.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(6, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 21);
            this.label21.TabIndex = 15;
            this.label21.Text = "Название:";
            // 
            // tabPageEquipment
            // 
            this.tabPageEquipment.BackColor = System.Drawing.Color.DimGray;
            this.tabPageEquipment.Controls.Add(this.cbEquipment_fkDepartments);
            this.tabPageEquipment.Controls.Add(this.cbEquipment_fkLocation);
            this.tabPageEquipment.Controls.Add(this.cbEquipment_fkManufacturer);
            this.tabPageEquipment.Controls.Add(this.cbEquipment_fkEqType);
            this.tabPageEquipment.Controls.Add(this.label28);
            this.tabPageEquipment.Controls.Add(this.label27);
            this.tabPageEquipment.Controls.Add(this.label26);
            this.tabPageEquipment.Controls.Add(this.label25);
            this.tabPageEquipment.Controls.Add(this.tbEquipment_Name);
            this.tabPageEquipment.Controls.Add(this.label24);
            this.tabPageEquipment.Location = new System.Drawing.Point(4, 27);
            this.tabPageEquipment.Name = "tabPageEquipment";
            this.tabPageEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEquipment.Size = new System.Drawing.Size(436, 377);
            this.tabPageEquipment.TabIndex = 4;
            this.tabPageEquipment.Text = "Техника";
            // 
            // cbEquipment_fkDepartments
            // 
            this.cbEquipment_fkDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipment_fkDepartments.FormattingEnabled = true;
            this.cbEquipment_fkDepartments.Location = new System.Drawing.Point(10, 320);
            this.cbEquipment_fkDepartments.Name = "cbEquipment_fkDepartments";
            this.cbEquipment_fkDepartments.Size = new System.Drawing.Size(420, 26);
            this.cbEquipment_fkDepartments.TabIndex = 30;
            // 
            // cbEquipment_fkLocation
            // 
            this.cbEquipment_fkLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipment_fkLocation.FormattingEnabled = true;
            this.cbEquipment_fkLocation.Location = new System.Drawing.Point(10, 267);
            this.cbEquipment_fkLocation.Name = "cbEquipment_fkLocation";
            this.cbEquipment_fkLocation.Size = new System.Drawing.Size(420, 26);
            this.cbEquipment_fkLocation.TabIndex = 29;
            // 
            // cbEquipment_fkManufacturer
            // 
            this.cbEquipment_fkManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipment_fkManufacturer.FormattingEnabled = true;
            this.cbEquipment_fkManufacturer.Location = new System.Drawing.Point(10, 214);
            this.cbEquipment_fkManufacturer.Name = "cbEquipment_fkManufacturer";
            this.cbEquipment_fkManufacturer.Size = new System.Drawing.Size(420, 26);
            this.cbEquipment_fkManufacturer.TabIndex = 28;
            // 
            // cbEquipment_fkEqType
            // 
            this.cbEquipment_fkEqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipment_fkEqType.FormattingEnabled = true;
            this.cbEquipment_fkEqType.Location = new System.Drawing.Point(10, 161);
            this.cbEquipment_fkEqType.Name = "cbEquipment_fkEqType";
            this.cbEquipment_fkEqType.Size = new System.Drawing.Size(420, 26);
            this.cbEquipment_fkEqType.TabIndex = 27;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(6, 296);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(162, 21);
            this.label28.TabIndex = 25;
            this.label28.Text = "Подразделение:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(6, 243);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 21);
            this.label27.TabIndex = 23;
            this.label27.Text = "Локация:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(6, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(161, 21);
            this.label26.TabIndex = 21;
            this.label26.Text = "Производитель:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(6, 137);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 21);
            this.label25.TabIndex = 19;
            this.label25.Text = "Тип:";
            // 
            // tbEquipment_Name
            // 
            this.tbEquipment_Name.Location = new System.Drawing.Point(10, 111);
            this.tbEquipment_Name.MaxLength = 99;
            this.tbEquipment_Name.Name = "tbEquipment_Name";
            this.tbEquipment_Name.Size = new System.Drawing.Size(420, 23);
            this.tbEquipment_Name.TabIndex = 18;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(6, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 21);
            this.label24.TabIndex = 17;
            this.label24.Text = "Название:";
            // 
            // tabPageWorkStaffOwner
            // 
            this.tabPageWorkStaffOwner.BackColor = System.Drawing.Color.DimGray;
            this.tabPageWorkStaffOwner.Controls.Add(this.tabControlWorkStaff);
            this.tabPageWorkStaffOwner.Location = new System.Drawing.Point(4, 27);
            this.tabPageWorkStaffOwner.Name = "tabPageWorkStaffOwner";
            this.tabPageWorkStaffOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkStaffOwner.Size = new System.Drawing.Size(450, 414);
            this.tabPageWorkStaffOwner.TabIndex = 2;
            this.tabPageWorkStaffOwner.Text = "Сотрудники";
            // 
            // tabControlWorkStaff
            // 
            this.tabControlWorkStaff.Controls.Add(this.tabPageWorkStaff);
            this.tabControlWorkStaff.Controls.Add(this.tabPageRoadBrigade);
            this.tabControlWorkStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWorkStaff.Location = new System.Drawing.Point(3, 3);
            this.tabControlWorkStaff.Name = "tabControlWorkStaff";
            this.tabControlWorkStaff.SelectedIndex = 0;
            this.tabControlWorkStaff.Size = new System.Drawing.Size(444, 408);
            this.tabControlWorkStaff.TabIndex = 1;
            this.tabControlWorkStaff.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlWorkStaff_Selecting);
            // 
            // tabPageWorkStaff
            // 
            this.tabPageWorkStaff.BackColor = System.Drawing.Color.DimGray;
            this.tabPageWorkStaff.Controls.Add(this.cbWorkStaff_fkRoadBrigade);
            this.tabPageWorkStaff.Controls.Add(this.cbWorkStaff_fkDepartments);
            this.tabPageWorkStaff.Controls.Add(this.label35);
            this.tabPageWorkStaff.Controls.Add(this.tbWorkStaff_FIO);
            this.tabPageWorkStaff.Controls.Add(this.label34);
            this.tabPageWorkStaff.Controls.Add(this.label33);
            this.tabPageWorkStaff.Controls.Add(this.tbWorkStaff_Experience);
            this.tabPageWorkStaff.Controls.Add(this.label32);
            this.tabPageWorkStaff.Controls.Add(this.tbWorkStaff_Address);
            this.tabPageWorkStaff.Controls.Add(this.label31);
            this.tabPageWorkStaff.Controls.Add(this.tbWorkStaff_Phone);
            this.tabPageWorkStaff.Controls.Add(this.label30);
            this.tabPageWorkStaff.Controls.Add(this.tbWorkStaff_Position);
            this.tabPageWorkStaff.Controls.Add(this.label29);
            this.tabPageWorkStaff.Location = new System.Drawing.Point(4, 27);
            this.tabPageWorkStaff.Name = "tabPageWorkStaff";
            this.tabPageWorkStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkStaff.Size = new System.Drawing.Size(436, 377);
            this.tabPageWorkStaff.TabIndex = 0;
            this.tabPageWorkStaff.Text = "Сотрудники";
            // 
            // cbWorkStaff_fkRoadBrigade
            // 
            this.cbWorkStaff_fkRoadBrigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkStaff_fkRoadBrigade.FormattingEnabled = true;
            this.cbWorkStaff_fkRoadBrigade.Location = new System.Drawing.Point(10, 340);
            this.cbWorkStaff_fkRoadBrigade.Name = "cbWorkStaff_fkRoadBrigade";
            this.cbWorkStaff_fkRoadBrigade.Size = new System.Drawing.Size(420, 26);
            this.cbWorkStaff_fkRoadBrigade.TabIndex = 34;
            // 
            // cbWorkStaff_fkDepartments
            // 
            this.cbWorkStaff_fkDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkStaff_fkDepartments.FormattingEnabled = true;
            this.cbWorkStaff_fkDepartments.Location = new System.Drawing.Point(10, 287);
            this.cbWorkStaff_fkDepartments.Name = "cbWorkStaff_fkDepartments";
            this.cbWorkStaff_fkDepartments.Size = new System.Drawing.Size(420, 26);
            this.cbWorkStaff_fkDepartments.TabIndex = 33;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(6, 316);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(97, 21);
            this.label35.TabIndex = 31;
            this.label35.Text = "Бригада:";
            // 
            // tbWorkStaff_FIO
            // 
            this.tbWorkStaff_FIO.Location = new System.Drawing.Point(10, 37);
            this.tbWorkStaff_FIO.MaxLength = 99;
            this.tbWorkStaff_FIO.Name = "tbWorkStaff_FIO";
            this.tbWorkStaff_FIO.Size = new System.Drawing.Size(420, 23);
            this.tbWorkStaff_FIO.TabIndex = 30;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(6, 13);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(61, 21);
            this.label34.TabIndex = 29;
            this.label34.Text = "ФИО:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(6, 263);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(162, 21);
            this.label33.TabIndex = 27;
            this.label33.Text = "Подразделение:";
            // 
            // tbWorkStaff_Experience
            // 
            this.tbWorkStaff_Experience.Location = new System.Drawing.Point(10, 237);
            this.tbWorkStaff_Experience.MaxLength = 99;
            this.tbWorkStaff_Experience.Name = "tbWorkStaff_Experience";
            this.tbWorkStaff_Experience.Size = new System.Drawing.Size(420, 23);
            this.tbWorkStaff_Experience.TabIndex = 26;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(6, 213);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(144, 21);
            this.label32.TabIndex = 25;
            this.label32.Text = "Опыт работы:";
            // 
            // tbWorkStaff_Address
            // 
            this.tbWorkStaff_Address.Location = new System.Drawing.Point(10, 187);
            this.tbWorkStaff_Address.MaxLength = 99;
            this.tbWorkStaff_Address.Name = "tbWorkStaff_Address";
            this.tbWorkStaff_Address.Size = new System.Drawing.Size(420, 23);
            this.tbWorkStaff_Address.TabIndex = 24;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(6, 163);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(73, 21);
            this.label31.TabIndex = 23;
            this.label31.Text = "Адрес:";
            // 
            // tbWorkStaff_Phone
            // 
            this.tbWorkStaff_Phone.Location = new System.Drawing.Point(10, 137);
            this.tbWorkStaff_Phone.MaxLength = 99;
            this.tbWorkStaff_Phone.Name = "tbWorkStaff_Phone";
            this.tbWorkStaff_Phone.Size = new System.Drawing.Size(420, 23);
            this.tbWorkStaff_Phone.TabIndex = 22;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(6, 113);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 21);
            this.label30.TabIndex = 21;
            this.label30.Text = "Телефон:";
            // 
            // tbWorkStaff_Position
            // 
            this.tbWorkStaff_Position.Location = new System.Drawing.Point(10, 87);
            this.tbWorkStaff_Position.MaxLength = 99;
            this.tbWorkStaff_Position.Name = "tbWorkStaff_Position";
            this.tbWorkStaff_Position.Size = new System.Drawing.Size(420, 23);
            this.tbWorkStaff_Position.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(6, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(121, 21);
            this.label29.TabIndex = 19;
            this.label29.Text = "Должность:";
            // 
            // tabPageRoadBrigade
            // 
            this.tabPageRoadBrigade.BackColor = System.Drawing.Color.DimGray;
            this.tabPageRoadBrigade.Controls.Add(this.tbRoadBrigade_Describe);
            this.tabPageRoadBrigade.Controls.Add(this.label37);
            this.tabPageRoadBrigade.Controls.Add(this.tbRoadBrigade_Name);
            this.tabPageRoadBrigade.Controls.Add(this.label36);
            this.tabPageRoadBrigade.Location = new System.Drawing.Point(4, 27);
            this.tabPageRoadBrigade.Name = "tabPageRoadBrigade";
            this.tabPageRoadBrigade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoadBrigade.Size = new System.Drawing.Size(436, 377);
            this.tabPageRoadBrigade.TabIndex = 1;
            this.tabPageRoadBrigade.Text = "Бригады";
            // 
            // tbRoadBrigade_Describe
            // 
            this.tbRoadBrigade_Describe.Location = new System.Drawing.Point(10, 161);
            this.tbRoadBrigade_Describe.MaxLength = 99;
            this.tbRoadBrigade_Describe.Name = "tbRoadBrigade_Describe";
            this.tbRoadBrigade_Describe.Size = new System.Drawing.Size(420, 23);
            this.tbRoadBrigade_Describe.TabIndex = 34;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(6, 137);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(110, 21);
            this.label37.TabIndex = 33;
            this.label37.Text = "Описание:";
            // 
            // tbRoadBrigade_Name
            // 
            this.tbRoadBrigade_Name.Location = new System.Drawing.Point(10, 111);
            this.tbRoadBrigade_Name.MaxLength = 99;
            this.tbRoadBrigade_Name.Name = "tbRoadBrigade_Name";
            this.tbRoadBrigade_Name.Size = new System.Drawing.Size(420, 23);
            this.tbRoadBrigade_Name.TabIndex = 32;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(6, 87);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 21);
            this.label36.TabIndex = 31;
            this.label36.Text = "Название:";
            // 
            // tabPageImportantPlacesOwner
            // 
            this.tabPageImportantPlacesOwner.BackColor = System.Drawing.Color.DimGray;
            this.tabPageImportantPlacesOwner.Controls.Add(this.tabControlImportantPlaces);
            this.tabPageImportantPlacesOwner.Location = new System.Drawing.Point(4, 27);
            this.tabPageImportantPlacesOwner.Name = "tabPageImportantPlacesOwner";
            this.tabPageImportantPlacesOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImportantPlacesOwner.Size = new System.Drawing.Size(450, 414);
            this.tabPageImportantPlacesOwner.TabIndex = 3;
            this.tabPageImportantPlacesOwner.Text = "Места";
            // 
            // tabControlImportantPlaces
            // 
            this.tabControlImportantPlaces.Controls.Add(this.tabPageTypeImportantPlaces);
            this.tabControlImportantPlaces.Controls.Add(this.tabPageImportantPlaces);
            this.tabControlImportantPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlImportantPlaces.Location = new System.Drawing.Point(3, 3);
            this.tabControlImportantPlaces.Name = "tabControlImportantPlaces";
            this.tabControlImportantPlaces.SelectedIndex = 0;
            this.tabControlImportantPlaces.Size = new System.Drawing.Size(444, 408);
            this.tabControlImportantPlaces.TabIndex = 2;
            this.tabControlImportantPlaces.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlImportantPlaces_Selecting);
            // 
            // tabPageTypeImportantPlaces
            // 
            this.tabPageTypeImportantPlaces.BackColor = System.Drawing.Color.DimGray;
            this.tabPageTypeImportantPlaces.Controls.Add(this.cbTypeImportantPlaces_Priority);
            this.tabPageTypeImportantPlaces.Controls.Add(this.label39);
            this.tabPageTypeImportantPlaces.Controls.Add(this.tbTypeImportantPlaces_TypeName);
            this.tabPageTypeImportantPlaces.Controls.Add(this.label38);
            this.tabPageTypeImportantPlaces.Location = new System.Drawing.Point(4, 27);
            this.tabPageTypeImportantPlaces.Name = "tabPageTypeImportantPlaces";
            this.tabPageTypeImportantPlaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeImportantPlaces.Size = new System.Drawing.Size(436, 377);
            this.tabPageTypeImportantPlaces.TabIndex = 0;
            this.tabPageTypeImportantPlaces.Text = "Типы";
            // 
            // cbTypeImportantPlaces_Priority
            // 
            this.cbTypeImportantPlaces_Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeImportantPlaces_Priority.FormattingEnabled = true;
            this.cbTypeImportantPlaces_Priority.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.cbTypeImportantPlaces_Priority.Location = new System.Drawing.Point(10, 161);
            this.cbTypeImportantPlaces_Priority.Name = "cbTypeImportantPlaces_Priority";
            this.cbTypeImportantPlaces_Priority.Size = new System.Drawing.Size(420, 26);
            this.cbTypeImportantPlaces_Priority.TabIndex = 36;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(6, 137);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(120, 21);
            this.label39.TabIndex = 35;
            this.label39.Text = "Приоритет:";
            // 
            // tbTypeImportantPlaces_TypeName
            // 
            this.tbTypeImportantPlaces_TypeName.Location = new System.Drawing.Point(10, 111);
            this.tbTypeImportantPlaces_TypeName.MaxLength = 99;
            this.tbTypeImportantPlaces_TypeName.Name = "tbTypeImportantPlaces_TypeName";
            this.tbTypeImportantPlaces_TypeName.Size = new System.Drawing.Size(420, 23);
            this.tbTypeImportantPlaces_TypeName.TabIndex = 34;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(6, 87);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(201, 21);
            this.label38.TabIndex = 33;
            this.label38.Text = "Тип важного места:";
            // 
            // tabPageImportantPlaces
            // 
            this.tabPageImportantPlaces.BackColor = System.Drawing.Color.DimGray;
            this.tabPageImportantPlaces.Controls.Add(this.cbImportantPlaces_fkTypeImpPlaces);
            this.tabPageImportantPlaces.Controls.Add(this.cbImportantPlaces_fkRoad);
            this.tabPageImportantPlaces.Controls.Add(this.label43);
            this.tabPageImportantPlaces.Controls.Add(this.label42);
            this.tabPageImportantPlaces.Controls.Add(this.tbImportantPlaces_Describe);
            this.tabPageImportantPlaces.Controls.Add(this.label41);
            this.tabPageImportantPlaces.Controls.Add(this.tbImportantPlaces_Name);
            this.tabPageImportantPlaces.Controls.Add(this.label40);
            this.tabPageImportantPlaces.Location = new System.Drawing.Point(4, 27);
            this.tabPageImportantPlaces.Name = "tabPageImportantPlaces";
            this.tabPageImportantPlaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImportantPlaces.Size = new System.Drawing.Size(436, 377);
            this.tabPageImportantPlaces.TabIndex = 1;
            this.tabPageImportantPlaces.Text = "Места";
            // 
            // cbImportantPlaces_fkTypeImpPlaces
            // 
            this.cbImportantPlaces_fkTypeImpPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImportantPlaces_fkTypeImpPlaces.FormattingEnabled = true;
            this.cbImportantPlaces_fkTypeImpPlaces.Location = new System.Drawing.Point(10, 301);
            this.cbImportantPlaces_fkTypeImpPlaces.Name = "cbImportantPlaces_fkTypeImpPlaces";
            this.cbImportantPlaces_fkTypeImpPlaces.Size = new System.Drawing.Size(420, 26);
            this.cbImportantPlaces_fkTypeImpPlaces.TabIndex = 44;
            // 
            // cbImportantPlaces_fkRoad
            // 
            this.cbImportantPlaces_fkRoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImportantPlaces_fkRoad.FormattingEnabled = true;
            this.cbImportantPlaces_fkRoad.Location = new System.Drawing.Point(10, 248);
            this.cbImportantPlaces_fkRoad.Name = "cbImportantPlaces_fkRoad";
            this.cbImportantPlaces_fkRoad.Size = new System.Drawing.Size(420, 26);
            this.cbImportantPlaces_fkRoad.TabIndex = 43;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(6, 277);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(201, 21);
            this.label43.TabIndex = 41;
            this.label43.Text = "Тип важного места:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(6, 224);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 21);
            this.label42.TabIndex = 39;
            this.label42.Text = "Дорога:";
            // 
            // tbImportantPlaces_Describe
            // 
            this.tbImportantPlaces_Describe.Location = new System.Drawing.Point(10, 161);
            this.tbImportantPlaces_Describe.MaxLength = 254;
            this.tbImportantPlaces_Describe.Multiline = true;
            this.tbImportantPlaces_Describe.Name = "tbImportantPlaces_Describe";
            this.tbImportantPlaces_Describe.Size = new System.Drawing.Size(420, 60);
            this.tbImportantPlaces_Describe.TabIndex = 38;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(6, 137);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(259, 21);
            this.label41.TabIndex = 37;
            this.label41.Text = "Описание важного места:";
            // 
            // tbImportantPlaces_Name
            // 
            this.tbImportantPlaces_Name.Location = new System.Drawing.Point(10, 111);
            this.tbImportantPlaces_Name.MaxLength = 99;
            this.tbImportantPlaces_Name.Name = "tbImportantPlaces_Name";
            this.tbImportantPlaces_Name.Size = new System.Drawing.Size(420, 23);
            this.tbImportantPlaces_Name.TabIndex = 36;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(6, 87);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(256, 21);
            this.label40.TabIndex = 35;
            this.label40.Text = "Название важного места:";
            // 
            // tabPageRoadOrder
            // 
            this.tabPageRoadOrder.BackColor = System.Drawing.Color.DimGray;
            this.tabPageRoadOrder.Controls.Add(this.cbRoadOrder_fkRoad);
            this.tabPageRoadOrder.Controls.Add(this.cbRoadOrder_fkRoadBrigade);
            this.tabPageRoadOrder.Controls.Add(this.cbRoadOrder_Status);
            this.tabPageRoadOrder.Controls.Add(this.dtpRoadOrder_Date);
            this.tabPageRoadOrder.Controls.Add(this.label48);
            this.tabPageRoadOrder.Controls.Add(this.label47);
            this.tabPageRoadOrder.Controls.Add(this.label46);
            this.tabPageRoadOrder.Controls.Add(this.label45);
            this.tabPageRoadOrder.Controls.Add(this.tbRoadOrder_Name);
            this.tabPageRoadOrder.Controls.Add(this.label44);
            this.tabPageRoadOrder.Location = new System.Drawing.Point(4, 27);
            this.tabPageRoadOrder.Name = "tabPageRoadOrder";
            this.tabPageRoadOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoadOrder.Size = new System.Drawing.Size(450, 414);
            this.tabPageRoadOrder.TabIndex = 4;
            this.tabPageRoadOrder.Text = "Заказы";
            // 
            // cbRoadOrder_fkRoad
            // 
            this.cbRoadOrder_fkRoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoadOrder_fkRoad.FormattingEnabled = true;
            this.cbRoadOrder_fkRoad.Items.AddRange(new object[] {
            "Выполнено",
            "Не выполнено"});
            this.cbRoadOrder_fkRoad.Location = new System.Drawing.Point(10, 347);
            this.cbRoadOrder_fkRoad.Name = "cbRoadOrder_fkRoad";
            this.cbRoadOrder_fkRoad.Size = new System.Drawing.Size(434, 26);
            this.cbRoadOrder_fkRoad.TabIndex = 50;
            // 
            // cbRoadOrder_fkRoadBrigade
            // 
            this.cbRoadOrder_fkRoadBrigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoadOrder_fkRoadBrigade.FormattingEnabled = true;
            this.cbRoadOrder_fkRoadBrigade.Location = new System.Drawing.Point(10, 294);
            this.cbRoadOrder_fkRoadBrigade.Name = "cbRoadOrder_fkRoadBrigade";
            this.cbRoadOrder_fkRoadBrigade.Size = new System.Drawing.Size(434, 26);
            this.cbRoadOrder_fkRoadBrigade.TabIndex = 49;
            // 
            // cbRoadOrder_Status
            // 
            this.cbRoadOrder_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoadOrder_Status.FormattingEnabled = true;
            this.cbRoadOrder_Status.Items.AddRange(new object[] {
            "Выполнено",
            "Не выполнено"});
            this.cbRoadOrder_Status.Location = new System.Drawing.Point(10, 241);
            this.cbRoadOrder_Status.Name = "cbRoadOrder_Status";
            this.cbRoadOrder_Status.Size = new System.Drawing.Size(434, 26);
            this.cbRoadOrder_Status.TabIndex = 48;
            // 
            // dtpRoadOrder_Date
            // 
            this.dtpRoadOrder_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRoadOrder_Date.Location = new System.Drawing.Point(10, 191);
            this.dtpRoadOrder_Date.Name = "dtpRoadOrder_Date";
            this.dtpRoadOrder_Date.Size = new System.Drawing.Size(434, 23);
            this.dtpRoadOrder_Date.TabIndex = 47;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(6, 323);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(84, 21);
            this.label48.TabIndex = 45;
            this.label48.Text = "Дорога:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(6, 270);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(97, 21);
            this.label47.TabIndex = 43;
            this.label47.Text = "Бригада:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(6, 217);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(81, 21);
            this.label46.TabIndex = 41;
            this.label46.Text = "Статус:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(6, 167);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(148, 21);
            this.label45.TabIndex = 39;
            this.label45.Text = "Дата события:";
            // 
            // tbRoadOrder_Name
            // 
            this.tbRoadOrder_Name.Location = new System.Drawing.Point(10, 141);
            this.tbRoadOrder_Name.MaxLength = 99;
            this.tbRoadOrder_Name.Name = "tbRoadOrder_Name";
            this.tbRoadOrder_Name.Size = new System.Drawing.Size(434, 23);
            this.tbRoadOrder_Name.TabIndex = 38;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(6, 117);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(107, 21);
            this.label44.TabIndex = 37;
            this.label44.Text = "Название:";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(464, 54);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(408, 496);
            this.dgvMain.TabIndex = 2;
            // 
            // bNavigatorMain
            // 
            this.bNavigatorMain.AddNewItem = null;
            this.bNavigatorMain.CountItem = this.bindingNavigatorCountItem;
            this.bNavigatorMain.DeleteItem = null;
            this.bNavigatorMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bDelete,
            this.toolStripSeparator1,
            this.tbSearch,
            this.bSearch,
            this.bClearSearch,
            this.toolStripSeparator2,
            this.bEdit});
            this.bNavigatorMain.Location = new System.Drawing.Point(0, 26);
            this.bNavigatorMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigatorMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigatorMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNavigatorMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNavigatorMain.Name = "bNavigatorMain";
            this.bNavigatorMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bNavigatorMain.Size = new System.Drawing.Size(872, 25);
            this.bNavigatorMain.TabIndex = 3;
            this.bNavigatorMain.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bDelete
            // 
            this.bDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bDelete.Image = ((System.Drawing.Image)(resources.GetObject("bDelete.Image")));
            this.bDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(23, 22);
            this.bDelete.Text = "Удалить строку";
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSearch
            // 
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // bSearch
            // 
            this.bSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSearch.Image = ((System.Drawing.Image)(resources.GetObject("bSearch.Image")));
            this.bSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(23, 22);
            this.bSearch.Text = "Поиск данных";
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bClearSearch
            // 
            this.bClearSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("bClearSearch.Image")));
            this.bClearSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bClearSearch.Name = "bClearSearch";
            this.bClearSearch.Size = new System.Drawing.Size(23, 22);
            this.bClearSearch.Text = "Очистить";
            this.bClearSearch.Click += new System.EventHandler(this.bClearSearch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bEdit
            // 
            this.bEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bEdit.Image = ((System.Drawing.Image)(resources.GetObject("bEdit.Image")));
            this.bEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(23, 22);
            this.bEdit.Text = "Редактировать запись";
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdd.Location = new System.Drawing.Point(7, 507);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(186, 43);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Применить изменения";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bClear.Location = new System.Drawing.Point(272, 507);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(186, 43);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Очистка полей(Отмена)";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(872, 557);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bNavigatorMain);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.tabControlRoadMain);
            this.Controls.Add(this.menuStripRoad);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripRoad;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дорожная служба";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStripRoad.ResumeLayout(false);
            this.menuStripRoad.PerformLayout();
            this.tabControlRoadMain.ResumeLayout(false);
            this.tabPageRoadOwner.ResumeLayout(false);
            this.tabControlRoad.ResumeLayout(false);
            this.tabPageTypeRoad.ResumeLayout(false);
            this.tabPageTypeRoad.PerformLayout();
            this.tabPageRoadDirection.ResumeLayout(false);
            this.tabPageRoadDirection.PerformLayout();
            this.tabPageRoadComposition.ResumeLayout(false);
            this.tabPageRoadComposition.PerformLayout();
            this.tabPageRoad.ResumeLayout(false);
            this.tabPageRoad.PerformLayout();
            this.tabPageRoadStatus.ResumeLayout(false);
            this.tabPageRoadStatus.PerformLayout();
            this.tabPageEquipmentOwner.ResumeLayout(false);
            this.tabControlEquipment.ResumeLayout(false);
            this.tabPageEquipmentType.ResumeLayout(false);
            this.tabPageEquipmentType.PerformLayout();
            this.tabPageManufacturer.ResumeLayout(false);
            this.tabPageManufacturer.PerformLayout();
            this.tabPageLocation.ResumeLayout(false);
            this.tabPageLocation.PerformLayout();
            this.tabPageDepartments.ResumeLayout(false);
            this.tabPageDepartments.PerformLayout();
            this.tabPageEquipment.ResumeLayout(false);
            this.tabPageEquipment.PerformLayout();
            this.tabPageWorkStaffOwner.ResumeLayout(false);
            this.tabControlWorkStaff.ResumeLayout(false);
            this.tabPageWorkStaff.ResumeLayout(false);
            this.tabPageWorkStaff.PerformLayout();
            this.tabPageRoadBrigade.ResumeLayout(false);
            this.tabPageRoadBrigade.PerformLayout();
            this.tabPageImportantPlacesOwner.ResumeLayout(false);
            this.tabControlImportantPlaces.ResumeLayout(false);
            this.tabPageTypeImportantPlaces.ResumeLayout(false);
            this.tabPageTypeImportantPlaces.PerformLayout();
            this.tabPageImportantPlaces.ResumeLayout(false);
            this.tabPageImportantPlaces.PerformLayout();
            this.tabPageRoadOrder.ResumeLayout(false);
            this.tabPageRoadOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorMain)).EndInit();
            this.bNavigatorMain.ResumeLayout(false);
            this.bNavigatorMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripRoad;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиСоединенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОПроектеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem справкаF1ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlRoadMain;
        private System.Windows.Forms.TabPage tabPageRoadOwner;
        private System.Windows.Forms.TabPage tabPageEquipmentOwner;
        private System.Windows.Forms.TabPage tabPageWorkStaffOwner;
        private System.Windows.Forms.TabControl tabControlEquipment;
        private System.Windows.Forms.TabPage tabPageEquipmentType;
        private System.Windows.Forms.TabPage tabPageManufacturer;
        private System.Windows.Forms.TabControl tabControlWorkStaff;
        private System.Windows.Forms.TabPage tabPageWorkStaff;
        private System.Windows.Forms.TabPage tabPageRoadBrigade;
        private System.Windows.Forms.TabPage tabPageImportantPlacesOwner;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.BindingNavigator bNavigatorMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage tabPageLocation;
        private System.Windows.Forms.TabPage tabPageDepartments;
        private System.Windows.Forms.TabPage tabPageEquipment;
        private System.Windows.Forms.TabControl tabControlRoad;
        private System.Windows.Forms.TabPage tabPageTypeRoad;
        private System.Windows.Forms.TabPage tabPageRoadDirection;
        private System.Windows.Forms.TabPage tabPageRoadComposition;
        private System.Windows.Forms.TabPage tabPageRoad;
        private System.Windows.Forms.TabPage tabPageRoadStatus;
        private System.Windows.Forms.TabPage tabPageRoadOrder;
        private System.Windows.Forms.TabControl tabControlImportantPlaces;
        private System.Windows.Forms.TabPage tabPageTypeImportantPlaces;
        private System.Windows.Forms.TabPage tabPageImportantPlaces;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.HelpProvider helpProviderRoad;
        private System.Windows.Forms.ToolStripButton bDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripButton bSearch;
        private System.Windows.Forms.ToolStripButton bClearSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTypeRoad_TypeName;
        private System.Windows.Forms.TextBox tbRoadDirection_Distance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRoadDirection_Direction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRoadComposition_Composition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRoad_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRoad_OpenDate;
        private System.Windows.Forms.DateTimePicker dtpRoad_CloseDate;
        private System.Windows.Forms.ComboBox cbRoad_fkTypeRoad;
        private System.Windows.Forms.ComboBox cbRoad_fkRoadDirection;
        private System.Windows.Forms.ComboBox cbRoad_fkComposition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbRoadStatus_Describe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbRoadStatus_Status;
        private System.Windows.Forms.ComboBox cbRoadStatus_fkRoad;
        private System.Windows.Forms.TextBox tbEquipmentType_typeName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbEquipmentType_Appoinment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbManufacturer_Name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbManufacturer_Country;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpManufacturer_CreateDate;
        private System.Windows.Forms.TextBox tbLocation_Location;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbDepartments_Name;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbDepartments_Adress;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbDepartments_fkLocation;
        private System.Windows.Forms.TextBox tbEquipment_Name;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbEquipment_fkDepartments;
        private System.Windows.Forms.ComboBox cbEquipment_fkLocation;
        private System.Windows.Forms.ComboBox cbEquipment_fkManufacturer;
        private System.Windows.Forms.ComboBox cbEquipment_fkEqType;
        private System.Windows.Forms.TextBox tbWorkStaff_Position;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbWorkStaff_FIO;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbWorkStaff_Experience;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbWorkStaff_Address;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbWorkStaff_Phone;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cbWorkStaff_fkRoadBrigade;
        private System.Windows.Forms.ComboBox cbWorkStaff_fkDepartments;
        private System.Windows.Forms.TextBox tbRoadBrigade_Name;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbRoadBrigade_Describe;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbTypeImportantPlaces_TypeName;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cbTypeImportantPlaces_Priority;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox tbImportantPlaces_Name;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tbImportantPlaces_Describe;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cbImportantPlaces_fkTypeImpPlaces;
        private System.Windows.Forms.ComboBox cbImportantPlaces_fkRoad;
        private System.Windows.Forms.TextBox tbRoadOrder_Name;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.DateTimePicker dtpRoadOrder_Date;
        private System.Windows.Forms.ComboBox cbRoadOrder_Status;
        private System.Windows.Forms.ComboBox cbRoadOrder_fkRoad;
        private System.Windows.Forms.ComboBox cbRoadOrder_fkRoadBrigade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bEdit;
    }
}

