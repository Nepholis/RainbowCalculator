   M S B A M L   `   `   `  ���� L  HRainbowCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RechnerV1	RechnerV1  "    RainbowCalculator.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:RechnerV1       � Title$#  Rainbow-Calculator ~ Nepholis��$��20(�$	��700��$	��710�� � 
ResizeMode$ NoResize=����	#FF1DBEA5 � WindowStartupLocation$ CenterScreen=�.��� $��0,0,0,0q� +� FocusedElement ��  �� ElementName$ InputBox������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��� $ 	#FFD9FFE2�� � Offset$ 1Q�.+��� -   	 ��Name$	 Button_Clear��$
��Left=�$��60��$��	0,150,0,0q�$	��Top=�$��97�����	#FFFF0505$��16(�
�������.���� $��39��$��45��$��/Resources/trash_icon.png���� -   
 ��Name$
 InputBox��$
��Left=�$	��120�� �� TextWrapping$
 Wrap=�$	��Top=�$	��400��$��36(����	#FFF3F3F3 �� SelectionBrush �	#FFD70000 �� MaxLines$ 1��4  .System.Windows.Automation.AutomationProperties   HelpText$! Enter Your Calculation Here�� �� 	MaxLength$ 40���� $
��Left=�$��50��$��	410,0,0,0q�$��History��$
��Wrap=�$	��Top=�$	��290��
�������$��36(� �� TextAlignment$ Center=����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ 	#FF178764��$ 1Q��� -   $
 ErrorLog��$��Center=�$��60�� �� 
IsReadOnly$
 True��$��False��$��	0,624,0,0q�$	��719�����	#FFC9EDD2���	#FF1DBEA5$��20(��� -   $	 Button_DeleteLast��$��<-��$
��Left=�$��60��$��304,150,0,0q�$	��Top=�$��97�����	#FF164B43$��16(�
��������� -   $	 
Button_Del��$	��Del��$
��Left=�$��60��$��202,150,0,0q�$	��Top=�$��97�����	#FF164B43$��16(�
��������� -   $	 Button_Root��$	��√��$
��Left=�$��60��$��	0,215,0,0q�$	��Top=�$��97�����	#FF1DBEA5$��16(��� -   $	 
Button_Pow��$��^��$
��Left=�$��60��$��101,215,0,0q�$	��Top=�$��97�����	#FF1DBEA5$��16(��� -   $	 	Button_Ln��$��ln��$
��Left=�$��60��$��202,215,0,0q�$	��Top=�$��97�����	#FF1DBEA5$��16(��� -	   $	 Button_Bracket_Left��$��(��$
��Left=�$��60��$��	0,280,0,0q�$	��Top=�$��97�����	#FF1DBEA5$��16(��� -
   $	 Button_Bracket_Right��$��)��$
��Left=�$��60��$��101,280,0,0q�$	��Top=�$��97�����	#FF1DBEA5$��16(��� -   $	 
Button_Log��$	��log��$
��Left=�$��60��$��202,280,0,0q�$	��Top=�$��97�����	#FF1DBEA5$��16(��� -   $	 Button_7��$��7��$
��Left=�$��60��$��	0,345,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_8��$��8��$
��Left=�$��60��$��101,345,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_9��$��9��$
��Left=�$��60��$��202,345,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_Plus��$��+��$
��Left=�$��60��$��304,345,0,0q�$	��Top=�$��97�����	#FF03FFD8$��24(��� -   $	 Button_4��$��4��$
��Left=�$��60��$��	0,410,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_5��$��5��$
��Left=�$��60��$��101,410,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_6��$��6��$
��Left=�$��60��$��202,410,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_Minus��$��-��$
��Left=�$��60��$��304,410,0,0q�$	��Top=�$��97�����	#FF03FFD8$��24(��� -   $	 Button_1��$��1��$
��Left=�$��60��$��	0,475,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_2��$��2��$
��Left=�$��60��$��101,475,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 Button_3��$��3��$
��Left=�$��60��$��202,475,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 
Button_Mul��$��×��$
��Left=�$��60��$��304,475,0,0q�$	��Top=�$��97�����	#FF03FFD8$��24(��� -   $	 Button_0��$��0��$
��Left=�$��60��$��	0,540,0,0q�$	��Top=�$	��198�����	#FFA7FFF1$��16(��� -   $	 Button_Point��$��.��$
��Left=�$��60��$��202,540,0,0q�$	��Top=�$��97�����	#FFA7FFF1$��16(��� -   $	 
Button_Div��$��÷��$
��Left=�$��60��$��304,540,0,0q�$	��Top=�$��97�����	#FF03FFD8$��24(��� -   $	 Button_Solve��$��=��$
��Left=�$��60��$��304,280,0,0q�$	��Top=�$��97�����	#FF03FFD8$��24(��� -   $	 
Button_Ans��$	��Ans��$
��Left=�$��60��$��304,215,0,0q�$	��Top=�$��97�����	#FF03FFD8$��16(��� -    ��Name$ 
HistoryBox��$
��Left=�$	��550��$��
410,50,0,0q�$	��Top=�$	��290�����	#FFA7FFF1$��Visible=�$
��True�� �� PanningRatio$ 50Q�