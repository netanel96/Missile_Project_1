﻿using Missile_Project.Models;
using System;
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

namespace Missile_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetGeoCoordinate();
        }
        private async void GetGeoCoordinate()
        {
           var Coordinate = await ViewModels.GeoCoordinateApi.GetGeoCoordinateAsync("IL_Jerusalem_Havad_haleumi");
            double let = Coordinate.results[0].geometry.location.lat;
            double lng = Coordinate.results[0].geometry.location.lng;
            
        }
    }
}
