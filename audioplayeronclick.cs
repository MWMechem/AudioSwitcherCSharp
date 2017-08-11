using UnityEngine;
using System.Collections;

public class audioplayeronclick : MonoBehaviour {
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
   void update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }

}