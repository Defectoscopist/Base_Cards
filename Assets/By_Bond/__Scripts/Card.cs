using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [Header("Set Dynamically")]
    public string suit; // ����� (C, D, H ��� S)
    public int rank; // ����������� �����
    public Color color = Color.black; // ���� �������
    public string colS = "Black"; // ��� "Red" - ���� �����,
    public List<GameObject> decoGOs = new List<GameObject>(); // ��� �������� ���� Decorator
    public List<GameObject> pipGOs = new List<GameObject>(); // ��� �������� ���� Pip

    public GameObject back; // �������
    public CardDefinition def; // ����������� �� DeckXML.xml

    // ������������ ������ �����������
    public bool faceUp
    {
        get { return (!back.activeSelf); }
        set { back.SetActive(!value); }
    }
}

[System.Serializable]
public class Decorator
{ // ������ ���������� �� DeckXML � ������ ������ �����
    public string type; // ����������� �����
    public Vector3 loc; // ��������� ������� �� �����
    public bool flip = false; // ��������� �����
    public float scale = 1f; // ������� �������
}

[System.Serializable]
public class CardDefinition
{ // ���������� � ����������� �����
    public string face; // ������ ������� ������� �����
    public int rank; // ����������� �����
    public List<Decorator> pips = new List<Decorator>(); // ������
}