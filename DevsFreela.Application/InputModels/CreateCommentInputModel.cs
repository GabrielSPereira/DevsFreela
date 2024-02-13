namespace DevsFreela.Application.InputModels
{
    public class CreateCommentInputModel
    {
        public required string Content { get; set; }

        public int IdProject { get; set; }

        public int IdUser { get; set; }
    }
}
