   M S B A M L   `   `   `  ����L  HFastDeliveryGroup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FastDeliveryGroup.Presentation.AdminForm(FastDeliveryGroup.Presentation.AdminForm  5      e aDe.TorstenMandelkow.MetroChart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d5b8d1bbc99c4a2awTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5      ?    9FastDeliveryGroup.Presentation.AdminForm.ReportManagement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:FastDeliveryGroup.Presentation.AdminForm     5      fchartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     5      $��828.571��5	   #   .��5
      � -   5        .+�5   
   �� -   5          ��Name$  btnOk��5      $��OK��6    $
��Left=�6-   $��
371,10,0,0q�6H   $	��Top=�6\   $��75��6t   6   �� 5   
   -   5         ��Name$ 	cbbChoice��5      $
��Left=�6&   $��
122,10,0,0q�6A   $	��Top=�6U   $	��120��6m   .@�5      ��  �� ContentStringFormat$  ��6   $��Revenue/Day��62   �� 5      $  ��6   $��Schedule/Month��62   �� 5      $  ��6   $��Shipper/Month��62   5      �� 5   
   -   5        $ cbbMonth��5      $
��Left=�6%   $��
264,10,0,0q�6@   $	��Top=�6T   $��35��6l   $y�Hidden=�6w   .@�5      �� $  ��6   $��1��62   �� 5      $  ��6   $��2��62   �� 5      $  ��6   $��3��62   �� 5      $  ��6   $��4��62   �� 5      $  ��6   $��5��62   �� 5      $  ��6   $��6��62   �� 5      $  ��6   $��7��62   �� 5      $  ��6   $��8��62   �� 5      $  ��6   $��9��62   �� 5      $  ��6   $��10��62   �� 5      $  ��6   $��11��62   �� 5      $  ��6   $��12��62   5      �� 5   
   -   5        $ cbbYear��5      $
��Left=�6$   $��
320,10,0,0q�6?   $	��Top=�6S   $��45��6k   $y�Hidden=�6v   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ dpDate��5!      $
��Left=�6%   $��	264,8,0,0q�6@   $	��Top=�6S   $y�Hidden=�6k   �� 5"   
   $
��Left=�6   $	��504��60   $��	10,86,0,0q�6=   $	��Top=�6P   $	��809��6h   .+�5#      9  3De.TorstenMandelkow.MetroChart.ClusteredColumnChart  -   5          Name$ cccMainChart��5#   )   .  (De.TorstenMandelkow.MetroChart.ChartBase   ChartSubTitle$  ��6?      
ChartTitle$ Schedule per month��6P   $y�Hidden=�6p   $	��516��6�      Series 5%      0  *De.TorstenMandelkow.MetroChart.ChartSeries  -   5          Name$ csMyChartSeries��5%   (   	   DisplayMember$
	 Name��6A   
   SeriesTitle$
  ��5'   $      ValueMember$ Count��5(   $   ��5&   (   ��  �� Path$ Charts�5(   $   5*      5+      �� 5,   
   $
��Left=�6   $	��516��60   $��	10,74,0,0q�6=   $	��Top=�6P   $	��780��6h   .+�5-      7  1De.TorstenMandelkow.MetroChart.StackedColumnChart  -	   5          Name$ sccMainChart��5-   '   $  ��6=   $ Revenue per day��6N   $y�Hidden=�6k   $	��516��6    5/        -
   5        $ csMyStackChartSeries��5/   (   $
	 Name��6F   $
  ��51   $   $ Count��52   $   ��50   (   �� $ Charts�52   $   54      55      58      59      