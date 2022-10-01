using AutoMapper;
using Odering.Application.Features.Orders.Commands.CheckOutOrders;
using Odering.Application.Features.Orders.Commands.UpdateOrder;
using Odering.Application.Features.Orders.Queires.GetOrdersList;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odering.Application.Mappings
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}