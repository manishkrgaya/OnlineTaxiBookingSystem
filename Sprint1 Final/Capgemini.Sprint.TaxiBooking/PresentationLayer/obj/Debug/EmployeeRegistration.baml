   M S B A M L   `   `   `  ����L  HPresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PresentationLayerPresentationLayer  5   	   ,    &PresentationLayer.EmployeeRegistration   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PresentationLayer     5   	     � Title$  EmployeeRegistration��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   �� $��Employee Name��6   $
��Left=�6(   $��	72,95,0,0q�6C   $	��Top=�6V   $	��117��6n   $��33��6z   �� 5   
   $��Phone Number��6   $
��Left=�6'   $��
72,143,0,0q�6B   $	��Top=�6V   $	��117��6n   $��33��6z   �� 5   
   $��EmailID��6   $
��Left=�6"   $��
72,192,0,0q�6=   $	��Top=�6Q   $	��117��6i   $��33��6u   �� 5   
   $��Address��6   $
��Left=�6"   $��
72,242,0,0q�6=   $	��Top=�6Q   $	��117��6i   $��33��6u   �� 5   
   $��Driving Licence Number��6   $
��Left=�61   $��
72,293,0,0q�6L   $	��Top=�6`   $	��141��6x   $��33��6�   �� 5   
   $��Login ID��6   $
��Left=�6#   $��411,196,0,0q�6>   $	��Top=�6S   $	��141��6k   $��33��6w   �� 5   
   $��Password��6   $
��Left=�6#   $��411,245,0,0q�6>   $	��Top=�6S   $	��141��6k   $��33��6w   �� 5   
   -   5        $��Txt_EmployeeName��5      $
��Left=�6*   $��23��6E   $��
238,95,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $��Txt_PhoneNumber��5      $
��Left=�6)   $��23��6D   $��238,143,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $��Txt_EmailID��5      $
��Left=�6%   $��23��6@   $��238,192,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $��Txt_Address��5      $
��Left=�6%   $��23��6@   $��238,242,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $��Txt_DrivingLicenceNumber��5      $
��Left=�62   $��23��6M   $��238,293,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $��Txt_EmployeeLogIn��5      $
��Left=�6+   $��23��6F   $��598,196,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $��Txt_EmployeePassword��5      $
��Left=�6.   $��23��6I   $��598,245,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5   
   $ ��Enter New Employee Details��6   $
��Left=�65   $��	72,33,0,0q�6P   $	��Top=�6c   $	��295��6{   �� 5   
   -   5        $��Btn_Register��5      $��Register Employee��6%   $
��Left=�6A   $��411,336,0,0q�6\   $	��Top=�6q   $	��120��6�   $��33��6�    J� RenderTransformOrigin$ 0.502,2.276&�6�   �� 5   
   -	   5        $��	Btn_Clear��5      $��Clear��6"   $
��Left=�62   $��617,336,0,0q�6M   $	��Top=�6b   $	��101��6z   $��33��6�   6�   �� 5   
   -
   5        $��Lbl_Register��5      $�� ��6$   $
��Left=�6/   $��
411,95,0,0q�6J   $	��Top=�6^   $	��170��6v   $��36��6�   �� 5   
   $��Admin Controls��6   $
��Left=�6)   $��
617,41,0,0q�6D   $	��Top=�6X   $	��145��6p   $��34��6|   �� 5   
    �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ Select to Navigate��67   $
��Left=�6Q   $��
598,71,0,0q�6l   $	��Top=�6�   $	��164��6�   $��33��6�   .@�5      �� -   5        .��5   =   Change Password6N   �� 5      -   5        .��5   >   Manage Weekly Roster6T   �� 5       -   5        .��5    >   Print Report6L   �� 5!      -   5        .��5!   >   Manage Users6L   5"      �� 5#   
   -   5        $��Lbl_RegistrationValidate��5#      $�� ��60   $
��Left=�6;   $��
44,336,0,0q�6V   $	��Top=�6j   $	��337��6�   $��36��6�   5$      5%      