   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Project.PresentationProject.Presentation  5   	   )    #Project.Presentation.DiscountWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Project.Presentation     5   	     � Title$  Discount��5   	   $��225.866��6   $��309.067��6+    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q   ��5	      �� 5
   
    �� ImageSource$. (/Project;component/Image/wallpaper02.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ lblName��5      $��Label��6!   $��Center=�61   $	��Top=�6N   
�������$��French Script MT)�6y   $��20(�6�   $��Center=�6�   �� 5   
   -   5        $ label1_Copy��5      $��DateEnd��6%   $
��Left=�67   $	��Top=�6R   $��
10,115,0,0q�6j   
�������6~   �� 5   
   -   5        $ label1_Copy1��5      $��	DateStart��6&   $
��Left=�6:   $	��Top=�6U   $��	10,84,0,0q�6m   
�������6�   �� 5   
   -   5        $ label1_Copy3��5      $
��Rate��6&   $
��Left=�65   $	��Top=�6P   $��9,42,0,0q�6h   
�������6z   �� 5   
   -   5         ��Name$ txtRate��5      $
��Left=�6#   $��23��6>    �� TextWrapping$
 Wrap=�6J   $	��Top=�6^   $	��212��6v   $��	82,46,0,0q�6�   �� 5   
   -   5         ��Name$ btnOK��5      $��OK��6    $
��Left=�6-   $	��Top=�6H   $��75��6`   $��
70,149,0,0q�6k   ���	#FF1800FF��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FF00F1FF��6#    � Offset$ 0Q�65   � 5      $
 White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��180,149,0,0q�6s   ���	#FF1800FF��5      �� 5      $ 0.5,1&�6&   $	 0.5,0&�67   .��5      � $
 	#FF00F1FF��6#   $ 0Q�65   � 5      $
 White��6#   $ 1Q�61   5      5!      (  "System.Windows.Controls.DatePicker  5"   
   -   5          Name$ dpStart��5"      $
��Left=�6&   $	��Top=�6A   $��	83,80,0,0q�6Y      SelectedDateFormat$ Short=�6l     5#   
   -	   5        $ dpEnd��5#      $
��Left=�6$   $	��Top=�6?   $��
82,115,0,0q�6W   $ Short=�6k   5%      5&      