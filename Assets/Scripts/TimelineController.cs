using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public GameObject imageTarget;

    public void Play() 
    {
      playableDirector.Play();
    }

    public void Stop()
    {
      playableDirector.Stop();
    }

    public void Update()
    {
      // If the image target is detected, play the timeline. Else, stop the timeline.
      // if(imageTarget.GetComponent<DefaultTrackableEventHandler>().mTrackedObjFound)
      //   Play();
      // else
      //   Stop();
    }
}
