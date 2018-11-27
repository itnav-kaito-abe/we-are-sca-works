using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour {

    public GameObject OperationKeyImage;
    private Animator animator;

	// Use this for initialization
	void Start () {
		OperationKeyImage = GameObject.Find("Canvas").gameObject.transform.Find("OperationKeyImage").gameObject;
        animator = transform.parent.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            OperationKeyImage = GameObject.Find("Canvas").gameObject.transform.Find("OperationKeyImage").gameObject;

            OperationKeyImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Syutoku");

            OperationKeyImage.GetComponent<Image>().preserveAspect = true;

            OperationKeyImage.GetComponent<Image>().SetNativeSize();

            OperationKeyImage.SetActive(true);
        }
    }

    public void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player") {
            GameObject EastDoor = GameObject.Find("EastDoor");

            if (Input.GetKeyDown(KeyCode.H)) {
                animator.SetBool("Open",!animator.GetBool("Open"));
            }
        }
    }

}
