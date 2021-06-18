using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DenemeGrup //objelerimizi kýsaca gruplandýrýyor
{
    public class FirstScript : MonoBehaviour


    {
         public int tamSayi = 1;           //integar uzun bir sayý skalasýna kadar gidiyor bunu görmek için int.MaxValue
         [SerializeField] float ondalikSayi = 1.25f; //float ondalýk sayýlarý belirtmek için kullanýlýr
         public bool dogruYanlis = true;          // false veya true olabilir 
         public bool dogruYanlis2 = false;        /// <-- comment kod uygulamaya geçerken etki etmez 



        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}