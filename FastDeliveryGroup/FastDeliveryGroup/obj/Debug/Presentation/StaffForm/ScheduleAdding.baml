   M S B A M L   `   `   `  ����L  HFastDeliveryGroup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FastDeliveryGroup.Presentation.StaffForm(FastDeliveryGroup.Presentation.StaffForm  5   	   :    4FastDeliveryGroup.Presentation.StaffForm.AddSchedule   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:FastDeliveryGroup.Presentation.StaffForm     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          �Name$  
frmScheAdd��5   @    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddSchedule��5
   	   $	��674��6   $	��600��6*   .��5      � $	��642��6   $	��Top=�6   $��0,1,0,0q�60   .+�5   
   �� -   5         ��Name$ 	ProductID��5      $��Product��6#   $
��Left=�65   $��100,196,0,0q�6P   $	��Top=�6e   $��Times New Roman)�6}   $��16(�6�   �� 5   
   -   5        $ ProductID_Copy1��5      $��Shipper��6)   $
��Left=�6;   $��100,436,0,0q�6V   $	��Top=�6k   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5        $ ProductID_Copy2��5      $��Description��6)   $
��Left=�6?   $��
75,477,0,0q�6Z   $	��Top=�6n   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5        $ ProductID_Copy3��5      $��Delivery Time��6)   $
��Left=�6A   $��
57,407,0,0q�6\   $	��Top=�6p   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 
cbbShipper��5      $
��Left=�6'   $��180,440,0,0q�6B   $	��Top=�6W   $	��309��6o   $��Times New Roman)�6{   $��16(�6�   6�   �� 5   
   -   5         ��Name$ btnOk��5      $��OK��6    $
��Left=�6-   $��180,603,0,0q�6H   $	��Top=�6]   $��75��6u   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��307,603,0,0q�6P   $	��Top=�6e   $��98��6}   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -	   5        $ btnAddProduct��5      $	��Add��6(   $
��Left=�66   $��472,200,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ 
dgdProduct��5      $
��Left=�6'   $��180,230,0,0q�6B   $	��Top=�6W   $	��163��6o   $	��168��6|      AutoGenerateColumns .     
IsReadOnly . $	 �� IsSynchronizedWithCurrentItem$
	 TrueY�6�   
   CanUserSortColumns
 .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product��6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Product+   ClipboardContentBinding 6A   Z� 6d     5      $ Quantity��6e    6%   �� *
Quantity+ 6B   Z� 6e   5      �� 5   
   -   5        $ 
cbbProduct��5      $
��Left=�6'   $��178,202,0,0q�6B   $	��Top=�6W   $	��120��6o   �� 5   
   -   5        $ Quantity��5      $��Quantity��6"   $
��Left=�65   $��307,196,0,0q�6P   $	��Top=�6e   $��Times New Roman)�6}   $��16(�6�   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ txtQuantity��5      $
��Left=�62   $��373,200,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $��77��6�      Mask$ 00000��6�   �� 5   
   -   5        $ ProductID_Copy��5      $��Customer��6(   $
��Left=�6;   $��	88,51,0,0q�6V   $	��Top=�6i   $��Times New Roman)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 	txtFilter��5      $
��Left=�6%   $��36��6@   $��
180,10,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��113��6�   6�     5   
   -   5        $ dgdCustomer��5      $
��Left=�6(   $��
180,51,0,0q�6C   $	��Top=�6W   $	��140��6o   $	��281��6|   
 .   .  .   5         5!      $ ID��6g    6%   �� *
CustomerID+ 6D   Z� 6g     5"      $
 Name��6a    6%   �� *Name+ 6>   Z� 6a   5$      (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$ 
dpDeliTime��5%      $
��Left=�6)   $��180,410,0,0q�6D   $	��Top=�6Y   $	��102��6q   �� 5&   
   -   5        $ txtDescription��5&      $
��Left=�6*   $	��116��6E   $��180,482,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��309��6�   �� 5'   
   -   5        $ 	lblFilter��5'      $��	ID filter��6#   $
��Left=�67   $��
182,16,0,0q�6R   $	��Top=�6f   5*      5+      