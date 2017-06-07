using System;
using System.IO;
using System.Windows.Forms;

namespace RoadProject
{
    public partial class Settings : Form
    {
        public MSSQLConnector conSQL;
        public Settings(MSSQLConnector conSQL)
        {
            InitializeComponent();
            this.conSQL = conSQL;
        }

        //Кнопка: создание подключения к базе данных
        private void bAddConnection_Click(object sender, EventArgs e)
        {
            if (tbDatabase.Text.Equals("") || (tbServer.Text.Equals("")))
            {
                MessageBox.Show("Вы не ввели все данные!", "Предупреждение!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sConnectionString;
                sConnectionString = "Database=" + tbDatabase.Text + ";Server=" + tbServer.Text +
                    ";Trusted_Connection=True;MultipleActiveResultSets=True";

                StreamWriter writer = new StreamWriter(@"Data\ConnMicrosoftSQLServer.cfg");
                writer.WriteLine(sConnectionString);
                writer.Close();
                writer.Dispose();
                MessageBox.Show("Данные были сохранены!", "Созданно!");
                SplashScrean SplashScreen = new SplashScrean(conSQL);
                SplashScreen.Show();
                this.Close();
            }
        }

        //Кнопка: отмена действий
        private void bCancel_Click(object sender, EventArgs e)
        {
            SplashScrean SplashScreen = new SplashScrean(conSQL);
            SplashScreen.Show();
            this.Close();
        }

        //Кнопка: возврат на главную форму 100%
        private void bReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main(conSQL);
            main.Show();
        }
    }
}