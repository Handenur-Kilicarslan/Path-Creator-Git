using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour
{
    public Transform oyuncu; // transform bir data type float, int gibi.
   
    public Vector3 offset;     //3 vektörlü konum bilgisi? (offset= dengeleme, denkleştirme)


    void Update()
    {
        // Debug.Log(oyuncu.position); //console log'da Küpün konumunu görüyoruz.

        transform.position = oyuncu.position + offset;
        // transform.rotation = oyuncu.rotation;
        //Kamera pozisyonu oyuncu pozisyonu + belirlediğimiz vektörel konum ile toplanarak eşlendi .

    }
}
