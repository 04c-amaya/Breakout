
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameObject launcherObjectLink;
    Launcher launcherScriptLink;
    GameObject soundObjectLink;
    Sound soundScriptLink;

    // Start is called before the first frame update

    void Start()

    {
        launcherObjectLink = GameObject.Find("Launcher");
        launcherScriptLink = launcherObjectLink.GetComponent<Launcher>();
        soundObjectLink = GameObject.Find("Sound Manager");
        soundScriptLink = soundObjectLink.GetComponent<Sound>();
        soundScriptLink.PlaySound("BarrierSide");
    }

    // Update is called once per frame

    void Update()

    {
    }


    private void OnCollisionEnter2D(Collision2D collision)

    {
        var hitObject = collision.gameObject;
        var hitTag = hitObject.tag;
        soundScriptLink.PlaySound(hitTag);

        if (hitTag.Contains("Block"))

        {
            Destroy(hitObject);

        }

        else if (hitTag.Contains("Bottom"))

        {
            launcherScriptLink.resetBall = true;
            Destroy(gameObject);

        }
    }
}