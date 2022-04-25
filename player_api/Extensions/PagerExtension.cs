using Microsoft.EntityFrameworkCore;
using player_api.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.Extensions
{
    public static class PagerExtension
    {
        /// <summary>
        /// The code is where the actual pagination and calculation is happening.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// 

        public static async Task<PagedResponse<T>> PaginateAsync<T>(this IQueryable<T> query, int pageNumber, int pageSize)
            where T : class
        {
            var paged = new PagedResponse<T>();
            pageNumber = (pageNumber < 0) ? 1 : pageNumber;
            paged.CurrentPageNumber = pageNumber;
            paged.PageSize = pageSize;
            paged.TotalRecordCount = await query.CountAsync();

            var pageCount = (double)paged.TotalRecordCount / pageSize;
            paged.PageCount = (int)Math.Ceiling(pageCount);
            var startRow = (pageNumber - 1) * pageSize;
            paged.Result = await query.Skip(startRow).
            Take(pageSize).ToListAsync();
            return paged;



        }
    }
}
