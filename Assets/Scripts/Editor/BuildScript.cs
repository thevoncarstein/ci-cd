using UnityEditor;

public class BuildScript
{
    [MenuItem("Build/Windows")]
    public static void BuildWindows()
    {
        var scenes = EditorBuildSettings.scenes;
        BuildPipeline.BuildPlayer(
            scenes,
            "C:\\Users\\Admin\\Downloads\\Builds\\CMDBuilds\\Windows\\Build.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None
            );
    }

    [MenuItem("Build/Android")]
    public static void BuildAndroid()
    {
        var scenes = EditorBuildSettings.scenes;
        BuildPipeline.BuildPlayer(
            scenes,
            "C:\\Users\\Admin\\Downloads\\Builds\\CMDBuilds\\Android\\Build.apk",
            BuildTarget.Android,
            BuildOptions.None
            );
    }

    [MenuItem("Build/iOS")]
    public static void BuildiOS()
    {
        var scenes = EditorBuildSettings.scenes;
        BuildPipeline.BuildPlayer(
            scenes,
            "C:\\Users\\Admin\\Downloads\\Builds\\CMDBuilds\\iOS\\Build",
            BuildTarget.iOS,
            BuildOptions.None
            );
    }
}