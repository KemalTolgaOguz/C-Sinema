   M S B A M L   `   `   `  ����C  ?FilmGise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FilmGiseFilmGise  5   	       FilmGise.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:FilmGise     5   	   -   5          � Title$  
MainWindow��5   	   $	��451��6   $	��798��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Dg��5      $��0,0,0,69q�6       Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ KOLTUK NUMARASI��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	KoltukNum+6^     5      $ FİYAT��6%    65   �� *fiyat+6Q     5      $ DURUM��6%    65   �� *Durum+6Q   5      �� 5   
   -   5         ��Name$	 Ogr��5      $��	Öğrenci��6   $
��Left=�60   $	��303��6K   $��	0,365,0,0q�6W   6j   �� 5   
   -   5        $
 Nrml��5      $��Normal��6   $
��Left=�60   $	��303��6K   $��497,365,0,0q�6W   6l   �� 5   
   -   5        $ Iptal��5      $��İptal��6!   $��Center=�61   $��	0,365,0,0q�6N   $	��Top=�6a   $��70��6y   $	��194��6�   6�   5      5      