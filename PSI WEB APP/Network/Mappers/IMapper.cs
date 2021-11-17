﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSI_WEB_APP.Network.Mappers
{
    public interface IMapper<in TInput,out TOutput> 
    {
        TOutput Map(TInput input);
    }
    public interface IMap<Dto, DomainModel>
    {
        Dto MapToDto(DomainModel m);
        DomainModel MapToDomain(Dto t);
    }
}
