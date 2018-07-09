using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {
    public void Start()
    {
        XRSettings.enabled = false;
    }


	public void Changescene(string scenename)
    {
        XRSettings.enabled = true;
        SceneManager.LoadScene(scenename);
    }
}
