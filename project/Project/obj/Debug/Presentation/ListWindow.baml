   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Project.PresentationProject.Presentation  5   	   %    Project.Presentation.ListWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Project.Presentation     5   	     � Title$  
Management��5   	   $��340.299��6   $��511.974��6-    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S   ��5	      �� 5
   
    �� ImageSource$. (/Project;component/Image/wallpaper02.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ lblName2��5      $
��List��6"   $��Center=�61   $	��Top=�6N   
�������$��26.667(�6y   $��French Script MT)�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��
184,44,0,0q�6s   ���	#FF0600FF��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF00F1FF��6#   	 � Offset$	 0Q�65   � 5      $ White��6#   $	 1Q�61   5      5      �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��	47,44,0,0q�6s   ���	#FF0600FF��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF00F1FF��6#   $	 0Q�65   � 5      $ White��6#   $	 1Q�61   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dataGrid��5      $
��Left=�6%   $	��Top=�6@   $	��168��6X   $��505.574��6e   $��0,78,0,0q�6u   6�   �� 5   
   -   5         ��Name$ 	txtSearch��5      $
��Left=�6%   $��23��6@   $��254,266,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��242��6�   6�   �� 5    
   -   5        $ lblName��5       $
��Left=�6!   $	��Top=�6<   $��
10,266,0,0q�6T   $	��239��6h   ���	#FF1300C3$��16(�6�   $��30��6�   �� 5!   
   -   5        $ btnBack��5!      $
��Back��6"   $
��Left=�61   $��
326,44,0,0q�6L   $	��Top=�6`   $��75��6x   ���	#FF0600FF��5"      �� 5#      $ 0.5,1&�6&   $ 0.5,0&�67   .��5$      � $ 	#FF00F1FF��6#   $	 0Q�65   � 5%      $ White��6#   $	 1Q�61   5&      5(      �� 5)   
   -   5        $ lblName_Copy��5)      $
��Left=�6&   $	��Top=�6A   $��295,263,-28.4,0q�6Y   $	��239��6r   ���	#FF1300C3$��16(�6�   (  "System.Windows.Controls.DatePicker  5*   
   -	   5          Name$ dpSearch��5*      $��254,263,118.6,17.4q�6'   6C   �� 5+   
   -
   5        $ btnAdd��5+      $	��Add��6!   $
��Left=�6/   $	��Top=�6J   $��75��6b   6m   5-      5.      