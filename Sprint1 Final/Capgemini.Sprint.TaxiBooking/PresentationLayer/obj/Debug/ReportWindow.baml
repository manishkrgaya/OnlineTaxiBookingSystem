   M S B A M L   `   `   `  ����L  HPresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PresentationLayerPresentationLayer  5   	   $    PresentationLayer.ReportWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PresentationLayer     5   	   -   5          �Name$  ReportWindows��5   	    � Title$ ReportWindow��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   	� -   5        $��
RadioDaily��5
      $��Daily Report��6(   $
��Left=�6?   $	��Top=�6Z   $��39.2,91,0,0q�6r   $��1��6�   6�   	� 5   
   -   5        $��RadioWeeklyOrMonthly��5      $��WeeklyOrMonthly Report��62   $
��Left=�6S   $	��Top=�6n   $��
279,88,0,0q�6�   $��18��6�   $	��199��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
ReportGrid��5      $
��Left=�6%   $	��207��6@   $	��Top=�6M   $	��794��6e   $��0,203,-0.4,0q�6q   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��
dtFromDate��5      $
��Left=�6'   $	��Top=�6B   $��128,140,0,0q�6Z   �� 5   
   $��FromDate��6   $
��Left=�6#   $	��Top=�6>   $��
39,136,0,0q�6V   $��78��6j   �� 5   
   $��ToDate��6   $
��Left=�6!   $	��Top=�6<   $��279.1,138,0,0q�6T   $��78��6k   $��1��6v   �� 5   
   -   5        $��Gobtn��5      $��Go��6   $
��Left=�6+   $��496,142,0,0q�6F   $	��Top=�6[   $��75��6s   6~     5   
   -   5        $��dtToDate��5      $
��Left=�6%   $��335,140,0,0q�6@   $	��Top=�6U   �� 5   
   -   5        $��
LblMessage��5      
���  ��$�� ��63   $
��Left=�6>   $	��Top=�6Y   $��128,177,0,0q�6q   $	��443��6�   5      5      