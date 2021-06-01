using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp23
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow main = new MainWindow();
        Window2 win2 = new Window2();

        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*  MainWindow main = new MainWindow();

              if (textBox_login.Text.Length > 0 && password.Password.Length > 0)

              {
                  MessageBox.Show("Вы успешно зашли");

                  main.Show();

              }
              else
              {
                  MessageBox.Show("Неправильно");

              }
              */
            if (textBox_login.Text.Length > 0) // проверяем введён ли логин
            {
                if (password.Password.Length > 0) // проверяем введён ли пароль
                {             // ищем в базе данных пользователя с такими данными
                    DataTable dt_user = main.Select("SELECT * FROM [dbo].[Vxodv] WHERE [login] = '" + textBox_login.Text + "' AND [password] = '" + password.Password + "'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует
                    {
                        main.Hide();
                        MainWindow menuWindow1 = new MainWindow();
                        menuWindow1.Show();

                    }
                    else MessageBox.Show("Пользователя не найден"); // выводим ошибку
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            win2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void b123_Click(object sender, RoutedEventArgs e)
        {
            CaptchBox.Text = null;
            ButNewCaptch.Content = "Новая\nкапча";
            String allowchar = "";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            String[] ar = allowchar.Split(a);
            String pwd = "";
            string temp = "";

            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }

            if (CapthGenBox.Text != "")
            {
                CapthGenBox.Text = null;
            }

            CapthGenBox.Text = pwd;

        }
    }
}

