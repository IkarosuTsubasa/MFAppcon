﻿using UnityEngine;
using System.Collections;

public class NPCPush : MonoBehaviour
{
    public GameObject[] NPCs;
    public Transform NPCParent;

    public GameObject QuestionIcon;
    public GameObject NPCObject;
    void Start()
    {
        NPCParent = this.gameObject.transform;
        if (Random.Range(0, 10) == 0)
        {
            InstantiateNPC();
        }
    }

    void InstantiateNPC()
    {
        int NPCNumber = Random.Range(0, NPCs.Length);
        NPCObject = Instantiate(NPCs[NPCNumber]);
        NPCObject.transform.position = new Vector3((NPCParent.position.x + Random.Range(10, 20)), 2, (NPCParent.position.z + Random.Range(10, 20)));
        NPCObject.transform.localScale = new Vector3(8, 8, 8);
        Animator animator = NPCObject.GetComponent<Animator>();
        animator.SetBool("IsWalk", false);
        animator.SetBool("Set", true);
        GameObject Qustion = Instantiate(QuestionIcon);
        Qustion.transform.SetParent(NPCObject.transform);
        Qustion.transform.localPosition = new Vector3(0, 3, 0);
        Qustion.transform.localScale = new Vector3(1, 1, 1);
    }

}
