using MediatR;


namespace PostLand.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQuery : IRequest<List<GetPostDetailViewModel>>
    {
        public Guid PostId { get; set; }
    }
}
