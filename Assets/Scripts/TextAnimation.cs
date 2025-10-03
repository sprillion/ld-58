using System;
using DG.Tweening;
using UnityEngine;

public class TextAnimation : MonoBehaviour
{
   private void Awake()
   {
      transform.DOScale(1.3f, 0.7f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InQuad);
      //Для теста
   }
}
