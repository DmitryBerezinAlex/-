   M S B A M L   `   `   `  ����K  GTechnicalRequest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TechnicalRequestTechnicalRequest  5   	   %    TechnicalRequest.StudentsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TechnicalRequest     5   	   -   5          �Name$  
StudWindow��5   	    � Title$ Ученики��5   	   $	��450��6   $��833.521��6&   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ StudentGrid��5         AutoGenerateColumns . $
��Left=�6C   $	��400��6^   $��	10,10,0,0q�6k   $	��Top=�6~   $	��474��6�   �� 5   
   -   5         ��Name$ DeleteButton��5      $��Удалить��6'   $
��Left=�69   $��
489,10,0,0q�6T   $	��Top=�6h   $��85��6�   $��30��6�   6�   �� 5   
   -   5        $ RedactButton��5      $ ��Редактировать��6'   $
��Left=�6?   $��
489,70,0,0q�6Z   $	��Top=�6n   $��98��6�   $��30��6�   6�   �� 5   
   -   5        $ 	AddButton��5      $��Добавить��6$   $
��Left=�67   $��
614,10,0,0q�6R   $	��Top=�6f   $��85��6~   $��30��6�   6�   �� 5   
   -   5        $��LastNameBox��5   -   $
��Left=�6   $��33��6@   $��489,142,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��154��6�   �� 5   
   -   5        $��FirstNameBox��5   -   $
��Left=�6   $��33��6A   $��489,197,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��154��6�   �� 5   
   -   5        $��MiddleNameBox��5   -   $
��Left=�6   $��33��6B   $��489,258,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��154��6�   �� 5   
   $
��Left=�6   $��649,143,0,0q�6/   $
��Wrap=�6D   $��Фамилия*��6X   $	��Top=�6h   $��32��6�   $��67��6�   �� 5   
   $
��Left=�6   $��649,197,0,0q�6/   $
��Wrap=�6D   $��Имя*��6X   $	��Top=�6d   $��32��6|   $��67��6�   �� 5   
   $
��Left=�6   $��649,259,0,0q�6/   $
��Wrap=�6D   $��Отчество��6X   $	��Top=�6h   $��32��6�   $	��157��6�   �� 5   
   -	   5        $��
HelpButton��5   8   $��?��6   $
��Left=�6   $��20(�6J   $��
782,10,0,0q�6X   $	��Top=�6l   $��35��6�   $��25��6�   6�   �� 5   
   $
��Left=�6   $��614,316,0,0q�6/   $
��Wrap=�6D   $��Класс*��6X   $	��Top=�6f   $��32��6~   $��67��6�   �� 5   
   -
   5         ��Name$ ClassBox��5   .   $
��Left=�6    �� DisplayMemberPath$
 Name��6@   $��488,316,0,0q�6Y   $	��Top=�6n   $	��120��6�   5      5      