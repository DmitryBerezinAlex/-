   M S B A M L   `   `   `  ����K  GTechnicalRequest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TechnicalRequestTechnicalRequest  5   	   $    TechnicalRequest.StudentRedact   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TechnicalRequest     5   	   -   5          � Title$  StudentRedact��5   	   $	��450��6   $��776.8��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
RedactGrid��5
         AutoGenerateColumns . $
��Left=�6B   $	��242��6]   $��	10,20,0,0q�6j   $	��Top=�6}   $	��474��6�   �� 5   
   -   5         ��Name$ RedactButton��5      $��Изменить��6'   $
��Left=�6:   $��
489,10,0,0q�6U   $	��Top=�6i   $��98��6�   $��30��6�   6�   �� 5   
   -   5        $��LastNameBox��5   -   $
��Left=�6   $��33��6@   $��492,114,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��154��6�   �� 5   
   -   5        $��FirstNameBox��5   -   $
��Left=�6   $��33��6A   $��492,168,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��154��6�   �� 5   
   -   5        $��MiddleNameBox��5   -   $
��Left=�6   $��33��6B   $��492,229,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��154��6�   �� 5   
   $
��Left=�6   $��652,115,0,0q�6/   $
��Wrap=�6D   $��Фамилия*��6X   $	��Top=�6h   $��32��6�   $��67��6�   �� 5   
   $
��Left=�6   $��652,168,0,0q�6/   $
��Wrap=�6D   $��Имя*��6X   $	��Top=�6d   $��32��6|   $��67��6�   �� 5   
   $
��Left=�6   $��651,230,-37.6,0q�6/   $
��Wrap=�6H   $��Отчество��6\   $	��Top=�6l   $��32��6�   $	��157��6�   �� 5   
   $
��Left=�6   $��652,293,0,0q�6/   $
��Wrap=�6D   $��Класс*��6X   $	��Top=�6f   $��32��6~   $��67��6�   �� 5   
   -   5        $��
HelpButton��5   8   $��?��6   $
��Left=�6   $��20(�6J   $��
725,10,0,0q�6X   $	��Top=�6l   $��35��6�   $��25��6�   6�   �� 5   
   -   5         ��Name$ IDBox��5   -   $
��Left=�6   $��33��6<   $��
492,65,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��154��6�   �� 5   
   $
��Left=�6   $��
651,65,0,0q�6/   $
��Wrap=�6C   $	��ID*��6W   $	��Top=�6b   $��32��6z   $��67��6�   �� 5   
   -	   5        $��ClassBox��5   .   $
��Left=�6    �� DisplayMemberPath$
 Name��6>   $��526,293,0,0q�6W   $	��Top=�6l   $	��120��6�   �� 5   
   $
��Left=�6   $��10,4,0,0q�6/   $
��Wrap=�6A   $��Ученики��6U   $	��Top=�6d     5   
   -
   5        $��	ClassGrid��5   .   $
��Left=�6   $	��117��6?   $��
10,293,0,0q�6L   $	��Top=�6`   $	��189��6x   �� 5   
   $
��Left=�6   $��
10,277,0,0q�6/   $
��Wrap=�6C   $��Классы��6W   $	��Top=�6e   5      5      