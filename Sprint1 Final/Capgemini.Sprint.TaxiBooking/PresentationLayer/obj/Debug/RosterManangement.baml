   M S B A M L   `   `   `  ����L  HPresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PresentationLayerPresentationLayer  5   	   )    #PresentationLayer.RosterManangement   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PresentationLayer     5   	   -   5          �Name$  WindowRoster��5   	    � Title$ RosterManangement��5   	   $	��450��6#   $	��800��60   .��5	      � -   5         �Name$ RosterManage��5	       � ColumnDefinitions 5
   
   �� 5      $	��46* �6   �� 5      $
��351* �6   .+�5   
   �� $��Available Employees��6   $
��Left=�6.   $��	50,84,0,0q�6I   $	��Top=�6\   $	��193��6t   $��2��6�   �� 5   
   -   5        $��Ddl_AvailableEmployees��5      $
��Left=�61   $��
50,115,0,0q�6L   $	��Top=�6`   $	��167��6x   $��2��6�   �� 5   
   $��Create Roster��6   $
��Left=�6(   $��27.294,33,0,0q�6C   $	��Top=�6Z   $	��134��6r   $��1��6~   �� 5   
   $��Employee ID��6   $
��Left=�6&   $��
50,180,0,0q�6A   $	��Top=�6U   $��84��6m   $��2��6x   �� 5   
   $��	From Date��6   $
��Left=�6$   $��
50,238,0,0q�6?   $	��Top=�6S   $��84��6k   $��2��6v   �� 5   
   $��To Date��6   $
��Left=�6"   $��
50,302,0,0q�6=   $	��Top=�6Q   $��84��6i   $��2��6t   �� 5   
   -   5        $��Txt_Employee��5      $
��Left=�6&   $��23��6A   $��106.294,183,0,0q�6M    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��1��6�   �� 5   
   -   5        $��Btn_CreateRoster��5      $��Create Roster��6)   $
��Left=�6A   $��
75,354,0,0q�6\   $	��Top=�6p   $��87��6�   $��27��6�   $��2��6�   �� 5   
    �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ Select to Navigate��67   $
��Left=�6Q   $��427.294,115,0,0q�6l   $	��Top=�6�   $	��176��6�   $��36��6�   $��1��6�   .@�5      �� -   5        .��5   <   Register Employee6O   �� 5      -   5        .��5   >   Update Password6O   �� 5      -   5        .��5   >   Print Report6L   �� 5      -	   5        .��5   >   Manage Users6L   5      �� 5   
   $��Admin Controls��6   $
��Left=�6)   $��427.294,76,0,0q�6D   $	��Top=�6\   $	��176��6t   $��1��6�   �� 5   
   -
   5        $��
Lbl_Roster��5      $
��Left=�6"   $��295.294,326,0,0q�6=   $	��Top=�6V   $	��203��6n   $��36��6z   $��1��6�   �� 5   
   -   5        $��Lbl_RosterValidate��5      $
��Left=�6*   $��295.294,241,0,0q�6E   $	��Top=�6^   $	��203��6v   $��36��6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��Dt_FromDate��5      $
��Left=�6(   $��106.294,241,0,0q�6C   $	��Top=�6\   $	��121��6t   $��1��6�     5    
   -   5        $��	Dt_ToDate��5       $
��Left=�6&   $��106.294,302,0,0q�6A   $	��Top=�6Z   $	��121��6r   $��1��6~   5"      5#      