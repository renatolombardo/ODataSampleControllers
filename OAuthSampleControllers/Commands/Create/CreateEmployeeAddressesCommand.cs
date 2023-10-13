namespace ODataSampleControllers.Commands.Create
{
    public class CreateEmployeeAddressesCommand
    {
        public string? HouseNumber { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int EmployeeId { get; set; }
    }
}
