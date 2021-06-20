using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{


       public class RotateObject : MonoBehaviour
       {
        [SerializeField] private int _speed = 60; //private kullan�sak de�i�kenimizin ba��na "_" koymak zorunday�z ve private bu kodun sadece RotateScript dosyas� i�erisinden kontrol edilmesini sa�lar [SerializeField] ise public yerine kullan�l�r ��nk� e�er public yaparsak bu kodun her yerden eri�imini a�m�� oluruz ama [SerializeField] bu kodun daha g�venli olmas�n� sa�l�yor ve Unitynin i�erisinden "_speed" de�i�kenimizi de�i�tirebilmemizi sa�l�yor.
        
        private void Update() //Update() fonksiyonunun i�ersinideki kodlar her frame �al���rlar.
        {
            transform.Rotate(Vector3.up, _speed * Time.deltaTime);
        }
    
       }

}
