using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    float collaiderBoyYarim;
    float collaiderEnYarim;
    // Start is called before the first frame update
    void Start()
    {
        //Oyun objesini rastgele bir kuvvetle hareket ettir.

        //Rigidbody2D myRigibody = GetComponent<Rigidbody2D>();
        //myRigibody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);

        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-5,5), Random.Range(-5,5)), ForceMode2D.Impulse);
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        collaiderBoyYarim = collider.size.y / 2;
        collaiderEnYarim = collider.size.x / 2;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       // Debug.Log("Kemerlerinizi baðlayýnýz");
    }
    // Update is called once per frame
    void Update()
    {
        //Astroid mouse imlecini takip etsin
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);
        //transform.position = position;
        //EkrandaKal();
    }
    void EkrandaKal()
    {
        Vector3 position = transform.position;
        if (position.x - collaiderEnYarim < EkranHesaplayicisi.Sol)
        {
            position.x = EkranHesaplayicisi.Sol + collaiderEnYarim;
        }
        else if (position.x + collaiderEnYarim > EkranHesaplayicisi.Sag)
        {
            position.x = EkranHesaplayicisi.Sag - collaiderEnYarim;
        }

        if (position.y + collaiderBoyYarim > EkranHesaplayicisi.Ust)
        {
            position.y = EkranHesaplayicisi.Ust - collaiderBoyYarim;
        }
        else if (position.y - collaiderBoyYarim < EkranHesaplayicisi.Alt)
        {
            position.y = EkranHesaplayicisi.Alt + collaiderBoyYarim;
        }
        transform.position = position;
    }
}
