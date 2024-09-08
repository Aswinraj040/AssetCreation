using UnityEngine; 
using UnityEditor;

public class Assetbundlecreator {
    // Creates a new menu (Build AssetBundles) in the Editor 
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAB()
    {
        // Build for Android
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles/Android", BuildAssetBundleOptions.None, BuildTarget.None);
        
        // Build for iOS
    } 
}
