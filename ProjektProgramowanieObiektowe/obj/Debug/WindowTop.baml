   M S B A M L   `   `   `  ����!  ProjektProgramowanieObiektowe-    'ProjektProgramowanieObiektowe.WindowTop   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	WindowTop��5   	   $	��345��6   $	��650��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o   
����İ�.��5      � .+�5	   
   � .+�5
      �� "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��6      AnimatedSource$ Gif/bg2.gif��6?   $��-80,-28,-27.4,-0.2q�6n   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $
��Left=�6F   $
��20 0q�6a   .+�5      �� -   5         ��Name$ ButtonLogOut��5      $��Center=�6X    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6s   ��6+   Z� ��6A   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6*   
���  ��$��25��6L   $��25��6W   5      5      � 5   
   $	��103��6   $��Bottom=�6   $��0,0,-0.4,-0.2q�67   ��5      �� 5      	 �� Color$	 Black��6"   
 �� Opacity$	
 0.4Q�60   .+�5      � -   5         �Name$ 
GridCursor��5      $	��100��6'   $��5��63   ���	#FF2196F3$
��Left=�6U   $��	0,72,0,26q�6p   �� 5      $ 
Horizontal=�6   $	��Top=�62   $��0,27,0,0q�6J   .+�5      �� -   5        $	��100��5      $��PC��6&   $��50��63   ���	#FF2196F3
 J� Uid$ 0��6�   ��6?   Z� ��6U   Z� 6�   �� 5      -   5        $	��100��5      $��Consol��6&   $��50��67   ���	#FF2196F3$ 1��6�   ��6C   Z� ��6Y   Z� 6�   �� 5      -   5        $	��100��5      $��Arcade��6&   $��50��67   ���	#FF2196F3$ 2��6�   ��6C   Z� ��6Y   Z� 6�   �� 5      -   5        $	��100��5      $��Mobile��6&   $��50��67   ���	#FF2196F3$ 3��6�   ��6C   Z� ��6Y   Z� 6�   �� 5      -   5        $	��100��5      $	��GBA��6&   $��50��64   ���	#FF2196F3$ 4��6�   ��6@   Z� ��6V   Z� 6�   �� 5      -   5        $	��100��5      $
��Base��6&   $��50��65   ���	#FF2196F3$ 5��6�   ��6A   Z� ��6W   Z� 6�   5      5      &   System.Windows.Controls.DataGrid  5   
   -	   5        $��	DataGrid1��5         AutoGenerateColumns . $��Center=�6?   $	��180��6\   $	��320��6i   $��160,40,170,125q�6u   ��5       �� 5!      $	 Black��6"   $	
 0.2Q�60   5#      5$      5%      