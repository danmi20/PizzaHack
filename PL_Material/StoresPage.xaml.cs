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
using DS;

namespace PL_Material
{
    /// <summary>
    /// Interaction logic for StoresPage.xaml
    /// </summary>
    public partial class StoresPage : Page
    {
        public StoresPage()
        {
            InitializeComponent();
            this.storesDataGrid.ItemsSource = DataSource.stores;
        }
    }
}
