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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var salarioBruto = decimal.Parse(baseSalary.Text);
            var res = 0m;
            var subsidioRef = 0m;
            var ajudaC = decimal.Parse(AjudaCustos.Text);
            if (renum.IsChecked == true)
            {
                subsidioRef = decimal.Parse(subAlim.Text);
                var diff = 0m;
                if (subsidioRef > 4.77m)
                {
                    diff = subsidioRef - 4.77m;
                }
                salarioBruto += (diff * 22);
                res += subsidioRef > 0 ? (4.77m * 22) : 0;

            }
            else if (carRef.IsChecked == true)
            {
                subsidioRef = decimal.Parse(subAlim.Text);
                res += (subsidioRef * 22);
            }
            var ttd = new TabelaTrabalhoDependente();
            var depend = int.Parse(dependentes.Text);
            var perc = ttd.PercetagemRetençaoNaFonte(salarioBruto, depend);
            var retencao = salarioBruto * ((perc) / 100);
            var ss = salarioBruto * (11m / 100);
            var salarioDescontado = salarioBruto - (int)retencao - ss;
            res += salarioDescontado + ajudaC;
            var toPrint = Math.Round(res, 2);
            var anual = (salarioDescontado * 14) + (subsidioRef * 22 * int.Parse(RefX.Text)) + (ajudaC * int.Parse(acX.Text));
            MessageBox.Show("Por mes: " + toPrint.ToString() + "€" + "\nPor ano: " + anual.ToString("") + "€");// valor mensal
        }
    }
}
