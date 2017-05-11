using Tests.IDSRO.Core.Base;

namespace Tests.IDSRO.Core.Context
{
    public interface IPageFactory
    {
        T GetInstance<T>() where T : PageBase;
    }
}