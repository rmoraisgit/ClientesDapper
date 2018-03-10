using System.Web;
using System.Web.Mvc;

namespace RFL.CadastroClientes.UI.MVc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
