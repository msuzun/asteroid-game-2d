using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimSayaci : MonoBehaviour
{
    float toplamSure = 0;
    float gecenSure = 0;

    bool calisiyor = false;
    bool basladi = false;


    /// <summary>
    ///  Geri say�m sayac�n�n toplam s�resini ayarlar
    /// </summary>
    public float ToplamSure
    {
        set
        {
            if (!calisiyor)
            {
                toplamSure = value;
            }
        }
    }
    /// <summary>
    /// Geri say�m�n bitip bitmedi�ini s�yler
    /// </summary>
    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor;
        }
    }
    /// <summary>
    /// Sayac� calistirir
    /// </summary>
    public void Calistir()
    {
        if (toplamSure > 0)
        {
            calisiyor = true;
            basladi = true;
            gecenSure = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (calisiyor)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure>= toplamSure)
            {
                calisiyor = false;
            }
        }
    }
}
