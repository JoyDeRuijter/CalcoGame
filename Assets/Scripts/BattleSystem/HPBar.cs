using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField] private GameObject healthObject;

    public void SetHP(float _normalizedHP)
    {
        healthObject.transform.localScale = new Vector3(_normalizedHP, 1f, 0f);
    }
}
