   M S B A M L   `   `   `  ����V  RMunicipalServiceApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MunicipalServiceApplicationMunicipalServiceApplication  5   	   '    !MunicipalServiceApplication.Local   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:MunicipalServiceApplication     5   	     � Title$  Local��5   	   $	��450��6   $	��800��6$    � 	Resources 5	      9   3MunicipalServiceApplication.CategoryColourConverter   CategoryColourConverter��%   &	          5
   
   6(   5      .��5      � #��� ��6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��60,37,80,339q�6.   .+�5      �� $��Search by Category: ��6   $��Center=�64   �� 5      -   5         ��Name$ categoryComboBox��5      $	��150��61   $	��5,0q�6=   #��� ��6J   #��� ��6�   #��� ��6�   �� 5      $��Or Select Date: ��6   $��Center=�60   $��20,0,0,0q�6K   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
datePicker��5      $	��150��6-   $	��5,0q�69   
���   �#��� ��6Y   #��� ��6�   �� 5      -   5        $��Search��5      $��75��6&   $��20,0,0,0q�61   #��� ��6^   #��� ��6�   5      �� 5   
   -   5         ��Name$ eventsListView��5      $��36,113,48,217q�6+   #��� ��6B   
���   ���5      �� 5      .R�5      � 5      ��5      �� 5      .R�5      �� 
�������$��1q�60    �� CornerRadius$ 5��6D   $��5q�6U    �� Padding$ 10q�6`   ��6m   �� *
Category+ �� 	Converter# [  ._�5       �� .+�5!      �� $
��Bold"�6>   $��16(�6P   ��6(   �� *Name+6P   �� 5"      ��6(   �� *Date+	 �� StringFormat$	 {0:MMMM dd, yyyy}���� 5#      $��Italic$�6B   ��6(   �� *
Category+6B   5$      5%      5&      5(      �� 5+   
   -   5        $ announcementsListView��5+      $��36,248,49,73q�62   #��� ��6H   
���   ���5,      �� 5-      .R�5.      �� 
�������$��1q�60   $ 5��6D   $��5q�6U   $ 10q�6`   ._�5/      �� .+�50      �� $
��Bold"�6?   $��16(�6Q   ��6(   �� *Title+6Q   �� 51      $��14(�6E   ��6(   �� *Description+6E   �� 52      $��Italic$�6`   ��6(   �� *Date+$	 {0:MMMM dd, yyyy}��6`   53      54      55      57      �� 59   
   -   5        $��Back to Main Window��59      $
��Left=�6/   $��631,366,0,0q�6J   $	��Top=�6_   
 J� RenderTransformOrigin$
 -0.041,0.864&�6�   $��38��6�   $	��120��6�   #��� ��6�   
���   �6  �� 5:   
   $��Events��6   $
��Left=�6!   $��
354,90,0,0q�6<   $	��Top=�6P   $
 0.59,-0.268&�6h   $
��Bold"�6�   $��14(�6�   �� 5;   
   $��Announcements��6   $
��Left=�6(   $��319,219,0,0q�6C   $	��Top=�6X   $
 0.545,1.619&�6p   $
��Bold"�6�   $��14(�6�   5<      5=      