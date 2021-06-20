using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{


       public class RotateObject : MonoBehaviour
       {
        [SerializeField] private int _speed = 60; //private kullanýsak deðiþkenimizin baþýna "_" koymak zorundayýz ve private bu kodun sadece RotateScript dosyasý içerisinden kontrol edilmesini saðlar [SerializeField] ise public yerine kullanýlýr çünkü eðer public yaparsak bu kodun her yerden eriþimini açmýþ oluruz ama [SerializeField] bu kodun daha güvenli olmasýný saðlýyor ve Unitynin içerisinden "_speed" deðiþkenimizi deðiþtirebilmemizi saðlýyor.
        
        private void Update() //Update() fonksiyonunun içersinideki kodlar her frame çalýþýrlar.
        {
            transform.Rotate(Vector3.up, _speed * Time.deltaTime);
        }
    
       }

}
