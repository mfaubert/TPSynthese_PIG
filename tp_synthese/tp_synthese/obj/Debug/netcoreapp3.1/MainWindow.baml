   M S B A M L   `   `   `  ����F  Btp_synthese, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:tp_synthesetp_synthese  5   	       tp_synthese.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:tp_synthese     5   	     � Title$
  Wall��5	   	   $	��600��6   $	��800��6#   $��15(�6/    � DataContext 5   	   ��  �� RelativeSource �� *Self+ � 	Resources 5         	TextWhite �� 
TargetType �� Property �� Value  date��%  &	        &	 �     �� 5   
   " ��6"   .�5      ��  � ��
 �����6+   �� 5       � ��$ 20(�6)   �� 5       � ��$
 bold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 11(�6)   �� 5       � ��$ Italic$�6*   5      5      .��5   
   �  � ColumnDefinitions 5      �� 5      $	��220 �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��75 �6    �� 5       $��* �6    .+�5#      �� ���#3c63b25$      �� 5%      $��1��6   $��0��6)   ���#3c63b2.+�5&      �� $��130, 20, 0, 0q�6   #��[  6/   .��6R   WALL6X   5'      �� 5)   
   $��1��6   $��0��6"   ���#222222.+�5*      �� 
�������.��6'   Logged in as65   �� 5+      -   5        	 ��Name$	 LoggedUserCbox��5+      $
��10,4q�5,      ��5-      �� *	usersList+5.      �� 5/      ���#333333.+�50      �  51      �� 52      $��60 �6+   �� 53      $��* �6+   .+�55      �� -   5        
 ��Name$
 userProfilePic��55      $��0��64   6F   �� 56      -   5         ��Name$ userName��56       $��1��62   
�������6W   57      �� 58      
�������	Friends68   �� 59      -   5         ��Name$ FriendListBox��59      $
��10,2q�5:      $��60��5;      ��5<      �� *friendsList+5=      5>      �� 5@      
�������.��6'   View posts of66   �� 5A      $
��10,4q�6   .@�5B      �� .��6   Tom Richards6-   �� 5C      .��6   Elliot Hart6,   �� 5D      .��6   Rachel Chapman6/   5E      �� 5G      
�������.��6'   	Sort by60   	� 5H      
�������.��6-   Date (newest first)6B   	� 5I      
�������.��6-   Popularity (highest first)6I   �� 5K      -   5        $��10q�5K      ���#0073A6
�������.��6]   Marketplace5M      5N      �� 5P   
   $��1��6   $��1��6$   ���#333333.��5Q      � -   5         �Name$ WrapPanelPosts��5Q      $��Center=�60   5R      5S      5U      5V      