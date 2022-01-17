using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{

    [SerializeField]
    private PlayableDirector timeline;


    void Update()
    {

        //Play and Pause
        if (Input.GetKeyDown(KeyCode.P))
        {

            Debug.Log("Play/Pause");

            if(timeline.state == PlayState.Playing)
            {
                timeline.Pause();
            } else if (timeline.state == PlayState.Paused)
            {
                timeline.Play();
            }

        }

        //Stop and Reset
        if (Input.GetKeyDown(KeyCode.R))
        {

            Debug.Log("Reset");

            timeline.Stop();
            timeline.time = 0;
            timeline.Evaluate();

        }

    }
}
