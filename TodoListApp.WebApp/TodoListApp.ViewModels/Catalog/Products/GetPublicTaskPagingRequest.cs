using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.ViewModels.Comon;

namespace TodoListApp.ViewModels.Catalog.Products
{
    public class GetPublicTaskPagingRequest : PagingRequestBase
    {
        public int TaskID { get; set; }
    }
}
