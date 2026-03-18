namespace SboxMcpServer;

/// <summary>
/// Aggregates all MCP tool schema definitions returned by tools/list.
/// Schemas are defined in SceneToolDefinitions and ConsoleToolDefinitions.
/// To add a new tool: add its schema to the appropriate definitions file,
/// implement its handler in the appropriate handler file, and add a case
/// to the switch in RpcDispatcher.
/// </summary>
internal static class ToolDefinitions
{
	internal static object[] All => new object[]
	{
		SceneToolDefinitions.GetSceneSummary,
		SceneToolDefinitions.GetSceneHierarchy,
		SceneToolDefinitions.FindGameObjects,
		SceneToolDefinitions.FindGameObjectsInRadius,
		SceneToolDefinitions.GetGameObjectDetails,
		SceneToolDefinitions.GetComponentProperties,
		SceneToolDefinitions.GetPrefabInstances,
		ConsoleToolDefinitions.ListConsoleCommands,
		ConsoleToolDefinitions.RunConsoleCommand
	};
}
