   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	     � Title$  Login��5   	   $��315.312��6   $��384.919��6(    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N   ��5	      �� 5
   
    �� ImageSource$. (/Project;component/Image/wallpaper02.jpg��6   .��5      � $��0,0,-6.6,-2.4q�6   .+�5   
   �� -   5         ��Name$ label��5      $��	Username:��6   $	��Top=�63   $��
50,100,0,0q�6K   $��13.333(�6_   $��Stretch=�6q   $��Center=�6�   $
��Left=�6�    � Cursor$
 None��6�   
�������6�   �� 5   
   -   5        $ label1��5      $��	Password:��6    $
��Left=�64   $	��Top=�6O   $��
50,150,0,0q�6g   $��13.333(�6{   $��Center=�6�   $��Stretch=�6�   
�������6�   �� 5   
   -   5        $ label2��5      $��Login��6    $	��Top=�60   $��40(�6H   $��Center=�6V   $��Center=�6s   $��Center=�6�   $��French Script MT)�6�   $��0,30,0,0q�6�   
���������5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Offset$ 0Q�6#   � 5      $ 1Q�6#   5      5      �� 5   
   -   5        	 ��Name$	 txtUsername��5      $
��Left=�6'   
 �� TextWrapping$

 Wrap=�6B   $	��Top=�6V   $��150,100,0,0q�6n   $��13.333(�6�   $��Stretch=�6�   $��Center=�6�   $��30��6�   $	��150��6�   6�   �� 5   
   -   5         ��Name$ btnLogin��5      $��Login��6#   $
��Left=�63   $��Bottom=�6N   $��
123,0,0,25q�6i   $��13.333(�6}   $��Center=�6�   $��Center=�6�   $��50.006��6�   ���	#FF0003FF��5      �� 5      $ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5      �  � Color$ Black��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   � 5      $ 	#FF00F1FF��6#   5      5!      �� 5"   
   -   5        $ btnExit��5"      $
��Exit��6"   $
��Left=�61   $��Bottom=�6L   $��
224,0,0,25q�6g   $��13.333(�6{   $��Center=�6�   $��Center=�6�   $��49.98��6�   ���	#FF0003FF��5#      �� 5$      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5%      � $ Black��6#   $ 0Q�61   � 5&      $ White��6#   $ 1Q�61   � 5'      $ 	#FF00F1FF��6#   5(      5*      G� 5+   
   -   5         G�Name$ txtPassword��5+      $
��Left=�6+   $��150,158,0,0q�6F   $	��Top=�6[   $��13.333(�6s   $��Stretch=�6�   $��Center=�6�   $��30��6�   $	��150��6�   �� 5,   
   -   5        $ lblUsername��5,      $
��Left=�6%   $��152,130,0,0q�6@   $	��Top=�6U   $	��148��6m   $��14.667(�6y   $��Username not blank!��6�   
�������6�   5-      5.      