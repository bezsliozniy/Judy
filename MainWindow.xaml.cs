﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskManager{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, t) => { 
                tbox_currTime.Text = $"{DateTime.Now.Hour:00}:{DateTime.Now.Minute:00}:{DateTime.Now.Second:00}";
                tbox_currDate.Text = $"{DateTime.Now.DayOfWeek} | {DateTime.Now.Day:00}/{DateTime.Now.Month:00}/{DateTime.Now.Year}";
            };
            timer.Start();
        }

        private void btn_currTasks_Click(object sender, RoutedEventArgs e)
        {
            frame_cont.Navigate((new Uri("Manager.xaml", UriKind.Relative)));
        }

        private void btn_finTasks_Click(object sender, RoutedEventArgs e)
        {
            frame_cont.Navigate((new Uri("Done.xaml", UriKind.Relative)));

        }



        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void manipulation_bar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
