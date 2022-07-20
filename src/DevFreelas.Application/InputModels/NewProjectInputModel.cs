namespace DevFreelas.Application.InputModels
{
    public class NewProjectInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid ClientId { get; set; }
        public Guid FreelancerId { get; set; }
        public decimal TotalCost { get; set; }
    }
}
