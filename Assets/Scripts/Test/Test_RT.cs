using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 测试 ResourcesTool 资源加载
/// </summary>
public class Test_RT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // 使用 ResourcesTool 分别加载 Cube 与 Sphere 预制体

        if (Input.GetKeyDown(KeyCode.C)) {
            GameObject go = ResourcesTool.Instance.ResourcesLoad<GameObject>(EnumResourcesPath.Prefabs_Cube.Cube);

            Instantiate(go);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject go = ResourcesTool.Instance.ResourcesLoad<GameObject>(EnumResourcesPath.Prefabs_Sphere.Sphere);

            Instantiate(go);
        }


    }
}
