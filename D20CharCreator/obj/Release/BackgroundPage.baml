   M S B A M L   `   `   `  ���� I  ED20CharCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:D20CharCreatorD20CharCreator  #    D20CharCreator.BackgroundPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:D20CharCreator       N� Title$  BackgroundPage��$	��758��$	��510�� N� 	KeepAlive . .���  � ColumnDefinitions �� ��  � RowDefinitions �� .+��� $��Center=�.+��� -    ��Name$ BackgroundTextBlock��$
��Wrap=�$��Choose Background��$��Palatino Linotype)�$��18.667(� �� TextAlignment$ Center=��� -    ��Name$ BackgroundListBox��$��0q�$��Center=�$��Palatino Linotype)�$��18.667(�$��3q����	#FF370000$	��200��$��Center=�.@��� $��Acolyte���� $��	Charlatan���� $��Criminal���� $��Entertainer���� $��	Folk Hero���� $��Guild Artisan���� $��Hermit���� $��Noble���� $��	Outlander���� $
��Sage���� $��Sailor���� $��Soldier���� $��Urchin���� -    ��Name$ BackgroundTabControl��$��1��$��
0,10,30,30q����	#99FFFFFF$��3q����	#FF720000.@��� $��Proficiencies��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ ProficienciesTextBlock��$
��Wrap=�$��Proficiencies��$��Center=�$��26.667(��� $��0q�$	��Top=�$��20��$��0q����	#FF720000��Z� �� -   $ CharacterTextBlock��$
��Wrap=�$��	Character��$��Center=�$��21.333(�$��95.053,0,94.946,0q��� -   $ Proficiency1TextBlock��$
��Wrap=�$��18.667(�$��Center=��� -   $ Proficiency2TextBlock��$
��Wrap=�$��18.667(�$��0q�$��Center=��� $��0q�$	��Top=�$��20��$��0q���Z� ��Z� �� -   $ ToolsTextBlock��$
��Wrap=�$
��Tool��$��Center=�$��21.333(�$��111.82,0,111.179,0q��� -	   $ Proficiency3TextBlock��$
��Wrap=�$��18.667(�$��Center=�$��0q��� -
   $ Proficiency4TextBlock��$
��Wrap=�$��18.667(�$��0q�$��Center=��� $��	Languages��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ LanguagesTextBlock��$
��Wrap=�$��Center=�$��26.667(�$��Additional Languages���� $��0q�$��20��$��0q����	#FF720000$	��Top=���Z� �� -    ��Name$ Language1ComboBox��$��6,3,5,3q�$��18.667(�$	��300��{�.  .@��� $��Abyssal���� $��Aquan���� $��Auran���� $��	Celestial���� $��Common���� $��Deep Speech���� $��Draconic���� $��Druidic���� $��Dwarvish���� $��Elvish���� $��Giant���� $��Gnomish���� $��Goblin���� $��Gnoll���� $��Halfling���� $��Ignan���� $��Infernal���� $	��Orc���� $��
Primordial���� $��Sylvan���� $��Terran���� $��Undercommon���� $��0q�$	��Top=�$��20��$��0q���Z� ��Z� �� -   $ Language2ComboBox��$��6,3,5,3q�$��18.667(�$	��300��{�.  .@��� $��Abyssal���� $��Aquan���� $��Auran���� $��	Celestial���� $��Common���� $��Deep Speech���� $��Draconic���� $��Druidic���� $��Dwarvish���� $��Elvish���� $��Giant���� $��Gnomish���� $��Goblin���� $��Gnoll���� $��Halfling���� $��Ignan���� $��Infernal���� $	��Orc���� $��
Primordial���� $��Sylvan���� $��Terran���� $��Undercommon���� $��	Equipment��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ EquipmentTextBlock��$
��Wrap=�$��Center=�$��26.667(�$��	Equipment���� $��0q�$��20��$��0q����	#FF720000$	��Top=���Z� �� -   $ EquipmentComboBox��$
��20,0q�	 �� 
IsReadOnly	 . {�.  �� -   
 ��Name$
 EquipmentTextBox�� �� TextWrapping$
 Wrap=�$��13.333(� �� 
IsReadOnly . $
��20,0q�$	��330��$��0q��� $��Characteristics��$��Palatino Linotype)�.���� $	��Top=�$��0,10,0,0q�.+��� -   $ EquipmentTextBlock1��$
��Wrap=�$��Center=�$��26.667(�$��Characteristics���� $��0q�$��20��$��0q����	#FF720000$	��Top=���Z� �� -   $ PersonalityTextBlock��$
��Wrap=�$��21.333(�$ Center=�$��Personality���� -   $
 PersonalityTextBox��$
 Wrap=�$��50�� . $��0q��� -   $ IdealTextBlock��$
��Wrap=�$��0q�$��21.333(�$ Center=�$��Ideal���� -   $
 IdealTextBox��$
 Wrap=�$��50�� . $��0q��� -   $ BondTextBlock��$
��Wrap=�$��0q�$��21.333(�$ Center=�$
��Bond���� -   $
 BondTextBox��$
 Wrap=�$��50�� . $��0q��� -   $ FlawTextBlock��$
��Wrap=�$
��Flaw��$��0q�$��21.333(�$ Center=��� -   $
 FlawTextBox��$
 Wrap=�$��50�� . $��0q�� $��57�� �� �� .+��� -    ��Name$ 
RollButton��$��REROLL��$	��100��$��0q�$��16(����	#FF720000
�������
���   �$��2q�$��Center=�$��30��$��Center=��� -   $ RollsTextBlock��$��Center=�$
��Wrap=�$��Center=�$��1��$��0q�$��16(�$
��Bold"�