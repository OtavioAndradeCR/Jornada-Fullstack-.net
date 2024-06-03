using System;

namespace Fina.Api;

public static class ApiConfiguration
{
	public const string UserId = "otavio@jornada.io";
	public static string ConnectionString { get; set; } = string.Empty;
    public static string CorsPolicyName = "wasm";
}
