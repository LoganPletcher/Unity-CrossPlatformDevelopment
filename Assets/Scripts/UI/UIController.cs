﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// Controller class for UI
/// Interacts with the UIView and Rest of Game
/// </summary>
public class UIController : MonoBehaviour
{
    [System.Serializable]
    public class OnCancel : UnityEvent { }
    [System.Serializable]
    public class OnSubmit : UnityEvent { }
    [System.Serializable]
    public class OnStart : UnityEvent { }

    public ScriptableAssets.Unit Unit;
    public OnSubmit onSubmit;
    public OnCancel onCancel;
    public UIView view;
    
    private void Create()
    {        
        foreach(var item in backPack.Items)
        {
            var go = new GameObject(item.Name, typeof(Button), typeof(Image));
            var button = go.GetComponent<Button>();
            var image = go.GetComponent<Image>();
            image.sprite = item.sprite;
            go.transform.SetParent(view.InventoryGrid.transform);            
            go.transform.ResetTransformation();
        }
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        if(GetCancel()) onCancel.Invoke();
        if(GetSubmit()) onSubmit.Invoke();
    }
    public static bool GetCancel()
    {
        return Input.GetButtonDown("Cancel");
    }

    public static bool GetSubmit()
    {
        return Input.GetButtonDown("Submit");
    }

    public BackPack backPack;
}
