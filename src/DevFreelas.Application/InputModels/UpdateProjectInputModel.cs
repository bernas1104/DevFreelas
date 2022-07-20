namespace DevFreelas.Application.InputModels
{
    public class UpdateProjectInputModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; set; }
    }
}
