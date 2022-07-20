namespace DevFreelas.Application.InputModels
{
    public class CreateCommentInputModel
    {
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
