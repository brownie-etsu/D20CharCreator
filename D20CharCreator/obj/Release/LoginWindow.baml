   M S B A M L   `   `   `  ���� I  ED20CharCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:D20CharCreatorD20CharCreator       D20CharCreator.LoginWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:D20CharCreator       � Title$  Login�� � 
ResizeMode$ CanMinimize=�$��399.3��$	��494��$��3,0,3,3q�$��Center=�$��Center=� � WindowStartupLocation$ CenterScreen=� � Icon$ Resources/d20.ico�����	#FF720000.���  J� RenderTransformOrigin$	 0,0&� � ColumnDefinitions �� ����  �� ImageSource$ Resources/parchment.jpg��.+��� -    ��Name$ UsernameTextBlock��$��20,140,10,0q�$
��Wrap=�$	��Top=�$��18.667(�$��Palatino Linotype)� K� ZIndex$ 1��$��USERNAME���� -   $ PasswordTextBlock��$��20,223,10,0q�$
��Wrap=�$	��Top=�$��18.667(�$��Palatino Linotype)�$ 1��$��PASSWORD���� -   	 ��Name$	 UsernameInputBox��$��10,170,10,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$��21.333(�$��1q�$��Palatino Linotype)�$��0q����	#99FFFFFF � Cursor$ IBeam��$ 1��G� -    G�Name$ PasswordInputBox��$��10,253,10,0q�$��21.333(�$��1q�$��Palatino Linotype)�$��Disabled=�$	��Top=����	#99FFFFFF$ IBeam��$ 1���� -    ��Name$ LoginButton��$��LOG IN��$��Center=�$��40��$��	0,312,0,0q�$	��Top=�$��70��$��18.667(�$ 0.5,0.5&�$��Palatino Linotype)�$ 1��
������� �� 	IsDefault . $��0q�$
 Hand����Z� ��Z� �� -   $ CreateAccountButton��$��Create Account��$
��Left=�$��
60,403,0,0q�$	��Top=�$��16(�$��Palatino Linotype)�$��Italic$�$ 1��$
 Hand����Z� ��Z� �� -   $ ForgotPasswordButton��$��Forgot Password?��$��
0,403,60,0q�$	��Top=�$��16(�$��Italic$�$��Right=�$��Palatino Linotype)�$ 1��$
 Hand����Z� ��Z� �� -    ��Name$ CenterImage��$��Center=�$��
0,-45,12,0q�$	��Top=�$	��397��$��Resources/d20-2.png��$	��263�� J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0.666Q�� $ 0.805Q�� $ Black��$ 0.291Q�� $ 	#00000000��$ 0.156Q��� -	   $ 
LoginImage��$��Center=�$��	3,272,0,0q�$	��Top=�$��Resources/login.png��$	��157��$	��190��$
��Fill=�