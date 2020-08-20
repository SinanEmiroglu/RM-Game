﻿using DG.Tweening;
using System.Collections;
using UnityEngine;

namespace Methodyca.Minigames.Questioniser
{
    public class PointConverter : ActionCard
    {
        [Header("PointConverter Attributes")]
        [SerializeField] int affectedActionPoint = 5;
        [SerializeField] int affectedInterestPoint = -10;

        protected override void OnMouseUp()
        {
            if (!IsClickable)
                return;
            base.OnMouseUp();

            if (GameManager.Instance.InterestPoint >= Mathf.Abs(affectedInterestPoint) + InterestPoint)
            {
                Throw();
            }
            else
            {
                ReturnHand();
                GameManager.Instance.RaiseGameMessage("Not enough interest points");
            }
        }

        protected override void Throw()
        {
            StartCoroutine(ThrowCoroutine());
        }

        IEnumerator ThrowCoroutine()
        {
            TriggerCardIsThrown((ActionCard)this);
            Sequence throwSeq = DOTween.Sequence();
            yield return throwSeq.Append(_transform.DOMove(_table.GetTransform.position + _thrownLocation, 0.25f))
                .Join(_transform.DORotate(new Vector3(0, 360, 0), 0.25f))
                .AppendCallback(() => GameManager.Instance.SwitchInterestToActionPoint(affectedInterestPoint, affectedActionPoint)).WaitForCompletion();
            Destroy(gameObject);
        }
    }
}