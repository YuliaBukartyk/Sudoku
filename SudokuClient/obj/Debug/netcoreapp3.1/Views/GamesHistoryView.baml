   M S B A M L   `   `   `  ����G  CSudokuClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SudokuClient.ViewsSudokuClient.Views  5      )    #SudokuClient.Views.GamesHistoryView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SudokuClient.Views     5      
�������  � 	Resources  5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButtonStyle �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6+   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 0q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $ border��6!   $	 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5)      �� $
 contentPresenter��6/   $|�False��6J   #��z��6\   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      � .+�5C   
   �� $��18,89,24,89q�6   $��0q�6N   ��6(   �� *PreviousGames+��5D      �� 5E      .R�5F      ��  �� Orientation$ 
Horizontal=�6!   .+�5G      �� $��Level: ��6$   $��Center=�63   $��15(�6N   $��Arial)�5H   $   $
��Bold"�5I   $   �� 5J      $��Center=�6@   $��12(�6[   $��Arial)�5K   $   ��5J   $   ��  �� Path$ Level�5K   $   �� 5L      $	��   ��6$   $��Center=�6/   �� 5M      $��
Duration: ��6$   $��15(�66   $��Center=�6D   $��Arial)�6_   $
��Bold"�6r   �� 5N      $��Center=�6C   $��12(�6^   $��Arial)�6l   ��6$   �� $ Duration�6l   �� 5O      $	��   ��6$   $��Center=�6/   �� 5P      $��Result: ��6$   $��15(�64   $��Center=�6B   $��Arial)�6]   $
��Bold"�6p   �� 5Q      $��Center=�6A   $��12(�6\   $��Arial)�6j   ��6$   �� $ Result�6j   5R      5S      5U      �� 5V   
   #��� 
 6   $
��Back��6d   $
��Left=�6s   $��	18,10,0,0q�6�   $	��Top=�6�   $��37��6�   $��69��6�   
����� �
�������$��Arial)�5Y      $��20(�5Z      ��5V   >   �� *BackToMenuCommand+5Z      5^      5_      