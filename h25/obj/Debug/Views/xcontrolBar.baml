   M S B A M L   `   `   `  ����?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views  5          h25.Views.xcontrolBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      #localclr-namespace:h25.Views  5      -   5          >�Name$  xcontrol��5	       
  vmmain � DataContext# [  5
      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ MouseLeftButtonDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *btn.dragMove+   CommandParameter 5      ��  �� ElementName$ xcontrol��5      .��5      � ���	#FF6280BD$��40��6"    � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   .+�5   
   � -   5        $��g1��5      $��0��6    5      �� 5      $
��auto �6#   �� 5      .+�5      �� $��1��6   $��Center=�5      $��Center=�5      $
��Bold"�5       $��14(�5!      ��5"      �� *Tag+$ xcontrol��5#      �� 5$   
   	 �� Orientation$	 
Horizontal=�5%      $��1��5&      
 � 	Resources
 5'       �� 
TargetType �� Property  btno �� Value �� Triggers P� Property P� Value �� 
TargetType��%T  '��       &	 �    �� 5(      " ��6   .�5)      ��  � ��# �  61   �� 5*       � �� �	#FF6280BD63   �� 5+       �@�Cursor$
 Hand��6/   �� 5,       � ��$ 0q�6/   �� 5-       � ��$ DemiBold"�63   �� 5.       � ��$ SemiCondensed&�64    5/      P� 50       �@J�IsMouseOver . . �51      ��  � ��
 ����6;   52      54      �� 55      " ��6/   .R�56      �� $��38��57      $��0q�58      #��z��59      $��38��5:      ._�5;      �� $��Center=�5<      $��Center=�5=      5>      5?      5@      .+�5Q      �� -   5         ��Name$
 btn1��5R      ��5Q      �� *btn.minsize+��5S      �� $
 btn1��.��5T      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6*   5U      �� 5V      -   5        $
��btn2��5W      ��5V      �� *btn.maxsize+��5X      �� $
 btn2��.��5Y        $ WindowMaximize=�6*   5Z      �� 5[      -   5        $
��btn3��5\      ��5[      �� *	btn.close+��5]      �� $
 btn3��.��5^        $ Close=�6*   5_      5`      5a      5b      