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

    


    void Start()
    {

        LvL4Menu = LvL4Menu.GetComponent <Canvas>();
        Wlasne = Wlasne.GetComponent <Canvas>();
        objM = objM.GetComponent<Menu>();
        timerTxt = timerTxt.GetComponent<Text>();
        timerTxt.enabled = false;
        l4S = l4S.GetComponent<LvL4Script>();
        objM.ogienLvL4[0].SetActive(false);
        objM.ogienLvL4[1].SetActive(false);
        objM.ogienLvL4[2].SetActive(false);
        objM.ogienLvL4[3].SetActive(false);
        objM.ogienLvL4[4].SetActive(false);
        objM.ogienLvL4[5].SetActive(false);
        objM.ogienLvL4[6].SetActive(false);
        objM.ogienLvL4[7].SetActive(false);
        objM.ogienLvL4[8].SetActive(false);
        objM.ogienLvL4[9].SetActive(false);
        objM.ogienLvL4[10].SetActive(false);
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
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled); 
        }
        else if ((int)iloscZ == 2)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
        } 
        else if ((int)iloscZ == 3)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 4)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
        }    
        else if ((int)iloscZ == 5)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 6)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 7)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
        }      
        else if ((int)iloscZ == 8)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
        }       
        else if ((int)iloscZ == 9)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[8].SetActive(isActiveAndEnabled);
        }   
        else if ((int)iloscZ == 10)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[8].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[9].SetActive(isActiveAndEnabled);
        }     
        else if ((int)iloscZ == 11)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[8].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[9].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[10].SetActive(isActiveAndEnabled);
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

        timerTxt.enabled = true;
        Time.timeScale = 1;

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
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 2)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 3)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 4)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 5)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 6)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 7)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 8)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 9)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[8].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 10)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[8].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[9].SetActive(isActiveAndEnabled);
        }
        else if ((int)iloscZ == 11)
        {
            objM.ogienLvL4[0].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[1].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[2].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[3].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[4].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[5].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[6].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[7].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[8].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[9].SetActive(isActiveAndEnabled);
            objM.ogienLvL4[10].SetActive(isActiveAndEnabled);
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

        timerTxt.enabled = true;
        Time.timeScale = 1;
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
