   M S B A M L   `   `   `  ����|  xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   	    Project#   Project.Presentation.GraphDay   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	     � Title$  GraphDay��5   	   $��705.2��6   $��1000.985��6)   .��5      �� $
��Auto=�6   $
��Auto=�5      $��0,-28,0.4,0q�6*   ��5   
   �� 5	       �� ImageSource$. (/Project;component/Image/wallpaper02.jpg��6   .��5   
   � $	��658��6   $
��1013��6   .+�5      � $
��1400��6   $��-10,54,10,-54q�6!   .+�5      >   8System.Windows.Controls.DataVisualization.Charting.Chart  -   5        $��ColumnChart1��5   #   $	��420��5   (   $
��Left=�65   $��95,-56,0,936q�5         Title$ ReportOfMonth��67   $��Bottom=�5      $	��800��6(      LegendTitle$  ��64      Series. 5      E   ?System.Windows.Controls.DataVisualization.Charting.ColumnSeries  ?   9System.Windows.Controls.DataVisualization.Charting.Series   Title$ Magin��63   H   BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   DependentValuePath$ Value��6A      IndependentValuePath$	 Key��6]      IsSelectionEnabled . 	   ItemsSource	 6x   �� 5   )   5      (  "System.Windows.Controls.DatePicker  5      -   5        $��	dpDateEnd��5      $
��Left=�6.   $��425,485,0,0q�6I   $	��Top=�6^   �� 5      $
��Left=�6   $��122,485,0,0q�63   $	��Top=�6H   .��5      �� $��	DateStart��6   5      �� 5      $��DateEnd��6   $
��Left=�6*   $��327,484,0,0q�6E   $	��Top=�6Z   �� 5      -   5        $��btnView��5      $
��View��6(   $
��Left=�67   $��588,488,0,0q�6R   $	��Top=�6g   $��75��6   ���	#FF005FFF��5      �� 5      
 �� EndPoint$
 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5      �  � Color$ 	#FF00F1FF��6+    � Offset$ 0Q�6=   � 5      $ White��6+   $ 1Q�69   5      5      �� 5       $2��,Please choose year's months you want to show��6   $
��Left=�6O   $��154,526,0,0q�6j   $	��Top=�6   �� 5!      -   5        $��btnReportMonths��5!      $��View Report's months��60   $
��Left=�6O   $��588,526,0,0q�6j   $	��Top=�6   $	��126��6�   ���	#FF005FFF��5"      �� 5#      $
 0.5,1&�6.   $ 0.5,0&�6?   .��5$      � $ 	#FF00F1FF��6+   $ 0Q�6=   � 5%      $ White��6+   $ 1Q�69   5&      5(      �� 5)      -   5        $��btnReportYear��5)      $��View Report's Years��6.   $
��Left=�6L   $��754,527,0,0q�6g   $	��Top=�6|   $	��114��6�   ���	#FF005FFF��5*      �� 5+      $
 0.5,1&�6.   $ 0.5,0&�6?   .��5,      � $ 	#FF00F1FF��6+   $ 0Q�6=   � 5-      $ White��6+   $ 1Q�69   5.      50      52        53      -   5        $��dpDateStart��53      $
��Left=�6,   $��190,537,0,0q�6G   $	��Top=�6\     54      -   5        $��dpYearChoose��54      $
��Left=�6-   $��415,580,0,0q�6H   $	��Top=�6]   �� 55      -   5         ��Name$ button��55      $��Back to Mainwindow��6%   $
��Left=�6B   $	��Top=�6]   $��75��6u   $��442,629,0,0q�6�   ���	#FF005FFF��56      �� 57      $
 0.5,1&�6*   $ 0.5,0&�6;   .��58      � $ 	#FF00F1FF��6'   $ 0Q�69   � 59      $ White��6'   $ 1Q�65   5:      5<      5=      5>      5?      