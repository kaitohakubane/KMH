   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Project.PresentationProject.Presentation  5   	   &     Project.Presentation.BillDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Project.Presentation     5   	     � Title$  BillDetails��5   	   $��414.237��6   $��470.275��6.    � 
ResizeMode$ NoResize=�6>    � WindowStartupLocation$ CenterScreen=�6T   .��5	      � ��5
   
   �� 5       �� ImageSource$. (/Project;component/Image/wallpaper02.jpg��6   .+�5   
   �� -   5         ��Name$ 
txtProName��5      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��188��6y   $��
132,58,0,0q�6�   �� 5   
   -   5        $ txtProID��5      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $	��Top=�6_   $	��188��6w   $��
132,29,0,0q�6�   �� 5   
   -   5         ��Name$ label��5      $
��Left=�6   $	��Top=�6:   $��	19,27,0,0q�6R   $��
Product ID��6e   �� 5   
   -   5        $ 
label_Copy��5      $��Product Name��6$   $
��Left=�6;   $	��Top=�6V   $��	19,58,0,0q�6n   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$	 dgv��5      $
��Left=�6    $	��Top=�6;   $	��265��6S   $	��464��6`   $��0,120,0,-0.2q�6l   6�   �� 5   
   -   5         ��Name$ btnAdd��5      $��Add to bill��6!   $
��Left=�67   $	��Top=�6R   $��75��6j   $��
353,62,0,0q�6u   6�   �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��
353,34,0,0q�6s   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��
353,93,0,0q�6s   6�   �� 5   
   -	   5        $ label_Copy1��5      $��Quantity��6%   $
��Left=�68   $	��Top=�6S   $��	19,84,0,0q�6k   �� 5   
   -
   5        $ txtQuantity��5      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��188��6z   $��
132,86,0,0q�6�   5      5      