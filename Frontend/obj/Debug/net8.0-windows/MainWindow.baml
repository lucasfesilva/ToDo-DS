   M S B A M L   `   `   `  ����C  ?Frontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FrontendFrontend  5   	       Frontend.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Frontend     5   	     � Title$  Lista de Tarefas��5   	   $	��629��6"   $
��1166��6/   ���#F4F4F4 � WindowStartupLocation$ CenterScreen=�5	      .��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Lista de Tarefas��6   $��24(�5      $
��Bold"�5      ���#333$��Center=�5      $��10q�5      �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��10q�69   $
��Left=�6E   .+�5      �� $ 
Horizontal=�6   $��10,5,0,0q�62   .+�5      �� $��Filtrar:��6   $��14(�5      $��Center=�5      ���#555$��0,0,10,0q�5       �� 5"      
������� �� CornerRadius$ 8��6,    �� Padding$ 2q�6=   ���#CCC$��1q�6\   $��15,0,0,0q�6p   ._�5#      �� $	��150��6   $��14(�6+   .@�5$      �� $��Todos��6'   �� 5%      $��Em progresso��6'   �� 5&      $��Pendente��6'   �� 5'      $��
Concluído��6'   5(      5)      �� 5*      -   5        $��Nova Tarefa��5*      ���#4CAF50
�������$��80��5-      $��30��6   $��0q�5.       � Cursor$
 Hand��5/      $��Right=�50      $��1��51      $��10,5,0,0q�52      53      54      55      �� 57   
   $��3��6   
�������$ 10��61   $ 5q�6C   ���#CCC$��1q�6b   ._�58      �� -   5         ��Name$ ListaTarefas��58   "   $��5q�6    �� View 59      �� 5:      .P�5;      �� $��ID��6)   	 �� Width$	 50��65   
 �� DisplayMemberBinding
 6@   �� *Id+�� 5<      $��Tarefa��6)   $		 250��69   
 6E   �� *Titulo+�� 5=      $��Descrição��6)   $		 160��6<   
 6H   �� *	Descricao+�� 5>      $��Data de Criação��6)   $		 160��6B   
 6N   �� *
CriadoEm+�� 5?      $��Data de Conclusão��6)   $		 160��6D   
 6P   �� *ConcluidoEm+�� 5@      $��Status��6)   $		 160��69   
 6E   �� *Status+�� 5A      $��Ações��6)   $		 160��68    �� CellTemplate 5B      �� 5C   "   .R�5D   &   �� $ 
Horizontal=�61   $��Center=�6J   .+�5E   *   �� -   5        $��✏️��5E   1    � ToolTip$ Alterar��5F   -   ���#FFC107
�������$��35��5I   -   $��25��68   $��0q�5J   -   $
 Hand��5K   -   $��	{Binding}��5O   G   5P   +   �� 5Q   *   $��🗑️��61   $ Deletar��5R   1   ���#F44336
�������$��35��5U   1   $��25��6<   $��0q�5V   1   $
 Hand��5W   1   5X   '   5Y   #   5[      5\      5^      5_      5a      5b      