using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanceScene;

public class TweetClick : MonoBehaviour
{
    public void OnClick()
    {
		var tweetText = "あなたのライブの点数は"+ DanceSceneManager.CORRECT_COUNT*100 +"点！！！";
		Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(tweetText + " #EDPS_201903_GameJam"));
        //Application.OpenURL("https://twitter.com/intent/tweet?text="+tweetText+"&hashtags=EDPS_201903_GameJam,akazukin_game");
    }
}
