   M S B A M L   `   `   `  ����C  ?Registro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RegistroRegistro  5   	       Registro.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Registro     5   	     � Title$  Registro��5   	   $	��380��6   $	��400��6'   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFC0CFF6��6    � Offset$ 0.204Q�61   � 5      $ 	#FF1A1E69��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $	��17* �6   �� 5      $	��40* �6   �� 5      $
��110* �6   .+�5   
   �� $	��ID:��6   $
��Left=�6   $��17,0,0,0q�69   $��Center=�6K   �� 5   
   $��Nombre:��6   $
��Left=�6"   $��17,1,0,0q�6=   $	��Top=�6O   $��1��6g   �� 5   
   $��	Telefono:��6   $
��Left=�6$   $��	17,37,0,0q�6?   $	��Top=�6R   $��1��6j   �� 5   
   $��Cedula:��6   $
��Left=�6"   $��	17,76,0,0q�6=   $	��Top=�6P   $��1��6h   $��2��6u   �� 5   
   $��
Direccion:��6   $
��Left=�6%   $��	17,37,0,0q�6@   $	��Top=�6S   $��2��6k   �� 5   
   $��Fecha de Nacimiento:��6   $
��Left=�6/   $��	17,75,0,0q�6J   $	��Top=�6]   $��2��6u   �� 5   
   -   5         ��Name$ 	IdTextBox��5      $��Center=�6%   $�� ��6B    �� TextWrapping$
 Wrap=�6J   $��Center=�6^   $	��120��6y   �� 5   
   -   5        $ NombreTextBox��5      $��Center=�6)   $��0,5,0,0q�6F   $��1��6W   $�� ��6d   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ TelefonoTextBox��5      $��Center=�6+   $��0,43,0,0q�6H   $��1��6Z   $�� ��6g   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ CedulaTextBox��5      $��Center=�6)   $��0,4,0,0q�6F   $��2��6W   $�� ��6d   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ DireccionTextBox��5      $��Center=�6,   $��0,41,0,0q�6I   $��2��6[   $�� ��6h   $
 Wrap=�6p   $	��Top=�6�   $	��120��6�   �� 5    
   -   5         ��Name$ BtnNuevo��5       $��Nuevo��6#   $
��Left=�63   $��
37,140,0,0q�6N   $��2��6b   $	��Top=�6o   $��30��6�   $��69��6�   6�   �� 5!   
   -   5        $ 
BtnGuardar��5!      $��Guardar��6%   $
��Left=�67   $��160,140,0,0q�6R   $��2��6g   $	��Top=�6t   $��30��6�   $��69��6�   6�   �� 5"   
   -   5        $ BtnEliminar��5"      $��Eliminar��6&   $
��Left=�69   $��277,140,0,0q�6T   $��2��6i   $	��Top=�6v   $��30��6�   $��69��6�   �� 5#   
   $��Buscar��6   $
��Left=�6"   $��
310,10,0,0q�6=   $	��Top=�6Q   $��2��6i   $��30��6z   $��69��6�   r� 5$   
   $
��Left=�6   $	��100��62   $��
610,50,0,0q�6?   $��2��6S   $	��Top=�6`   $	��100��6x   (  "System.Windows.Controls.DatePicker  5%   
   -	   5        	  Name$#	 FechaNacimientoDateTimePicker��5%      $��141,75,87,119q�6<   $��2��6S   5'      5(      