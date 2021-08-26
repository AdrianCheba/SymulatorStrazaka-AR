using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvL4WScript : MonoBehaviour
{
    public Canvas LvL4Menu;
    public Canvas Wlasne;
    public Menu objM;
    public Text timerTxt;
    public LvL4Script l4S;

    public float czas;
    public float iloscZ;
    public float rozmiarP;
    public float srodkiG;
    public float czasM;
    public float czasS;

    public Text czasTxt;
    public Text mocP;
    public Text IPZ;
    public Text ISG;

    public float lczas;
    


    void Start()
    {

        LvL4Menu = LvL4Menu.GetComponent <Canvas>();
        Wlasne = Wlasne.GetComponent <Canvas>();
        objM = objM.GetComponent<Menu>();
        timerTxt = timerTxt.GetComponent<Text>();
        timerTxt.enabled = false;
        l4S = l4S.GetComponent<LvL4Script>();
        objM.ogienLvL4.SetActive(false);
        objM.ogienLvL42.SetActive(false);
        objM.ogienLvL43.SetActive(false);
        objM.ogienLvL44.SetActive(false);
        objM.ogienLvL45.SetActive(false);
        objM.ogienLvL46.SetActive(false);
        objM.ogienLvL47.SetActive(false);
        objM.ogienLvL48.SetActive(false);
        objM.ogienLvL49.SetActive(false);
        objM.ogienLvL410.SetActive(false);
        objM.ogienLvL411.SetActive(false);

        czasTxt = czasTxt.GetComponent<Text>();
        mocP = mocP.GetComponent<Text>();
        IPZ = IPZ.GetComponent<Text>();
        ISG = ISG.GetComponent<Text>();

       
    }

  
    void Update()
    {
        if (timerTxt.enabled == true)
        {
            if (czas > 0.1f)
            {
                czas -= Time.deltaTime;
                czasM = Mathf.FloorToInt(czas / 60);
                czasS = Mathf.FloorToInt(czas % 60);
                timerTxt.text = "" + (int)czasM + " : " + (int)czasS;
            }
        }

        czasTxt.text = "" + (int)czas + " s";
        mocP.text = "" + (int)rozmiarP;
        IPZ.text = "" + (int)iloscZ;
        ISG.text = "" + (int)srodkiG;
    }

    public void btnWlasne()
    {
        LvL4Menu.enabled = false;
        Wlasne.enabled = true;
        
    }
    
    public void btnRozpoczecie()
    {
        Wlasne.enabled = false;
        objM.BtnEQ.enabled = true;
        objM.LvL4.SetActive(isActiveAndEnabled);
        objM.LvL4H.SetActive(isActiveAndEnabled);

        if ((int)iloscZ == 1)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 2)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
        } 
        else if ((int)iloscZ == 3)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 4)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
        }    
        else if ((int)iloscZ == 5)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 6)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 7)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
        }      
        else if ((int)iloscZ == 8)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
        }       
        else if ((int)iloscZ == 9)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
            objM.ogienLvL49.SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 10)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
            objM.ogienLvL49.SetActive(isActiveAndEnabled);
            objM.ogienLvL410.SetActive(isActiveAndEnabled);
        }     
        else if ((int)iloscZ == 11)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
            objM.ogienLvL49.SetActive(isActiveAndEnabled);
            objM.ogienLvL410.SetActive(isActiveAndEnabled);
            objM.ogienLvL411.SetActive(isActiveAndEnabled);
        }


        l4S.O1.startSize = rozmiarP;
        l4S.O2.startSize = rozmiarP;
        l4S.O3.startSize = rozmiarP;
        l4S.O4.startSize = rozmiarP;
        l4S.O5.startSize = rozmiarP;
        l4S.O6.startSize = rozmiarP * 2;
        l4S.O7.startSize = rozmiarP * 2;
        l4S.O8.startSize = rozmiarP * 2;
        l4S.O9.startSize = rozmiarP * 2;
        l4S.O10.startSize = rozmiarP * 2;
        l4S.O11.startSize = rozmiarP * 2;


        objM.iloscPiany = srodkiG;
        objM.iloscPiany2 = srodkiG;

        l4S.btnGP.gameObject.SetActive(false);
        l4S.btnW.gameObject.SetActive(false);
        l4S.btnGZ.gameObject.SetActive(false);

        timerTxt.enabled = true;
        Time.timeScale = 1;

        lczas = czas;

    }

    public void Losuj()
    {
        Wlasne.enabled = false;
        objM.BtnEQ.enabled = true;
        objM.LvL4.SetActive(isActiveAndEnabled);
        objM.LvL4H.SetActive(isActiveAndEnabled);

        czas = Random.Range(30, 120);

        int iloscR = Random.Range(1, 12);
        iloscZ = iloscR;

        if ((int)iloscZ == 1)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 2)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 3)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 4)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 5)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 6)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 7)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 8)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 9)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
            objM.ogienLvL49.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 10)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
            objM.ogienLvL49.SetActive(isActiveAndEnabled);
            objM.ogienLvL410.SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 11)
        {
            objM.ogienLvL4.SetActive(isActiveAndEnabled);
            objM.ogienLvL42.SetActive(isActiveAndEnabled);
            objM.ogienLvL43.SetActive(isActiveAndEnabled);
            objM.ogienLvL44.SetActive(isActiveAndEnabled);
            objM.ogienLvL45.SetActive(isActiveAndEnabled);
            objM.ogienLvL46.SetActive(isActiveAndEnabled);
            objM.ogienLvL47.SetActive(isActiveAndEnabled);
            objM.ogienLvL48.SetActive(isActiveAndEnabled);
            objM.ogienLvL49.SetActive(isActiveAndEnabled);
            objM.ogienLvL410.SetActive(isActiveAndEnabled);
            objM.ogienLvL411.SetActive(isActiveAndEnabled);
        }


        l4S.O1.startSize = Random.Range(5,15);
        l4S.O2.startSize = Random.Range(5, 15);
        l4S.O3.startSize = Random.Range(5, 15);
        l4S.O4.startSize = Random.Range(5, 15);
        l4S.O5.startSize = Random.Range(5, 15);
        l4S.O6.startSize = Random.Range(10, 29);
        l4S.O7.startSize = Random.Range(10, 29);
        l4S.O8.startSize = Random.Range(10, 29);
        l4S.O9.startSize = Random.Range(10, 29);
        l4S.O10.startSize = Random.Range(10, 29);
        l4S.O11.startSize = Random.Range(10, 29);


        objM.iloscPiany = Random.Range(5, 16);
        objM.iloscPiany2 = Random.Range(5, 16);

        l4S.btnGP.gameObject.SetActive(false);
        l4S.btnW.gameObject.SetActive(false);
        l4S.btnGZ.gameObject.SetActive(false);

        timerTxt.enabled = true;
        Time.timeScale = 1;
        lczas = czas;
    }

    public void NowyCzas(float nowyCzas)
    {
        czas = nowyCzas;
    }

    public void NowaIlosc(float nowaIlosc)
    {
        iloscZ = nowaIlosc;
    }

    public void NowyRozmiar(float nowyRozmiar)
    {
        rozmiarP = nowyRozmiar;
    }

    public void NoweSrodki(float noweSrodki)
    {
        srodkiG = noweSrodki;
    }

}
