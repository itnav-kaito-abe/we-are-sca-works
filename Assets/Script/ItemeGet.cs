using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemeGet : MonoBehaviour {

    public GameObject OperationKeyImage;

	// Use this for initialization
	void Start () {
	    OperationKeyImage = GameObject.Find("Canvas").gameObject.transform.Find("OperationKeyImage").gameObject;
        OperationKeyImage.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "key") {
            OperationKeyImage = GameObject.Find("Canvas").gameObject.transform.Find("OperationKeyImage").gameObject;

            OperationKeyImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Syutoku");

            OperationKeyImage.GetComponent<Image>().preserveAspect = true;

            OperationKeyImage.GetComponent<Image>().SetNativeSize();

            OperationKeyImage.SetActive(true);
        }
    }

    public void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "key") {
            GameObject key = GameObject.Find("key");

            if (Input.GetKeyDown(KeyCode.H)) {
                Destroy(key);
                OperationKeyImage.SetActive(false);
            }
        }
    }

    public void OnTriggerExit(Collider other) {
        OperationKeyImage = GameObject.Find("Canvas").gameObject.transform.Find("OperationKeyImage").gameObject;
        OperationKeyImage.SetActive(false);
    }
}
