   M S B A M L   `   `   `  ����D  @WpdfAppDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpdfAppDb	WpdfAppDb  5   	       WpdfAppDb.ProductWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpdfAppDb     5   	     � Title$  ProductWindow��5   	   $	��250��6   $	��400��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $
��Name��6   $��5q�5       �� Padding$ 5q�5      $��20(�5      $��0��5      $��0��5      �� 5   
   -   5         ��Name$ 
NameTexbox��5      $��5q�5      $��5q�5      $��20(�5       $��1��5!      $��0��5"      
�������5#      �� 5&   
   $��Price��6   $��5q�5'      $ 5q�5(      $��20(�5)      $��0��5*      $��1��5+      �� 5.   
   -   5        $ PriceTexbox��5/      $��5q�50      $��5q�51      $��20(�52      $��1��53      $��1��54      
�������55      �� 57   
   $��Quantity��6   $��5q�58      $ 5q�59      $��20(�5:      $��0��5;      $��2��5<      �� 5?   
   -   5        $ QuantityTexbox��5@      $��5q�5A      $��5q�5B      $��20(�5C      $��1��5D      $��2��5E      
�������5F      �� 5I   
   $��3��6   $��0��5J      $��2��5K       �� Orientation$ 
Horizontal=�5L      $��Right=�5M      .+�5O      �� -   5        $
��Save��5O      $	��100��6$   $��40��60   $
��5 10q�5P      $��5q�5Q      $��20(�6!   5R      �� 5S      $��Cancel��6   $	��100��6&   $��40��62   $��20 10q�5T      $��5q�5U      $��20(�6!   5V      5W      5X      