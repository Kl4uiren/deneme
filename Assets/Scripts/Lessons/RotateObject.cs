using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{



   public class NewBehaviourScript : MonoBehaviour
   {
        [SerializeField] private float _speed = 1.25f; //private kullan�rsak bu de�i�kene sadece rotate object scriptinden eri�ebiliriz public yaparsak herhangi bir scriptten buraya eri�im sa�layabiliriz [SerializeField] kullan�m� public kullan�m�na g�re �nem arz etmektedir ��nk� daha g�venlidir.
   } 
}