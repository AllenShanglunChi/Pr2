// MainPageViewModel.cs
using Pr2;
using System.Collections.ObjectModel;

public class MainPageViewModel
{
    public ObservableCollection<Staff> StaffList { get; set; } = new ObservableCollection<Staff>();
    public ObservableCollection<Department> Departments { get; set; } = new ObservableCollection<Department>();

    public MainPageViewModel()
    {
        // Populate Departments
        Departments.Add(new Department { Id = 1, Name = "General" });
        Departments.Add(new Department { Id = 2, Name = "Information Communications Technology" });
        Departments.Add(new Department { Id = 3, Name = "Finance" });
        Departments.Add(new Department { Id = 4, Name = "Marketing" });
        Departments.Add(new Department { Id = 5, Name = "Human Resources" });

        // Populate StaffList
        StaffList.Add(new Staff { Id = 1, Name = "John Smith", Phone = "02 9988 2211", DepartmentId = 1, Address = "1 Code Lane, Javaville, NSW 0100, Australia" });
        StaffList.Add(new Staff { Id = 2, Name = "Sue White", Phone = "03 8899 2255", DepartmentId = 2, Address = "16 Bit Way, Byte Cove, QLD 1101, Australia" });
        StaffList.Add(new Staff { Id = 3, Name = "Bob O’Bits", Phone = "05 7788 2255", DepartmentId = 3, Address = "8 Silicon Road, Cloud Hills, VIC 1001, Australia" });
        StaffList.Add(new Staff { Id = 4, Name = "Mary Blue", Phone = "06 4455 9988", DepartmentId = 2, Address = "4 Processor Boulevard, Appletson, NT 1010, Australia" });
        StaffList.Add(new Staff { Id = 5, Name = "Mick Green", Phone = "02 9988 1122", DepartmentId = 3, Address = "700 Bandwidth Street, Bufferland, NSW 0110, Australia" });
    }
}
