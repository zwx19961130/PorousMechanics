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


    public enum KeyOpening { 一开, 二开, 三开, 四开, 五开 };
    public enum KeyCasingType { 表层套管, 技术套管, 生产套管 };


    public partial class ParameterInput : UserControl
    {


        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();


        public ParameterInput()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {








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
            



        }

        private void dataGrid2_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
    }
}
