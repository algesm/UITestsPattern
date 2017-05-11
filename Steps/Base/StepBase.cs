using Tests.IDSRO.Core.Context;

namespace Tests.IDSRO.Core.Base
{
    public abstract class StepBase<T> where T: PageBase
    {
        protected StepBase(IPageFactory factory)
        {
            Page = factory.GetInstance<T>();
        }

        protected T Page { get; }
    }
}