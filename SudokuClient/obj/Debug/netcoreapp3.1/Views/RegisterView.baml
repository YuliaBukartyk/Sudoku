   M S B A M L   `   `   `  ����G  CSudokuClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SudokuClient.ViewsSudokuClient.Views  5      A%clr-namespace:SudokuClient.ComponentsSudokuClient.Components  6=   %    SudokuClient.Views.RegisterView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SudokuClient.Views     5      <
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
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      �  J� RenderTransformOrigin$ 0.311,0.175&�6   .+�5C   
   �� $��Center=�6   $��	0,160,0,0q�6/    �� TextWrapping$
 Wrap=�6B   $	��Top=�6V   $	��214��6n   $��38��6z   $��26(�5D      ���	#FF64CCF1���	#FFF6F6F6
���������5C   �   �� *
Username+5G      1   +SudokuClient.Components.BindablePasswordBox  5I   
   $��Center=�6)   $	��Top=�6F   $	��214��6^   $��38��6j   $��	0,256,0,0q�5K         Password 5J      �� *
Password+ �� Mode$ TwoWay=�5K        5M   
   $��Center=�6)   $	��Top=�6F   $	��214��6^   $��38��6j   $��	0,358,0,0q�5O       5N      �� *VerificationPassword+$ TwoWay=�5O      �� 5Q   
   #��� 
 6   $��Submit��6`   $
��Left=�6q   $��170,480,0,0q�6�   $	��Top=�6�   $��31��6�   $��95��6�   ���	#FF64CCF1
�������$��Arial)�5T      $��20(�5U      ��5Q   >   �� *SubmitCommand+5U      �� 5W   
   #��� 
 6   $
��Back��6e   $
��Left=�6t   $��	18,17,0,0q�6�   $	��Top=�6�   $��37��6�   $��69��6�   
����� �
�������$��Arial)�5Z      $��20(�5[      ��5W   >   �� *BackToEntryCommand+5[      �� 5\   
   $
��Left=�6   $��118,138,0,0q�6/   $��Enter your name: ��6D   $
��Wrap=�6]   $	��Top=�6q   $��Arial)�5]      $��15(�5^      
�������5_      �� 5a   
   $
��Left=�6   $��118,234,0,0q�6/   $��Enter your password: ��6D   $
��Wrap=�6a   $	��Top=�6u   $��Arial)�5b      $��15(�5c      
�������5d      �� 5f   
   $
��Left=�6   $��119,336,0,0q�6/   $��Verify your password: ��6D   $
��Wrap=�6b   $	��Top=�6v   $��Arial)�5g      $��15(�5h      
�������5i      5o      5p      