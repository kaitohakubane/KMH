   M S B A M L   `   `   `  ����L  HFastDeliveryGroup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FastDeliveryGroup.Presentation.AdminForm(FastDeliveryGroup.Presentation.AdminForm  5      >    8FastDeliveryGroup.Presentation.AdminForm.StaffManagement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:FastDeliveryGroup.Presentation.AdminForm     5      .��5	      � -   5        .+�5
   
   �� -   5          ��Name$  label��5
      $��AdmindManager��6   $
��Left=�67   $��	244,3,0,0q�6R   $	��Top=�6e   $��Times New Roman)�6}   $��16(�6�   �� 5   
   -   5         ��Name$ btnAddStaff��5      $��	Add Staff��6&   $
��Left=�6:   $��145,208,0,0q�6U   $	��Top=�6j   $	��132��6�   $��Times New Roman)�6�   $��16(�6�   6�   �� 5   
   -   5        $ btnDeleteStaff��5      $��Delete Staff��6)   $
��Left=�6@   $��315,208,0,0q�6[   $	��Top=�6p   $	��118��6�   $��Times New Roman)�6�   $��16(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgStaff��5      $
��Left=�6%   $��	23,45,0,0q�6@   $	��Top=�6S   $	��560��6k   $	��147��6w      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ FullName��6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
FullName+   ClipboardContentBinding 6B   Z� 6e     5      $ UserID��6c    6%   �� *UserID+ 6@   Z� 6c     5      $ UserName��6e    6%   �� *
UserName+ 6B   Z� 6e     5      $ PasWord��6e    6%   �� *
Password+ 6B   Z� 6e     5      $
 Role��6a    6%   �� *Role+ 6>   Z� 6a     5      $ Phone��6b    6%   �� *Phone+ 6?   Z� 6b     5      5      5      5      