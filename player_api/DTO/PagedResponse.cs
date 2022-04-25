﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.DTO
{
    public class PagedResponse<T>
    {

        const int _maxPageSize = 100;

        public int CurrentPageNumber { get; set; }

        public int PageCount { get; set; }

        public int PageSize
        {
            get => 20;
            set => _ = (value > _maxPageSize) ? _maxPageSize :
            value;
        }
        public int TotalRecordCount { get; set; }

        public IList<T> Result { get; set; }

        public PagedResponse()
        {
            Result = new List<T>();
        }
    }
}
