using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EnemyModel))]
public class EnemyModelGUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EnemyModel enemyModel = (EnemyModel)target;

        if (enemyModel.drops.Count != enemyModel.randomPercentatges.Count)
        {
            EditorGUILayout.HelpBox("Los drops y Random Percentatges deben tener el mismo numero de elementos.", MessageType.Error, true);
        }
        /*
        foreach (GameObject item in enemyModel.drops)
        {
            if(item == null)
            {
                EditorGUILayout.HelpBox("No puedes tener objetos vacios", MessageType.Error, true);
            }
        }

        foreach (int item in enemyModel.randomPercentatges)
        {
            if (item <= 0 || item > 100 )
            {
                EditorGUILayout.HelpBox("No puedes tener numeros por debajo de 0 o más grandes de 100", MessageType.Error, true);
            }
        }*/
    }
}

/*
[CustomEditor(typeof(CameraZoomInOut))]
public class CameraZoomInOutCustomGUI : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CameraZoomInOut myCameraZoomInOut = (CameraZoomInOut)target;

        if (myCameraZoomInOut.zoomX == true && myCameraZoomInOut.zoomY == true)
        {
            EditorGUILayout.HelpBox("No puedes seleccionar zoomX y zoomY a la vez", MessageType.Error, true);
        }
    }

}*/

