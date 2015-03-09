using UnityEngine;
using System.Collections;

public class MenuPowrotu : MonoBehaviour {

	public int szerokoscOkna;
	public int wysokoscOkna;
	public int wysokoscOkna2;
	public int szerokoscOkna2;
	public string obecnepolozenie;
	public GUISkin SkinMenu;
	public bool Czypokazac;
	// Use this for initialization
	void Start () {
		obecnepolozenie = "Menu powrotu";
		szerokoscOkna = 300;
		szerokoscOkna2 = szerokoscOkna - 10;
		wysokoscOkna2 = 60;
	}
	// Update is called once per frame
	void Update () {
		if (obecnepolozenie == "Menu Pauzy") {
			wysokoscOkna = wysokoscOkna2 * 4 + 35;
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (!Czypokazac) {
				Czypokazac = true;
			} else {
				Czypokazac = false;
			}

		}
	}
void OnGui()
	{
		if(obecnepolozenie=="Menu powrotu" && Czypokazac==true)
		{
				GUI.skin=SkinMenu;
				GUI.Box (new Rect (Screen.width / 2 - szerokoscOkna / 2, Screen.height / 2 - szerokoscOkna / 2, szerokoscOkna, wysokoscOkna), "");
				if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + 15, szerokoscOkna2, wysokoscOkna2), "Zapisz"))
				{
					obecnepolozenie="Podglad";
				}
				if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + wysokoscOkna2+20, szerokoscOkna2, wysokoscOkna2), "Ustawienia"))
				{
					obecnepolozenie = "Ustawienia";
				}
				if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + wysokoscOkna2*2+25, szerokoscOkna2, wysokoscOkna2), "Tworcy"))
				{
					obecnepolozenie = "Tworcy";
				}
				if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + wysokoscOkna2*3+30, szerokoscOkna2, wysokoscOkna2), "Wyjscie"))
				{
					Czypokazac=false;
		}
	}
}
	}
