   M S B A M L   `   `   `  ����?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views  5
   	       h25.Views.VItemz   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   #localclr-namespace:h25.Views  5
   	   -   5        $��vitemz��5	   	      vmitemz  � DataContext#  [  5   	   $��1q�5   	   ���	#FF7A81CE � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ itemz��5   	   $	��450��6   $	��800��6$    � 	Resources 5       �� 
TargetType  	stylerbtn �� Property �� Value	 �� Triggers
 P� Property P� Value��%6  &	       �� 5   
   " ��6   .�5      ��  � ��$ 32��6'   �� 5       � �� �	#FF7A81CE6+   �� 5       � ��$ 0q�60   	 5      P� 5      
 �@J�IsMouseOver . . �5      ��  �@�Cursor$
 Hand��6/   �� 5       � ��
 � ���63   5      5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $��35 �6   �� 5#      $	��300 �6   �� 5$      $��* �6   .+�5&   
   � $��0��6    � ColumnDefinitions 5'      �� 5(      $��* �6#   �� 5)      $
��auto �6#   .+�5+      � ���	#FF7A81CE.  (System.Windows.Interactivity.Interaction   Triggers 5,      /  )System.Windows.Interactivity.EventTrigger  5-         	EventName$ MouseLeftButtonDown��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5.      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *btn.isWinDragMove+   CommandParameter 5/   0   ��  �� ElementName$ vitemz��50      52      �� 53      -   5         ��Name$ close��55      $��1��54      #���  56      $��35��59      $��35��5:      $��Right=�5;      ��57      �� *	btn.close+��58      �� $ close��.��5<      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�6*   5=      5>      � 5A   
   $��1��6    5B      �� 5C      $
��auto �6#   �� 5D      $��* �6$   .+�5G      �� ���	#FF7A81CE$��0 1 0 1q�5I       �� Padding$ 0q�5J      $	��298��5K      $��0��5L      ._�5M      �� $	��300��5N      $
��Left=�5O      ��5M      �� *	PathImage+ �� UpdateSourceTrigger$ PropertyChanged=�5O      5P      �� 5Q      $��1��6   $��1 1 0 1q�6%   ���	#FF7A81CE._�5R      � .+�5S      )  #MaterialDesignThemes.Wpf.DrawerHost  .��5T      �� .+�5U      �� #���  5V   !   $��Thông tin sản Phẩm��5W   !   $	��500��5X   !   $
��Left=�5Y   %   "  System.Windows.Controls.Dock   Right#��Z 5Z   "      OpenDrawerCommand#��Z 5[   !   �� 5\       �� Orientation$ Vertical=�6)   $��0 10 0 0q�5^   )   .+�5_   "   �� $��	120 0 0 0q�5a   ,   $��DemiBold"�5b   ,   $��14(�5c   ,   ��5_   ,   �� *Name+5c   ,   �� 5d   "   $��14(�5e   ,   $��DemiBold"�5f   ,   $��	140 4 0 0q�5g   ,   ��5d   ,   �� *Price+5g   ,   5h      � 5i      $	��200��5k   #   .+�5l   "   �� $��0 15 0 0q�6-   .+�5m   &   �� $��	30 10 0 0q�5n   )   $
��Left=�5o   %   $	��100��5p   %   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Số Lượng��5q   %    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 5s   %   .@�5t   *   ��  �� 
IsSelected . .��6J   15v   +   �� 5w   *   .��67   25y   +   �� 5z   *   .��67   35|   +   �� 5}   *   .��67   45   +   5�   '   �� 5�   &   $��16(�5�   -   $��DemiBold"�5�   -   $��	30 10 0 0q�5�   -   $��Tổng ��5�   -   �� 5�   &   $��
50 10 0 10q�5�   -   $��DemiBold"�5�   -   $��60000000 vnđ��5�   -   �� 5�   &   $��Đặt món ăn��5�   -   $��	40 10 0 0q�5�   -   
������$
��Left=�5�   -   $��90��5�   -   $��30��5�   -   #���  5�   -   5�   '   5�   #   �� 5�   "   $��0 15 0 0q�6-   .+�5�   &   �� $��
160 10 0 0q�5�   -    ! MaterialDesignOutlinedTextBox#��[ 5�   )   $	��Top=�5�   )    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5�   )   $	��300��5�   )   $	��150��5�   ,   $ 
Tin nhắn��5�   )   5�   #   5�      5�          RightDrawerContent  5�      �� 5�      $	��500��6)   .+�5�   "   �� #���  5�   %   !   CloseDrawerCommand#��Z! 5�   &   #��Z 5�   )   $
��Back��5�   %   �� 5�   "   $��hello��6,   5�      5�      5�      5�      5�      � 5�   
   $��2��6    5�      �� 5�      $
��auto �6#   �� 5�      .+�5�      �� $ Vertical=�6   $	��100��5�      $��10 0 0 0q�5�      .+�5�      �� $��	0 10 0 0 q�6   �� 5�      $ 
Horizontal=�6!   .+�5�        $
 Star=�62   �� 5�      $	��100��6$   $��15 0 0 0q�6/   5�      5�      �� 5�      �� 5�      $ 
Horizontal=�6!   .+�5�        $
 Star=�62   �� 5�      $	��100��6$   $��15 0 0 0q�6/   5�      5�      �� 5�      �� 5�      $ 
Horizontal=�6!   .+�5�        $
 Star=�62   �� 5�      $	��100��6$   $��15 0 0 0q�6/   5�      5�      �� 5�      �� 5�      $ 
Horizontal=�6!   .+�5�        $
 Star=�62   �� 5�      $	��100��6$   $��15 0 0 0q�6/   5�      5�      �� 5�      �� 5�      $ 
Horizontal=�6!   .+�5�        $
 Star=�62   �� 5�      $	��100��6$   $��15 0 0 0q�6/   5�      5�      5�      5�      5�      5�      