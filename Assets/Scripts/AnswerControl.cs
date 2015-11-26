using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerControl : MonoBehaviour {


    int[][] listjawaban = new int[][]{
        new int[]{0, 0, 1, 0}, //kotak1
        new int[]{0, 0, 0, 1}, //kotak3
        new int[]{0, 1, 0, 0}, //kotak5
        new int[]{0, 0, 1, 0}, //kotak7
        new int[]{0, 1, 0, 0}, //kotak8
        new int[]{1, 0, 0, 0}, //kotak10
        new int[]{1, 0, 0, 0}, //kotak11
        new int[]{0, 0, 0, 1}, //kotak13
        new int[]{0, 0, 1, 0}, //kotak15
        new int[]{1, 0, 0, 0}, //kotak16
        new int[]{0, 1, 0, 0}, //kotak17
        new int[]{0, 0, 0, 1}, //kotak19
        new int[]{0, 1, 0, 0}, //kotak20
        new int[]{0, 0, 0, 1}, //kotak21
        new int[]{0, 1, 0, 0}, //kotak22
        new int[]{1, 0, 0, 0}  //kotak23
    };

    string[][] listtextjawaban = new string[][]{
        new string[]{"Telur", "Kupu-kupu", "Pupa", "Ulat"}, //kotak1
        new string[]{"Herbivora", "Mamalia", "Fertilisasi Internal", "Fertilisasi External"}, //kotak3
        new string[]{"Berekor", "Omnivora", "Herbivora", "Panjang kaki = tangan"}, //kotak5
        new string[]{"Kuda", "Gajah", "Singa", "Keledai"}, //kotak7
        new string[]{"Rake", "Shovel", "Hammer", "Crowbar"}, //kotak8
        new string[]{"BKR", "Marinir", "Kopasus", "TNI"}, //kotak10
        new string[]{"Akar", "Batang", "Daun", "Buah"}, //kotak11
        new string[]{"Vietnam", "Indonesia", "Malaysia", "Singapura"}, //kotak13
        new string[]{"Akar Panjang", "Daun Berduri", "Batang Lilin", "Jaringan Spons"}, //kotak15
        new string[]{"Mars", "Jupiter", "Venus", "Bumi"}, //kotak16
        new string[]{"Italy", "Prancis", "Paris", "Spanyol"}, //kotak17
        new string[]{"Dom", "Paul Walker", "William Lennox", "Sam Witwicky"}, //kotak19
        new string[]{"Atlanta", "Pisa", "Italia", "Roma"}, //kotak20
        new string[]{"Airbus A380", "Boeing 767", "Boeing 777", "Boeing 747"}, //kotak21
        new string[]{"2 Serambi 2 Bilik", "4 Bilik", "2 Atrium 1 Ventrikel", "3 Bilik"}, //kotak22
        new string[]{"2 Serambi 1 Bilik", "2 Serambi 2 Bilik", "Tidak Punya Kloaka", "Berdarah Panas"} //kotak23
    };
    
    int soalsekarang;
    int jawabansekarang;
    Text jawaban;

    // Use this for initialization
    void Start(int noSoal)
    {
        soalsekarang = noSoal;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Button Soal
    public void Soal1()
    {
        jawabansekarang = 0;
        jawaban = GameObject.Find("Pilihan1").GetComponent<Text>();
        jawaban.text = listtextjawaban[jawabansekarang][0];
        jawaban = GameObject.Find("Pilihan2").GetComponent<Text>();
        jawaban.text = listtextjawaban[jawabansekarang][1];
        jawaban = GameObject.Find("Pilihan3").GetComponent<Text>();
        jawaban.text = listtextjawaban[jawabansekarang][2];
        jawaban = GameObject.Find("Pilihan4").GetComponent<Text>();
        jawaban.text = listtextjawaban[jawabansekarang][3];
    }

    //Button Jawaban A
    public void klikA()
    {
        int idx = 0;
        int isTrue = listjawaban[soalsekarang][idx];
        Check(isTrue);
    }

    //Button Jawaban B
    public void klikB()
    {
        int idx = 1;
        int isTrue = listjawaban[soalsekarang][idx];
        Check(isTrue);
    }

    //Button Jawaban C
    public void klikC()
    {
        int idx = 2;
        int isTrue = listjawaban[soalsekarang][idx];
        Check(isTrue);
    }

    //Button Jawaban D
    public void klikD()
    {
        int idx = 3;
        int isTrue = listjawaban[soalsekarang][idx];
        Check(isTrue);
    }
    
    //Action Check Jawaban
    public void Check(int isTrue)
    {
        if (isTrue == 1)
            Debug.Log("benar");
        else if (isTrue == 0)
            Debug.Log("salah");
    }

    
}
