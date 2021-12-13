﻿using StockManagement.Core.DTOs.Vendas;
using StockManagement.Core.Entities.Vendas;
using StockManagement.Core.Interfaces.Persistence.Repositories.Generico;
using StockManagement.Shared.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Core.Interfaces.Persistence.Repositories.Vendas
{
    public interface IVendaRepository : IRepository<Venda>
    {
        Task<VendaDto> ObterVendaPorId(Guid id);
        Task<PagedList<VendaDto>> ObterVendas(PaginationParams paginationParams);
        Task<PagedList<VendaDto>> ObterVendasDeHoje(PaginationParams paginationParams);
        Task<PagedList<VendaDto>> ObterVendasPorMes(string mes, PaginationParams paginationParams);
    }
}
