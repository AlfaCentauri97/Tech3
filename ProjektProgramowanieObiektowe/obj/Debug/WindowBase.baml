   M S B A M L   `   `   `  ����!  ProjektProgramowanieObiektowe.    (ProjektProgramowanieObiektowe.WindowBase   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
WindowBase��5   	   $	��345��6   $	��650��6)    � 
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
 0.4Q�60   .+�5      '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6'      	StaysOpen .  ���#f6047b$��26,0,0,0q�6w      ToggleContent 5        5      $ PlayCircleFilled=�6.   ���#f6047b$	��100��6[   $	��100��6g      PopupContent. 5      �� $	��150��6   .+�5      �� -   5        $
��Load��5      6,   �� 5      -   5        $��Update��5      6.   �� 5      -   5        $	��Add��5      6+   �� 5      -   5        $��Delete��5      6.   �� 5      5       5!      �� 5#      $��30��6   $	��Top=�6$    �� RadiusY$ 10��6=    �� RadiusX$ 10��6J   
�������$��250,10,60,0q�6d    J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]      Color$ 	#FFBBBBBB��6m   5'      �� 5(      -   5        $��txtName��5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��6&    % !MaterialDesignFloatingHintTextBox#��[ 6L   $��Champagne & Limousines)�6�   $��18(�6�    J� RenderTransformOrigin$ 0.518,0.075&�6�   $��261,-4,79,63q�6�   �� 5*      $��30��6   $	��Top=�6$   $ 10��6=   $ 10��6J   
�������$��250,55,249,0q�6d    5+        5,      $ 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ 	#FFBBBBBB��6m   5.      �� 5/      -   5        $��txtID��5/      $ ID��6$   #��[ 6H   $��Champagne & Limousines)�6�   $��18(�6�   $ 0.518,0.075&�6�   $��261,40,263,18q�6�   �� 51      $��30��6   $	��Top=�6$   $ 10��6=   $ 10��6J   
�������$��427,55,60,0q�6f    52        53      $ 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ 	#FFBBBBBB��6m   55      �� 56      -   5        $��txtScore��56      $ Score��6'   #��[ 6N   $��Champagne & Limousines)�6�   $��18(�6�   $ 0.518,0.075&�6�   $��439,40,71,18q�6�   59      &   System.Windows.Controls.DataGrid  5:   
   -	   5        $��	DataGrid1��5:         AutoGenerateColumns . $��Center=�6?   $	��180��6\   $	��320��6i   $��160,40,170,125q�6u   ��5;      �� 5<      $	 Black��6"   $	
 0.2Q�60   5>      5?      5@      