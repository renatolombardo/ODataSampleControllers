namespace ODataSampleControllers.Commands
{
    public class EmployeeCommandResponse
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Salary { get; set; }
        public string? JobRole { get; set; }

        public List<EmployeeAddressCommandResponse>? EmployeeAddresses { get; set; }

    }
}
