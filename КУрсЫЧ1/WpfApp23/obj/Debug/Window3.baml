   M S B A M L   `   `   `  ����C  ?WpfApp23, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp23WpfApp23  5   	       WpfApp23.Window3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp23     5   	   -   5          � Title$  Window3��5   	   $	��450��6   $	��800��6&    � 	Resources 5	         WpfApp23.vxodDataSet1   vxodDataSet1  info_o_biletaxViewSource �� Source �� Source��%_   &	        &	      7     5
   
   6   �� 5   
    6@   �� *Info_o_biletax+8   5      .��5      � ���	#FFB851FF.+�5   
   �� $
��Left=�6   $	��270��6-   $��
40,108,0,0q�6:   $	��Top=�6N   $	��270��6f   �� 5   
   $2��,Информация о изменениях��6   $
��Left=�62   $��	40,65,0,0q�6M   $	��Top=�6`   $��Times New Roman)�6x   $��24(�6�   � 5   
   -   5         �Name$ grid1��5       � DataContext# [ 6   $
��Left=�6V   $��330,108,0,0q�6q   $	��Top=�6�    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��Bilet:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��0��6[   $��Center=�6h   �� 5      -   5         ��Name$ biletTextBox��5      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��0��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Bilet+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   5      �� 5   
   -   5        $��Назад
��5      $
��Left=�6+   $��670,366,0,0q�6F   $	��Top=�6[   $	��112��6s   $��43��6   ���	#FF1BFF6E6�   5      5      