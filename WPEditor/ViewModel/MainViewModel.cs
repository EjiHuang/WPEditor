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

            HttpTileSource source = new(
                tileSchema: new GlobalSphericalMercator(0, 18),
                urlFormatter: "http://t{s}.tianditu.gov.cn/img_w/wmts?SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0&LAYER=img&STYLE=default&TILEMATRIXSET=w&FORMAT=tiles&TILEMATRIX={z}&TILEROW={x}&TILECOL={y}&tk={k}",
                serverNodes: new string[8] { "0", "1", "2", "3", "4", "5", "6", "7" },
                apiKey: "8326d0888fac6bc26279108edd086c38",
                name: "TianDiTu",
                persistentCache: null,
                tileFetcher: null,
                attribution: TianDiTuAttribution,
                userAgent: null);
            TileLayer TianDiTuTileLayer = new(source, dataFetchStrategy: new DataFetchStrategy());

            CurrentMap.Map.Layers.Add(TianDiTuTileLayer);
            CurrentMap.Map.Home = n => n.NavigateTo(new MPoint(1059114.80157058, 5179580.75916194), CurrentMap.Map.Resolutions[14]);
            CurrentMap.Map.BackColor = Color.FromString("#000613");

        }
    }
}
