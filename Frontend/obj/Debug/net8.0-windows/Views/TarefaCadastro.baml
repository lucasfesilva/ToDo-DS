   M S B A M L   `   `   `  ����  Frontend#    Frontend.Views.TarefaCadastro   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Nova Tarefa��5   	   $	��350��6   $	��450��6*   ���#FFFFFF � WindowStyle$
 None=�6K    � 
ResizeMode$ NoResize=�6^    � WindowStartupLocation$ CenterScreen=�6t   .��5      ��  �� CornerRadius$ 10��6   ���#CCCCCC$��2q�65   ���#F9F9F9 �� Padding$ 15q�6^   ._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5	      $
��Auto �6    �� 5
      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��Nome da Tarefa��6   $��0��6.   $��0��6;   $��Center=�6K   $��14(�6f   $��SemiBold"�6t   �� 5      -   5         ��Name$ txtNome��5      $��0��6'   $��1��64   $��5q�6D   $��8q�6O   $��1q�6[   ���#CCCCCC���#FFFFFF6�   �� 5      $��Descrição��6   $��1��6)   $��0��66   $��Center=�6F   $��14(�6a   $��SemiBold"�6o   �� 5      -   5        $ txtDescricao��5      $��1��6,   $��1��69   $��5q�6I   $��8q�6T   	 �� AcceptsReturn$
	 True��6`   $��60��6u   $��1q�6�   ���#CCCCCC���#FFFFFF6�   �� 5      $��Status��6   $��2��6&   $��0��63   $��Center=�6C   $��14(�6^   $��SemiBold"�6l   �� 5      -   5        
 ��Name$
 	cmbStatus��5      $��2��6*   $��1��67   $��5q�6G   $��8q�6R   $��1q�6^   ���#CCCCCC���#FFFFFF.@�5      �� $��	Pendentes��6   �� 5      $��EmProgresso��6   �� 5      $��
Concluída��6   5      �� 5!      $��Data de Criação��6   $��3��6/   $��0��6<   $��Center=�6L   $��14(�6g   $��SemiBold"�6u   (  "System.Windows.Controls.DatePicker  5"      -   5          Name$ 
dtpCriacao��5"      $��3��6-   $��1��6:   $��5q�6J   $��8q�6U   $��1q�6a   ���#CCCCCC���#FFFFFF6�   �� 5$      $��Data de Conclusão��6   $��4��61   $��0��6>   $��Center=�6N   $��14(�6i   $��SemiBold"�6w     5%      -   5        $ dtpConclusao��5%      $��4��6/   $��1��6<   $��5q�6L   $��8q�6W   $��1q�6c   ���#CCCCCC���#FFFFFF6�   �� 5'      $��5��6   $��2��6&    �� Orientation$ 
Horizontal=�6:   $��Right=�6S   $��10q�6o   .+�5(      �� -   5        $��Cancelar��5(      $	��100��6,   $��35��68   $��5q�6D   ���#FF5C5C
�������$��SemiBold"�6�   $��0q�6�   �� 5)      -   5        $��Gravar��5)      $	��100��6*   $��35��66   $��5q�6B   ���#4CAF50
�������$��SemiBold"�6�   $��0q�6�   5*      5+      5,      5-      