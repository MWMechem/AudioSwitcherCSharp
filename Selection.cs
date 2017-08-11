using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    private GameObject lastSelected = null; // store last selected object reference
    public bool audioplayer = false;
    public AudioClip audio3;
    public AudioClip audio2;
    public AudioClip audio1;
    //public AudioSource[] shuffles;

        
    void Awake()
    {
        //shuffles[0] = audio1;
      //  shuffles[1] = audio2;
       // shuffles[2] = audio3;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if LMB clicked
            bool truHit = false;
            RaycastHit raycastHit = new RaycastHit(); // create new raycast hit info object
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit))
            { // create ray from screen's mouse position to world and store info in raycastHit object
                if (raycastHit.collider.tag == "Yup")
                { // we just want to hit objects tagged with "yup"
                    truHit = true; // yup, we hit it!
                }
            }

            Deselect(lastSelected); // deselect last hit object
            if (truHit)
                Select(raycastHit.collider.gameObject); // select new cube
        }
    }

    private void Select(GameObject g)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (audioplayer ==true)
        {
            audio.Stop();
            audioplayer = false;
        }
        else
        {
            var num = Random.Range(0, 3);
            if (num == 0)
            {
                audio.PlayOneShot(audio1);
            }
            else if (num == 1)
            {
                audio.PlayOneShot(audio2);
            }
            else
            {
                audio.PlayOneShot(audio3);
            }
            audioplayer = true;
        }
    }

    private void Deselect(GameObject g)
    {
        
    }
}