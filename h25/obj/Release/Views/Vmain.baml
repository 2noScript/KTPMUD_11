   M S B A M L   `   `   `  ���� ?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views      h25.Views.Vmain   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  #localclr-namespace:h25.Views  -   $��vmain�� 
  vmmain  � DataContext#  [   � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � Title$  �� � WindowStartupLocation$ CenterScreen=� � Icon$; 5C:\Users\Administrator\Desktop\Images_h25\default.ico��$	��700��$
��1200������  �� ImageSource$1 +C:\Users\Administrator\Desktop\Image\k1.jpg�� j� Stretch$ UniformToFill=�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *GetMainWindow+   CommandParameter ��  �� ElementName$ vmain��   �� *GetContentMainWindow+ �� $ ContentMainWindow��   �� *GetControlBar+ �� $ 
ControlBar��  $	 Closed��.
    �� *CloseMainWindow+.��� $��0q� � RowDefinitions �� $
��auto ��� .+�   h25.Views.ControlBar_z  -     Name$ 
ControlBar��$��0��$��0q�$��38�� J� Opacity$ 0Q�$y�Visible=�
 � Tag �� *Title+$ vmain��   $	 	MouseMove��.
    �� $ 
ControlBar�� �� *ShowControlBar+  $	 
MouseLeave��.
    �� *HideControlBar+ �� $ 
ControlBar��� $��1�� K� ZIndex$ 0��.+�� $��30q� � ColumnDefinitions �� �� ��  � 	Resources  �� 
TargetType  templatebtn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%K  &	       '��      7  �� " ��.R��� #��z���� " ��.���  � ��8   ��  � ��$ 10q���  � ��$ 0q���  �@�Cursor$
 Hand����  �@J�Opacity$
 0.02Q���  � ��$	 300����  � ��$	 300�� P�  �@J�IsMouseOver . . ���  �@J�Opacity$ 1Q���  �@�Cursor$
 Hand��.+��� -   $
��user��$��0������ $ /Images/shopping.png�� � ToolTip �� $*��$Đăng nhập dành cho khách hàng��   $	 Click��.
    �� *OpenLoginClient+�� -   $��OpenAdministrationWindow��$��1��
���   ����� *OpenWindowAdministration+���� $ ContentMainWindow�� �� $��Quản Lý Dịch Vụ������ $ /Images/setting_no.png���� -   $��information��$��2������ $ /Images/compass.png�� �� $��Thông tin phần mềm ���� -    ��Name$ ContentMainWindow��