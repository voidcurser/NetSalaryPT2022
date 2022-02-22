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

namespace NetSalaryPT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const decimal FoodAllowanceMoneyValue = 4.77m;//valor que noa e sujeito a descontos no ordenado
        const decimal SocialSecurityDiscount = 11m;
        public MainWindow()
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
            var salary_Model = new SalaryComponentModel()
            {
                Gross_Salary = Math.Round(gross_Salary, 2),
                Irs_Discount = (int)irs_Discounted_Value,
                Irs_Discount_Percentage = irs_Percentage.Value,
                Ss_Discount = Math.Round(social_Security_Value,2),
                Ss_Discount_Percentage = SocialSecurityDiscount,
                Help_Allowance = Math.Round(help_allowance, 2),
                Food_Allowance = Math.Round(food_Allowance * 22, 2)
            };
            var win = new ResultWindow(salary_Model);
            win.Show();
        }
    }
}
