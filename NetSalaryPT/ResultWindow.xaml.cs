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
using System.Windows.Shapes;

namespace NetSalaryPT
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        private SalaryComponentModel salary_Model;
        public ResultWindow(SalaryComponentModel data)
        {
            InitializeComponent();
            salary_Model = data;
            AnualTable.ItemsSource = LoadTableData();
            grossSalary.Text = data.Gross_Salary.ToString() + "€";
            irs.Text = data.Irs_Discount.ToString() + "€";
            socialSecurity.Text = data.Ss_Discount.ToString() + "€";
            helpAllowance.Text = data.Help_Allowance.ToString() + "€";
            foodAllowance.Text = data.Food_Allowance.ToString() + "€";
            irsPercentage.Text = data.Irs_Discount_Percentage.ToString() + "%";
            socialSecurityPercentage.Text = data.Ss_Discount_Percentage.ToString() + "%";

        }
        public List<ResultTableData> LoadTableData()
        {
            var salarioLiquido = salary_Model.Gross_Salary - salary_Model.Irs_Discount - salary_Model.Ss_Discount;
            List<ResultTableData> data = new List<ResultTableData>();
            data.Add(new ResultTableData()
            {
                Info = "Salario Liquido",
                Janeiro = salarioLiquido,
                Fevereiro = salarioLiquido,
                Março = salarioLiquido,
                Abril = salarioLiquido,
                Maio = salarioLiquido,
                Junho = salarioLiquido * 2,
                Julho = salarioLiquido,
                Agosto = salarioLiquido,
                Setembro = salarioLiquido,
                Outubro = salarioLiquido,
                Novembro = salarioLiquido,
                Dezembro = salarioLiquido * 2,
                Total = salarioLiquido * 14
            });
            data.Add(new ResultTableData()
            {
                Info = "Subsidio Alimentaçao",
                Janeiro = salary_Model.Food_Allowance,
                Fevereiro = salary_Model.Food_Allowance,
                Março = salary_Model.Food_Allowance,
                Abril = salary_Model.Food_Allowance,
                Maio = salary_Model.Food_Allowance,
                Junho = salary_Model.Food_Allowance,
                Julho = salary_Model.Food_Allowance,
                Agosto = salary_Model.Food_Allowance,
                Setembro = salary_Model.Food_Allowance,
                Outubro = salary_Model.Food_Allowance,
                Novembro = salary_Model.Food_Allowance,
                Total = salary_Model.Food_Allowance * 11
            });
            data.Add(new ResultTableData()
            {
                Info = "Ajudas de Custos",
                Janeiro = salary_Model.Help_Allowance,
                Fevereiro = salary_Model.Help_Allowance,
                Março = salary_Model.Help_Allowance,
                Abril = salary_Model.Help_Allowance,
                Maio = salary_Model.Help_Allowance,
                Junho = salary_Model.Help_Allowance,
                Julho = salary_Model.Help_Allowance,
                Agosto = salary_Model.Help_Allowance,
                Setembro = salary_Model.Help_Allowance,
                Outubro = salary_Model.Help_Allowance,
                Novembro = salary_Model.Help_Allowance,
                Total = salary_Model.Help_Allowance * 11
            });
            var aux = new ResultTableData();
            foreach (var d in data)
            {
                aux.Info = "Total";
                aux.Janeiro += d.Janeiro;
                aux.Fevereiro += d.Fevereiro;
                aux.Março += d.Março;
                aux.Abril += d.Abril;
                aux.Maio += d.Maio;
                aux.Junho += d.Junho;
                aux.Julho += d.Julho;
                aux.Agosto += d.Agosto;
                aux.Setembro += d.Setembro;
                aux.Outubro += d.Outubro;
                aux.Novembro += d.Novembro;
                aux.Dezembro += d.Dezembro;
                aux.Total += d.Total;
            }
            data.Add(aux);
            return data;
        }
    }
}
