   M S B A M L   `   `   `  ����D  @WpdfAppDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpdfAppDb	WpdfAppDb  5   	       WpdfAppDb.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpdfAppDb     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��4* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $��0��6!   $��2��5      $��20(�5       �� Padding$ 5q�5      $��Center=�5      $
��Bold"�5      $��Food Product App��5      6.   �� 5   
   $��1��6   $��1��6"   .+�5      �� -   5        $��20(�5      $��Center=�5      $��10q�5      $��5q�5       
���Gc��
�������.��5#   )   Add Product5%      �� 5&      -   5        $��20(�5&      $��10q�5'      $��5q�5(      
���Gc��
�������.��5+   ,   Delete Product5,      �� 5-      -   5        $��20(�5-      $��10q�5.      $��5q�5/      
���Gc��
�������.��51   ?   Update Product52      53      &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ ProductGrid��59         AutoGenerateColumns$
 True��56      $��Stretch=�57      $��Stretch=�58      $��2��5:      $��1��5;      $��0��5<      
�������5>      �� 5?   
   $��1��6   $��2��6!   $��20(�6.   .��6<   Add Product6I   5A      5C      