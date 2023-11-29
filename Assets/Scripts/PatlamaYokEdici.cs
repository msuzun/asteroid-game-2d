using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{
    GeriSayimSayaci geriSayimSayaci;
    SiraliYokEdici siraliYokEdici;
    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        siraliYokEdici = Camera.main.GetComponent<SiraliYokEdici>();
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            siraliYokEdici.HedefiYokEt();
            Destroy(gameObject);
        }
    }
}
