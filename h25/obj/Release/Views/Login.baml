   M S B A M L   `   `   `  ���� ?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views      h25.Views.Login   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  #localclr-namespace:h25.Views  -   $��login��   vmlogin  � DataContext#  [   � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � Title$ Login��$	��500��$	��400��.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *GetPasswordSignIn+	   CommandParameter	 �� 
 �� ElementName$
 passwordSignIn��   �� *GetPasswordSignUp+	 �� $
 passwordSignUp��   �� *GetRPasswordSignUp+	 �� $
 rpasswordSignUp��  $ Closed��.    �� *ShowMainWindow+.���  � RowDefinitions �� $
��auto ��� $��* �.+�� $��0�� � ColumnDefinitions �� �� $
��auto �.+�� -   $��g��$��0�����	#FF7A81CE   $ MouseLeftButtonDown��.    �� *btn.isWinDragMove+	 �� $
 login���� $��1�� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   '��       �� " ��.���  � ��$ 32����  � �� �	#FF7A81CE��  � ��$ 0q� P�  �@J�IsMouseOver . . ���  �@�Cursor$
 Hand����  � ��
 � ���.+��� -   $��close��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�$
��auto��$
��auto��   $ Click��.    �� *	btn.close+	 �� $
 close��#  MaterialDesignThemes.Wpf.Card  $��1��   UniformCornerRadius$ 0Q�$��0q�.��&   MaterialDesignThemes.Wpf.Flipper     FrontContent �  �� $
��auto ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�$��	0 20 0 20q�.��  $ AccountCircle=�$��0q�$��Center=�$	��140��$	��140���� $��1��
�������.+��� -    ��Name$ userNameSignIn��$��
30 10 30 5q�$��14(�)	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Tên đăng nhập�� % !MaterialDesignFloatingHintTextBox#��[ ���� *userNameSignIn+ �� UpdateSourceTrigger$ PropertyChanged=�G� -    G�Name$ passwordSignIn��$��14(� G� Password$ 22022000��$��
30 10 30 5q�$ Mật khẩu�� ) %MaterialDesignFloatingHintPasswordBox#��[ ��  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�   templateBtn �� 
TargetType �� CornerRadius��%:  '��       &	 �     �� " ��.���  � ��# �  ��  � ��$ 32����  � ��$	 150����  � ��
 �������  � ��$ 
5 20 10 10q� P�  �@J�IsMouseOver . . ���  � ��
 ������  �@�Cursor$
 Hand���� " ��.R��� $ 14��#��z��._��� $��Center=�$��Center=�.+��� $��Đăng Nhập������ *SignIn+���� $
 login���� $��
Đăng ký��    FlipCommand#��Z     $ Click��.    �� *ClearNewAdministration+�� 
���  ��$��0 10 0 0q�$	��200��$
��Wrap=�$��Center=�$��Center=����� *	warning+!   BackContent! �  �� $
��auto ��� .+�  $
 Dark=�$��0��.���� $ 
Horizontal=�.+��� #��Z  $��0 3 0 0q�$��Center=�$��50��$��Center=�$��60��$��0q���Z�    $ Click��.    �� *ClearNewAdministration+.��  $��Center=�$��25��$
��auto��$  ArrowLeftDropCircleOutline=��� $
��Back��$��14(�$��Center=��� 
�������$��1��.+��� $��
20 10 20 0q�$��14(�#��[ $ Tên Đăng nhập������ *newAdministration.userName+$ PropertyChanged=��� $��
20 10 20 0q�$��14(�#��[ $ Họ và Tên của bạn������ *newAdministration.fullName+$ PropertyChanged=��� $��
20 10 20 0q�$��14(�#��[ $ Email������ *newAdministration.gmail+$ PropertyChanged=�G� -   $��passwordSignUp��$��14(�$��
20 10 20 0q�#��[ $ Mật Khẩu�� Z� G� -   $��rpasswordSignUp��$��14(�$��
20 10 20 0q�#��[ $ Nhập lại mật khẩu���� $ 
Horizontal=�$��0 15 0 0q�$��Center=�$��Center=�   y��%:  '��       &	 �     �� " ��.���  � ��# �  ��  � ��$ 32����  � ��$	 150����  � ��
 �������  � ��$ 
5 10 10 10q� P�  �@J�IsMouseOver . . ���  � ��
 ������  �@�Cursor$
 Hand���� " ��.R��� $ 14��#��z��._��� $��Center=�$��Center=�.+��� $��Trở lại đăng Nhập��#��Z     $ Click��.    �� *ClearNewAdministration+�� $��Gửi đăng ký������ *SignUp+�� 
���  ��$��0 10 0 0q�$	��200��$
��Wrap=�$��Center=�$��Center=����� *	warning+