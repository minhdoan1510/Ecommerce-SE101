   M S B A M L   `   `   `  ����H  DECommerce_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ECommerce_GUI.MainApp.SellerECommerce_GUI.MainApp.Seller  5   	   3    -ECommerce_GUI.MainApp.Seller.AddProductWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47toolKit)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   6local*clr-namespace:ECommerce_GUI.MainApp.Seller  5   	     � Title$  AddProductWindow��5
   	   $	��520��5   	    � 
ResizeMode$ NoResize=�5   	   $	��395��5   	   .��5      � .+�5   
   �� $��5q�6   .+�5      �� $��Product Name��6   $
��Bold"�5      $��0 5 0 5q�5      $��15(�5      �� 5      -   5        $��productName��5      $��15(�5      �� 5      $��Price��6   $
��Bold"�5      $��0 5 0 5q�5      $��15(�5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��productPrice��5      $��15(�5      
���  ��$	��320��5       �� 5!      $
��VNĐ��6   $��Center=�5"      $��5 0 0 0q�5#      5$      �� 5%      $��Quantity��6   $
��Bold"�5&      $��0 5 0 5q�5'      $��15(�5(      %  Xceed.Wpf.Toolkit.IntegerUpDown  5)      -   5          Name$ quantity��5)   $   $	��150��5*   $   $
��Left=�5+   $   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value$ 1X�5-   $      Minimum$ 1X�5.   $   $��15(�5/   $   �� 50      $��Description��6   $
��Bold"�51      $��0 5 0 5q�52      $��15(�53      �� 54      $��Visible=�6   $��Disabled=�55      .��56      �� -   5        $��description��56      $��12(�57      
������� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5:      $	��100��5;      $��	0,0,0.2,0q�5<      5=      �� 5>      $ 
Horizontal=�6   $��32��5?      .+�5@      �� $��Product Images��6   $
��Bold"�5A      $��0 5 0 5q�5B      $��15(�5C      �� 5D      -   5        $��	chooseImg��5E      
������ $��0q�5G      $��0q�5H      $
��auto��5I      $��10,5,0,5q�5J      $��25��5K      .��5L      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 File=�6.   
�������5M   .   5N      �� 5O      -   5        $��clearImg��5P      
������ $��0q�5R      $��0q�5S      $
��auto��5T      $��10,5,0,5q�5U      $��25��5V      ���	#FFB73A3A.��5X        $ Trash=�6.   
�������5Y   .   5Z      5[      �� 5]      $��Visible=�6   $��Disabled=�5^      .��5_      �� -   5        $��imageUrl��5`      $��80��5_      	 J� 	AllowDrop	 . $��Drag And Drop Images Here��5d      $��12(�5e       . 
 �� 
IsReadOnly
 . $��	0,0,0.2,0q�5h      .��6-   5i      5j      �� 5k      -   5         ��Name$ 
addProduct��5k      $��Add Product��5l      $��0 25 0 0q�5m      $
��Left=�5n      ���	#FF3DB73A5q      5r      5s      5t      