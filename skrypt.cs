using UnityEngine;
using System.Collections;

public class skrypt : MonoBehaviour {
	public int szerokoscOkna;
	public int wysokoscOkna;
	public int wysokoscOkna2;
	public int szerokoscOkna2;
	public string obecnepolozenie;
	public GUISkin SkinMenu;
	public bool Czypokazac;
	// Use this for initialization
	void Start () {
		szerokoscOkna = 300;
		szerokoscOkna2 = szerokoscOkna - 10;
		wysokoscOkna2 = 60;
		obecnepolozenie = "Menu Glowne";
		Czypokazac=true;
	}
	
	// Update is called once per frame
	void Update () {
	if (obecnepolozenie == "Menu Glowne") 
		{
			wysokoscOkna = wysokoscOkna2 * 4 + 35;
		}
		if (obecnepolozenie == "Podglad")
		{
			wysokoscOkna=wysokoscOkna2*3 +30;
		}
		if (obecnepolozenie == "Wyjscie") 
		{
			wysokoscOkna=wysokoscOkna2*2 +45;
		}
	}
	void OnGUI(){
		if (obecnepolozenie == "Menu Glowne" && Czypokazac==true) 
		{
			GUI.skin=SkinMenu;
			GUI.Box (new Rect (Screen.width / 2 - szerokoscOkna / 2, Screen.height / 2 - szerokoscOkna / 2, szerokoscOkna, wysokoscOkna), "");
			if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + 15, szerokoscOkna2, wysokoscOkna2), "Podglad"))
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
				obecnepolozenie = "Wyjscie";
			}
		}
		if(obecnepolozenie=="Podglad")
		{
			GUI.skin=SkinMenu;
			GUI.Box (new Rect (Screen.width / 2 - szerokoscOkna / 2, Screen.height / 2 - szerokoscOkna / 2, szerokoscOkna, wysokoscOkna), "");
			if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + 15, szerokoscOkna2, wysokoscOkna2), "Nowy Projekt"))
			{
				Application.LoadLevel(1);
			}
			if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + wysokoscOkna2+20, szerokoscOkna2, wysokoscOkna2), "Szablony"))
			{
				Application.LoadLevel(1);
			}
			if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + wysokoscOkna2*2+25, szerokoscOkna2, wysokoscOkna2), "Powrot"))
			{
				obecnepolozenie = "Menu Glowne";
			}
		}
		if (obecnepolozenie == "Wyjscie") 
		{
			Czypokazac=false;
			GUI.skin=SkinMenu;
			GUI.Box (new Rect (Screen.width / 2 - szerokoscOkna / 2, Screen.height / 2 - szerokoscOkna / 2, szerokoscOkna, wysokoscOkna), "");
			GUI.Box (new Rect (Screen.width / 2 - szerokoscOkna / 2, Screen.height / 2 - szerokoscOkna / 2, szerokoscOkna, 30), "Czy na pewno chcesz wyjsc");
			if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + 35, szerokoscOkna2, wysokoscOkna2), "Tak"))
			{
				Application.Quit ();
			}
			if (GUI.Button (new Rect (Screen.width / 2 - szerokoscOkna / 2+5, Screen.height / 2 - szerokoscOkna / 2 + wysokoscOkna2+40, szerokoscOkna2, wysokoscOkna2), "Nie"))
			{
				obecnepolozenie="Menu Glowne";
				Czypokazac=true;
			}
		}
		
	
}
}











