using BruTile;
using BruTile.Predefined;
using BruTile.Web;
using DevExpress.Mvvm;
using Mapsui;
using Mapsui.Fetcher;
using Mapsui.Layers;
using Mapsui.Styles;
using Mapsui.UI.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapsui.UI;
using Mapsui.Geometries;
using WPEditor.Ext;

namespace WPEditor.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MapControl CurrentMap { get; internal set; }
        private static readonly Attribution TianDiTuAttribution = new("© 自然资源部 & NavInfo", "https://www.tianditu.gov.cn/");

        protected override void OnInitializeInRuntime()
        {

        }

        public void InitializeMapControl(MapControl mapControl)
        {
            CurrentMap = mapControl;
            CurrentMap.Map = new Map();
            CurrentMap.Map.Layers.Add(MapHelper.TianDiTuAerialTileLayer, MapHelper.TianDiTuVectorMarks_zh_CN);

            CurrentMap.Map.Home = n => n.NavigateTo(new Point(1059114.80157058, 5179580.75916194), CurrentMap.Map.Resolutions[14]);
            CurrentMap.Map.BackColor = Color.FromString("#000613");
        }
    }
}
