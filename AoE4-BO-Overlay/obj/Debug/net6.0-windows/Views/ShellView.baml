   M S B A M L   `   `   `  ����J  FAoE4-BO-Overlay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AoE4_BO_Overlay.ViewsAoE4_BO_Overlay.Views  5   	   G(clr-namespace:AoE4_BO_Overlay.ViewModelsAoE4_BO_Overlay.ViewModels  5   	   %    AoE4_BO_Overlay.Views.ShellView   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:AoE4_BO_Overlay.Views     5   	   ?
ViewModels(clr-namespace:AoE4_BO_Overlay.ViewModels     5   	   $��20(�5        � AllowsTransparency$
  True��5	   	    � WindowStyle$
 None=�6#    � Topmost$
 True��66    � Title$ 	ShellView��5
   	   $	��200��6   $	��300��6(    � WindowStartupLocation$ CenterScreen=�64   ��5      �� 5   
    �� Opacity$ 0Q�6    �� Color$ White��6&   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� $��0��6:   $��0��6G   ��6   �� *
BuildOrder+��5      �� 5      .R�5       �  5!      �� 5"      $��80 �6/   �� 5#      $��50 �6/   �� 5$      $
��auto �6/    5'      �� 5(      $
��auto �6,   �� 5)      $
��auto �6,   .+�5,      �� $��0��6G   $��0��6W   ��6$   �� *Time+	 �� Mode$	 OneWay=�6W   �� 5-      $��1��6I   $��0��6Y   ��6$   �� *Supply+$	 OneWay=�6Y   �� 5.      $��2��6I   $��0��6Y   ��6$   �� *Action+$	 OneWay=�6Y   5/      50      52      �� 54   
   -   5        
 ��Name$
 CreateBO_Click��54      $��0��6)   $��2��66   $��40��6F   $��40��6Q   $	��Top=�6]   $��C��6u   �� 55   
   -   5        $
 ShowBO_Click��55      $��0��6'   $��3��64   $��40��6D   $��40��6O   $	��Top=�6[   $��S��6s   �� 56   
   -   5         ��Name$ 
ActiveItem��56      57      58      