   M S B A M L   `   `   `  ���� ?  ;leaf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:h25.Views	h25.Views      h25.Views.Add   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  #localclr-namespace:h25.Views  -   $	��add�� 	  vmadd  � DataContext#  [   � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Title$	 add��$	��700��$	��900��.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Closed��  $ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *DeletePathImageItem+   �� *LoadDefaultListItem+   �� *GetComboBox+	   CommandParameter	 �� 
 �� ElementName$
 comboBoxCheck�� � 	Resources  �� 
TargetType  	stylerbtn �� Property �� Value �� Triggers P� Property P� Value��%�   &	       �� " ��.���  � ��$ 32����  � �� �	#FF7A81CE��  � ��$ 0q� P�  �@J�IsMouseOver . . ���  �@�Cursor$
 Hand����  � ��
 � ���.���  � RowDefinitions �� $
��auto ��� .+�� $��0��.+�� $��0�� � ColumnDefinitions �� $��* ��� $
��auto �.+�� $��0�����	#FF7A81CE   $ MouseLeftButtonDown��.    �� *btn.isWinDragMove+	 �� $	
 add���� -    ��Name$ close��$��1��#���  $��35��$��35��$��Right=����� *	btn.close+���� $
 close��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�#  MaterialDesignThemes.Wpf.Card  $��1��.���  �� $	��350 ��� .+�� $��0�� �� $
��auto ��� .+�� .+��� .+��� -   $��imageDisplay��$	��Top=�$��	10 10 0 0q�$	��200��$	��200������ *itemDisplay.pathImage+�� $(��"Sản Phẩm đang được chọn��$��14(�$��
20 10 0 0 q�$��DemiBold"��� $��	10 15 0 0q� �� Orientation$ 
Horizontal=�.+��� $��ID : ��$��10 0 0 0q�$��DemiBold"��� $��DemiBold"����� *itemDisplay.id+�� $ 
Horizontal=�$��10 5 0 0q�.+��� $��Tên  : ��$��10 0 0 0q�$��DemiBold"��� $��DemiBold"����� *itemDisplay.namez+�� $ 
Horizontal=�$��10 5 0 0q�.+��� $��Giá(vnđ) : ��$��10 0 0 0q�$��DemiBold"��� $��DemiBold"����� *itemDisplay.price+�� $ 
Horizontal=�$��10 5 0 0q�.+��� $��Giảm giá (%) : ��$��10 0 0 0q�$��DemiBold"��� $��DemiBold"����� *itemDisplay.sale+� $��1��.+�)  #MaterialDesignThemes.Wpf.DrawerHost  $��1��$	��650��
����� �$��Right=�.���  �� $
��auto ��� $
��auto ��� .+��� $ 
Horizontal=�.+��� -   $��comboBoxCheck��$	��138��$��	31 30 0 0q�$
��Left=�.@��� $��Đồ mặn�� �� 
IsSelected . �� $��Đồ ngọt���� $��Đồ uống��   $ SelectionChanged��.    �� *SelectDispalayListItem+�� $	��300��$��20 13.5 0 0q�$��40��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm�� % !MaterialDesignFloatingHintTextBox#��[ ���� *
SearchItem+ �� UpdateSourceTrigger$ PropertyChanged=�.��   $ TextChanged��.    �� *SearchOfNameItem+.���� $ 
Horizontal=�$��1��$��	10 14 0 0q�.+��� #���     OpenDrawerCommand#��Z "	  System.Windows.Controls.Dock 	  Right#��Z $��20 0 0 0q�$	��140��$��Thêm sản phẩm mới��   $ Click��.    �� *OpenCreateItem+�� #���  #��Z 
 	  Top#��Z $��20 0 0 0q�$	��140��$��Chỉnh sử sản Phẩm��   .    �� *OpenCreateItem+�� #���  $��20 0 0 0q�$	��140��$
��Xóa������ *DeleteOneItem+� $��2�� �� $
��414* ��� $
��235* �.+��� $��30,10,-0.4,-0.2q�$��DemiBold"�$��16(�$��Thông tin sản phẩm��$��2���� $
��Left=�$��30,34,0,14.8q�$��14(�$��DemiBold"�$	��550��$	��200��$
��Wrap=�
�������  MaterialDesignTextBlock#��[ $��2������ *itemDisplay.information+   RightDrawerContent � -   $��NewSp��$	��650�� �� $
��auto ��� $��* �.+��� $
��back��   CloseDrawerCommand#��Z #��Z #���     $ Click��.    �� *CloseViewCreateItem+� $��1��.+��  �� $
��auto ��� � $��0�� �� $
��auto ��� $��* �.+��� $��0��$��15 0 0 0q�.+��� $��0 5 0 0q�$	��350��$��13(�$ Tên sản Phẩm��#��[ ���� *newItemz.namez+$ PropertyChanged=��� $��0 5 0 0q�$	��350��$��13(�$ Giá tiền (VNĐ)��#��[ ���� *newItemz.price+�� $��0 5 0 0q�$	��350��$��13(�$ Giảm Giá (%)��#��[ ���� *newItemz.sale+�� $	��350��  MaterialDesignFilledTextBox#��[ $��0 5 0 0q�$	��100�� �� AcceptsReturn .   �� TextWrapping$
  Wrap=�"! �� VerticalScrollBarVisibility$
! Auto=�$ Thông tin sản phẩm������ *newItemz.information+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #���  $��0 5 0 0q�$��30��$��Chọn ảnh��$	��160������ *OpenDialogImageCreateItem+�� #���  $��30 5 0 0q�$��30��$��Thêm��$	��160������ *CommandCreateItem+� $��1��.+��� -   $��imageCreate��$��Center=�$��0 10 0 0q�$	��Top=�$	��160��$	��160������ *newItemz.pathImage+�� $��Bottom=�$	��200��$��Center=�$��20 0 -10 40q�$��80��
���  ��$��DemiBold"�$
��Wrap=����� *	warning+"   TopDrawerContent" � -   # �Name$# editSp��$	��650��$	��350�� �� $
��auto ��� .+��� $
��back��$��0��#��Z #��Z #���     $ Click��� $��1��.+��� .+��� $��0 5 0 0q�$	��300��$��13(�$ Tên sản Phẩm��#��[ ���� *itemDisplay.namez+�� $��0 5 0 0q�$	��300��$��13(�$ Giá tiền (VNĐ)��#��[ ���� *itemDisplay.price+�� $��0 5 0 0q�$	��300��$��13(�$ Giảm Giá (%)��#��[ ���� *itemDisplay.sale+�� $	��300��#��[ $��0 5 0 0q�$��90�� . $
  Wrap=�$
! Auto=�$ Thôn tin sản phẩm������ *itemDisplay.information+$ 	LostFocus=��� $ 
Horizontal=�$��Center=�$��0 10 0 0q�.+��� #���  $��0 0 0 0q�$��30��$��Chọn ảnh mới��$	��140������ *OpenDialogImageEditItem+�� #���  $��20 0 0 0q�$��30��$��cập nhật��$	��140������ *UpdateDataOfEditItem+���� $
 	listItemz���� $��DemiBold"�$��0 8 0 0q�$��Center=�$
��Wrap=�
���  ��$	��280������ *	warning+� $��1��$��0 10 0 0q� �� $
��auto ��� .+��� $ 
Horizontal=�$��0��.+��� $��ID��$��15 0 0 0q�$��DemiBold"�$��80���� $��Tên sản Phẩm ��$��-5 0 0 0q�$��DemiBold"�$	��280���� $��Giá (VNĐ)��$��5 0 0 0q�$��DemiBold"�$��90���� $��Thời gian thêm��$��30 0 0 0q�$��DemiBold"�$	��120���� $��Thời gian sửa��$��38 0 0 0q�$��DemiBold"�$	��120��� $��1��.+��� -   $ ��Name$$ 	listItemz��$	��900��$
��Left=����� *
ListItem+   $ MouseDoubleClick��.    �� *
SelectItem+	 �� $
 	listItemz�� ��%Y   '��       �� " ��.���  � ��$
 Left=���  �@�OverridesDefaultStyle . % �� View% �� .P��� $��ID��& �� Width$& 80��' �� DisplayMemberBinding' �� *id+�� $��Tên sản phẩm ��$	& 280��' �� *namez+�� $��Giá Tiền ��$	& 120��' �� *price+�� $��Thời gian thêm ��$	& 160��' �� *
timeLine+�� $��Thời gian sửa ��$	& 160��' �� *	repaiTime+