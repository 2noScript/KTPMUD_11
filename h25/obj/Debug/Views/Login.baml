   M S B A M L   `   `   `  ����?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views  5   	       h25.Views.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   #localclr-namespace:h25.Views  5   	   -   5        $��login��5	   	      vmlogin  � DataContext#  [  5   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Login��5   	   $	��500��6   $	��400��6$   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *GetPasswordSignIn+	   CommandParameter	 5   $   �� 
 �� ElementName$
 passwordSignIn��  5       6$   �� *GetPasswordSignUp+	 5   $   �� $
 passwordSignUp��  5       6$   �� *GetRPasswordSignUp+	 5   $   �� $
 rpasswordSignUp��5        5   
   $ Closed��6   . 5         6$   �� *ShowMainWindow+5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5       $��* �6   .+�5"   
   � $��0��6    � ColumnDefinitions 5#      �� 5$      �� 5%      $
��auto �6#   .+�5'      � -   5        $��g��5'   :   $��0��6   ���	#FF7A81CE 5(        5)      $ MouseLeftButtonDown��6%   . 5*         60   �� *btn.isWinDragMove+	 5+   0   �� $
 login��5,      5.      �� 5/      $��1��6    � 	Resources 50       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%6  '��       �� 51      " ��6   .�52      ��  � ��$ 32��63   �� 53       � �� �	#FF7A81CE67   �� 54       � ��$ 0q�6<    55      P� 56       �@J�IsMouseOver . . �57   "   ��  �@�Cursor$
 Hand��6;   �� 58   "    � ��
 � ���6?   59      5;      5<      .+�5=      �� -   5        $��close��5=      .��5>      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $
��auto��6;   $
��auto��6I    5?        5@      $ Click��6)   . 5B         64   �� *	btn.close+	 5C   4   �� $
 close��5D      5F      5G      5H      #  MaterialDesignThemes.Wpf.Card  5J   
   $��1��6      UniformCornerRadius$ 0Q�5K      $��0q�5L      .��5M      &   MaterialDesignThemes.Wpf.Flipper     FrontContent 5O      � 5P       5Q      �� 5R      $
��auto �6,   �� 5S      .+�5U      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�63   $��	0 20 0 20q�6G   .��5V        $ AccountCircle=�66   $��0q�5W   6   $��Center=�5X   6   $	��140��5Y   6   $	��140��5Z   6   5[      �� 5\      $��1��6%   
�������.+�5]      �� -   5         ��Name$ userNameSignIn��5]   )   $��
30 10 30 5q�5_   '   $��14(�5`   '   )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Tên đăng nhập��5a   &    % !MaterialDesignFloatingHintTextBox#��[ 5b   '   ��5^   )   �� *userNameSignIn+ �� UpdateSourceTrigger$ PropertyChanged=�5b   '   G� 5c      -   5         G�Name$ passwordSignIn��5d   !   $��14(�5e   '    G� Password$ 22022000��5f   '   $��
30 10 30 5q�5g   '   $ Mật khẩu��5h   '    ) %MaterialDesignFloatingHintPasswordBox#��[ 5i   '   5j      �� 5k       �� Orientation$ 
Horizontal=�6)   $��Center=�6B   $��Center=�5l   !    5m   "     templateBtn �� 
TargetType �� CornerRadius��%$  '��       &	 v    �� 5n   &   " ��6,   .�5o   *   ��  � ��# �  6E   �� 5p   *    � ��$ 32��6C   �� 5q   *    � ��$	 150��6B   �� 5r   *    � ��
 �����6G   �� 5s   *    � ��$ 
5 20 10 10q�6C    5t   *   P� 5u   .    �@J�IsMouseOver . . �5v   2   ��  � ��
 ����6O   �� 5w   2    �@�Cursor$
 Hand��6K   5x   /   5z   '   �� 5{   &   " ��66   .R�5|   *   �� $ 14��5}   -   #��z��5~   -   ._�5   .   �� $��Center=�5�   1   $��Center=�5�   1   5�   +   5�   '   5�   #   .+�5�   "   �� $��Đăng Nhập��6)   ��6=   �� *SignIn+��5�   )   �� $
 login���� 5�   "   $��
Đăng ký��6)       FlipCommand#��Z  6;    5�   &     5�   *   $ Click��69   . 5�   .      6D   �� *ClearNewAdministration+5�   +   5�   #   5�      �� 5�      
���  ��$��0 10 0 0q�5�   (   $	��200��5�   (   $
��Wrap=�5�   (   $��Center=�5�   (   $��Center=�5�   (   ��5�   (   �� *	warning+5�   (   5�      5�      !   BackContent! 5�      � 5�       5�      �� 5�      $
��auto �6,   �� 5�      .+�5�        $
 Dark=�63   $��0��6?   .��5�      �� $ 
Horizontal=�5�   !   .+�5�   "   �� #��Z  5�   )   $��0 3 0 0q�5�   )   $��Center=�5�   )   $��50��5�   )   $��Center=�5�   )   $��60��5�   )   $��0q�5�   )   ��5�   )   Z�  5�   &     5�   *   $ Click��69   . 5�   .      6D   �� *ClearNewAdministration+5�   +   .��5�   &     $��Center=�5�   )   $��25��5�   -   $
��auto��5�   -   $  ArrowLeftDropCircleOutline=�5�   -   5�   '   5�   #   �� 5�   "   $
��Back��6,   $��14(�5�   ,   $��Center=�5�   ,   5�      5�      �� 5�      
�������$��1��5�   %   .+�5�      �� $��
20 10 20 0q�5�   !   $��14(�5�   !   #��[ 5�   !   $ Tên Đăng nhập��5�   !   ��5�   !   �� *newAdministration.userName+$ PropertyChanged=�5�   !   �� 5�      $��
20 10 20 0q�5�   !   $��14(�5�   !   #��[ 5�   !   $ Họ và Tên của bạn��5�   !   ��5�   !   �� *newAdministration.fullName+$ PropertyChanged=�5�   !   �� 5�      $��
20 10 20 0q�5�   !   $��14(�5�   !   #��[ 5�   !   $ Email��5�   !   ��5�   !   �� *newAdministration.gmail+$ PropertyChanged=�5�   !   G� 5�      -   5        $��passwordSignUp��5�   !   $��14(�5�   !   $��
20 10 20 0q�5�   !   #��[ 5�   !   $ Mật Khẩu��5�   !    5�   !   Z� 5�   !   G� 5�      -   5        $��rpasswordSignUp��5�   !   $��14(�5�   !   $��
20 10 20 0q�5�   !   #��[ 5�   !   $ Nhập lại mật khẩu��5�   !   �� 5�      $ 
Horizontal=�6)   $��0 15 0 0q�5�   )   $��Center=�5�   )   $��Center=�5�   !    5�   "     y��%$  '��       &	 v    �� 5�   &   " ��6,   .�5�   *   ��  � ��# �  6E   �� 5�   *    � ��$ 32��6C   �� 5�   *    � ��$	 150��6B   �� 5�   *    � ��
 �����6G   �� 5�   *    � ��$ 
5 10 10 10q�6C    5�   *   P� 5�   .    �@J�IsMouseOver . . �5�   2   ��  � ��
 ����6O   �� 5�   2    �@�Cursor$
 Hand��6K   5�   /   5�   '   �� 5�   &   " ��66   .R�5�   *   �� $ 14��5�   -   #��z��5�   -   ._�5�   .   �� $��Center=�5�   1   $��Center=�5�   1   5�   +   5�   '   5�   #   .+�5�   "   �� $��Trở lại đăng Nhập��6)   #��Z  6E    5�   &     5�   *   $ Click��69   . 5�   .      6D   �� *ClearNewAdministration+5�   +   5  #   �� 5  "   $��Gửi đăng ký��6)   ��6?   �� *SignUp+5     �� 5     
���  ��$��0 10 0 0q�5  (   $	��200��5  (   $
��Wrap=�5  (   $��Center=�5	  (   $��Center=�5
  (   ��5  (   �� *	warning+5
  (   5     5     5     5     5     5     