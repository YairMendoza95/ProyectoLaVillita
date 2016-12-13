using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
	public interface IDetalleRentaManager
	{
		IQueryable<DetalleRentaDTO> DetallesRentas { get; }
		bool InsertarDetalleRenta(DetalleRentaDTO detalle);
	}
}
