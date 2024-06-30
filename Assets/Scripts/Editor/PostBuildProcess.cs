using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.IO;

public class MyBuildPostprocessor
{
    [PostProcessBuildAttribute(1)]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
    {
        string projectLuaPath = "/../Lua/";
        string luaPath = $"{Application.dataPath}/{projectLuaPath}";
        // string luaPath = Path.Combine(Application.dataPath, projectLuaPath);

        string dirName = Path.Combine(Path.GetDirectoryName(pathToBuiltProject), "Lua");

        Debug.Log($"Finishing build and copying lua files from '{luaPath}' to '{dirName}'");

        try
        {
            FileUtil.CopyFileOrDirectory(luaPath, dirName);

            Debug.Log($"Build and copying lua files is complete.");
        }
        catch 
        {
            Debug.LogError($"Faild to copy lua files from '{luaPath}' to '{dirName}'");
        }


    }
}
