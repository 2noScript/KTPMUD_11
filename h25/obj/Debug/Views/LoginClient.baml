   M S B A M L   `   `   `  ����?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views  5	   	       h25.Views.LoginClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   #localclr-namespace:h25.Views  5	   	   -   5        $��loginclient��5   	      vmloginclient  � DataContext#  [  5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   $	��360��5   	   $	��400��6    � Title$ LoginClient��5   	   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Closed��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *CloseLoginClient+5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   
 � ColumnDefinitions
 5      �� 5      �� 5      $
��auto �6#   .+�5!      � $��0��6   ���	#FF7A81CE 5"        5#      $ MouseLeftButtonDown��6%   . 5$         60   �� *btn.isWinDragMove+   CommandParameter 5%   0   ��  �� ElementName$ loginclient��5&      5(      �� 5)      $��1��6    � 	Resources 5*       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%6  '��       �� 5+      " ��6   .�5,      ��  � ��$ 32��63   �� 5-       � �� �	#FF7A81CE67   �� 5.       � ��$ 0q�6<    5/      P� 50       �@J�IsMouseOver . . �51   "   ��  �@�Cursor$
 Hand��6;   �� 52   "    � ��
 � ���6?   53      56      57      .+�58      �� -   5        $��x��58   7   ��6   �� *	btn.close+��59      �� $ x��.��5:      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $
��auto��6;   $
��auto��6I   5;      5<      5=      � 5>   
   $��1��6   	 5?      �� 5@      $
��auto �6    �� 5A      .+�5D      �� $��1��6   
�������.+�5E      �� $��
30 40 30 5q�5F   '   $��14(�5G   '   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập��5H   &    % !MaterialDesignFloatingHintTextBox#��[ 5I   '   G� 5J      $��14(�5L   '   $��
30 10 30 5q�5M   '   $ Mật khẩu��5N   '    ) %MaterialDesignFloatingHintPasswordBox#��[ 5O   '   �� 5P       �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Center=�5Q   !    5R        x �� 
TargetType �� CornerRadius��%%  '��       &	 w    �� 5S      " ��6    .�5T      ��  � ��# �  69   �� 5U       � ��$ 32��67   �� 5V       � ��$	 150��66   �� 5W       � ��
 �����6;   �� 5X       � ��$ 10 25 10 10q�67    5Y      P� 5Z   "    �@J�IsMouseOver . . �5[   &   ��  � ��
 ����6C   �� 5\   &    �@�Cursor$
 Hand��6?   5]   #   5_      �� 5`      " ��6*   .R�5a      �� $ 14��5b   -   #��z��5c   -   ._�5d   "   �� $��Center=�5e   1   $��Center=�5f   1   5g      5h      5i      .+�5j      �� $��Đăng Nhập��6   �� 5k      $��Thoát��6   5l      �� 5m      
���  ��$��0 10 0 0q�5o   (   $	��200��5p   (   $
��Wrap=�5q   (   $��Center=�5r   (   $��Center=�5s   (   ��5m      �� *	warning+5s   (   5t      5u      5v      5w      