   M S B A M L   `   `   `  ����H  DECommerce_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ECommerce_GUI.MainApp.ProductECommerce_GUI.MainApp.Product  5   	   =#clr-namespace:ECommerce_GUI.MainAppECommerce_GUI.MainApp  5   	   *    $ECommerce_GUI.MainApp.CustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   9control+clr-namespace:ECommerce_GUI.MainApp.Product  5   	   /local#clr-namespace:ECommerce_GUI.MainApp  5   	   -   5          � WindowStyle$
  None=�5
   	   $��1q�5   	   
���   � � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	   
������� � Title$ MainApp��5   	   $	��768��5   	   $
��1300��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    K� ZIndex$ 1��5      $��0 0 0 50q�5       �� Orientation$ 
Horizontal=�5      $��LeftToRight=�5      .+�5      �� -   5         ��Name$ rechargeAccount��5      
������ 
������ $��Recharge Account��5!      5$      �� 5%      -   5        $ 
sellerPage��5%      
������ 
������ $��Seller Channel��5(      5*      �� 5+      -   5        $ homePage��5+      
������ 
������ $��Refresh��5.      50      � 51      -   5        $��watting��51       %  !MaterialDesignCircularProgressBar#��[  52      
�������$y�Visible=�54      $��30��55      $
��Auto��56       � Value$ 0Q�57      	 � IsIndeterminate	 . $��
0,10,0,8.6q�59      5:      �� 5;   
   -   5        $��0��5;      ���	#FFD44D27.+�5>      �� $��50��6   $ 
Horizontal=�5?      $��RightToLeft=�5@      .+�5A      �� -   5        $ closeBtn��5A      $��	5,9,5,8.6q�5B      
������ 
������ $��0q�5E      $��29��5F      .��5H      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6.   
�������$��21��5J   .   $��22��5K   .   5L      �� 5M      -   5        $ minimizeBtn��5M      $��	5,9,5,8.6q�5N      
������ 
������ $��0q�5Q      $��29��5R      .��5T        $
 WindowMinimize=�6.   
�������$��21��5V   .   $��22��5W   .   5X      �� 5Y      -	   5        $ username��5Y      $��customer username��5Z      
������ 
������ 
�������$��20(�5^      $��3q�5_      $��SemiBold"�5`      $	��256��5a      �� 5b        user#��[ 6   $
��Fill=�5c      $��5q�5d      5e      �� 5f      $��50��6   $ 
Horizontal=�5g      .+�5h      ��   appIcon#��[ 6   $
��Fill=�5i      $��5q�5j      �� 5k      $��
E-Commerce��6   
������� �� TextAlignment$ Center=�5m      $��Center=�5n      $��25(�5o      $��SemiBold"�5p      �� 5q      -
   5        $��	searchBar��5q      $��10,10,0,7.6q�5r      $	��946��5s      $��32��5t      $��20(�5u      $��DemiBold"�5v      
�������
���   �5x      �� 5y      -   5        $��search��5y      $��
10,9,0,8.6q�5z      $��34��5{      ���	#FF6BD05B$��0q�5~      .��5        $
 Search=�6.   
�������5�   .   5�      �� 5�      -   5        $
��cart��5�      $��
10,5,0,4.6q�5�      $��34��5�      
������ 
������ $��0q�5�      $
��Auto��5�      .��5�        $

 Cart=�6.   
�������$��29��5�   .   $��30��5�   .   5�      �� 5�      -   5        $��orders��5�      $��
10,5,0,4.6q�5�      $��34��5�      
������ 
������ $��0q�5�      $
��Auto��5�      .��5�        $
 TruckDelivery=�6.   
�������$��29��5�   .   $��30��5�   .   5�      5�      5�      � 5�   
   -   5        $��toastNotificationArea��5�      $��1��5�      .+�5�      � -   5        $��controlGrid��5�      $��1��5�      $��	70 0 70 0q�5�      
�������5�      5�      5�      5�      