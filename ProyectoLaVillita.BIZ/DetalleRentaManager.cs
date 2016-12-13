using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.DAL;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;

namespace ProyectoLaVillita.BIZ
{
	public class DetalleRentaManager : IDetalleRentaManager
	{
		DetalleRentaRepository drRepository;
		public DetalleRentaManager()
		{
			drRepository = new DetalleRentaRepository();
		}
		public IQueryable<DetalleRentaDTO> DetallesRentas
		{
			get
			{
				return drRepository.Elementos;
			}
		}

		public bool InsertarDetalleRenta(DetalleRentaDTO detalle)
		{
			return drRepository.Insertar(detalle);
		}
	}
}
