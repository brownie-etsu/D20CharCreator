   M S B A M L   `   `   `  ���� I  ED20CharCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:D20CharCreatorD20CharCreator      D20CharCreator.ClassPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:D20CharCreator       N� Title$  	ClassPage��$	��758��$	��510�� N� 	KeepAlive . .��� $��0q� � ColumnDefinitions �� ��  � RowDefinitions �� .+��� $��Center=�.+��� -    ��Name$ ClassTextBlock��$
��Wrap=�$��Choose Class��$��Palatino Linotype)�$��18.667(� �� TextAlignment$ Center=��� -    ��Name$ ClassListBox��$��0q�$��Center=�$��Palatino Linotype)�$��18.667(�$��3q����	#FF370000$	��200��$��Center=�.@��� $��	Barbarian���� $��Cleric���� $��Rogue���� $��Wizard���� -    ��Name$ ClassTabControl��$��1��$��
0,10,30,30q����	#99FFFFFF$��3q����	#FF720000.@��� $��
Hit Points��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ HitPointsTextBlock��$
��Wrap=�$��Center=�$��26.667(�$��
Hit Points���� $��0q�$��20��$��0q����	#FF720000$	��Top=���Z� �� -   $ HitDiceTextBlock��$
��Wrap=�$��24(�$��Hit Dice��$ Center=��� -    ��Name$ HitDiceTextBox��$��60��	 �� TextWrapping$
	 Wrap=�$��16(�
 �� TextAlignment$
 Center=� �� 
IsReadOnly . $��0q���Z� ��Z�  �� SelectionBrush Z� �� -   $  HitPoints1stLevelTextBlock��$
��Wrap=�$��24(�$��0,18,0,0q�$��Hit Points at 1st Level��$ Center=��� -   $ HitPoints1stLevelTextBox��$��60��$
	 Wrap=�$��16(�$
 Center=� . $��0q���Z� ��Z�  Z� �� -	   $# HitPointsHigherLevelTextBlock��$
��Wrap=�$��24(�$��0,15,0,0q�$!��Hit Points at Higher Levels��$ Center=��� -
   $! HitPointsHigherLevelTextBox��$��60��$
	 Wrap=�$��16(�$
 Center=� . $��0q���Z� ��Z�  Z� �� $��Proficiencies��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ ProficienciesTextBlock��$
��Wrap=�$��Proficiencies��$��Center=�$��26.667(��� $��0q�$	��Top=�$��20��$��0q����	#FF720000��Z� �� -   $ ArmorProficiencyTextBlock��$
��Wrap=�$��Armor��$��Center=�$��26.667(�$��0,0,-1,0q��� -   $ ArmorProficiencyTextBox��$
	 Wrap=�$��18.667(�$
 Center=�$��27�� . $��0q���Z� ��Z�  Z� �� -   $! WeaponsProficiencyTextBlock��$
��Wrap=�$��Weapons��$��Center=�$��26.667(�$��0,20,0,0q��� -   $ WeaponsProficiencyTextBox��$��27��$
	 Wrap=�$
 Center=�$��18.667(� . $��0q���Z� ��Z�  Z� �� -   $ ToolsProficiencyTextBlock��$
��Wrap=�$��Tools��$��Center=�$��26.667(�$��0,20,0,0q��� -   $ ToolsProficiencyTextBox��$��27��$
	 Wrap=�$
 Center=�$��18.667(� . $��0q���Z� ��Z�  Z� �� -   $  ThrowsProficiencyTextBlock��$
��Wrap=�$��Saving Throws��$��Center=�$��26.667(�$��0,20,0,0q��� -   $ ThrowsProficiencyTextBox��$��27��$
	 Wrap=�$
 Center=�$��18.667(� . $��0q���Z� ��Z�  Z� �� $��Skills��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ SkillsTextBlock��$
��Wrap=�$��Skills��$��Center=�$��26.667(��� $��0q�$	��Top=�$��20��$��0q����	#FF720000��Z� �  �� $	��66* ��� $	��33* �.+��� -   $ SkillsListBox��$	��140��$��Center=�$��0q�$	��180��$��16(��� -    ��Name$ RemoveButton��$
��Left=�$	��Top=�$��1��$��20��$��20�����	#FFB65050{�.  � $��0,20,0,0q� �� $	��66* ��� $	��33* �.+��� -    ��Name$ SkillsComboBox��$��Center=�$��Center=�$	��170��$��1,0,0,0q�$��16(�{�.  �� -   $ 	AddButton��$
��Left=�$	��Top=�$��1��$��20��$��20�����	#FF82CF6C{�.  �� $��	Equipment��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ EquipmentTextBlock��$
��Wrap=�$��Center=�$��26.667(�$��	Equipment���� $��0q�$��20��$��0q����	#FF720000$	��Top=���Z� �� -   $ EquipmentComboBox��$
��20,0q� �� 
IsReadOnly . {�.  �� -   $ EquipmentTextBox��$
	 Wrap=�$��13.333(� . $
��20,0q�$	��330��$��0q� Z� �� $��Features��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ FeaturesTextBlock��$
��Wrap=�$��Center=�$��26.667(�$��Features���� $��0q�$��20��$��0q����	#FF720000$	��Top=���Z� �� -   $ FeaturesTextBox��$	��350��$
	 Wrap=�$
��20,0q�$��16(� . $��0q� Z� 