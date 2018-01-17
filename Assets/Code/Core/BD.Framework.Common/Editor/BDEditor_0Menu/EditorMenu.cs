﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class BDEditorMenu
{

    [MenuItem("BDFrameWork工具箱/资源打包/DLL打包")]
    public static void ExecuteBuildDLL()
    {
        var window = (ScriptBuildDll_Windows)EditorWindow.GetWindow(typeof(ScriptBuildDll_Windows), false, "DLL打包工具");
        window.Show();
    }

    [MenuItem("BDFrameWork工具箱/资源打包/AssetBundle打包")]
    public static void ExecuteAssetBundle()
    {
        var window = (AssetBundleCtrl_Windows)EditorWindow.GetWindow(typeof(AssetBundleCtrl_Windows),false,"AB打包工具");
        window.Show();
    }

    [MenuItem("BDFrameWork工具箱/资源打包/表格打包")]
    public static void ExecuteGenTable()
    {
        Editor_VersionCtrl.GenTableCofig();
    }
}
