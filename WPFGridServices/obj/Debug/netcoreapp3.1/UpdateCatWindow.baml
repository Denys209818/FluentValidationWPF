   M S B A M L   `   `   `  ����J  FWPFGridServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPFGridServicesWPFGridServices  5   	   %    WPFGridServices.UpdateCatWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPFGridServices     5   	     � Title$%  Редагування кота��5   	   $	��500��6"   $	��450��6/    � 	Resources 5	         validationTemplate �� 
TargetType �� Property �� Value  btnUpdateStyle��%`  &	        '�� �     '�� �     7   &	 n    �� 5
   
   .R�5      �� .+�5      �� 
���  ��$��1q�6+   ._�5      �� 5      �� 5      
���  ����6-   �� *[0].ErrorContent+5      5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 24(�6)   �� 5       �@=�ErrorTemplate8   69   5      �� 5   
   .�5      ��  � ��$
 0,20q�6.   �� 5       � ��$ 50��6.   �� 5       � ��$ Змінити��6/   �� 5       � ��$ 24(�60   -   5        5!      5"      .��5#      ]� .+�5$   
   �� $	��300��6   .+�5%      �� $��33(�6   $��Center=�6"   $%��Редагування кота��5&      
���  ��$
��Bold"�6@   �� 5'      .+�5(      �� $��
Назва��6   �� 5)      -   5         ��Name$ txtName��5)      .��6+   ��5*      �� 5+       �� Path$
 Name�6"    �� ValidationRules 5,      5  /System.Windows.Controls.DataErrorValidationRule  5-   "    �� UpdateSourceTrigger$ PropertyChanged=�51   ;   	 �� ValidatesOnDataErrors$
	 True��54   =   55      .��56   $   57      58      �� 59      .+�5:      �� $��Вік��6   �� 5;      -   5        $ txtAge��5;      .��6*   ��5<      �� 5>      $	 Age�6    5?        5@      $ PropertyChanged=�5D   7   $
	 True��5G   9   5H      .��5I   $   5J      5K      �� 5L      .+�5M      �� $��Деталі��6   �� 5N      -   5        $ 
txtDetails��5N      .��6.   ��5O      �� 5Q      $ Details�6    5R        5S      $ PropertyChanged=�5W   7   $
	 True��5Z   9   5[      .��5\   $   5]      5^      �� 5_      .+�5`      �� $��
Силка��6   �� 5a      -   5        $ 
txtImgPath��5a      .��6.   ��5b      �� 5d      $ ImgPath�6    5e        5f      $ PropertyChanged=�5j   7   $
	 True��5m   9   5n      .��5o   $   5p      5q      �� 5r      .+�5s      �� $��Ціна��6   �� 5t      -   5        $ txtPrice��5t      .��6,   ��5u      �� 5w      $ Price�6    5x        5y      $ PropertyChanged=�5}   7   $
	 True��5�   9   5�      .��5�   "   5�      5�      �� 5�      -   5        
 ��Name$
 	btnUpdate��5�      #��[ 6(   5�      5�      5�      