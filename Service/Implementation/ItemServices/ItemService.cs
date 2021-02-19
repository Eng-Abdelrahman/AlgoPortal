using AutoMapper;
using Repo.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementation.ItemServices
{
    public class ItemService : IItemService
    {
        private readonly IMapper _Mapper;
        private readonly IItemRepo _itemRepo;
        public ItemService(IMapper mapper, IItemRepo itemRepo)
        {
            _Mapper = mapper;
            _itemRepo = itemRepo;
        }



    }
}
