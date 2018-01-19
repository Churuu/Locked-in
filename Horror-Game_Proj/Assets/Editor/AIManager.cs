﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AIManager : EditorWindow {

    public GameObject room;
    public GameObject KeyRoom;
    public GameObject Floor;

    [MenuItem("AI/AI Manager")]


    public static void ShowWindow()
    {
        GetWindow(typeof(AIManager));
    }


    void OnGUI()
    {
        if (GUILayout.Button("Add Room"))
        {
            
            GameObject parent = GameObject.Find("Rooms");

            if (parent == null)
            {
                parent = new GameObject("Rooms");
            }
            Instantiate(room, parent.transform);
        }

        if (GUILayout.Button("Add Key Room"))
        {
            GameObject parent = GameObject.Find("Rooms");
            if (parent == null)
            {
                parent = new GameObject("Rooms");
            }
            Instantiate(KeyRoom, parent.transform);
        }

        if (GUILayout.Button("Add Floor"))
        {
            GameObject parent = GameObject.Find("Floors");
            if (parent == null)
            {
                parent = new GameObject("Floors");
            }
            Instantiate(Floor, parent.transform);
        }
    }
}
