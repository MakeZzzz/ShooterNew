using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class BulletsUI : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _bulletsUI;
   
   private Shooting _shooting;
   private int _bulletsCount;

   private void Start()
   {
      _bulletsUI.text = _shooting.ammunition.ToString();
   }

   [UsedImplicitly]
   public void Initialize(Shooting shooting)
   {
      _shooting = shooting;
   }
   
   [UsedImplicitly]
   public void Shoot(int bulletsCount)
   {
      if (_shooting.ammunition <= 0)
      {
         return;
      }
      _shooting.ammunition -= bulletsCount;
      _bulletsUI.text = _shooting.ammunition.ToString();
   }
}
