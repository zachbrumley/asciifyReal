   M S B A M L   `   `   `  ����E  Aasciify3.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:asciify3._0asciify3._0  5   	       asciify3._0.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:asciify3._0     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   o� -   5         o�Name$ mnuOpen��5
      $
��Left=�6    $��50��6;   $��0,10,0,0q�6G   $	��Top=�6Y   $	��107��6q   .@�5      m� -   5         m�Name$ mitOpen��5      
�������$��36��6;   $��91��6G   $
��File��6R   .@�5      m� -   5        $ mitOpenFile��5      $��54��60   $	��200��6<   $��	Open File��6H   6[   5      5      �� 5   
   -   5         ��Name$ imgMain��5      $
��Left=�6!   $	��235��6<   $��	10,45,0,0q�6I   $	��Top=�6\   $	��263��6t   �� 5   
   -   5         ��Name$ 	lstPixels��5      $
��Left=�6%   $	��273��6@   $��
299,45,0,0q�6M   $	��Top=�6a   $	��128��6y   �� 5   
   $��Pixel Data
��6   $
��Left=�6/   $��
299,-3,0,0q�6J   $	��Top=�6^   $��51��6v   $	��128��6�   $��25(�6�   �� 5   
   -   5         ��Name$ lblAscii��5      $��Ascii
��6"   $
��Left=�6<   $��45��6W   $��
445,-5,0,0q�6c   $	��Top=�6w   $	��141��6�   $��25(�6�   �� 5   
   -   5        $ lblSourceImage��5      $��Source Image
��6(   $
��Left=�6I   $��	101,0,0,0q�6d   $	��Top=�6w   $��45��6�   $	��184��6�   $��25(�6�   �� 5   
   -   5         ��Name$ btnConvertToAscii��5      $��Convert Image
��6,   $��
34,304,0,0q�6N   $��20(�6b   $
��Left=�6�   $	��Top=�6�   �� 5   
   -	   5         ��Name$ txtKernelWidth��5      $�� ��6*    �� TextWrapping$
 Wrap=�62   $��140,366,0,0q�6F   	 J� RenderTransformOrigin$	 -0.165,0.332&�6[   $
��Left=�6�   $	��Top=�6�   $��60��6�   $��25��6�   .��6�   z�5      V� 5      .~�5      �� 
 �� ScaleY$
 -1Q�6%    �� ScaleX$ -1Q�61   �� 5      �� 5       �� Angle$	 180Q�6&   T� 5       T� Y$ 10.416Q�6)   5      .��5   '   5      �� 5    
   -
   5        $ txtKernelHeight��5       $
 Wrap=�6+   $��363,372,0,0q�6?   $	 0.557,1.642&�6T   $	��Top=�6x   $
��Left=�6�   $��60��6�   $��25��6�   �� 5!   
   $��Kernel Width
��6   $��34,374,669,2q�61   $	 0.495,0.467&�6G   $��97��6k   $
��Left=�6v   $	��Top=�6�   �� 5"   
   $��Kernel Height
��6   $��276,366,0,0q�62   $	��Top=�6G   $
��Left=�6_   �� 5#   
   -   5        $ 	txtAscii1��5#      $��TextBox��6%   $ NoWrap=�64   $��432,45,15,10q�6J   $��False��6`   $��Courier New)�6r   $��8(�6�   5%      5&      