   M S B A M L   `   `   `  ���� G  CBedmintonApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfProject
WpfProject      WpfProject.MainWindow2   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:WpfProject       � Title$  MainWindow2�����	#FFA4A4A4���� *&$SystemParameters.PrimaryScreenHeight+���� *%#SystemParameters.PrimaryScreenWidth+ � 	Resources    PlusFirstPlayer  MinusFirstPlayer  PlusSecondPlayer  MinusSecondPlayer  PressedS  PressedR  PressedZaciatok  PressedVynulovat��%x   &	        &	      &	 
     &	      &	      &	      &	      &	 #     �� �� �� �� �� �� �� ��  J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command# [    -   # [   -   # [   -   # [   -   # [   -   # [   -   # [   -   # [  J� InputBindings �� 
 �� Key$
 Left�� �� Command# [ �� $ Right��# [  �� $ Up��# [ �� $
 Down��# [ �� $ S�� �� 	Modifiers$
 Ctrlf�# [ �� $ R��$
 Ctrlf�# [ �� $ Z��$
 Ctrlf�# [ �� $ V��$
 Ctrlf�# [ .���  � ColumnDefinitions �� �� 	 � RowDefinitions	 �� $��25 ��� $	��10* ��� $��1* ��� $��1* �.+�]� $��2��.+�o� $	��Top=����	#FFA4A4A4.@�m� $��_File��.@�m� -	   $��_About��m� -
   $��_Close���� -   
 ��Name$
 LabelCountFirstPlayer��$��0��$	��160��$��143,42,143,0q�$��Center=�$	��Top=�$
��auto��$	��110(�$
��Bold"�$��1��$��0���� -    ��Name$ LabelStateFirstPlayer��$��Hráč 1��$��Center=�$��32��$��144,5,144,0q�$��Center=�$	��Top=�$
��auto��
������ $��1��$��0��$��24(��� -   $ LabelStateSecondPlayer��$��Hráč 2��$��Center=�$��32��$��144,5,144,0q�$��Center=�$	��Top=�$
��auto��
������ $��1��$��1��$��24(��� -    ��Name$ buttPlusFirstPlayer��$��+��$��Center=�$��21��$��144,217,206,0q�$	��Top=�$��30��$��1��$��0���� -   $ buttMinusFirstPlayer��$��-��$��Center=�$��21��$��206,217,144,0q�$	��Top=�$��30��$��1��$��0���� -   $
 labelSetyCountFirstPlayer��$
��Sety��$��Right=�$	��Top=�$��	0,217,0,0q�$��51��$��92��$��Center=�$��29.333(�$
��Bold"�$��1��$��0���� -   $
 LabelSetCountFirstPlayer��$��0��$��Right=�$	��133��$��
0,268,10,0q�$��Center=�
���  ��$	��Top=�$��92��$��96(�$
��Bold"�$��Verdana Pro Black)�$��1��$��0���� -   $
 LabelCountSecondPlayer��$��0��$	��160��$��143,42,143,0q�$��Center=�$	��Top=�$
��auto��$	��110(�$
��Bold"�$��1��$��1���� -   $ buttPlusSecondPlayer��$��+��$��Center=�$��21��$��144,217,206,0q�$	��Top=�$��30��$��1��$��1���� -   $ buttMinusSecondPlayer��$��-��$��Center=�$��21��$��206,217,144,0q�$	��Top=�$��30��$��1��$��1���� -   $ 
 labelSetyCountSecondPlayer��$
��Sety��$
��Left=�$	��Top=�$��	0,217,0,0q�$��51��$��92��$��Center=�$��29.33(�$
��Bold"�$��1��$��1���� -   $
 LabelSetCountSecondPlayer��$��0��$
��Left=�$	��133��$��
10,268,0,0q�$��Center=�
���  ��$	��Top=�$��92��$��96(�$
��Bold"�$��Verdana Pro Black)�$��1��$��1��� $��2��$��0��$��2��.+���  �� Orientation$ 
Horizontal=�$��2q�.+��� -   $
 label��$
��Menu��$
��Left=�$	��Top=�$��34��$��64��$��18(��� -   $ buttonStart��$��	Začiatok��$
��Left=�$	��Top=�$��84��$��13.333(�$
��Bold"�$��34���� -   $ buttonVynulovat��$��
Vynulovať��$
��Left=�$	��Top=�$��86��$��13.333(�$
��Bold"�$��34���� -   $ buttonR��$��R��$
��Left=�$	��Top=�$��88��$��13.333(�$
��Bold"�$��34���� -   $ buttonS��$��S��$
��Left=�$	��Top=�$��85��$��13.333(�$
��Bold"�$��34���� -    ��Name$ checkBox��$��Center=�$	��Top=�{�.  �� -   $
 	labeltime��$
��Čas��$
��Left=�$��30��$��18(�$	��Top=�$��51��$��0��$��3��$��10,0,0,0q��� -   $
 
labelTimer��$
��Left=�$��25��$	��Top=�$	��252��$��0��$��3��$��66,5,0,0q��� -   $
 labelStatus��$
��Left=�$��27��$	��Top=�$
��auto�����	#FF8C9191$��0��$��3��$��2��$��	341,5,0,0q�