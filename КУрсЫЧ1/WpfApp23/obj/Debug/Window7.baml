   M S B A M L   `   `   `  ����C  ?WpfApp23, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp23WpfApp23  5   	       WpfApp23.Window7   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp23     5   	   -   5          � Title$  Window7��5   	   $	��450��6   $	��800��6&    � 	Resources 5	         WpfApp23.vxodDataSet   vxodDataSet  rasshetViewSource �� Source �� Source��%X   &	        &	      7     5
   
   6   �� 5   
    69   �� *	rasshet+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� $)��#Меню броннирования��6   $
��Left=�6-   $��
110,10,0,0q�6H   $	��Top=�6\   $��46��6t   $	��492��6�   �� 5   
   $
��Left=�6   $��	10,56,0,0q�6.   $	��Top=�6A   $	��772��6Y   $	��263��6e    �� DisplayMemberPath$
 kuda��6r    �� SelectedValuePath$
 kuda��6�   ��6�   ��  �� SelectedValue 6�   �� *kuda+�� 5   
   $��Button��6   $
��Left=�6"   $��
10,344,0,0q�6=   $	��Top=�6Q   $	��360��6i   $��65��6u   �� 5   
   $��Button��6   $
��Left=�6"   $��405,344,0,0q�6=   $	��Top=�6R   $	��360��6j   $��65��6v   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ rasshetDataGrid��5      	   AutoGenerateColumns	 .  
   EnableRowVirtualization
 . $��45,90,222,129q�6      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   ��6g   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
kudaColumn��,  &System.Windows.Controls.DataGridColumn   Header$
 kuda��5   R      Width$	 100 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *kuda+6`     5      -   5        vremaColumn��$ vrema��5   T   $	 100 6c    6:   �� *vrema+6c     5      -   5        
dataColumn��$
 data��5   R   $	 100 6`    69   �� *data+6`     5      -   5        stoumostColumn��$ stoumost��5   Z   $	 100 6l    6=   �� *
stoumost+6l   5      5      5      