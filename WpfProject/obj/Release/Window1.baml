   M S B A M L   `   `   `  ���� G  CBedmintonApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfProject
WpfProject      WpfProject.Window1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:WpfProject       � Title$  Window1��$	��300��$	��300��.���  � RowDefinitions �� �� $
��Auto ��� $	��70* �.+��� -    ��Name$ gridSplitter��$��Stretch=�$��10�� �� ResizeDirection$
 Rows=�$��1��]� .+��� -    ��Name$ label��$��Display��$��23��$	��Top=�
����  �
�������$	��Top=��� -    ��Name$ richTextBox��
����ح�$��Bottom=� �� 
IsReadOnly . . �/� .T�J� .*�.*��� $�RichTextBox��� $��2�� � ColumnDefinitions �� �� $
��Auto �.+��� -   $ LabelCountFirstPlayer��$��0��$
��Left=�$��85��$��5,5,5,5q�$��Center=�$	��Top=�$��91��$��48(�$
��Bold"� � ToolTip$ Skóre hráča číslo 1��	 � Cursor$
	 None���� -   $ LabelCountSecondPlayer��$��0��$
��Left=�$��85��$��5,5,5,5q�$��Center=�$	��Top=�$��91��$��48(�$
��Bold"�$��1���� -   
 ��Name$
 button��$��OK��$��60��$��1��$��60��$��5q�