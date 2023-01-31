using Reveal.Sdk;

namespace RevealWebApi1
{
    public class DashboardProvider : IRVDashboardProvider
    {
        public Task<Dashboard> GetDashboardAsync(IRVUserContext userContext, string dashboardId)
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, $"Dashboards/{dashboardId}.rdash");
            var dashboard = new Dashboard(filePath);
            return Task.FromResult(dashboard);
        }

        public Task SaveDashboardAsync(IRVUserContext userContext, string dashboardId, Dashboard dashboard)
        {
            throw new NotImplementedException();
        }
    }
}
