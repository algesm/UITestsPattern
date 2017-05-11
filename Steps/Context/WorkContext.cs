using OpenQA.Selenium;

namespace Tests.IDSRO.Core.Context
{
    /// <summary>
    /// �������� ������� �������� � ����������� ��� ������
    /// </summary>
    public class WorkContext : IWorkContext
    {
        public WorkContext(IWebDriver browser)
        {
            Browser = browser;
            ContextParemeter  = new ContextParameter();
        }

        public ContextParameter ContextParemeter { get; }

        public IWebDriver Browser { get; }

    }
}