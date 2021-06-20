using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.ViewModels.Comon;

namespace TodoListApp.ViewModels.Catalog.Products
{
    public class GetManageTaskPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> TaskIDs { get; set; }
    }
}
