   M S B A M L   `   `   `  ����  Avituallamientos'    !Avituallamientos.vista.Productos2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Productos2��5   	   $	��415��6   $	��400��6)   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5	      $ White��6   $ 1Q�6-   � 5
      $ 	#FF4F4F4F��6   $ 0.004Q�61   5      .+�5   
   �� -   5         ��Name$ LabelNombre��5      $��Nombre��6%   $
��Left=�66   $��	31,55,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        $ 	LabelTipo��5      $
��Tipo��6#   $
��Left=�62   $��	52,88,0,0q�6M   $	��Top=�6`   �� 5   
   -   5        $ LabelPrecio��5      $��Precio��6%   $
��Left=�66   $��
44,128,0,0q�6Q   $	��Top=�6e    J� RenderTransformOrigin$ -0.407,0.779&�6}   �� 5   
   -   5         ��Name$  ButtonAnhadirNuevoProducto��5      $��AÑADIR/MODIFICAR��65   $
��Left=�6P   $��
95,170,0,0q�6k   $	��Top=�6   $	��206��6�   6�   �� 5   
   -   5         ��Name$ TextBoxPrecio��5      $
��Left=�6�   $��23��6�   $��121,128,0,0q�6�   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��217��6�   ��6*   �� 
 �� Path$
 producto.Precio� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6�   �� 5   
   -   5         ��Name$ ComboBoxTipo��5      $
��Left=�6�   $��
121,92,0,0q�6�   $	��Top=�6�   $	��217��6�   ��6)   �� $
 TiposMaterial� �� SelectedItem 6T   �� $
 producto.Tipo�6�   �� 5   
   -   5        $ TextBoxNombre��5      $
��Left=�6�   $��23��6�   $��
121,55,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��217��6�   ��6*   �� $
 producto.Nombre� .  . 6�   �� 5   
   -   5        $ LabelTitulo��5      $��GESTIÓN PRODUCTOS��6%   $
��Left=�6A   $��
121,10,0,0q�6\   $	��Top=�6p   $	��180��6�   $��16(�6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ TablaProductosTotales��5         AutoGenerateColumns .     
IsReadOnly . $
��Left=�6�   $��
10,207,0,0q�6�   $	��Top=�6�   $	��101��6�   $	��373��6�   ��62   �� $
 ListaProductos�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� $
 Nombre�  5      $ Tipo Material��6%    .  6N   �� $

 Tipo�  5      $ Precio��6%    .  6G   �� $
 Precio�5      �� 5   
   -
   5        $ ButtonModificar��5      $��	MODIFICAR��6*   $
��Left=�6>   $��
31,333,0,0q�6Y   $	��Top=�6m   $��75��6�   6�   �� 5   
   -   5        $ ButtonEliminar��5      $��ELIMINAR��6)   $
��Left=�6<   $��152,333,0,0q�6W   $	��Top=�6l   $��75��6�   6�   �� 5   
   -   5        $ ButtonCerrar��5      $��CERRAR��6'   $
��Left=�68   $��284,333,0,0q�6S   $	��Top=�6h   $��75��6�   6�   5       5!      