   M S B A M L   `   `   `  ����H  DECommerce_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ECommerce_GUI.MainApp.ProductECommerce_GUI.MainApp.Product  5      1    +ECommerce_GUI.MainApp.Product.DetailProduct   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      7local+clr-namespace:ECommerce_GUI.MainApp.Product  5      
�������.��5      �� $��Disabled=�6   $��Hidden=�5      .��5   
   �� .+�5      �� -   5        $
��back��5      $��0 10 1100 1q�6!   
������ $��0q�5   *   $��0q�5      $��52��5   $   .��5      '  !MaterialDesignThemes.Wpf.PackIcon      Kind$  	ArrowBack=�6*   
���   �$��46��6N   $��38��6Y   $��0 0 0 0q�5   *   5      � 5      $��	0 10 0 10q�6   
�������.+�5      �  � ColumnDefinitions 5      �� 5      $	��450 �6+   �� 5      $��* �6+   .+�5      �� $��0��6!   .+�5      �� -   5         ��Name$ 
productImg��5       $	��350��64   $��50 10 50 10q�6A   $��Uniform=�5       5      � 5       $��50��6   $��10q�6+    5!      �� 5"   "   $��* �63   �� 5#   "   $��* �63   .+�5&      �� -   5        $��previousImg��5&   T   $��0��6%   $��	50 0 50 0q�65   $��0q�6H   .��5(   "     $  ArrowLeftBold=�6:   
�������$��70��6b   $��20��6m   5)      �� 5*      -   5        $��nextImg��5*   T   $��1��6%   $��	50 0 50 0q�65   $��0q�6H   .��5,   "     $  ArrowRightBold=�6:   
�������$��70��6c   $��20��6n   5-      5.      50      �� 52      $��1��6!   $��10 0 0 0q�61   .+�53      �� -   5        $��productName��53   $   $��35(�54       $��DemiBold"�6.   $��	underline{�55       $�� ��6<   �� 56      -   5         ��Name$ productPrice��56   $   $��45(�57   !   
���  ��$�� ��6@   58      �� 59       �� Orientation$ 
Horizontal=�6%   $��0 20 0 0q�6>   $��80��5:   %   .+�5;      �� -   5        $��shopImg��5<   $   $��80��5;   $   $��10 0 0 0q�6/      MaterialDesignShadowDepth5 J� Effect# [  6A   $
��Fill=�5<   3   5>      �� 5?      $��15 0 0 0q�6)   .+�5@   "   �� -   5        $��shopName��5@   ,   $��25(�6<   �� 5A   "   -	   5        $��viewShop��5A   )   $��	View Shop��69   $��20(�6M   $��0 8 60 0q�6[   ���	#FFB06F2E5C   )   5D      5E      �� 5F      $ 
Horizontal=�6%   $��	0 20 0 10q�6>   $��45��5G   %   .+�5H      �� $��Quantity��6(   $��30(�5I   !   %  Xceed.Wpf.Toolkit.IntegerUpDown  5J      -
   5          Name$ quantity��5J   1   $��15,0,0,-0.2q�6C   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 1X�5K   !      DefaultValue$ 1X�6-   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase	   Text$	 1��6>   $��25(�6G   $	��166��6U   
   AllowTextInput
 .  5M   !   5O      �� 5Q      $��30��6%   $ 
Horizontal=�61   .+�5R      (  "MaterialDesignThemes.Wpf.RatingBar  -   5        $��productRating��5R   7      
IsReadOnly . 6L   �� 5S      -   5        $ ratingCount��5S   (    �� TextAlignment$ Center=�6=   $��5 0 0 0q�6T   $��18(�5T   (   5U      �� 5W      -   5         ��Name$ 	addToCart��5W   !   $
��Auto��65   $��0,30,498.2,20q�6C   ���	#FF8B2727$��Add To Cart��5Y   !   $��25(�67   5Z   !   5[      5\      5]      �� 5_      $��	0 10 0 10q�6   
�������$
��auto��5`      .+�5a      �� $��Reviews��6   $��35(�6+   $��DemiBold"�69   �� 5b      -   5        $��
reviewText��5b      $��20(�6.   $
��Wrap=�6<    �� Padding$ 0 10 0 0q�5c      5d      �� 5f      $��	0 10 0 10q�6   
�������$
��auto��5g      .+�5h      �� $��Description��6   $��35(�6/   $��DemiBold"�6=   �� 5i      -   5        $��productDescription��5i      $��25(�66   $
��Wrap=�6D   $ 0 10 0 0q�5j      5k      5l      5m      5n      