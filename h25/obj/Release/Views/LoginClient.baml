   M S B A M L   `   `   `  ���� ?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views      h25.Views.LoginClient   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  #localclr-namespace:h25.Views  -   $��loginclient��   vmloginclient  � DataContext#  [   � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�$	��360��$	��400�� � Title$ LoginClient��.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Closed��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *CloseLoginClient+.��� 	 � RowDefinitions	 �� $
��auto ��� $��* �.+�� $��0��
 � ColumnDefinitions
 �� �� $
��auto �.+�� $��0�����	#FF7A81CE   $ MouseLeftButtonDown��.    �� *btn.isWinDragMove+   CommandParameter ��  �� ElementName$ loginclient���� $��1�� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   '��       �� " ��.���  � ��$ 32����  � �� �	#FF7A81CE��  � ��$ 0q� P�  �@J�IsMouseOver . . ���  �@�Cursor$
 Hand����  � ��
 � ���.+��� -   $��x������ *	btn.close+���� $ x��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�$
��auto��$
��auto��� $��1��	 �� $
��auto ��� .+��� $��1��
�������.+��� $��
30 40 30 5q�$��14(�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập�� % !MaterialDesignFloatingHintTextBox#��[ G� $��14(�$��
30 10 30 5q�$ Mật khẩu�� ) %MaterialDesignFloatingHintPasswordBox#��[ ��  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�   x �� 
TargetType �� CornerRadius��%;  '��       &	 �     �� " ��.���  � ��# �  ��  � ��$ 32����  � ��$	 150����  � ��
 �������  � ��$ 10 25 10 10q� P�  �@J�IsMouseOver . . ���  � ��
 ������  �@�Cursor$
 Hand���� " ��.R��� $ 14��#��z��._��� $��Center=�$��Center=�.+��� $��Đăng Nhập���� $��Thoát���� 
���  ��$��0 10 0 0q�$	��200��$
��Wrap=�$��Center=�$��Center=����� *	warning+