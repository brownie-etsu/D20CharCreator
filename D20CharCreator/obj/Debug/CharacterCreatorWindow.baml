   M S B A M L   `   `   `  ����I  ED20CharCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:D20CharCreatorD20CharCreator  5   	   +    %D20CharCreator.CharacterCreatorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:D20CharCreator     5   	   -   5          � Title$  Character Creator��5   	   $	��598��6#   $	��800��60    � WindowStartupLocation$ CenterOwner=�6<   ���	#FF720000$��3,0,3,3q�6�    � 
ResizeMode$ CanMinimize=�6�    � Icon$ Resources/d20.ico��6�   ��5	      �� 5
   
    �� ImageSource$ Resources/parchment.jpg��6    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6%    �� CenterX$	 0.5Q�63   �� 5       �� CenterY$	 0.5Q�6$   	 �� CenterX$		 0.5Q�62   �� 5      
 �� Angle$
 90Q�6&    �� CenterY$	 0.5Q�61    �� CenterX$	 0.5Q�6?   T� 5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��171* �6   �� 5      $
��172* �6   �� 5      $
��172* �6   �� 5      $
��171* �6    � RowDefinitions 5   
   �� 5      $	��13* �6   �� 5      $
��255* �6   �� 5      $	��15* �6   .+�5!   
    � -   5          �Name$ frame��5!      $��Frame��6   $��4��6/     � NavigationUIVisibility$ Hidden=�6C   $��1��6c   �� 5"   
   -   5         ��Name$ ClassButton��5"      $��CLASS��6&   $��0q�66   $��2��6A   $��Bottom=�6N   
�������
���   ����	#FF720000$��2,2,2,0q�6�   $��Palatino Linotype)�6�   $��1��6�   $��18.667(�6�   $��Center=�6  $	��158��69  $��29��6E  �� 5#   
   -   5        $ BackgroundButton��5#      $��
BACKGROUND��6+   $��0q�6@   $��2��6K   $��Bottom=�6X   
�������
���   ����	#FF720000$��2,2,2,0q�6�   $��Palatino Linotype)�6�   $	��160��6�   $��18.667(�6�   $��Center=�6  $��29��6D  �� 5$   
   -   5        $ SaveExitButton��5$      $
��SAVE��6)   $
��Left=�68   $	��Top=�6S   
�������
���   ����	#FF720000$��0,0,2,2q�6�   $��Palatino Linotype)�6�   $��16(�6�   $��70��6�   $��26��6�   6  5%      5&      