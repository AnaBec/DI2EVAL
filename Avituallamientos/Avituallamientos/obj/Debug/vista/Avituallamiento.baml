   M S B A M L   `   `   `  ����  Avituallamientos,    &Avituallamientos.vista.Avituallamiento   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Avituallamiento��5   	   $	��500��6!   $	��400��6.   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5	      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5
      $ White��6   $ 1Q�6-   � 5      $ 	#FF393939��6   $ 0.004Q�61   5      .+�5   
   �� -   5         ��Name$ LabelTitulo��5      $��AVITUALLAMIENTOS��6%   $
��Left=�6@   $��
113,10,0,0q�6[   $	��Top=�6o   $��16(�6�   �� 5   
   -   5        $ LabelCarrera��5      $��Nombre carrera��6&   $
��Left=�6?   $��	36,59,0,0q�6Z   $	��Top=�6m   �� 5   
   -   5        $ LabelKm��5      $��Punto kilométrico��6!   $
��Left=�6=   $��	31,90,0,0q�6X   $	��Top=�6k   �� 5   
   -   5        $ LabelContacto��5      $��Persona de contacto:��6'   $
��Left=�6F   $��
10,134,0,0q�6a   $	��Top=�6u   �� 5   
   -   5         ��Name$ TextBoxNombreCarrera��5      $
��Left=�6U   $��23��6p   $��
161,65,0,0q�6|    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��187��6�   ��60   ��  �� Path$ NombreCarrera�6�   �� 5   
   -   5        $ 	TextBoxKm��5      $
��Left=�6M   $��23��6h   $��
161,93,0,0q�6t   $
 Wrap=�6�   $	��Top=�6�   $	��187��6�   ��6&   �� $ PuntoKilometrico�6�   �� 5   
   -   5        $ LabelNombre��5      $��Nombre��6%   $
��Left=�66   $��
80,165,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ LabelTelefono��5      $��	Teléfono��6'   $
��Left=�6:   $��
75,195,0,0q�6U   $	��Top=�6i   �� 5   
   -	   5        $ TextBoxNombre��5      $
��Left=�6O   $��23��6j   $��161,169,0,0q�6v   $
 Wrap=�6�   $	��Top=�6�   $	��187��6�   ��6*   �� $ Persona.Nombre�6�   �� 5   
   -
   5        $ TextBoxTelefono��5      $
��Left=�6V   $��23��6q   $��161,195,0,0q�6}   $
 Wrap=�6�   $	��Top=�6�   $	��187��6�   ��6+   �� $ Persona.NumTelefono�6�   �� 5   
   -   5        $ LabelDisponible��5      $��Productos disponibles:��6)   $
��Left=�6J   $��
10,241,0,0q�6e   $	��Top=�6y   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 TablaProductosAvitu��5      
   
IsReadOnly
 .    AutoGenerateColumns .  $
��Left=�6�   $��
10,272,0,0q�6�   $	��Top=�6�   $	��111��6�   $	��373��6�   ��60   �� $ ListaProductosDisponibles�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� $ Nombre�  5      $ Tipo material��6%    .  6N   �� $
 Tipo�  5      $ Precio��6%    .    MinWidth$ 75Q�6G    6U   �� $ Precio�  5      $ Cantidad��6%   $ 20Q�67   5       �� 5!   
   -   5         ��Name$ ButtonAnhadirProductos��5!      $��AÑADIR PRODUCTOS��61   $
��Left=�6L   $��102,388,0,0q�6g   $	��Top=�6|   $	��190��6�   6�   �� 5"   
   -   5        $ ButtonAceptar��5"      $��ACEPTAR��6(   $
��Left=�6:   $��
36,426,0,0q�6U   $	��Top=�6i   $	��151��6�   6�   �� 5#   
   -   5        $ ButtonCancelar��5#      $��CANCELAR��6)   $
��Left=�6<   $��197,426,0,0q�6W   $	��Top=�6l   $	��151��6�   6�   5%      5&      