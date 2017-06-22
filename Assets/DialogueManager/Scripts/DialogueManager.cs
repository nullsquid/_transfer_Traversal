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
    

	void GetRootStory(string rootStoryName){

	}

	void GetNextStory(string nextStoryName){

	}

	void GetRootNode(){

	}

	void GetNextNode(string nextNodeName){

	}

	void ParseNode(){
		StartCoroutine (ProcessNodeTags ());
	}

	IEnumerator ProcessNodeTags(){
		yield return null;
	}

	static string GetNodePassage(){
		return null;
	}


}
