   M S B A M L   `   `   `  ���� !  ProjektProgramowanieObiektowe.    (ProjektProgramowanieObiektowe.WindowBase   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  
WindowBase��$	��345��$	��650�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�
����İ�.��� .+�� .+��� "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��   AnimatedSource$ Gif/bg2.gif��$��-80,-28,-27.4,-0.2q���  �� Orientation$ 
Horizontal=�$	��Top=�$
��Left=�$
��20 0q�.+��� -    ��Name$ ButtonLogOut��$��Center=� 0  ,MaterialDesignFloatingActionMiniAccentButton#��[  ��Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�
���  ��$��25��$��25��� $	��103��$��Bottom=�$��0,0,-0.4,-0.2q����� 	 �� Color$	 Black��
 �� Opacity$	
 0.4Q�.+�'  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�   	StaysOpen .  ���#f6047b$��26,0,0,0q�   ToggleContent   $ PlayCircleFilled=����#f6047b$	��100��$	��100��   PopupContent. �� $	��150��.+��� -   $
��Load���� -   $��Update���� -   $	��Add���� -   $��Delete���� �� $��30��$	��Top=� �� RadiusY$ 10�� �� RadiusX$ 10��
�������$��250,10,60,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 15Q�   	Direction$ 0Q�   RenderingBias$ Quality=�   ShadowDepth$ 1Q�   Color$ 	#FFBBBBBB���� -   $��txtName��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name�� % !MaterialDesignFloatingHintTextBox#��[ $��Champagne & Limousines)�$��18(� J� RenderTransformOrigin$ 0.518,0.075&�$��261,-4,79,63q��� $��30��$	��Top=�$ 10��$ 10��
�������$��250,55,249,0q�   $ 15Q�$ 0Q�$ Quality=�$ 1Q�$ 	#FFBBBBBB���� -   $��txtID��$ ID��#��[ $��Champagne & Limousines)�$��18(�$ 0.518,0.075&�$��261,40,263,18q��� $��30��$	��Top=�$ 10��$ 10��
�������$��427,55,60,0q�   $ 15Q�$ 0Q�$ Quality=�$ 1Q�$ 	#FFBBBBBB���� -   $��txtScore��$ Score��#��[ $��Champagne & Limousines)�$��18(�$ 0.518,0.075&�$��439,40,71,18q�&   System.Windows.Controls.DataGrid  -	   $��	DataGrid1��   AutoGenerateColumns . $��Center=�$	��180��$	��320��$��160,40,170,125q����� $	 Black��$	
 0.2Q�