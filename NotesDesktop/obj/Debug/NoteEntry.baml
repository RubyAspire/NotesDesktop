   M S B A M L   `   `   `  ����G  CNotesDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NotesDesktopNotesDesktop  5   	       NotesDesktop.NoteEntry   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:NotesDesktop     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 	NoteEntry��5	   	   $	��407��6   $	��300��6(   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$	 Top��5      $��0��5       �� Orientation$ 
Horizontal=�5      
������.+�5      �� -   5        $
��Back��5      $��0q�5      $	��100��5      $��20(�5      $
��Left=�5      ��5      ��  �� ElementName$	 Top�� �� Path$ 
Background�5      5      �� 5   
   -   5        $��txtEntry��5       $��1��5      $	��328��5       �� AcceptsReturn . $��15(�5#      $��5q�5$       �� TextWrapping$
 Wrap=�5%      $��0q�5&      ��5"      �� *Text+5&      �� 5'   
   $��2��6   $ 
Horizontal=�5(      .+�5)      �� -   5        $
��Save��5)      ���	#FF00FF0C
�������$��0q�5-      $��28��5.      $	��300��5/      51      53      54      