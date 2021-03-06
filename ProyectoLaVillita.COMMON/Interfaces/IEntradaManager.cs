﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IEntradaManager
    {
        IQueryable<EntradaDTO> Entradas { get; }
        EntradaDTO BuscarEntradaPorId(int idEntrada);
        bool InsertarEntrada(EntradaDTO entrada);
        bool ModificarEntrada(EntradaDTO entrada);
        IQueryable<EntradaDTO> EntradasPorProducto(int idProducto);
    }
}
