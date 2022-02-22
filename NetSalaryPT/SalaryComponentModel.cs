using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSalaryPT
{
    // depois posso por a fazer donwload de um excel com tabela a mostrar
    public class SalaryComponentModel
    {
        public decimal Gross_Salary { get; set; }
        public decimal Irs_Discount { get; set; }
        public decimal Ss_Discount { get; set; }
        public decimal Help_Allowance { get; set; }
        public decimal Food_Allowance { get; set; }
        public decimal Irs_Discount_Percentage { get; set; }
        public decimal Ss_Discount_Percentage { get; set; }
    }
}
