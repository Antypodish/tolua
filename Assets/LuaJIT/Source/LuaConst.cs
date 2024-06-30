using UnityEngine;

public static class LuaConst
{

    public static string assetsToLuaDir = Application.dataPath + "/../Lua";        //tolua

#if UNITY_EDITOR
    public static string luaDir = Application.dataPath + "/../Lua";                //lua
#else
    public static string luaDir = Application.dataPath + "/Lua";                //lua
#endif

#if UNITY_STANDALONE
    public static string osDir = "Win";
#elif UNITY_ANDROID
    public static string osDir = "Android";            
#elif UNITY_IPHONE
    public static string osDir = "iOS";        
#else
    public static string osDir = "";        
#endif

    public static string luaResDir = string.Format("{0}/{1}/Lua", Application.persistentDataPath, osDir); 

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN    
    public static string zbsDir = "D:/ZeroBraneStudio/lualibs/mobdebug";        //ZeroBraneStudio     
#elif UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
	public static string zbsDir = "/Applications/ZeroBraneStudio.app/Contents/ZeroBraneStudio/lualibs/mobdebug";
#else
    public static string zbsDir = luaResDir + "/mobdebug/";
#endif    

    public static bool openLuaSocket = true;            // Lua Socket
    public static bool openLuaDebugger = false;         // Lua debugger
}