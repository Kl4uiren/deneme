using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DenemeGrup //objelerimizi k�saca grupland�r�yor
{
    public class FirstScript : MonoBehaviour


    {
         public int tamSayi = 1;           //integar uzun bir say� skalas�na kadar gidiyor bunu g�rmek i�in int.MaxValue
         [SerializeField] float ondalikSayi = 1.25f; //float ondal�k say�lar� belirtmek i�in kullan�l�r
         public bool dogruYanlis = true;          // false veya true olabilir 
         public bool dogruYanlis2 = false;        /// <-- comment kod uygulamaya ge�erken etki etmez 



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