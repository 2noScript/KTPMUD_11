   M S B A M L   `   `   `  ���� ?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views      h25.Views.VItemz   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  #localclr-namespace:h25.Views  -   $��vitemz��   vmitemz  � DataContext#  [  $��1q����	#FF7A81CE � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Title$ itemz��$	��450��$	��800�� � 	Resources  �� 
TargetType  	stylerbtn �� Property �� Value	 �� Triggers
 P� Property P� Value��%�   &	       �� " ��.���  � ��$ 32����  � �� �	#FF7A81CE��  � ��$ 0q�	 P� 
 �@J�IsMouseOver . . ���  �@�Cursor$
 Hand����  � ��
 � ���.���  � RowDefinitions �� $��35 ��� $	��300 ��� $��* �.+�� $��0�� � ColumnDefinitions �� $��* ��� $
��auto �.+�� ���	#FF7A81CE.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ MouseLeftButtonDown��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *btn.isWinDragMove+   CommandParameter ��  �� ElementName$ vitemz���� -    ��Name$ close��$��1��#���  $��35��$��35��$��Right=����� *	btn.close+���� $ close��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�� $��1�� �� $
��auto ��� $��* �.+��� ���	#FF7A81CE$��0 1 0 1q� �� Padding$ 0q�$	��298��$��0��._��� $	��300��$
��Left=����� *	PathImage+ �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$��1 1 0 1q����	#FF7A81CE._�� .+�)  #MaterialDesignThemes.Wpf.DrawerHost  .���� .+��� #���  $��Thông tin sản Phẩm��$	��500��$
��Left=�"  System.Windows.Controls.Dock   Right#��Z    OpenDrawerCommand#��Z ��  �� Orientation$ Vertical=�$��0 10 0 0q�.+��� $��	120 0 0 0q�$��DemiBold"�$��14(����� *Name+�� $��14(�$��DemiBold"�$��	140 4 0 0q����� *Price+� $	��200��.+��� $��0 15 0 0q�.+��� $��	30 10 0 0q�$
��Left=�$	��100��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Số Lượng�� �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ .@���  �� 
IsSelected . .��1�� .��2�� .��3�� .��4�� $��16(�$��DemiBold"�$��	30 10 0 0q�$��Tổng ���� $��
50 10 0 10q�$��DemiBold"�$��60000000 vnđ���� $��Đặt món ăn��$��	40 10 0 0q�
������$
��Left=�$��90��$��30��#���  �� $��0 15 0 0q�.+��� $��
160 10 0 0q� ! MaterialDesignOutlinedTextBox#��[ $	��Top=� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�$	��300��$	��150��$ 
Tin nhắn��    RightDrawerContent  �� $	��500��.+��� #���  !   CloseDrawerCommand#��Z! #��Z $
��Back���� $��hello��� $��2�� �� $
��auto ��� .+��� $ Vertical=�$	��100��$��10 0 0 0q�.+��� $��	0 10 0 0 q��� $ 
Horizontal=�.+�  $
 Star=��� $	��100��$��15 0 0 0q��� �� $ 
Horizontal=�.+�  $
 Star=��� $	��100��$��15 0 0 0q��� �� $ 
Horizontal=�.+�  $
 Star=��� $	��100��$��15 0 0 0q��� �� $ 
Horizontal=�.+�  $
 Star=��� $	��100��$��15 0 0 0q��� �� $ 
Horizontal=�.+�  $
 Star=��� $	��100��$��15 0 0 0q�