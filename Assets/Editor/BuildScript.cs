using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public void BuildWebGL()
    {
        string buildPath = "Builds/WebGL";
        BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, buildPath, BuildTarget.WebGL, BuildOptions.None);
        Debug.Log("WebGL Build Complete");
    }
}
