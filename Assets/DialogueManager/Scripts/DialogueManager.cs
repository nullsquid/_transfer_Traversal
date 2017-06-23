using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Silk;
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
	////////////////////////////////////////////
	////////////////////////////////////////////
	////////////////////////////////////////////
    //REQUIRES SILK 0.4.1 OR LATER TO FUNCTION//
	////////////////////////////////////////////
	////////////////////////////////////////////
	////////////////////////////////////////////
	/// 
	/// 
	SilkStory rootStory;
	SilkStory curStory;
	SilkNode rootNode;
	SilkNode curNode;


	#region Accessor Methods
	void GetRootStory(string rootStoryName){
		rootStory = Silky.Instance.mother.GetStoryByName (rootStoryName);
		curStory = rootStory;
	}

	void GetNextStory(string nextStoryName){

	}

	void GetRootNode(){
		rootNode = curStory.GetNodeByName ("Start");
		curNode = rootNode;
	}

	void GetNextNode(string nextNodeName){
		curNode = curStory.GetNodeByName (nextNodeName);
	}
		

	static string GetNodePassage(){
		return null;
	}
	#endregion

	void ParseNode(){
		StartCoroutine (ProcessNodeTags ());
	}

	IEnumerator ProcessNodeTags(){
		yield return null;
	}
}
