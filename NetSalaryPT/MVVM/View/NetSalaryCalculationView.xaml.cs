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

namespace NetSalaryPT.MVVM.View
{
    /// <summary>
    /// Interaction logic for NetSalaryCalculationView.xaml
    /// </summary>
    public partial class NetSalaryCalculationView : UserControl
    {
        const decimal FoodAllowanceMoneyValue = 4.77m;//valor que noa e sujeito a descontos no ordenado
        const decimal SocialSecurityDiscount = 11m;
        public NetSalaryCalculationView()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var gross_Salary = decimal.Parse(GrossSalary.Text);
            var food_Allowance = 0m;
            var help_allowance = decimal.Parse(HelpAllowance.Text);
            if (FoodMoney.IsChecked == true)
            {
                food_Allowance = decimal.Parse(FoodAllowance.Text);
                var difference = 0m;
                if (food_Allowance > FoodAllowanceMoneyValue)
                {
                    difference = food_Allowance - FoodAllowanceMoneyValue;
                    food_Allowance = FoodAllowanceMoneyValue;
                }
                gross_Salary += (difference * 22);

            }
            else if (FoodCard.IsChecked == true)
            {
                food_Allowance = decimal.Parse(FoodAllowance.Text);
            }
            var ttd = new TabelaTrabalhoDependente();
            var number_Of_Dependents = int.Parse(Dependents.Text);
            var irs_Percentage = ttd.PercetagemRetençaoNaFonte(gross_Salary, number_Of_Dependents);
            var irs_Discounted_Value = gross_Salary * ((irs_Percentage) / 100);
            var social_Security_Value = gross_Salary * (SocialSecurityDiscount / 100);
            results.Visibility= Visibility.Visible;
            var salary_Model = new SalaryComponentModel()
            {
                Gross_Salary = Math.Round(gross_Salary, 2),
                Irs_Discount = (int)irs_Discounted_Value,
                Irs_Discount_Percentage = irs_Percentage.Value,
                Ss_Discount = Math.Round(social_Security_Value, 2),
                Ss_Discount_Percentage = SocialSecurityDiscount,
                Help_Allowance = Math.Round(help_allowance, 2),
                Food_Allowance = Math.Round(food_Allowance * 22, 2)
            };
            AnualTable.ItemsSource = LoadTableData(salary_Model);
            grossSalary.Text = GrossSalary.Text + "€";
            irsPercentage.Text = salary_Model.Irs_Discount_Percentage.ToString() + "%";
            socialSecurityPercentage.Text = salary_Model.Ss_Discount_Percentage.ToString() + "%";
            irs.Text = salary_Model.Irs_Discount.ToString() + "€";
            socialSecurity.Text = salary_Model.Ss_Discount.ToString() + "€";
            foodAllowance.Text = salary_Model.Food_Allowance.ToString() + "€";
            helpAllowance.Text = salary_Model.Help_Allowance.ToString() + "€";
            var net_Salary = salary_Model.Gross_Salary - salary_Model.Irs_Discount - salary_Model.Ss_Discount;
            NetSalary.Text = net_Salary.ToString() + "€";
        }

        public decimal GetGrossSalaryFromNet(decimal netSalary, decimal current, bool first = true)
        {
            var grossSalary = first ? current * 1.5m : current;
            var net = GetNetSalary(grossSalary);
            if (net <= netSalary + 10 && net >= netSalary - 10)
            {
                return Math.Round(grossSalary, 2);
            }
            else if (net <= netSalary)
            {
                grossSalary = Math.Round(grossSalary * 1.1m, 2);
                return GetGrossSalaryFromNet(netSalary, grossSalary, false);
            }
            else if (net >= netSalary)
            {
                grossSalary = Math.Round(grossSalary * 0.9m, 2);
                return GetGrossSalaryFromNet(netSalary, grossSalary, false);
            }
            return net;
        }
        private decimal GetNetSalary(decimal grossSalary)
        {
            var ttd = new TabelaTrabalhoDependente();
            var number_Of_Dependents = 0;//int.Parse(Dependents.Text);
            var irs_Percentage = ttd.PercetagemRetençaoNaFonte(grossSalary, number_Of_Dependents);
            var irs_Discounted_Value = grossSalary * ((irs_Percentage) / 100);
            var social_Security_Value = grossSalary * (SocialSecurityDiscount / 100);
            return grossSalary - (irs_Discounted_Value.HasValue ? irs_Discounted_Value.Value : 0) - social_Security_Value;
        }
        public List<ResultTableData> LoadTableData(SalaryComponentModel salary_Model)
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
