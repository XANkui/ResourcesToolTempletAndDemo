﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton_XAN;

/// <summary>
/// 继承泛型 new 单例模版
/// </summary>
public class ResourcesTool : SingletonNewBase<ResourcesTool> {

    /// <summary>
    /// 一个泛型的资源加载函数
    /// </summary>
    /// <typeparam name="T">泛型的资源</typeparam>
    /// <param name="objectType">object 可接受几乎任何类型的输入参数</param>
    /// <returns>返回泛型的资源</returns>
    public T ResourcesLoad<T>(object objectType) where T : Object {

        // 获取加载资源的枚举类型
        // 设置资源文件夹在路径，初始化为空
        string objectTypeEnumName = objectType.GetType().Name;
        string objectFilePath = string.Empty;

        // 根据资源的枚举类型，设置资源加载目标文件夹
        switch (objectTypeEnumName) {

            case "Prefabs_Cube":
                objectFilePath = "Cubes/";
                break;

            case "Prefabs_Sphere":
                objectFilePath = "Spheres/";
                break;

            default:
                break;
        }

        // 目标文件夹 + 资源名称 组合成实际加载路径
        objectFilePath += objectType.ToString();

        // 使用 Unity 原生接口加载资源
        T tmp = Resources.Load<T>(objectFilePath);

        // 返回加载结果
        return tmp;
    }
}
