   M S B A M L   `   `   `  ����?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views  5
   	       h25.Views.Vmain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   #localclr-namespace:h25.Views  5
   	   -   5        $��vmain��5   G    
  vmmain  � DataContext#  [  5	   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$  ��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$; 5C:\Users\Administrator\Desktop\Images_h25\default.ico��5   	   $	��700��5   	   $
��1200��6   ��5      �� 5   
    �� ImageSource$1 +C:\Users\Administrator\Desktop\Image\k1.jpg��6    j� Stretch$ UniformToFill=�6O   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *GetMainWindow+   CommandParameter 5   $   ��  �� ElementName$ vmain��  5       6$   �� *GetContentMainWindow+ 5   $   �� $ ContentMainWindow��  5       6$   �� *GetControlBar+ 5   $   �� $ 
ControlBar��5        5    
   $	 Closed��6   .
 5!         6$   �� *CloseMainWindow+5"      .��5&      � $��0q�6    � RowDefinitions 5'   
   �� 5(      $
��auto �6   �� 5)      .+�5,   
      h25.Views.ControlBar_z  -   5          Name$ 
ControlBar��5-      $��0��5,      $��0q�5.      $��38��5/       J� Opacity$ 0Q�50      $y�Visible=�51      
 � Tag 52      �� *Title+$ vmain�� 53        54      $	 	MouseMove��6!   .
 55         56      �� $ 
ControlBar�� 57      �� *ShowControlBar+58        59      $	 
MouseLeave��6!   .
 5:         6,   �� *HideControlBar+ 5;   -   �� $ 
ControlBar��5<      5>      � 5A   
   $��1��6    K� ZIndex$ 0��6   .+�5D      � $��30q�6    � ColumnDefinitions 5E      �� 5F      �� 5G      �� 5H       � 	Resources 5J       �� 
TargetType  templatebtn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%)  &	       '�� G     7  �� 5K      " ��6&   .R�5L      �� #��z��6"   5M      5N      �� 5O      " ��6   .�5P      ��  � ��8   65   �� 5Q       � ��$ 10q�63   �� 5R       � ��$ 0q�6<   �� 5S       �@�Cursor$
 Hand��63   �� 5T       �@J�Opacity$
 0.02Q�64   �� 5U       � ��$	 300��62   �� 5V       � ��$	 300��63    5W      P� 5X       �@J�IsMouseOver . . �5Y   "   ��  �@J�Opacity$ 1Q�6<   �� 5Z   "    �@�Cursor$
 Hand��6;   5[      5]      5^      .+�5`      �� -   5        $
��user��5`   )   $��0��6   ��5a      �� 5b      $ /Images/shopping.png��6%    � ToolTip 5d      �� 5e      $*��$Đăng nhập dành cho khách hàng��6$    5g        5h      $	 Click��6)   .
 5i         64   �� *OpenLoginClient+5j      5l      �� 5n      -   5        $��OpenAdministrationWindow��5n   )   $��1��6   
���   ���5o      �� *OpenWindowAdministration+��5p      �� $ ContentMainWindow�� 5r      �� 5s      $��Quản Lý Dịch Vụ��6$   ��5u      �� 5v      $ /Images/setting_no.png��6%   5x      �� 5z      -   5        $��information��5z   )   $��2��6   ��5{      �� 5|      $ /Images/compass.png��6%    5~      �� 5      $��Thông tin phần mềm ��6$   5�      5�      �� 5�      -   5         ��Name$ ContentMainWindow��5�      5�      5�      5�      