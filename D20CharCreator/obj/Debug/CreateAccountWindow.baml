   M S B A M L   `   `   `  ����I  ED20CharCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:D20CharCreatorD20CharCreator  5   	   (    "D20CharCreator.CreateAccountWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:D20CharCreator     5   	   -   5          � Title$  Create Account��5   	   $	��600��6    $	��500��6-    � WindowStartupLocation$ CenterOwner=�69    � 
ResizeMode$ CanMinimize=�6]    � Icon$ Resources/d20.ico��6�   $��3,0,3,3q�6�   ���	#FF720000.��5	      � ��5
   
   �� 5       �� ImageSource$ Resources/parchment.jpg��6   .+�5   
   �� -   5         ��Name$ FirstNameTextBlock��5      $
��Left=�60   $��	37,27,0,0q�6K   $
��Wrap=�6^   $	��Top=�6r   $��Palatino Linotype)�6�   $��18.667(�6�   $��
First Name��6�    K� ZIndex$ 1��6�   �� 5   
   -   5         ��Name$ FirstNameInputBox��5      $��
49,57,40,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U   $��Palatino Linotype)�6m   $��18.667(�6�   ���	#99FFFFFF$ 1��6�   	 � Cursor$	 IBeam��6�   ��6�   Z� 6�   �� 5   
   -   5        $ LastNameTextBlock��5      $
��Left=�6/   $��	37,89,0,0q�6J   $
��Wrap=�6]   $	��Top=�6q   $��Palatino Linotype)�6�   $��18.667(�6�   $��	Last Name��6�   $ 1��6�   �� 5   
   -   5        $ LastNameInputBox��5      $��49,119,40,0q�6,   $
 Wrap=�6A   $	��Top=�6U   $��Palatino Linotype)�6m   $��18.667(�6�   ���	#99FFFFFF$ 1��6�   $	 IBeam��6�   ��6�   Z� 6�   �� 5   
   -   5        $ EmailTextBlock��5      $
��Left=�6,   $��
37,151,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   $��Palatino Linotype)�6�   $��18.667(�6�   $��Email Address��6�   $ 1��6�   �� 5   
   -   5        $ EmailInputBox��5      $��49,181,40,0q�6)   $
 Wrap=�6>   $	��Top=�6R   $��Palatino Linotype)�6j   $��18.667(�6�   ���	#99FFFFFF$ 1��6�   $	 IBeam��6�   ��6�   Z� 6�   �� 5   
   -   5        $ UsernameTextBlock��5      $
��Left=�6/   $��
37,265,0,0q�6J   $
��Wrap=�6^   $	��Top=�6r   $��Palatino Linotype)�6�   $��18.667(�6�   $��Username��6�   $ 1��6�   �� 5   
   -	   5        $ UsernameInputBox��5      $��49,295,40,0q�6,   $
 Wrap=�6A   $	��Top=�6U   $��Palatino Linotype)�6m   $��18.667(�6�   ���	#99FFFFFF$ 1��6�   $	 IBeam��6�   ��6�   Z� 6�   �� 5   
   -
   5        $ PasswordTextBlock1��5      $
��Left=�60   $��
37,327,0,0q�6K   $
��Wrap=�6_   $	��Top=�6s   $��Palatino Linotype)�6�   $��18.667(�6�   $��Password��6�   
 J� RenderTransformOrigin$
 0.533,1.747&�6�   $ 1��6�   �� 5   
   -   5        $ PasswordTextBlock2��5      $
��Left=�60   $��
37,389,0,0q�6K   $
��Wrap=�6_   $	��Top=�6s   $��Palatino Linotype)�6�   $��18.667(�6�   $��Re-enter Password��6�   $
 0.533,1.747&�6�   $ 1��6�   �� 5   
   -   5         ��Name$ HorizontalDivider��5      $	��162��6+   $��40,160,40,0q�68   $	��Top=�6M   $!��Resources/horizontaldiv.png��6e   $
��Fill=�6�   �� 5   
   -   5         ��Name$ CreateAccountButton��5      $��CREATE ACCOUNT��6.   $��Right=�6G   $	��Top=�6c   $��0,485,148,0q�6{   $��Palatino Linotype)�6�   $��16(�6�   $	��198��6�   $��35��6�   $ 1��6�   ���	#FF720000$��2q�6  
���   �
�������$
	 Hand��6Z  G� 5   
   -   5         G�Name$ PasswordInputBox1��5      $��49,357,40,0q�61   $	��Top=�6F   $��Palatino Linotype)�6^   $��18.667(�6}   ���	#99FFFFFF��6�   Z� G� 5   
   -   5        $ PasswordInputBox2��5      $��49,419,40,0q�61   $	��Top=�6F   $��Palatino Linotype)�6^   $��18.667(�6}   ���	#99FFFFFF��6�   Z� 5      5      