using Mapsui.Layers;
using Mapsui.Logging;
using Mapsui.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPEditor.View
{
    public partial class MainView : Window
    {
        private WritableLayer? _targetLayer;

        public MainView()
        {
            InitializeComponent();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Logger.LogDelegate += MapLogMethod;

            MainVM.InitializeMapControl(MapControl);
        }

        private void MapControl_MouseMove(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// 地图Log
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <param name="arg3"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void MapLogMethod(LogLevel arg1, string arg2, Exception arg3)
        {
            Debug.WriteLine($"{arg1.ToString()}: {arg2}.");

            if (arg3 != null)
            {
                Debug.WriteLine($"Exception: {arg3.ToString()}");
            }
        }
    }
}
