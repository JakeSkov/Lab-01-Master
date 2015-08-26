using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

/// <summary>
/// @Author Jake Skov
/// @Desc ScriptFolderStructure Creates a folderstructure inside Unity
/// @Date 8/24/2015
/// </summary>
public class ScriptFolderStructure : MonoBehaviour 
{
    static bool filesExist = false;

    [MenuItem("Tool Creation/Set Folder %#f")]

    public static void SetFolder()
    {
        if (filesExist == false)
        {
            //Folders and Subfolders for Dynamic Assets
            AssetDatabase.CreateFolder("Assets", "Dynamic Assets");
            AssetDatabase.CreateFolder("Assets/Dynamic Assets", "Resources");                           //This folder is entirely irrelevent
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Animations");                //Animations Superfolder
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Animations", "Sources");            //Source Animations
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Animation Controllers");     //Animation Controllers
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Effects");                   //Effects Folder
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Models");                    //Models Supersolder
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Models", "Character");              //Character Models
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Models", "Environment");            //Envirionment Models
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Prefabs");                   //Prefabricated Game Objects
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Prefabs", "Common");                //Common
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Sounds");                    //Sounds Superfolder
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds", "Music");                  //Music
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds/Music", "Common");               //Common
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds", "SFX");                    //Sound Effects
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds/Music", "Common");               //Common
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Textures");                  //Textures Superfolder
            AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Textures", "Common");               //Common

            //Static Assets Folder and Subfolders
            AssetDatabase.CreateFolder("Assets", "Static Assets");
            AssetDatabase.CreateFolder("Assets/Static Assets", "Animations");                //Animations Superfolder
            AssetDatabase.CreateFolder("Assets/Static Assets/Animations", "Sources");            //Source Animations
            AssetDatabase.CreateFolder("Assets/Static Assets", "Animation Controllers");     //Animation Controllers
            AssetDatabase.CreateFolder("Assets/Static Assets", "Effects");                   //Effects Folder
            AssetDatabase.CreateFolder("Assets/Static Assets", "Models");                    //Models Supersolder
            AssetDatabase.CreateFolder("Assets/Static Assets/Models", "Character");              //Character Models
            AssetDatabase.CreateFolder("Assets/Static Assets/Models", "Environment");            //Envirionment Models
            AssetDatabase.CreateFolder("Assets/Static Assets", "Prefabs");                   //Prefabricated Game Objects
            AssetDatabase.CreateFolder("Assets/Static Assets/Prefabs", "Common");                //Common
            AssetDatabase.CreateFolder("Assets/Static Assets", "Sounds");                    //Sounds Superfolder
            AssetDatabase.CreateFolder("Assets/Static Assets/Sounds", "Music");                  //Music
            AssetDatabase.CreateFolder("Assets/Static Assets/Sounds/Music", "Common");               //Common
            AssetDatabase.CreateFolder("Assets/Static Assets/Sounds", "SFX");                    //Sound Effects
            AssetDatabase.CreateFolder("Assets/Static Assets/Sounds/Music", "Common");               //Common
            AssetDatabase.CreateFolder("Assets/Static Assets", "Textures");                  //Textures Superfolder
            AssetDatabase.CreateFolder("Assets/Static Assets/Textures", "Common");               //Common

            //Shaders Folder
            AssetDatabase.CreateFolder("Assets", "Shaders");

            //Plugins Folder
            AssetDatabase.CreateFolder("Assets", "Plugins");

            //Scripts Folder
            AssetDatabase.CreateFolder("Assets", "Scripts");
            AssetDatabase.CreateFolder("Assets/Scripts", "Common");

            //Gizmos Folder
            AssetDatabase.CreateFolder("Assets", "Gizmos");

            //Extensions Folder
            AssetDatabase.CreateFolder("Assets", "Extensions");

            //Testing Folder
            AssetDatabase.CreateFolder("Assets", "Testing");

            //Editor Folder
            AssetDatabase.CreateFolder("Assets", "Editor");

            //Places the FolderStructure.txt
            File.WriteAllText(Application.dataPath + "/Editor/folderStructure.txt", "Contains files that effect the Editor");
            File.WriteAllText(Application.dataPath + "/Shaders/folderStructure.txt", "Contains Shaders");
            File.WriteAllText(Application.dataPath + "/Gizmos/folderStructure.txt", "Contains Gizmos");
            File.WriteAllText(Application.dataPath + "/Plugins/folderStructure.txt", "Contains Plugins");
            File.WriteAllText(Application.dataPath + "/Extensions/folderStructure.txt", "Contains Extensions");
            File.WriteAllText(Application.dataPath + "/Scripts/folderStructure.txt", "Contains Scripts");
            File.WriteAllText(Application.dataPath + "/Static Assets/folderStructure.txt", "Contains Static Assets");
            File.WriteAllText(Application.dataPath + "/Dynamic Assets/folderStructure.txt", "Contains Dynamic Assets");
            File.WriteAllText(Application.dataPath + "/Testing/folderStructure.txt", "Contains Test Objects");
            File.WriteAllText(Application.dataPath + "/folderStructure.txt", "All the folder names are easy to understand "
            + "just read them and you'll be able to use this structure with ease");

            filesExist = true;
        }
    }
}
