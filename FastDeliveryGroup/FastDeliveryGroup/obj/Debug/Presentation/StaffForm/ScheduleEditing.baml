   M S B A M L   `   `   `  ����L  HFastDeliveryGroup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FastDeliveryGroup.Presentation.StaffForm(FastDeliveryGroup.Presentation.StaffForm  5   	   ;    5FastDeliveryGroup.Presentation.StaffForm.EditSchedule   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:FastDeliveryGroup.Presentation.StaffForm     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          �Name$  frmScheEdit��5   @    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ EditSchedule��5
   	   $	��520��6   $	��600��6+   .��5      � -   5        .+�5   
   �� -   5         ��Name$ ProductID_Copy��5      $��Total��6(   $
��Left=�68   $��415,288,0,0q�6S   $	��Top=�6h   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5        $ ProductID_Copy1��5      $��Shipper��6)   $
��Left=�6;   $��
104,94,0,0q�6V   $	��Top=�6j   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5        $ ProductID_Copy2��5      $��Description��6)   $
��Left=�6?   $��
80,144,0,0q�6Z   $	��Top=�6n   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5        $ ProductID_Copy3��5      $��Time Delivery��6)   $
��Left=�6A   $��	62,48,0,0q�6\   $	��Top=�6o   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ btnOk��5      $
��Save��6    $
��Left=�6/   $��236,336,0,0q�6J   $	��Top=�6_   $��74��6w   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��356,336,0,0q�6P   $	��Top=�6e   $��98��6}   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -	   5         ��Name$ 
cbbShipper��5      $
��Left=�6'   $��
222,98,0,0q�6B   $	��Top=�6V   $	��308��6n   $��Times New Roman)�6z   $��16(�6�   (  "System.Windows.Controls.DatePicker  5   
   -
   5          Name$ 
dpDeliTime��5      $
��Left=�6)   $��
222,50,0,0q�6D   $	��Top=�6X   �� 5   
   -   5        $ ProductID_Copy4��5      $��Status��6)   $
��Left=�6:   $��116,234,0,0q�6U   $	��Top=�6j   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5        $ 	cbbStatus��5      $
��Left=�6&   $	��Top=�6A   $	��120��6Y   $��222,240,0,0q�6e   .@�5      �� $��Pending��6   �� 5      $��On going��6   �� 5      $��	Completed��6   �� 5      $��Cancel��6   5      �� 5   
   -   5         ��Name$ txtDescription��5      $
��Left=�6*   $��85��6E   $��222,150,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��308��6�   �� 5   
   -   5        $ lblTotal��5      $��Label��6"   $
��Left=�62   $	��Top=�6M   $��492,288,0,0q�6e   5!      5"      