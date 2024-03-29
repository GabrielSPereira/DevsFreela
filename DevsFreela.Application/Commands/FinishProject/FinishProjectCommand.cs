﻿using MediatR;
namespace DevsFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommand : IRequest<Unit>
    {
        public FinishProjectCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
