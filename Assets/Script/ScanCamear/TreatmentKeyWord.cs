﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TreatmentKeyWord : MonoBehaviour
{

    public GameObject KeyWordPrefab;
    public GameObject KeyWordList;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void InstantiatePrefab(string KeyWord)
    {
        GameObject KeyWordObject = Instantiate(KeyWordPrefab);
        //子オブジェクトのテキストをキーワードに変更
        KeyWordObject.GetComponentInChildren<Text>().text = KeyWord;

        KeyWordObject.transform.SetParent(KeyWordList.transform);

    }
    void CleanPrefab()
    {
        foreach (Transform n in KeyWordList.transform)
        {
            GameObject.Destroy(n.gameObject);
        }

    }
}
