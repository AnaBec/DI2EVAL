   M S B A M L   `   `   `  ����  Avituallamientos4    .Avituallamientos.vista.GestionAvituallamientos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  GestionAvituallamientos��5   	   $	��500��6)   $	��400��66   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5	      $ White��6   $ 1Q�6-   � 5
      $ 	#FF4F4F4F��6   $ 0.004Q�61   5      .+�5   
   �� -   5         ��Name$ LabelTitulo��5      $��GESTIÓN AVITUALLAMIENTOS��6%   $
��Left=�6H   $��	83,10,0,0q�6c   $	��Top=�6v   $	��229��6�   $��16(�6�   �� 5   
   -   5        $ LabelNombreCarrera��5      $��Nombre Carrera: ��6,   $
��Left=�6G   $��	31,63,0,0q�6b   $	��Top=�6u   $��99��6�    J� RenderTransformOrigin$ 0.483,1.198&�6�   �� 5   
   -   5         ��Name$ ComboBoxCarreras��5      $
��Left=�6X   $��
161,63,0,0q�6s   $	��Top=�6�   $	��202��6�   ��6-   ��  �� Path$ ListaCarreras�6�   �� 5   
   -   5        $ 
LabelAvitu��5      $��Avituallamientos:��6$   $
��Left=�6@   $��
10,114,0,0q�6[   $	��Top=�6o   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 TablaAvituallamientos��5      
   CanUserAddRows
 .     CanUserDeleteRows .     
IsReadOnly .    AutoGenerateColumns .     SelectionMode$ Single=�6%  $
��Left=�6<  $��
10,145,0,0q�6W  $	��Top=�6k  $	��105��6�  $	��373��6�  ��63   ��  �� ElementName$ ComboBoxCarreras��$( "SelectedItem.ListaAvituallamientos� �� SelectedIndex 6�   �� $ indiceAvituallamiento�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Punto kilométrico��6&   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� $ PuntoKilometrico�  5      $ Persona de contacto��6&    6C   �� $ PersonaContacto.Nombre�  5      $ 	Teléfono��6%    67   �� $! PersonaContacto.NumTelefono�  5      $ 
Materiales��6%    69   �� $% ListaProductosDisponibles.Count�5      �� 5   
   -   5         ��Name$ ButtonAnhadirNuevoAvi��5      $#��AÑADIR NUEVO AVITUALLAMIENTO��60   $
��Left=�6W   $��
83,269,0,0q�6r   $	��Top=�6�   $	��227��6�   6�   �� 5   
   -   5        $ ButtonModificarAvi��5      $��MODIFICAR AVITUALLAMIENTO��6-   $
��Left=�6Q   $��
83,307,0,0q�6l   $	��Top=�6�   $	��227��6�   6�   5      5      