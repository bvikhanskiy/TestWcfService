   M S B A M L   `   `   `  ����B  >GClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GClientGClient  5   	       GClient.AddOrderWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:GClient     5   	     � Title$  AddOrderWindow��5   	   $��262.181��6    $��520.657��61   .��5	      � $��0,0,2,-2q�6   .+�5
   
   �� -   5         ��Name$ 
cbCustomer��5
      $
��Left=�6'   $��
157,10,0,0q�6B   $	��Top=�6V   $	��274��6n   6z   �� 5   
   $��Customer name:��6   $
��Left=�6)   $��	10,10,0,0q�6D   $	��Top=�6W   $	��142��6o   �� 5   
   -   5        $ cbInventory��5      $
��Left=�6(   $��
157,41,0,0q�6C   $	��Top=�6W   $	��274��6o   6{   �� 5   
   $��Inventory name:��6   $
��Left=�6*   $��	10,41,0,0q�6E   $	��Top=�6X   $	��142��6p   �� 5   
   $��Event date:��6   $
��Left=�6&   $��	10,72,0,0q�6A   $	��Top=�6T   $	��142��6l   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtpEventDate��5      $
��Left=�6+   $��
157,74,0,0q�6F   $	��Top=�6Z   $	��274��6r   6~   �� 5   
   -   5         ��Name$ btnAdd��5      $
��Add ��6!   $
��Left=�60   $��157,201,0,0q�6K   $	��Top=�6`   $��75��6x   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��306,201,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   $��Comment:��6   $
��Left=�6#   $��
10,103,0,0q�6>   $	��Top=�6R   $	��142��6j   �� 5   
   -   5         ��Name$ 
txtComment��5      $
��Left=�6&   $��79��6A   $��157,106,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��274��6�   6�   5      5      