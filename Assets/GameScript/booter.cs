using UnityEngine;
using System.Collections;

public class booter : MonoBehaviour {

	SLua.LuaSvr lua = null;
	// Use this for initialization
	void Start () {
		SLua.LuaState.loaderDelegate = Loader;
		lua = new SLua.LuaSvr();
		lua.init(tick,complete,false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void tick(int p)
	{
	}

	void complete()
	{

	}

	byte[] Loader(string fn)
	{
		string filepath = "Assets/LuaScript/"+fn+".lua";
		using(System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.Open))
		{
			using(System.IO.BinaryReader br = new System.IO.BinaryReader(fs))
			{
				return br.ReadBytes((int)fs.Length);
			}
		}
	}

	void OnGUI()
	{
		GUILayout.BeginVertical();
		if(GUILayout.Button("Load baselua",GUILayout.Height(30)))
		{
			lua.luaState.doFile("baselua");
		}
		else if(GUILayout.Button("Load updatelua", GUILayout.Height(30)))
		{
			lua.luaState.doFile("updatelua");
		}
		else if(GUILayout.Button("Show Result", GUILayout.Height(100)))
		{
			lua.luaState.getFunction("TestResult").call();
		}
		GUILayout.EndVertical();
	}
}
