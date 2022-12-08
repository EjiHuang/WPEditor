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

namespace WPEditor.Ext
{
    public class MapHelper
    {
        /// <summary>
        /// 天地图卫星影像瓦片
        /// </summary>
        public static TileLayer TianDiTuAerialTileLayer
            = new(
                new HttpTileSource(
                    tileSchema: new GlobalSphericalMercator(1, 18),
                    urlFormatter: "https://t{s}.tianditu.gov.cn/img_w/wmts?SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0&LAYER=img&STYLE=default&TILEMATRIXSET=w&FORMAT=tiles&TILECOL={x}&TILEROW={y}&TILEMATRIX={z}&tk={k}",
                    serverNodes: new string[8] { "0", "1", "2", "3", "4", "5", "6", "7" },
                    apiKey: "",
                    name: "TianDiTu",
                    persistentCache: null,
                    tileFetcher: null,
                    attribution: new Attribution("© 自然资源部 & NavInfo"),
                    userAgent: null),
                dataFetchStrategy: new DataFetchStrategy());

        /// <summary>
        /// 天地图标签瓦片
        /// </summary>
        public static TileLayer TianDiTuVectorMarks_zh_CN
            = new(
                new HttpTileSource(
                    tileSchema: new GlobalSphericalMercator(1, 18),
                    urlFormatter: "http://t{s}.tianditu.gov.cn/cva_w/wmts?SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0&LAYER=cva&STYLE=default&TILEMATRIXSET=w&FORMAT=tiles&TILECOL={x}&TILEROW={y}&TILEMATRIX={z}&tk={k}",
                    serverNodes: new string[8] { "0", "1", "2", "3", "4", "5", "6", "7" },
                    apiKey: "",
                    name: "TianDiTu",
                    persistentCache: null,
                    tileFetcher: null,
                    attribution: new Attribution("© 自然资源部 & NavInfo"),
                    userAgent: null),
                dataFetchStrategy: new DataFetchStrategy());
    }
}
