   M S B A M L   `   `   `  ����V  RMunicipalServiceApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MunicipalServiceApplicationMunicipalServiceApplication  5   	   .    (MunicipalServiceApplication.ReportIssues   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:MunicipalServiceApplication     5   	     � Title$  ReportIssues��5   	   $	��450��6   $	��800��6+   .��5	      � $��0,0,0,-6q�6   #��� ��6   .+�5
   
   �� -   5         ��Name$ locationTextBox��5
      $
��Left=�6+   $��	52,72,0,0q�6F    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��169��6�   $��42��6�   #��� ��6�   #��� ��6�   �� 5   
   -   5         ��Name$ 
locationLB��5      $��Add Location/Address��6$   $
��Left=�6C   $��	52,43,0,0q�6^   $	��Top=�6q   $
��Bold"�6�   �� 5   
   -   5        $ ReportIssuesLB��5      $��Report Issues��6(   $
��Left=�6@   $��	319,7,0,0q�6[   $	��Top=�6n   $
��Bold"�6�   $��18(�6�   $	��132��6�   �� 5   
   -   5         ��Name$ descriptionTB��5      $��319,93,255,260q�6-    J� RenderTransformOrigin$ 0.493,0.237&�6k   #��� ��6�   #��� ��6�   . �5      /� .T�5      J� .*�6   .*�5      �� $� ��6   5      5      5      �� 5   
   -   5        $��Back to Main Window��5      $
��Left=�6/   $��
641,28,0,0q�6J   $	��Top=�6^   $ -0.041,0.864&�6�   $��39��6�   $	��120��6�   #��� ��6�   �� 5   
   -   5        $��Submit��5      $
��Left=�6"   $��685,361,0,0q�6=   $	��Top=�6R   $��39��6j   $��76��6v   #��� ��6�   �� 5   
   $��Add Description��6   $
��Left=�6*   $��
319,54,0,0q�6E   $	��Top=�6Y   $ 0.183,0.608&�6q   $
��Bold"�6�   �� 5   
   $��Select Category��6   $
��Left=�6*   $��
52,154,0,0q�6E   $	��Top=�6Y   $
��Bold"�6q   �� 5   
   -   5         ��Name$ categoryListBox��5      $��52,187,592,128q�6+   #��� ��6C   .@�5      �� .��6   
Sanitation6&   �� 5      .��6   Roads6!   �� 5      .��6   Electricity6'   �� 5      .��6   Water6!   5      �� 5   
   -   5        $��btnAttachMedia��5      $��Attach Media��6'   $��322,243,322,145q�6[   $ 0.915,0.136&�6t   #��� ��6�   �� 5   
   -	   5         ��Name$ txtSelectedFile��5      $
��Left=�6-   $��319,204,0,0q�6H   $	��Top=�6]   $	��300��6u   $��No file selected��6�   $
��Bold"�6�   � 5    
   -
   5         �Name$ ProgressBar��5       $
��Left=�6+   $��22��6F   $��
52,326,0,0q�6R   $	��Top=�6f   $	��254��6~   #��� ��6�   #��� ��6�   �� 5!   
   -   5        	 ��Name$	 ProgressBtn��5!      $��Load Progress Bar��6&   $
��Left=�6B   $��
65,361,0,0q�6]   $	��Top=�6q   #��� ��6�   $��34��6�   $	��122��6�   6�   5#      5$      