﻿using MediatR;
using NovyGorod.Domain.Models;
using NovyGorod.Domain.Models.Common;

namespace NovyGorod.Application.Contracts.Media.Requests;

public record CreateLocalMediaDataRequest : IRequest<BaseEntityDto>
{
    public Stream Stream { get; init; }

    public string FileExtension { get; init; }

    public MediaDataType Type { get; init; }
}