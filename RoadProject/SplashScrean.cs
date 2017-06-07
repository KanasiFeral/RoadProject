using System;
using System.IO;
using System.Windows.Forms;

namespace RoadProject
{
    public partial class SplashScrean : Form
    {
        public MSSQLConnector conSQL;
        public SplashScrean(MSSQLConnector conSQL)
        {
            InitializeComponent();
            this.conSQL = conSQL;
        }

        //Загрузка формы
        private void SplashScrean_Load(object sender, EventArgs e)
        {
            labelConn.Text = "Проверка подключения...";
            timerRoad.Interval = 1000;
            timerRoad.Start();
        }

        //Действия таймера
        private void timerRoad_Tick(object sender, EventArgs e)
        {
            //Если существует файл настроек подключения
            if (File.Exists(@"Data\ConnMicrosoftSQLServer.cfg"))
            {
                Main main = new Main(conSQL);
                StreamReader sreader = new StreamReader(@"Data\ConnMicrosoftSQLServer.cfg");

                //читаем шифрованные данные о подключении в переменную 
                string ConnectionString = sreader.ReadLine(); 

                sreader.Close();
                sreader.Dispose();
                //Если возврат true
                if (conSQL.bConnection(ConnectionString) == true)
                {
                    timerRoad.Stop();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    labelConn.Text = "Ошибка подключения...";
                    timerRoad.Stop();
                    if (MessageBox.Show("Не удалось подключиться к базе данных, сервер выключен или неправильно указаны данные соединения.\nНастроить подключение?",
                        "Ошибка", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Settings Stngs = new Settings(conSQL);
                        Stngs.Show();
                        //Return to Main
                        Stngs.bReturnToMain.Enabled = false;
                        //Cancel
                        Stngs.bCancel.Enabled = true;
                        this.Hide();
                    }
                    else
                    {
                        Application.Exit();
                        conSQL.bCloseConnection();
                    }
                }
            }
            else
            {
                StreamWriter wreader = new StreamWriter(@"Data\ConnMicrosoftSQLServer.cfg");
                wreader.Close();
            }
        }
    }
}