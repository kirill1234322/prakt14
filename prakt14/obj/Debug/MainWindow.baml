   M S B A M L   `   `   `  ����B  >prakt14, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:prakt14prakt14  5   	       prakt14.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:prakt14     5   	     � Title$  MVVM_Example��5	   	   $��403.921��6   $��310.294��6/    � 	Resources 5
      +   %prakt14.DiscountToVisibilityConverter   DiscountConverter+   %prakt14.DiscountToStrikelineConverter  DecorationConverter��%:   &	        &	        5   
   6.     5   
   6.   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6I    � DataContext 6%   �� *SelectedCar+.+�5      �� $'��!Выбранный элемент��6   $��
0,0,-233,0q�61   �� 5      $��Модель��6   �� 5      -   5         ��Name$
 text��5      ��6$   �� *Model+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $:��4Максимальная скрорость, км/ч��6   �� 5      ��6   �� *
MaxSpeed+$ PropertyChanged=��� 5      $��Цена, руб.��6   �� 5      ��6   �� *Price+$ PropertyChanged=��� 5      $��Скидка товара��6   �� 5      -   5        $ text1��5   h   ��6   �� *
Discount+$ PropertyChanged=�6h   �� 5      -   5        $��10 10 10 10q�5   '   
����� �.��6N   Добавить товар6^   �� 5      -   5        $��10 10 10 10q�5   *   
����� �.��6Q   Удалить товар6`   5!      �� 5"   
   -   5         ��Name$
 list��5"      $��0��6    $��0��60   $��	0,240,0,0q�5#   '   ��5"   =   �� *Cars+ �� SelectedItem 5#      �� *SelectedCar+��5$      �� 5%      .R�5&      �� $��5q�6!   .+�5'      �� $��18(�6$   ��62   ��  �� Path$ Model��� 5(      ��6$   �� $ MaxSpeed��� 5+      �� 5,      $�Цена��6"   $��SemiBold"�6/    �� 5-      �6"   �� *DiscountPrice+	 �� Mode$	 OneWay=�
 �� TextDecorations
 5.      �� *HasDiscount+ �� 	Converter# [  �� 50      $�рублей��6"   51      �� 53      
���  ��$��12(�56      $��SemiBold"�6-   y�54      �� *HasDiscount+# [  �� 58       $(�"СКИДКА! НОВАЯ ЦЕНА:��6$    �� 59       �6$   �� *Price+$	 OneWay=� �� 5:       $�рублей.��6$   5;      5<      5=      5?      5@      5A      