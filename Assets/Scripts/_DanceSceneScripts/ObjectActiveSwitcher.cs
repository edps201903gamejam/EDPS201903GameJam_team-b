using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace akazukin_omochabako
{
    public class ObjectActiveSwitcher : MonoBehaviour
    {
        public int activeIndexNumber;

        [SerializeField] private int firstObjectInidex;

        //オブジェクトの設定ファイル
        [Serializable]
        private class gameObjectSettings
        {
            public ObjectActiveSwitcher _objectActiveSwitcher;

            private int myIndex;

            //On/offを切り替える対象GameObject
            public GameObject _targetObject;

            //FunctionKeyを使うかどうかのbool
            public bool useFunc;
            public KeyCode FunctionKey;


            //どのキーを押したらカメラが切り替わるか
            public KeyCode activeOnKey;

            //GameObjectごとにIndexNumberをつけて管理する。
            public void _start(int _myIndex)
            {
                myIndex = _myIndex;
            }

            //Keyの入力をチェックする
            public void KeyCheck()
            {
                //重い(確信)
                if (useFunc)
                {
                    //ActionKeyを押したらGameObjectをTrueにする
                    if (Input.GetKeyDown(activeOnKey) && Input.GetKey(FunctionKey))
                    {
                        _targetObject.SetActive(true);
                        _objectActiveSwitcher.gameObjectSettingses[_objectActiveSwitcher.activeIndexNumber].ObjectOff();
                        _objectActiveSwitcher.activeIndexNumber = myIndex;
                    }
                }
                else if (!useFunc)
                {
                    //ActionKeyを押したらGameObjectをTrueにする
                    if (Input.GetKeyDown(activeOnKey))
                    {
                        _targetObject.SetActive(true);
                        _objectActiveSwitcher.gameObjectSettingses[_objectActiveSwitcher.activeIndexNumber].ObjectOff();
                        _objectActiveSwitcher.activeIndexNumber = myIndex;
                    }
                }
            }

            public void ObjectOff()
            {
                _targetObject.SetActive(false);
            }
        }

        [SerializeField] private List<gameObjectSettings> gameObjectSettingses;



        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < gameObjectSettingses.Count; i++)
            {
                gameObjectSettingses[i]._start(i);
            }

            //初期化
            activeIndexNumber = firstObjectInidex;
            for (int i = 0; i < gameObjectSettingses.Count; i++)
            {
                if (i == firstObjectInidex)
                {
                    gameObjectSettingses[i]._targetObject.SetActive(true);
                }
                else if (i != firstObjectInidex)
                {
                    gameObjectSettingses[i]._targetObject.SetActive(false);
                }
            }

            StartCoroutine(_update());
        }

        // Update is called once per frame
        void Update()
        {

        }

        //gameObjectSettingsのKeyCheckを実行
        //この処理の書き方絶対間違ってるのでレビューしてほしい
        private IEnumerator _update()
        {
            while (true)
            {
                for (int i = 0; i < gameObjectSettingses.Count; i++)
                {
                    gameObjectSettingses[i].KeyCheck();
                }

                yield return null;
            }
        }

    }

}