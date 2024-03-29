﻿using Spotify.Application.Conta.Dto;
using SpotifyLike.Domain.Conta.Agreggates;
using SpotifyLike.Domain.Transacao.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Conta.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>();
            CreateMap<Usuario, UsuarioDto>();

            CreateMap<CartaoDto, Cartao>()
                .ForMember(x => x.Limite.Valor, m => m.MapFrom(f => f.Limite));

            CreateMap<Cartao, CartaoDto>();

        }
    }
}