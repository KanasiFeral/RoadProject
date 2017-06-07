using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RoadProject
{
    public partial class Main : Form
    {
        public bool bFlagAddRecord = true;
        public string sEditId;

        public MSSQLConnector conSQL;
        public Main(MSSQLConnector conSQL)
        {
            InitializeComponent();
            this.conSQL = conSQL;
        }
        
        //Процедура загрузки данных в таблицу 100%
        public void vLoadTable(TabControl tabControl)
        {
            //Проверка первого таб контрола
            if (tabControl == tabControlRoad)
            {
                if (tabControl.SelectedTab == tabPageTypeRoad)
                {
                    conSQL.vLoadTable("TYPE_ROAD", "SELECT iIdTypeRoad, vTypeName AS 'Тип дороги' FROM TYPE_ROAD",
                        conSQL.binSourceTypeRoad, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageRoadDirection)
                {
                    conSQL.vLoadTable("ROAD_DIRECTION", "SELECT iIdRoadDirection, vDirection AS 'Направление', "
                        + "vDistance AS 'Длинна' FROM ROAD_DIRECTION", conSQL.binSourceRoadDirection, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageRoadComposition)
                {
                    conSQL.vLoadTable("ROAD_COMPOSITION", "SELECT iIdRoadComposition, vComposition AS 'Состав' "
                        + "FROM ROAD_COMPOSITION", conSQL.binSourceRoadComposition, dgvMain, bNavigatorMain);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoad)
                {
                    //Прогрузка данных в выпадающие списки
                    try
                    {
                        conSQL.bQueryToComboBox("SELECT vTypeName FROM TYPE_ROAD", cbRoad_fkTypeRoad, "vTypeName");
                        conSQL.bQueryToComboBox("SELECT vDirection FROM ROAD_DIRECTION", cbRoad_fkRoadDirection, "vDirection");
                        conSQL.bQueryToComboBox("SELECT vComposition FROM ROAD_COMPOSITION", cbRoad_fkComposition, "vComposition");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    conSQL.vLoadTable("ROAD", "SELECT R.iIdRoad, R.vName AS 'Название', R.vOpenDate AS 'Дата открытия', "
                        + "R.vCloseDate AS 'Дата закрытия', TR.vTypeName AS 'Тип дороги', RD.vDirection AS 'Направление дороги', "
                        + "RC.vComposition AS 'Состав дороги' FROM ROAD AS R, TYPE_ROAD AS TR, ROAD_DIRECTION AS RD, "
                        + "ROAD_COMPOSITION AS RC WHERE R.fk_iIdTypeRoad = TR.iIdTypeRoad AND R.fk_iIdRoadDirection = "
                        + "RD.iIdRoadDirection AND R.fk_iIdRoadComposition = RC.iIdRoadComposition",
                        conSQL.binSourceRoad, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageRoadStatus)
                {
                    //Прогрузка данных в выпадающие списки
                    try
                    {
                        conSQL.bQueryToComboBox("SELECT vName FROM ROAD", cbRoadStatus_fkRoad, "vName");
                        cbRoadStatus_Status.SelectedIndex = 0;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    conSQL.vLoadTable("ROAD_STATUS", "SELECT RS.iIdRoadStatus, RS.vStatus AS 'Статус', RS.vDescribe "
                        + "AS 'Описание', R.vName AS 'Дорога' FROM ROAD_STATUS AS RS, ROAD AS R WHERE RS.fk_iIdRoad = R.iIdRoad",
                        conSQL.binSourceRoadStatus, dgvMain, bNavigatorMain);
                }
            }
            //Проверка второго таб контрола
            else if (tabControl == tabControlEquipment)
            {
                if (tabControl.SelectedTab == tabPageEquipmentType)
                {
                    conSQL.vLoadTable("EQUIPMENT_TYPE", "SELECT iIdEquipmentType, vTypeName AS 'Тип', vAppoinment "
                        + "AS 'Назначение' FROM EQUIPMENT_TYPE",
                        conSQL.binSourceEquipmentType, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageManufacturer)
                {
                    conSQL.vLoadTable("MANUFACTURER", "SELECT iIdManufacturer, vName AS 'Название', vCountry AS "
                        + "'Страна', vCreateDate AS 'Дата создания' FROM MANUFACTURER",
                        conSQL.binSourceEquipment, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageLocation)
                {
                    conSQL.vLoadTable("LOCATION", "SELECT iIdLocation, vLocation AS 'Локация' FROM LOCATION",
                        conSQL.binSourceLocation, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageDepartments)
                {
                    //Прогрузка данных в выпадающие списки
                    try
                    {
                        conSQL.bQueryToComboBox("SELECT vLocation FROM LOCATION", cbDepartments_fkLocation, "vLocation");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    conSQL.vLoadTable("DEPARTMENTS", "SELECT D.iIdDepartments, D.vName AS 'Название', D.vAddress AS "
                        + "'Адрес', L.vLocation AS 'Локация' FROM DEPARTMENTS AS D, LOCATION AS L WHERE D.fk_iIdLocation = "
                        + "L.iIdLocation",
                        conSQL.binSourceDepartments, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageEquipment)
                {
                    //Прогрузка данных в выпадающие списки
                    try
                    {
                        conSQL.bQueryToComboBox("SELECT vTypeName FROM EQUIPMENT_TYPE", cbEquipment_fkEqType, "vTypeName");
                        conSQL.bQueryToComboBox("SELECT vName FROM MANUFACTURER", cbEquipment_fkManufacturer, "vName");
                        conSQL.bQueryToComboBox("SELECT vLocation FROM LOCATION", cbEquipment_fkLocation, "vLocation");
                        conSQL.bQueryToComboBox("SELECT vName FROM DEPARTMENTS", cbEquipment_fkDepartments, "vName");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    conSQL.vLoadTable("EQUIPMENT", "SELECT EQ.iIdEquipment, EQ.vName AS 'Название', EQT.vTypeName AS "
                        + "'Тип', M.vName AS 'Производитель', L.vLocation AS 'Локация', D.vName AS 'Подразделение' FROM EQUIPMENT "
                        + "AS EQ, EQUIPMENT_TYPE AS EQT, MANUFACTURER AS M, LOCATION AS L, DEPARTMENTS AS D WHERE "
                        + "EQ.fk_iIdEquipmentType = EQT.iIdEquipmentType AND EQ.fk_iIdManufacturer = M.iIdManufacturer AND "
                        + "EQ.fk_iIdLocation = L.iIdLocation AND EQ.fk_iIdDepartments = D.iIdDepartments",
                        conSQL.binSourceEquipment, dgvMain, bNavigatorMain);
                }
            }
            //Проверка третьего таб контрола
            else if (tabControl == tabControlWorkStaff)
            {
                if (tabControl.SelectedTab == tabPageWorkStaff)
                {
                    //Прогрузка данных в выпадающие списки
                    try
                    {
                        conSQL.bQueryToComboBox("SELECT vName FROM ROAD_BRIGADE", cbWorkStaff_fkRoadBrigade, "vName");
                        conSQL.bQueryToComboBox("SELECT vName FROM DEPARTMENTS", cbWorkStaff_fkDepartments, "vName");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    conSQL.vLoadTable("WORK_STAFF", "SELECT WS.iIdWorkStaff, WS.vFIO AS 'ФИО', WS.vPosition AS 'Должность', WS.vPhone "
                        + "AS 'Телефон', WS.vAddress AS 'Адрес', WS.vExperience AS 'Опыт работы', D.vName AS 'Подразделение', RB.vName "
                        + "AS 'Бригада' FROM WORK_STAFF AS WS, DEPARTMENTS AS D, ROAD_BRIGADE AS RB WHERE WS.fk_iIdDepartments = "
                        + "D.iIdDepartments AND WS.fk_iIdRoadBrigade = RB.iIdRoadBrigade",
                        conSQL.binSourceWorkStaff, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageRoadBrigade)
                {
                    conSQL.vLoadTable("ROAD_BRIGADE", "SELECT iIdRoadBrigade, vName AS 'Название', vDescribe AS 'Описание' FROM ROAD_BRIGADE",
                        conSQL.binSourceRoadBrigade, dgvMain, bNavigatorMain);
                }
            }
            //Проверка четвертого таб контрола
            else if (tabControl == tabControlImportantPlaces)
            {
                if (tabControl.SelectedTab == tabPageTypeImportantPlaces)
                {
                    cbTypeImportantPlaces_Priority.SelectedIndex = 0;

                    conSQL.vLoadTable("TYPE_IMPORTANT_PLACES", "SELECT iIdTypeImportantPlaces, vTypeName AS "
                        + "'Тип', vPrioity AS 'Приоритет' FROM TYPE_IMPORTANT_PLACES",
                        conSQL.binSourceTypeImportantPlaces, dgvMain, bNavigatorMain);
                }
                else if (tabControl.SelectedTab == tabPageImportantPlaces)
                {
                    //Прогрузка данных в выпадающие списки
                    try
                    {
                        conSQL.bQueryToComboBox("SELECT vName FROM ROAD", cbImportantPlaces_fkRoad, "vName");
                        conSQL.bQueryToComboBox("SELECT vTypeName FROM TYPE_IMPORTANT_PLACES", cbImportantPlaces_fkTypeImpPlaces, "vTypeName");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    conSQL.vLoadTable("IMPORTANT_PLACES", "SELECT IP.iIdImportantPlaces, IP.vName AS 'Название', "
                        + "IP.vDescribe AS 'Описание', R.vName AS 'Дорога', TIP.vTypeName AS 'Тип места' FROM IMPORTANT_PLACES AS IP, "
                        + "ROAD AS R, TYPE_IMPORTANT_PLACES AS TIP WHERE IP.fk_iIdRoad = R.iIdRoad AND IP.fk_iIdTypeImportantPlaces = "
                        + "TIP.iIdTypeImportantPlaces",
                        conSQL.binSourceImportantPlaces, dgvMain, bNavigatorMain);
                }
            }
            //Проверка пятого таб контрола
            else if (tabControl == tabControlRoadMain)
            {
                if (tabControl.SelectedTab == tabPageRoadOrder)
                {
                    //Прогрузка данных в выпадающие списки
                    try
                    {
                        conSQL.bQueryToComboBox("SELECT vName FROM ROAD", cbRoadOrder_fkRoad, "vName");
                        conSQL.bQueryToComboBox("SELECT vName FROM ROAD_BRIGADE", cbRoadOrder_fkRoadBrigade, "vName");
                        cbRoadOrder_Status.SelectedIndex = 0;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверка пятого таб контрола
                    if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
                    {
                        conSQL.vLoadTable("ROAD_ORDER", "SELECT RO.iIdRoadOrder, RO.vName AS 'Название', RO.vDate AS "
                            + "'Дата', RO.vStatus AS 'Статус', RB.vName AS 'Бригада', R.vName AS 'Дорога' FROM ROAD_ORDER AS RO, "
                            + "ROAD_BRIGADE AS RB, ROAD AS R WHERE RO.fk_iIdRoadBrigade = RB.iIdRoadBrigade AND RO.fk_iIdRoad = R.iIdRoad",
                            conSQL.binSourceRoadOrder, dgvMain, bNavigatorMain);
                    }
                }
            }

            //Сокрытие id таблицы
            vHideIdInTable();
        }

        //Процедура проверки объектов на пустоту значений 100%
        public bool bCheckIsEmpty(List<Object> listObj)
        {
            TextBox textBoxClear = new TextBox();
            ComboBox comboBoxClear = new ComboBox();
            DateTimePicker dateTimePickerClear = new DateTimePicker();
            Object obj = new Object();

            //Очистка полей ввода
            for (int i = 0; i < listObj.Count; i++)
            {
                //Присваиваем объект массива нашему временному объекту
                obj = listObj[i];

                //Проверка на тип объекта TextBox
                if (obj.GetType() == typeof(TextBox))
                {
                    //Делаем приведение типов
                    textBoxClear = (TextBox)listObj[i];
                    //Проверяем на пустоту
                    if(textBoxClear.Text.Equals(""))
                    {
                        return false;
                    }
                }
                //Проверка на тип объекта ComboBox
                else if (obj.GetType() == typeof(ComboBox))
                {
                    //Делаем приведение типов
                    comboBoxClear = (ComboBox)listObj[i];
                    //Проверяем на пустоту
                    if (comboBoxClear.Text.Equals(""))
                    {
                        return false;
                    }
                }
                //Проверка на тип объекта DateTimePicker
                else if (obj.GetType() == typeof(DateTimePicker))
                {
                    //Делаем приведение типов
                    dateTimePickerClear = (DateTimePicker)listObj[i];
                    if (dateTimePickerClear.Text.Equals(""))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //Процедура очистки полей ввода 100%
        public void vClearFields(List<Object> listObj)
        {
            TextBox textBoxClear = new TextBox();
            ComboBox comboBoxClear = new ComboBox();
            DateTimePicker dateTimePickerClear = new DateTimePicker();
            Object obj = new Object();

            //Очистка полей ввода
            for (int i = 0; i < listObj.Count; i++)
            {
                //Присваиваем объект массива нашему временному объекту
                obj = listObj[i];

                //Проверка на тип объекта TextBox
                if (obj.GetType() == typeof(TextBox))
                {
                    //Делаем приведение типов
                    textBoxClear = (TextBox)listObj[i];
                    //Очищаем объект
                    textBoxClear.Clear();
                    //Возвращаем на место
                    listObj[i] = textBoxClear;
                }
                //Проверка на тип объекта ComboBox
                else if (obj.GetType() == typeof(ComboBox))
                {
                    //Делаем приведение типов
                    comboBoxClear = (ComboBox)listObj[i];
                    //Очищаем объект
                    comboBoxClear.SelectedIndex = 0;
                    //Возвращаем на место
                    listObj[i] = comboBoxClear;
                }
                //Проверка на тип объекта DateTimePicker
                else if (obj.GetType() == typeof(DateTimePicker))
                {
                    //Делаем приведение типов
                    dateTimePickerClear = (DateTimePicker)listObj[i];
                    //Очищаем объект
                    dateTimePickerClear.Value = DateTime.Now;
                    //Возвращаем на место
                    listObj[i] = dateTimePickerClear;
                }
            }
        }

        //Процедура переноса значений из таблицы на форму для редактирования 100%
        public void vMoveValueToForm(string sQueryIsEmpty, TabPage tabPage, string sTabPageText, DataGridView dgView, List<Object> listObj)
        {
            TextBox textBoxEdit = new TextBox();
            ComboBox comboBoxEdit = new ComboBox();
            DateTimePicker dateTimePickerEdit = new DateTimePicker();

            if (conSQL.bQueryToBool(sQueryIsEmpty) == true)
            {
                //Изменяем название
                tabPage.Text = sTabPageText;
                //Вызов процедуры очистки полей ввода (проверить, возвращается ли объект)
                vClearFields(listObj);

                //Определение текущей выделенной строки
                int iCurrentRow = dgView.CurrentRow.Index;
                //Забираем значение ячейки с id
                sEditId = Convert.ToString(dgView[0, iCurrentRow].Value);
                //Забираем значение ячейки
                for (int i = 0; i < listObj.Count; i++)
                {
                    //Проверка на тип объекта TextBox
                    if (listObj[i].GetType() == typeof(TextBox))
                    {
                        //Делаем приведение типов
                        textBoxEdit = (TextBox)listObj[i];
                        //Присваиваем значение
                        textBoxEdit.Text = Convert.ToString(dgView[i+1, iCurrentRow].Value);
                        //Возвращаем в массив
                        listObj[i] = textBoxEdit;
                    }
                    //Проверка на тип объекта ComboBox
                    else if (listObj[i].GetType() == typeof(ComboBox))
                    {
                        //Делаем приведение типов
                        comboBoxEdit = (ComboBox)listObj[i];
                        //Присваиваем значение
                        comboBoxEdit.Text = Convert.ToString(dgView[i+1, iCurrentRow].Value);
                        //Возвращаем в массив
                        listObj[i] = comboBoxEdit;

                    }
                    //Проверка на тип объекта DateTimePicker
                    else if (listObj[i].GetType() == typeof(DateTimePicker))
                    {
                        //Делаем приведение типов
                        dateTimePickerEdit = (DateTimePicker)listObj[i];
                        //Присваиваем значение
                        dateTimePickerEdit.Text = Convert.ToString(dgView[i+1, iCurrentRow].Value);
                        //Возвращаем в массив
                        listObj[i] = dateTimePickerEdit;
                    }
                }

                //Меняем статус флага добавления
                bFlagAddRecord = false;
            }
            else
            {
                MessageBox.Show("Нету данных для изменения!", "Ошибка!");
            }
        }

        //Процедура получения максимального id из таблицы 100%
        public string sMaxId(string sId, string sTableName)
        {
            string sIdMax = "";
            //Строка запроса выяснения максимального id в таблице
            string sQueryMaxId = "SELECT MAX(" + sId + ") FROM " + sTableName + "";
            //Выполнение запроса
            if (conSQL.bQueryToBool("SELECT * FROM " + sTableName + "") == true)
            {
                string sBuffer = conSQL.sAgregateQueryToDataGrid(sQueryMaxId);
                int iIdMax = Int16.Parse(sBuffer);
                iIdMax++;
                sIdMax = Convert.ToString(iIdMax);
            }
            else
            {
                sIdMax = "1";
            }

            return sIdMax;
        }

        //Процедура добавления строки в любую таблицу 100%
        public bool bAddRecordInTable(String[] massTableInfo, String[] massValues)
        {
            //Создаем начальную строку добавления
            string sAddQuery = "insert into " + massTableInfo[0] + " (";

            //Цикл добавления в строку добавления колонок таблицы
            for(int i = 1; i < massTableInfo.Length; i++)
            {
                //Если это не последний элемент массива
                if (i != massTableInfo.Length - 1)
                {
                    sAddQuery += massTableInfo[i] + ",";
                }
                else
                {
                    sAddQuery += massTableInfo[i] + ") values (";
                }
            }

            //Выяснение максимального значения id таблицы
            string sMaxId = this.sMaxId(massTableInfo[1], massTableInfo[0]);

            //Цикл добавления списка значений
            for (int i = 0; i <= massValues.Length; i++)
            {
                if (i == 0)
                {
                    sAddQuery += sMaxId + ",'";
                }
                //Если это не последний элемент массива
                else if (i != massValues.Length)
                {
                    sAddQuery += massValues[i-1] + "','";
                }
                else
                {
                    sAddQuery += massValues[i-1] + "')";
                }
            }

            //Добавление строки, выполнение запроса
            if (conSQL.bQueryToBool(sAddQuery) == true)
            {
                //Произошла ошибка
                return true;
            }
            else
            {               
                return false;
            }
        }

        //Процедура редактирования значений в любой таблице 100%
        public bool bEditRecordInTable(String[] massTableInfo, String[] massValues)
        {
            string sEditQuery = "UPDATE " + massTableInfo[0] + " SET ";

            //Цикл добавления имен столбцов и значений этих столбцов
            for(int i = 1; i < massTableInfo.Length; i++)
            {
                //Если это первое значение, id таблицы
                if(i == 1)
                {
                    sEditQuery += massTableInfo[i] + " = " + massValues[i-1] + ", ";
                }
                //Если это не последний элемент массива
                else if (i != massTableInfo.Length - 1)
                {
                    sEditQuery += massTableInfo[i] + " = '" + massValues[i-1] + "', ";
                }
                else
                {
                    sEditQuery += massTableInfo[i] + " = '" + massValues[i - 1] + "' WHERE " 
                        + massTableInfo[1] + " = " + massValues[0];
                }
            }

            //Добавление строки, выполнение запроса
            if (conSQL.bQueryToBool(sEditQuery) == true)
            {
                //Произошла ошибка
                return true;
            }
            else
            {                
                return false;
            }
        }

        //Процедура "Поиска по datagrid" 100%
        public void vSearchDatagrid(DataGridView dGV, ToolStripTextBox text)
        {
            if (text.Text.Equals(""))
            {
                MessageBox.Show("Введите искомое значение!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int i, j = 0;
                for (i = 0; i < dGV.ColumnCount; i++)
                {
                    for (j = 0; j < dGV.RowCount; j++)
                    {
                        dGV[i, j].Style.BackColor = Color.White;
                        dGV[i, j].Style.ForeColor = Color.Black;
                    }
                }
                for (i = 0; i < dGV.ColumnCount; i++)
                {
                    for (j = 0; j < dGV.RowCount; j++)
                    {
                        if ((dGV[i, j].FormattedValue.ToString().Contains(text.Text.Trim())))
                        {
                            dGV[i, j].Style.BackColor = Color.DimGray;
                            dGV[i, j].Style.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        //Процедура очистки результатов поиска 100%
        public void vClearDatagrid(DataGridView dGV)
        {
            int i;
            int j;
            for (i = 0; i <= dGV.ColumnCount - 1; i++)
            {
                for (j = 0; j <= dGV.RowCount - 1; j++)
                {
                    dGV[i, j].Style.BackColor = Color.White;
                    dGV[i, j].Style.ForeColor = Color.Black;
                }
            }
        }

        //Процедура сокрытия id в таблице 100%
        public void vHideIdInTable()
        {
            //Сокрытие id таблицы
            try
            {
                dgvMain.Columns[0].Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Процедура удаления записи 100%
        public void vDeleteRecord(string sNameOfTable, string sId, BindingSource binSource)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?",
                        "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (conSQL.bQueryToBool("SELECT * FROM " + sNameOfTable + "") == false)
                {
                    MessageBox.Show("Все строки были удалены из базы", "Ошибка удаления!");
                }
                else
                {
                    int iIdCurrent = 0;
                    //Определяем индекс выбранной строки
                    int i = dgvMain.CurrentRow.Index;
                    iIdCurrent = Convert.ToInt32(dgvMain[0, i].Value);
                    //Удаление строки
                    conSQL.bQueryToBool("DELETE FROM " + sNameOfTable + " WHERE " + sId + " = " + iIdCurrent);
                    //Удаляем строку из представления
                    binSource.RemoveAt(i);
                }
            }
        }

        //Кнопка: выход из программы 100%
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conSQL.bCloseConnection();
            Application.Exit();
        }

        //Загрузка формы 100%
        private void Main_Load(object sender, EventArgs e)
        {
            //Вызываем вкладку дороги, как основную для проекта
            tabControlRoad.SelectedTab = tabPageRoad;

            helpProviderRoad.HelpNamespace = @"Data\Help\RoadHelp.chm";
            helpProviderRoad.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProviderRoad.SetShowHelp(this, true);
        }

        //Кнопка: настройка соединения подключения к базе данных 100%
        private void настройкиСоединенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Stngs = new Settings(conSQL);
            Stngs.Show();
            //Return to Main
            Stngs.bReturnToMain.Enabled = true;
            //Cancel
            Stngs.bCancel.Enabled = false;
            this.Hide();
        }

        //Кнопка: вызов информации о проекте 100%
        private void информацияОПроектеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Андрей Годун\nДорожная служба\nБГУиР ©2017","Сообщение!");
        }

        //Кнопка: вызов справки 100%
        private void справкаF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProviderRoad.HelpNamespace);
        }

        //Происходит после закрытия формы 100%
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            conSQL.bCloseConnection();
            Application.Exit();
        }

        //Кнопка: удалить запись 100%
        private void bDelete_Click(object sender, EventArgs e)
        {
            //Проверка первого таб контрола
            if (tabControlRoadMain.SelectedTab == tabPageRoadOwner)
            {
                if (tabControlRoad.SelectedTab == tabPageTypeRoad)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("TYPE_ROAD", "iIdTypeRoad", conSQL.binSourceTypeRoad);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlRoad);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadDirection)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("ROAD_DIRECTION", "iIdRoadDirection", conSQL.binSourceRoadDirection);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlRoad);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadComposition)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("ROAD_COMPOSITION", "iIdRoadComposition", conSQL.binSourceRoadComposition);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlRoad);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoad)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("ROAD", "iIdRoad", conSQL.binSourceRoad);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlRoad);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadStatus)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("ROAD_STATUS", "iIdRoadStatus", conSQL.binSourceRoadStatus);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlRoad);
                }
            }
            //Проверка второго таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageEquipmentOwner)
            {
                if (tabControlEquipment.SelectedTab == tabPageEquipmentType)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("EQUIPMENT_TYPE", "iIdEquipmentType", conSQL.binSourceEquipmentType);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlEquipment);
                }
                else if (tabControlEquipment.SelectedTab == tabPageManufacturer)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("MANUFACTURER", "iIdManufacturer", conSQL.binSourceManufacturer);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlEquipment);
                }
                else if (tabControlEquipment.SelectedTab == tabPageLocation)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("LOCATION", "iIdLocation", conSQL.binSourceLocation);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlEquipment);
                }
                else if (tabControlEquipment.SelectedTab == tabPageDepartments)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("DEPARTMENTS", "iIdDepartments", conSQL.binSourceDepartments);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlEquipment);
                }
                else if (tabControlEquipment.SelectedTab == tabPageEquipment)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("EQUIPMENT", "iIdEquipment", conSQL.binSourceEquipment);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlEquipment);
                }
            }
            //Проверка четвертого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageImportantPlacesOwner)
            {
                if (tabControlImportantPlaces.SelectedTab == tabPageTypeImportantPlaces)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("TYPE_IMPORTANT_PLACES", "iIdTypeImportantPlaces", conSQL.binSourceTypeImportantPlaces);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlImportantPlaces);
                }
                else if (tabControlImportantPlaces.SelectedTab == tabPageImportantPlaces)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("IMPORTANT_PLACES", "iIdImportantPlaces", conSQL.binSourceImportantPlaces);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlImportantPlaces);
                }
            }
            //Проверка третьего таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageWorkStaffOwner)
            {
                if (tabControlWorkStaff.SelectedTab == tabPageWorkStaff)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("WORK_STAFF", "iIdWorkStaff", conSQL.binSourceWorkStaff);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlWorkStaff);
                }
                else if (tabControlWorkStaff.SelectedTab == tabPageRoadBrigade)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("ROAD_BRIGADE", "iIdRoadBrigade", conSQL.binSourceRoadBrigade);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlWorkStaff);
                }
            }
            //Проверка пятого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
            {
                if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
                {
                    //Вызов процедуры удаления строки из таблицы
                    vDeleteRecord("ROAD_ORDER", "iIdRoadOrder", conSQL.binSourceRoadOrder);
                    //Прогрузка данных в таблицу
                    vLoadTable(tabControlRoadMain);
                }
            }            
        }

        //Кнопка: поиск данных в таблице 100%
        private void bSearch_Click(object sender, EventArgs e)
        {
            vSearchDatagrid(dgvMain, tbSearch);
        }

        //Кнопка: очистка данных поиска 100%
        private void bClearSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            vClearDatagrid(dgvMain);
        }

        //Кнопка: применить изменения (добавление/редактирование) 100%
        private void bAdd_Click(object sender, EventArgs e)
        {
            //Обьявляем лист объектов
            List<Object> listObj = new List<Object>();

            //Проверка первого таб контрола
            if (tabControlRoadMain.SelectedTab == tabPageRoadOwner)
            {
                if (tabControlRoad.SelectedTab == tabPageTypeRoad)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbTypeRoad_TypeName);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "TYPE_ROAD", "iIdTypeRoad", "vTypeName" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbTypeRoad_TypeName.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbTypeRoad_TypeName.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageTypeRoad.Text = "Типы";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlRoad);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadDirection)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadDirection_Direction);
                    listObj.Add(tbRoadDirection_Distance);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "ROAD_DIRECTION", "iIdRoadDirection", "vDirection", "vDistance" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbRoadDirection_Direction.Text, tbRoadDirection_Distance.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbRoadDirection_Direction.Text, tbRoadDirection_Distance.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageRoadDirection.Text = "Направления";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlRoad);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadComposition)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadComposition_Composition);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "ROAD_COMPOSITION", "iIdRoadComposition", "vComposition" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbRoadComposition_Composition.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbRoadComposition_Composition.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageRoadComposition.Text = "Состав";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlRoad);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlRoad.SelectedTab == tabPageRoad)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoad_Name); listObj.Add(dtpRoad_OpenDate); listObj.Add(dtpRoad_CloseDate);
                    listObj.Add(cbRoad_fkTypeRoad); listObj.Add(cbRoad_fkRoadDirection); listObj.Add(cbRoad_fkComposition);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "ROAD", "iIdRoad", "vName", "vOpenDate", "vCloseDate",
                    "fk_iIdTypeRoad", "fk_iIdRoadDirection", "fk_iIdRoadComposition" };

                    //Объявление переменных под id записей
                    string sIdTypeRoad = "", sIdRoadDirection = "", sIdRoadComposition = "";

                    //Получние id значений, т.к. в выпадающих списках текст
                    try
                    {
                        sIdTypeRoad = conSQL.sAgregateQueryToDataGrid("SELECT iIdTypeRoad FROM TYPE_ROAD WHERE vTypeName = '"
                       + cbRoad_fkTypeRoad.Text + "'");
                        sIdRoadDirection = conSQL.sAgregateQueryToDataGrid("SELECT iIdRoadDirection FROM ROAD_DIRECTION WHERE vDirection = '"
                            + cbRoad_fkRoadDirection.Text + "'");
                        sIdRoadComposition = conSQL.sAgregateQueryToDataGrid("SELECT iIdRoadComposition FROM ROAD_COMPOSITION WHERE vComposition = '"
                            + cbRoad_fkComposition.Text + "'");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbRoad_Name.Text, dtpRoad_OpenDate.Text, dtpRoad_CloseDate.Text,
                                sIdTypeRoad, sIdRoadDirection, sIdRoadComposition};

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbRoad_Name.Text, dtpRoad_OpenDate.Text, dtpRoad_CloseDate.Text,
                                sIdTypeRoad, sIdRoadDirection, sIdRoadComposition};

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageRoad.Text = "Дороги";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlRoad);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadStatus)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadStatus_Describe); listObj.Add(cbRoadStatus_Status); listObj.Add(cbRoadStatus_fkRoad);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "ROAD_STATUS", "iIdRoadStatus", "vStatus", "vDescribe", "fk_iIdRoad" };

                    //Объявление переменных под id записей
                    string sIdRoad = "";

                    //Получние id значений, т.к. в выпадающих списках текст
                    try
                    {
                        sIdRoad = conSQL.sAgregateQueryToDataGrid("SELECT iIdRoad FROM ROAD WHERE vName = '"
                        + cbRoadStatus_fkRoad.Text + "'");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { cbRoadStatus_Status.Text, tbRoadStatus_Describe.Text, sIdRoad };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, cbRoadStatus_Status.Text, tbRoadStatus_Describe.Text, sIdRoad };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageRoadStatus.Text = "Статус";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlRoad);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
            }
            //Проверка второго таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageEquipmentOwner)
            {
                if (tabControlEquipment.SelectedTab == tabPageEquipmentType)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbEquipmentType_typeName); listObj.Add(tbEquipmentType_Appoinment);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "EQUIPMENT_TYPE", "iIdEquipmentType", "vTypeName", "vAppoinment" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbEquipmentType_typeName.Text, tbEquipmentType_Appoinment.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbEquipmentType_typeName.Text, tbEquipmentType_Appoinment.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageEquipmentType.Text = "Типы";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlEquipment);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlEquipment.SelectedTab == tabPageManufacturer)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbManufacturer_Name);
                    listObj.Add(tbManufacturer_Country);
                    listObj.Add(dtpManufacturer_CreateDate);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "MANUFACTURER", "iIdManufacturer", "vName", "vCountry", "vCreateDate" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbManufacturer_Name.Text, tbManufacturer_Country.Text, dtpManufacturer_CreateDate.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbManufacturer_Name.Text, tbManufacturer_Country.Text, dtpManufacturer_CreateDate.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageManufacturer.Text = "Производитель";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlEquipment);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlEquipment.SelectedTab == tabPageLocation)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbLocation_Location);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "LOCATION", "iIdLocation", "vLocation" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbLocation_Location.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbLocation_Location.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageLocation.Text = "Локация";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlEquipment);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlEquipment.SelectedTab == tabPageDepartments)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbDepartments_Name);
                    listObj.Add(tbDepartments_Adress);
                    listObj.Add(cbDepartments_fkLocation);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "DEPARTMENTS", "iIdDepartments", "vName", "vAddress", "fk_iIdLocation" };

                    //Объявление переменных под id записей
                    string sIdLocation = "";

                    //Получние id значений, т.к. в выпадающих списках текст
                    try
                    {
                        sIdLocation = conSQL.sAgregateQueryToDataGrid("SELECT iIdLocation FROM LOCATION WHERE vLocation = '"
                            + cbDepartments_fkLocation.Text + "'");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbDepartments_Name.Text, tbDepartments_Adress.Text, sIdLocation };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbDepartments_Name.Text, tbDepartments_Adress.Text, sIdLocation };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageDepartments.Text = "Подразделения";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlEquipment);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlEquipment.SelectedTab == tabPageEquipment)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbEquipment_Name);
                    listObj.Add(cbEquipment_fkEqType);
                    listObj.Add(cbEquipment_fkManufacturer);
                    listObj.Add(cbEquipment_fkLocation);
                    listObj.Add(cbEquipment_fkDepartments);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "EQUIPMENT", "iIdEquipment", "vName", "fk_iIdEquipmentType",
                    "fk_iIdManufacturer", "fk_iIdLocation", "fk_iIdDepartments" };

                    //Объявление переменных под id записей
                    string sIdLocation = "", sIdEquipmentType = "", sIdManufacturer = "", sIdDepartments = "";

                    //Получние id значений, т.к. в выпадающих списках текст 
                    try
                    {
                        sIdEquipmentType = conSQL.sAgregateQueryToDataGrid("SELECT iIdEquipmentType FROM EQUIPMENT_TYPE WHERE vTypeName = '"
                            + cbEquipment_fkEqType.Text + "'");
                        sIdManufacturer = conSQL.sAgregateQueryToDataGrid("SELECT iIdManufacturer FROM MANUFACTURER WHERE vName = '"
                            + cbEquipment_fkManufacturer.Text + "'");
                        sIdLocation = conSQL.sAgregateQueryToDataGrid("SELECT iIdLocation FROM LOCATION WHERE vLocation = '"
                            + cbEquipment_fkLocation.Text + "'");
                        sIdDepartments = conSQL.sAgregateQueryToDataGrid("SELECT iIdDepartments FROM DEPARTMENTS WHERE vName = '"
                            + cbEquipment_fkDepartments.Text + "'");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbEquipment_Name.Text, sIdEquipmentType, sIdManufacturer, sIdLocation, sIdDepartments };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbEquipment_Name.Text, sIdEquipmentType, sIdManufacturer, sIdLocation, sIdDepartments };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageEquipment.Text = "Техника";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlEquipment);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
            }
            //Проверка четвертого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageImportantPlacesOwner)
            {
                if (tabControlImportantPlaces.SelectedTab == tabPageTypeImportantPlaces)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbTypeImportantPlaces_TypeName);
                    listObj.Add(cbTypeImportantPlaces_Priority);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "TYPE_IMPORTANT_PLACES", "iIdTypeImportantPlaces", "vTypeName", "vPrioity" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbTypeImportantPlaces_TypeName.Text, cbTypeImportantPlaces_Priority.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbTypeImportantPlaces_TypeName.Text, cbTypeImportantPlaces_Priority.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageTypeImportantPlaces.Text = "Типы";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlImportantPlaces);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlImportantPlaces.SelectedTab == tabPageImportantPlaces)
                {
                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "IMPORTANT_PLACES", "iIdImportantPlaces", "vName", "vDescribe",
                    "fk_iIdRoad", "fk_iIdTypeImportantPlaces" };

                    //Объявление переменных под id записей
                    string sIdRoad = "", sIdTypeImportantPlaces = "";

                    //Получние id значений, т.к. в выпадающих списках текст                
                    try
                    {
                        sIdRoad = conSQL.sAgregateQueryToDataGrid("SELECT iIdRoad FROM ROAD WHERE vName = '"
                        + cbImportantPlaces_fkRoad.Text + "'");
                        sIdTypeImportantPlaces = conSQL.sAgregateQueryToDataGrid("SELECT iIdTypeImportantPlaces FROM TYPE_IMPORTANT_PLACES WHERE vTypeName = '"
                            + cbImportantPlaces_fkTypeImpPlaces.Text + "'");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbImportantPlaces_Name.Text, tbImportantPlaces_Describe.Text, sIdRoad, sIdTypeImportantPlaces };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbImportantPlaces_Name.Text, tbImportantPlaces_Describe.Text, sIdRoad, sIdTypeImportantPlaces };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageImportantPlaces.Text = "Места";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlImportantPlaces);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
            }
            //Проверка третьего таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageWorkStaffOwner)
            {
                if (tabControlWorkStaff.SelectedTab == tabPageWorkStaff)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbWorkStaff_FIO); listObj.Add(tbWorkStaff_Position); listObj.Add(tbWorkStaff_Phone);
                    listObj.Add(tbWorkStaff_Experience); listObj.Add(cbWorkStaff_fkDepartments); listObj.Add(cbWorkStaff_fkRoadBrigade);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "WORK_STAFF", "iIdWorkStaff", "vFIO", "vPosition",
                    "vPhone", "vAddress", "vExperience", "fk_iIdDepartments", "fk_iIdRoadBrigade" };

                    //Объявление переменных под id записей
                    string sIdDepartments = "", sIdRoadBrigade = "";

                    //Получение id значений, т.к. в выпадающих списках текст  
                    try
                    {
                        sIdDepartments = conSQL.sAgregateQueryToDataGrid("SELECT iIdDepartments FROM DEPARTMENTS WHERE vName = '"
                            + cbWorkStaff_fkDepartments.Text + "'");
                        sIdRoadBrigade = conSQL.sAgregateQueryToDataGrid("SELECT iIdRoadBrigade FROM ROAD_BRIGADE WHERE vName = '"
                            + cbWorkStaff_fkRoadBrigade.Text + "'");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbWorkStaff_FIO.Text, tbWorkStaff_Position.Text, tbWorkStaff_Phone.Text, tbWorkStaff_Address.Text,
                                tbWorkStaff_Experience.Text, sIdDepartments, sIdRoadBrigade};

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbWorkStaff_FIO.Text, tbWorkStaff_Position.Text, tbWorkStaff_Phone.Text, tbWorkStaff_Address.Text,
                        tbWorkStaff_Experience.Text, sIdDepartments, sIdRoadBrigade};

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageWorkStaff.Text = "Сотрудники";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlWorkStaff);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                else if (tabControlWorkStaff.SelectedTab == tabPageRoadBrigade)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadBrigade_Name);
                    listObj.Add(tbRoadBrigade_Describe);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "ROAD_BRIGADE", "iIdRoadBrigade", "vName", "vDescribe" };

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbRoadBrigade_Name.Text, tbRoadBrigade_Describe.Text };

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbRoadBrigade_Name.Text, tbRoadBrigade_Describe.Text };

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageRoadBrigade.Text = "Бригады";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlWorkStaff);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
                
            }
            //Проверка пятого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
            {
                if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadOrder_Name); listObj.Add(dtpRoadOrder_Date); listObj.Add(cbRoadOrder_Status);
                    listObj.Add(cbRoadOrder_fkRoadBrigade); listObj.Add(cbRoadOrder_fkRoad);

                    //Массив данных таблицы
                    String[] massTableInfo = new String[] { "ROAD_ORDER", "iIdRoadOrder", "vName", "vDate",
                    "vStatus", "fk_iIdRoadBrigade", "fk_iIdRoad" };

                    //Объявление переменных под id записей
                    string sIdRoadBrigade = "", sIdRoad = "";

                    //Получние id значений, т.к. в выпадающих списках текст      
                    try
                    {
                        sIdRoadBrigade = conSQL.sAgregateQueryToDataGrid("SELECT iIdRoadBrigade FROM ROAD_BRIGADE WHERE vName = '"
                            + cbRoadOrder_fkRoadBrigade.Text + "'");
                        sIdRoad = conSQL.sAgregateQueryToDataGrid("SELECT iIdRoad FROM ROAD WHERE vName = '"
                            + cbRoadOrder_fkRoad.Text + "'");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    //Проверку на пустоту
                    if (bCheckIsEmpty(listObj) == true)
                    {
                        if (bFlagAddRecord == true)
                        {
                            //Массив значений
                            String[] massValues = new String[] { tbRoadOrder_Name.Text, dtpRoadOrder_Date.Text, cbRoadOrder_Status.Text,
                        sIdRoadBrigade, sIdRoad};

                            //Вызов процедуры добавления значения в таблицу
                            if (bAddRecordInTable(massTableInfo, massValues) == true)
                            {
                                MessageBox.Show("Запись добавить не удалось!", "Ошибка!");
                            }
                        }
                        else
                        {
                            //Массив значений
                            String[] massValues = new String[] { sEditId, tbRoadOrder_Name.Text, dtpRoadOrder_Date.Text, cbRoadOrder_Status.Text,
                        sIdRoadBrigade, sIdRoad};

                            //Вызов процедуры редактирования значений в таблице
                            if (bEditRecordInTable(massTableInfo, massValues) == false)
                            {
                                tabPageRoadOrder.Text = "Сотрудники";
                                bFlagAddRecord = true;
                            }
                            else
                            {
                                MessageBox.Show("Запись изменить не удалось!", "Ошибка!");
                            }
                        }

                        //Прогрузка данных в таблицу
                        vLoadTable(tabControlRoadMain);
                    }
                    else
                    {
                        MessageBox.Show("Не все поля введены", "Ошибка!");
                    }
                }
            }            

            //Очищаем все предыдущие элементы
            listObj.Clear();
        }

        //Кнопка: очистка полей, отмена в одном ключе 100%
        private void bClear_Click(object sender, EventArgs e)
        {
            //Обьявляем лист объектов
            List<Object> listObj = new List<Object>();

            //Проверка первого таб контрола
            if (tabControlRoadMain.SelectedTab == tabPageRoadOwner)
            {               
                if (tabControlRoad.SelectedTab == tabPageTypeRoad)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbTypeRoad_TypeName);
                    //Изменяем название страницы
                    tabPageTypeRoad.Text = "Типы";
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadDirection)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadDirection_Direction); listObj.Add(tbRoadDirection_Distance);
                    //Изменяем название страницы
                    tabPageRoadDirection.Text = "Направления";
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadComposition)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadComposition_Composition);
                    //Изменяем название страницы
                    tabPageRoadComposition.Text = "Состав";
                }
                else if (tabControlRoad.SelectedTab == tabPageRoad)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoad_Name); listObj.Add(dtpRoad_OpenDate); listObj.Add(dtpRoad_CloseDate);
                    listObj.Add(cbRoad_fkTypeRoad); listObj.Add(cbRoad_fkRoadDirection); listObj.Add(cbRoad_fkComposition);

                    //Изменяем название страницы
                    tabPageRoad.Text = "Дороги";
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadStatus)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadStatus_Describe); listObj.Add(cbRoadStatus_Status); listObj.Add(cbRoadStatus_fkRoad);

                    //Изменяем название страницы
                    tabPageRoadStatus.Text = "Статус";
                }
            }
            //Проверка второго таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageEquipmentOwner)
            {
                if (tabControlEquipment.SelectedTab == tabPageEquipmentType)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbEquipmentType_typeName); listObj.Add(tbEquipmentType_Appoinment);

                    //Изменяем название страницы
                    tabPageEquipmentType.Text = "Типы";
                }
                else if (tabControlEquipment.SelectedTab == tabPageManufacturer)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbManufacturer_Name); listObj.Add(tbManufacturer_Country); listObj.Add(dtpManufacturer_CreateDate);

                    //Изменяем название страницы
                    tabPageManufacturer.Text = "Производитель";
                }
                else if (tabControlEquipment.SelectedTab == tabPageLocation)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbLocation_Location);

                    //Изменяем название страницы
                    tabPageLocation.Text = "Локация";
                }
                else if (tabControlEquipment.SelectedTab == tabPageDepartments)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbDepartments_Name); listObj.Add(tbDepartments_Adress); listObj.Add(cbDepartments_fkLocation);

                    //Изменяем название страницы
                    tabPageDepartments.Text = "Подразделения";
                }
                else if (tabControlEquipment.SelectedTab == tabPageEquipment)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbEquipment_Name); listObj.Add(cbEquipment_fkEqType); listObj.Add(cbEquipment_fkManufacturer);
                    listObj.Add(cbEquipment_fkLocation); listObj.Add(cbEquipment_fkDepartments);

                    //Изменяем название страницы
                    tabPageEquipment.Text = "Техника";
                }
            }
            //Проверка четвертого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageImportantPlacesOwner)
            {
                if (tabControlImportantPlaces.SelectedTab == tabPageTypeImportantPlaces)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbTypeImportantPlaces_TypeName); listObj.Add(cbTypeImportantPlaces_Priority);

                    //Изменяем название страницы
                    tabPageTypeImportantPlaces.Text = "Типы";
                }
                else if (tabControlImportantPlaces.SelectedTab == tabPageImportantPlaces)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbImportantPlaces_Name); listObj.Add(tbImportantPlaces_Describe); listObj.Add(cbImportantPlaces_fkRoad);
                    listObj.Add(cbImportantPlaces_fkTypeImpPlaces);

                    //Изменяем название страницы
                    tabPageImportantPlaces.Text = "Места";
                }
            }
            //Проверка третьего таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageWorkStaffOwner)
            {
                if (tabControlWorkStaff.SelectedTab == tabPageWorkStaff)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbWorkStaff_FIO); listObj.Add(tbWorkStaff_Position); listObj.Add(tbWorkStaff_Phone);
                    listObj.Add(tbWorkStaff_Address); listObj.Add(tbWorkStaff_Experience); listObj.Add(cbWorkStaff_fkDepartments);
                    listObj.Add(cbWorkStaff_fkRoadBrigade);

                    //Изменяем название страницы
                    tabPageWorkStaff.Text = "Сотрудники";
                }
                else if (tabControlWorkStaff.SelectedTab == tabPageRoadBrigade)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadBrigade_Name); listObj.Add(tbRoadBrigade_Describe);

                    //Изменяем название страницы
                    tabPageRoadBrigade.Text = "Бригады";
                }
            }
            //Проверка пятого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
            {
                if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadOrder_Name); listObj.Add(dtpRoadOrder_Date); listObj.Add(cbRoadOrder_Status);
                    listObj.Add(cbRoadOrder_fkRoadBrigade); listObj.Add(cbRoadOrder_fkRoad);

                    //Изменяем название страницы
                    tabPageRoadOrder.Text = "Заказы";
                }
            }

            //Ставим флаг добавления в режим добавления
            bFlagAddRecord = true;

            //Вызов процедуры очистки полей ввода
            vClearFields(listObj);

            //Очищаем все предыдущие элементы
            listObj.Clear();
        }

        //Происходит при смене вкладки, основной таб контрол 100%
        private void tabControlRoadMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(tabControlRoadMain.SelectedTab == tabPageRoadOwner)
            {
                //Прогрузка данных в таблицу
                vLoadTable(tabControlRoad);
            }
            else if(tabControlRoadMain.SelectedTab == tabPageEquipmentOwner)
            {
                //Прогрузка данных в таблицу
                vLoadTable(tabControlEquipment);
            }
            else if (tabControlRoadMain.SelectedTab == tabPageWorkStaffOwner)
            {
                //Прогрузка данных в таблицу
                vLoadTable(tabControlWorkStaff);
            }
            else if (tabControlRoadMain.SelectedTab == tabPageImportantPlacesOwner)
            {
                //Прогрузка данных в таблицу
                vLoadTable(tabControlImportantPlaces);
            }
            else if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
            {
                //Прогрузка данных в таблицу
                vLoadTable(tabControlRoadMain);
            }
        }

        //Происходит при смене вкладки, таб контрол "Дороги" 100%
        private void tabControlRoad_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Прогрузка данных в таблицу
            vLoadTable(tabControlRoad);
        }

        //Происходит при смене вкладки, таб контрол "Техника" 100%
        private void tabControlEquipment_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Прогрузка данных в таблицу
            vLoadTable(tabControlEquipment);
        }

        //Происходит при смене вкладки, таб контрол "Рабочий персонал" 100%
        private void tabControlWorkStaff_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Прогрузка данных в таблицу
            vLoadTable(tabControlWorkStaff);
        }

        //Происходит при смене вкладки, таб контрол "Важные места" 100%
        private void tabControlImportantPlaces_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Прогрузка данных в таблицу
            vLoadTable(tabControlImportantPlaces);
        }
        
        //Кнопка: перенос значений для редактирования на форму 100%
        private void bEdit_Click(object sender, EventArgs e)
        {
            //Обьявляем лист объектов
            List<Object> listObj = new List<Object>();

            //Проверка первого таб контрола
            if (tabControlRoadMain.SelectedTab == tabPageRoadOwner)
            {
                if (tabControlRoad.SelectedTab == tabPageTypeRoad)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbTypeRoad_TypeName);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM TYPE_ROAD", tabPageTypeRoad, "Типы(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadDirection)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadDirection_Direction); listObj.Add(tbRoadDirection_Distance);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM ROAD_DIRECTION", tabPageRoadDirection, "Направления(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadComposition)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadComposition_Composition);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM ROAD_COMPOSITION", tabPageRoadComposition, "Состав(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoad)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoad_Name); listObj.Add(dtpRoad_OpenDate); listObj.Add(dtpRoad_CloseDate);
                    listObj.Add(cbRoad_fkTypeRoad); listObj.Add(cbRoad_fkRoadDirection); listObj.Add(cbRoad_fkComposition);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM ROAD", tabPageRoad, "Дороги(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlRoad.SelectedTab == tabPageRoadStatus)
                {
                    //Заполняем лист объектов
                    listObj.Add(cbRoadStatus_Status); listObj.Add(tbRoadStatus_Describe); listObj.Add(cbRoadStatus_fkRoad);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM ROAD_STATUS", tabPageRoadStatus, "Статус(Редактирование)", dgvMain, listObj);
                }
            }
            //Проверка второго таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageEquipmentOwner)
            {
                if (tabControlEquipment.SelectedTab == tabPageEquipmentType)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbEquipmentType_typeName); listObj.Add(tbEquipmentType_Appoinment);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM EQUIPMENT_TYPE", tabPageEquipmentType, "Типы(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlEquipment.SelectedTab == tabPageManufacturer)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbManufacturer_Name); listObj.Add(tbManufacturer_Country); listObj.Add(dtpManufacturer_CreateDate);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM MANUFACTURER", tabPageManufacturer, "Производители(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlEquipment.SelectedTab == tabPageLocation)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbLocation_Location);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM LOCATION", tabPageLocation, "Локация(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlEquipment.SelectedTab == tabPageDepartments)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbDepartments_Name); listObj.Add(tbDepartments_Adress); listObj.Add(cbDepartments_fkLocation);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM DEPARTMENTS", tabPageDepartments, "Подразделения(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlEquipment.SelectedTab == tabPageEquipment)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbEquipment_Name); listObj.Add(cbEquipment_fkEqType); listObj.Add(cbEquipment_fkManufacturer);
                    listObj.Add(cbEquipment_fkLocation); listObj.Add(cbEquipment_fkDepartments);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM EQUIPMENT", tabPageEquipment, "Техника(Редактирование)", dgvMain, listObj);
                }
            }
            //Проверка четвертого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageImportantPlacesOwner)
            {
                if (tabControlImportantPlaces.SelectedTab == tabPageTypeImportantPlaces)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbTypeImportantPlaces_TypeName); listObj.Add(cbTypeImportantPlaces_Priority);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM TYPE_IMPORTANT_PLACES", tabPageTypeImportantPlaces, "Типы(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlImportantPlaces.SelectedTab == tabPageImportantPlaces)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbImportantPlaces_Name); listObj.Add(tbImportantPlaces_Describe); listObj.Add(cbImportantPlaces_fkRoad);
                    listObj.Add(cbImportantPlaces_fkTypeImpPlaces);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM IMPORTANT_PLACES", tabPageImportantPlaces, "Места(Редактирование)", dgvMain, listObj);
                }
            }
            //Проверка третьего таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageWorkStaffOwner)
            {
                if (tabControlWorkStaff.SelectedTab == tabPageWorkStaff)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbWorkStaff_FIO); listObj.Add(tbWorkStaff_Position); listObj.Add(tbWorkStaff_Phone);
                    listObj.Add(tbWorkStaff_Address); listObj.Add(tbWorkStaff_Experience); listObj.Add(cbWorkStaff_fkDepartments);
                    listObj.Add(cbWorkStaff_fkRoadBrigade);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM WORK_STAFF", tabPageWorkStaff, "Сотрудники(Редактирование)", dgvMain, listObj);
                }
                else if (tabControlWorkStaff.SelectedTab == tabPageRoadBrigade)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadBrigade_Name); listObj.Add(tbRoadBrigade_Describe);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM ROAD_BRIGADE", tabPageRoadBrigade, "Бригады(Редактирование)", dgvMain, listObj);
                }
            }
            //Проверка пятого таб контрола
            else if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
            {
                if (tabControlRoadMain.SelectedTab == tabPageRoadOrder)
                {
                    //Заполняем лист объектов
                    listObj.Add(tbRoadOrder_Name); listObj.Add(dtpRoadOrder_Date); listObj.Add(cbRoadOrder_Status);
                    listObj.Add(cbRoadOrder_fkRoadBrigade); listObj.Add(cbRoadOrder_fkRoad);

                    //Вызываем процедуру переноса значений из таблицы на форму
                    vMoveValueToForm("SELECT * FROM ROAD_ORDER", tabPageRoadOrder, "Заказы(Редактирование)", dgvMain, listObj);
                }
            }

            //Очищаем все предыдущие элементы
            listObj.Clear();
        }
    }
}