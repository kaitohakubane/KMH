   M S B A M L   `   `   `  ����L  HFastDeliveryGroup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FastDeliveryGroup.Presentation.StaffForm(FastDeliveryGroup.Presentation.StaffForm  5      A    ;FastDeliveryGroup.Presentation.StaffForm.ScheduleManagement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:FastDeliveryGroup.Presentation.StaffForm     5      .��5	      � -   5        .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  dataGrid��5
      $
��Left=�6%   $��197,135,0,0q�6@   $	��Top=�6U     5   
   -   5        $  
dgdInvoice��5      $
��Left=�6'   $��	10,29,0,0q�6B   $	��Top=�6U   $	��580��6m   $	��211��6y      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
ScheduleID��6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	InvoiceID+   ClipboardContentBinding 6C   Z� 6f     5      $ 
CustomerID��6g    6%   �� *
CustomerID+ 6D   Z� 6g     5      $ Status��6c    6%   �� *Status+ 6@   Z� 6c     5      $ Total��6b    6%   �� *Total+ 6?   Z� 6b   5      �� 5   
   -   5         ��Name$ btnAddSchedule��5      $��Add Schedule��6)   $
��Left=�6@   $��113,260,0,0q�6[   $	��Top=�6p   $	��141��6�   $��Times New Roman)�6�   $��16(�6�   6�   �� 5   
   -   5        $ btnEditSchedule��5      $��Edit Schedule��6*   $
��Left=�6B   $��268,260,0,0q�6]   $	��Top=�6r   $	��132��6�   $��Times New Roman)�6�   $��16(�6�   6�   5      5      