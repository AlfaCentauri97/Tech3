   M S B A M L   `   `   `  ����!  ProjektProgramowanieObiektowe.    (ProjektProgramowanieObiektowe.WindowHome   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
WindowHome��5   	   $	��345��6   $	��650��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � WindowStyle$
 None=�6p   
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
 0.4Q�60   .+�5      �� $��Bottom=�6   $	��103��62   
����İ�.@�5      �� $��Center=�6   $��Center=�6:   .��5      �� -   5        $��PC Games��5      $	��230��60   
 J� Uid$ 0��6i   ��6<   Z� ��6R   Z� 6r   5      �� 5      $��Center=�6   $��Center=�6:   .��5      �� $ 
Horizontal=�6!   .+�5      �� -   5        $��Consola Games��5   !   $	��230��69   $ 1��6s   ��6E   Z� ��6[   Z� 6{     5      $ WheelchairAccessibility=�62   $��25��6Q   ���#0cb4b6$��10q�6q   $��25��6}   $��Center=�6�   5      5      �� 5      $��Center=�6   $��Center=�6:   .��5       �� $ 
Horizontal=�6!   .+�5!      �� -   5        $��Arcade Games��5!   !   $	��230��68   $ 2��6q   ��6D   Z� ��6Z   Z� 6y   5"      5#      �� 5$      $��Center=�6   $��Center=�6:   .��5%      �� $ 
Horizontal=�6!   .+�5&      �� -   5        $��	GBA Games��5&   !   $	��230��65   $ 3��6o   ��6A   Z� ��6W   Z� 6w   5'      5(      �� 5)      $��Center=�6   $��Center=�6:   .��5*      �� $ 
Horizontal=�6!   .+�5+      �� -   5        $��Mobile Games��5+   !   $	��230��68   $ 4��6r   ��6D   Z� ��6Z   Z� 6z   5,      5-      5.      5/      &   System.Windows.Controls.DataGrid  50   
   -   5        $��	DataGrid1��50         AutoGenerateColumns . $��Center=�6?   $	��180��6\   $	��320��6i   $��160,40,170,125q�6u   ��51      �� 52      $	 Black��6"   $	
 0.2Q�60   54      55      56      