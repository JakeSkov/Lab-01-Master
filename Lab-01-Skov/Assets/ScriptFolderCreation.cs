using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

/// <summary>
/// @Author Jake Skov
/// @Desc 
/// @Date 8/21/2015
/// </summary>
public class ScriptFolderCreation : MonoBehaviour 
{
    //Create folders in Unity (Matierials, Textures, Prefabs, Scripts, Scenes, Animations)
    //Add a menu item
    //Include text documents that are prepopulated with how the structure of the project is going to be

    [MenuItem("Tool Creation/Create Folder")]

    public static void CreateFolder()
    {
        AssetDatabase.CreateFolder("Assets", "Matierials");
        AssetDatabase.CreateFolder("Assets", "Textures");
        AssetDatabase.CreateFolder("Assets", "Prefabs");
        AssetDatabase.CreateFolder("Assets", "Scripts");
        AssetDatabase.CreateFolder("Assets", "Scenes");
        AssetDatabase.CreateFolder("Assets", "Animations");
        AssetDatabase.CreateFolder("Assets/Animations", "AnimationControllers");

        File.WriteAllText(Application.dataPath + "/Matierials/folderStructure.txt", "This folder is for storing matierials!");
        File.WriteAllText(Application.dataPath + "/Textures/folderStructure.txt", "This folder is for storing textures!");
        File.WriteAllText(Application.dataPath + "/Prefabs/folderStructure.txt", "This folder is for storing prefabs!");
        File.WriteAllText(Application.dataPath + "/Scripts/folderStructure.txt", "This folder is for storing scripts!");
        File.WriteAllText(Application.dataPath + "/Scenes/folderStructure.txt", "This folder is for storing scenes!");
        File.WriteAllText(Application.dataPath + "/Animations/folderStructure.txt", "This folder is for storing animations!");
        File.WriteAllText(Application.dataPath + "/Animations/AnimationControllers/folderStructure.txt",
            "This folder is for storing animation controllers!");
    }
}
