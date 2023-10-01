using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTeleporter : MonoBehaviour
{
    public Transform Upstairs;
    public Transform Downstairs;
    public GameObject XRrig;
    public OVRScreenFade ovrscreenfade;
    public bool IsUpstairs = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && IsUpstairs == false)
        {
            StartCoroutine(GoUpstair()); 
        }
        if (other.tag == "Player" && IsUpstairs == true)
        {
            StartCoroutine(GoDownstairs());
        }
    }

    public IEnumerator GoUpstair()
    {
        ovrscreenfade.FadeOut();
        yield return new WaitForSeconds(1f);
        XRrig.transform.position = Upstairs.position;
        XRrig.transform.rotation = Upstairs.rotation;
        yield return new WaitForSeconds(1f);
        ovrscreenfade.FadeIn();
        Debug.Log("go upstairs");

        //IsUpstairs = true;

    }

    public IEnumerator GoDownstairs()
    {
        ovrscreenfade.FadeOut();
        yield return new WaitForSeconds(1f);
        XRrig.transform.position = Downstairs.position;
        XRrig.transform.rotation= Downstairs.rotation;
        yield return new WaitForSeconds(1f);
        ovrscreenfade.FadeIn();
        Debug.Log("go downstairs");
        //IsUpstairs = false;

    }
}

