   M S B A M L   `   `   `  ���� ?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views      h25.Views.xcontrolBar   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  #localclr-namespace:h25.Views  -     >�Name$  xcontrol�� 
  vmmain � DataContext# [  .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ MouseLeftButtonDown��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *btn.dragMove+   CommandParameter ��  �� ElementName$ xcontrol��.��� ���	#FF6280BD$��40�� � ColumnDefinitions �� �� $
��auto �.+�� -   $��g1��$��0�� �� $
��auto ��� .+��� $��1��$��Center=�$��Center=�$
��Bold"�$��14(����� *Tag+$ xcontrol���� 	 �� Orientation$	 
Horizontal=�$��1��
 � 	Resources
  �� 
TargetType �� Property  btno �� Value �� Triggers P� Property P� Value �� 
TargetType��%X  '��       &	 �     �� " ��.���  � ��# �  ��  � �� �	#FF6280BD��  �@�Cursor$
 Hand����  � ��$ 0q���  � ��$ DemiBold"���  � ��$ SemiCondensed&� P�  �@J�IsMouseOver . . ���  � ��
 ������ " ��.R��� $��38��$��0q�#��z��$��38��._��� $��Center=�$��Center=�.+��� -    ��Name$
 btn1������ *btn.minsize+���� $
 btn1��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=��� -   $
��btn2������ *btn.maxsize+���� $
 btn2��.��  $ WindowMaximize=��� -   $
��btn3������ *	btn.close+���� $
 btn3��.��  $ Close=�