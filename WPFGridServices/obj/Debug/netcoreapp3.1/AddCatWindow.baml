   M S B A M L   `   `   `  ����J  FWPFGridServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPFGridServicesWPFGridServices  5   	   "    WPFGridServices.AddCatWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPFGridServices     5   	   -   5          � Title$  Додати кота��5   	   $	��650��6   $	��450��6*    � 	Resources 5	         validationRules  btnStyleBase �� Property �� Value �� 
TargetType  btnSubmitStyles��%  &	        &	 �     &	 #    '�� �    �� 5
   
   .R�5      �� .+�5      �� 
���  ��$��1q�6+   ._�5      �� 5      �� 5      
���  ����6-   �� *[0].ErrorContent+5      5      �� 5   
   .�5      ��  � ��$ 16(�60   �� 5       � ��$ 40,10q�6.   -   5        5      �� 5   
   " ��6   .�5      ��  � ��$ 24(�6)   �� 5       � ��$ 10q�6(   -   5        5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   5       5!      .��5"      ]� .+�5#   
   �� $	��300��6   .+�5$      �� $!��Додати елемент��6   $��Center=�6-   $��36(�6J   $
��Bold"�6X   
���  ��6j   �� 5&      $��5q�6   .+�5'      �� $��
Назва��6   �� 5(      -   5         ��Name$ txtName��5(      $��24(�5)       =� ErrorTemplate# �   6    .��6]   ��5*      �� 5+       �� Path$
 Name�6"    �� ValidationRules 5,      5  /System.Windows.Controls.DataErrorValidationRule  5-   "   	 �� UpdateSourceTrigger$	 PropertyChanged=�51   ;   52      .��53   $   54      55      �� 56      $��5q�6   .+�57      �� $��Вік��6   �� 58      -   5        $ txtAge��58      $��24(�59      # �   6(   ��58   *   �� *Age+$	 PropertyChanged=�
 �� ValidatesOnDataErrors$

 True��59   (   5:      �� 5;      $��5q�6   .+�5<      �� $��Деталі��6   �� 5=      -   5        $ 
txtDetails��5=      $��24(�5>       �� AcceptsReturn$
 True��6)   $	��100��6>   # �   5?      ��5=   .   �� *	Details+$	 PropertyChanged=�$

 True��5?      5@      �� 5A      $��5q�6   .+�5B      �� $��Ціна��6   �� 5C      -   5        $ txtPrice��5C      $��24(�5D      # �   6'   ��5C   ,   �� *Price+$	 PropertyChanged=�$

 True��5D   '   5E      �� 5F      $��5q�6   .+�5G      �� $*��$Силка на зображення��6   �� 5H      -   5        $ txtImage��5H      $��24(�5I      # �   6(   ��5H   ,   �� *	ImgPath+$	 PropertyChanged=�$

 True��5I   (   5J      � 5K      $��5q�6   $��40��6#   .+�5L      	� $��Кіт��6   #��[ 6,   
 � Tag$
 True��6R    d� 	IsChecked$
 TrueY�6]   	� 5M      $��
Кішка��6   #��[ 6.   $ False��6T   5N      �� 5O      -	   5         ��Name$ 	btnSubmit��5O      $��Підтвердити��6(   #��[ 6>   5P      5Q      5R      