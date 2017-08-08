namespace Common.Settings
{
    public class AppSetting
    {
        public static string ConnectionString { get; set; }
        public static string SecretKey { get; set; } = "TinTanSoft_Warehouse_Web_App_Secret_Key";
        public static string TokenAuthenticationPath { get; set; } = "/api/token";
        public static string Audience = "TinTanSoft_Warehouse_Web_App";
        public static string Issuer = "TinTanSoft";
        public static string AuthenticationScheme = "Cookie";
        public static string CookieName = "access_token";
    }
}