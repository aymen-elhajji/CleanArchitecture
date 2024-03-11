using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLandDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
    {
        private readonly IAsyncRepository<Post> _asyncRepository;
        private readonly IMapper _mapper;

        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            Post post = _mapper.Map<Post>(request);

            await _asyncRepository.UpdateAsync(post);

            return Unit.Value;
        }
    }
}
