using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsScript : MonoBehaviour
{
	float i;
	float j;
	float k;
	float l;
	float m;

	Button Face;
	Button Body;
	Button Hand;
	Button Legs;
	Button Other;

	Button FaceLine;
	Button Eye;
	Button Nose;
	Button Brows;
	Button Mouse;
	Button Set1;
	public Button Parts1;

    public bool EyeTrigger = false;

    // Use this for initialization
    void Start()
    {
		Face = GameObject.Find("Canvas/FirstSelect/Face").GetComponent<Button>();
		Body = GameObject.Find("Canvas/FirstSelect/Body").GetComponent<Button>();
		Hand = GameObject.Find("Canvas/FirstSelect/Hand").GetComponent<Button>();
		Legs = GameObject.Find("Canvas/FirstSelect/Legs").GetComponent<Button>();
		Other = GameObject.Find("Canvas/FirstSelect/Other").GetComponent<Button>();

		FaceLine = GameObject.Find("Canvas/FirstSelect/FaceLine").GetComponent<Button>();
		Eye = GameObject.Find("Canvas/FirstSelect/Eye").GetComponent<Button>();
		Nose = GameObject.Find("Canvas/FirstSelect/Nose").GetComponent<Button>();
		Brows = GameObject.Find("Canvas/FirstSelect/Brows").GetComponent<Button>();
		Mouse = GameObject.Find("Canvas/FirstSelect/Mouse").GetComponent<Button>();
		Set1 = GameObject.Find("Canvas/PartsSelect/Set1").GetComponent<Button>();
    }

    void Update()
    {
        if (EyeTrigger)
        {
			i = FaceLine.transform.position.x;
			j = Eye.transform.position.x;
			k = Nose.transform.position.x;
			l = Brows.transform.position.x;
			m = Mouse.transform.position.x;

			FaceLine.transform.position = new Vector3(-200, FaceLine.transform.position.y, 0);
			Eye.transform.position = new Vector3(-200, Eye.transform.position.y, 0);
			Nose.transform.position = new Vector3(-200, Nose.transform.position.y, 0);
			Brows.transform.position = new Vector3(-200, Brows.transform.position.y, 0);
			Mouse.transform.position = new Vector3(-200, Mouse.transform.position.y, 0);

			Face.transform.position = new Vector3(i, FaceLine.transform.position.y, 1);
			Body.transform.position = new Vector3(j, Eye.transform.position.y, 0);
			Hand.transform.position = new Vector3(k, Nose.transform.position.y, 0);
			Legs.transform.position = new Vector3(l, Brows.transform.position.y, 0);
			Other.transform.position = new Vector3(m, Mouse.transform.position.y, 0);

			Parts1.transform.position = new Vector3(Set1.transform.position.x,Set1.transform.position.y, 0);
        }
		EyeTrigger = false;
    }

    public void OnClick()
    {
        Debug.Log("clicked");
        EyeTrigger = true;
    }
}
