   M S B A M L   `   `   `  ����J  FKR2_Galautdinov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KR2_Galautdinov.PagesKR2_Galautdinov.Pages  5      '    !KR2_Galautdinov.Pages.EmpListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:KR2_Galautdinov.Pages     5        N� Title$  EmpListPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   
���   �.+�5      �� -   5         ��Name$ ExitB��5   6   $��0 0 10 0q�6   $
��Exit��6'   6E   �� 5      -   5        $ AddEmployeeB��5   ,   $��Add Employee��6   6B   5      �� 5   
   $��1��6   .+�5      �� $��filtres��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ EmployeesDG��5   %      
IsReadOnly . $��2��6:      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ FullName��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *
FullName+  5      $ Birthday��6%   	 67   �� *
Birthday+  5      $ PhoneNumber��6%   	 6:   �� *PhoneNumber+  5      $ Salary��6%   	 65   �� *Salary+  5      $ Departament��6%   	 6:   �� *Departament.Title+  5      $ Passport��6%   	 67   �� *
Passport+  5       $ Platform��6%   	 67   �� *Platform.Title+  5!      $
 Role��6%   	 63   �� *
Role.Title+5#      5$      5%      