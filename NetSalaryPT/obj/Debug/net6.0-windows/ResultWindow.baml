   M S B A M L   `   `   `  ����F  BNetSalaryPT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NetSalaryPTNetSalaryPT  5   	       NetSalaryPT.ResultWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:NetSalaryPT     5   	     � Title$  ResultWindow��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� $
��Left=�6   $��	13,12,0,0q�6/   $
��Wrap=�6B   $��Salario Base:��6V   $	��Top=�6k   �� 5   
   -   5        $��grossSalary��5      $
��Left=�6'   $��
108,13,0,0q�6B   $
��Wrap=�6V   $��0��6j   $	��Top=�6s   �� 5   
   $
��Left=�6   $��	16,31,0,0q�6/   $
��Wrap=�6B   $��IRS(%)��6V   $	��Top=�6d   �� 5   
   -   5        $��irsPercentage��5      $
��Left=�6)   $��
127,32,0,0q�6D   $
��Wrap=�6X   $��0��6l   $	��Top=�6u   �� 5   
   $
��Left=�6   $��	14,54,0,0q�6/   $
��Wrap=�6B   $��Segurança Social(%)��6V   $	��Top=�6q   �� 5   
   -   5        $��socialSecurityPercentage��5      $
��Left=�64   $��
141,54,0,0q�6O   $
��Wrap=�6c   $��0��6w   $	��Top=�6�   �� 5   
   $
��Left=�6   $��	16,78,0,0q�6/   $
��Wrap=�6B   $	��IRS��6V   $	��Top=�6a   �� 5   
   -   5        $	��irs��5      $
��Left=�6   $��
144,76,0,0q�6:   $
��Wrap=�6N   $��0��6b   $	��Top=�6k   �� 5   
   $
��Left=�6   $��	19,99,0,0q�6/   $
��Wrap=�6B   $��Segurança Social��6V   $	��Top=�6n   �� 5   
   -   5        $��socialSecurity��5      $
��Left=�6*   $��150,100,0,0q�6E   $
��Wrap=�6Z   $��0��6n   $	��Top=�6w   �� 5   
   $
��Left=�6   $��
16,123,0,0q�6/   $
��Wrap=�6C   $��Subsidio Alimentaçao��6W   $	��Top=�6s   �� 5   
   -   5        $��foodAllowance��5      $
��Left=�6)   $��155,123,0,0q�6D   $
��Wrap=�6Y   $��0��6m   $	��Top=�6v   �� 5   
   $
��Left=�6   $��
18,143,0,0q�6/   $
��Wrap=�6C   $��Ajudas de Custos��6W   $	��Top=�6o   �� 5   
   -   5        $��helpAllowance��5      $
��Left=�6)   $��162,146,0,0q�6D   $
��Wrap=�6Y   $��0��6m   $	��Top=�6v   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
AnualTable��5   �   $	��200��6   $	��500��6    $
��Left=�6,   $	��Top=�6G      	RowHeight$ 30Q�6_      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6n   $��
18,189,0,0q�6�   6�   5      5      