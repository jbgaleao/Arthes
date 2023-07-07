using System;
using System.Collections.Generic;

using Arthes.Domain.DTO;
using Arthes.Domain.Entities;

namespace Arthes.Domain.Mappers
{
    public static class RevistaMapper
    {
        public static List<RevistaDTO> EntidadeParaDTO(List<Revista> ListaRev)
        {
            List<RevistaDTO> ListaDTO = new List<RevistaDTO>();
            foreach (Revista r in ListaRev)
            {
                RevistaDTO revDTO = new RevistaDTO
                {
                    Id = r.Id,
                    Tema = r.Tema,
                    NumEdicao = r.NumEdicao,
                    MesEdicao = r.MesEdicao,
                    AnoEdicao = r.AnoEdicao,
                    DataCadastro = DateTime.Now
                };
                ListaDTO.Add(revDTO);
            }
            return ListaDTO;
        }

        public static List<Revista> DTOParaEntidade(List<RevistaDTO> ListaRevDTO)
        {
            List<Revista> ListaRev = new List<Revista>();
            foreach (RevistaDTO rDTO in ListaRevDTO)
            {
                Revista rev = new Revista
                {
                    Id = rDTO.Id,
                    Tema = rDTO.Tema,
                    NumEdicao = rDTO.NumEdicao,
                    MesEdicao = rDTO.MesEdicao,
                    AnoEdicao = rDTO.AnoEdicao,
                    DataCadastro = DateTime.Now
                };
                ListaRev.Add(rev);
            }
            return ListaRev;
        }


        public static RevistaDTO UmaEntidadeParaUmDTO(Revista Rev)
        {
            RevistaDTO revDTO = new RevistaDTO
            {
                Id = Rev.Id,
                Tema = Rev.Tema,
                NumEdicao = Rev.NumEdicao,
                MesEdicao = Rev.MesEdicao,
                AnoEdicao = Rev.AnoEdicao,
                DataCadastro = DateTime.Now
            };

            return revDTO;
        }

        public static Revista UmDTOParaUmaEntidade(RevistaDTO RevDTO)
        {
            Revista rev = new Revista
            {
                Id = RevDTO.Id,
                Tema = RevDTO.Tema,
                NumEdicao = RevDTO.NumEdicao,
                MesEdicao = RevDTO.MesEdicao,
                AnoEdicao = RevDTO.AnoEdicao,
                DataCadastro = DateTime.Now
            };
            return rev;
        }

    }
}
