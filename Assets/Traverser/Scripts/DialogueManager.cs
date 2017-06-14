using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {
    #region Singleton
    private static DialogueManager _instance;
    public static DialogueManager Instance
    {
        get
        {
            if (_instance == null) {
                GameObject dm = new GameObject("DialogueManager");
                dm.AddComponent<DialogueManager>();

            }
            return _instance;
        }

    }
    void Awake() {
        _instance = this;

    }
    #endregion
    
}
