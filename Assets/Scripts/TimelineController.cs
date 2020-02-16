using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public List<TimelineAsset> timelines;

    public bool isTrent = false;
    public bool isUltrasonic = false;

    public void Play() 
    {
      playableDirector.Play();
    }

    public void Stop()
    {
      playableDirector.Stop();
    }

    public void PlayFromTimelines(int index) 
    {
      TimelineAsset selectedAsset;

      if(timelines.Count <= index)
      {
        selectedAsset = timelines[timelines.Count - 1];
      }
      else 
      {
        if(isTrent && isUltrasonic)
        {
          selectedAsset = timelines[1];
        } 
        else
          selectedAsset = timelines[0];
      }

      playableDirector.Play(selectedAsset);
    }

    public void setIsTrent(bool b) 
    {
      isTrent = b;
    }

    public void setIsUltrasonic(bool b) 
    {
      isUltrasonic = b;
    }
}
