   M S B A M L   `   `   `  ����G  CSudokuClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SudokuClient.ViewsSudokuClient.Views  5      A%clr-namespace:SudokuClient.ComponentsSudokuClient.Components  6=   "    SudokuClient.Views.LogInView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SudokuClient.Views     5      <
components%clr-namespace:SudokuClient.Components     6=   
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
 contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      � .+�5D   
   �� $��Center=�6   $��	0,209,0,0q�6/    �� TextWrapping$
 Wrap=�6B   $	��Top=�6V   $	��214��6n   $��38��6z   $��26(�5E      ���	#FF64CCF1���	#FFF6F6F6
���������5I      �� *Name+�� 5K   
   #��� 
 6   $��Log in��6e   $��Center=�6v   $	��Top=�6�   $��50��6�   $	��100��6�   ���	#FF64CCF1
�������$��Arial)�5N      $��20(�5O      $��	0,416,0,0q�6   ��5K   >   �� *LogedToGameCommand+5O      1   +SudokuClient.Components.BindablePasswordBox  5Q   
   $��Center=�6)   $	��Top=�6G   $	��214��6_   $��38��6k   $��	0,306,0,0q�5S         Password 5R      �� *
Password+ �� Mode$ TwoWay=�5S      �� 5V   
   #��� 
 6   $
��Back��6e   $
��Left=�6t   $��	18,10,0,0q�6�   $	��Top=�6�   $��37��6�   $��69��6�   
����� �
�������$��Arial)�5Y      $��20(�5Z      ��5V   >   �� *BackToEntryCommand+5Z      �� 5\   
   $
��Left=�6   $��118,187,0,0q�6/   $��Enter your name: ��6D   $
��Wrap=�6]   $	��Top=�6q   $��Arial)�5]      $��15(�5^      
�������5_      �� 5a   
   $
��Left=�6   $��118,284,0,0q�6/   $��Enter your password: ��6D   $
��Wrap=�6a   $	��Top=�6u   $��Arial)�5b      $��15(�5c      
�������5d      5g      5h      