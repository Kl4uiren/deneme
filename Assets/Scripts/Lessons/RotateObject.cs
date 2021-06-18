using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{



   public class NewBehaviourScript : MonoBehaviour
   {
        [SerializeField] private float _speed = 1.25f; //private kullanýrsak bu deðiþkene sadece rotate object scriptinden eriþebiliriz public yaparsak herhangi bir scriptten buraya eriþim saðlayabiliriz [SerializeField] kullanýmý public kullanýmýna göre önem arz etmektedir çünkü daha güvenlidir.
   } 
}