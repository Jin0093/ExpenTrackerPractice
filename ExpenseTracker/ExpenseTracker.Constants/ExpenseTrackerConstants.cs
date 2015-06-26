namespace ExpenseTracker.Constants
{
    public class ExpenseTrackerConstants
    {
        public const string ExpenseTrackerAPI = "http://localhost:679/";
        public const string ExpenseTrackerClient = "https://web.client:681/";
        public const string ExpenseTrackerMobile = "ms-app://s-1-15-2-467734538-4209884262-1311024127-1211083007-3894294004-443087774-3929518054/";

        public const string IdSrvIssueUri = "https://expensetrackeridsrv3/embedded";

        public const string IdSrv = "https://idsrv.local:444/identity";
        public const string IdSrvToken = IdSrv + "/connect/token";
        public const string IdSrvAuthorize = IdSrv + "/connect/authorize";
        public const string IdSrvUserInfo = IdSrv + "/connect/userinfo";

        public const string IdSrvWp = "https://localhost:44305/identity";
        public const string IdSrvTokenWp = IdSrvWp + "/connect/token";
        public const string IdSrvAuthorizeWp = IdSrvWp + "/connect/authorize";
        public const string IdSrvUserInfoWp = IdSrvWp + "/connect/userinfo";
    }
}