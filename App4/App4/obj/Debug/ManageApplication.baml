   M S B A M L   `   `   `  ����?  ;App4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:App4App4  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      clr-namespace:App4App4  5	          App4.ManageApplication   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:App4     5   	   9System&clr-namespace:System;assembly=mscorlib     5      )
StyleAliasclr-namespace:App4     5	        � Title$  ManageApplication��5
   	   $	��450��6#   $	��800��60    � 	Resources 5         dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%{   &	        S� 5   
   $ 	GetValues��62   "  5       5      M� 5      $ StyleAlias:Types��6   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��346* �6   �� 5      $
��449* �6    � RowDefinitions 5"   
   �� 5#      $	��80* �6   �� 5$      $	��71* �6   �� 5%      $	��61* �6   �� 5&      $	��71* �6   �� 5'      $	��71* �6   �� 5(      $	��70* �6   .+�5+   
   �� $��Management Center��6   $��
0,0,10,0.5q�6,   $��0��6@   $��10q�6P   6_   �� 5.   
   -   5         ��Name$ Cartlst2��5.      $��Stretch=�6$   $��0��5/   /   $��0,70,25,0.5q�6?   $��6��6T   ��6   �� 6T   �� 51   
   $��1��6   $��0,0,0,70q�6%   $��4��67   .+�57      �  59      �� 5:      �� 5;      $��0* �6$   �� 5<       5?      �� 5@      $
��244* �6'   �� 5A      $
��205* �6'   .+�5D      �� $��Name:��6   $��0,0,48,28.5q�6(   $��0��6=   $��0��6M   �� 5F      $�� Type:��6   $��0,30.5,123,29.5q�6)   $��0��6B   $��1��6R   �� 5G      -   5        	 ��Name$	 
ComboTypes��5G      $��34,14.5,92,48.5q�61   
 J� RenderTransformOrigin$
 0.272,0.406&�6J   $��1��5I   ?   $��1��6O   ��5H      ��  �� Source# [   �� SelectedItem 5I      �� *CurrentEffectStyle+6O   �� 5K      $��description��6   $��0,85.5,123,0q�6.   $��0��6D   $��2��6T   $��1��6e   �� 5M      -   5         ��Name$ description��5M      $��34,85.5,10,0q�6/   $��1��6F   $��1��6V   $��2��6c   �� 5O      -   5        $
 Name��5O      $��34,10,10,50.5q�6)   $
 0.564,-2.585&�6@   $��1��6f   5U      5X      �� 5[   
   -   5         ��Name$	 Add��5[      $	��Add��6   $��1��6,   $��3��6<   $��
73,1,105,0q�6I   6]   �� 5]   
   -   5        $ update��5]      $��Update��6!   $��1��62   $�� 4��6C   $��73,0,105,0.5q�6Q   �� 5_   
   -   5        $ delete��5_      $��Delete��6!   $��1��62   $��4��6B   $��73,70,105,0.5q�6O   $��2��6f   5a      5b      