namespace FansVoice.Shared.Constants;

public static class ApiRoutes
{
    private const string Root = "api";
    private const string Version = "v1";
    private const string Base = Root + "/" + Version;

    public static class Auth
    {
        public const string Login = Base + "/auth/login";
        public const string Register = Base + "/auth/register";
        public const string RefreshToken = Base + "/auth/refresh-token";
        public const string RevokeToken = Base + "/auth/revoke-token";
    }

    public static class Users
    {
        public const string GetAll = Base + "/users";
        public const string Get = Base + "/users/{id}";
        public const string Create = Base + "/users";
        public const string Update = Base + "/users/{id}";
        public const string Delete = Base + "/users/{id}";
        public const string UpdateProfile = Base + "/users/profile";
    }

    public static class Events
    {
        public const string GetAll = Base + "/events";
        public const string Get = Base + "/events/{id}";
        public const string Create = Base + "/events";
        public const string Update = Base + "/events/{id}";
        public const string Delete = Base + "/events/{id}";
        public const string Join = Base + "/events/{id}/join";
        public const string Leave = Base + "/events/{id}/leave";
    }

    public static class Media
    {
        public const string Upload = Base + "/media/upload";
        public const string Get = Base + "/media/{id}";
        public const string Delete = Base + "/media/{id}";
        public const string Like = Base + "/media/{id}/like";
        public const string Unlike = Base + "/media/{id}/unlike";
        public const string Comment = Base + "/media/{id}/comment";
    }

    public static class Leaderboard
    {
        public const string GetGlobal = Base + "/leaderboard/global";
        public const string GetByTeam = Base + "/leaderboard/team/{teamId}";
        public const string GetUserRank = Base + "/leaderboard/user/{userId}";
    }

    public static class Analytics
    {
        public const string GetUserStats = Base + "/analytics/user/{userId}";
        public const string GetEventStats = Base + "/analytics/event/{eventId}";
        public const string GetTeamStats = Base + "/analytics/team/{teamId}";
    }
}