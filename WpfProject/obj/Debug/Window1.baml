   M S B A M L   `   `   `  ����G  CBedmintonApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfProject
WpfProject  5   	       WpfProject.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfProject     5   	     � Title$  Window1��5   	   $	��300��6   $	��300��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $
��Auto �6   �� 5      $	��70* �6   .+�5   
   �� -   5         ��Name$ gridSplitter��5      $��Stretch=�6-   $��10��6K    �� ResizeDirection$
 Rows=�6W   $��1��6n   ]� 5   
   .+�5      �� -   5         ��Name$ label��5      $��Display��6#   $��23��65   $	��Top=�6A   
����  �
�������$	��Top=�6~   �� 5      -   5         ��Name$ richTextBox��5      
����ح�$��Bottom=�6F    �� 
IsReadOnly . . �5      /� .T�5      J� .*�6    .*�5      �� $�RichTextBox��6   5      5      5      5      � 5      $��2��6    � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   .+�5      �� -   5        $ LabelCountFirstPlayer��5      $��0��63   $
��Left=�6@   $��85��6[   $��5,5,5,5q�6g   $��Center=�6x   $	��Top=�6�   $��91��6�   $��48(�6�   $
��Bold"�6�    � ToolTip$ Skóre hráča číslo 1��6�   	 � Cursor$
	 None��6�   �� 5       -   5        $ LabelCountSecondPlayer��5       $��0��64   $
��Left=�6@   $��85��6[   $��5,5,5,5q�6g   $��Center=�6x   $	��Top=�6�   $��91��6�   $��48(�6�   $
��Bold"�6�   $��1��6�   �� 5"      -   5        
 ��Name$
 button��5"      $��OK��6%   $��60��62   $��1��6=   $��60��6M   $��5q�6Y   5+      59      5:      