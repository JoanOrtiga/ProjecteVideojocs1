using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(EnemyModel), true)]
public class EnemyModelGUI : Editor
{ 

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EnemyModel enemyModel = (EnemyModel)target;

        if (enemyModel.drops.Count != enemyModel.randomDropPercentatges.Count)
        {
            EditorGUILayout.HelpBox("Los drops y Random Percentatges deben tener el mismo numero de elementos.", MessageType.Error, true);
        }
        EditorUtility.SetDirty(enemyModel);
        
        foreach (GameObject item in enemyModel.drops)
        {
            if(item == null)
            {
                EditorGUILayout.HelpBox("No puedes tener objetos vacios", MessageType.Error, true);
            }
        }

        foreach (int item in enemyModel.randomDropPercentatges)
        {
            if (item <= 0 || item > 100 )
            {
                EditorGUILayout.HelpBox("No puedes tener numeros por debajo de 0 o más grandes de 100", MessageType.Error, true);
            }
        }
    }
}