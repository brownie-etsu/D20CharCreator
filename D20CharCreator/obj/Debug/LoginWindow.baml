   M S B A M L   `   `   `  ����I  ED20CharCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:D20CharCreatorD20CharCreator  5   	        D20CharCreator.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:D20CharCreator     5   	     � Title$  Login��5   	    � 
ResizeMode$ CanMinimize=�6   $��399.3��60   $	��494��6>   $��3,0,3,3q�6K   $��Center=�6e   $��Center=�6�    � WindowStartupLocation$ CenterScreen=�6�    � Icon$ Resources/d20.ico��6�   ���	#FF720000.��5	      �  J� RenderTransformOrigin$	 0,0&�6    � ColumnDefinitions 5
   
   �� 5      ��5   
   �� 5       �� ImageSource$ Resources/parchment.jpg��6   .+�5   
   �� -   5         ��Name$ UsernameTextBlock��5      $��20,140,10,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��18.667(�6p   $��Palatino Linotype)�6�    K� ZIndex$ 1��6�   $��USERNAME��6�   �� 5   
   -   5        $ PasswordTextBlock��5      $��20,223,10,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��18.667(�6p   $��Palatino Linotype)�6�   $ 1��6�   $��PASSWORD��6�   �� 5   
   -   5        	 ��Name$	 UsernameInputBox��5      $��10,170,10,0q�6,   
 �� TextWrapping$

 Wrap=�6A   $	��Top=�6U   $��21.333(�6m   $��1q�6   $��Palatino Linotype)�6�   $��0q�6�   ���	#99FFFFFF � Cursor$ IBeam��6�   $ 1��6�   G� 5   
   -   5         G�Name$ PasswordInputBox��5      $��10,253,10,0q�60   $��21.333(�6E   $��1q�6W   $��Palatino Linotype)�6k   $��Disabled=�6�   $	��Top=�6�   ���	#99FFFFFF$ IBeam��6�   $ 1��6�   �� 5   
   -   5         ��Name$ LoginButton��5      $��LOG IN��6&   $��Center=�67   $��40��6T   $��	0,312,0,0q�6`   $	��Top=�6s   $��70��6�   $��18.667(�6�   $ 0.5,0.5&�6�   $��Palatino Linotype)�6�   $ 1��6�   
������� �� 	IsDefault . $��0q�6I  $
 Hand��6]  ��6�   Z� ��6"  Z� 6k  �� 5   
   -   5        $ CreateAccountButton��5      $��Create Account��6.   $
��Left=�6G   $��
60,403,0,0q�6b   $	��Top=�6v   $��16(�6�   $��Palatino Linotype)�6�   $��Italic$�6�   $ 1��6�   $
 Hand��6  ��6�   Z� ��6�   Z� 6  �� 5   
   -   5        $ ForgotPasswordButton��5      $��Forgot Password?��6/   $��
0,403,60,0q�6J   $	��Top=�6^   $��16(�6�   $��Italic$�6�   $��Right=�6�   $��Palatino Linotype)�6�   $ 1��6�   $
 Hand��6  ��6v   Z� ��6�   Z� 6  �� 5   
   -   5         ��Name$ CenterImage��5      $��Center=�6%   $��
0,-45,12,0q�6B   $	��Top=�6V   $	��397��6n   $��Resources/d20-2.png��6z   $	��263��6�    J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0.666Q�61   � 5      $ 0.805Q�6#   � 5      $ Black��6#   $ 0.291Q�61   � 5      $ 	#00000000��6#   $ 0.156Q�65   5      5       �� 5!   
   -	   5        $ 
LoginImage��5!      $��Center=�6$   $��	3,272,0,0q�6A   $	��Top=�6T   $��Resources/login.png��6l   $	��157��6�   $	��190��6�   $
��Fill=�6�   5"      5#      