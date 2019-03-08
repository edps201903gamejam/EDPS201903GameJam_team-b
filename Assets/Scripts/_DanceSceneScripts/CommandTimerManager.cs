using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandTimerManager : SingletonMonoBehaviour<CommandTimerManager>
{
    [Header("Commandの制限時間。「秒」単位で設定できます。")]
    [SerializeField] private float commandInputTime = 10;
    [HideInInspector] public bool isStartTimer = false;
    [HideInInspector] public float countTime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isStartTimer)
        {
            countTime += Time.deltaTime;
            if (countTime > commandInputTime)
            {
                isStartTimer = false;
                countTime = 0;
                Debug.Log("Timer End!");
                return;
            }
        }
    }

    [ContextMenu("Test")]
    public void test_timerStart()
    {
        isStartTimer = true;
        Debug.Log("Timer Test Start");
    }

	public void timerStart()
	{
		isStartTimer = true;
		Debug.Log("Timer Test Start");
	}
}
