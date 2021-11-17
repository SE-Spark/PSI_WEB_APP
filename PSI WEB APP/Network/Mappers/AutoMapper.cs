using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSI_WEB_APP.Network.Mappers
{
    public static class AutoMapper
    {
        public static IEnumerable<TOutput> MapAll<TInput, TOutput>(this IMapper<TInput, TOutput> mapper, IEnumerable<TInput> input)
        {
            return input.Select(x => mapper.Map(x));
        }
    }
}
