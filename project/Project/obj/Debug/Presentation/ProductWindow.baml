   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Project.PresentationProject.Presentation  5   	   (    "Project.Presentation.ProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Project.Presentation     5   	     � Title$  Product��5   	   $	��400��6   $��308.955��6&    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L   ��5	      �� 5
   
    �� ImageSource$. (/Project;component/Image/wallpaper02.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ lblName��5      $��Label��6!   $��Center=�61   $	��Top=�6N   
�������$��Center=�6y   $��French Script MT)�6�   $��20(�6�   �� 5   
   -   5        $ label��5      $	��ID:��6   $
��Left=�6-   $	��Top=�6H   $��	10,48,0,0q�6`   
�������6s   �� 5   
   -   5        $ label1��5      $��Name:��6    $
��Left=�60   $	��Top=�6K   $��	10,79,0,0q�6c   
�������6v   �� 5   
   -   5        $ label1_Copy��5      $��SupplierID:��6%   $
��Left=�6;   $	��Top=�6V   $��
10,110,0,0q�6n   
�������6�   �� 5   
   -   5        $ label1_Copy1��5      $��	Producer:��6&   $
��Left=�6:   $	��Top=�6U   $��
10,141,0,0q�6m   
�������6�   �� 5   
   -   5        $ label1_Copy2��5      $��Origin:��6&   $
��Left=�68   $	��Top=�6S   $��
10,172,0,0q�6k   
�������6   �� 5   
   -   5        $ label1_Copy3��5      $��InPrice:��6&   $
��Left=�69   $	��Top=�6T   $��
10,203,0,0q�6l   
�������6�   �� 5   
   -   5        $ label1_Copy4��5      $��	OutPrice:��6&   $
��Left=�6:   $	��Top=�6U   $��
10,234,0,0q�6m   
�������6�   �� 5   
   -	   5        $ label1_Copy5��5      $��	Quantity:��6&   $
��Left=�6:   $	��Top=�6U   $��
10,264,0,0q�6m   
�������6�   �� 5   
   -
   5        $ label1_Copy6��5      $��Type:��6&   $
��Left=�66   $	��Top=�6Q   $��
10,295,0,0q�6i   
�������6}   �� 5   
   -   5         ��Name$ btnOK��5      $��OK��6    $
��Left=�6-   $	��Top=�6H   $��75��6`   $��
50,333,0,0q�6k   ���	#FF003AFF��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF00F1FF��6#   	 � Offset$	 0Q�65   � 5      $ White��6#   $	 1Q�61   5      5      �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $	��Top=�6P   $��75��6h   $��178,333,0,0q�6s   ���	#FF003AFF��5       �� 5!      $ 0.5,1&�6&   $ 0.5,0&�67   .��5"      � $ 	#FF00F1FF��6#   $	 0Q�65   � 5#      $ White��6#   $	 1Q�61   5$      5&      �� 5'   
   -   5        
 ��Name$
 txtName��5'      $
��Left=�6#   $��23��6>   $��	85,82,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��182��6�   �� 5(   
   -   5        $
 txtSupplierID��5(      $
��Left=�6)   $��23��6D   $��
85,113,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��182��6�   �� 5)   
   -   5        $
 txtProducer��5)      $
��Left=�6'   $��23��6B   $��
85,144,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��182��6�   �� 5*   
   -   5        $
 	txtOrigin��5*      $
��Left=�6%   $��23��6@   $��
85,175,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��182��6�   �� 5+   
   -   5        $
 
txtInPrice��5+      $
��Left=�6&   $��23��6A   $��
85,206,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��182��6�   �� 5,   
   -   5        $
 txtOutPrice��5,      $
��Left=�6'   $��23��6B   $��
85,236,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��182��6�   �� 5-   
   -   5        $
 txtQuantity��5-      $
��Left=�6'   $��23��6B   $��
85,267,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��182��6�   �� 5.   
   -   5        $
 txtID��5.      $
��Left=�6!   $��23��6<   $��	85,48,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $	��182��6�   �� 5/   
   -   5         ��Name$ cbbType��5/      $
��Left=�6$   $	��Top=�6?   $	��182��6W   $��
85,298,0,0q�6c   51      52      