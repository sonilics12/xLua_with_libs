using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace XLuaTest
{
    public class RapidJson : MonoBehaviour
    {
        public TextAsset luaScript;

        // Start is called before the first frame update
        void Start()
        {
            LuaEnv luaEnv = new LuaEnv();
            luaEnv.AddBuildin("rapidjson", XLua.LuaDLL.Lua.LoadRapidJson);
            luaEnv.DoString("CS.UnityEngine.Debug.Log('hello world')");
            luaEnv.DoString(luaScript.text);
            luaEnv.Dispose();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}