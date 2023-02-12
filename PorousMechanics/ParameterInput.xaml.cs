using System;
using System.Collections.Generic;
using System.Data;
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

namespace PorousMechanics
{
    /// <summary>
    /// Interaction logic for ParameterInput.xaml
    /// </summary>
    /// 


    public enum keyOpening { 一开, 二开, 三开, 四开, 五开 };
    public enum keyCasingType { 表层套管, 技术套管, 生产套管 };

    public enum keyFluid { 领浆, 尾浆};


    public partial class ParameterInput : UserControl
    {


        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        public ParameterInput()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {



            //井身结构
            dt1.Columns.Add("Opening", typeof(Enum));
            dt1.Columns.Add("DrillSize", typeof(double));
            dt1.Columns.Add("WEnlarge", typeof(double));
            dt1.Columns.Add("CasingType", typeof(Enum));
            dt1.Columns.Add("Outerdm", typeof(double));
            dt1.Columns.Add("Wthickness", typeof(double));
            dt1.Columns.Add("TDepth", typeof(double));
            dt1.Columns.Add("BDepth", typeof(double));
            dt1.Columns.Add("WAngle", typeof(double));
            dt1.Columns.Add("CHeight", typeof(double));


            DataRow row = dt1.NewRow();
            row["Opening"] = keyOpening.二开;
            row["DrillSize"] = 171.4;
            row["WEnlarge"] = 5;
            row["CasingType"] = keyCasingType.技术套管;
            row["Outerdm"] = 139.7;
            row["Wthickness"] = 14.27;
            row["TDepth"] = 0;
            row["BDepth"] = 7280;
            row["WAngle"] = 0;
            row["CHeight"] = 0;
            dt1.Rows.Add(row);


            dataGrid1.ItemsSource = dt1.DefaultView;
            dataGrid1.GridLinesVisibility = DataGridGridLinesVisibility.All;


            //材料参数
            dt2.Columns.Add("Materials", typeof(string));
            dt2.Columns.Add("PoissonRatio", typeof(double));
            dt2.Columns.Add("ElasticModulus", typeof(double));
            dt2.Columns.Add("ThermalConductivity", typeof(double));
            dt2.Columns.Add("ExpensionCoefficient", typeof(double));
            dt2.Columns.Add("ExpensionQuotient", typeof(double));


            DataRow row1 = dt2.NewRow();
            row1["Materials"] = "表层套管";
            row1["PoissonRatio"] = 0.30;
            row1["ElasticModulus"] = 210000.00;
            row1["ThermalConductivity"] = 50.00;
            row1["ExpensionCoefficient"] = 11.59;
            row1["ExpensionQuotient"] = 0.00;
            dt2.Rows.Add(row1);


            row1 = dt2.NewRow();
            row1["Materials"] = "水泥环1";
            row1["PoissonRatio"] = 0.21;
            row1["ElasticModulus"] = 10000.00;
            row1["ThermalConductivity"] = 0.58;
            row1["ExpensionCoefficient"] = 10.00;
            row1["ExpensionQuotient"] = 0.00;
            dt2.Rows.Add(row1);


            row1 = dt2.NewRow();
            row1["Materials"] = "技术套管";
            row1["PoissonRatio"] = 0.30;
            row1["ElasticModulus"] = 210000.00;
            row1["ThermalConductivity"] = 50.00;
            row1["ExpensionCoefficient"] = 11.59;
            row1["ExpensionQuotient"] = 0.00;
            dt2.Rows.Add(row1);


            row1 = dt2.NewRow();
            row1["Materials"] = "水泥环2";
            row1["PoissonRatio"] = 0.21;
            row1["ElasticModulus"] = 10000.00;
            row1["ThermalConductivity"] = 0.58;
            row1["ExpensionCoefficient"] = 10.00;
            row1["ExpensionQuotient"] = 0.00;
            dt2.Rows.Add(row1);


            row1 = dt2.NewRow();
            row1["Materials"] = "技术尾管";
            row1["PoissonRatio"] = 0.30;
            row1["ElasticModulus"] = 210000.00;
            row1["ThermalConductivity"] = 50.00;
            row1["ExpensionCoefficient"] = 11.59;
            row1["ExpensionQuotient"] = 0.00;
            dt2.Rows.Add(row1);



            row1 = dt2.NewRow();
            row1["Materials"] = "水泥环3";
            row1["PoissonRatio"] = 0.21;
            row1["ElasticModulus"] = 10000.00;
            row1["ThermalConductivity"] = 0.58;
            row1["ExpensionCoefficient"] = 10.00;
            row1["ExpensionQuotient"] = 0.00;
            dt2.Rows.Add(row1);


            row1 = dt2.NewRow();
            row1["Materials"] = "岩石";
            row1["PoissonRatio"] = 0.30;
            row1["ElasticModulus"] = 20000.00;
            row1["ThermalConductivity"] = 2.00;
            row1["ExpensionCoefficient"] = 7.00;
            row1["ExpensionQuotient"] = 0.00;
            dt2.Rows.Add(row1);


            dataGrid2.ItemsSource = dt2.DefaultView;
            dataGrid2.GridLinesVisibility = DataGridGridLinesVisibility.All;



            //浆体与底层压力
            dt3.Columns.Add("CasingType", typeof(Enum)); // 套管层次
            dt3.Columns.Add("QianzhiyeMidu", typeof(double)); // 前置液密度
            dt3.Columns.Add("YalieyeMidu", typeof(double)); // 压裂液密度
            dt3.Columns.Add("ZuanjingyeMidu", typeof(double)); // 钻井液密度
            dt3.Columns.Add("liuti", typeof(Enum)); // 流体
            dt3.Columns.Add("midu", typeof(double)); // 密度
            dt3.Columns.Add("fanshen", typeof(double)); // 返深
            dt3.Columns.Add("YalieqianDicengyalitidu", typeof(double)); // 压裂前地层压力梯度
            dt3.Columns.Add("YaliehouDicengyalitidu", typeof(double)); // 压裂后地层压力梯度


            DataRow row2 = dt3.NewRow();
            row2["CasingType"] = keyCasingType.表层套管;
            row2["QianzhiyeMidu"] = 1.00;
            row2["YalieyeMidu"] = 1.03;
            row2["ZuanjingyeMidu"] = 1.00;
            row2["liuti"] = keyFluid.领浆;
            row2["midu"] = 1.45;
            row2["fanshen"] = 0.00;
            row2["YalieqianDicengyalitidu"] = 0.92;
            row2["YaliehouDicengyalitidu"] = 0.92;
            dt3.Rows.Add(row2);

            dataGrid3.ItemsSource = dt3.DefaultView;
            dataGrid3.GridLinesVisibility = DataGridGridLinesVisibility.All;



        }

        private void dataGrid2_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }




        public void Insert_Grid2_Row(object sender, RoutedEventArgs e)
        {
            int _rowIndex = 0;
            int _columnIndex = 0;
            if (GetGrid2CellXY(ref _rowIndex, ref _columnIndex))
            {
                dt2.Rows.InsertAt(dt2.NewRow(), _rowIndex);
            }
        }


        //---删除选中Cell所在行
        public void Delete_Grid2_Row(object sender, RoutedEventArgs e)
        {
            int _rowIndex = 0;
            int _columnIndex = 0;
            if (GetGrid2CellXY(ref _rowIndex, ref _columnIndex))
            {
                dt2.Rows.RemoveAt(_rowIndex);
            }
        }


        public void Insert_Grid3_Row(object sender, RoutedEventArgs e)
        {
            int _rowIndex = 0;
            int _columnIndex = 0;
            if (GetGrid3CellXY(ref _rowIndex, ref _columnIndex))
            {
                dt3.Rows.InsertAt(dt3.NewRow(), _rowIndex);
            }
        }


        //---删除选中Cell所在行
        public void Delete_Grid3_Row(object sender, RoutedEventArgs e)
        {
            int _rowIndex = 0;
            int _columnIndex = 0;
            if (GetGrid3CellXY(ref _rowIndex, ref _columnIndex))
            {
                dt3.Rows.RemoveAt(_rowIndex);
            }
        }



        //----取得选中Cell所在的行列
        public bool GetGrid2CellXY(ref int rowIndex, ref int columnIndex)
        {
            var _cells = dataGrid2.SelectedCells;
            if (_cells.Any())
            {
                rowIndex = dataGrid2.Items.IndexOf(_cells.First().Item);
                columnIndex = _cells.First().Column.DisplayIndex;
                return true;
            }
            return false;
        }


        public bool GetGrid3CellXY(ref int rowIndex, ref int columnIndex)
        {
            var _cells = dataGrid3.SelectedCells;
            if (_cells.Any())
            {
                rowIndex = dataGrid3.Items.IndexOf(_cells.First().Item);
                columnIndex = _cells.First().Column.DisplayIndex;
                return true;
            }
            return false;
        }



    }
}
