using System;
using UnityEditor;
using UnityEngine;

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

        string buildPath = string.Empty;
        var args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].Equals("-buildPath"))
            {
                buildPath = args[i + 1];
                break;
            }
        }

        string name = Application.productName;
        string version = Application.version;
        string datetime = DateTime.Now.ToString("ddMM.HHmm");
        string extension = ".apk";

        buildPath += $"{name}_{version}_{datetime}{extension}";

        BuildPipeline.BuildPlayer(
            scenes,
            buildPath,
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