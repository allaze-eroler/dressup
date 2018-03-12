using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateCharacterWizard : ScriptableWizard
{

    public Texture2D Character;
    public Color color = Color.white;


    [MenuItem("Dress Up Game/Create Character Wizard...")]
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard<CreateCharacterWizard>("Create Character", "Create new", "Update selected");
    }



}
